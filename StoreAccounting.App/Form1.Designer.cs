namespace StoreAccounting.App
{
    partial class frmSartup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSartup));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnResetUserName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnListCustomers = new System.Windows.Forms.ToolStripButton();
            this.btnListProducts = new System.Windows.Forms.ToolStripButton();
            this.btnListEmployees = new System.Windows.Forms.ToolStripButton();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTimer,
            this.lblDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1015, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTimer
            // 
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(79, 17);
            this.lblTimer.Text = "Timer be here";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(138, 17);
            this.lblDateTime.Text = "DateTime should be here";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1015, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnResetUserName,
            this.toolStripMenuItem1,
            this.btnResetPassword,
            this.toolStripMenuItem2,
            this.btnExit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            // 
            // btnResetUserName
            // 
            this.btnResetUserName.Name = "btnResetUserName";
            this.btnResetUserName.Size = new System.Drawing.Size(149, 22);
            this.btnResetUserName.Text = "تغییر نام کاربری";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Image = global::StoreAccounting.App.Properties.Resources.icons8_password_30;
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(149, 22);
            this.btnResetPassword.Text = "تغییر رمز عبور";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(146, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 22);
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnListCustomers,
            this.btnListProducts,
            this.btnListEmployees,
            this.btnReport});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1015, 72);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnListCustomers
            // 
            this.btnListCustomers.Image = global::StoreAccounting.App.Properties.Resources.icons8_customer_48;
            this.btnListCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListCustomers.Name = "btnListCustomers";
            this.btnListCustomers.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnListCustomers.Size = new System.Drawing.Size(115, 69);
            this.btnListCustomers.Text = "لیست مشتریان";
            this.btnListCustomers.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnListCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnListProducts
            // 
            this.btnListProducts.Image = global::StoreAccounting.App.Properties.Resources.icons8_product_50;
            this.btnListProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnListProducts.Size = new System.Drawing.Size(123, 69);
            this.btnListProducts.Text = "لیست محصولات";
            this.btnListProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnListEmployees
            // 
            this.btnListEmployees.Image = global::StoreAccounting.App.Properties.Resources.icons8_customer_48__1_;
            this.btnListEmployees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListEmployees.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListEmployees.Name = "btnListEmployees";
            this.btnListEmployees.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnListEmployees.Size = new System.Drawing.Size(114, 69);
            this.btnListEmployees.Text = "لیست کارمندان";
            this.btnListEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListEmployees.Click += new System.EventHandler(this.btnListEmployees_Click);
            // 
            // btnReport
            // 
            this.btnReport.Image = global::StoreAccounting.App.Properties.Resources.icons8_report_50;
            this.btnReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnReport.Size = new System.Drawing.Size(98, 69);
            this.btnReport.Text = "گزارش گیری";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.ToolTipText = "گزارش گیری";
            // 
            // frmSartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 623);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmSartup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت فروشگاه";
            this.Load += new System.EventHandler(this.frmSartup_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnResetUserName;
        private System.Windows.Forms.ToolStripMenuItem btnResetPassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripStatusLabel lblTimer;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnListProducts;
        private System.Windows.Forms.ToolStripButton btnListCustomers;
        private System.Windows.Forms.ToolStripButton btnListEmployees;
        private System.Windows.Forms.ToolStripButton btnReport;
    }
}

