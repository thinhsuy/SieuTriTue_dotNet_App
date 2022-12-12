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
    public partial class FormSelectPlayers : Form
    {
        public FormSelectPlayers()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string playerA = "null", playerB = "null";
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = DBC.GetConnectionStringByName("PublicDB");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select count(*) from NguoiChoi where Id='" + this.tbA.Text + "' or Id='" + this.tbB.Text + "' or HoTen like N'%"+this.tbA.Text+"%' or HoTen like N'%"+tbB.Text+"%'";

            try
            {
                if (int.Parse(DBC.GetValueReturn(sql, cnn)) != 2)
                {
                    MessageBox.Show("Username violated!");
                    DBC.CloseDB(cnn);
                    return;
                }
                else
                {
                    sql = "select HoTen from NguoiChoi where Id='" + this.tbA.Text + "' or HoTen like N'%" + this.tbA.Text + "%'";
                    playerA = DBC.GetValueReturn(sql, cnn);
                    sql = "select HoTen from NguoiChoi where Id='" + this.tbB.Text + "' or HoTen like N'%" + this.tbB.Text + "%'";
                    playerB = DBC.GetValueReturn(sql, cnn);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(DBC.CatchSqlExeption(ex));
                DBC.CloseDB(cnn);
                return;
            }
            DBC.CloseDB(cnn);
            FormDiemNguoiChoi battle = new FormDiemNguoiChoi(playerA, playerB);
            battle.ShowDialog();
        }
    }
}
