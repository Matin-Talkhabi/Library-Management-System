using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace library
{
    public partial class UserMainForm : Form
    {
        private int userID;
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";
        private NotifyIcon trayIcon;

        public UserMainForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadUserBorrows();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.SizeChanged += new EventHandler(this.UserMainForm_SizeChanged);
            InitializeTrayIcon();
        }

        private void InitializeTrayIcon()
        {
            trayIcon = new NotifyIcon
            {
                Icon = SystemIcons.Application,
                Text = "Library Application",
                Visible = false
            };
            trayIcon.DoubleClick += new EventHandler(this.TrayIcon_DoubleClick);
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            trayIcon.Visible = false;
        }

        private void UserMainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                trayIcon.Visible = true;
            }
        }

        private void LoadUserBorrows()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = @"
                    SELECT 
                        Books.Title AS BookTitle,
                        Borrows.BorrowDate, 
                        Borrows.ReturnDate,
                        CASE 
                            WHEN Borrows.ReturnDate IS NOT NULL THEN 'Returned'
                            WHEN DATEDIFF(day, GETDATE(), Borrows.BorrowDate) > 5 THEN 'Delay in Receipt'
                            ELSE 'On Loan'
                        END AS Status
                    FROM 
                        Borrows 
                    INNER JOIN 
                        Books ON Borrows.BookID = Books.BookID 
                    WHERE 
                        Borrows.UserID = @userID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@userID", userID);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewBorrows.DataSource = dataTable;
                txtCountBooks.Text = dataTable.Rows.Count.ToString();

                foreach (DataGridViewRow row in dataGridViewBorrows.Rows)
                {
                    if (!row.IsNewRow && row.Cells["Status"].Value != null)
                    {
                        string statusValue = row.Cells["Status"].Value?.ToString();

                        if (statusValue == "Delay in Receipt")
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (statusValue == "On Loan")
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else if (statusValue == "Returned")
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                }
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (dataGridViewBorrows.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewBorrows.SelectedRows[0];
                string bookTitle = selectedRow.Cells["BookTitle"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = @"
                        UPDATE Borrows 
                        SET BorrowDate = GETDATE() 
                        WHERE 
                            UserID = @userID 
                            AND BookID = (SELECT BookID FROM Books WHERE Title = @bookTitle) 
                            AND ReturnDate IS NULL";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@bookTitle", bookTitle);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Borrow date successfully updated.");
                    LoadUserBorrows();
                }
            }
            else
            {
                MessageBox.Show("Please select a borrow row to renew.");
            }
        }

        private void btnManageCredit_Click(object sender, EventArgs e)
        {
            ManageCreditForm manageCreditForm = new ManageCreditForm(userID);
            manageCreditForm.ShowDialog();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            LoadUserBorrows();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void بازگشتبهصفحهورودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Close();
        }

        private void btnRenew_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                trayIcon.Visible = true;
            }
        }

        private void btnRenew_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                trayIcon.Visible = true;
            }
        }
    }
}
