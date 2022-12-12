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
    public partial class FormPlayer : Form
    {
        public FormPlayer()
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = GetConnectionStringByName("PublicDB");
            cnn.Open();

            //SQL Query
            string sql = "insert into NguoiChoi(ID, HoTen, GioiTinh, NgaySinh, SoDienThoai, QuocTich) ";
            sql += "values ('" + tbID.Text + "', N'" + tbHoten.Text + "', N'" + tbGioiTinh.Text + "', '" + tbNgSinh.Text + "', '" + tbSDT.Text + "', N'" + tbQuocTich.Text + "')";
            int result = 0;
            try
            {
                result = DBC.GetAffectiveRows(sql, cnn, "insert");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(DBC.CatchSqlExeption(ex));
                cnn.Close();
                return;
            }
            cnn.Close();
            if (result == 0)
            {
                MessageBox.Show("Add fail!");
            }
            else
            {
                MessageBox.Show("Add successfully");
            }
            cnn.Close();
        }

        private void FormPlayer_Load(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = DBC.GetConnectionStringByName("PublicDB");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "Update NguoiChoi set Hoten=N'" + tbHoten.Text + "' ,GioiTinh=N'" + tbGioiTinh.Text + "' ,NgaySinh='" + tbNgSinh.Text + "' ,SoDienThoai='" + tbSDT.Text + "' ,QuocTich=N'" + tbQuocTich.Text + "' where ID='" + tbID.Text + "'";

            int result = 0;
            try
            {
                result = DBC.GetAffectiveRows(sql, cnn, "update");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(DBC.CatchSqlExeption(ex));
                cnn.Close();
                return;
            }

            if (result == 0)
            {
                MessageBox.Show("Update fail!");
            }
            else
            {
                MessageBox.Show("Update successfully");
            }
            //MessageBox.Show(sql);
            cnn.Close();
        }
    }
}
