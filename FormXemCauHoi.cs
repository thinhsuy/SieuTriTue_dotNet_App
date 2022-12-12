using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace CSDL_WinFormApp
{
    public partial class FormXemCauHoi : Form
    {
        string selectedId = "null";
        public FormXemCauHoi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormThemCauHoi themCauHoi = new FormThemCauHoi();
            themCauHoi.ShowDialog();
        }

        static string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void LoadDataGrid()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = GetConnectionStringByName("PublicDB");
            cnn.Open();

            string sql = "SELECT * FROM CACLOAICAUHOI WHERE PHEPTINH = N'Cộng' or PHEPTINH = N'Trừ'";

            SqlDataAdapter adt = new SqlDataAdapter(sql, cnn);
            DataSet dts = new DataSet();
            adt.Fill(dts);

            if (dts.Tables.Count > 0)
            {
                //Bring the data into the ComboBox
                dataGridViewCH.DataSource = dts.Tables[0];

            }
            cnn.Close();
        }
        private void FormXemCauHoi_Load(object sender, EventArgs e)
        {
            this.LoadDataGrid();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

            if (this.selectedId == "null")
            {
                MessageBox.Show("Please choose one");
                return;
            }
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = DBC.GetConnectionStringByName("PublicDB");
            if (!DBC.OpenDB(cnn)) return;
            List<SqlParameter> paraList = new List<SqlParameter>();
            SqlParameter para1 = new SqlParameter() {
                ParameterName = "@id",
                SqlDbType = SqlDbType.VarChar,
                Value = this.selectedId
            }; paraList.Add(para1);
            
            try
            {
                DBC.ProcessProc("DeleteQues", cnn, paraList);
                MessageBox.Show("Delete Successfully!");
                this.LoadDataGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(DBC.CatchSqlExeption(ex));
            }
            cnn.Close();
        }

        private void dataGridViewCH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectedId = dataGridViewCH.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
