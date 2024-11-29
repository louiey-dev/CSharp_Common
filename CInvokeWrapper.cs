using System.Diagnostics;
using System.Drawing;

public class CInvokeWrapper
{
    void DBG(String str)
    {
        Debug.Print(str);
    }

    #region CheckBox Invoke Wrapper
    /*
     * Check Box Check Set
    */
    public void CBSet(CheckBox cb, bool set)
    {
        try
        {
            if (cb.InvokeRequired) { cb.Invoke(new MethodInvoker(delegate () { cb.Checked = set; })); }
            else { cb.Checked = set; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }

    /*
     * Check Box Check Get
     */
    public bool CBGet(CheckBox cb)
    {
        bool set = false;

        try
        {
            if (cb.InvokeRequired) { cb.Invoke(new MethodInvoker(delegate () { set = cb.Checked; })); }
            else { set = cb.Checked; }

            return set;
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
            return set;
        }
    }

    /*
     * Check Box Text/Check Set
     */
    public void CBTextSet(CheckBox cb, bool set, string str)
    {
        try
        {
            if (cb.InvokeRequired) { cb.Invoke(new MethodInvoker(delegate () { cb.Checked = set; cb.Text = str; })); }
            else { cb.Checked = set; cb.Text = str; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }

    /*
     * Check Box Text Set
     */
    public void CBTextSet(CheckBox cb, string str)
    {
        try
        {
            if (cb.InvokeRequired) { cb.Invoke(new MethodInvoker(delegate () { cb.Text = str; })); }
            else { cb.Text = str; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }
    /*
     * Check Box Text Get
     */
    public String CBTextGet(CheckBox cb)
    {
        String str = "";
        try
        {
            if (cb.InvokeRequired) { cb.Invoke(new MethodInvoker(delegate () { str = cb.Text; })); }
            else { str = cb.Text; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
        return str;
    }
    #endregion

    #region TextBox Invoke Wrapper
    /// <summary>
    /// Text Box Text Set
    /// </summary>
    /// <param name="tb"></param>
    /// <param name="str"></param>
    public void TBSet(TextBox tb, string str)
    {
        try
        {
            if (tb.InvokeRequired) { tb.Invoke(new MethodInvoker(delegate () { tb.Text = str; })); }
            else { tb.Text = str; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }

    /// <summary>
    /// Text Box BG Color Set
    /// </summary>
    /// <param name="tb"></param>
    /// <param name="bgColor"></param>
    public void TBSetBgColor(TextBox tb, Color bgColor)
    {
        try
        {
            if (tb.InvokeRequired) { tb.Invoke(new MethodInvoker(delegate () { tb.BackColor = bgColor; })); }
            else { tb.BackColor = bgColor; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }

    /// <summary>
    /// Text Box Text Get
    /// </summary>
    /// <param name="tb"></param>
    /// <returns></returns>
    public string TBGet(TextBox tb)
    {
        string str = "";

        try
        {
            if (tb.InvokeRequired) { tb.Invoke(new MethodInvoker(delegate () { str = tb.Text; })); }
            else { str = tb.Text; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
        return str;
    }

    /// <summary>
    /// Text Box Text Get UINT32 with NULL check
    /// TODO : Add digit check routine here
    /// </summary>
    /// <param name="tb"></param>
    /// <returns></returns>
    public UInt32 TextBoxGetUInt32(TextBox tb)
    {
        string str = "";

        try
        {
            if (tb.InvokeRequired)
            {
                tb.Invoke(new MethodInvoker(delegate ()
                {
                    if (string.IsNullOrWhiteSpace(tb.Text)) { str = "0"; MessageBox.Show("${tb.Name} is empty"); }
                    else { str = tb.Text; }
                }));
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tb.Text)) { str = "0"; MessageBox.Show("${tb.Name} is empty"); }
                else { str = tb.Text; }
            }

            return Convert.ToUInt32(str);
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
            return 0;
        }
    }

    /// <summary>
    /// Text Box Text Get UINT16 with NULL check
    /// </summary>
    /// <param name="tb"></param>
    /// <returns></returns>
    public UInt16 TextBoxGetUInt16(TextBox tb)
    {
        string str = "";

        try
        {
            if (tb.InvokeRequired)
            {
                tb.Invoke(new MethodInvoker(delegate ()
                {
                    if (string.IsNullOrWhiteSpace(tb.Text)) { str = "0"; MessageBox.Show("TextBox is empty"); }
                    else { str = tb.Text; }
                }));
            }
            else
            {
                if (string.IsNullOrWhiteSpace(tb.Text)) { str = "0"; MessageBox.Show("TextBox is empty"); }
                else { str = tb.Text; }
            }

            return Convert.ToUInt16(str);
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
            return 0;
        }
    }
    #endregion

    #region Label Invoke Wrapper
    /// <summary>
    /// Label Text Set
    /// </summary>
    /// <param name="lb"></param>
    /// <param name="str"></param>
    public void LBSet(Label lb, string str)
    {
        try
        {
            if (lb.InvokeRequired)
            {
                lb.Invoke(new MethodInvoker(delegate () { lb.Text = str; }));
            }
            else
            {
                lb.Text = str;
            }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }

    /// <summary>
    /// Label BG color Set
    /// </summary>
    /// <param name="lb"></param>
    /// <param name="clr"></param>
    public void LabelSetForeColor(Label lb, Color clr)
    {
        try
        {
            if (lb.InvokeRequired)
            {
                lb.Invoke(new MethodInvoker(delegate () { lb.ForeColor = clr; }));
            }
            else
            {
                lb.ForeColor = clr;
            }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }

    /// <summary>
    /// Label Get label string
    /// </summary>
    /// <param name="lb"></param>
    /// <returns></returns>
    public String LBGet(Label lb)
    {
        String str = "";
        try
        {
            if (lb.InvokeRequired)
            {
                lb.Invoke(new MethodInvoker(delegate () { str = lb.Text; }));
            }
            else
            {
                str = lb.Text;
            }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
        return str;
    }

    /// <summary>
    /// Label get fore-color
    /// </summary>
    /// <param name="lb"></param>
    /// <returns></returns>
    public Color LabelGetForeColor(Label lb)
    {
        Color color = Color.Black;
        try
        {
            if (lb.InvokeRequired)
            {
                lb.Invoke(new MethodInvoker(delegate () { color = lb.ForeColor; }));
            }
            else
            {
                color = lb.ForeColor;
            }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
        return color;
    }
    #endregion

    #region ComBoBox Invoke Wrapper
    /// <summary>
    /// ComboBox Text Get
    /// </summary>
    /// <param name="cb"></param>
    /// <returns></returns>
    public string CBBGet(ComboBox cb)
    {
        string str = "";

        try
        {
            if (cb.InvokeRequired) { cb.Invoke(new MethodInvoker(delegate () { str = cb.Text; })); }
            else { str = cb.Text; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
        return str;
    }

    /// <summary>
    /// ComboBox Text Set
    /// </summary>
    /// <param name="cb"></param>
    /// <param name="str"></param>
    /// <returns></returns>
    public void CBBSet(ComboBox cb, string str)
    {
        try
        {
            if (cb.InvokeRequired) { cb.Invoke(new MethodInvoker(delegate () { cb.Text = str; })); }
            else { cb.Text = str; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }
    #endregion

    #region Radio Button Invoke Wrapper
    /// <summary>
    /// Radio Button Checked Get
    /// </summary>
    /// <param name="rb"></param>
    /// <returns></returns>
    public bool RBGet(RadioButton rb)
    {
        bool ret = false;

        try
        {
            if (rb.InvokeRequired) { rb.Invoke(new MethodInvoker(delegate () { if (rb.Checked) { ret = true; } else { ret = false; } })); }
            else { if (rb.Checked) { ret = true; } else { ret = false; } }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
        return ret;
    }

    /// <summary>
    /// Radio Button Checked Set
    /// </summary>
    /// <param name="rb"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public void RBSet(RadioButton rb, bool val)
    {
        try
        {
            if (rb.InvokeRequired) { rb.Invoke(new MethodInvoker(delegate () { rb.Checked = val; })); }
            else { rb.Checked = val; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }
    #endregion

    #region Button Invoke Wrapper
    /// <summary>
    /// Button Text Set
    /// </summary>
    /// <param name="bt"></param>
    /// <param name="str"></param>
    public void BTNSet(Button bt, string str)
    {
        try
        {
            if (bt.InvokeRequired) { bt.Invoke(new MethodInvoker(delegate () { bt.Text = str; })); }
            else { bt.Text = str; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }

    /// <summary>
    /// Button Text Get
    /// </summary>
    /// <param name="bt"></param>
    /// <returns></returns>
    public String BTNGet(Button bt)
    {
        string ret = "";
        try
        {
            if (bt.InvokeRequired) { bt.Invoke(new MethodInvoker(delegate () { ret = bt.Text; })); }
            else { ret = bt.Text; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
        return ret;
    }
    #endregion

    #region ListView Invoke Wrapper
    /// <summary>
    /// List View Item Remove
    /// </summary>
    /// <param name="view"></param>
    /// <param name="item"></param>
    public void LVItemRem(ListView view, ListViewItem item)
    {
        try
        {
            if (view.InvokeRequired) { view.Invoke(new MethodInvoker(delegate () { view.Items.Remove(item); })); }
            else { view.Items.Remove(item); }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }

    /// <summary>
    /// List View Item Add
    /// </summary>
    /// <param name="view"></param>
    /// <param name="item"></param>
    public void LVItemAdd(ListView view, ListViewItem item)
    {
        try
        {
            if (view.InvokeRequired) { view.Invoke(new MethodInvoker(delegate () { view.Items.Add(item); })); }
            else { view.Items.Add(item); }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }
    #endregion

    #region ListBox Invoke Wrapper
    /// <summary>
    /// List Box Add
    /// </summary>
    /// <param name="lbx"></param>
    /// <param name="str"></param>
    public void LBAdd(ListBox lbx, string str)
    {
        try
        {
            if (lbx.InvokeRequired) { lbx.Invoke(new MethodInvoker(delegate () { lbx.Items.Add(str); lbx.TopIndex = lbx.Items.Count - 1; })); }
            else { lbx.Items.Add(str); lbx.TopIndex = lbx.Items.Count - 1; }
        }
        catch (Exception ex)
        {
            DBG(ex.Message);
        }
    }
    #endregion
}
