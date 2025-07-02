using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class ManageBorrowsForm : Form
    {
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public ManageBorrowsForm()
        {
            InitializeComponent();
            LoadBorrows();
        }

        private void LoadBorrows()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = @"
                    SELECT 
                        b.BorrowID,
                        u.Username AS 'Username',
                        bk.Title AS 'Book Title',
                        b.BorrowDate,
                        b.ReturnDate
                    FROM 
                        Borrows b
                        JOIN Users u ON b.UserID = u.UserID
                        JOIN Books bk ON b.BookID = bk.BookID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewBorrows.DataSource = dataTable;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBorrows();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBorrows.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBorrows.SelectedRows[0];
                int borrowID = Convert.ToInt32(selectedRow.Cells["BorrowID"].Value);
                EditBorrowForm editBorrowForm = new EditBorrowForm(borrowID);
                editBorrowForm.ShowDialog();
                LoadBorrows(); // Refresh the data grid view after editing
            }
            else
            {
                MessageBox.Show("لطفاً یک امانت را برای ویرایش انتخاب کنید.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBorrows.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBorrows.SelectedRows[0];
                int borrowID = Convert.ToInt32(selectedRow.Cells["BorrowID"].Value);

                DialogResult result = MessageBox.Show("آیا مطمئن هستید که می‌خواهید این امانت را حذف کنید؟", "تأیید حذف", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(conString))
                    {
                        connection.Open();
                        string query = "DELETE FROM Borrows WHERE BorrowID = @borrowID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@borrowID", borrowID);
                        command.ExecuteNonQuery();
                    }
                    LoadBorrows(); // Refresh the data grid view after deletion
                }
            }
            else
            {
                MessageBox.Show("لطفاً یک امانت را برای حذف انتخاب کنید.");
            }
        }
    }
}
