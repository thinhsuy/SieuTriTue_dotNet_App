using System;

namespace CSDL_WinFormApp
{
    partial class FormThemCauHoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cauhoiThem = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.tbChuso = new System.Windows.Forms.TextBox();
            this.labelChuso = new System.Windows.Forms.Label();
            this.tbPheptinh = new System.Windows.Forms.TextBox();
            this.labelPheptinh = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelDapan = new System.Windows.Forms.Label();
            this.tbDapAn = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Câu hỏi được thêm:";
            // 
            // cauhoiThem
            // 
            this.cauhoiThem.Location = new System.Drawing.Point(236, 37);
            this.cauhoiThem.Multiline = true;
            this.cauhoiThem.Name = "cauhoiThem";
            this.cauhoiThem.Size = new System.Drawing.Size(732, 73);
            this.cauhoiThem.TabIndex = 1;
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonThem.ForeColor = System.Drawing.Color.Black;
            this.buttonThem.Location = new System.Drawing.Point(387, 456);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(318, 72);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm ";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // tbChuso
            // 
            this.tbChuso.Location = new System.Drawing.Point(236, 129);
            this.tbChuso.Multiline = true;
            this.tbChuso.Name = "tbChuso";
            this.tbChuso.Size = new System.Drawing.Size(732, 52);
            this.tbChuso.TabIndex = 4;
            // 
            // labelChuso
            // 
            this.labelChuso.AutoSize = true;
            this.labelChuso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelChuso.ForeColor = System.Drawing.Color.White;
            this.labelChuso.Location = new System.Drawing.Point(54, 157);
            this.labelChuso.Name = "labelChuso";
            this.labelChuso.Size = new System.Drawing.Size(113, 20);
            this.labelChuso.TabIndex = 3;
            this.labelChuso.Text = "Chữ số/Bậc:";
            // 
            // tbPheptinh
            // 
            this.tbPheptinh.Location = new System.Drawing.Point(236, 202);
            this.tbPheptinh.Multiline = true;
            this.tbPheptinh.Name = "tbPheptinh";
            this.tbPheptinh.Size = new System.Drawing.Size(732, 52);
            this.tbPheptinh.TabIndex = 6;
            // 
            // labelPheptinh
            // 
            this.labelPheptinh.AutoSize = true;
            this.labelPheptinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelPheptinh.ForeColor = System.Drawing.Color.White;
            this.labelPheptinh.Location = new System.Drawing.Point(54, 230);
            this.labelPheptinh.Name = "labelPheptinh";
            this.labelPheptinh.Size = new System.Drawing.Size(94, 20);
            this.labelPheptinh.TabIndex = 5;
            this.labelPheptinh.Text = "Phép tính:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(236, 278);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(732, 52);
            this.textBox3.TabIndex = 8;
            // 
            // labelDapan
            // 
            this.labelDapan.AutoSize = true;
            this.labelDapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelDapan.ForeColor = System.Drawing.Color.White;
            this.labelDapan.Location = new System.Drawing.Point(54, 306);
            this.labelDapan.Name = "labelDapan";
            this.labelDapan.Size = new System.Drawing.Size(74, 20);
            this.labelDapan.TabIndex = 7;
            this.labelDapan.Text = "Đáp án:";
            // 
            // tbDapAn
            // 
            this.tbDapAn.Location = new System.Drawing.Point(236, 278);
            this.tbDapAn.Multiline = true;
            this.tbDapAn.Name = "tbDapAn";
            this.tbDapAn.Size = new System.Drawing.Size(732, 52);
            this.tbDapAn.TabIndex = 9;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(236, 364);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(732, 52);
            this.tbID.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(236, 364);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(732, 52);
            this.textBox6.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID câu hỏi:";
            // 
            // FormThemCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDapAn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelDapan);
            this.Controls.Add(this.tbPheptinh);
            this.Controls.Add(this.labelPheptinh);
            this.Controls.Add(this.tbChuso);
            this.Controls.Add(this.labelChuso);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.cauhoiThem);
            this.Controls.Add(this.label1);
            this.Name = "FormThemCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Round 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cauhoiThem;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox tbChuso;
        private System.Windows.Forms.Label labelChuso;
        private System.Windows.Forms.TextBox tbPheptinh;
        private System.Windows.Forms.Label labelPheptinh;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelDapan;
        private System.Windows.Forms.TextBox tbDapAn;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
    }
}