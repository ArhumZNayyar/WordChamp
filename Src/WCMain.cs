/*
 *   WordChamp - Guess the word and compete with others on the ranked ladder.
 *   Copyright (C) 2022 Arhum Z. Nayyar
 *
 *   This program is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <https://www.gnu.org/licenses/>.
 *   
*/

using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using WordChamp.Src;

namespace WordChamp
{
    public partial class WCMain : Form
    {
        private Graphics graphics;
        private Grid WCGrid = new Grid();
        private Font fnt = new Font("Arial", 10);

        int currentRow = 0;
        int currentColumn = 0;
        int currentNode = 0;
        int totalCorrect = 0;
        int totalPoints = 0;
        string word = "null";
        bool completed = false;
        

        public WCMain()
        {
            InitializeComponent();
            CheckUpdate();
            InitializeGrid(WCGrid);
            graphics = this.CreateGraphics();
            answerBox.Parent = canvasSurface;
        }

        public void CheckUpdate()
        {
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            Console.WriteLine("Current version: " + version);

            string fileContent = new WebClient().DownloadString("https://www.dropbox.com/s/0xo2kda53umwbz0/App_Update.txt?dl=1");
            if (fileContent != version)
            {
                var result = MessageBox.Show("New update available.\nDownload Update?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Console.WriteLine("New version: " + fileContent);
                    Console.WriteLine("Version mismatch. Updating program.");
                    dlProgressBar.Visible = true;
                    dlProgLabel.Visible = true;
                    using (var client = new WebClient())
                    {
                        Uri URL = new Uri("https://www.dropbox.com/s/822lbovvoqfue0e/Word%20Champ.dll?dl=1");
                        client.DownloadFile(URL, Application.StartupPath + @"\tempClient\Word Champ.dll");
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                        URL = new Uri("https://www.dropbox.com/s/kx34nglxx65o783/Word%20Champ.exe?dl=1");
                        client.DownloadFileAsync(URL, Application.StartupPath + @"\tempClient\Word Champ.exe");
                        Console.WriteLine(Application.StartupPath);
                    }
                }
                else
                {
                    Environment.Exit(0);
                    Application.Exit();
                }
            }
            Console.WriteLine("Updating Solution");
            try
            {
                fileContent = new WebClient().DownloadString("https://www.dropbox.com/s/foobtbypiop8030/App_Key.txt?dl=1");
                Console.WriteLine(fileContent);
                this.word = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Caught", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // The event that will trigger when the WebClient is completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.\nPress OK to retry.");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Download complete. \nPress OK to Update.", "Update");

                // Rename current process
                var self = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var selfFileName = Path.GetFileName(self);
                var selfWithoutExt = Path.Combine(Path.GetDirectoryName(self), Path.GetFileNameWithoutExtension(self));
                System.IO.File.Move(selfWithoutExt + ".exe", "WC.exe");

                // Start batch file that will delete old program and move/start the new one
                ProcessStartInfo startInfo = new ProcessStartInfo("patchhelp.bat");
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.WorkingDirectory = Path.GetDirectoryName(self);
                Process.Start(startInfo);
                Application.ExitThread();
                Application.Exit();
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Update the progressbar percentage
            Console.WriteLine("Downloading Update: " + e.ProgressPercentage + "%");
            dlProgressBar.Value = e.ProgressPercentage;

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            dlProgLabel.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        public void InitializeGrid(Grid grid)
        {
            WCGrid.maxColumns = word.Length;
            WCGrid.word = this.word;
            for (int row = 1; row <= grid.maxRows; row++)
            {
                for (int col = 1; col <= grid.maxColumns; col++)
                {
                    grid.createNode(col, row, grid);
                }
            }
        }

        public void DrawNodes(Graphics g)
        {
            Pen drawColor = new Pen(Color.Black, 3);
            int currNode = 0;
            // Iterate through the rows and columns and draw the grid -> nodes
            for (int row = 1; row <= WCGrid.maxRows; row++)
            {
                for (int col = 1; col <= WCGrid.maxColumns; col++)
                {
                    Rectangle rect = new Rectangle(64 * col, (64 * row), 25, 25);
                    drawColor = new Pen(WCGrid.allNodes[currNode].getColor());
                    g.DrawRectangle(drawColor, rect);
                    g.DrawString(WCGrid.allNodes[currNode].userAnswer.ToString().ToUpper(),
                fnt, System.Drawing.Brushes.Black, new Point((64 * col) + 3, (64 * row) + 3));
                    currNode += 1;
                }
            }
        }

        public void checkInput()
        {
            if (!String.IsNullOrEmpty(answerBox.Text))
            {
                // Set the entered character to uppercase
                answerBox.Text = answerBox.Text.ToUpper();
                // Add the users input as an answer to the node they are currently on
                WCGrid.allNodes[currentNode].addAnswer(answerBox.Text[0]);
                // Increment the current node / column the user is on
                currentNode++;
                currentColumn++;
                // Check if the user has completed every possible node
                if (currentNode == WCGrid.allNodes.Count)
                {
                    completed = true;
                    return;
                }
                // Reset the textbox to a new location (next node) and set the text to null
                answerBox.Location = new Point(WCGrid.allNodes[currentNode].x + 3, WCGrid.allNodes[currentNode].y + 3);
                answerBox.Text = null;
            }
        }

        public void checkAnswer()
        {
            // If the user has reached the last column of the row (I.E: Word is Computer and they are at 'r' check the answer
            // Note: It only gets validated once that 'r' is typed in this example
            if (currentColumn == this.word.Length)
            {
                currentColumn = 0;
                currentRow++;
                for (int i = 0; i < WCGrid.allNodes.Count; i++)
                {
                    if (WCGrid.allNodes[i].colPos == currentRow && WCGrid.allNodes[i].correct == true)
                    {
                        totalCorrect += 1;
                    }
                }
                // If the total amount of correct nodes is the same as the word length then the user has guessed the word
                if (totalCorrect == this.word.Length)
                {
                    MessageBox.Show("You win!");
                    completed = true;
                    switch (currentRow)
                    {
                        case 1:
                            Console.WriteLine("First try! +1000 points");
                            totalPoints += 1000;
                            break;
                        case 2:
                            Console.WriteLine("Second try. +500 points");
                            totalPoints += 500;
                            break;
                        case 3:
                            Console.WriteLine("Third try. +250 points");
                            totalPoints += 250;
                            break;
                        case 4:
                            Console.WriteLine("Fourth try. +100 points");
                            totalPoints += 100;
                            break;
                        case 5:
                            Console.WriteLine("Fifth try. +25 points");
                            totalPoints += 25;
                            break;
                        default:
                            Console.WriteLine("Failed all attempts. No points.");
                            break;
                    }
                }
                else
                {
                    totalCorrect = 0;
                }
            }
        }

        private void canvasPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create a local version of the graphics object for the Canvas.
            Graphics canvasGraphics = e.Graphics;

            // Draw a string on the Canvas that shows the topic.
            // TODO: Get the topic from network
            canvasGraphics.DrawString("Today's topic is: FROMSOFTWARE",
                fnt, System.Drawing.Brushes.Black, new Point(30, 30));
            // Call the function to draw the grid and nodes
            DrawNodes(canvasGraphics);
        }

        private void WCMain_Load(object sender, EventArgs e)
        {
            // If the user is new, prompt for a login
            if (String.IsNullOrEmpty(Properties.Settings.Default.userName))
            {
                Login login = new Login();
                login.ShowDialog();
                MessageBox.Show(Properties.Settings.Default.userName + " has been submitted", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            usernameLabel.Text = Properties.Settings.Default.userName;
            // Connect the Paint event of the Canvas to the event handler method.
            canvasSurface.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPaint);

            // Add the Canvas (Picturebox) control to the Form.
            this.Controls.Add(canvasSurface);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            this.canvasSurface.Refresh();
            checkAnswer();
            if (!completed)
                checkInput();
            if (completed)
            {
                answerBox.Enabled = false;
                answerBox.Visible = false;
            }
            pointsLabel.Text = "Total Points: " + totalPoints;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}