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
            panel1 = new Panel();
            btnUser = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            dgvFoods = new DataGridView();
            txtSearchFood = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAddNewFood = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            btnUpdate = new FontAwesome.Sharp.IconButton();
            btnRemove = new FontAwesome.Sharp.IconButton();
            lstDailyMeal = new ListBox();
            dtpMealDate = new DateTimePicker();
            lblMealName = new Label();
            panel5 = new Panel();
            cbOrderByFilter = new ComboBox();
            label3 = new Label();
            btnOrder = new FontAwesome.Sharp.IconButton();
            btnAddMeal = new FontAwesome.Sharp.IconButton();
            txtFood = new TextBox();
            nudQuantity = new NumericUpDown();
            panel3 = new Panel();
            lblMeasure = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.HomePageBanner;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 100);
            panel1.TabIndex = 1;
            // 
            // btnUser
            // 
            btnUser.BackgroundImage = Properties.Resources.WhatsApp_Image_2023_03_03_at_14_29_51;
            btnUser.BackgroundImageLayout = ImageLayout.Zoom;
            btnUser.Dock = DockStyle.Right;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUser.IconColor = Color.Black;
            btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUser.Location = new Point(941, 0);
            btnUser.Margin = new Padding(4);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(100, 100);
            btnUser.TabIndex = 0;
            btnUser.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Dock = DockStyle.Bottom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 120, 80);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 197, 61);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnClose.IconColor = Color.Black;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 60;
            btnClose.ImageAlign = ContentAlignment.TopCenter;
            btnClose.Location = new Point(0, 583);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(1041, 67);
            btnClose.TabIndex = 2;
            btnClose.Text = "GERİ DÖN";
            btnClose.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvFoods
            // 
            dgvFoods.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.Dock = DockStyle.Fill;
            dgvFoods.Location = new Point(416, 166);
            dgvFoods.MultiSelect = false;
            dgvFoods.Name = "dgvFoods";
            dgvFoods.RowTemplate.Height = 25;
            dgvFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoods.Size = new Size(625, 417);
            dgvFoods.TabIndex = 3;
            dgvFoods.CellContentClick += dgvFoods_CellContentClick;
            dgvFoods.SelectionChanged += dgvFoods_SelectionChanged;
            // 
            // txtSearchFood
            // 
            txtSearchFood.Location = new Point(12, 31);
            txtSearchFood.Name = "txtSearchFood";
            txtSearchFood.Size = new Size(192, 27);
            txtSearchFood.TabIndex = 4;
            txtSearchFood.TextChanged += txtSearchFood_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(192, 24);
            label1.TabIndex = 5;
            label1.Text = "Yemek Adı";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Location = new Point(111, 102);
            label2.Name = "label2";
            label2.Size = new Size(192, 24);
            label2.TabIndex = 6;
            label2.Text = "Aradığınızı bulamadınız mı? ";
            // 
            // btnAddNewFood
            // 
            btnAddNewFood.FlatAppearance.BorderSize = 0;
            btnAddNewFood.FlatStyle = FlatStyle.Flat;
            btnAddNewFood.ForeColor = Color.Navy;
            btnAddNewFood.IconChar = FontAwesome.Sharp.IconChar.Fish;
            btnAddNewFood.IconColor = Color.Navy;
            btnAddNewFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddNewFood.IconSize = 30;
            btnAddNewFood.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNewFood.Location = new Point(111, 125);
            btnAddNewFood.Name = "btnAddNewFood";
            btnAddNewFood.Size = new Size(192, 28);
            btnAddNewFood.TabIndex = 7;
            btnAddNewFood.Text = "Yeni Yemek Ekle";
            btnAddNewFood.TextAlign = ContentAlignment.MiddleLeft;
            btnAddNewFood.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddNewFood.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 483);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(lstDailyMeal);
            panel4.Controls.Add(dtpMealDate);
            panel4.Controls.Add(lblMealName);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 164);
            panel4.Name = "panel4";
            panel4.Size = new Size(416, 319);
            panel4.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnUpdate);
            panel6.Controls.Add(btnRemove);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 274);
            panel6.Name = "panel6";
            panel6.Size = new Size(416, 45);
            panel6.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Left;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 198, 198);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            btnUpdate.IconColor = Color.FromArgb(192, 192, 0);
            btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdate.Location = new Point(0, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(204, 45);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Güncelle";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Dock = DockStyle.Right;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 198, 198);
            btnRemove.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            btnRemove.IconColor = Color.FromArgb(192, 0, 0);
            btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemove.IconSize = 45;
            btnRemove.ImageAlign = ContentAlignment.MiddleRight;
            btnRemove.Location = new Point(204, 0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(212, 45);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Sil";
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lstDailyMeal
            // 
            lstDailyMeal.BackColor = Color.FromArgb(224, 224, 224);
            lstDailyMeal.Dock = DockStyle.Fill;
            lstDailyMeal.FormattingEnabled = true;
            lstDailyMeal.ItemHeight = 20;
            lstDailyMeal.Location = new Point(0, 73);
            lstDailyMeal.Name = "lstDailyMeal";
            lstDailyMeal.Size = new Size(416, 246);
            lstDailyMeal.TabIndex = 2;
            lstDailyMeal.SelectedIndexChanged += lstDailyMeal_SelectedIndexChanged;
            // 
            // dtpMealDate
            // 
            dtpMealDate.Dock = DockStyle.Top;
            dtpMealDate.Location = new Point(0, 46);
            dtpMealDate.Name = "dtpMealDate";
            dtpMealDate.Size = new Size(416, 27);
            dtpMealDate.TabIndex = 1;
            dtpMealDate.ValueChanged += dtpMealDate_ValueChanged;
            // 
            // lblMealName
            // 
            lblMealName.Dock = DockStyle.Top;
            lblMealName.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMealName.Location = new Point(0, 0);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(416, 46);
            lblMealName.TabIndex = 1;
            lblMealName.Text = "KAHVALTI";
            lblMealName.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(cbOrderByFilter);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(btnAddNewFood);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtSearchFood);
            panel5.Controls.Add(btnOrder);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(416, 164);
            panel5.TabIndex = 9;
            // 
            // cbOrderByFilter
            // 
            cbOrderByFilter.FormattingEnabled = true;
            cbOrderByFilter.Items.AddRange(new object[] { "Ketojenik diyet için ideal ( düşük karbonhidrat )", "Dukan diyeti için ideal ( yüksek protein )", "Kaloriye göre azalan", "Kaloriye göre artan", "Proteine göre azalan", "Proteine göre artan", "Karbonhidrata göre azalan", "Karbonhidrata göre artan", "Yağa göre azalan", "Yağa göre artan", "" });
            cbOrderByFilter.Location = new Point(210, 30);
            cbOrderByFilter.Name = "cbOrderByFilter";
            cbOrderByFilter.Size = new Size(192, 28);
            cbOrderByFilter.TabIndex = 6;
            cbOrderByFilter.SelectedIndexChanged += cbOrderByFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Location = new Point(210, 4);
            label3.Name = "label3";
            label3.Size = new Size(192, 24);
            label3.TabIndex = 5;
            label3.Text = "Sıralama Filtresi";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Transparent;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 198, 198);
            btnOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 197, 62);
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            btnOrder.IconColor = Color.Black;
            btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOrder.Location = new Point(12, 64);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(390, 34);
            btnOrder.TabIndex = 7;
            btnOrder.Text = "SIRALA";
            btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnAddMeal
            // 
            btnAddMeal.BackColor = Color.Transparent;
            btnAddMeal.Dock = DockStyle.Right;
            btnAddMeal.FlatAppearance.BorderSize = 0;
            btnAddMeal.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 120, 80);
            btnAddMeal.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 197, 61);
            btnAddMeal.FlatStyle = FlatStyle.Flat;
            btnAddMeal.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnAddMeal.Font = new Font("Segoe MDL2 Assets", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMeal.ForeColor = Color.Black;
            btnAddMeal.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            btnAddMeal.IconColor = Color.FromArgb(0, 64, 0);
            btnAddMeal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddMeal.IconSize = 40;
            btnAddMeal.Location = new Point(466, 0);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Padding = new Padding(0, 6, 0, 0);
            btnAddMeal.Size = new Size(159, 66);
            btnAddMeal.TabIndex = 7;
            btnAddMeal.Text = "EKLE";
            btnAddMeal.TextAlign = ContentAlignment.TopCenter;
            btnAddMeal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddMeal.UseVisualStyleBackColor = false;
            btnAddMeal.Click += btnAddMeal_Click;
            // 
            // txtFood
            // 
            txtFood.Location = new Point(50, 19);
            txtFood.Name = "txtFood";
            txtFood.ReadOnly = true;
            txtFood.Size = new Size(157, 27);
            txtFood.TabIndex = 9;
            txtFood.TextChanged += txtFood_TextChanged;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(213, 19);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(53, 27);
            nudQuantity.TabIndex = 10;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel3
            // 
            panel3.Controls.Add(lblMeasure);
            panel3.Controls.Add(nudQuantity);
            panel3.Controls.Add(btnAddMeal);
            panel3.Controls.Add(txtFood);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(416, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(625, 66);
            panel3.TabIndex = 9;
            // 
            // lblMeasure
            // 
            lblMeasure.Location = new Point(272, 19);
            lblMeasure.Name = "lblMeasure";
            lblMeasure.Size = new Size(90, 27);
            lblMeasure.TabIndex = 11;
            lblMeasure.Text = "fincan/kase";
            // 
            // AddMeals
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1041, 650);
            Controls.Add(dgvFoods);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AddMeals";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMeals";
            Load += AddMeals_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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