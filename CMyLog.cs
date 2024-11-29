using System.Diagnostics;

/// <summary>
/// log mask
/// 
/// </summary>
public class CMyLog
{
    #region Delegates
    public delegate void logDelegate(String msg);
    #endregion

    public RichTextBox logBox;

    public int logMaxCount;

    public UInt32 logMask;  // 0000 0000 0000 0000 0000 0000 0000 0001 : log
                            // 0000 0000 0000 0000 0000 0000 0000 0010 : error
                            // 0000 0000 0000 0000 0000 0000 0000 0100 : api
                            // 0000 0000 0000 0000 0000 0000 0000 1000 : info
                            // 0000 0000 0000 0000 0000 0000 0001 0000 : warn

    const UInt32 LOG_MASK = 0x00000001;
    const UInt32 ERR_MASK = 0x00000002;
    const UInt32 API_MASK = 0x00000004;
    const UInt32 INFO_MASK = 0x00000008;
    const UInt32 WARN_MASK = 0x00000010;

    public Color logColor = Color.Black;
    public Color errColor = Color.Red;
    public Color apiColor = Color.Blue;
    public Color infoColor = Color.Green;
    public Color warnColor = Color.Orange;

    public CMyLog(RichTextBox _logBox, UInt32 _logMask, int _maxCount) 
    {
        logBox = _logBox;
        logMask = _logMask;
        logMaxCount = _maxCount;
    }

    CMyLog(RichTextBox _logBox, UInt32 _logMask, int _maxCount, Color _logColor, Color _erColor, Color _apiColor, Color _infoColor, Color _warmColor)
    {
        logBox = _logBox;
        logMask = _logMask;
        logMaxCount = _maxCount;

        logColor = _logColor;
        errColor = _erColor;
        apiColor = _apiColor;
        infoColor = _infoColor;
        warnColor = _warmColor;
    }

    public void log(String str, Color userColor)
    {
        try
        {
            str = "[" + DateTime.Now.ToString("HH:mm:ss") + "] " + str;

            if (logBox.InvokeRequired)
            {
                logBox.Invoke(new MethodInvoker(delegate ()
                {
                    logBox.SelectionColor = userColor;
                    if (logBox.Lines.Length > logMaxCount)
                        Clear();

                    logBox.AppendText(str);
                    logBox.ScrollToCaret();
                    logBox.SelectionColor = logBox.ForeColor;
                }));
            }
            else
            {
                logBox.SelectionColor = userColor;
                if (logBox.Lines.Length > logMaxCount)
                    Clear();

                logBox.AppendText(str);
                logBox.ScrollToCaret();
                logBox.SelectionColor = logBox.ForeColor;
            }
        }
        catch (Exception ex)
        {
            Debug.Print(ex.Message);
        }
    }

    public void l(String str)
    {
        try
        {
            if ((logMask & LOG_MASK) == LOG_MASK)
                log(str, logColor);
        }
        catch (Exception ex)
        {
            d(ex.Message);
        }
    }

    public void w(String str)
    {
        try
        {
            if ((logMask & WARN_MASK) == WARN_MASK)
                log(str, warnColor);
        }
        catch (Exception ex)
        {
            d(ex.Message);
        }
    }

    public void i(String str)
    {
        try
        {
            if ((logMask & INFO_MASK) == INFO_MASK)
                log(str, infoColor);
        }
        catch (Exception ex)
        {
            d(ex.Message);
        }
    }
    public void a(String str)
    {
        try
        {
            if ((logMask & API_MASK) == API_MASK)
                log(str, apiColor);
        }
        catch (Exception ex)
        {
            d(ex.Message);
        }
    }

    public void e(String str)
    {
        try
        {
            if ((logMask & ERR_MASK) == ERR_MASK)
                log(str, errColor);
        }
        catch (Exception ex)
        {
            d(ex.Message);
        }
    }

    public void d(string str)
    {
        try
        {
            Debug.Print("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + str);
        }
        catch (Exception ex)
        {
            Debug.Print(ex.Message);
        }
    }

    public void Clear()
    {
        try
        {
            if (logBox.InvokeRequired)
            {
                logBox.Invoke(new MethodInvoker(delegate ()
                {
                    logBox.Clear();
                }));
            }
            else
            {
                logBox.Clear();
            }
        }
        catch (Exception ex)
        {
            Debug.Print(ex.Message);
        }
    }
}
