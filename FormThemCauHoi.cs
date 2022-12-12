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
    public partial class FormThemCauHoi : Form
    {
        public FormThemCauHoi()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = DBC.GetConnectionStringByName("PublicDB");
            if (!DBC.OpenDB(cnn)) return;

            List<SqlParameter> paraList = new List<SqlParameter>();
            SqlParameter para1 = new SqlParameter() {
                ParameterName = "@id",
                SqlDbType = SqlDbType.VarChar,
                Value = this.tbID.Text
            }; paraList.Add(para1);
            SqlParameter para2 = new SqlParameter() {
                ParameterName = "@pheptinh",
                SqlDbType = SqlDbType.NVarChar,
                Value = this.tbPheptinh.Text
            }; paraList.Add(para2);
            SqlParameter para3 = new SqlParameter() {
                ParameterName = "@bac",
                SqlDbType = SqlDbType.SmallInt,
                Value = int.Parse(this.tbChuso.Text)
            }; paraList.Add(para3);
            SqlParameter para4 = new SqlParameter() {
                ParameterName = "@noidung",
                SqlDbType = SqlDbType.VarChar,
                Value = this.cauhoiThem.Text
            }; paraList.Add(para4);
            SqlParameter para5 = new SqlParameter() {
                ParameterName = "@dapan",
                SqlDbType = SqlDbType.NVarChar,
                Value = this.tbDapAn.Text
            }; paraList.Add(para5);

            try
            {
                DBC.ProcessProc("InsertQuestion", cnn, paraList);
            } catch (SqlException ex)
            {
                MessageBox.Show(DBC.CatchSqlExeption(ex));
                DBC.CloseDB(cnn);
                return;
            }
            MessageBox.Show("Insert Successfully");
            DBC.CloseDB(cnn);
        }
    }
}
