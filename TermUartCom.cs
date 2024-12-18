using System.Collections;
using System.Diagnostics;
using System.IO.Ports;

namespace CSharp_Common
{
    public partial class Form1 : Form
    {
        String termOutput = "";
        Process puttyProcess = null;

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
            // -serial \\.\COM9 -sercfg 115200,8,1,N,N
            String comStr = CBBGet(cbbTermComPort);
            String baudStr = CBBGet(cbbTermBaudrate);

            String argStr = "-serial \\\\.\\" + comStr + " -sercfg " +  baudStr + ",8,1,N,N";
            LOG(argStr);
#if false
            puttyProcess = new Process();
            puttyProcess.StartInfo.FileName = "plink.exe";
            puttyProcess.StartInfo.Arguments = argStr;
            puttyProcess.StartInfo.UseShellExecute = false;
            puttyProcess.StartInfo.RedirectStandardOutput = true;
            puttyProcess.Start();

            puttyProcess.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            puttyProcess.BeginOutputReadLine();
#endif
            return true;
        }
        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                BeginInvoke(new Action(() => {
                    richTextBoxTerm.AppendText(outLine.Data + Environment.NewLine);
                }));
            }
        }
    }
}
