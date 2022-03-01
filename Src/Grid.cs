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
        }
    }
}
