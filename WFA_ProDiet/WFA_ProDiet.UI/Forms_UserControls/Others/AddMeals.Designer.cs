namespace WFA_ProDiet.UI
{
    partial class AddMeals
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewFood = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.lstDailyMeal = new System.Windows.Forms.ListBox();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.lblMealName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbOrderByFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.btnAddMeal = new FontAwesome.Sharp.IconButton();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WFA_ProDiet.UI.Properties.Resources.HomePageBanner;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.BackgroundImage = global::WFA_ProDiet.UI.Properties.Resources.WhatsApp_Image_2023_03_03_at_14_29_51;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUser.IconColor = System.Drawing.Color.Black;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.Location = new System.Drawing.Point(941, 0);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(100, 100);
            this.btnUser.TabIndex = 0;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(80)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(61)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 60;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(0, 583);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1041, 67);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "GERİ DÖN";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvFoods
            // 
            this.dgvFoods.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFoods.Location = new System.Drawing.Point(416, 166);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.RowTemplate.Height = 25;
            this.dgvFoods.Size = new System.Drawing.Size(625, 417);
            this.dgvFoods.TabIndex = 3;
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(12, 31);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(192, 27);
            this.txtSearchFood.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yemek Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(111, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aradığınızı bulamadınız mı? ";
            // 
            // btnAddNewFood
            // 
            this.btnAddNewFood.FlatAppearance.BorderSize = 0;
            this.btnAddNewFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewFood.ForeColor = System.Drawing.Color.Navy;
            this.btnAddNewFood.IconChar = FontAwesome.Sharp.IconChar.Fish;
            this.btnAddNewFood.IconColor = System.Drawing.Color.Navy;
            this.btnAddNewFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewFood.IconSize = 30;
            this.btnAddNewFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewFood.Location = new System.Drawing.Point(111, 125);
            this.btnAddNewFood.Name = "btnAddNewFood";
            this.btnAddNewFood.Size = new System.Drawing.Size(192, 28);
            this.btnAddNewFood.TabIndex = 7;
            this.btnAddNewFood.Text = "Yeni Yemek Ekle";
            this.btnAddNewFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewFood.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 483);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.lstDailyMeal);
            this.panel4.Controls.Add(this.dtpMealDate);
            this.panel4.Controls.Add(this.lblMealName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 319);
            this.panel4.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnUpdate);
            this.panel6.Controls.Add(this.btnRemove);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 274);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(416, 45);
            this.panel6.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(204, 45);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnRemove.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 45;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.Location = new System.Drawing.Point(204, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(212, 45);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Sil";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lstDailyMeal
            // 
            this.lstDailyMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstDailyMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDailyMeal.FormattingEnabled = true;
            this.lstDailyMeal.ItemHeight = 20;
            this.lstDailyMeal.Location = new System.Drawing.Point(0, 73);
            this.lstDailyMeal.Name = "lstDailyMeal";
            this.lstDailyMeal.Size = new System.Drawing.Size(416, 246);
            this.lstDailyMeal.TabIndex = 2;
            // 
            // dtpMealDate
            // 
            this.dtpMealDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpMealDate.Location = new System.Drawing.Point(0, 46);
            this.dtpMealDate.Name = "dtpMealDate";
            this.dtpMealDate.Size = new System.Drawing.Size(416, 27);
            this.dtpMealDate.TabIndex = 1;
            // 
            // lblMealName
            // 
            this.lblMealName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMealName.Font = new System.Drawing.Font("Segoe MDL2 Assets", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMealName.Location = new System.Drawing.Point(0, 0);
            this.lblMealName.Name = "lblMealName";
            this.lblMealName.Size = new System.Drawing.Size(416, 46);
            this.lblMealName.TabIndex = 1;
            this.lblMealName.Text = "KAHVALTI";
            this.lblMealName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbOrderByFilter);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnAddNewFood);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtSearchFood);
            this.panel5.Controls.Add(this.btnOrder);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(416, 164);
            this.panel5.TabIndex = 9;
            // 
            // cbOrderByFilter
            // 
            this.cbOrderByFilter.FormattingEnabled = true;
            this.cbOrderByFilter.Items.AddRange(new object[] {
            "Ketojenik diyet için ideal ( düşük karbonhidrat )",
            "Dukan diyeti için ideal ( yüksek protein )",
            "Kaloriye göre azalan",
            "Kaloriye göre artan",
            "Proteine göre azalan",
            "Proteine göre artan",
            "Karbonhidrata göre azalan",
            "Karbonhidrata göre artan",
            "Yağa göre azalan",
            "Yağa göre artan",
            ""});
            this.cbOrderByFilter.Location = new System.Drawing.Point(210, 30);
            this.cbOrderByFilter.Name = "cbOrderByFilter";
            this.cbOrderByFilter.Size = new System.Drawing.Size(192, 28);
            this.cbOrderByFilter.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(210, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sıralama Filtresi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOrder.IconColor = System.Drawing.Color.Black;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.Location = new System.Drawing.Point(12, 64);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(390, 34);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "SIRALA";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMeal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddMeal.FlatAppearance.BorderSize = 0;
            this.btnAddMeal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(80)))));
            this.btnAddMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(61)))));
            this.btnAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMeal.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnAddMeal.Font = new System.Drawing.Font("Segoe MDL2 Assets", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMeal.ForeColor = System.Drawing.Color.Black;
            this.btnAddMeal.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnAddMeal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddMeal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMeal.IconSize = 40;
            this.btnAddMeal.Location = new System.Drawing.Point(466, 0);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnAddMeal.Size = new System.Drawing.Size(159, 66);
            this.btnAddMeal.TabIndex = 7;
            this.btnAddMeal.Text = "EKLE";
            this.btnAddMeal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddMeal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMeal.UseVisualStyleBackColor = false;
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(50, 19);
            this.txtFood.Name = "txtFood";
            this.txtFood.ReadOnly = true;
            this.txtFood.Size = new System.Drawing.Size(157, 27);
            this.txtFood.TabIndex = 9;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(213, 19);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(53, 27);
            this.nudQuantity.TabIndex = 10;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblMeasure);
            this.panel3.Controls.Add(this.nudQuantity);
            this.panel3.Controls.Add(this.btnAddMeal);
            this.panel3.Controls.Add(this.txtFood);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(416, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 66);
            this.panel3.TabIndex = 9;
            // 
            // lblMeasure
            // 
            this.lblMeasure.Location = new System.Drawing.Point(272, 19);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(90, 27);
            this.lblMeasure.TabIndex = 11;
            this.lblMeasure.Text = "fincan/kase";
            // 
            // AddMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 650);
            this.Controls.Add(this.dgvFoods);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddMeals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMeals";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnClose;
        private DataGridView dgvFoods;
        private TextBox txtSearchFood;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnAddNewFood;
        private Panel panel2;
        private Panel panel4;
        private Label lblMealName;
        private FontAwesome.Sharp.IconButton btnOrder;
        private ComboBox cbOrderByFilter;
        private FontAwesome.Sharp.IconButton btnAddMeal;
        private TextBox txtFood;
        private NumericUpDown nudQuantity;
        private Panel panel3;
        private Label lblMeasure;
        private DateTimePicker dtpMealDate;
        private Panel panel5;
        private ListBox lstDailyMeal;
        private Label label3;
        private Panel panel6;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnRemove;
    }
}