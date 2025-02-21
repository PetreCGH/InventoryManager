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
    public partial class FurnizoriForm : Form
    {
        public FurnizoriForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdaugaFurnizor_Click(object sender, EventArgs e)
        {
            string nume = txtNumeFurnizor.Text;
            string companie = txtCompanieFurnizor.Text;
            string telefon = txtTelefonFurnizor.Text;
            string email = txtEmailFurnizor.Text;

            if (string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(companie))
            {
                MessageBox.Show("Numele și compania sunt obligatorii!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DatabaseHelper.AddFurnizor(nume, companie, telefon, email);
            LoadFurnizori();
        }

        private void btnStergeFurnizor_Click(object sender, EventArgs e)
        {
            if (lstFurnizori.SelectedItem != null)
            {
                string selected = lstFurnizori.SelectedItem.ToString();
                string[] parts = selected.Split(' ');

                if (parts.Length > 1 && int.TryParse(parts[1], out int id))
                {
                    DatabaseHelper.DeleteFurnizor(id);
                    LoadFurnizori();
                }
                else
                {
                    MessageBox.Show("Nu s-a putut extrage ID-ul furnizorului!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selectează un furnizor din listă pentru a-l șterge!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadFurnizori()
        {
            lstFurnizori.Items.Clear(); 

            List<string> furnizori = DatabaseHelper.GetAllFurnizori(); 
            if (furnizori.Count > 0)
            {
                lstFurnizori.Items.AddRange(furnizori.ToArray()); 
            }
            else
            {
                MessageBox.Show("Nu există furnizori în baza de date!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FurnizoriForm_Load(object sender, EventArgs e)
        {
            LoadFurnizori();
        }

        private void txtCompanieFurnizor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
