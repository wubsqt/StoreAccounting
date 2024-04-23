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
using ValidationComponents;

namespace StoreAccounting.App.Forms.Product
{
    public partial class frmAddOrEditProducts : Form
    {
        // 0 = Adding mode
        // anything else = Edit mode
        public int Mode = 0;

        public frmAddOrEditProducts()
        {
            InitializeComponent();
        }

        private void frmAddOrEditProducts_Load(object sender, EventArgs e)
        {
            ModeChecker();

        }

        private void ModeChecker()
        {
            if (Mode != 0)
            {
                this.Name = "ویرایش محصول";
                using (StoreDBManager db = new StoreDBManager())
                {
                    Products product = db.ProductRepository.GetByEntity(Mode);
                    txtName.Text = product.Name;
                    txtPrice.Value = product.Price;
                    txtDescription.Text = product.Description;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components) && txtPrice.Value != 0)
            {
                using(StoreDBManager db = new StoreDBManager())
                {
                    Products product = new Products()
                    {
                        Name = txtName.Text,
                        Price = (int)txtPrice.Value,
                        Description = txtDescription.Text
                    };

                    if (Mode == 0)
                    {
                        db.ProductRepository.Insert(product);
                    }

                    else
                    {
                        product.Id = Mode;
                        db.ProductRepository.Update(product);
                    }

                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }

            else
            {
                // the controler can not control numeric so we control it manually
                RtlMessageBox.Show("لطفا افزودن بر نام قیمت را هم وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
