namespace CSDL_WinFormApp
{
    partial class FormXemCauHoi
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
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.dataGridViewCH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCH)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonThem.ForeColor = System.Drawing.Color.Black;
            this.buttonThem.Location = new System.Drawing.Point(298, 473);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(154, 45);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonXoa.ForeColor = System.Drawing.Color.Black;
            this.buttonXoa.Location = new System.Drawing.Point(589, 473);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(154, 45);
            this.buttonXoa.TabIndex = 1;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // dataGridViewCH
            // 
            this.dataGridViewCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCH.Location = new System.Drawing.Point(76, 76);
            this.dataGridViewCH.Name = "dataGridViewCH";
            this.dataGridViewCH.RowHeadersWidth = 51;
            this.dataGridViewCH.RowTemplate.Height = 24;
            this.dataGridViewCH.Size = new System.Drawing.Size(895, 360);
            this.dataGridViewCH.TabIndex = 2;
            this.dataGridViewCH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewCH.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCH_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "CÂU HỎI";
            // 
            // FormXemCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCH);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThem);
            this.Name = "FormXemCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXemCauHoi";
            this.Load += new System.EventHandler(this.FormXemCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.DataGridView dataGridViewCH;
        private System.Windows.Forms.Label label1;
    }
}