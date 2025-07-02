using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class ShowAllUsers : Form
    {
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public ShowAllUsers()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT UserID, Username, IsAdmin, Credit FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewUsers.DataSource = dataTable;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
