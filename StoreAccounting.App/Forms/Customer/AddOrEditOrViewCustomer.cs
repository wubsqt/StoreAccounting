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
using System.IO;
using ValidationComponents;

namespace StoreAccounting.App.Forms.Customer
{
    public partial class AddOrEditOrViewCustomer : Form
    {
        // This is for getting customer
        public int CustomerId = 0;

        /* This is for set form mode
            0 : Add
            1 : Edit
            2 : View Info */
        public int Mode = 0;

        public AddOrEditOrViewCustomer()
        {
            InitializeComponent();
        }

        private void AddOrEditOrViewCustomer_Load(object sender, EventArgs e)
        {
            ModeChecker();
        }

        void ModeChecker()
        {
            if (Mode == 1)
                EditMode();

            else if (Mode == 2)
                ShowInfo();
        }

        void EditMode()
        {
            this.Text = "ویرایش";

            using (StoreDBManager db = new StoreDBManager())
            {
                Customers customer = db.CustomerRepository.GetByEntity(CustomerId);
                txtName.Text = customer.FullName;
                txtNumber.Value = int.Parse(customer.Mobile);
                txtAddress.Text = customer.Address;
                pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.Image;
            }
        }

        void ShowInfo()
        {
            EditMode();
            this.Text = "نمایش اطلاعات";
            txtName.ReadOnly = true;
            txtNumber.ReadOnly = true;
            txtAddress.ReadOnly = true;
            btnSubmit.Enabled = false;
            btnSelectImage.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components) && txtNumber.Value != default)
            {
                if (Mode == 0)
                    SubmitAddCustomer();

                if (Mode == 1)
                    SubmitEditCustomer();
            }

            else
            {
                RtlMessageBox.Show("لطفا افزون بر نام،شماره را هم وارد کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SubmitEditCustomer()
        {
            using (StoreDBManager db = new StoreDBManager())
            {
                // TODO : Clean This Code Here And Extract Method Uniq Name

                string rootFolder = Application.StartupPath + @"\Images\";
                string UniqName = Guid.NewGuid().ToString();
                string Extension = Path.GetExtension(pcCustomer.ImageLocation);
                File.Copy(pcCustomer.ImageLocation, rootFolder + UniqName + Extension);

                Customers customer = new Customers()
                {
                    CustomerId = this.CustomerId,
                    FullName = txtName.Text,
                    Mobile = txtNumber.Value.ToString(),
                    Address = txtAddress.Text,
                    Image = UniqName + Extension
                };

                db.CustomerRepository.Update(customer);
                db.Save();
            }

            DialogResult = DialogResult.OK;
        }

        private void SubmitAddCustomer()
        {
            string rootFolder = Application.StartupPath + @"\Images\";
            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            string UniqName = Guid.NewGuid().ToString();
            string Extension = Path.GetExtension(pcCustomer.ImageLocation);
            if (Extension != string.Empty)
                File.Copy(pcCustomer.ImageLocation, rootFolder + UniqName + Extension);

            using (StoreDBManager db = new StoreDBManager())
            {
                Customers customer = new Customers()
                {
                    FullName = txtName.Text,
                    Mobile = txtNumber.Value.ToString(),
                    Address = txtAddress.Text,
                    Image = UniqName + Extension
                };
                db.CustomerRepository.Insert(customer);
                db.Save();

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            pcCustomer.ImageLocation = openFile.FileName;
        }
    }
}
