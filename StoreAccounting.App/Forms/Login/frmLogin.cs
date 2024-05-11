using Microsoft.SqlServer.Server;
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

namespace StoreAccounting.App.Forms.Login
{
    public partial class frmLogin : Form
    {
        // TODO : FIX THIS WONDOWS FOR LOGIN AND CHANGING THE USERNAME AND PASSWORDS

        //frmSartup frmSartup;
        public frmLogin()
        {
            InitializeComponent();
            //frmSartup = new frmSartup();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //if (frmSartup.EmployeeId == default)
            //    StartupLogin();
            //else
            //    ChangeAccountSetting();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (frmSartup.EmployeeId == default)
            //    StartupLogin();
            //else
            //    ChangeAccountSetting();
        }

        //private void ChangeAccountSetting()
        //{
        //    this.Text = "ویرایش اطلاعات کاربری";
        //    txtUserName.Value = frmSartup.EmployeeId;
        //    txtPassword.Text = frmSartup.EmployeeId.ToString();
        //}

        //private void StartupLogin()
        //{
        //    int UserId = int.Parse(txtUserName.Value.ToString());
        //    int ExportedId = default;

        //    using (StoreDBManager db = new StoreDBManager())
        //    {
        //        ExportedId = db.EmployeeRepository.GetAll()
        //            .Select(x => x.Id)
        //            .ToList()
        //            .FirstOrDefault(x => x == UserId);
        //    }

        //    if (ExportedId != 0 && txtUserName.Value.ToString() == txtPassword.Text)
        //    {
        //        DialogResult = DialogResult.OK;
        //        frmSartup.EmployeeId = ExportedId;
        //    }

        //    else
        //    {
        //        RtlMessageBox.Show("اطلاعات وارد شده صحیح نمیباشد !", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        
    }
}
