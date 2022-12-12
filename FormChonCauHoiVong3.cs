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
    public partial class FormChonCauHoiVong3 : Form
    {
        string selectedId = "null";
        string selectedType = "null";
        public FormChonCauHoiVong3()
        {
            InitializeComponent();
        }

        private void FormChonCauHoiVong3_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = DBC.GetConnectionStringByName("PublicDB");
            cnn.Open();

            string sql = "SELECT * FROM Cacloaicauhoi where pheptinh = N'Chia'";

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

        private void buttonChon_Click(object sender, EventArgs e)
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
            int round = 0;
            if (this.Text == "Round 1") round = 1;
            else if (this.Text == "Round 2") round = 2;
            else if (this.Text == "Round 3") round = 3;
            SqlParameter para1 = new SqlParameter() {
                ParameterName = "@round",
                SqlDbType = SqlDbType.Int,
                Value = round
            }; paraList.Add(para1);
            SqlParameter para2 = new SqlParameter() {
                ParameterName = "@type",
                SqlDbType = SqlDbType.NVarChar,
                Value = this.selectedType
            }; paraList.Add(para2);
            SqlParameter para3 = new SqlParameter() {
                ParameterName = "@idques",
                SqlDbType = SqlDbType.VarChar,
                Value = this.selectedId
            }; paraList.Add(para3);

            try
            {
                DBC.ProcessProc("AddQuesToCompetion", cnn, paraList);
                MessageBox.Show("Add Successfully!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(DBC.CatchSqlExeption(ex));
            }
            cnn.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectedId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                selectedType = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
