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
    public partial class FormQLNguoiChoi : Form
    {
        public FormQLNguoiChoi()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormPlayer insert = new FormPlayer();
            insert.ShowDialog();
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            FormViewPlayer view = new FormViewPlayer();
            view.ShowDialog();
        }
    }
}
