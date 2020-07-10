using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Diplomnaya.Forms
{
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
            refreshDGV();
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = e.RowIndex;

            textBox1.Text = dgv.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dgv.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dgv.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dgv.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dgv.Rows[i].Cells[4].Value.ToString();
            textBox6.Text = dgv.Rows[i].Cells[5].Value.ToString();
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

            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format($"наименование LIKE '%{search.Text}%'");
            dgv.DataSource = DV;
        }

        private void Edit_Click(object sender, System.EventArgs e)
        {
            string cmd = $"Update Product Set Наименование='{textBox2.Text}',Материал='{textBox3.Text}',Длина='{textBox4.Text}',Ширина='{textBox5.Text}',Цена='{textBox6.Text}' Where ProductID='{textBox1.Text}'";

            using (SqlConnection connection = new SqlConnection(Class1.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                refreshDGV();
            }
        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            string cmd = $"Delete from Product Where ProductID='{textBox1.Text}'";

            using (SqlConnection connection = new SqlConnection(Class1.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cmd, connection);
                command.ExecuteNonQuery();
                refreshDGV();
            }
        }
        private void search_TextChanged(object sender, System.EventArgs e)
        {
            refreshDGV();
        }
    }
}
