using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace library
{
    public partial class AdminForm : Form
    {
        private int UserId;
        private string conString = "Data Source=KM-MATIN;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=True";
        private NotifyIcon trayIcon;
        private bool isMinimizedToTray = false;

        public AdminForm(int userId, string username)
        {
            InitializeComponent();
            adminDetails.Text = $"نام کاربری :{username} (id : {userId})";
            UserId = userId;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.SizeChanged += new EventHandler(this.UserMainForm_SizeChanged);
            this.Resize += new EventHandler(this.AdminForm_Resize);
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

        private void AdminForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                trayIcon.Visible = true;
            }
        }

        private void UserMainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                trayIcon.Visible = true;
            }
        }


        private void اضافهکردنکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserForm addUserform = new addUserForm(UserId);
            addUserform.Show();
        }

        private void مشاهدهیهمهیکاربرهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllUsers showAllUsers = new ShowAllUsers();
            showAllUsers.Show();
        }

        private void جستجووویرایشوحذفکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsersForm viewUsersform = new ViewUsersForm();
            viewUsersform.Show();
        }

        private void اضافهکردنکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm addBookform = new AddBookForm();
            addBookform.Show();
        }

        private void مشاهدهیهمهیکتابهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllBooks showAllBooks = new ShowAllBooks();
            showAllBooks.Show();
        }

        private void جستجوویرایشوحذفکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooksForm viewBooksform = new ViewBooksForm();
            viewBooksform.Show();
        }

        private void اخرینامانتهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllBorrows showAllBorrows = new ShowAllBorrows();
            showAllBorrows.Show();
        }

        private void اضافهکردنامانتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowBookForm borrowBookForm = new BorrowBookForm();
            borrowBookForm.Show();
        }

        private void جستجووویرایشوحذفامانتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBorrowsForm manageBorrowsForm = new ManageBorrowsForm();
            manageBorrowsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e) { }

        private void برگشتنبهصفحهورودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            trayIcon.Visible = false;
        }

        private void AdminForm_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            this.Hide();
            trayIcon.Visible = true;
        }
    }
}
