using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomnaya.Forms
{
    public partial class ProdList : Form
    {
        public ProdList()
        {
            InitializeComponent();
            refreshDGV();
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
