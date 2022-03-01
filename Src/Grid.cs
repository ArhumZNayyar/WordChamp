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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordChamp.Src
{
    public class Grid
    {
        public int maxRows = 5;
        public int maxColumns = 5;
        public int amountofNodes = 25;
        public string word = "null";
        public List<Node> allNodes = new List<Node>();
        public Grid.Node? Nodes;

        public void createNode(int row, int column, Grid grid)
        {
            Nodes = new Grid.Node();
            Nodes.setNode(row, column, grid);
            allNodes.Add(Nodes);
        }

        public class Node : Grid
        {
            /* Node Data */
            public int rowPos;
            public int colPos;
            public int x;
            public int y;
            public char userAnswer;
            public char trueAnswer;
            public bool correct;
            public Color color;

            public Node()
            {
                this.rowPos = 0;
                this.colPos = 0;
                this.x = 0;
                this.y = 0;
                this.color = Color.Black;
                this.correct = false;
                this.trueAnswer = 'a';
            }

            public bool checkAnswer() { return this.correct; }
            public Color getColor() { return this.color; }

            public void setNode(int row, int column, Grid grid)
            {
                this.rowPos = row;
                this.colPos = column;
                this.x = 64 * row;
                this.y = 64 * column;
                this.trueAnswer = grid.word[row - 1];
                this.trueAnswer = Char.ToUpper(this.trueAnswer);
            }

            public void addAnswer(char ans)
            {
                this.userAnswer = ans;
                if (this.userAnswer == this.trueAnswer)
                {
                    this.color = Color.Green;
                    this.correct = true;
                }
                else
                {
                    this.color = Color.Red;
                    this.correct = false;
                }
            }

        }
    }
}
