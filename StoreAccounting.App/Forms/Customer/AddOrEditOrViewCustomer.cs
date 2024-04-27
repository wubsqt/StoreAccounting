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
            {
                // TODO : Fix this 
                this.Text = "ویرایش";
                //using(StoreDBManager db = new StoreDBManager())
                //{
                //    db.CustomerRepository.GetAll()
                //}

            }
            else if (Mode == 2)
                this.Text = "نمایش اطلاعات";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Mode == 0)
            {
                SubmitAddCustomer();
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
