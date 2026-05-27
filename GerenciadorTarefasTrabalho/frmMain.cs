using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoLoginApp;


namespace GerenciadorTarefasTrabalho
{

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        public frmMain(int userId, string username)
        {
            InitializeComponent();

            loggedUserId = userId;
            loggedUsername = username;

            lblWelcome.Text = "Bem-vindo, " + username;

            LoadTasks();


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private int loggedUserId;
        private string loggedUsername;

        private void LoadTasks()
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT id,title,is_done FROM tasks WHERE user_id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", loggedUserId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dgvTasks.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "INSERT INTO tasks(user_id,title) VALUES(@u,@t)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@u", loggedUserId);
                cmd.Parameters.AddWithValue("@t", txtTask.Text);

                cmd.ExecuteNonQuery();

                LoadTasks();

                txtTask.Clear();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(
                dgvTasks.CurrentRow.Cells["id"].Value
            );

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "UPDATE tasks SET is_done=TRUE WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                LoadTasks();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(
                dgvTasks.CurrentRow.Cells["id"].Value
            );

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "DELETE FROM tasks WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                LoadTasks();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();

            login.Show();

            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // pega o id da tarefa selecionada
            int id = Convert.ToInt32(
                dgvTasks.CurrentRow.Cells["id"].Value
            );

            using (MySqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query =
                    "UPDATE tasks SET title=@title WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@title", txtTask.Text);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Tarefa editada!");

                LoadTasks();

                txtTask.Clear();
            }
        }

        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTask.Text =
                dgvTasks.CurrentRow.Cells["title"].Value.ToString();
        }
    }
}
