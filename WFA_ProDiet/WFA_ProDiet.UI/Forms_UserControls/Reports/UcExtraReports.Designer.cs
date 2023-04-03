namespace WFA_ProDiet.UI
{
    partial class UcExtraReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoryDetail = new System.Windows.Forms.ComboBox();
            this.cbMealDetail = new System.Windows.Forms.ComboBox();
            this.btnLeastConsumed = new FontAwesome.Sharp.IconButton();
            this.btnMostConsumed = new FontAwesome.Sharp.IconButton();
            this.dgvExtraReports = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbCategoryDetail);
            this.panel1.Controls.Add(this.cbMealDetail);
            this.panel1.Controls.Add(this.btnLeastConsumed);
            this.panel1.Controls.Add(this.btnMostConsumed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(729, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 560);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Seçiniz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğün Seçiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCategoryDetail
            // 
            this.cbCategoryDetail.FormattingEnabled = true;
            this.cbCategoryDetail.Items.AddRange(new object[] {
            "Hepsi",
            "Av Hayvanları",
            "Balıklar",
            "Bitkisel Yağlar",
            "Çeşniler",
            "Çorbalar",
            "Deniz Ürünleri",
            "Diğer Besinler",
            "Ekmek vb.",
            "Et Ürünleri",
            "Hayvansal Yağlar",
            "İçecekler",
            "Kırmızı Etler",
            "Kurubaklagiller",
            "Kümes Hayvanları",
            "Meyveler",
            "Peynirler",
            "Sakatatlar",
            "Sebzeler",
            "Soslar",
            "Süt ve Süt Ürünleri",
            "Şeker ve Şeker Ürünleri",
            "Tahıl Ürünleri",
            "Tatlılar",
            "Yumurtalar"});
            this.cbCategoryDetail.Location = new System.Drawing.Point(23, 240);
            this.cbCategoryDetail.Name = "cbCategoryDetail";
            this.cbCategoryDetail.Size = new System.Drawing.Size(190, 29);
            this.cbCategoryDetail.TabIndex = 1;
            // 
            // cbMealDetail
            // 
            this.cbMealDetail.FormattingEnabled = true;
            this.cbMealDetail.Items.AddRange(new object[] {
            "Hepsi",
            "Kahvaltı",
            "Öğle Yemeği",
            "Akşam Yemeği",
            "Ekstra"});
            this.cbMealDetail.Location = new System.Drawing.Point(23, 164);
            this.cbMealDetail.Name = "cbMealDetail";
            this.cbMealDetail.Size = new System.Drawing.Size(190, 29);
            this.cbMealDetail.TabIndex = 0;
            // 
            // btnLeastConsumed
            // 
            this.btnLeastConsumed.BackColor = System.Drawing.Color.Transparent;
            this.btnLeastConsumed.FlatAppearance.BorderSize = 0;
            this.btnLeastConsumed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnLeastConsumed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLeastConsumed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeastConsumed.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnLeastConsumed.Font = new System.Drawing.Font("Roboto Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeastConsumed.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.btnLeastConsumed.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLeastConsumed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeastConsumed.Location = new System.Drawing.Point(3, 335);
            this.btnLeastConsumed.Name = "btnLeastConsumed";
            this.btnLeastConsumed.Size = new System.Drawing.Size(225, 57);
            this.btnLeastConsumed.TabIndex = 3;
            this.btnLeastConsumed.Text = "En az tüketilenler";
            this.btnLeastConsumed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeastConsumed.UseVisualStyleBackColor = false;
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            cbCategoryDetail = new ComboBox();
            cbMealDetail = new ComboBox();
            btnLeastConsumed = new FontAwesome.Sharp.IconButton();
            btnMostConsumed = new FontAwesome.Sharp.IconButton();
            dgvExtraReports = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExtraReports).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbCategoryDetail);
            panel1.Controls.Add(cbMealDetail);
            panel1.Controls.Add(btnLeastConsumed);
            panel1.Controls.Add(btnMostConsumed);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(729, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 560);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(23, 201);
            label2.Name = "label2";
            label2.Size = new Size(190, 36);
            label2.TabIndex = 3;
            label2.Text = "Kategori Seçiniz";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(23, 125);
            label1.Name = "label1";
            label1.Size = new Size(190, 36);
            label1.TabIndex = 3;
            label1.Text = "Öğün Seçiniz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbCategoryDetail
            // 
            cbCategoryDetail.FormattingEnabled = true;
            cbCategoryDetail.Items.AddRange(new object[] { "Hepsi", "Av Hayvanları", "Balıklar", "Bitkisel Yağlar", "Çeşniler", "Çorbalar", "Deniz Ürünleri", "Diğer Besinler", "Ekmek vb.", "Et Ürünleri", "Hayvansal Yağlar", "İçecekler", "Kırmızı Etler", "Kurubaklagiller", "Kümes Hayvanları", "Meyveler", "Peynirler", "Sakatatlar", "Sebzeler", "Soslar", "Süt ve Süt Ürünleri", "Şeker ve Şeker Ürünleri", "Tahıl Ürünleri", "Tatlılar", "Yumurtalar" });
            cbCategoryDetail.Location = new Point(23, 240);
            cbCategoryDetail.Name = "cbCategoryDetail";
            cbCategoryDetail.Size = new Size(190, 29);
            cbCategoryDetail.TabIndex = 2;
            // 
            // cbMealDetail
            // 
            cbMealDetail.FormattingEnabled = true;
            cbMealDetail.Items.AddRange(new object[] { "Hepsi", "Kahvaltı", "Öğle Yemeği", "Akşam Yemeği", "Ekstra" });
            cbMealDetail.Location = new Point(23, 164);
            cbMealDetail.Name = "cbMealDetail";
            cbMealDetail.Size = new Size(190, 29);
            cbMealDetail.TabIndex = 1;
            // 
            // btnLeastConsumed
            // 
            btnLeastConsumed.BackColor = Color.Transparent;
            btnLeastConsumed.FlatAppearance.BorderSize = 0;
            btnLeastConsumed.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 198, 198);
            btnLeastConsumed.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnLeastConsumed.FlatStyle = FlatStyle.Flat;
            btnLeastConsumed.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            btnLeastConsumed.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeastConsumed.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            btnLeastConsumed.IconColor = Color.FromArgb(192, 0, 0);
            btnLeastConsumed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLeastConsumed.Location = new Point(3, 335);
            btnLeastConsumed.Name = "btnLeastConsumed";
            btnLeastConsumed.Size = new Size(225, 57);
            btnLeastConsumed.TabIndex = 0;
            btnLeastConsumed.Text = "En az tüketilenler";
            btnLeastConsumed.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLeastConsumed.UseVisualStyleBackColor = false;
            btnLeastConsumed.Click += btnLeastConsumed_Click;
            // 
            // btnMostConsumed
            // 
            btnMostConsumed.BackColor = Color.Transparent;
            btnMostConsumed.FlatAppearance.BorderSize = 0;
            btnMostConsumed.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 198, 198);
            btnMostConsumed.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 197, 62);
            btnMostConsumed.FlatStyle = FlatStyle.Flat;
            btnMostConsumed.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostConsumed.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            btnMostConsumed.IconColor = Color.Green;
            btnMostConsumed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMostConsumed.Location = new Point(3, 276);
            btnMostConsumed.Name = "btnMostConsumed";
            btnMostConsumed.Size = new Size(225, 53);
            btnMostConsumed.TabIndex = 0;
            btnMostConsumed.Text = "En çok tüketilenler";
            btnMostConsumed.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostConsumed.UseVisualStyleBackColor = false;
            btnMostConsumed.Click += btnMostConsumed_Click;

            // 
            // btnMostConsumed
            // 
            this.btnMostConsumed.BackColor = System.Drawing.Color.Transparent;
            this.btnMostConsumed.FlatAppearance.BorderSize = 0;
            this.btnMostConsumed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.btnMostConsumed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.btnMostConsumed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostConsumed.Font = new System.Drawing.Font("Roboto Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostConsumed.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.btnMostConsumed.IconColor = System.Drawing.Color.Green;
            this.btnMostConsumed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostConsumed.Location = new System.Drawing.Point(3, 276);
            this.btnMostConsumed.Name = "btnMostConsumed";
            this.btnMostConsumed.Size = new System.Drawing.Size(225, 53);
            this.btnMostConsumed.TabIndex = 2;
            this.btnMostConsumed.Text = "En çok tüketilenler";
            this.btnMostConsumed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostConsumed.UseVisualStyleBackColor = false;
            // 
            // dgvExtraReports
            // 
            dgvExtraReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExtraReports.Dock = DockStyle.Fill;
            dgvExtraReports.Location = new Point(0, 0);
            dgvExtraReports.Name = "dgvExtraReports";
            dgvExtraReports.RowTemplate.Height = 25;
            dgvExtraReports.Size = new Size(729, 560);
            dgvExtraReports.TabIndex = 1;
            // 
            // UcExtraReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvExtraReports);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcExtraReports";
            this.Size = new System.Drawing.Size(960, 560);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraReports)).EndInit();
            this.ResumeLayout(false);

            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvExtraReports);
            Controls.Add(panel1);
            Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UcExtraReports";
            Size = new Size(960, 560);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExtraReports).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox cbMealDetail;
        private FontAwesome.Sharp.IconButton btnMostConsumed;
        private Label label2;
        private Label label1;
        private ComboBox cbCategoryDetail;
        private FontAwesome.Sharp.IconButton btnLeastConsumed;
        private DataGridView dgvExtraReports;
    }
}
