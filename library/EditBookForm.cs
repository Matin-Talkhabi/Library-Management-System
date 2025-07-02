using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class EditBookForm : Form
    {
        private int bookID;
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public EditBookForm(int bookID)
        {
            InitializeComponent();
            this.bookID = bookID;
            LoadBookData();
        }

        private void LoadBookData()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT TOP 1 Title, Author, Publisher, Copies, PublicationYear FROM Books WHERE BookID = @bookID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@bookID", bookID);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtTitle.Text = reader["Title"].ToString();
                    txtAuthor.Text = reader["Author"].ToString();
                    txtPublisher.Text = reader["Publisher"].ToString();
                    txtCopies.Text = reader["Copies"].ToString();
                    txtPublicationYear.Text = reader["PublicationYear"].ToString();
                }
                else
                {
                    MessageBox.Show("کتاب با این شناسه پیدا نشد یا بیش از یک کتاب با این شناسه وجود دارد.");
                    this.Close();
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string publisher = txtPublisher.Text;
            int copies = Convert.ToInt32(txtCopies.Text);
            int publicationYear = Convert.ToInt32(txtPublicationYear.Text);

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "UPDATE Books SET Title = @title, Author = @author, Publisher = @publisher, Copies = @copies, PublicationYear = @publicationYear WHERE BookID = @bookID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author", author);
                command.Parameters.AddWithValue("@publisher", publisher);
                command.Parameters.AddWithValue("@copies", copies);
                command.Parameters.AddWithValue("@publicationYear", publicationYear);
                command.Parameters.AddWithValue("@bookID", bookID);
                command.ExecuteNonQuery();
                MessageBox.Show("اطلاعات کتاب با موفقیت به‌روزرسانی شد.");
                this.Close();
            }
        }
    }
}
