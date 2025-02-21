namespace InventoryManager
{
    partial class FurnizoriForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblNumeFurnizor = new System.Windows.Forms.Label();
            this.lblCompanie = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCompanieFurnizor = new System.Windows.Forms.TextBox();
            this.txtNumeFurnizor = new System.Windows.Forms.TextBox();
            this.txtTelefonFurnizor = new System.Windows.Forms.TextBox();
            this.txtEmailFurnizor = new System.Windows.Forms.TextBox();
            this.lstFurnizori = new System.Windows.Forms.ListBox();
            this.btnAdaugaFurnizor = new System.Windows.Forms.Button();
            this.btnStergeFurnizor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNumeFurnizor
            // 
            this.lblNumeFurnizor.AutoSize = true;
            this.lblNumeFurnizor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeFurnizor.Location = new System.Drawing.Point(21, 20);
            this.lblNumeFurnizor.Name = "lblNumeFurnizor";
            this.lblNumeFurnizor.Size = new System.Drawing.Size(55, 19);
            this.lblNumeFurnizor.TabIndex = 1;
            this.lblNumeFurnizor.Text = "Nume:";
            // 
            // lblCompanie
            // 
            this.lblCompanie.AutoSize = true;
            this.lblCompanie.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanie.Location = new System.Drawing.Point(21, 58);
            this.lblCompanie.Name = "lblCompanie";
            this.lblCompanie.Size = new System.Drawing.Size(83, 19);
            this.lblCompanie.TabIndex = 2;
            this.lblCompanie.Text = "Companie:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(21, 93);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(66, 19);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(21, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 19);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtCompanieFurnizor
            // 
            this.txtCompanieFurnizor.Location = new System.Drawing.Point(115, 57);
            this.txtCompanieFurnizor.Name = "txtCompanieFurnizor";
            this.txtCompanieFurnizor.Size = new System.Drawing.Size(150, 22);
            this.txtCompanieFurnizor.TabIndex = 6;
            this.txtCompanieFurnizor.TextChanged += new System.EventHandler(this.txtCompanieFurnizor_TextChanged);
            // 
            // txtNumeFurnizor
            // 
            this.txtNumeFurnizor.Location = new System.Drawing.Point(115, 19);
            this.txtNumeFurnizor.Name = "txtNumeFurnizor";
            this.txtNumeFurnizor.Size = new System.Drawing.Size(150, 22);
            this.txtNumeFurnizor.TabIndex = 7;
            // 
            // txtTelefonFurnizor
            // 
            this.txtTelefonFurnizor.Location = new System.Drawing.Point(115, 93);
            this.txtTelefonFurnizor.Name = "txtTelefonFurnizor";
            this.txtTelefonFurnizor.Size = new System.Drawing.Size(150, 22);
            this.txtTelefonFurnizor.TabIndex = 8;
            // 
            // txtEmailFurnizor
            // 
            this.txtEmailFurnizor.Location = new System.Drawing.Point(115, 128);
            this.txtEmailFurnizor.Name = "txtEmailFurnizor";
            this.txtEmailFurnizor.Size = new System.Drawing.Size(150, 22);
            this.txtEmailFurnizor.TabIndex = 9;
            // 
            // lstFurnizori
            // 
            this.lstFurnizori.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFurnizori.FormattingEnabled = true;
            this.lstFurnizori.ItemHeight = 19;
            this.lstFurnizori.Location = new System.Drawing.Point(12, 198);
            this.lstFurnizori.Name = "lstFurnizori";
            this.lstFurnizori.Size = new System.Drawing.Size(400, 175);
            this.lstFurnizori.TabIndex = 10;
            // 
            // btnAdaugaFurnizor
            // 
            this.btnAdaugaFurnizor.BackColor = System.Drawing.Color.White;
            this.btnAdaugaFurnizor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaFurnizor.Location = new System.Drawing.Point(425, 20);
            this.btnAdaugaFurnizor.Name = "btnAdaugaFurnizor";
            this.btnAdaugaFurnizor.Size = new System.Drawing.Size(150, 30);
            this.btnAdaugaFurnizor.TabIndex = 11;
            this.btnAdaugaFurnizor.Text = "Adauga Furnizor";
            this.btnAdaugaFurnizor.UseVisualStyleBackColor = false;
            this.btnAdaugaFurnizor.Click += new System.EventHandler(this.btnAdaugaFurnizor_Click);
            // 
            // btnStergeFurnizor
            // 
            this.btnStergeFurnizor.BackColor = System.Drawing.Color.White;
            this.btnStergeFurnizor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeFurnizor.Location = new System.Drawing.Point(425, 93);
            this.btnStergeFurnizor.Name = "btnStergeFurnizor";
            this.btnStergeFurnizor.Size = new System.Drawing.Size(150, 30);
            this.btnStergeFurnizor.TabIndex = 12;
            this.btnStergeFurnizor.Text = "Sterge Furnizor";
            this.btnStergeFurnizor.UseVisualStyleBackColor = false;
            this.btnStergeFurnizor.Click += new System.EventHandler(this.btnStergeFurnizor_Click);
            // 
            // FurnizoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnStergeFurnizor);
            this.Controls.Add(this.btnAdaugaFurnizor);
            this.Controls.Add(this.lstFurnizori);
            this.Controls.Add(this.txtEmailFurnizor);
            this.Controls.Add(this.txtTelefonFurnizor);
            this.Controls.Add(this.txtNumeFurnizor);
            this.Controls.Add(this.txtCompanieFurnizor);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblCompanie);
            this.Controls.Add(this.lblNumeFurnizor);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FurnizoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionare Furnizori";
            this.Load += new System.EventHandler(this.FurnizoriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNumeFurnizor;
        private System.Windows.Forms.Label lblCompanie;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCompanieFurnizor;
        private System.Windows.Forms.TextBox txtNumeFurnizor;
        private System.Windows.Forms.TextBox txtTelefonFurnizor;
        private System.Windows.Forms.TextBox txtEmailFurnizor;
        private System.Windows.Forms.ListBox lstFurnizori;
        private System.Windows.Forms.Button btnAdaugaFurnizor;
        private System.Windows.Forms.Button btnStergeFurnizor;
    }
}