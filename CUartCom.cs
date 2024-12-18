
using System.Diagnostics;
using System.IO.Ports;

public class CUartCom
{
    #region Delegates
    public delegate void logDelegate(string msg);
    public delegate void uartReceiveDelegate(object sender, SerialDataReceivedEventArgs e);
    #endregion

    SerialPort Sp = null;
    AutoResetEvent EventUartResp = null;

    void DBG(String str)
    {
        Debug.Print(str);
    }

    public bool UartCom(ComboBox cbb)
    {
        UInt16 isPortFound = 0;

        DBG("COM port finding...\n");

        // Clear ComboBox
        cbb.Items.Clear();
        cbb.BeginUpdate();
        ////////////////////////////////////////////

        // Update COM ports
        foreach (string comport in SerialPort.GetPortNames())
        {
            cbb.Items.Add(comport);
            DBG("Found " + comport + "\n");

            cbb.Text = comport;
            isPortFound++;
        }
        cbb.EndUpdate();
        ///////////////////////////////////////////////////
        return true;
    }

    
}
