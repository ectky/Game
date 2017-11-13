namespace OfficialGameProject
{
    partial class Options
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
            this.mutePic = new System.Windows.Forms.PictureBox();
            this.infoPic = new System.Windows.Forms.PictureBox();
            this.musicPic = new System.Windows.Forms.PictureBox();
            this.stopGamePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mutePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopGamePic)).BeginInit();
            this.SuspendLayout();
            // 
            // mutePic
            // 
            this.mutePic.Location = new System.Drawing.Point(12, 12);
            this.mutePic.Name = "mutePic";
            this.mutePic.Size = new System.Drawing.Size(31, 31);
            this.mutePic.TabIndex = 5;
            this.mutePic.TabStop = false;
            this.mutePic.Visible = false;
            this.mutePic.Click += new System.EventHandler(this.mutePic_Click);
            // 
            // infoPic
            // 
            this.infoPic.Location = new System.Drawing.Point(13, 65);
            this.infoPic.Name = "infoPic";
            this.infoPic.Size = new System.Drawing.Size(31, 31);
            this.infoPic.TabIndex = 4;
            this.infoPic.TabStop = false;
            this.infoPic.Click += new System.EventHandler(this.infoPic_Click);
            // 
            // musicPic
            // 
            this.musicPic.Location = new System.Drawing.Point(12, 12);
            this.musicPic.Name = "musicPic";
            this.musicPic.Size = new System.Drawing.Size(31, 31);
            this.musicPic.TabIndex = 3;
            this.musicPic.TabStop = false;
            this.musicPic.Click += new System.EventHandler(this.musicPic_Click);
            // 
            // stopGamePic
            // 
            this.stopGamePic.Location = new System.Drawing.Point(12, 116);
            this.stopGamePic.Name = "stopGamePic";
            this.stopGamePic.Size = new System.Drawing.Size(31, 31);
            this.stopGamePic.TabIndex = 6;
            this.stopGamePic.TabStop = false;
            this.stopGamePic.Click += new System.EventHandler(this.stopGamePic_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(55, 159);
            this.Controls.Add(this.stopGamePic);
            this.Controls.Add(this.mutePic);
            this.Controls.Add(this.infoPic);
            this.Controls.Add(this.musicPic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.mutePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopGamePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox musicPic;
        private System.Windows.Forms.PictureBox infoPic;
        private System.Windows.Forms.PictureBox mutePic;
        private System.Windows.Forms.PictureBox stopGamePic;
    }
}