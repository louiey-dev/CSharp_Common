using System.Collections;
using System.Diagnostics;
using System.IO.Ports;

namespace CSharp_Common
{
    public partial class Form1 : Form
    {
        String termOutput = "";
        Process puttyProcess = null;
        StreamWriter puttyCmdStreamWriter = null;

        bool TermUartCom(ComboBox cbb)
        {
            UInt16 isPortFound = 0;

            LOG("COM port finding...\n");

            // Clear ComboBox
            cbb.Items.Clear();
            cbb.BeginUpdate();
            ////////////////////////////////////////////

            // Update COM ports
            foreach (string comport in SerialPort.GetPortNames())
            {
                cbb.Items.Add(comport);
                LOG("Found " + comport + "\n");

                ComboTextSet(cbb, comport);
                isPortFound++;
            }
            cbb.EndUpdate();
            ///////////////////////////////////////////////////

            CheckForIllegalCrossThreadCalls = false;

            return true;
        }

        bool TermUartComOpen()
        {
            try
            {
                // -serial \\.\COM9 -sercfg 115200,8,1,N,N
                String comStr = CBBGet(cbbTermComPort);
                String baudStr = CBBGet(cbbTermBaudrate);

                String argStr = "-serial \\\\.\\" + comStr + " -sercfg " + baudStr + ",8,1,N,N";
                LOG(argStr);
#if true
                puttyProcess = new Process();
                puttyProcess.StartInfo.FileName = "plink.exe";
                puttyProcess.StartInfo.Arguments = argStr;
                puttyProcess.StartInfo.CreateNoWindow = true;
                puttyProcess.StartInfo.UseShellExecute = false;
                puttyProcess.StartInfo.RedirectStandardOutput = true;
                puttyProcess.StartInfo.RedirectStandardInput = true;
                //puttyProcess.StartInfo.RedirectStandardError = true;
                puttyProcess.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
                //puttyProcess.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
                puttyProcess.Start();
#if false
                [DllImport("user32.dll")]
                static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

                [DllImport("user32.dll")]
                static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

                while (puttyProcess.MainWindowHandle == IntPtr.Zero)
                {
                    puttyProcess.Refresh();
                }
                SetParent(puttyProcess.MainWindowHandle, richTextBoxTerm.Handle);
                ShowWindow(puttyProcess.MainWindowHandle, 3);
#endif
                puttyProcess.BeginOutputReadLine();
                //puttyProcess.BeginErrorReadLine();

                puttyCmdStreamWriter = puttyProcess.StandardInput;

                //termOutput = puttyProcess.StandardOutput.ReadToEnd();
                //richTextBoxTerm.AppendText(termOutput);
#endif
                return true;
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
                return false;
            }
        }
        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                BeginInvoke(new Action(() => {
                    String msg = outLine.Data;

                    if (msg.Contains("\b") == true)
                    {
                        msg = msg.Replace("\b", "");
                    }

                    if (msg.Contains("\u001b") == true) // 
                    {
                        msg = msg.Replace("\u001b", "");
                    }

                    if (msg.Contains("[") == true) // [
                    {
                        msg = msg.Replace("[", "");
                    }

                    if (msg.Contains("J") == true) // [
                    {
                        msg = msg.Replace("J", "");
                    }

                    if (msg.Contains("\u001b[J") == true)
                    {
                        msg = msg.Replace("\u001b[J", "");
                    }

                    richTextBoxTerm.AppendText(msg + Environment.NewLine);
                    //richTextBoxTerm.AppendText(msg);
                    richTextBoxTerm.ScrollToCaret();
                }));
            }
        }
    }
}
