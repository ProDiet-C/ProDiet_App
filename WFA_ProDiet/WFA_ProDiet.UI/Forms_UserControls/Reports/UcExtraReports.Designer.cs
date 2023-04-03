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
            cbCategoryDetail.Items.AddRange(new object[] { "Hepsi", "Av Hayvanları", "Balıklar", "Bitkisel Yağlar", "Çeşniler", "Çorbalar", "Deniz Ürünleri", "Diğer Besinler", "Ekmek Vb. Ürünler", "Et Ürünleri", "Hayvansal Yağlar", "İçecekler", "Kırmızı Etler", "Kurubaklagiller", "Kümes Hayvanları", "Meyveler", "Peynirler", "Sakatatlar", "Sebzeler", "Soslar", "Süt ve Ürünleri", "Şeker ve Şeker Ürünleri", "Tahıl Ürünleri", "Tatlılar", "Yumurtalar" });
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
            btnMostConsumed.TabIndex = 2;
            btnMostConsumed.Text = "En çok tüketilenler";
            btnMostConsumed.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostConsumed.UseVisualStyleBackColor = false;
            btnMostConsumed.Click += btnMostConsumed_Click;
            // 
            // dgvExtraReports
            // 
            dgvExtraReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
