using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class EditBorrowForm : Form
    {
        private int borrowID;
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public EditBorrowForm(int borrowID)
        {
            InitializeComponent();
            this.borrowID = borrowID;
            LoadBorrowData();
        }

        private void LoadBorrowData()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = @"
                    SELECT 
                        b.BorrowID,
                        u.Username,
                        bk.Title,
                        b.BorrowDate,
                        b.ReturnDate
                    FROM 
                        Borrows b
                        JOIN Users u ON b.UserID = u.UserID
                        JOIN Books bk ON b.BookID = bk.BookID
                    WHERE 
                        b.BorrowID = @borrowID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@borrowID", borrowID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtUsername.Text = reader["Username"].ToString();
                    txtBookTitle.Text = reader["Title"].ToString();
                    dtpBorrowDate.Value = Convert.ToDateTime(reader["BorrowDate"]);
                    dtpReturnDate.Value = reader["ReturnDate"] != DBNull.Value ? Convert.ToDateTime(reader["ReturnDate"]) : DateTime.Now;
                }
                else
                {
                    MessageBox.Show("امانتی با این شناسه پیدا نشد.");
                    this.Close();
                }
            }
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string bookTitle = txtBookTitle.Text;
            DateTime borrowDate = dtpBorrowDate.Value;
            DateTime? returnDate = dtpReturnDate.Checked ? dtpReturnDate.Value : (DateTime?)null;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                // Check if the user and book exist
                string userQuery = "SELECT UserID FROM Users WHERE Username = @username";
                string bookQuery = "SELECT BookID FROM Books WHERE Title = @bookTitle";

                int userID, bookID;

                using (SqlCommand userCommand = new SqlCommand(userQuery, connection))
                {
                    userCommand.Parameters.AddWithValue("@username", username);
                    object userResult = userCommand.ExecuteScalar();
                    if (userResult == null)
                    {
                        MessageBox.Show("کاربر وارد شده وجود ندارد.");
                        return;
                    }
                    userID = Convert.ToInt32(userResult);
                }

                using (SqlCommand bookCommand = new SqlCommand(bookQuery, connection))
                {
                    bookCommand.Parameters.AddWithValue("@bookTitle", bookTitle);
                    object bookResult = bookCommand.ExecuteScalar();
                    if (bookResult == null)
                    {
                        MessageBox.Show("کتاب وارد شده وجود ندارد.");
                        return;
                    }
                    bookID = Convert.ToInt32(bookResult);
                }

                // Update the borrow information
                string updateQuery = "UPDATE Borrows SET UserID = @userID, BookID = @bookID, BorrowDate = @borrowDate, ReturnDate = @returnDate WHERE BorrowID = @borrowID";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@userID", userID);
                updateCommand.Parameters.AddWithValue("@bookID", bookID);
                updateCommand.Parameters.AddWithValue("@borrowDate", borrowDate);
                updateCommand.Parameters.AddWithValue("@returnDate", (object)returnDate ?? DBNull.Value);
                updateCommand.Parameters.AddWithValue("@borrowID", borrowID);

                updateCommand.ExecuteNonQuery();
                MessageBox.Show("اطلاعات امانت با موفقیت به‌روزرسانی شد.");
                this.Close();
            }
        }
    }
}
