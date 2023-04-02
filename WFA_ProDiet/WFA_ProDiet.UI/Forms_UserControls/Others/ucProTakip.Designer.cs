namespace WFA_ProDiet.UI
{
    partial class ucProTakip
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
            pnlCurrentKcal = new Panel();
            dtpMealDate = new DateTimePicker();
            label2 = new Label();
            lblTargetCalorie = new Label();
            flpMeals = new FlowLayoutPanel();
            pnlBreakFast = new Panel();
            lblCurrentKcalBF = new Label();
            label9 = new Label();
            label8 = new Label();
            lblTargetKcalBF = new Label();
            label5 = new Label();
            label4 = new Label();
            lblBreakfast = new Label();
            btnAddBreakFast = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblCurrentKcalLunch = new Label();
            label11 = new Label();
            label12 = new Label();
            lblTargetKcalLunch = new Label();
            label14 = new Label();
            label15 = new Label();
            lblLunch = new Label();
            btnAddLunch = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            lblCurrentKcalDinner = new Label();
            label18 = new Label();
            label19 = new Label();
            lblTargetKcalDinner = new Label();
            label21 = new Label();
            label22 = new Label();
            lblDinner = new Label();
            btnAddDinner = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            lblCurrentKcalExtra = new Label();
            label25 = new Label();
            label28 = new Label();
            lblExtra = new Label();
            btnAddExtra = new FontAwesome.Sharp.IconButton();
            pnlCurrentKcal.SuspendLayout();
            flpMeals.SuspendLayout();
            pnlBreakFast.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCurrentKcal
            // 
            pnlCurrentKcal.Controls.Add(dtpMealDate);
            pnlCurrentKcal.Controls.Add(label2);
            pnlCurrentKcal.Controls.Add(lblTargetCalorie);
            pnlCurrentKcal.Dock = DockStyle.Fill;
            pnlCurrentKcal.Location = new Point(0, 0);
            pnlCurrentKcal.Name = "pnlCurrentKcal";
            pnlCurrentKcal.Size = new Size(960, 560);
            pnlCurrentKcal.TabIndex = 0;
            // 
            // dtpMealDate
            // 
            dtpMealDate.Location = new Point(12, 52);
            dtpMealDate.Name = "dtpMealDate";
            dtpMealDate.Size = new Size(246, 27);
            dtpMealDate.TabIndex = 2;
            dtpMealDate.ValueChanged += dtpMealDate_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 64, 0);
            label2.Location = new Point(537, 47);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 0;
            label2.Text = "kcal";
            // 
            // lblTargetCalorie
            // 
            lblTargetCalorie.Anchor = AnchorStyles.Top;
            lblTargetCalorie.AutoSize = true;
            lblTargetCalorie.Font = new Font("Segoe MDL2 Assets", 50.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTargetCalorie.ForeColor = Color.Green;
            lblTargetCalorie.Location = new Point(407, 0);
            lblTargetCalorie.Name = "lblTargetCalorie";
            lblTargetCalorie.Size = new Size(141, 67);
            lblTargetCalorie.TabIndex = 0;
            lblTargetCalorie.Text = "1180";
            // 
            // flpMeals
            // 
            flpMeals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpMeals.AutoScroll = true;
            flpMeals.BackColor = Color.FromArgb(255, 224, 192);
            flpMeals.BackgroundImageLayout = ImageLayout.Stretch;
            flpMeals.Controls.Add(pnlBreakFast);
            flpMeals.Controls.Add(panel2);
            flpMeals.Controls.Add(panel3);
            flpMeals.Controls.Add(panel4);
            flpMeals.Location = new Point(0, 82);
            flpMeals.Name = "flpMeals";
            flpMeals.Size = new Size(960, 478);
            flpMeals.TabIndex = 1;
            // 
            // pnlBreakFast
            // 
            pnlBreakFast.BackColor = Color.Transparent;
            pnlBreakFast.BackgroundImage = Properties.Resources.WhatsApp_Image_2023_03_28_at_17_021;
            pnlBreakFast.BorderStyle = BorderStyle.Fixed3D;
            pnlBreakFast.Controls.Add(lblCurrentKcalBF);
            pnlBreakFast.Controls.Add(label9);
            pnlBreakFast.Controls.Add(label8);
            pnlBreakFast.Controls.Add(lblTargetKcalBF);
            pnlBreakFast.Controls.Add(label5);
            pnlBreakFast.Controls.Add(label4);
            pnlBreakFast.Controls.Add(lblBreakfast);
            pnlBreakFast.Controls.Add(btnAddBreakFast);
            pnlBreakFast.Location = new Point(12, 3);
            pnlBreakFast.Margin = new Padding(12, 3, 8, 3);
            pnlBreakFast.Name = "pnlBreakFast";
            pnlBreakFast.Size = new Size(460, 210);
            pnlBreakFast.TabIndex = 0;
            // 
            // lblCurrentKcalBF
            // 
            lblCurrentKcalBF.BackColor = Color.Transparent;
            lblCurrentKcalBF.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentKcalBF.Location = new Point(150, 166);
            lblCurrentKcalBF.Name = "lblCurrentKcalBF";
            lblCurrentKcalBF.Size = new Size(53, 20);
            lblCurrentKcalBF.TabIndex = 4;
            lblCurrentKcalBF.Text = "425";
            lblCurrentKcalBF.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(206, 166);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 3;
            label9.Text = "kcal";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(206, 140);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 3;
            label8.Text = "kcal";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTargetKcalBF
            // 
            lblTargetKcalBF.BackColor = Color.Transparent;
            lblTargetKcalBF.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTargetKcalBF.Location = new Point(150, 140);
            lblTargetKcalBF.Name = "lblTargetKcalBF";
            lblTargetKcalBF.Size = new Size(53, 20);
            lblTargetKcalBF.TabIndex = 3;
            lblTargetKcalBF.Text = "355";
            lblTargetKcalBF.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 166);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 2;
            label5.Text = "Alınan Kalori :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 140);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 2;
            label4.Text = "Hedef Kalori :";
            // 
            // lblBreakfast
            // 
            lblBreakfast.BackColor = Color.Transparent;
            lblBreakfast.Font = new Font("Segoe MDL2 Assets", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBreakfast.Location = new Point(3, 3);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new Size(285, 55);
            lblBreakfast.TabIndex = 1;
            lblBreakfast.Text = "KAHVALTI";
            lblBreakfast.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddBreakFast
            // 
            btnAddBreakFast.BackColor = Color.Transparent;
            btnAddBreakFast.FlatAppearance.BorderSize = 0;
            btnAddBreakFast.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddBreakFast.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            btnAddBreakFast.FlatStyle = FlatStyle.Flat;
            btnAddBreakFast.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnAddBreakFast.IconColor = Color.Green;
            btnAddBreakFast.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddBreakFast.IconSize = 70;
            btnAddBreakFast.Location = new Point(3, 61);
            btnAddBreakFast.Name = "btnAddBreakFast";
            btnAddBreakFast.Size = new Size(285, 63);
            btnAddBreakFast.TabIndex = 0;
            btnAddBreakFast.UseVisualStyleBackColor = false;
            btnAddBreakFast.Click += btnAddBreakFast_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.BackgroundImage = Properties.Resources.WhatsApp_Image_2023_03_28_at_17_30_58;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lblCurrentKcalLunch);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(lblTargetKcalLunch);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(lblLunch);
            panel2.Controls.Add(btnAddLunch);
            panel2.Location = new Point(488, 3);
            panel2.Margin = new Padding(8, 3, 10, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 210);
            panel2.TabIndex = 1;
            // 
            // lblCurrentKcalLunch
            // 
            lblCurrentKcalLunch.BackColor = Color.Transparent;
            lblCurrentKcalLunch.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentKcalLunch.Location = new Point(150, 166);
            lblCurrentKcalLunch.Name = "lblCurrentKcalLunch";
            lblCurrentKcalLunch.Size = new Size(53, 20);
            lblCurrentKcalLunch.TabIndex = 4;
            lblCurrentKcalLunch.Text = "425";
            lblCurrentKcalLunch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(206, 166);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 3;
            label11.Text = "kcal";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(206, 140);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 3;
            label12.Text = "kcal";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTargetKcalLunch
            // 
            lblTargetKcalLunch.BackColor = Color.Transparent;
            lblTargetKcalLunch.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTargetKcalLunch.Location = new Point(150, 140);
            lblTargetKcalLunch.Name = "lblTargetKcalLunch";
            lblTargetKcalLunch.Size = new Size(53, 20);
            lblTargetKcalLunch.TabIndex = 3;
            lblTargetKcalLunch.Text = "355";
            lblTargetKcalLunch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(51, 166);
            label14.Name = "label14";
            label14.Size = new Size(100, 20);
            label14.TabIndex = 2;
            label14.Text = "Alınan Kalori :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(51, 140);
            label15.Name = "label15";
            label15.Size = new Size(100, 20);
            label15.TabIndex = 2;
            label15.Text = "Hedef Kalori :";
            // 
            // lblLunch
            // 
            lblLunch.BackColor = Color.Transparent;
            lblLunch.Font = new Font("Segoe MDL2 Assets", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLunch.Location = new Point(3, 3);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new Size(285, 55);
            lblLunch.TabIndex = 0;
            lblLunch.Text = "ÖĞLE YEMEĞİ";
            lblLunch.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddLunch
            // 
            btnAddLunch.BackColor = Color.Transparent;
            btnAddLunch.FlatAppearance.BorderSize = 0;
            btnAddLunch.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddLunch.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnAddLunch.FlatStyle = FlatStyle.Flat;
            btnAddLunch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnAddLunch.IconColor = Color.Green;
            btnAddLunch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddLunch.IconSize = 70;
            btnAddLunch.Location = new Point(3, 61);
            btnAddLunch.Name = "btnAddLunch";
            btnAddLunch.Size = new Size(285, 63);
            btnAddLunch.TabIndex = 0;
            btnAddLunch.UseVisualStyleBackColor = false;
            btnAddLunch.Click += btnAddLunch_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.WhatsApp_Image_2023_03_28_at_17_30_57;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblCurrentKcalDinner);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(lblTargetKcalDinner);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(lblDinner);
            panel3.Controls.Add(btnAddDinner);
            panel3.Location = new Point(12, 219);
            panel3.Margin = new Padding(12, 3, 8, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 210);
            panel3.TabIndex = 2;
            // 
            // lblCurrentKcalDinner
            // 
            lblCurrentKcalDinner.BackColor = Color.Transparent;
            lblCurrentKcalDinner.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentKcalDinner.Location = new Point(150, 165);
            lblCurrentKcalDinner.Name = "lblCurrentKcalDinner";
            lblCurrentKcalDinner.Size = new Size(53, 20);
            lblCurrentKcalDinner.TabIndex = 4;
            lblCurrentKcalDinner.Text = "425";
            lblCurrentKcalDinner.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(206, 165);
            label18.Name = "label18";
            label18.Size = new Size(53, 20);
            label18.TabIndex = 3;
            label18.Text = "kcal";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(206, 140);
            label19.Name = "label19";
            label19.Size = new Size(53, 20);
            label19.TabIndex = 3;
            label19.Text = "kcal";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTargetKcalDinner
            // 
            lblTargetKcalDinner.BackColor = Color.Transparent;
            lblTargetKcalDinner.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTargetKcalDinner.Location = new Point(150, 140);
            lblTargetKcalDinner.Name = "lblTargetKcalDinner";
            lblTargetKcalDinner.Size = new Size(53, 20);
            lblTargetKcalDinner.TabIndex = 3;
            lblTargetKcalDinner.Text = "355";
            lblTargetKcalDinner.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(51, 165);
            label21.Name = "label21";
            label21.Size = new Size(100, 20);
            label21.TabIndex = 2;
            label21.Text = "Alınan Kalori :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(51, 140);
            label22.Name = "label22";
            label22.Size = new Size(100, 20);
            label22.TabIndex = 0;
            label22.Text = "Hedef Kalori :";
            // 
            // lblDinner
            // 
            lblDinner.BackColor = Color.Transparent;
            lblDinner.Font = new Font("Segoe MDL2 Assets", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDinner.Location = new Point(3, 3);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new Size(285, 55);
            lblDinner.TabIndex = 1;
            lblDinner.Text = "AKŞAM YEMEĞİ";
            lblDinner.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddDinner
            // 
            btnAddDinner.BackColor = Color.Transparent;
            btnAddDinner.FlatAppearance.BorderSize = 0;
            btnAddDinner.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddDinner.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnAddDinner.FlatStyle = FlatStyle.Flat;
            btnAddDinner.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnAddDinner.IconColor = Color.Green;
            btnAddDinner.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddDinner.IconSize = 70;
            btnAddDinner.Location = new Point(3, 61);
            btnAddDinner.Name = "btnAddDinner";
            btnAddDinner.Size = new Size(285, 63);
            btnAddDinner.TabIndex = 0;
            btnAddDinner.UseVisualStyleBackColor = false;
            btnAddDinner.Click += btnAddDinner_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.BackgroundImage = Properties.Resources.WhatsApp_Image_2023_03_28_at_17_02_00;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(lblCurrentKcalExtra);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(label28);
            panel4.Controls.Add(lblExtra);
            panel4.Controls.Add(btnAddExtra);
            panel4.Location = new Point(488, 219);
            panel4.Margin = new Padding(8, 3, 10, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 210);
            panel4.TabIndex = 3;
            // 
            // lblCurrentKcalExtra
            // 
            lblCurrentKcalExtra.BackColor = Color.Transparent;
            lblCurrentKcalExtra.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentKcalExtra.Location = new Point(150, 165);
            lblCurrentKcalExtra.Name = "lblCurrentKcalExtra";
            lblCurrentKcalExtra.Size = new Size(53, 20);
            lblCurrentKcalExtra.TabIndex = 4;
            lblCurrentKcalExtra.Text = "425";
            lblCurrentKcalExtra.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(206, 165);
            label25.Name = "label25";
            label25.Size = new Size(53, 20);
            label25.TabIndex = 3;
            label25.Text = "kcal";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.Transparent;
            label28.Font = new Font("Segoe MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(51, 165);
            label28.Name = "label28";
            label28.Size = new Size(100, 20);
            label28.TabIndex = 2;
            label28.Text = "Alınan Kalori :";
            // 
            // lblExtra
            // 
            lblExtra.BackColor = Color.Transparent;
            lblExtra.Font = new Font("Segoe MDL2 Assets", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblExtra.Location = new Point(3, 3);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(285, 55);
            lblExtra.TabIndex = 1;
            lblExtra.Text = "EKSTRA";
            lblExtra.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAddExtra
            // 
            btnAddExtra.BackColor = Color.Transparent;
            btnAddExtra.FlatAppearance.BorderSize = 0;
            btnAddExtra.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddExtra.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            btnAddExtra.FlatStyle = FlatStyle.Flat;
            btnAddExtra.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnAddExtra.IconColor = Color.Green;
            btnAddExtra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddExtra.IconSize = 70;
            btnAddExtra.Location = new Point(3, 61);
            btnAddExtra.Name = "btnAddExtra";
            btnAddExtra.Size = new Size(285, 63);
            btnAddExtra.TabIndex = 0;
            btnAddExtra.UseVisualStyleBackColor = false;
            btnAddExtra.Click += btnAddExtra_Click;
            // 
            // ucProTakip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpMeals);
            Controls.Add(pnlCurrentKcal);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucProTakip";
            Size = new Size(960, 560);
            pnlCurrentKcal.ResumeLayout(false);
            pnlCurrentKcal.PerformLayout();
            flpMeals.ResumeLayout(false);
            pnlBreakFast.ResumeLayout(false);
            pnlBreakFast.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCurrentKcal;
        private Label label2;
        private Label lblTargetCalorie;
        private FlowLayoutPanel flpMeals;
        private Panel pnlBreakFast;
        private Label lblTargetKcalBF;
        private Label label5;
        private Label label4;
        private Label lblBreakfast;
        private FontAwesome.Sharp.IconButton btnAddBreakFast;
        private Label label9;
        private Label label8;
        private Panel panel2;
        private Label lblCurrentKcalLunch;
        private Label label11;
        private Label label12;
        private Label lblTargetKcalLunch;
        private Label label14;
        private Label label15;
        private Label lblLunch;
        private FontAwesome.Sharp.IconButton btnAddLunch;
        private Panel panel3;
        private Label lblCurrentKcalDinner;
        private Label label18;
        private Label label19;
        private Label lblTargetKcalDinner;
        private Label label21;
        private Label label22;
        private Label lblDinner;
        private FontAwesome.Sharp.IconButton btnAddDinner;
        private Panel panel4;
        private Label lblCurrentKcalExtra;
        private Label label25;
        private Label label28;
        private Label lblExtra;
        private FontAwesome.Sharp.IconButton btnAddExtra;
        private DateTimePicker dtpMealDate;
        public Label lblCurrentKcalBF;
    }
}
