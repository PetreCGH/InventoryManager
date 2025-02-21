using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class ProduseForm : Form
    {
        public ProduseForm()
        {
            InitializeComponent();
            AfiseazaProduse();
            LoadProduse();
        }

        private int GetSelectedProductId()
        {
            if (lstProduse.SelectedItem == null)
            {
                MessageBox.Show("Selectează un produs din listă!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }

            string selectedItem = lstProduse.SelectedItem.ToString(); 
            string[] parts = selectedItem.Split(' '); 

            if (parts.Length < 2 || !int.TryParse(parts[1], out int productId))
            {
                MessageBox.Show("Nu s-a putut extrage ID-ul produsului!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            return productId; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            string nume = txtNumeProdus.Text;
            string categorie = txtCategorie.Text;
            decimal pret;
            int cantitate;

            if (string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(categorie) ||
                !decimal.TryParse(txtPret.Text, out pret) || !int.TryParse(txtCantitate.Text, out cantitate))
            {
                MessageBox.Show("Toate câmpurile trebuie completate corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper.AddProduct(nume, categorie, pret, cantitate);
                txtNumeProdus.Clear();
                txtCategorie.Clear();
                txtPret.Clear();
                txtCantitate.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la adăugare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadProduse();
        }

        private void btnStergeProdus_Click(object sender, EventArgs e)
        {
            int productId = GetSelectedProductId(); 

            if (productId == -1) 
                return;

            
            DialogResult confirmare = MessageBox.Show("Sigur vrei să ștergi acest produs?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmare == DialogResult.No)
                return; 

            
            string query = "DELETE FROM Produse WHERE ID = @ID";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["InventoryDBConnection"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", productId); 

                    int rowsAffected = cmd.ExecuteNonQuery(); 
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produs șters cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProduse(); 
                    }
                    else
                    {
                        MessageBox.Show("Produsul nu a fost găsit în baza de date!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        

        private void AfiseazaProduse()
        {
            lstProduse.Items.Clear(); 

            List<string> produse = DatabaseHelper.GetAllProducts();

            foreach (string produs in produse)
            {
                lstProduse.Items.Add(produs);
            }
        }
        private void lstProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lstProduse.SelectedItem != null)
            {
                MessageBox.Show("Ai selectat: " + lstProduse.SelectedItem.ToString());
            }
        }

        private void btnEditeazaProdus_Click(object sender, EventArgs e)
        {
            if (lstProduse.SelectedItem == null)
            {
                MessageBox.Show("Selectează un produs din listă pentru a-l edita!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string selectedText = lstProduse.SelectedItem.ToString();
            string[] parts = selectedText.Split('-');

            if (parts.Length < 2)
            {
                MessageBox.Show("Eroare la extragerea ID-ului produsului!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int productId;
            if (!int.TryParse(parts[0].Replace("ID", "").Trim(), out productId))
            {
                MessageBox.Show("Nu s-a putut extrage ID-ul produsului!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string numeNou = txtNumeProdus.Text;
            string categorieNoua = txtCategorie.Text;
            string pretNou = txtPret.Text;
            string cantitateNoua = txtCantitate.Text;

            if (string.IsNullOrWhiteSpace(numeNou) || string.IsNullOrWhiteSpace(categorieNoua) || string.IsNullOrWhiteSpace(pretNou) || string.IsNullOrWhiteSpace(cantitateNoua))
            {
                MessageBox.Show("Toate câmpurile trebuie completate pentru a edita produsul!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string query = "UPDATE Produse SET Nume=@Nume, Categorie=@Categorie, Pret=@Pret, Cantitate=@Cantitate WHERE ID=@ID";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["InventoryDBConnection"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", productId);
                    cmd.Parameters.AddWithValue("@Nume", numeNou);
                    cmd.Parameters.AddWithValue("@Categorie", categorieNoua);
                    cmd.Parameters.AddWithValue("@Pret", pretNou);
                    cmd.Parameters.AddWithValue("@Cantitate", cantitateNoua);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("✅ Produs editat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProduse(); 
                    }
                    else
                    {
                        MessageBox.Show("⚠ Eroare: Produsul nu a fost actualizat!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadProduse()
        {
            lstProduse.Items.Clear(); 
            string query = "SELECT * FROM Produse"; 

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["InventoryDBConnection"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nume = reader.GetString(1);
                            string categorie = reader.GetString(2);
                            decimal pret = reader.GetDecimal(3);
                            int cantitate = reader.GetInt32(4);

                            
                            string produs = $"ID {id} - {nume}, {categorie}, {pret} RON, {cantitate} buc.";
                            lstProduse.Items.Add(produs);
                        }
                    }
                }
            }
        }
    }
}
