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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddOrEditOrViewCustomer addCustomer = new AddOrEditOrViewCustomer();
            if (addCustomer.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows != null)
            {
                int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());

                AddOrEditOrViewCustomer EditCustomer = new AddOrEditOrViewCustomer();
                EditCustomer.CustomerId = customerId;
                EditCustomer.Mode = 1;

                if (EditCustomer.ShowDialog() == DialogResult.OK)
                    BindGrid();
            }

            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows != null)
            {
                int customerId = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());

                AddOrEditOrViewCustomer ViewCustomer = new AddOrEditOrViewCustomer();
                ViewCustomer.CustomerId = customerId;
                ViewCustomer.Mode = 2;
                ViewCustomer.ShowDialog();
            }

            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if(dgvCustomers.SelectedRows != null)
            {
                if(RtlMessageBox.Show("آیا از حذف شخص اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using(StoreDBManager db = new StoreDBManager())
                    {
                        int Id = int.Parse(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                        Customers customer = db.CustomerRepository.GetByEntity(Id);
                        db.CustomerRepository.Delete(customer);
                        db.Save();
                    }
                    BindGrid();
                }
            }

            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
