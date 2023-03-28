namespace WFA_ProDiet.UI
{
    partial class ucProPlan
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCreatePlan = new FontAwesome.Sharp.IconButton();
            this.lnkProTakip = new System.Windows.Forms.LinkLabel();
            this.nudCurrentWeight = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.dtpTargetDate = new System.Windows.Forms.DateTimePicker();
            this.nudTargetWeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGainWeigth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.Location = new System.Drawing.Point(0, 403);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(960, 157);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreatePlan
            // 
            this.btnCreatePlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreatePlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.btnCreatePlan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.btnCreatePlan.FlatAppearance.BorderSize = 0;
            this.btnCreatePlan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCreatePlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCreatePlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePlan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreatePlan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreatePlan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCreatePlan.IconColor = System.Drawing.Color.Black;
            this.btnCreatePlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreatePlan.Location = new System.Drawing.Point(356, 216);
            this.btnCreatePlan.Name = "btnCreatePlan";
            this.btnCreatePlan.Size = new System.Drawing.Size(248, 65);
            this.btnCreatePlan.TabIndex = 12;
            this.btnCreatePlan.Text = "Plan Oluştur";
            this.btnCreatePlan.UseVisualStyleBackColor = false;
            // 
            // lnkProTakip
            // 
            this.lnkProTakip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkProTakip.Font = new System.Drawing.Font("Segoe MDL2 Assets", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnkProTakip.Location = new System.Drawing.Point(433, 345);
            this.lnkProTakip.Name = "lnkProTakip";
            this.lnkProTakip.Size = new System.Drawing.Size(123, 47);
            this.lnkProTakip.TabIndex = 20;
            this.lnkProTakip.TabStop = true;
            this.lnkProTakip.Text = "ProTakip";
            this.lnkProTakip.Visible = false;
            // 
            // nudCurrentWeight
            // 
            this.nudCurrentWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudCurrentWeight.DecimalPlaces = 1;
            this.nudCurrentWeight.Location = new System.Drawing.Point(494, 98);
            this.nudCurrentWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCurrentWeight.Name = "nudCurrentWeight";
            this.nudCurrentWeight.Size = new System.Drawing.Size(102, 27);
            this.nudCurrentWeight.TabIndex = 9;
            // 
            // nudHeight
            // 
            this.nudHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudHeight.Location = new System.Drawing.Point(495, 65);
            this.nudHeight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(101, 27);
            this.nudHeight.TabIndex = 10;
            // 
            // dtpTargetDate
            // 
            this.dtpTargetDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTargetDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTargetDate.Location = new System.Drawing.Point(490, 174);
            this.dtpTargetDate.Name = "dtpTargetDate";
            this.dtpTargetDate.Size = new System.Drawing.Size(106, 27);
            this.dtpTargetDate.TabIndex = 19;
            // 
            // nudTargetWeight
            // 
            this.nudTargetWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudTargetWeight.DecimalPlaces = 1;
            this.nudTargetWeight.Location = new System.Drawing.Point(494, 135);
            this.nudTargetWeight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nudTargetWeight.Name = "nudTargetWeight";
            this.nudTargetWeight.Size = new System.Drawing.Size(102, 27);
            this.nudTargetWeight.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mevcut Ağırlığı (kg):";
            // 
            // lblGainWeigth
            // 
            this.lblGainWeigth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGainWeigth.AutoSize = true;
            this.lblGainWeigth.Location = new System.Drawing.Point(84, 325);
            this.lblGainWeigth.Name = "lblGainWeigth";
            this.lblGainWeigth.Size = new System.Drawing.Size(813, 20);
            this.lblGainWeigth.TabIndex = 18;
            this.lblGainWeigth.Text = "Ulaşmak istediğiniz kilo için kalorisi yüksek ürünler tercih etmelisiniz. Pro Tak" +
    "ip  linkine tıklayarak sürecinizi yönetebilirsiniz.";
            this.lblGainWeigth.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hedef Ağırlığı (kg): ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Boy  (cm):";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hedef Tarihi :";
            // 
            // ucProPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCreatePlan);
            this.Controls.Add(this.lnkProTakip);
            this.Controls.Add(this.nudCurrentWeight);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.dtpTargetDate);
            this.Controls.Add(this.nudTargetWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGainWeigth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucProPlan";
            this.Size = new System.Drawing.Size(960, 560);
            ((System.ComponentModel.ISupportInitialize)(this.nudCurrentWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblInfo;
        private FontAwesome.Sharp.IconButton btnCreatePlan;
        private LinkLabel lnkProTakip;
        private NumericUpDown nudCurrentWeight;
        private NumericUpDown nudHeight;
        private DateTimePicker dtpTargetDate;
        private NumericUpDown nudTargetWeight;
        private Label label1;
        private Label lblGainWeigth;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}
