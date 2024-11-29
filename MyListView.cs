using System.Collections;

namespace CSharp_Common
{
    public partial class Form1 : Form
    {        
        public void ListViewInit(ListView lv)
        {
            try
            {
                listView1.BeginUpdate();

                lv.View = View.Details;
                lv.GridLines = true;
                lv.FullRowSelect = true;
                //lv.CheckBoxes = true;
                lv.LabelEdit = true;
                lv.Scrollable = true;
                //lv.HeaderStyle = ColumnHeaderStyle.None;  // disable column name field

                Iw.LVColAdd(listView1, "1");
                Iw.LVColAdd(listView1, "2");
                Iw.LVColAdd(listView1, "3");
                Iw.LVColAdd(listView1, "4");
                Iw.LVColAdd(listView1, "5");
                Iw.LVColAdd(listView1, "6");
                Iw.LVColAdd(listView1, "7");

                listView1.EndUpdate();
            }
            catch (Exception ex)
            {
                //ERR(ex.Message);
            }
        }
    }
}
