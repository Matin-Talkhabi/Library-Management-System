using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class AddBookForm : Form
    {
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string publisher = txtPublisher.Text;
            int publicationYear;
            int copies;

            // Validate inputs
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(publisher) ||
                !int.TryParse(txtYear.Text, out publicationYear) || !int.TryParse(txtCopies.Text, out copies))
            {
                MessageBox.Show("لطفاً تمام فیلدها را با اطلاعات معتبر پر کنید.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "INSERT INTO Books (Title, Author, Publisher, publicationYear, Copies) VALUES (@title, @Author, @Publisher, @publicationYear, @Copies)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@Publisher", publisher);
                    command.Parameters.AddWithValue("@publicationYear", publicationYear);
                    command.Parameters.AddWithValue("@Copies", copies);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("کتاب با موفقیت اضافه شد!");
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("خطا در اضافه کردن کتاب: " + ex.Message);
                    }
                }
            }
        }
    }
}
