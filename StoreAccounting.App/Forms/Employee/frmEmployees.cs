using StoreAccounting.App.Forms.Product;
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

namespace StoreAccounting.App.Forms.Employee
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            using (StoreDBManager db = new StoreDBManager())
            {
                dgvEmployees.AutoGenerateColumns = false;
                dgvEmployees.DataSource = db.EmployeeRepository.GetAll();
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                if (RtlMessageBox.Show("آیا از حذف اطمینان دارید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (StoreDBManager db = new StoreDBManager())
                    {
                        int Id = int.Parse(dgvEmployees.CurrentRow.Cells[0].Value.ToString());
                        db.EmployeeRepository.Delete(Id);
                        db.Save();
                        BindGrid();
                    }
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (StoreDBManager db = new StoreDBManager())
            {
                dgvEmployees.DataSource = db.EmployeeRepository.GetAll(x =>
                    x.FullName.Contains(txtFilter.Text) || x.Id.ToString() == txtFilter.Text);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddOrEditEmployees frmAddOrEdit = new frmAddOrEditEmployees();
            if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            frmAddOrEditEmployees frmAddOrEdit = new frmAddOrEditEmployees();
            frmAddOrEdit.Mode = int.Parse(dgvEmployees.CurrentRow.Cells[0].Value.ToString());
            if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
