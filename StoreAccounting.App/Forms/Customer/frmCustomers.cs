using StoreAccounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAccounting.App.Forms.Customer
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            BindGrid();   
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            using (StoreDBManager db = new StoreDBManager())
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = db.CustomerRepo.GetAllCustomer();
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }
    }
}
