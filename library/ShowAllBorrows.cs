using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class ShowAllBorrows : Form
    {
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public ShowAllBorrows()
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
                        Borrows.BorrowID, 
                        Users.Username AS UserName, 
                        Books.Title AS BookTitle, 
                        Borrows.BorrowDate, 
                        Borrows.ReturnDate 
                    FROM 
                        Borrows 
                    INNER JOIN 
                        Users ON Borrows.UserID = Users.UserID 
                    INNER JOIN 
                        Books ON Borrows.BookID = Books.BookID";

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
    }
}
