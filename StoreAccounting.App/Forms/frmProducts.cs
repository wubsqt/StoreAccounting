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
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvProducts.CurrentRow != null)
            {
                if(RtlMessageBox.Show("آیا از حذف اطمینان دارید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
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
    }
}
