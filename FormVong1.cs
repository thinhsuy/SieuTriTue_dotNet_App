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
    public partial class FormVong1 : Form
    {
        public FormVong1()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = DBC.GetConnectionStringByName("PublicDB");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select clch.NoiDung, clch.ID_CauHoi from CauHoiThi as cht inner join CacLoaiCauHoi as clch on clch.ID_CauHoi = cht.ID_CauHoi and clch.PhepTinh = cht.LoaiCauHoi and clch.Bac=" + comboBox1.Text + " and clch.PhepTinh=N'"+comboBox2.Text+"'";
            DataSet ds = DBC.SelectDataSet(sql, cnn);
            if (ds.Tables.Count < 0) return;
            
            cbQues.DataSource = ds.Tables[0];
            cbQues.DisplayMember = "NoiDung";
            cbQues.ValueMember = "ID_CauHoi";
            
            
            DBC.CloseDB(cnn);
        }

        private void buttonNop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVong1_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = DBC.GetConnectionStringByName("PublicDB");
            if (!DBC.OpenDB(cnn)) return;

            string sql = "select clch.Bac, clch.PhepTinh from CacLoaiCauHoi as clch inner join CauHoiThi as cht on clch.ID_CauHoi = cht.ID_CauHoi and clch.PhepTinh = cht.LoaiCauHoi and (clch.PhepTinh=N'Cộng' or clch.PhepTinh=N'Trừ') order by clch.Bac";

            DataSet ds = DBC.SelectDataSet(sql, cnn);
            if (ds.Tables.Count < 0)
            {
                MessageBox.Show("DataSet is empty!");
                return;
            }
            else
            {
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "Bac";
                comboBox2.DataSource = ds.Tables[0];
                comboBox2.DisplayMember = "PhepTinh";
            }
            DBC.CloseDB(cnn);
        }
    }
}
