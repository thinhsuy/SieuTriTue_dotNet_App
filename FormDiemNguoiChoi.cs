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
    public partial class FormDiemNguoiChoi : Form
    {
        string playerA = "", playerB = "";
        public FormDiemNguoiChoi(string playerA, string playerB)
        {
            InitializeComponent();
            this.playerA = playerA;
            this.playerB = playerB; 
        }

        private void buttonVong1_Click(object sender, EventArgs e)
        {
            FormVong1 vong1 = new FormVong1();
            vong1.ShowDialog();
        }

        private void buttonVong2_Click(object sender, EventArgs e)
        {
            FormVong2 vong2 = new FormVong2();
            vong2.ShowDialog();
        }

        private void buttonVong3_Click(object sender, EventArgs e)
        {
            FormVong3 vong3 = new FormVong3();
            vong3.ShowDialog();
        }

        private void FormDiemNguoiChoi_Load(object sender, EventArgs e)
        {
            this.lbA.Text = this.playerA;
            this.lbB.Text = this.playerB;
        }
    }
}