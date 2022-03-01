namespace WordChamp
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.submitNameButton = new System.Windows.Forms.Button();
            this.exitLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(111, 26);
            this.usernameBox.MaxLength = 12;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PlaceholderText = "12 Characters Max";
            this.usernameBox.Size = new System.Drawing.Size(120, 23);
            this.usernameBox.TabIndex = 1;
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameBox_KeyDown);
            // 
            // submitNameButton
            // 
            this.submitNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitNameButton.Location = new System.Drawing.Point(133, 55);
            this.submitNameButton.Name = "submitNameButton";
            this.submitNameButton.Size = new System.Drawing.Size(75, 23);
            this.submitNameButton.TabIndex = 2;
            this.submitNameButton.Text = "Submit";
            this.submitNameButton.UseVisualStyleBackColor = true;
            this.submitNameButton.Click += new System.EventHandler(this.submitNameButton_Click);
            // 
            // exitLoginButton
            // 
            this.exitLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitLoginButton.Location = new System.Drawing.Point(276, 65);
            this.exitLoginButton.Name = "exitLoginButton";
            this.exitLoginButton.Size = new System.Drawing.Size(75, 23);
            this.exitLoginButton.TabIndex = 3;
            this.exitLoginButton.Text = "Exit";
            this.exitLoginButton.UseVisualStyleBackColor = true;
            this.exitLoginButton.Click += new System.EventHandler(this.exitLoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(352, 90);
            this.Controls.Add(this.exitLoginButton);
            this.Controls.Add(this.submitNameButton);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox usernameBox;
        private Button submitNameButton;
        private Button exitLoginButton;
    }
}