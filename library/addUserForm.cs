using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class addUserForm : Form
    {
        private int creatorID;
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public addUserForm(int userId)
        {
            InitializeComponent();
            creatorID = userId;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                // Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@username", txtUsername.Text);
                    int userCount = (int)checkCommand.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("نام کاربری که وارد کردید در حال حاضر وجود دارد لطفا نام کاربری دیگیری وارد کنید.");
                        return;
                    }
                }

                // Validate Credit input
                if (!decimal.TryParse(txtCredit.Text, out decimal credit))
                {
                    MessageBox.Show("یک مقدار معبر برای اعتبار وارد کنید.");
                    return;
                }

                // Insert new user
                string query = "INSERT INTO Users (Username, Password, IsAdmin, Credit, CreatedBy) VALUES (@username, @password, @isAdmin, @credit, @createdBy)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", txtUsername.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    command.Parameters.AddWithValue("@isAdmin", chkIsAdmin.Checked);
                    command.Parameters.AddWithValue("@credit", credit);
                    command.Parameters.AddWithValue("@createdBy", creatorID);

                    command.ExecuteNonQuery();
                    MessageBox.Show("کاربر با موفقیت اضافه شد!");
                    this.Close();
                }
            }
        }
    }
}
