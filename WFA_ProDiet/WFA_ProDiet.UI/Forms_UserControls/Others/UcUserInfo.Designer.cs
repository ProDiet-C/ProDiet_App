namespace WFA_ProDiet.UI
{
    partial class UcUserInfo
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
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbAktivite = new ComboBox();
            dtpBirthDate = new DateTimePicker();
            nudHeight = new NumericUpDown();
            nudWeight = new NumericUpDown();
            label6 = new Label();
            label9 = new Label();
            pbUserPic = new PictureBox();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            ıconButton2 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUserPic).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(180, 209);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(230, 27);
            txtLastName.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(4, 209);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 27);
            label2.TabIndex = 1;
            label2.Text = "Soyad :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(180, 174);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(230, 27);
            txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(4, 174);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 27);
            label1.TabIndex = 1;
            label1.Text = "Ad :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(180, 141);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(4, 141);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 27);
            label3.TabIndex = 1;
            label3.Text = "Kullanıcı Adı / Eposta :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(4, 241);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 27);
            label4.TabIndex = 1;
            label4.Text = "Doğum Tarihi :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(5, 277);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(168, 27);
            label5.TabIndex = 1;
            label5.Text = "Aktivite Düzeyi :";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(4, 349);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(168, 27);
            label7.TabIndex = 1;
            label7.Text = "Kilo :";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Location = new Point(4, 314);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(168, 27);
            label8.TabIndex = 1;
            label8.Text = "Boy :";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbAktivite
            // 
            cbAktivite.FormattingEnabled = true;
            cbAktivite.Items.AddRange(new object[] { "Aktivite Yok (Masabaşı iş-Hareketsiz)", "Az Aktif (Hafif egzersizler-Günlük işler)", "Aktif (Hafta 2-4 gün spor)", "Çok Aktif (Haftada 4+ gün spor)" });
            cbAktivite.Location = new Point(181, 276);
            cbAktivite.Name = "cbAktivite";
            cbAktivite.Size = new Size(230, 28);
            cbAktivite.TabIndex = 2;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(180, 243);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(230, 27);
            dtpBirthDate.TabIndex = 3;
            // 
            // nudHeight
            // 
            nudHeight.Location = new Point(180, 314);
            nudHeight.Margin = new Padding(4);
            nudHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 130, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(49, 27);
            nudHeight.TabIndex = 4;
            nudHeight.Value = new decimal(new int[] { 130, 0, 0, 0 });
            // 
            // nudWeight
            // 
            nudWeight.Location = new Point(180, 349);
            nudWeight.Margin = new Padding(5);
            nudWeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudWeight.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(49, 27);
            nudWeight.TabIndex = 4;
            nudWeight.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // label6
            // 
            label6.Location = new Point(236, 314);
            label6.Name = "label6";
            label6.Size = new Size(38, 27);
            label6.TabIndex = 5;
            label6.Text = "cm";
            // 
            // label9
            // 
            label9.Location = new Point(236, 349);
            label9.Name = "label9";
            label9.Size = new Size(47, 27);
            label9.TabIndex = 5;
            label9.Text = "kg";
            // 
            // pbUserPic
            // 
            pbUserPic.BackColor = Color.Transparent;
            pbUserPic.BorderStyle = BorderStyle.Fixed3D;
            pbUserPic.Image = Properties.Resources.WhatsApp_Image_2023_03_03_at_14_29_51;
            pbUserPic.Location = new Point(144, 3);
            pbUserPic.Name = "pbUserPic";
            pbUserPic.Size = new Size(121, 99);
            pbUserPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserPic.TabIndex = 6;
            pbUserPic.TabStop = false;
            // 
            // ıconButton1
            // 
            ıconButton1.BackColor = Color.Transparent;
            ıconButton1.FlatAppearance.BorderSize = 0;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 35;
            ıconButton1.Location = new Point(146, 78);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(25, 24);
            ıconButton1.TabIndex = 7;
            ıconButton1.UseVisualStyleBackColor = false;
            ıconButton1.Click += ıconButton1_Click;
            // 
            // ıconButton2
            // 
            ıconButton2.BackColor = Color.Transparent;
            ıconButton2.Dock = DockStyle.Bottom;
            ıconButton2.FlatAppearance.BorderSize = 0;
            ıconButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 198, 198);
            ıconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(165, 197, 62);
            ıconButton2.FlatStyle = FlatStyle.Flat;
            ıconButton2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ıconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconButton2.IconColor = Color.Black;
            ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton2.Location = new Point(0, 441);
            ıconButton2.Name = "ıconButton2";
            ıconButton2.Size = new Size(414, 119);
            ıconButton2.TabIndex = 8;
            ıconButton2.Text = "Değişikleri Kaydet";
            ıconButton2.UseVisualStyleBackColor = false;
            ıconButton2.Click += ıconButton2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(rbFemale);
            panel1.Controls.Add(rbMale);
            panel1.Controls.Add(ıconButton1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(pbUserPic);
            panel1.Controls.Add(ıconButton2);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(nudWeight);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(nudHeight);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpBirthDate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbAktivite);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 560);
            panel1.TabIndex = 9;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(252, 384);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(64, 24);
            rbFemale.TabIndex = 9;
            rbFemale.TabStop = true;
            rbFemale.Text = "Kadın";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(180, 384);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(66, 24);
            rbMale.TabIndex = 9;
            rbMale.TabStop = true;
            rbMale.Text = "Erkek";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.AktiviteDüzey;
            pictureBox2.Location = new Point(414, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(546, 560);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // UcUserInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UcUserInfo";
            Size = new Size(960, 560);
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUserPic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private ComboBox cbAktivite;
        private DateTimePicker dtpBirthDate;
        private NumericUpDown nudHeight;
        private NumericUpDown nudWeight;
        private Label label6;
        private Label label9;
        private PictureBox pbUserPic;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private Panel panel1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private PictureBox pictureBox2;
    }
}
