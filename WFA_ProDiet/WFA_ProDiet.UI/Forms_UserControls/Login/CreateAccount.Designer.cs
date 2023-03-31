namespace WFA_ProDiet.UI
{
    partial class CreateAccount
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            panel1 = new Panel();
            pnlUserInfo = new Panel();
            btnAddPhoto = new FontAwesome.Sharp.IconButton();
            btnInfo = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            lblInfo = new Label();
            label7 = new Label();
            pbUser = new PictureBox();
            label8 = new Label();
            label10 = new Label();
            nudWeight = new NumericUpDown();
            nudHeight = new NumericUpDown();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label9 = new Label();
            label6 = new Label();
            dtpBirthDate = new DateTimePicker();
            cbActivityLevel = new ComboBox();
            panel2 = new Panel();
            panel4 = new Panel();
            btnContinue = new FontAwesome.Sharp.IconButton();
            txtPasswordCheck = new MaskedTextBox();
            txtPassword = new MaskedTextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            lblWelcome = new Label();
            tmrWelcome = new System.Windows.Forms.Timer(components);
            tmrOpenForm = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlUserInfo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(545, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 541);
            panel1.TabIndex = 0;
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(224, 224, 224);
            pnlUserInfo.Controls.Add(btnAddPhoto);
            pnlUserInfo.Controls.Add(btnInfo);
            pnlUserInfo.Controls.Add(label5);
            pnlUserInfo.Controls.Add(lblInfo);
            pnlUserInfo.Controls.Add(label7);
            pnlUserInfo.Controls.Add(pbUser);
            pnlUserInfo.Controls.Add(label8);
            pnlUserInfo.Controls.Add(label10);
            pnlUserInfo.Controls.Add(nudWeight);
            pnlUserInfo.Controls.Add(nudHeight);
            pnlUserInfo.Controls.Add(rbFemale);
            pnlUserInfo.Controls.Add(rbMale);
            pnlUserInfo.Controls.Add(label9);
            pnlUserInfo.Controls.Add(label6);
            pnlUserInfo.Controls.Add(dtpBirthDate);
            pnlUserInfo.Controls.Add(cbActivityLevel);
            pnlUserInfo.Dock = DockStyle.Fill;
            pnlUserInfo.Location = new Point(0, 0);
            pnlUserInfo.Name = "pnlUserInfo";
            pnlUserInfo.Size = new Size(0, 541);
            pnlUserInfo.TabIndex = 27;
            pnlUserInfo.Visible = false;
            // 
            // btnAddPhoto
            // 
            btnAddPhoto.Anchor = AnchorStyles.None;
            btnAddPhoto.BackColor = Color.Transparent;
            btnAddPhoto.FlatAppearance.BorderSize = 0;
            btnAddPhoto.FlatStyle = FlatStyle.Flat;
            btnAddPhoto.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddPhoto.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAddPhoto.IconColor = Color.FromArgb(141, 197, 62);
            btnAddPhoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddPhoto.IconSize = 30;
            btnAddPhoto.Location = new Point(-57, 4);
            btnAddPhoto.Name = "btnAddPhoto";
            btnAddPhoto.Size = new Size(48, 28);
            btnAddPhoto.TabIndex = 4;
            btnAddPhoto.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            btnInfo.Anchor = AnchorStyles.None;
            btnInfo.BackColor = Color.Transparent;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnInfo.IconColor = Color.FromArgb(64, 0, 0);
            btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInfo.IconSize = 25;
            btnInfo.Location = new Point(124, 189);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(33, 30);
            btnInfo.TabIndex = 26;
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.MouseEnter += btnInfo_MouseEnter;
            btnInfo.MouseLeave += btnInfo_MouseLeave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Location = new Point(-198, 193);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 27);
            label5.TabIndex = 10;
            label5.Text = "Aktivite Düzeyi :";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.BackColor = SystemColors.Info;
            lblInfo.Font = new Font("Segoe MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.FromArgb(0, 0, 64);
            lblInfo.Location = new Point(-198, 222);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(356, 300);
            lblInfo.TabIndex = 25;
            lblInfo.Text = resources.GetString("lblInfo.Text");
            lblInfo.Visible = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Location = new Point(4, 62);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 27);
            label7.TabIndex = 11;
            label7.Text = "Kilo :";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbUser
            // 
            pbUser.Anchor = AnchorStyles.None;
            pbUser.BackColor = Color.Transparent;
            pbUser.BorderStyle = BorderStyle.Fixed3D;
            pbUser.Image = Properties.Resources.Atakan;
            pbUser.Location = new Point(-159, 4);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(150, 150);
            pbUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbUser.TabIndex = 24;
            pbUser.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Location = new Point(-199, 157);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(118, 27);
            label8.TabIndex = 12;
            label8.Text = "Doğum Tarihi :";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.Location = new Point(4, 27);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(56, 27);
            label10.TabIndex = 13;
            label10.Text = "Boy :";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nudWeight
            // 
            nudWeight.Anchor = AnchorStyles.None;
            nudWeight.Location = new Point(67, 61);
            nudWeight.Margin = new Padding(6, 7, 6, 7);
            nudWeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudWeight.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(63, 28);
            nudWeight.TabIndex = 22;
            nudWeight.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // nudHeight
            // 
            nudHeight.Anchor = AnchorStyles.None;
            nudHeight.Location = new Point(67, 26);
            nudHeight.Margin = new Padding(5, 6, 5, 6);
            nudHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 130, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(63, 28);
            nudHeight.TabIndex = 23;
            nudHeight.Value = new decimal(new int[] { 130, 0, 0, 0 });
            // 
            // rbFemale
            // 
            rbFemale.Anchor = AnchorStyles.None;
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(93, 100);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(65, 25);
            rbFemale.TabIndex = 20;
            rbFemale.TabStop = true;
            rbFemale.Text = "Kadın";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.Anchor = AnchorStyles.None;
            rbMale.AutoSize = true;
            rbMale.Location = new Point(13, 100);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(67, 25);
            rbMale.TabIndex = 21;
            rbMale.TabStop = true;
            rbMale.Text = "Erkek";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.Location = new Point(134, 65);
            label9.Name = "label9";
            label9.Size = new Size(47, 27);
            label9.TabIndex = 18;
            label9.Text = "kg";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Location = new Point(134, 30);
            label6.Name = "label6";
            label6.Size = new Size(38, 27);
            label6.TabIndex = 19;
            label6.Text = "cm";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Anchor = AnchorStyles.None;
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(-74, 157);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(230, 28);
            dtpBirthDate.TabIndex = 15;
            // 
            // cbActivityLevel
            // 
            cbActivityLevel.Anchor = AnchorStyles.None;
            cbActivityLevel.FormattingEnabled = true;
            cbActivityLevel.Items.AddRange(new object[] { "Aktivite Yok (Masabaşı iş-Hareketsiz)", "Az Aktif (Hafif egzersizler-Günlük işler)", "Aktif (Hafta 2-4 gün spor)", "Çok Aktif (Haftada 4+ gün spor)" });
            cbActivityLevel.Location = new Point(-73, 190);
            cbActivityLevel.Name = "cbActivityLevel";
            cbActivityLevel.Size = new Size(191, 29);
            cbActivityLevel.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lblWelcome);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(545, 541);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnContinue);
            panel4.Controls.Add(txtPasswordCheck);
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(txtName);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 153);
            panel4.Name = "panel4";
            panel4.Size = new Size(545, 388);
            panel4.TabIndex = 6;
            // 
            // btnContinue
            // 
            btnContinue.Anchor = AnchorStyles.None;
            btnContinue.FlatAppearance.BorderColor = Color.FromArgb(198, 198, 198);
            btnContinue.FlatAppearance.MouseDownBackColor = Color.FromArgb(198, 198, 198);
            btnContinue.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 197, 62);
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnContinue.IconChar = FontAwesome.Sharp.IconChar.None;
            btnContinue.IconColor = Color.Black;
            btnContinue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnContinue.Location = new Point(223, 163);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(211, 35);
            btnContinue.TabIndex = 4;
            btnContinue.Text = "Devam Et";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // txtPasswordCheck
            // 
            txtPasswordCheck.Anchor = AnchorStyles.None;
            txtPasswordCheck.Location = new Point(223, 129);
            txtPasswordCheck.Name = "txtPasswordCheck";
            txtPasswordCheck.Size = new Size(211, 28);
            txtPasswordCheck.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(223, 95);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(211, 28);
            txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(223, 61);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 28);
            txtEmail.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Location = new Point(223, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(211, 28);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Location = new Point(44, 129);
            label3.Name = "label3";
            label3.Size = new Size(162, 28);
            label3.TabIndex = 0;
            label3.Text = "Şifre Tekrar :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Location = new Point(44, 95);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 0;
            label2.Text = "Şifre :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Location = new Point(44, 61);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 0;
            label4.Text = "E-mail :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(44, 27);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.FromArgb(141, 197, 62);
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Image = Properties.Resources.PRODİET_TRANSPARAN_DENEME_13;
            lblWelcome.ImageAlign = ContentAlignment.MiddleLeft;
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(545, 153);
            lblWelcome.TabIndex = 5;
            lblWelcome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tmrWelcome
            // 
            tmrWelcome.Tick += tmrWelcome_Tick;
            // 
            // tmrOpenForm
            // 
            tmrOpenForm.Interval = 10;
            tmrOpenForm.Tick += tmrOpenForm_Tick;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(544, 541);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccount";
            Load += CreateAccount_Load;
            panel1.ResumeLayout(false);
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnContinue;
        private MaskedTextBox txtPasswordCheck;
        private MaskedTextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label7;
        private DateTimePicker dtpBirthDate;
        private Label label8;
        private ComboBox cbActivityLevel;
        private Label label10;
        private NumericUpDown nudWeight;
        private NumericUpDown nudHeight;
        private PictureBox pbUser;
        private FontAwesome.Sharp.IconButton btnInfo;
        private Label lblInfo;
        private Label lblWelcome;
        private Panel pnlUserInfo;
        private Panel panel4;
        private System.Windows.Forms.Timer tmrWelcome;
        private FontAwesome.Sharp.IconButton btnAddPhoto;
        private System.Windows.Forms.Timer tmrOpenForm;
    }
}