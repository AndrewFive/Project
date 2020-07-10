using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomnaya
{
    public partial class createApp : Form
    {
        public createApp()
        {
            InitializeComponent();
            maskedTextBox1.Text = DateTime.Now.ToString();
            refreshDGV();
        }

        private void create_Click(object sender, EventArgs e)
        {
            string cmd = $"Insert into Clients (ФИО,ProductID,Телефон,Дата_создания,Статус)values('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{maskedTextBox1.Text}','Не выполнено')";

            using (SqlConnection connection = new SqlConnection(Class1.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Заявка успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        async private void createApp_Load(object sender, EventArgs e)
        {
            while (true)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    create.Enabled = false;
                }
                else
                {
                    create.Enabled = true;
                }
                await Task.Delay(1000);
            }
        }
        int i = 0;
        private void choosebtn_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Size = new Size(934, 235);
                i++;
            }
            else
            {
                Size = new Size(432, 235);
                i--;
            }
        }
        void refreshDGV()
        {
            string cmd = "Select ProductID,Наименование,Материал,Длина,Ширина,Цена From Product";

            SqlConnection connection = new SqlConnection(Class1.connectionString);
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            void GetImageBinaryFromDb()
            {
                int i = e.RowIndex;

                textBox2.Text = dgv.Rows[i].Cells[0].Value.ToString();

                List<byte[]> iScreen = new List<byte[]>();
                List<string> iScreen_format = new List<string>();
                using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-A6CCB5J;Initial Catalog=Diplom;Integrated Security=True"))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand($@"SELECT Фото, Формат_фото FROM Product WHERE ProductID = {dgv.Rows[i].Cells[0].Value}", sqlConnection);
                    try
                    {
                        SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                        byte[] iTrimByte = null;
                        string iTrimText = null;
                        while (sqlReader.Read())
                        {
                            iTrimByte = (byte[])sqlReader["Фото"];
                            iScreen.Add(iTrimByte);
                            iTrimText = sqlReader["Формат_фото"].ToString().TrimStart().TrimEnd();
                            iScreen_format.Add(iTrimText);
                        }
                        sqlConnection.Close();
                        byte[] imageData = iScreen[0];
                        MemoryStream ms = new MemoryStream(imageData);
                        Image newImage = Image.FromStream(ms);

                        Picture.Image = newImage;

                    }
                    catch
                    {

                    }
                }

            }
            GetImageBinaryFromDb();
        }
    }
}
