namespace WordChamp
{
    partial class WCMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasSurface = new System.Windows.Forms.PictureBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.answerBox = new System.Windows.Forms.RichTextBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.dlProgressBar = new System.Windows.Forms.ProgressBar();
            this.dlProgLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateLadderButton = new System.Windows.Forms.Button();
            this.pointsEarnedLabel = new System.Windows.Forms.Label();
            this.ladderTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasSurface)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.xToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WCMain_MouseDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(26, 20);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(31, 20);
            this.toolStripMenuItem1.Text = "—";
            this.toolStripMenuItem1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // canvasSurface
            // 
            this.canvasSurface.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.canvasSurface.Location = new System.Drawing.Point(67, 67);
            this.canvasSurface.Name = "canvasSurface";
            this.canvasSurface.Size = new System.Drawing.Size(896, 391);
            this.canvasSurface.TabIndex = 1;
            this.canvasSurface.TabStop = false;
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(66, 67);
            this.answerBox.MaxLength = 1;
            this.answerBox.Multiline = false;
            this.answerBox.Name = "answerBox";
            this.answerBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.answerBox.Size = new System.Drawing.Size(20, 20);
            this.answerBox.TabIndex = 1;
            this.answerBox.Text = "";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(940, 24);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(74, 15);
            this.pointsLabel.TabIndex = 2;
            this.pointsLabel.Text = "Total Points: ";
            // 
            // dlProgressBar
            // 
            this.dlProgressBar.Location = new System.Drawing.Point(469, 492);
            this.dlProgressBar.Name = "dlProgressBar";
            this.dlProgressBar.Size = new System.Drawing.Size(150, 23);
            this.dlProgressBar.TabIndex = 3;
            this.dlProgressBar.Visible = false;
            // 
            // dlProgLabel
            // 
            this.dlProgLabel.AutoSize = true;
            this.dlProgLabel.Location = new System.Drawing.Point(479, 474);
            this.dlProgLabel.Name = "dlProgLabel";
            this.dlProgLabel.Size = new System.Drawing.Size(109, 15);
            this.dlProgLabel.TabIndex = 4;
            this.dlProgLabel.Text = "Download Progress";
            this.dlProgLabel.Visible = false;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(1082, 24);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(33, 15);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "User:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.Color.LightGreen;
            this.usernameLabel.Location = new System.Drawing.Point(1112, 24);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(27, 15);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "null";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(987, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 391);
            this.panel1.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(190, 381);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(987, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Next Ladder Update: ";
            // 
            // updateLadderButton
            // 
            this.updateLadderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateLadderButton.Location = new System.Drawing.Point(1051, 464);
            this.updateLadderButton.Name = "updateLadderButton";
            this.updateLadderButton.Size = new System.Drawing.Size(88, 23);
            this.updateLadderButton.TabIndex = 9;
            this.updateLadderButton.Text = "Update Now";
            this.updateLadderButton.UseVisualStyleBackColor = true;
            // 
            // pointsEarnedLabel
            // 
            this.pointsEarnedLabel.AutoSize = true;
            this.pointsEarnedLabel.Location = new System.Drawing.Point(488, 49);
            this.pointsEarnedLabel.Name = "pointsEarnedLabel";
            this.pointsEarnedLabel.Size = new System.Drawing.Size(85, 15);
            this.pointsEarnedLabel.TabIndex = 10;
            this.pointsEarnedLabel.Text = "Points Earned: ";
            // 
            // ladderTimer
            // 
            this.ladderTimer.Enabled = true;
            this.ladderTimer.Interval = 900000;
            this.ladderTimer.Tick += new System.EventHandler(this.ladderTimer_Tick);
            // 
            // WCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1199, 527);
            this.Controls.Add(this.pointsEarnedLabel);
            this.Controls.Add(this.updateLadderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.dlProgLabel);
            this.Controls.Add(this.dlProgressBar);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.canvasSurface);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WCMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordChamp";
            this.Load += new System.EventHandler(this.WCMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WCMain_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasSurface)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private PictureBox canvasSurface;
        private System.Windows.Forms.Timer mainTimer;
        private RichTextBox answerBox;
        private Label pointsLabel;
        private ProgressBar dlProgressBar;
        private Label dlProgLabel;
        private Label userLabel;
        private Label usernameLabel;
        private ToolStripMenuItem xToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button updateLadderButton;
        private Label pointsEarnedLabel;
        private System.Windows.Forms.Timer ladderTimer;
    }
}