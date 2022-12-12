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
    public partial class FormQLVong3 : Form
    {
        public FormQLVong3()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormThemCauHoi themCauHoiVong3 = new FormThemCauHoi();
            themCauHoiVong3.ShowDialog();
        }

        private void buttonChon_Click(object sender, EventArgs e)
        {
            FormChonCauHoiVong3 chonCauHoiVong3 = new FormChonCauHoiVong3();
            chonCauHoiVong3.ShowDialog();
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            FormXemCauHoiVong3 xemCauHoiVong3 = new FormXemCauHoiVong3();
            xemCauHoiVong3.ShowDialog();
        }
    }
}
