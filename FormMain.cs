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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

        private void nameofshow_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {
            FormQLNguoiChoi QLNguoiChoi = new FormQLNguoiChoi();
            QLNguoiChoi.ShowDialog();
        }

        private void match_Click(object sender, EventArgs e)
        {
            FormQLTroChoi QLTroChoi = new FormQLTroChoi();
            QLTroChoi.ShowDialog();
        }

        private void contentofmatch_Click(object sender, EventArgs e)
        {
            FormSelectPlayers select = new FormSelectPlayers();
            select.ShowDialog();
        }
    }
}
