namespace CSDL_WinFormApp
{
    partial class FormQLNguoiChoi
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
            this.buttonThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonXem
            // 
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonXem.Location = new System.Drawing.Point(364, 306);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(306, 65);
            this.buttonXem.TabIndex = 0;
            this.buttonXem.Text = "Xem người chơi";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonThem.Location = new System.Drawing.Point(364, 180);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(306, 65);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = "Thêm người chơi";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // FormQLNguoiChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonXem);
            this.Name = "FormQLNguoiChoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLNguoiChoi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.Button buttonThem;
    }
}