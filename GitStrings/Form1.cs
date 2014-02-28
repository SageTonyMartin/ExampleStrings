using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitResources;

namespace GitStrings
{
    public partial class Form1 : Form
    {
        private GitResources.ContactResources gr;

        public Form1()
        {
            gr = new ContactResources();
            InitializeComponent();
            InitializeStrings();
            tbName.Focus();
        }

        private void InitializeStrings()
        {
            strTitle.Text = gr.GetResourceString("strTitle");
            strSubTitle.Text = gr.GetResourceString("strSubTitle");
            strName.Text = gr.GetResourceString("strName");
            strAddress.Text = gr.GetResourceString("strAddress");
            strCity.Text = gr.GetResourceString("strCity");
            strState.Text = gr.GetResourceString("strState");
            strZip.Text = gr.GetResourceString("strZip");
            strPhone.Text = gr.GetResourceString("strPhone");
            strHelpLine.Text = "";
        }

        private void strTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateHelp()
        {
            switch (this.ActiveControl.Name.ToUpper())
            {
                case "TBNAME": strHelpLine.Text = gr.GetResourceString("HelpName"); break;
                case "TBADDRESS": strHelpLine.Text = gr.GetResourceString("HelpAddress"); break;
                case "TBCITY": strHelpLine.Text = gr.GetResourceString("HelpCity"); break;
                case "TBSTATE": strHelpLine.Text = gr.GetResourceString("HelpState"); break;
                case "TBZIP": strHelpLine.Text = gr.GetResourceString("HelpZip"); break;
                case "MTBPHONE": strHelpLine.Text = gr.GetResourceString("HelpPhone"); break;
                default: strHelpLine.Text = "";  break;
            }
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            UpdateHelp();
        }

        private void tbAddress_Enter(object sender, EventArgs e)
        {
            UpdateHelp();
        }

        private void tbCity_Enter(object sender, EventArgs e)
        {
            UpdateHelp();
        }

        private void tbState_Enter(object sender, EventArgs e)
        {
            UpdateHelp();
        }

        private void tbZip_Enter(object sender, EventArgs e)
        {
            UpdateHelp();
        }

        private void mtbPhone_Enter(object sender, EventArgs e)
        {
            UpdateHelp();
        }
    }
}
