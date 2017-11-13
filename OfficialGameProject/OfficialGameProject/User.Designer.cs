namespace OfficialGameProject
{
    partial class User
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
            this.saveButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.ranklistButton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(61, 74);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(89, 103);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(102, 23);
            this.newUserButton.TabIndex = 1;
            this.newUserButton.Text = "Create new user";
            this.newUserButton.UseVisualStyleBackColor = true;
            // 
            // ranklistButton
            // 
            this.ranklistButton.Location = new System.Drawing.Point(61, 132);
            this.ranklistButton.Name = "ranklistButton";
            this.ranklistButton.Size = new System.Drawing.Size(75, 23);
            this.ranklistButton.TabIndex = 2;
            this.ranklistButton.Text = "Ranklist";
            this.ranklistButton.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username.Location = new System.Drawing.Point(12, 18);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(68, 15);
            this.username.TabIndex = 3;
            this.username.Text = "Username:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(38, 47);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(42, 15);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.Location = new System.Drawing.Point(86, 47);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(14, 15);
            this.score.TabIndex = 5;
            this.score.Text = "0";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(86, 17);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 6;
            // 
            // changeUserButton
            // 
            this.changeUserButton.Location = new System.Drawing.Point(8, 103);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(75, 23);
            this.changeUserButton.TabIndex = 7;
            this.changeUserButton.Text = "Change user";
            this.changeUserButton.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.ClientSize = new System.Drawing.Size(204, 168);
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.score);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.username);
            this.Controls.Add(this.ranklistButton);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Button ranklistButton;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button changeUserButton;
    }
}