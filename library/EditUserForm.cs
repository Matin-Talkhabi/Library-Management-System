using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class EditUserForm : Form
    {
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";
        private int userID;

        public EditUserForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT Username, IsAdmin, Credit, CreatedBy FROM Users WHERE UserID = @userID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userID", userID);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtUsername.Text = reader["Username"].ToString();
                    chkIsAdmin.Checked = (bool)reader["IsAdmin"];
                    txtCredit.Text = reader["Credit"].ToString();
                    txtCreatedBy.Text = reader["CreatedBy"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCredit.Text, out decimal credit))
            {
                MessageBox.Show("لطفا یک مقدار معتبر برای اعتبار وارد کنید.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "UPDATE Users SET Username = @username, IsAdmin = @isAdmin, Credit = @credit WHERE UserID = @userID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", txtUsername.Text);
                command.Parameters.AddWithValue("@isAdmin", chkIsAdmin.Checked);
                command.Parameters.AddWithValue("@credit", credit);
                command.Parameters.AddWithValue("@userID", userID);
                command.ExecuteNonQuery();
            }
            this.Close();
        }

        private void txtCredit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
