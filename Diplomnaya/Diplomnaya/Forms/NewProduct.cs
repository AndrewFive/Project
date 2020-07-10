using Diplomnaya.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomnaya.Forms
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
            refreshDGV();
        }

        private void CreateProduct_Click(object sender, EventArgs e)
        {
            PutImageBinaryInDb(filename.Text);
            MessageBox.Show($"Продукт {textBox1.Text} успешно создан", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshDGV();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            filename.Text = "";
            Picture.Image = Resources.белый_фон;
        }
        int i = 0;
        private void size_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                Size = new Size(1029, 369);
                i++;
                size.Text = "<";
            }
            else
            {
                Size = new Size(588, 369);
                i--;
                size.Text = ">";
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

        private void Review_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string name = openFileDialog1.FileName;
            filename.Text = name;
            Picture.Image = Image.FromFile(name);
        }

        private void PutImageBinaryInDb(string iFile)
        {
            byte[] imageData = null;
            FileInfo fInfo = new FileInfo(iFile);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(iFile, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            imageData = br.ReadBytes((int)numBytes);

            string iImageExtension = (Path.GetExtension(iFile)).Replace(".", "").ToLower();

            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-A6CCB5J;Initial Catalog=Diplom;Integrated Security=True"))
            {
                string commandText = $"INSERT INTO Product (Наименование,Материал,Длина,Ширина,Цена,Фото,Формат_фото) VALUES('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}',@Фото,@Формат_фото)";
                SqlCommand command = new SqlCommand(commandText, sqlConnection);
                command.Parameters.AddWithValue("@Фото", (object)imageData);
                command.Parameters.AddWithValue("@Формат_фото", iImageExtension);
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        async private void NewProduct_Load(object sender, EventArgs e)
        {
            while (true)
            {
                if (filename.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    CreateProduct.Enabled = false;
                }
                else
                {
                    CreateProduct.Enabled = true;
                }
                await Task.Delay(1000);
            }
        }
    }
}
