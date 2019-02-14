using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace netbioRDTx
{
    public partial class Frm_Dlg_About : Form
    {
        public Frm_Dlg_About()
        {
            InitializeComponent();
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Dlg_About_Load(object sender, EventArgs e)
        {
            LBL_VERSION.Text = "Version " + Application.ProductVersion.ToString();
        }
    }
}
