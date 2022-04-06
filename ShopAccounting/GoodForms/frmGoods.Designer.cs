namespace ShopAccounting
{
    partial class frmGoods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilterGoods = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefreshGoods = new System.Windows.Forms.Button();
            this.btnDeleteGood = new System.Windows.Forms.Button();
            this.btnEditGood = new System.Windows.Forms.Button();
            this.btnAddGood = new System.Windows.Forms.Button();
            this.dgGoods = new System.Windows.Forms.DataGridView();
            this.GoodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(149)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.txtFilterGoods);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRefreshGoods);
            this.panel1.Controls.Add(this.btnDeleteGood);
            this.panel1.Controls.Add(this.btnEditGood);
            this.panel1.Controls.Add(this.btnAddGood);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 104);
            this.panel1.TabIndex = 1;
            // 
            // txtFilterGoods
            // 
            this.txtFilterGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(221)))));
            this.txtFilterGoods.Font = new System.Drawing.Font("Estedad", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterGoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.txtFilterGoods.Location = new System.Drawing.Point(12, 41);
            this.txtFilterGoods.Name = "txtFilterGoods";
            this.txtFilterGoods.Size = new System.Drawing.Size(143, 27);
            this.txtFilterGoods.TabIndex = 5;
            this.txtFilterGoods.TextChanged += new System.EventHandler(this.txtFilterCustomers_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Estedad", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(161, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "جستجو :";
            // 
            // btnRefreshGoods
            // 
            this.btnRefreshGoods.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefreshGoods.FlatAppearance.BorderSize = 0;
            this.btnRefreshGoods.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(153)))), ((int)(((byte)(126)))));
            this.btnRefreshGoods.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.btnRefreshGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshGoods.Font = new System.Drawing.Font("Estedad", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshGoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnRefreshGoods.Image = global::ShopAccounting.Properties.Resources.icons8_repeat_64;
            this.btnRefreshGoods.Location = new System.Drawing.Point(235, 0);
            this.btnRefreshGoods.Name = "btnRefreshGoods";
            this.btnRefreshGoods.Size = new System.Drawing.Size(115, 104);
            this.btnRefreshGoods.TabIndex = 3;
            this.btnRefreshGoods.Text = "بروزرسانی";
            this.btnRefreshGoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshGoods.UseVisualStyleBackColor = true;
            this.btnRefreshGoods.Click += new System.EventHandler(this.btnRefreshGoods_Click);
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteGood.FlatAppearance.BorderSize = 0;
            this.btnDeleteGood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(153)))), ((int)(((byte)(126)))));
            this.btnDeleteGood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.btnDeleteGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGood.Font = new System.Drawing.Font("Estedad", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnDeleteGood.Image = global::ShopAccounting.Properties.Resources.icons8_delete_document_64;
            this.btnDeleteGood.Location = new System.Drawing.Point(350, 0);
            this.btnDeleteGood.Name = "btnDeleteGood";
            this.btnDeleteGood.Size = new System.Drawing.Size(115, 104);
            this.btnDeleteGood.TabIndex = 2;
            this.btnDeleteGood.Text = "حذف کالا";
            this.btnDeleteGood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteGood.UseVisualStyleBackColor = true;
            this.btnDeleteGood.Click += new System.EventHandler(this.btnDeleteGood_Click);
            // 
            // btnEditGood
            // 
            this.btnEditGood.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditGood.FlatAppearance.BorderSize = 0;
            this.btnEditGood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(153)))), ((int)(((byte)(126)))));
            this.btnEditGood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.btnEditGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGood.Font = new System.Drawing.Font("Estedad", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnEditGood.Image = global::ShopAccounting.Properties.Resources.icons8_compose_64;
            this.btnEditGood.Location = new System.Drawing.Point(465, 0);
            this.btnEditGood.Name = "btnEditGood";
            this.btnEditGood.Size = new System.Drawing.Size(115, 104);
            this.btnEditGood.TabIndex = 1;
            this.btnEditGood.Text = "ویرایش کالا";
            this.btnEditGood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditGood.UseVisualStyleBackColor = true;
            this.btnEditGood.Click += new System.EventHandler(this.btnEditGood_Click);
            // 
            // btnAddGood
            // 
            this.btnAddGood.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddGood.FlatAppearance.BorderSize = 0;
            this.btnAddGood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(153)))), ((int)(((byte)(126)))));
            this.btnAddGood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.btnAddGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGood.Font = new System.Drawing.Font("Estedad", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.btnAddGood.Image = global::ShopAccounting.Properties.Resources.icons8_add_tag_64;
            this.btnAddGood.Location = new System.Drawing.Point(580, 0);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(115, 104);
            this.btnAddGood.TabIndex = 0;
            this.btnAddGood.Text = "افزودن کالا";
            this.btnAddGood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddGood.UseVisualStyleBackColor = true;
            this.btnAddGood.Click += new System.EventHandler(this.btnAddGood_Click);
            // 
            // dgGoods
            // 
            this.dgGoods.AllowUserToAddRows = false;
            this.dgGoods.AllowUserToDeleteRows = false;
            this.dgGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGoods.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(210)))));
            this.dgGoods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsID,
            this.Goodname,
            this.GoodPrice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Estedad", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgGoods.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGoods.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.dgGoods.Location = new System.Drawing.Point(0, 104);
            this.dgGoods.Name = "dgGoods";
            this.dgGoods.ReadOnly = true;
            this.dgGoods.Size = new System.Drawing.Size(695, 457);
            this.dgGoods.TabIndex = 2;
            // 
            // GoodsID
            // 
            this.GoodsID.DataPropertyName = "GoodID";
            this.GoodsID.HeaderText = "Column1";
            this.GoodsID.Name = "GoodsID";
            this.GoodsID.ReadOnly = true;
            this.GoodsID.Visible = false;
            // 
            // Goodname
            // 
            this.Goodname.DataPropertyName = "GoodName";
            this.Goodname.HeaderText = "نام کالا";
            this.Goodname.Name = "Goodname";
            this.Goodname.ReadOnly = true;
            // 
            // GoodPrice
            // 
            this.GoodPrice.DataPropertyName = "GoodPrice";
            this.GoodPrice.HeaderText = "قیمت";
            this.GoodPrice.Name = "GoodPrice";
            this.GoodPrice.ReadOnly = true;
            // 
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(695, 561);
            this.Controls.Add(this.dgGoods);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Estedad", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmGoods";
            this.Opacity = 0.96D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت کالاها";
            this.Load += new System.EventHandler(this.frmGoods_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFilterGoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshGoods;
        private System.Windows.Forms.Button btnDeleteGood;
        private System.Windows.Forms.Button btnEditGood;
        private System.Windows.Forms.Button btnAddGood;
        private System.Windows.Forms.DataGridView dgGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodPrice;
    }
}