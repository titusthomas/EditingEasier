using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditngEasier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtInput.Text!=string.Empty)
            {
                string strOutput = "";
                string[] strTmpArray = txtInput.Text.Split(';');
                for(int Inc=0;Inc<strTmpArray.Length-1;Inc++)
                {
                    string[] strOutputArray = strTmpArray[Inc].Split('=');
                    string[] strSubOutputArray = strOutputArray[0].Split('.');
                    string dbname = strSubOutputArray[0].Trim().Replace("txt", "");
                    dbname=dbname.Replace("sc", "");
                    dbname = dbname.Replace("chk", "");
                    strOutput += "Globals.RealsoftObjects.SetCompanyData(\"" + dbname + "\"," + strOutputArray[0].Trim() + ");\r";
                 }
                strOutput += "\n";
                txtOutput.Text = strOutput;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
        }
    }
}
