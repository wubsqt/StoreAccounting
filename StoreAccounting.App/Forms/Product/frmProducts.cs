using StoreAccounting.App.Forms.Product;
using StoreAccounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreAccounting.App.Forms
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            using (StoreDBManager db = new StoreDBManager())
            {
                dgvProducts.AutoGenerateColumns = false;
                dgvProducts.DataSource = db.ProductRepository.GetAll();
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddOrEditProducts frmAddOrEdit = new frmAddOrEditProducts();
            if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows != null)
            {
                if (RtlMessageBox.Show("آیا از حذف اطمینان دارید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (StoreDBManager db = new StoreDBManager())
                    {
                        int Id = int.Parse(dgvProducts.CurrentRow.Cells[0].Value.ToString());
                        db.ProductRepository.Delete(Id);
                        db.Save();
                        BindGrid();
                    }
                }
            }

            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddOrEditProducts frmAddOrEdit = new frmAddOrEditProducts();
            frmAddOrEdit.Mode = int.Parse(dgvProducts.CurrentRow.Cells[0].Value.ToString());
            if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                BindGrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (StoreDBManager db = new StoreDBManager())
            {
                dgvProducts.DataSource = db.ProductRepository.GetAll(p =>
                    p.Name.Contains(txtFilter.Text) || p.Description.Contains(txtFilter.Text));
            }
        }
    }
}
