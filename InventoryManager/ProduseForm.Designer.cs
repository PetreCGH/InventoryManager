namespace InventoryManager
{
    partial class ProduseForm
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
            this.lblNumeProdus = new System.Windows.Forms.Label();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.btnStergeProdus = new System.Windows.Forms.Button();
            this.lstProduse = new System.Windows.Forms.ListBox();
            this.btnEditeazaProdus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNumeProdus
            // 
            this.lblNumeProdus.AutoSize = true;
            this.lblNumeProdus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeProdus.Location = new System.Drawing.Point(12, 26);
            this.lblNumeProdus.Name = "lblNumeProdus";
            this.lblNumeProdus.Size = new System.Drawing.Size(107, 19);
            this.lblNumeProdus.TabIndex = 1;
            this.lblNumeProdus.Text = "Nume Produs:";
            // 
            // txtNumeProdus
            // 
            this.txtNumeProdus.Location = new System.Drawing.Point(132, 20);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(150, 22);
            this.txtNumeProdus.TabIndex = 2;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(12, 61);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(81, 19);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "Categorie:";
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(132, 61);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(150, 22);
            this.txtCategorie.TabIndex = 5;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(132, 100);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(150, 22);
            this.txtPret.TabIndex = 6;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.Location = new System.Drawing.Point(12, 100);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(43, 19);
            this.lblPret.TabIndex = 7;
            this.lblPret.Text = "Pret:";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantitate.Location = new System.Drawing.Point(12, 138);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(75, 19);
            this.lblCantitate.TabIndex = 8;
            this.lblCantitate.Text = "Cantitate:";
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(132, 138);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(150, 22);
            this.txtCantitate.TabIndex = 9;
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.BackColor = System.Drawing.Color.White;
            this.btnAdaugaProdus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaProdus.Location = new System.Drawing.Point(573, 19);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(150, 30);
            this.btnAdaugaProdus.TabIndex = 10;
            this.btnAdaugaProdus.Text = "Adauga Produs";
            this.btnAdaugaProdus.UseVisualStyleBackColor = false;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.btnAdaugaProdus_Click);
            // 
            // btnStergeProdus
            // 
            this.btnStergeProdus.BackColor = System.Drawing.Color.White;
            this.btnStergeProdus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeProdus.Location = new System.Drawing.Point(573, 124);
            this.btnStergeProdus.Name = "btnStergeProdus";
            this.btnStergeProdus.Size = new System.Drawing.Size(150, 30);
            this.btnStergeProdus.TabIndex = 11;
            this.btnStergeProdus.Text = "Sterge Produs";
            this.btnStergeProdus.UseVisualStyleBackColor = false;
            this.btnStergeProdus.Click += new System.EventHandler(this.btnStergeProdus_Click);
            // 
            // lstProduse
            // 
            this.lstProduse.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProduse.FormattingEnabled = true;
            this.lstProduse.ItemHeight = 19;
            this.lstProduse.Location = new System.Drawing.Point(12, 194);
            this.lstProduse.Name = "lstProduse";
            this.lstProduse.Size = new System.Drawing.Size(400, 175);
            this.lstProduse.TabIndex = 13;
            this.lstProduse.SelectedIndexChanged += new System.EventHandler(this.lstProduse_SelectedIndexChanged);
            // 
            // btnEditeazaProdus
            // 
            this.btnEditeazaProdus.BackColor = System.Drawing.Color.White;
            this.btnEditeazaProdus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditeazaProdus.Location = new System.Drawing.Point(573, 71);
            this.btnEditeazaProdus.Name = "btnEditeazaProdus";
            this.btnEditeazaProdus.Size = new System.Drawing.Size(150, 30);
            this.btnEditeazaProdus.TabIndex = 14;
            this.btnEditeazaProdus.Text = "Editeaza Produs";
            this.btnEditeazaProdus.UseVisualStyleBackColor = false;
            this.btnEditeazaProdus.Click += new System.EventHandler(this.btnEditeazaProdus_Click);
            // 
            // ProduseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnEditeazaProdus);
            this.Controls.Add(this.lstProduse);
            this.Controls.Add(this.btnStergeProdus);
            this.Controls.Add(this.btnAdaugaProdus);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.txtNumeProdus);
            this.Controls.Add(this.lblNumeProdus);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProduseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionare Produse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNumeProdus;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.Button btnStergeProdus;
        private System.Windows.Forms.ListBox lstProduse;
        private System.Windows.Forms.Button btnEditeazaProdus;
    }
}