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
    public partial class FormViewPlayer : Form
    {
        string selectedId = "null";
        public FormViewPlayer()
        {
            InitializeComponent();
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

        private void buttonSua_Click(object sender, EventArgs e)
        {
            FormPlayer Sua = new FormPlayer();
            Sua.ShowDialog();
            this.LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = GetConnectionStringByName("PublicDB");
            cnn.Open();

            string sql = "SELECT * FROM NGUOICHOI";

            SqlDataAdapter adt = new SqlDataAdapter(sql, cnn);
            DataSet dts = new DataSet();
            adt.Fill(dts);

            if (dts.Tables.Count > 0)
            {
                //Bring the data into the ComboBox
                dataGridViewNC.DataSource = dts.Tables[0];

            }
            cnn.Close();
        }
        private void FormViewPlayer_Load(object sender, EventArgs e)
        {
            this.LoadDataGrid();
        }

        private void dataGridViewNC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedId = dataGridViewNC.Rows[e.RowIndex].Cells[0].Value.ToString();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = DBC.GetConnectionStringByName("PublicDB");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "Delete NguoiChoi where ID='" + this.selectedId + "'";
            try
            {
                if (DBC.GetAffectiveRows(sql, cnn, "delete") == 0) MessageBox.Show("Delete fail");
                else MessageBox.Show("Delete successfully!");
                this.LoadDataGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(DBC.CatchSqlExeption(ex));
            }
            DBC.CloseDB(cnn);
        }

        private void dataGridViewNC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                selectedId = dataGridViewNC.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
