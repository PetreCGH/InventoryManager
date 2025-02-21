using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            DatabaseHelper.TestConnection();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void btnProduse_Click(object sender, EventArgs e)
        {
            ProduseForm produseForm = new ProduseForm(); 
            produseForm.Show(); 
        }

        private void btnFurnizori_Click(object sender, EventArgs e)
        {
            FurnizoriForm furnizoriForm = new FurnizoriForm();
            furnizoriForm.Show();
        }

        private void btnComenzi_Click(object sender, EventArgs e)
        {
            ComenziForm comenziForm = new ComenziForm();
            comenziForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Program.UserRole != "Admin")
            {
                btnProduse.Enabled = false; 
                MessageBox.Show("⚠ Acces restricționat! Doar Adminii pot gestiona produsele.", "Acces", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
