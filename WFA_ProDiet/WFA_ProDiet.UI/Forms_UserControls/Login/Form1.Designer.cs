﻿namespace WFA_ProDiet.UI
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
            this.components = new System.ComponentModel.Container();
            this.pnlCommercial = new System.Windows.Forms.Panel();
            this.pbCommercial = new System.Windows.Forms.PictureBox();
            this.pnlUserLogin = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnShowPassword = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmrFirstOpen = new System.Windows.Forms.Timer(this.components);
            this.pnlCommercial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommercial)).BeginInit();
            this.pnlUserLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCommercial
            // 
            this.pnlCommercial.AutoScroll = true;
            this.pnlCommercial.Controls.Add(this.pbCommercial);
            this.pnlCommercial.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCommercial.Location = new System.Drawing.Point(0, 0);
            this.pnlCommercial.Name = "pnlCommercial";
            this.pnlCommercial.Size = new System.Drawing.Size(415, 583);
            this.pnlCommercial.TabIndex = 0;
            // 
            // pbCommercial
            // 
            this.pbCommercial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCommercial.Image = global::WFA_ProDiet.UI.Properties.Resources.HomePage2;
            this.pbCommercial.Location = new System.Drawing.Point(3, 0);
            this.pbCommercial.Name = "pbCommercial";
            this.pbCommercial.Size = new System.Drawing.Size(394, 1602);
            this.pbCommercial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCommercial.TabIndex = 0;
            this.pbCommercial.TabStop = false;
            // 
            // pnlUserLogin
            // 
            this.pnlUserLogin.Controls.Add(this.label3);
            this.pnlUserLogin.Controls.Add(this.btnLogin);
            this.pnlUserLogin.Controls.Add(this.txtEmail);
            this.pnlUserLogin.Controls.Add(this.txtPassword);
            this.pnlUserLogin.Controls.Add(this.btnShowPassword);
            this.pnlUserLogin.Controls.Add(this.label1);
            this.pnlUserLogin.Controls.Add(this.lnkCreateAccount);
            this.pnlUserLogin.Controls.Add(this.label2);
            this.pnlUserLogin.Location = new System.Drawing.Point(17, 30);
            this.pnlUserLogin.Name = "pnlUserLogin";
            this.pnlUserLogin.Size = new System.Drawing.Size(275, 132);
            this.pnlUserLogin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hesabınız yok mu ?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 30;
            this.btnLogin.Location = new System.Drawing.Point(156, 64);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 60);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Giris";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(63, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(63, 35);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnShowPassword.IconColor = System.Drawing.Color.Black;
            this.btnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowPassword.IconSize = 25;
            this.btnShowPassword.Location = new System.Drawing.Point(237, 34);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(23, 23);
            this.btnShowPassword.TabIndex = 5;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email :";
            // 
            // lnkCreateAccount
            // 
            this.lnkCreateAccount.AutoSize = true;
            this.lnkCreateAccount.LinkColor = System.Drawing.Color.Teal;
            this.lnkCreateAccount.Location = new System.Drawing.Point(31, 105);
            this.lnkCreateAccount.Name = "lnkCreateAccount";
            this.lnkCreateAccount.Size = new System.Drawing.Size(82, 15);
            this.lnkCreateAccount.TabIndex = 4;
            this.lnkCreateAccount.TabStop = true;
            this.lnkCreateAccount.Text = "Hesap Oluştur";
            this.lnkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCreateAccount_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 336);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mert Akdur\r\n\r\nAtakan Bektaş\r\n\r\nOğuz Kağan\r\n\r\nİlkiz Kasapoğlu\r\n\r\nMehmet Mustafa Öz" +
    "can\r\n\r\nMert Akdur\r\n\r\nAtakan Bektaş\r\n\r\nOğuz Kağan\r\n\r\nİlkiz Kasapoğlu\r\n\r\nMehmet Mu" +
    "stafa Özcan\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "TOP 10 Kullanıcı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pnlUserLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(415, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 583);
            this.panel1.TabIndex = 11;
            // 
            // tmrFirstOpen
            // 
            this.tmrFirstOpen.Interval = 30;
            this.tmrFirstOpen.Tick += new System.EventHandler(this.tmrFirstOpen_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCommercial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCommercial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCommercial)).EndInit();
            this.pnlUserLogin.ResumeLayout(false);
            this.pnlUserLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Timer tmrFirstOpen;
    }
}