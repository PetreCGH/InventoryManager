using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace InventoryManager
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["InventoryDBConnection"].ConnectionString;

        
        public static string GetConnectionString()
        {
            return connectionString;
        }

        public static void TestConnection()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("✅ Conectat cu succes la baza de date!");
                    MessageBox.Show("✅ Conectat cu succes la baza de date!", "Conexiune SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Eroare la conectare: " + ex.Message);
                    MessageBox.Show("❌ Eroare la conectare:\n" + ex.Message, "Eroare SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void AddProduct(string nume, string categorie, decimal pret, int cantitate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Produse (Nume, Categorie, Pret, Cantitate) VALUES (@nume, @categorie, @pret, @cantitate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nume", nume);
                command.Parameters.AddWithValue("@categorie", categorie);
                command.Parameters.AddWithValue("@pret", pret);
                command.Parameters.AddWithValue("@cantitate", cantitate);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Produs adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la adăugare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static List<string> GetAllProducts()
        {
            List<string> produse = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Nume, Categorie, Pret, Cantitate FROM Produse";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string produs = $"ID: {reader["ID"]} - {reader["Nume"]}, {reader["Categorie"]}, {reader["Pret"]} RON, {reader["Cantitate"]} buc.";
                            produse.Add(produs);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la încărcarea produselor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return produse;
        }

        public static void AddFurnizor(string nume, string companie, string telefon, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Furnizori (Nume, Companie, Telefon, Email) VALUES (@nume, @companie, @telefon, @email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nume", nume);
                command.Parameters.AddWithValue("@companie", companie);
                command.Parameters.AddWithValue("@telefon", telefon);
                command.Parameters.AddWithValue("@email", email);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Furnizor adăugat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la adăugare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void DeleteFurnizor(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Furnizori WHERE ID = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Furnizor șters cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Furnizorul nu a fost găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la ștergere: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        public static List<string> GetAllFurnizori()
        {
            List<string> furnizori = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Nume, Companie, Telefon, Email FROM Furnizori";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string furnizor = $"ID: {reader["ID"]} - {reader["Nume"]}, {reader["Companie"]}, {reader["Telefon"]}, {reader["Email"]}";
                            furnizori.Add(furnizor);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la încărcarea furnizorilor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return furnizori;
        }

        public static void AddComanda(string client, string produs, int cantitate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Comenzi (Client, Produs, Cantitate) VALUES (@client, @produs, @cantitate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@client", client);
                command.Parameters.AddWithValue("@produs", produs);
                command.Parameters.AddWithValue("@cantitate", cantitate);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Comanda adăugată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la adăugare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static List<string> GetAllComenzi()
        {
            List<string> comenzi = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Client, Produs, Cantitate FROM Comenzi";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string comanda = $"ID: {reader["ID"]} - {reader["Client"]}, {reader["Produs"]}, {reader["Cantitate"]} buc.";
                            comenzi.Add(comanda);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la încărcarea comenzilor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return comenzi;
        }

        public static void DeleteComanda(int idComanda)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Comenzi WHERE ID = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", idComanda);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Comanda a fost ștearsă cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Comanda nu a fost găsită în baza de date!", "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la ștergere: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static Comanda GetComandaById(int idComanda)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Client, Produs, Cantitate FROM Comenzi WHERE ID = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", idComanda);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Comanda
                            {
                                ID = idComanda,
                                Client = reader["Client"].ToString(),
                                Produs = reader["Produs"].ToString(),
                                Cantitate = Convert.ToInt32(reader["Cantitate"])
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la încărcarea comenzii: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }

        public static bool UpdateComanda(int id, string client, string produs, int cantitate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Comenzi SET Client = @client, Produs = @produs, Cantitate = @cantitate WHERE ID = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@client", client);
                command.Parameters.AddWithValue("@produs", produs);
                command.Parameters.AddWithValue("@cantitate", cantitate);
                command.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Eroare la actualizarea comenzii: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

    }


}
