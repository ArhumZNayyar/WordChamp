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
            InitializeGrid(WCGrid);
            graphics = this.CreateGraphics();
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