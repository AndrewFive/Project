using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Diplomnaya
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Class1.connectionString);
            string command = $"Select * from [Authorization] where Login='{login.Text.Trim()}' and Password='{password.Text.Trim()}' and State='{state.Text}'";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                Class1.login = login.Text;
                Class1.stateuser = state.Text;
                MainWindow mw = new MainWindow();
                mw.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
