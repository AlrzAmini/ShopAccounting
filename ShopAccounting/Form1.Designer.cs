namespace ShopAccounting
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReportPay = new System.Windows.Forms.Button();
            this.btnReportRecives = new System.Windows.Forms.Button();
            this.btnNewAccounting = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.labeTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpay = new System.Windows.Forms.Label();
            this.lblRecive = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(193)))), ((int)(((byte)(179)))));
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.btnSettings);
            this.PanelMenu.Controls.Add(this.btnReportPay);
            this.PanelMenu.Controls.Add(this.btnReportRecives);
            this.PanelMenu.Controls.Add(this.btnNewAccounting);
            this.PanelMenu.Controls.Add(this.btnProducts);
            this.PanelMenu.Controls.Add(this.btnCustomers);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(935, 100);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(168)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Estedad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnSettings.Image = global::ShopAccounting.Properties.Resources.icons8_settings_64;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(-8, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(110, 100);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "تنظیمات";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReportPay
            // 
            this.btnReportPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnReportPay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReportPay.FlatAppearance.BorderSize = 0;
            this.btnReportPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.btnReportPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnReportPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportPay.Font = new System.Drawing.Font("Estedad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnReportPay.Image = global::ShopAccounting.Properties.Resources.icons8_money_transfer_100;
            this.btnReportPay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportPay.Location = new System.Drawing.Point(102, 0);
            this.btnReportPay.Name = "btnReportPay";
            this.btnReportPay.Size = new System.Drawing.Size(172, 100);
            this.btnReportPay.TabIndex = 4;
            this.btnReportPay.Text = "پرداختی";
            this.btnReportPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportPay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReportPay.UseVisualStyleBackColor = false;
            this.btnReportPay.Click += new System.EventHandler(this.btnReportPay_Click);
            // 
            // btnReportRecives
            // 
            this.btnReportRecives.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnReportRecives.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReportRecives.FlatAppearance.BorderSize = 0;
            this.btnReportRecives.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.btnReportRecives.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnReportRecives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportRecives.Font = new System.Drawing.Font("Estedad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportRecives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnReportRecives.Image = global::ShopAccounting.Properties.Resources.icons8_money_100;
            this.btnReportRecives.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportRecives.Location = new System.Drawing.Point(274, 0);
            this.btnReportRecives.Name = "btnReportRecives";
            this.btnReportRecives.Size = new System.Drawing.Size(174, 100);
            this.btnReportRecives.TabIndex = 3;
            this.btnReportRecives.Text = "دریافتی";
            this.btnReportRecives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportRecives.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReportRecives.UseVisualStyleBackColor = false;
            this.btnReportRecives.Click += new System.EventHandler(this.btnReportRecives_Click);
            // 
            // btnNewAccounting
            // 
            this.btnNewAccounting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnNewAccounting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNewAccounting.FlatAppearance.BorderSize = 0;
            this.btnNewAccounting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.btnNewAccounting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnNewAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAccounting.Font = new System.Drawing.Font("Estedad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAccounting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnNewAccounting.Image = global::ShopAccounting.Properties.Resources.icons8_accounting_100;
            this.btnNewAccounting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewAccounting.Location = new System.Drawing.Point(448, 0);
            this.btnNewAccounting.Name = "btnNewAccounting";
            this.btnNewAccounting.Size = new System.Drawing.Size(172, 100);
            this.btnNewAccounting.TabIndex = 2;
            this.btnNewAccounting.Text = "تراکنش جدید";
            this.btnNewAccounting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNewAccounting.UseVisualStyleBackColor = false;
            this.btnNewAccounting.Click += new System.EventHandler(this.btnNewAccounting_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Estedad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnProducts.Image = global::ShopAccounting.Properties.Resources.icons8_fast_moving_consumer_goods_96;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducts.Location = new System.Drawing.Point(620, 0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(158, 100);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "کالا ها";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Estedad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.btnCustomers.Image = global::ShopAccounting.Properties.Resources.icons8_customer_64;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomers.Location = new System.Drawing.Point(778, 0);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(157, 100);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "مشتری ها";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // lblDate
            // 
            this.lblDate.Image = global::ShopAccounting.Properties.Resources._4907157;
            this.lblDate.Location = new System.Drawing.Point(0, 100);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(935, 612);
            this.lblDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblDate.TabIndex = 1;
            this.lblDate.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelDate,
            this.labeTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(935, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(118, 17);
            this.labelDate.Text = "toolStripStatusLabel1";
            // 
            // labeTime
            // 
            this.labeTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.labeTime.Name = "labeTime";
            this.labeTime.Size = new System.Drawing.Size(118, 17);
            this.labeTime.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(735, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.lblBalance);
            this.panel2.Controls.Add(this.lblRecive);
            this.panel2.Controls.Add(this.lblpay);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.panel2.Location = new System.Drawing.Point(735, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 165);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Estedad", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "گزارش این ماه ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Estedad", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "خرید :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Estedad", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "فروش :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Estedad", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "سود :";
            // 
            // lblpay
            // 
            this.lblpay.Location = new System.Drawing.Point(7, 42);
            this.lblpay.Name = "lblpay";
            this.lblpay.Size = new System.Drawing.Size(141, 21);
            this.lblpay.TabIndex = 4;
            this.lblpay.Text = "0";
            // 
            // lblRecive
            // 
            this.lblRecive.Location = new System.Drawing.Point(7, 65);
            this.lblRecive.Name = "lblRecive";
            this.lblRecive.Size = new System.Drawing.Size(141, 21);
            this.lblRecive.TabIndex = 5;
            this.lblRecive.Text = "0";
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(32, 104);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(116, 21);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(170)))), ((int)(((byte)(139)))));
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(145)))), ((int)(((byte)(108)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Estedad", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(0, 129);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "بروز رسانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(255)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(935, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("Estedad", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری فروشگاه";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblDate)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnNewAccounting;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnReportPay;
        private System.Windows.Forms.Button btnReportRecives;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel labelDate;
        private System.Windows.Forms.ToolStripStatusLabel labeTime;
        private System.Windows.Forms.PictureBox lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblRecive;
        private System.Windows.Forms.Label lblpay;
        private System.Windows.Forms.Button btnRefresh;
    }
}

