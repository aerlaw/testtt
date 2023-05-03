using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Main.cs;

namespace ShopMe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Bouton connexion login
        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;

            username = textBox1.Text;
            password = textBox2.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jaiun\Documents\shopme.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                string querry = "SELECT * FROM Table WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable Table = new DataTable();
                sda.Fill(Table);
                
                if (Table.Rows.Count > 0) 
                {
                    username = textBox1.Text;
                    password = textBox2.Text;
                    Form Main = new Form();
                    Main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur de connexion", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Erreur de connexion: vérifier les identifiants utilisés");
                Main mainForm = new Main();
                this.Hide(); // Masque la fenêtre actuelle
                mainForm.ShowDialog(); // Affiche la fenêtre Main en mode modal
                this.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // retourn un booléen qui permet de checker si un compte possède déjà le même username | n'est pas utilisé
        /*
        private bool usrbool()
        {
            bool alone = true;
            string usr = textBox3.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jaiun\Documents\shopme.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                string usercheck = "SELECT username FROM Table WHERE username = '" + usr + "'";
                SqlDataAdapter usrtable = new SqlDataAdapter(usercheck, conn);
                DataTable userdtable = new DataTable();
                usrtable.Fill(userdtable);
                if (userdtable.Rows.Count > 0)
                {
                    alone = false;
                }
            }
            catch
            {
                MessageBox.Show("Erreur");
            }
            return alone;
        }
        */

        // Bouton d'inscription
        private void button2_Click(object sender, EventArgs e)
        {/*
            string pwd1 = textBox4.Text;
            string pwd2 = textBox5.Text;
            string usr = textBox3.Text;

            */
        }
    }
}
