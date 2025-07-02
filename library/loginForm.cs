using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class loginForm : Form
    {

        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public loginForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT UserID, IsAdmin, Username FROM Users WHERE Username=@username AND Password=@password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", userNameInput.Text);
                    command.Parameters.AddWithValue("@password", passwordInput.Text);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        bool isAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
                        int userID = reader.GetInt32(reader.GetOrdinal("UserID"));
                        string username = reader.GetString(reader.GetOrdinal("Username"));

                        if (isAdmin)
                        {
                            AdminForm adminForm = new AdminForm(userID, username);
                            adminForm.Show();
                        }
                        else
                        {
                            UserMainForm userForm = new UserMainForm(userID);
                            userForm.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            userNameInput.Text = string.Empty;
            passwordInput.Text = string.Empty;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
