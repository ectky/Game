namespace OfficialGameProject
{
    partial class AboutTheGame
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
            this.abotText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abotText
            // 
            this.abotText.Location = new System.Drawing.Point(12, 9);
            this.abotText.Name = "abotText";
            this.abotText.Size = new System.Drawing.Size(520, 124);
            this.abotText.TabIndex = 0;
            this.abotText.Text = "Text";
            // 
            // AboutTheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(544, 142);
            this.Controls.Add(this.abotText);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutTheGame";
            this.Text = "AboutTheGame";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label abotText;
    }
}