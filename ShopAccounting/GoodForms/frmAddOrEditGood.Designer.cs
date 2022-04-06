namespace ShopAccounting
{
    partial class frmAddOrEditGood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrEditGood));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectGoodImage = new System.Windows.Forms.Button();
            this.pcGood = new System.Windows.Forms.PictureBox();
            this.txtGoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveGood = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(228)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.btnSelectGoodImage);
            this.panel1.Controls.Add(this.pcGood);
            this.panel1.Controls.Add(this.txtGoodPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGoodName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 370);
            this.panel1.TabIndex = 0;
            // 
            // btnSelectGoodImage
            // 
            this.btnSelectGoodImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.btnSelectGoodImage.FlatAppearance.BorderSize = 0;
            this.btnSelectGoodImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(147)))), ((int)(((byte)(150)))));
            this.btnSelectGoodImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.btnSelectGoodImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectGoodImage.Font = new System.Drawing.Font("Estedad", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectGoodImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnSelectGoodImage.Image = global::ShopAccounting.Properties.Resources.icons8_add_image_48;
            this.btnSelectGoodImage.Location = new System.Drawing.Point(104, 295);
            this.btnSelectGoodImage.Name = "btnSelectGoodImage";
            this.btnSelectGoodImage.Size = new System.Drawing.Size(177, 57);
            this.btnSelectGoodImage.TabIndex = 5;
            this.btnSelectGoodImage.Text = "انتخاب تصویر ";
            this.btnSelectGoodImage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSelectGoodImage.UseVisualStyleBackColor = false;
            this.btnSelectGoodImage.Click += new System.EventHandler(this.btnSelectGoodImage_Click);
            // 
            // pcGood
            // 
            this.pcGood.Image = global::ShopAccounting.Properties.Resources._as;
            this.pcGood.Location = new System.Drawing.Point(17, 108);
            this.pcGood.Name = "pcGood";
            this.pcGood.Size = new System.Drawing.Size(334, 169);
            this.pcGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcGood.TabIndex = 4;
            this.pcGood.TabStop = false;
            // 
            // txtGoodPrice
            // 
            this.txtGoodPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.txtGoodPrice.Font = new System.Drawing.Font("Estedad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.txtGoodPrice.Location = new System.Drawing.Point(17, 56);
            this.txtGoodPrice.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.txtGoodPrice.Name = "txtGoodPrice";
            this.txtGoodPrice.Size = new System.Drawing.Size(277, 32);
            this.txtGoodPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Estedad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(295, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "قیمت :";
            // 
            // txtGoodName
            // 
            this.txtGoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(146)))));
            this.txtGoodName.Font = new System.Drawing.Font("Estedad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.txtGoodName.Location = new System.Drawing.Point(17, 15);
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Size = new System.Drawing.Size(277, 32);
            this.txtGoodName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Estedad", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(295, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کالا :";
            // 
            // btnSaveGood
            // 
            this.btnSaveGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(78)))), ((int)(((byte)(119)))));
            this.btnSaveGood.FlatAppearance.BorderSize = 0;
            this.btnSaveGood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(23)))), ((int)(((byte)(158)))));
            this.btnSaveGood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(12)))), ((int)(((byte)(163)))));
            this.btnSaveGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGood.Font = new System.Drawing.Font("Lalezar", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGood.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSaveGood.Location = new System.Drawing.Point(86, 375);
            this.btnSaveGood.Name = "btnSaveGood";
            this.btnSaveGood.Size = new System.Drawing.Size(212, 71);
            this.btnSaveGood.TabIndex = 1;
            this.btnSaveGood.Text = "ثبت کالا";
            this.btnSaveGood.UseVisualStyleBackColor = false;
            this.btnSaveGood.Click += new System.EventHandler(this.btnSaveGood_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtGoodName;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام کالا را وارد کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtGoodPrice;
            this.requiredFieldValidator2.ErrorMessage = "لطفا قیمت کالا را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // frmAddOrEditGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(387, 451);
            this.Controls.Add(this.btnSaveGood);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Estedad", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmAddOrEditGood";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن کالا";
            this.Load += new System.EventHandler(this.frmAddOrEditGood_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGoodName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtGoodPrice;
        private System.Windows.Forms.Label label2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private System.Windows.Forms.PictureBox pcGood;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private System.Windows.Forms.Button btnSelectGoodImage;
        private System.Windows.Forms.Button btnSaveGood;
    }
}