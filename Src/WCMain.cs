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