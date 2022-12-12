namespace CSDL_WinFormApp
{
    partial class FormQLVong2
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
            this.buttonXem = new System.Windows.Forms.Button();
            this.buttonChon = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonXem
            // 
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonXem.Location = new System.Drawing.Point(369, 380);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(329, 78);
            this.buttonXem.TabIndex = 5;
            this.buttonXem.Text = "Xem câu hỏi ";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // buttonChon
            // 
            this.buttonChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonChon.Location = new System.Drawing.Point(369, 247);
            this.buttonChon.Name = "buttonChon";
            this.buttonChon.Size = new System.Drawing.Size(329, 78);
            this.buttonChon.TabIndex = 4;
            this.buttonChon.Text = "Chọn câu hỏi cho đề";
            this.buttonChon.UseVisualStyleBackColor = true;
            this.buttonChon.Click += new System.EventHandler(this.buttonChon_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonThem.Location = new System.Drawing.Point(369, 96);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(329, 78);
            this.buttonThem.TabIndex = 3;
            this.buttonThem.Text = "Thêm câu hỏi cho đề";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // FormQLVong2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.buttonChon);
            this.Controls.Add(this.buttonThem);
            this.Name = "FormQLVong2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLVong2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.Button buttonChon;
        private System.Windows.Forms.Button buttonThem;
    }
}