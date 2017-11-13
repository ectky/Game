namespace OfficialGameProject
{
    partial class Game2Maze
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
            this.Button1 = new System.Windows.Forms.Button();
            this.nudCols = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nudCols
            // 
            this.nudCols.Location = new System.Drawing.Point(12, 67);
            this.nudCols.Name = "nudCols";
            this.nudCols.Size = new System.Drawing.Size(120, 20);
            this.nudCols.TabIndex = 1;
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(102, 41);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 20);
            this.nudHeight.TabIndex = 2;
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(102, 15);
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 20);
            this.nudWidth.TabIndex = 3;
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(12, 93);
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(120, 20);
            this.nudRows.TabIndex = 4;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Panel1);
            this.Panel2.Location = new System.Drawing.Point(29, 120);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(457, 275);
            this.Panel2.TabIndex = 5;
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(50, 205);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(154, 70);
            this.Panel1.TabIndex = 6;
            // 
            // Game2Maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 454);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.nudRows);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudCols);
            this.Controls.Add(this.Button1);
            this.Name = "Game2Maze";
            this.Text = "Game2Maze";
            this.Load += new System.EventHandler(this.Game2Maze_Load);
            this.Resize += new System.EventHandler(this.Game2Maze_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.NumericUpDown nudCols;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel1;
    }
}