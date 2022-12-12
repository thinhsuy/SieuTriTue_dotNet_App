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
    public partial class FormVong2 : Form
    {
        public FormVong2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lbQuesA.Text = "12312*312312";
            
            this.lbQuesB.Text = "321435*2312312";
            this.lbMarkA.Text = "8";
            this.lbMarkB.Text = "8";
            this.lbCurMarkA.Text = "0";
            this.lbCurMarkB.Text = "0";
        }

        private void buttonNop_Click(object sender, EventArgs e)
        {
            this.lbAnswerA.Text = "3845185344";
            if (tbA.Text == lbAnswerA.Text) this.lbCurMarkA.Text = this.lbMarkA.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lbAnswerB.Text = "74351772720";
            if (tbB.Text == lbAnswerB.Text) this.lbCurMarkB.Text = this.lbMarkB.Text;
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
