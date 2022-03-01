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
        Graphics graphics;
        Grid WCGrid = new Grid();
        string word = "null";
        private Font fnt = new Font("Arial", 10);

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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}