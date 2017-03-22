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
    public partial class frmDbUpdateCommand : Form
    {
        public frmDbUpdateCommand()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
            txtVariableName.Text = "Query";
            chkDbUpdateCommand.Checked = false;
            chkVB.Checked = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                string strVar = "";
                strVar = txtVariableName.Text.Trim();
                if(strVar=="")
                {
                    MessageBox.Show("Variable Name cannot be empty");
                    return;
                }
                if (txtInput.Text != string.Empty)
                {
                    string strOutput =strVar+ "=\"\""+ (chkVB.Checked ? "\r" : ";\r");
                    string[] strTmpArray = txtInput.Text.Split('\r');
                    for (int Inc = 0; Inc < strTmpArray.Length ; Inc++)
                    {
                        string str = strTmpArray[Inc].Replace('\n', ' ');

                        strOutput += strVar + "+=\"" + str +(chkDbUpdateCommand.Checked?(chkVB.Checked? "\"& vbCrLf\r" : "\\n\";\r") :"") + "";
                    }
                    strOutput += "\n";
                    strOutput += "ExeStatement = \""+txtCmdNo.Text+"#\""+ (chkVB.Checked ? "&" :"+" )+strVar + (chkVB.Checked ?"": ";");
                    txtOutput.Text = strOutput;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmDbUpdateCommand_Load(object sender, EventArgs e)
        {
            chkDbUpdateCommand.Checked = false;
        }
    }
}
