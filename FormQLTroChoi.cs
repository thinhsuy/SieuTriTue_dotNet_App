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
    public partial class FormQLTroChoi : Form
    {
        public FormQLTroChoi()
        {
            InitializeComponent();
        }

        private void buttonVong1_Click(object sender, EventArgs e)
        {
            FormQLVong1 QLVong1 = new FormQLVong1();
            QLVong1.ShowDialog();
        }

        private void buttonVong2_Click(object sender, EventArgs e)
        {
            FormQLVong2 QLVong2 = new FormQLVong2();
            QLVong2.ShowDialog();
        }

        private void buttonVong3_Click(object sender, EventArgs e)
        {
            FormQLVong3 QLVong3 = new FormQLVong3();
            QLVong3.ShowDialog();
        }
    }
}
