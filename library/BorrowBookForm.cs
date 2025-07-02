using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class BorrowBookForm : Form
    {
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public BorrowBookForm()
        {
            InitializeComponent();
            LoadUsers();
            LoadBooks();
        }

        private void LoadUsers()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT UserID, Username FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                UserComboBox.DataSource = dataTable;
                UserComboBox.DisplayMember = "Username";
                UserComboBox.ValueMember = "UserID";
                UserComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                UserComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void LoadBooks()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT BookID, Title FROM Books";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                BookComboBox.DataSource = dataTable;
                BookComboBox.DisplayMember = "Title";
                BookComboBox.ValueMember = "BookID";
                BookComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                BookComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            int userID = (int)UserComboBox.SelectedValue;
            int bookID = (int)BookComboBox.SelectedValue;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                // Check if book exists and has available copies
                string bookQuery = "SELECT Copies FROM Books WHERE BookID = @bookID";
                using (SqlCommand bookCommand = new SqlCommand(bookQuery, connection))
                {
                    bookCommand.Parameters.AddWithValue("@bookID", bookID);
                    object result = bookCommand.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("کتابی با این شناسه یافت نشد.");
                        return;
                    }
                    int availableCopies = (int)result;
                    if (availableCopies <= 0)
                    {
                        MessageBox.Show("این کتاب هیچ نسخه‌ی موجودی ندارد.");
                        return;
                    }
                }

                // Register the borrow
                string borrowQuery = "INSERT INTO Borrows (UserID, BookID, BorrowDate) VALUES (@userID, @bookID, @borrowDate)";
                using (SqlCommand borrowCommand = new SqlCommand(borrowQuery, connection))
                {
                    borrowCommand.Parameters.AddWithValue("@userID", userID);
                    borrowCommand.Parameters.AddWithValue("@bookID", bookID);
                    borrowCommand.Parameters.AddWithValue("@borrowDate", DateTime.Now);
                    borrowCommand.ExecuteNonQuery();
                }

                // Update the number of available copies
                string updateBookQuery = "UPDATE Books SET Copies = Copies - 1 WHERE BookID = @bookID";
                using (SqlCommand updateBookCommand = new SqlCommand(updateBookQuery, connection))
                {
                    updateBookCommand.Parameters.AddWithValue("@bookID", bookID);
                    updateBookCommand.ExecuteNonQuery();
                }

                MessageBox.Show("درخواست امانت با موفقیت ثبت شد.");
            }
        }
    }
}
