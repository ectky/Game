namespace OfficialGameProject
{
    partial class Game
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
            this.userIcon = new System.Windows.Forms.Button();
            this.optionsPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.game3 = new System.Windows.Forms.PictureBox();
            this.game2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.game1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.optionsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1)).BeginInit();
            this.SuspendLayout();
            // 
            // userIcon
            // 
            this.userIcon.Location = new System.Drawing.Point(35, 16);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(30, 31);
            this.userIcon.TabIndex = 0;
            this.userIcon.UseVisualStyleBackColor = true;
            // 
            // optionsPic
            // 
            this.optionsPic.Location = new System.Drawing.Point(1300, 12);
            this.optionsPic.Name = "optionsPic";
            this.optionsPic.Size = new System.Drawing.Size(37, 31);
            this.optionsPic.TabIndex = 8;
            this.optionsPic.TabStop = false;
            this.optionsPic.Click += new System.EventHandler(this.optionsPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // game3
            // 
            this.game3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.game3.Location = new System.Drawing.Point(1008, 257);
            this.game3.Name = "game3";
            this.game3.Size = new System.Drawing.Size(245, 242);
            this.game3.TabIndex = 6;
            this.game3.TabStop = false;
            this.game3.MouseEnter += new System.EventHandler(this.game3_MouseEnter);
            this.game3.MouseLeave += new System.EventHandler(this.game3_MouseLeave);
            // 
            // game2
            // 
            this.game2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.game2.Location = new System.Drawing.Point(566, 257);
            this.game2.Name = "game2";
            this.game2.Size = new System.Drawing.Size(245, 242);
            this.game2.TabIndex = 5;
            this.game2.TabStop = false;
            this.game2.Click += new System.EventHandler(this.game2_Click);
            this.game2.MouseEnter += new System.EventHandler(this.game2_MouseEnter);
            this.game2.MouseLeave += new System.EventHandler(this.game2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(227, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(916, 74);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Green;
            this.logo.Location = new System.Drawing.Point(71, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1223, 110);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // game1
            // 
            this.game1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.game1.Location = new System.Drawing.Point(113, 257);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(245, 242);
            this.game1.TabIndex = 2;
            this.game1.TabStop = false;
            this.game1.MouseEnter += new System.EventHandler(this.game1_MouseEnter);
            this.game1.MouseLeave += new System.EventHandler(this.game1_MouseLeave);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OfficialGameProject.Properties.Resources.WoodenBackground;
            this.ClientSize = new System.Drawing.Size(1349, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.game3);
            this.Controls.Add(this.game2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.game1);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.optionsPic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPreview = true;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.optionsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userIcon;
        private System.Windows.Forms.PictureBox game1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox game2;
        private System.Windows.Forms.PictureBox game3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox optionsPic;
    }
}

