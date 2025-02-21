namespace InventoryManager
{
    partial class ComenziForm
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
            this.lblClient = new System.Windows.Forms.Label();
            this.lblProdus = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtProdus = new System.Windows.Forms.TextBox();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.lstComenzi = new System.Windows.Forms.ListBox();
            this.btnStergeComanda = new System.Windows.Forms.Button();
            this.btnAdaugaComanda = new System.Windows.Forms.Button();
            this.btnEditeazaComanda = new System.Windows.Forms.Button();
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
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(27, 18);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(56, 19);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Client:";
            // 
            // lblProdus
            // 
            this.lblProdus.AutoSize = true;
            this.lblProdus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdus.Location = new System.Drawing.Point(27, 53);
            this.lblProdus.Name = "lblProdus";
            this.lblProdus.Size = new System.Drawing.Size(62, 19);
            this.lblProdus.TabIndex = 2;
            this.lblProdus.Text = "Produs:";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantitate.Location = new System.Drawing.Point(27, 86);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(75, 19);
            this.lblCantitate.TabIndex = 3;
            this.lblCantitate.Text = "Cantitate:";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(108, 15);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(150, 22);
            this.txtClient.TabIndex = 4;
            // 
            // txtProdus
            // 
            this.txtProdus.Location = new System.Drawing.Point(108, 50);
            this.txtProdus.Name = "txtProdus";
            this.txtProdus.Size = new System.Drawing.Size(150, 22);
            this.txtProdus.TabIndex = 5;
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(108, 83);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(150, 22);
            this.txtCantitate.TabIndex = 6;
            // 
            // lstComenzi
            // 
            this.lstComenzi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstComenzi.FormattingEnabled = true;
            this.lstComenzi.ItemHeight = 19;
            this.lstComenzi.Location = new System.Drawing.Point(30, 229);
            this.lstComenzi.Name = "lstComenzi";
            this.lstComenzi.Size = new System.Drawing.Size(400, 137);
            this.lstComenzi.TabIndex = 7;
            this.lstComenzi.SelectedIndexChanged += new System.EventHandler(this.lstComenzi_SelectedIndexChanged);
            // 
            // btnStergeComanda
            // 
            this.btnStergeComanda.BackColor = System.Drawing.Color.White;
            this.btnStergeComanda.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeComanda.Location = new System.Drawing.Point(575, 112);
            this.btnStergeComanda.Name = "btnStergeComanda";
            this.btnStergeComanda.Size = new System.Drawing.Size(100, 30);
            this.btnStergeComanda.TabIndex = 8;
            this.btnStergeComanda.Text = "Sterge Comanda";
            this.btnStergeComanda.UseVisualStyleBackColor = false;
            this.btnStergeComanda.Click += new System.EventHandler(this.btnStergeComanda_Click);
            // 
            // btnAdaugaComanda
            // 
            this.btnAdaugaComanda.BackColor = System.Drawing.Color.White;
            this.btnAdaugaComanda.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaComanda.Location = new System.Drawing.Point(575, 18);
            this.btnAdaugaComanda.Name = "btnAdaugaComanda";
            this.btnAdaugaComanda.Size = new System.Drawing.Size(100, 30);
            this.btnAdaugaComanda.TabIndex = 9;
            this.btnAdaugaComanda.Text = "Adauga Comanda";
            this.btnAdaugaComanda.UseVisualStyleBackColor = false;
            this.btnAdaugaComanda.Click += new System.EventHandler(this.btnAdaugaComanda_Click);
            // 
            // btnEditeazaComanda
            // 
            this.btnEditeazaComanda.BackColor = System.Drawing.Color.White;
            this.btnEditeazaComanda.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditeazaComanda.Location = new System.Drawing.Point(575, 65);
            this.btnEditeazaComanda.Name = "btnEditeazaComanda";
            this.btnEditeazaComanda.Size = new System.Drawing.Size(100, 30);
            this.btnEditeazaComanda.TabIndex = 10;
            this.btnEditeazaComanda.Text = "Editeaza Comanda";
            this.btnEditeazaComanda.UseVisualStyleBackColor = false;
            this.btnEditeazaComanda.Click += new System.EventHandler(this.btnEditeazaComanda_Click);
            // 
            // ComenziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnEditeazaComanda);
            this.Controls.Add(this.btnAdaugaComanda);
            this.Controls.Add(this.btnStergeComanda);
            this.Controls.Add(this.lstComenzi);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.txtProdus);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblProdus);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ComenziForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionare Comenzi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblProdus;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtProdus;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.ListBox lstComenzi;
        private System.Windows.Forms.Button btnStergeComanda;
        private System.Windows.Forms.Button btnAdaugaComanda;
        private System.Windows.Forms.Button btnEditeazaComanda;
    }
}