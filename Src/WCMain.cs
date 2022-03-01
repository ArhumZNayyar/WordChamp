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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}