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
    public partial class FormVong3 : Form
    {
        public FormVong3()
        {
            InitializeComponent();
        }

        private void FormVong3_Load(object sender, EventArgs e)
        {
            this.lbQues.Text = "344324234233123/12312312";
            
            this.lbCurMarkA.Text = "0";
            this.lbCurMarkB.Text = "0";
            this.lbMark.Text = "10";

        }

        private void buttonNop_Click(object sender, EventArgs e)
        {
            this.lbAnswerA.Text = "23";
            if (this.textBox1.Text == this.lbAnswerA.Text)
            {
                this.lbCurMarkA.Text = this.lbMark.Text;
                this.button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lbAnswerB.Text = "23";
            if (this.textBox2.Text == this.lbAnswerB.Text)
            {
                this.lbCurMarkB.Text = this.lbMark.Text;
                this.buttonNop.Enabled = false;
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
