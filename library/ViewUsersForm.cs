using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class ViewUsersForm : Form
    {
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public ViewUsersForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT UserID, Username, IsAdmin, Credit, CreatedBy FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewUsers.DataSource = dataTable;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT UserID, Username, IsAdmin, Credit, CreatedBy FROM Users WHERE Username LIKE @searchTerm";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewUsers.DataSource = dataTable;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
                int userID = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                EditUserForm editUserForm = new EditUserForm(userID);
                editUserForm.ShowDialog();
                LoadUsers(); // Refresh the data grid view after editing
            }
            else
            {
                MessageBox.Show("لطفاً یک کاربر را برای ویرایش انتخاب کنید.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
                int userID = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

                DialogResult result = MessageBox.Show("آیا مطمئن هستید که می‌خواهید این کاربر را حذف کنید؟", "تأیید حذف", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(conString))
                    {
                        connection.Open();

                        // Check if the user has any active loans
                        string checkLoansQuery = "SELECT COUNT(*) FROM Borrows WHERE UserID = @userID AND ReturnDate IS NULL";
                        using (SqlCommand checkLoansCommand = new SqlCommand(checkLoansQuery, connection))
                        {
                            checkLoansCommand.Parameters.AddWithValue("@userID", userID);
                            int activeLoansCount = (int)checkLoansCommand.ExecuteScalar();
                            if (activeLoansCount > 0)
                            {
                                MessageBox.Show("کاربر نمی‌تواند حذف شود چون کتاب‌های امانتی فعال دارد.");
                                return;
                            }
                        }

                        // Delete user if no active loans
                        string query = "DELETE FROM Users WHERE UserID = @userID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@userID", userID);
                        command.ExecuteNonQuery();
                    }
                    LoadUsers(); // Refresh the data grid view after deletion
                }
            }
            else
            {
                MessageBox.Show("لطفاً یک کاربر را برای حذف انتخاب کنید.");
            }
        }
    }
}
