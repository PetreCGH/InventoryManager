namespace InventoryManager
{
    partial class Mainform
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnProduse = new System.Windows.Forms.Button();
            this.btnFurnizori = new System.Windows.Forms.Button();
            this.btnComenzi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Aplicatie de Gestionare a Stocurilor";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProduse
            // 
            this.btnProduse.BackColor = System.Drawing.Color.Khaki;
            this.btnProduse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduse.Location = new System.Drawing.Point(375, 114);
            this.btnProduse.Name = "btnProduse";
            this.btnProduse.Size = new System.Drawing.Size(250, 60);
            this.btnProduse.TabIndex = 1;
            this.btnProduse.Text = "Gestionare Produse";
            this.btnProduse.UseVisualStyleBackColor = false;
            this.btnProduse.Click += new System.EventHandler(this.btnProduse_Click);
            // 
            // btnFurnizori
            // 
            this.btnFurnizori.BackColor = System.Drawing.Color.SlateGray;
            this.btnFurnizori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFurnizori.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFurnizori.Location = new System.Drawing.Point(375, 312);
            this.btnFurnizori.Name = "btnFurnizori";
            this.btnFurnizori.Size = new System.Drawing.Size(250, 60);
            this.btnFurnizori.TabIndex = 2;
            this.btnFurnizori.Text = "Gestionare Furnizori";
            this.btnFurnizori.UseVisualStyleBackColor = false;
            this.btnFurnizori.Click += new System.EventHandler(this.btnFurnizori_Click);
            // 
            // btnComenzi
            // 
            this.btnComenzi.BackColor = System.Drawing.Color.PowderBlue;
            this.btnComenzi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzi.Location = new System.Drawing.Point(375, 213);
            this.btnComenzi.Name = "btnComenzi";
            this.btnComenzi.Size = new System.Drawing.Size(250, 60);
            this.btnComenzi.TabIndex = 3;
            this.btnComenzi.Text = "Gestionare Comenzi";
            this.btnComenzi.UseVisualStyleBackColor = false;
            this.btnComenzi.Click += new System.EventHandler(this.btnComenzi_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(375, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(250, 60);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Silver;
            this.btnLogout.Location = new System.Drawing.Point(850, 36);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnComenzi);
            this.Controls.Add(this.btnFurnizori);
            this.Controls.Add(this.btnProduse);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicatie de Gestionare a Stocurilor";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnProduse;
        private System.Windows.Forms.Button btnFurnizori;
        private System.Windows.Forms.Button btnComenzi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
    }
}

