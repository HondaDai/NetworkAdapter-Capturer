using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ManagementClass Network = new ManagementClass("Win32_NetworkAdapterConfiguration");
        string nowAdapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string query = "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled=TRUE";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            string showTEXT = "";
            //ManagementObjectCollection col = searcher.Get();
            foreach (ManagementObject Mobj in searcher.Get())
            {
                showTEXT += Mobj["Description"] + "\n";
                foreach (string s in (string[])Mobj["IPAddress"])
                {
                    showTEXT += s + "\n";
                }
                showTEXT += "---------------\n";

                ToolStripMenuItem adapter = new ToolStripMenuItem();
                adapter.CheckOnClick = true;
                adapter.Click += new EventHandler(adapter_Click);
                adapter.Text = (string)Mobj["Description"];
                MenuItem_adapter.DropDownItems.Add(adapter);
            }
            MessageBox.Show(showTEXT);
            Get_Now_Adapter();
            MessageBox.Show(nowAdapter);

        }

        private void adapter_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in MenuItem_adapter.DropDownItems)
            {
                if (item.Equals(sender))
                    item.CheckState = CheckState.Checked;
                else
                    item.CheckState = CheckState.Unchecked;
            }
            Get_Now_Adapter();
            MessageBox.Show(nowAdapter);
            //throw new NotImplementedException();
        }

        private void Get_Now_Adapter()
        {
            foreach (ToolStripMenuItem item in MenuItem_adapter.DropDownItems)
            {
                if (item.Checked == true)
                {
                    nowAdapter = item.Text;
                    return;
                }
            }
            nowAdapter = "";
        }

    }
}
