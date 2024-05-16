using Accounting.utility.Convertor;
using StoreAccounting.App.Forms;
using StoreAccounting.App.Forms.Customer;
using StoreAccounting.App.Forms.Employee;
using StoreAccounting.App.Forms.Login;
using StoreAccounting.Business;
using StoreAccounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StoreAccounting.App
{
    public partial class frmSartup : Form
    {
        public int EmployeeId = default;

        public frmSartup()
        {
            InitializeComponent();
        }

        private void frmSartup_Load(object sender, EventArgs e)
        {
            // TODO : FIX HERE AFTER LOGIN WINDOWS IS BE CREATED

            // this.Hide();
            //frmLogin frmLogin = new frmLogin();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //this.Show();
            UpdateTimer();
            FillChart();
        }

        private void FillChart()
        {
            // Exporting Data From DataBase

            #region Exporting Data

            List<double> TopProductPay = new List<double>();
            List<double> TopEmployeeSalary = new List<double>();

            using (StoreDBManager db = new StoreDBManager())
            {
                db.ProductRepository.GetAll()
                    .Select(p => p.Price)
                    .Take(10)
                    .ToList()
                    .ForEach(p => TopProductPay.Add(p));

                db.EmployeeRepository.GetAll()
                    .Select(e => e.BaseSalary)
                    .Take(10)
                    .ToList()
                    .ForEach(e => TopEmployeeSalary.Add(e));
            }

            #endregion

            double avgProductPay = ChartFill.AvgCalc(TopProductPay);
            double avgEmployeeSalary = ChartFill.AvgCalc(TopEmployeeSalary);

            // Putting Data To The Chart :
            chartMain.Palette = ChartColorPalette.Berry;
            chartMain.Series.Clear();


            // General Index for all of Series (using for x label)
            int index = default;

            #region Making Series

            // The List Of Top Employees
            Series sTopEm = new Series();
            sTopEm.Name = "بیشترین درآمد کارمندان";
            for (int i = 0; i < TopEmployeeSalary.Count; i++)
            {
                sTopEm.Points.AddXY(index, TopEmployeeSalary[i]);
                index += 1;
            }


            // The List Of Top Products
            Series sTopProd = new Series();
            sTopProd.Name = "محصولات قیمت بالا";
            for (int i = 0; i < TopProductPay.Count; i++)
            {
                sTopEm.Points.AddXY(index, TopProductPay[i]);
                index += 1;
            }


            // List Average Of Top Employee Salaries
            Series sAvgTopEm = new Series();
            sAvgTopEm.Name = "میانگین قیمت محصولات گران";
            sAvgTopEm.Points.AddXY(index, avgEmployeeSalary);
            index += 1;

            // List Average Of Top Employee Salaries
            Series sAvgTopProd = new Series();
            sAvgTopProd.Name = "میانگین درآمد کارمندان گران";
            sAvgTopProd.Points.AddXY(index, avgProductPay);
            index += 1;

            #endregion

            #region Adding Series to the Chart

            chartMain.Series.Add(sTopEm);
            chartMain.Series.Add(sTopProd);
            chartMain.Series.Add(sAvgTopEm);
            chartMain.Series.Add(sAvgTopProd);

            #endregion
        }

        private void UpdateTimer()
        {
            lblDateTime.Text = DateTime.Now.ToShamsi();
            lblTimer.Text = DateConvertor.Timer(DateTime.Now);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            frmProducts frmProducts = new frmProducts();
            frmProducts.ShowDialog();
        }

        private void btnListEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();
            frmEmployees.ShowDialog();
            FillChart();
        }

        private void btnListCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void Maintimer_Tick(object sender, EventArgs e)
        {
            UpdateTimer();
        }

        private void ChangeUserOrPass_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void btnUpdateChart_Click(object sender, EventArgs e)
        {
            FillChart();
        }
    }
}
