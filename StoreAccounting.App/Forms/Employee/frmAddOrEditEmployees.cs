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

namespace StoreAccounting.App.Forms.Employee
{
    public partial class frmAddOrEditEmployees : Form
    {
        public int Mode = 0;
        public frmAddOrEditEmployees()
        {
            InitializeComponent();
        }

        private void frmAddOrEditEmployees_Load(object sender, EventArgs e)
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
                    Employees employee = db.EmployeeRepository.GetByEntity(Mode);
                    txtName.Text = employee.FullName;
                    txtBaseSalary.Value = employee.BaseSalary;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components) && txtBaseSalary.Value != 0)
            {
                using (StoreDBManager db = new StoreDBManager())
                {
                    Employees employee = new Employees()
                    {
                        FullName = txtName.Text,
                        BaseSalary = (int)txtBaseSalary.Value,
                    };

                    if (Mode == 0)
                    {
                        db.EmployeeRepository.Insert(employee);
                    }

                    else
                    {
                        employee.Id = Mode;
                        db.EmployeeRepository.Update(employee);
                    }

                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }
            
            else
            {
                // the controler can not control numeric so we control it manually
                RtlMessageBox.Show("لطفا افزودن بر نام حقوق پایه را هم وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
