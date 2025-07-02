using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library
{
    public partial class ManageCreditForm : Form
    {
        private int userID;
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";

        public ManageCreditForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadUserCredit();
        }

        private void LoadUserCredit()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = "SELECT Credit FROM Users WHERE UserID = @userID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userID", userID);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    lblCredit.Text = $"اعتبار فعلی شما: {result.ToString()}";
                }
                else
                {
                    lblCredit.Text = "اعتباری یافت نشد.";
                }
            }
        }

        private void btnAddCredit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAddCredit.Text, out decimal addAmount))
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "UPDATE Users SET Credit = Credit + @addAmount WHERE UserID = @userID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@addAmount", addAmount);
                    command.Parameters.AddWithValue("@userID", userID);
                    command.ExecuteNonQuery();

                    MessageBox.Show("اعتبار با موفقیت اضافه شد.");
                    LoadUserCredit();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک مقدار معتبر وارد کنید.");
            }
        }

    }
}
