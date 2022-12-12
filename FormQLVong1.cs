using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDL_WinFormApp
{
    public partial class FormQLVong1 : Form
    {
        public FormQLVong1()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormThemCauHoi ThemCauHoi = new FormThemCauHoi();
            ThemCauHoi.ShowDialog();
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {
            FormChonCauHoi ChonCauHoi = new FormChonCauHoi();
            ChonCauHoi.ShowDialog();
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            FormXemCauHoi XemCauHoi = new FormXemCauHoi();
            XemCauHoi.ShowDialog();
        }
    }
}
