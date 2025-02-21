using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class LoginForm : Form
    {
        
        
        public LoginForm()
        {
            
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;













        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Introduceți utilizatorul")
            {
                txtUsername.Text = "";
                
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Introduceți utilizatorul";
                
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Introduceți parola")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Introduceți parola";
                txtPassword.UseSystemPasswordChar = false;
                
            }
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Username sau parolă incorectă!";
                lblMessage.Visible = true;
                return;
            }

            
            using (SqlConnection conn = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                string query = "SELECT Rol FROM Utilizatori WHERE Username = @user AND Parola = @pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string rol = result.ToString();
                        MessageBox.Show($"✅ Autentificare reușită! Rol: {rol}", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        Program.UserRole = rol;

                        
                        this.Hide();
                        Mainform main = new Mainform();
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("❌ Username sau parolă incorectă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la conectare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        
    }
}
