using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class ViewBooksForm : Form
    {
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public ViewBooksForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "SELECT BookID, Title, Author, Publisher, Copies FROM Books";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewBooks.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری کتاب‌ها: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBooks.SelectedRows[0];
                int bookID = Convert.ToInt32(selectedRow.Cells["BookID"].Value);
                EditBookForm editBookForm = new EditBookForm(bookID);
                editBookForm.ShowDialog();
                LoadBooks(); // بروزرسانی دیتا گرید ویو پس از ویرایش
            }
            else
            {
                MessageBox.Show("لطفاً یک ردیف را برای ویرایش انتخاب کنید.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBooks.SelectedRows[0];
                int bookID = Convert.ToInt32(selectedRow.Cells["BookID"].Value);

                DialogResult result = MessageBox.Show("آیا مطمئن هستید که می‌خواهید این کتاب را حذف کنید؟", "تأیید حذف", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(conString))
                        {
                            connection.Open();
                            string query = "DELETE FROM Books WHERE BookID = @bookID";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@bookID", bookID);
                            command.ExecuteNonQuery();
                        }
                        LoadBooks(); // بروزرسانی دیتا گرید ویو پس از حذف
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("خطا در حذف کتاب: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفاً یک ردیف را برای حذف انتخاب کنید.");
            }
        }
    }
}
