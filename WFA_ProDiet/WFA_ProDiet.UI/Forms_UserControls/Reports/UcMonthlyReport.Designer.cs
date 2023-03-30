namespace WFA_ProDiet.UI
{
    partial class UcMonthlyReport
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
            this.plistMonthlyGraph = new OxyPlot.WindowsForms.PlotView();
            this.rbBreakFast = new System.Windows.Forms.RadioButton();
            this.rbDinner = new System.Windows.Forms.RadioButton();
            this.rbExtra = new System.Windows.Forms.RadioButton();
            this.rbLaunch = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetList = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plistMonthlyGraph
            // 
            this.plistMonthlyGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plistMonthlyGraph.Location = new System.Drawing.Point(0, 122);
            this.plistMonthlyGraph.Name = "plistMonthlyGraph";
            this.plistMonthlyGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plistMonthlyGraph.Size = new System.Drawing.Size(960, 438);
            this.plistMonthlyGraph.TabIndex = 0;
            this.plistMonthlyGraph.Text = "plotView1";
            this.plistMonthlyGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plistMonthlyGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plistMonthlyGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // rbBreakFast
            // 
            this.rbBreakFast.AutoSize = true;
            this.rbBreakFast.FlatAppearance.BorderSize = 0;
            this.rbBreakFast.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.rbBreakFast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.rbBreakFast.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbBreakFast.Location = new System.Drawing.Point(119, 48);
            this.rbBreakFast.Name = "rbBreakFast";
            this.rbBreakFast.Size = new System.Drawing.Size(79, 23);
            this.rbBreakFast.TabIndex = 1;
            this.rbBreakFast.Text = "Kahvaltı";
            this.rbBreakFast.UseVisualStyleBackColor = true;
            // 
            // rbDinner
            // 
            this.rbDinner.AutoSize = true;
            this.rbDinner.FlatAppearance.BorderSize = 0;
            this.rbDinner.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.rbDinner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.rbDinner.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDinner.Location = new System.Drawing.Point(319, 48);
            this.rbDinner.Name = "rbDinner";
            this.rbDinner.Size = new System.Drawing.Size(120, 23);
            this.rbDinner.TabIndex = 1;
            this.rbDinner.Text = "Akşam Yemeği";
            this.rbDinner.UseVisualStyleBackColor = true;
            // 
            // rbExtra
            // 
            this.rbExtra.AutoSize = true;
            this.rbExtra.FlatAppearance.BorderSize = 0;
            this.rbExtra.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.rbExtra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.rbExtra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbExtra.Location = new System.Drawing.Point(445, 48);
            this.rbExtra.Name = "rbExtra";
            this.rbExtra.Size = new System.Drawing.Size(67, 23);
            this.rbExtra.TabIndex = 1;
            this.rbExtra.Text = "Ekstra";
            this.rbExtra.UseVisualStyleBackColor = true;
            // 
            // rbLaunch
            // 
            this.rbLaunch.AutoSize = true;
            this.rbLaunch.FlatAppearance.BorderSize = 0;
            this.rbLaunch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.rbLaunch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.rbLaunch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLaunch.Location = new System.Drawing.Point(204, 48);
            this.rbLaunch.Name = "rbLaunch";
            this.rbLaunch.Size = new System.Drawing.Size(109, 23);
            this.rbLaunch.TabIndex = 1;
            this.rbLaunch.Text = "Öğle Yemeği";
            this.rbLaunch.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.FlatAppearance.BorderSize = 0;
            this.rbAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(197)))), ((int)(((byte)(62)))));
            this.rbAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.rbAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAll.Location = new System.Drawing.Point(49, 48);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(64, 23);
            this.rbAll.TabIndex = 1;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Hepsi";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
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
            this.cbCategory.Location = new System.Drawing.Point(665, 31);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(281, 29);
            this.cbCategory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(759, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "KATEGORİ";
            // 
            // btnGetList
            // 
            this.btnGetList.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGetList.IconColor = System.Drawing.Color.Black;
            this.btnGetList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGetList.Location = new System.Drawing.Point(665, 66);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(281, 42);
            this.btnGetList.TabIndex = 4;
            this.btnGetList.Text = "Listele";
            this.btnGetList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGetList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbBreakFast);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.rbAll);
            this.panel1.Controls.Add(this.rbExtra);
            this.panel1.Controls.Add(this.rbLaunch);
            this.panel1.Controls.Add(this.rbDinner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 122);
            this.panel1.TabIndex = 5;
            // 
            // UcMonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plistMonthlyGraph);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcMonthlyReport";
            this.Size = new System.Drawing.Size(960, 560);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plistMonthlyGraph;
        private RadioButton rbBreakFast;
        private RadioButton rbDinner;
        private RadioButton rbExtra;
        private RadioButton rbLaunch;
        private RadioButton rbAll;
        private ComboBox cbCategory;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnGetList;
        private Panel panel1;
    }
}
