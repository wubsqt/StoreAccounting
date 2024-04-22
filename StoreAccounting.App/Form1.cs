using Accounting.utility.Convertor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAccounting.App
{
    public partial class frmSartup : Form
    {
        public frmSartup()
        {
            InitializeComponent();
        }

        private void frmSartup_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShamsi();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
