namespace CSDL_WinFormApp
{
    partial class FormQLTroChoi
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
            this.buttonVong1 = new System.Windows.Forms.Button();
            this.buttonVong2 = new System.Windows.Forms.Button();
            this.buttonVong3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVong1
            // 
            this.buttonVong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonVong1.Location = new System.Drawing.Point(411, 49);
            this.buttonVong1.Name = "buttonVong1";
            this.buttonVong1.Size = new System.Drawing.Size(222, 103);
            this.buttonVong1.TabIndex = 0;
            this.buttonVong1.Text = "Vòng 1";
            this.buttonVong1.UseVisualStyleBackColor = true;
            this.buttonVong1.Click += new System.EventHandler(this.buttonVong1_Click);
            // 
            // buttonVong2
            // 
            this.buttonVong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonVong2.Location = new System.Drawing.Point(411, 214);
            this.buttonVong2.Name = "buttonVong2";
            this.buttonVong2.Size = new System.Drawing.Size(222, 103);
            this.buttonVong2.TabIndex = 1;
            this.buttonVong2.Text = "Vòng 2";
            this.buttonVong2.UseVisualStyleBackColor = true;
            this.buttonVong2.Click += new System.EventHandler(this.buttonVong2_Click);
            // 
            // buttonVong3
            // 
            this.buttonVong3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonVong3.Location = new System.Drawing.Point(411, 380);
            this.buttonVong3.Name = "buttonVong3";
            this.buttonVong3.Size = new System.Drawing.Size(222, 103);
            this.buttonVong3.TabIndex = 2;
            this.buttonVong3.Text = "Vòng 3";
            this.buttonVong3.UseVisualStyleBackColor = true;
            this.buttonVong3.Click += new System.EventHandler(this.buttonVong3_Click);
            // 
            // FormQLTroChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1026, 554);
            this.Controls.Add(this.buttonVong3);
            this.Controls.Add(this.buttonVong2);
            this.Controls.Add(this.buttonVong1);
            this.Name = "FormQLTroChoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLTroChoi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVong1;
        private System.Windows.Forms.Button buttonVong2;
        private System.Windows.Forms.Button buttonVong3;
    }
}