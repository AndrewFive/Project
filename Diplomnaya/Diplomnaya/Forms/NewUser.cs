using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Diplomnaya.Forms
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string cmd = $"Insert into [Authorization] (Login,Password,State)values('{login.Text}','{password.Text}','{state.Text}')";

            using (SqlConnection connection = new SqlConnection(Class1.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                MessageBox.Show($"Пользователь {login.Text} успешно создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
