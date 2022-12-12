namespace CSDL_WinFormApp
{
    partial class FormQLVong1
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
            this.buttonChon = new System.Windows.Forms.Button();
            this.buttonXem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(360, 88);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(329, 78);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm câu hỏi cho đề";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonChon
            // 
            this.buttonChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChon.Location = new System.Drawing.Point(360, 239);
            this.buttonChon.Name = "buttonChon";
            this.buttonChon.Size = new System.Drawing.Size(329, 78);
            this.buttonChon.TabIndex = 1;
            this.buttonChon.Text = "Chọn câu hỏi cho đề";
            this.buttonChon.UseVisualStyleBackColor = true;
            this.buttonChon.Click += new System.EventHandler(this.buttonChon_Click);
            // 
            // buttonXem
            // 
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXem.Location = new System.Drawing.Point(360, 372);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(329, 78);
            this.buttonXem.TabIndex = 2;
            this.buttonXem.Text = "Xem câu hỏi ";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // FormQLVong1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.buttonChon);
            this.Controls.Add(this.buttonThem);
            this.Name = "FormQLVong1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLVong1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonChon;
        private System.Windows.Forms.Button buttonXem;
    }
}