namespace CSDL_WinFormApp
{
    partial class FormViewPlayer
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
            this.dataGridViewNC = new System.Windows.Forms.DataGridView();
            this.player = new System.Windows.Forms.Label();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNC)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNC
            // 
            this.dataGridViewNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNC.Location = new System.Drawing.Point(77, 106);
            this.dataGridViewNC.Name = "dataGridViewNC";
            this.dataGridViewNC.RowHeadersWidth = 51;
            this.dataGridViewNC.RowTemplate.Height = 24;
            this.dataGridViewNC.Size = new System.Drawing.Size(903, 302);
            this.dataGridViewNC.TabIndex = 0;
            this.dataGridViewNC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNC_CellDoubleClick);
            this.dataGridViewNC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewNC_CellMouseClick);
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player.ForeColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(403, 34);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(251, 42);
            this.player.TabIndex = 1;
            this.player.Text = "NGƯỜI CHƠI";
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonSua.ForeColor = System.Drawing.Color.Black;
            this.buttonSua.Location = new System.Drawing.Point(151, 473);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(239, 46);
            this.buttonSua.TabIndex = 2;
            this.buttonSua.Text = "Sửa thông tin";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.ForeColor = System.Drawing.Color.Black;
            this.buttonXoa.Location = new System.Drawing.Point(609, 473);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(239, 46);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa người chơi";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // FormViewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.player);
            this.Controls.Add(this.dataGridViewNC);
            this.Name = "FormViewPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewPlayer";
            this.Load += new System.EventHandler(this.FormViewPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNC;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
    }
}