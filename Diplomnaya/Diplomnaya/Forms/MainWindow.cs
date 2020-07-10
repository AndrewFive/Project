using Diplomnaya.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace Diplomnaya
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            label1.Text = Class1.login;
            refreshDGV();
            if (Class1.stateuser == "user")
            {
                addUser.Visible = false;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization();
            auth.Show();
            Hide();
        }


        private void notsucc_Click(object sender, EventArgs e)
        {
            string cmd = $"Update Clients Set Статус='Не выполненно',Логин_Выполнившего_Пользователя='{Class1.login}' Where ClientID='{lblID.Text}'";

            using (SqlConnection connection = new SqlConnection(Class1.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
            }
            refreshDGV();
        }

        private void createApp_Click(object sender, EventArgs e)
        {
            createApp ca = new createApp();
            ca.Show();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = e.RowIndex;
            using (SqlConnection connection = new SqlConnection(Class1.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT ФИО,ProductID,Телефон,Дата_создания FROM Clients WHERE ClientID = {dgv.Rows[i].Cells[0].Value}", connection);
                SqlDataReader sqlReader = command.ExecuteReader();
                string one;
                string two;
                string three;
                string four;
                if (sqlReader.Read())
                {
                    one = sqlReader["ФИО"].ToString();
                    two = sqlReader["ProductID"].ToString();
                    three = sqlReader["Телефон"].ToString();
                    four = sqlReader["Дата_создания"].ToString();

                    connection.Close();
                    connection.Open();
                    SqlCommand command2 = new SqlCommand($"SELECT Наименование, Материал, Длина, Ширина, Цена FROM Product WHERE ProductID = {dgv.Rows[i].Cells[2].Value}", connection);
                    SqlDataReader sqlReader2 = command2.ExecuteReader();
                    string five;
                    string six;
                    string seven;
                    string eight;
                    string ten;
                    if (sqlReader2.Read())
                    {
                        five = sqlReader2["Наименование"].ToString();
                        six = sqlReader2["Материал"].ToString();
                        seven = sqlReader2["Длина"].ToString();
                        eight = sqlReader2["Ширина"].ToString();
                        ten = sqlReader2["Цена"].ToString();
                        textBox1.Text = $"   ------------------------------------\r\n\r\nООО \"Ковровая Фабрика Орнамент\" \r\n\r\n------------------------------------\r\n\r\nID заказа: {dgv.Rows[i].Cells[0].Value}\r\nПродукт: {five}\r\nМатериал: {six}\r\nДлина: {seven}\r\nШирина: {eight}\r\nФИО: {one}\r\nТелефон: {three}\r\nДата создания заявки: {four}\r\nДата продажи: {DateTime.Now}\r\n\r\nИтоговая стоимость: {ten}";
                    }
                }
                connection.Close();
            }
            lblID.Text = dgv.Rows[i].Cells[0].Value.ToString();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser();
            nu.Show();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();
            np.Show();
        }

        private void editProduct_Click(object sender, EventArgs e)
        {
            EditProduct ep = new EditProduct();
            ep.Show();
            File.WriteAllText(@"D:\dsadsa.txt", "dsnfdasbnfbadfkjbafkjbdas");

        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            ProdList pl = new ProdList();
            pl.Show();
        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, 10, 25);
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            string cmd = $"Update Clients Set Статус='Выполнено',Логин_Выполнившего_Пользователя='{Class1.login}' Where ClientID='{lblID.Text}'";

            using (SqlConnection connection = new SqlConnection(Class1.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
            }
            refreshDGV();

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();
        }

        bool isTrue = true;

        private void SortBtn_Click(object sender, EventArgs e)
        {
            string cmd;
            if (isTrue)
            {
                cmd = $"Select ClientID,ФИО,ProductID,Телефон,Дата_создания,Статус from Clients where Статус='Не Выполнено'";
                isTrue = false;
            }
            else
            {
                cmd = $"Select ClientID,ФИО,ProductID,Телефон,Дата_создания,Статус from Clients where Статус='Выполнено'";
                isTrue = true;
            }

            SqlConnection connection = new SqlConnection(Class1.connectionString);
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }

        void refreshDGV()
        {
            string cmd = "Select ClientID,ФИО,ProductID,Телефон,Дата_создания,Статус From Clients";

            SqlConnection connection = new SqlConnection(Class1.connectionString);
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            refreshDGV();
        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            string cmd = "Select ClientID,ФИО,ProductID,Телефон,Дата_создания,Статус From Clients";

            SqlConnection connection = new SqlConnection(Class1.connectionString);
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dgv.DataSource = dt;

            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format($"ФИО LIKE '%{SearchTxtBox.Text}%'");
            dgv.DataSource = DV;
        }
    }
}
