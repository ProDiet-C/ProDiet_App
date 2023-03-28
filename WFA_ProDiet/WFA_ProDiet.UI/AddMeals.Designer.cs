namespace WFA_ProDiet.UI
{
    partial class AddMeals
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WFA_ProDiet.UI.Properties.Resources.HomePageBanner;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.BackgroundImage = global::WFA_ProDiet.UI.Properties.Resources.WhatsApp_Image_2023_03_03_at_14_29_51;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUser.IconColor = System.Drawing.Color.Black;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.Location = new System.Drawing.Point(938, 0);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(103, 100);
            this.btnUser.TabIndex = 0;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // ıconButton1
            // 
            this.ıconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.ıconButton1.IconColor = System.Drawing.Color.Black;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.IconSize = 60;
            this.ıconButton1.Location = new System.Drawing.Point(0, 590);
            this.ıconButton1.Margin = new System.Windows.Forms.Padding(4);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(1041, 60);
            this.ıconButton1.TabIndex = 2;
            this.ıconButton1.UseVisualStyleBackColor = true;
            // 
            // dgvFoods
            // 
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFoods.Location = new System.Drawing.Point(0, 261);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.RowTemplate.Height = 25;
            this.dgvFoods.Size = new System.Drawing.Size(1041, 329);
            this.dgvFoods.TabIndex = 3;
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(381, 228);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(288, 27);
            this.txtSearchFood.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(381, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yemek Ara";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(133, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aradığınızı bulamadınız mı? ";
            // 
            // ıconButton2
            // 
            this.ıconButton2.FlatAppearance.BorderSize = 0;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.ForeColor = System.Drawing.Color.Navy;
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Fish;
            this.ıconButton2.IconColor = System.Drawing.Color.Navy;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.IconSize = 30;
            this.ıconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.Location = new System.Drawing.Point(133, 200);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(184, 28);
            this.ıconButton2.TabIndex = 7;
            this.ıconButton2.Text = "Yeni Yemek Ekle";
            this.ıconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton2.UseVisualStyleBackColor = true;
            // 
            // AddMeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 650);
            this.Controls.Add(this.ıconButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchFood);
            this.Controls.Add(this.dgvFoods);
            this.Controls.Add(this.ıconButton1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddMeals";
            this.Text = "AddMeals";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private DataGridView dgvFoods;
        private TextBox txtSearchFood;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton ıconButton2;
    }
}