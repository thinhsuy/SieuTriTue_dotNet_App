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

namespace CSDL_WinFormApp
{
    public partial class FormXemCauHoiVong2 : Form
    {
        string selectedId = "null";
        public FormXemCauHoiVong2()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormThemCauHoi themCauHoiVong2 = new FormThemCauHoi();
            themCauHoiVong2.ShowDialog();
        }

        private void LoadDataGrid()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = DBC.GetConnectionStringByName("PublicDB");
            cnn.Open();

            string sql = "SELECT * FROM Cacloaicauhoi WHERE PHEPTINH = N'Nhân' or PHEPTINH = N'Lấy Căn'";

            SqlDataAdapter adt = new SqlDataAdapter(sql, cnn);
            DataSet dts = new DataSet();
            adt.Fill(dts);

            if (dts.Tables.Count > 0)
            {
                //Bring the data into the ComboBox
                dataGridView1.DataSource = dts.Tables[0];

            }
            cnn.Close();
        }

        private void FormXemCauHoiVong2_Load(object sender, EventArgs e)
        {
            this.LoadDataGrid();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectedId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
