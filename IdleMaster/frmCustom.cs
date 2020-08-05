using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleMaster
{
    public partial class frmCustom : Form
    {
        public frmCustom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdtext = "steam-idle.exe 252950";
            System.Diagnostics.Process.Start("cmd.exe", cmdtext);
            Application.Exit();
        }
    }
}
