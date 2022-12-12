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
    public partial class FormQLVong2 : Form
    {
        public FormQLVong2()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormThemCauHoi themCauHoiVong2 = new FormThemCauHoi();
            themCauHoiVong2.ShowDialog();
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {
            FormChonCauHoiVong2 chonCauHoiVong2 = new FormChonCauHoiVong2();
            chonCauHoiVong2.ShowDialog();
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            FormXemCauHoiVong2 xemCauHoiVong2 = new FormXemCauHoiVong2();
            xemCauHoiVong2.ShowDialog();
        }
    }
}
