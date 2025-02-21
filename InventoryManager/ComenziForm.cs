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
    public partial class ComenziForm : Form
    {
        public ComenziForm()
        {
            InitializeComponent();
            LoadComenzi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdaugaComanda_Click(object sender, EventArgs e)
        {
            string client = txtClient.Text;
            string produs = txtProdus.Text;
            string cantitateText = txtCantitate.Text;

            
            if (string.IsNullOrWhiteSpace(client) || string.IsNullOrWhiteSpace(produs) || string.IsNullOrWhiteSpace(cantitateText))
            {
                MessageBox.Show("Toate câmpurile trebuie completate!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!int.TryParse(cantitateText, out int cantitate))
            {
                MessageBox.Show("Cantitatea trebuie să fie un număr valid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DatabaseHelper.AddComanda(client, produs, cantitate);

            
            txtClient.Clear();
            txtProdus.Clear();
            txtCantitate.Clear();

            
            LoadComenzi();
        }

        private void LoadComenzi()
        {
            lstComenzi.Items.Clear();
            List<string> comenzi = DatabaseHelper.GetAllComenzi();

            if (comenzi.Count > 0)
            {
                lstComenzi.Items.AddRange(comenzi.ToArray());
                
            }
            else
            {
                MessageBox.Show("⚠ Nu există comenzi în baza de date!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStergeComanda_Click(object sender, EventArgs e)
        {
            if (lstComenzi.SelectedItem != null) 
            {
                string selectedComanda = lstComenzi.SelectedItem.ToString(); 

                
                string[] parts = selectedComanda.Split(' ');
                if (parts.Length < 2 || !int.TryParse(parts[1], out int idComanda))
                {
                    
                    return;
                }

                
                DialogResult result = MessageBox.Show("Sigur doriți să ștergeți această comandă?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DatabaseHelper.DeleteComanda(idComanda); 
                    LoadComenzi(); 
                }
            }
            else
            {
                MessageBox.Show("Selectează o comandă din listă pentru a o șterge!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditeazaComanda_Click(object sender, EventArgs e)
        {
            if (lstComenzi.SelectedItem == null)
            {
                MessageBox.Show("⚠ Selectați o comandă din listă înainte de a o edita!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string selectedComanda = lstComenzi.SelectedItem.ToString();
            

            
            string[] parts = selectedComanda.Split(' ');
            if (parts.Length < 2 || !int.TryParse(parts[1], out int idComanda))
            {
                MessageBox.Show("❌ Nu s-a putut extrage ID-ul comenzii!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            
            string clientNou = txtClient.Text;
            string produsNou = txtProdus.Text;
            int cantitateNoua;

            if (string.IsNullOrWhiteSpace(clientNou) || string.IsNullOrWhiteSpace(produsNou) || !int.TryParse(txtCantitate.Text, out cantitateNoua))
            {
                MessageBox.Show("⚠ Completați toate câmpurile corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            bool rezultat = DatabaseHelper.UpdateComanda(idComanda, clientNou, produsNou, cantitateNoua);

            if (rezultat)
            {
                MessageBox.Show("✅ Comanda a fost actualizată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadComenzi(); 
            }
            else
            {
                MessageBox.Show("❌ Eroare la actualizarea comenzii!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void lstComenzi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstComenzi.SelectedItem == null)
            {
                
                return;
            }

            string selectedComanda = lstComenzi.SelectedItem.ToString();
            
        }

        private void ComenziForm_Load(object sender, EventArgs e)
        {
            LoadComenzi();
        }
    }
}
