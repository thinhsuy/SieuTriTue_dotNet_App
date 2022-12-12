
namespace CSDL_WinFormApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.player = new System.Windows.Forms.Button();
            this.match = new System.Windows.Forms.Button();
            this.nameofshow = new System.Windows.Forms.Label();
            this.contentofmatch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.player.Location = new System.Drawing.Point(355, 129);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(325, 98);
            this.player.TabIndex = 0;
            this.player.Text = "Quản lí người chơi";
            this.player.UseVisualStyleBackColor = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // match
            // 
            this.match.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.match.BackColor = System.Drawing.Color.White;
            this.match.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.match.Location = new System.Drawing.Point(355, 269);
            this.match.Name = "match";
            this.match.Size = new System.Drawing.Size(325, 98);
            this.match.TabIndex = 1;
            this.match.Text = "Quản lí trò chơi";
            this.match.UseVisualStyleBackColor = false;
            this.match.Click += new System.EventHandler(this.match_Click);
            // 
            // nameofshow
            // 
            this.nameofshow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameofshow.AutoSize = true;
            this.nameofshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameofshow.ForeColor = System.Drawing.Color.White;
            this.nameofshow.Location = new System.Drawing.Point(386, 46);
            this.nameofshow.Name = "nameofshow";
            this.nameofshow.Size = new System.Drawing.Size(274, 44);
            this.nameofshow.TabIndex = 3;
            this.nameofshow.Text = "SIÊU TRÍ TUỆ";
            this.nameofshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameofshow.Click += new System.EventHandler(this.nameofshow_Click);
            // 
            // contentofmatch
            // 
            this.contentofmatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentofmatch.BackColor = System.Drawing.Color.White;
            this.contentofmatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.contentofmatch.Location = new System.Drawing.Point(355, 405);
            this.contentofmatch.Name = "contentofmatch";
            this.contentofmatch.Size = new System.Drawing.Size(325, 94);
            this.contentofmatch.TabIndex = 4;
            this.contentofmatch.Text = "Bắt đầu";
            this.contentofmatch.UseVisualStyleBackColor = false;
            this.contentofmatch.Click += new System.EventHandler(this.contentofmatch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1070, 559);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.contentofmatch);
            this.Controls.Add(this.nameofshow);
            this.Controls.Add(this.match);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1085, 601);
            this.MinimumSize = new System.Drawing.Size(1085, 601);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button player;
        private System.Windows.Forms.Button match;
        private System.Windows.Forms.Label nameofshow;
        private System.Windows.Forms.Button contentofmatch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

