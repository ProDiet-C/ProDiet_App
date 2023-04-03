namespace WFA_ProDiet.UI
{
    partial class UcEditFoods
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
            btnAdd = new FontAwesome.Sharp.IconButton();
            dgvFoods = new DataGridView();
            panel1 = new Panel();
            pbFood = new PictureBox();
            btnAddPict = new Button();
            cbCategory = new ComboBox();
            nudQuantity = new NumericUpDown();
            nudCalorieQ = new NumericUpDown();
            nudFatQ = new NumericUpDown();
            nudCarbohydrateQ = new NumericUpDown();
            nudProteinQ = new NumericUpDown();
            cbMeasure = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFoodName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCalorieQ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFatQ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCarbohydrateQ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProteinQ).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 198, 198);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            btnAdd.Font = new Font("Segoe MDL2 Assets", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAdd.IconColor = Color.FromArgb(141, 197, 62);
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 50;
            btnAdd.Location = new Point(597, 106);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(270, 73);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Ekle";
            btnAdd.TextAlign = ContentAlignment.TopCenter;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvFoods
            // 
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.Dock = DockStyle.Fill;
            dgvFoods.Location = new Point(0, 0);
            dgvFoods.Name = "dgvFoods";
            dgvFoods.ReadOnly = true;
            dgvFoods.RowTemplate.Height = 25;
            dgvFoods.Size = new Size(960, 254);
            dgvFoods.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbFood);
            panel1.Controls.Add(btnAddPict);
            panel1.Controls.Add(cbCategory);
            panel1.Controls.Add(nudQuantity);
            panel1.Controls.Add(nudCalorieQ);
            panel1.Controls.Add(nudFatQ);
            panel1.Controls.Add(nudCarbohydrateQ);
            panel1.Controls.Add(nudProteinQ);
            panel1.Controls.Add(cbMeasure);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtFoodName);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 306);
            panel1.TabIndex = 6;
            // 
            // pbFood
            // 
            pbFood.Location = new Point(35, 12);
            pbFood.Name = "pbFood";
            pbFood.Size = new Size(150, 150);
            pbFood.TabIndex = 12;
            pbFood.TabStop = false;
            // 
            // btnAddPict
            // 
            btnAddPict.Location = new Point(35, 173);
            btnAddPict.Name = "btnAddPict";
            btnAddPict.Size = new Size(150, 47);
            btnAddPict.TabIndex = 9;
            btnAddPict.Text = "Resim Ekle";
            btnAddPict.UseVisualStyleBackColor = true;
            btnAddPict.Click += btnAddPict_Click;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Hepsi", "Av Hayvanları", "Balıklar", "Bitkisel Yağlar", "Çeşniler", "Çorbalar", "Deniz Ürünleri", "Diğer Besinler", "Ekmek vb.", "Et Ürünleri", "Hayvansal Yağlar", "İçecekler", "Kırmızı Etler", "Kurubaklagiller", "Kümes Hayvanları", "Meyveler", "Peynirler", "Sakatatlar", "Sebzeler", "Soslar", "Süt ve Süt Ürünleri", "Şeker ve Şeker Ürünleri", "Tahıl Ürünleri", "Tatlılar", "Yumurtalar" });
            cbCategory.Location = new Point(363, 250);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(156, 29);
            cbCategory.TabIndex = 7;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(363, 218);
            nudQuantity.Margin = new Padding(8, 11, 8, 11);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(156, 28);
            nudQuantity.TabIndex = 6;
            // 
            // nudCalorieQ
            // 
            nudCalorieQ.Location = new Point(363, 148);
            nudCalorieQ.Margin = new Padding(8, 11, 8, 11);
            nudCalorieQ.Name = "nudCalorieQ";
            nudCalorieQ.Size = new Size(156, 28);
            nudCalorieQ.TabIndex = 4;
            // 
            // nudFatQ
            // 
            nudFatQ.Location = new Point(363, 114);
            nudFatQ.Margin = new Padding(6, 8, 6, 8);
            nudFatQ.Name = "nudFatQ";
            nudFatQ.Size = new Size(156, 28);
            nudFatQ.TabIndex = 3;
            // 
            // nudCarbohydrateQ
            // 
            nudCarbohydrateQ.Location = new Point(363, 80);
            nudCarbohydrateQ.Margin = new Padding(5, 6, 5, 6);
            nudCarbohydrateQ.Name = "nudCarbohydrateQ";
            nudCarbohydrateQ.Size = new Size(156, 28);
            nudCarbohydrateQ.TabIndex = 2;
            // 
            // nudProteinQ
            // 
            nudProteinQ.Location = new Point(363, 46);
            nudProteinQ.Margin = new Padding(4);
            nudProteinQ.Name = "nudProteinQ";
            nudProteinQ.Size = new Size(156, 28);
            nudProteinQ.TabIndex = 1;
            // 
            // cbMeasure
            // 
            cbMeasure.FormattingEnabled = true;
            cbMeasure.Items.AddRange(new object[] { "gram", "adet", "dilim", "fincan", "kutu", "kadeh", "porsiyon", "baş", "bütün", "tatlı kaşığı", "bardak" });
            cbMeasure.Location = new Point(363, 182);
            cbMeasure.Name = "cbMeasure";
            cbMeasure.Size = new Size(156, 29);
            cbMeasure.TabIndex = 5;
            // 
            // label8
            // 
            label8.Location = new Point(191, 250);
            label8.Name = "label8";
            label8.Size = new Size(166, 29);
            label8.TabIndex = 6;
            label8.Text = "Kategori :";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(191, 216);
            label7.Name = "label7";
            label7.Size = new Size(166, 28);
            label7.TabIndex = 6;
            label7.Text = "Miktar :";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(191, 182);
            label6.Name = "label6";
            label6.Size = new Size(166, 28);
            label6.TabIndex = 6;
            label6.Text = "Ölçü Birimi :";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(191, 148);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 6;
            label5.Text = "Kalori Miktarı :";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(191, 114);
            label4.Name = "label4";
            label4.Size = new Size(166, 28);
            label4.TabIndex = 6;
            label4.Text = "Yağ Miktarı :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(191, 80);
            label3.Name = "label3";
            label3.Size = new Size(166, 28);
            label3.TabIndex = 6;
            label3.Text = "Karbonhidrat Miktarı :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(191, 46);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 6;
            label2.Text = "Protein Miktarı :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new Point(191, 12);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 6;
            label1.Text = "Ad :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(363, 12);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(156, 28);
            txtFoodName.TabIndex = 0;
            // 
            // UcEditFoods
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvFoods);
            Controls.Add(panel1);
            Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UcEditFoods";
            Size = new Size(960, 560);
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCalorieQ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFatQ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCarbohydrateQ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProteinQ).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAdd;
        private DataGridView dgvFoods;
        private Panel panel1;
        private NumericUpDown nudProteinQ;
        private ComboBox cbMeasure;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtFoodName;
        private ComboBox cbCategory;
        private NumericUpDown nudCalorieQ;
        private NumericUpDown nudFatQ;
        private NumericUpDown nudCarbohydrateQ;
        private Label label8;
        private Label label7;
        private PictureBox pbFood;
        private Button btnAddPict;
        private NumericUpDown nudQuantity;
    }
}
