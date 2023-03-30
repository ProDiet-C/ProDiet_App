namespace WFA_ProDiet.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlCommercial = new Panel();
            pbCommercial = new PictureBox();
            pnlUserLogin = new Panel();
            label3 = new Label();
            btnLogin = new FontAwesome.Sharp.IconButton();
            txtEmail = new TextBox();
            txtPassword = new MaskedTextBox();
            btnShowPassword = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            lnkCreateAccount = new LinkLabel();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            pnlCommercial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCommercial).BeginInit();
            pnlUserLogin.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCommercial
            // 
            pnlCommercial.AutoScroll = true;
            pnlCommercial.Controls.Add(pbCommercial);
            pnlCommercial.Dock = DockStyle.Left;
            pnlCommercial.Location = new Point(0, 0);
            pnlCommercial.Name = "pnlCommercial";
            pnlCommercial.Size = new Size(415, 583);
            pnlCommercial.TabIndex = 0;
            // 
            // pbCommercial
            // 
            pbCommercial.BackgroundImageLayout = ImageLayout.Stretch;
            pbCommercial.Image = Properties.Resources.HomePage2;
            pbCommercial.Location = new Point(3, 0);
            pbCommercial.Name = "pbCommercial";
            pbCommercial.Size = new Size(394, 1602);
            pbCommercial.SizeMode = PictureBoxSizeMode.CenterImage;
            pbCommercial.TabIndex = 0;
            pbCommercial.TabStop = false;
            // 
            // pnlUserLogin
            // 
            pnlUserLogin.Controls.Add(label3);
            pnlUserLogin.Controls.Add(btnLogin);
            pnlUserLogin.Controls.Add(txtEmail);
            pnlUserLogin.Controls.Add(txtPassword);
            pnlUserLogin.Controls.Add(btnShowPassword);
            pnlUserLogin.Controls.Add(label1);
            pnlUserLogin.Controls.Add(lnkCreateAccount);
            pnlUserLogin.Controls.Add(label2);
            pnlUserLogin.Location = new Point(17, 30);
            pnlUserLogin.Name = "pnlUserLogin";
            pnlUserLogin.Size = new Size(275, 132);
            pnlUserLogin.TabIndex = 8;
            // 
            // label3
            // 
            label3.Location = new Point(19, 82);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 6;
            label3.Text = "Hesabınız yok mu ?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnLogin.IconColor = Color.FromArgb(142, 197, 62);
            btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogin.IconSize = 30;
            btnLogin.Location = new Point(156, 64);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 60);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Giris";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(63, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(63, 35);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(168, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnShowPassword
            // 
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            btnShowPassword.IconColor = Color.Black;
            btnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnShowPassword.IconSize = 25;
            btnShowPassword.Location = new Point(237, 34);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(23, 23);
            btnShowPassword.TabIndex = 5;
            btnShowPassword.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Email :";
            // 
            // lnkCreateAccount
            // 
            lnkCreateAccount.AutoSize = true;
            lnkCreateAccount.LinkColor = Color.Teal;
            lnkCreateAccount.Location = new Point(31, 105);
            lnkCreateAccount.Name = "lnkCreateAccount";
            lnkCreateAccount.Size = new Size(82, 15);
            lnkCreateAccount.TabIndex = 4;
            lnkCreateAccount.TabStop = true;
            lnkCreateAccount.Text = "Hesap Oluştur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 43);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre :";
            // 
            // label4
            // 
            label4.Location = new Point(17, 230);
            label4.Name = "label4";
            label4.Size = new Size(275, 336);
            label4.TabIndex = 9;
            label4.Text = "Mert Akdur\r\n\r\nAtakan Bektaş\r\n\r\nOğuz Kağan\r\n\r\nİlkiz Kasapoğlu\r\n\r\nMehmet Mustafa Özcan\r\n\r\nMert Akdur\r\n\r\nAtakan Bektaş\r\n\r\nOğuz Kağan\r\n\r\nİlkiz Kasapoğlu\r\n\r\nMehmet Mustafa Özcan\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 204);
            label5.Name = "label5";
            label5.Size = new Size(275, 23);
            label5.TabIndex = 10;
            label5.Text = "TOP 10 Kullanıcı";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pnlUserLogin);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(415, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 583);
            panel1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 583);
            Controls.Add(panel1);
            Controls.Add(pnlCommercial);
            Name = "Form1";
            Text = "Form1";
            pnlCommercial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCommercial).EndInit();
            pnlUserLogin.ResumeLayout(false);
            pnlUserLogin.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCommercial;
        private PictureBox pbCommercial;
        private LinkLabel lnkCreateAccount;
        private Label label2;
        private Label label1;
        private MaskedTextBox txtPassword;
        private TextBox txtEmail;
        private FontAwesome.Sharp.IconButton btnLogin;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnShowPassword;
        private Panel pnlUserLogin;
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}