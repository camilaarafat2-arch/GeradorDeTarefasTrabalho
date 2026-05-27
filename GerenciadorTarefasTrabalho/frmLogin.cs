using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using TodoLoginApp;

namespace GerenciadorTarefasTrabalho
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string hash = BCrypt.Net.BCrypt.HashPassword(password);

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "INSERT INTO users(username,password) VALUES(@u,@p)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", hash);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário cadastrado!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT * FROM users WHERE username=@u";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@u", username);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string hash = reader["password"].ToString();

                    bool ok = BCrypt.Net.BCrypt.Verify(password, hash);

                    if (ok)
                    {
                        int userId = Convert.ToInt32(reader["id"]);

                        frmMain main = new frmMain(userId, username);

                        main.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Senha inválida");
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lbllogin_Click(object sender, EventArgs e)
        {

        }
    }
}