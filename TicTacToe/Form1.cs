using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public gfx engine;
        public Board theBoard;
		public static bool aiGame = false;

		public static bool getAiGame()
		{
			return aiGame;
		}

		

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics toPass = panel1.CreateGraphics();
            engine = new gfx(toPass);

            theBoard = new Board();
            theBoard.initBoard();

			refreshLabel();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point mouse = Cursor.Position;
            mouse = panel1.PointToClient(mouse);
            theBoard.detectHit(mouse);
			refreshLabel();
        }

		private void rButton_Click(object sender, EventArgs e)
		{
			theBoard.reset();
			gfx.setUpCanvas();
		}

		private void aButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This tic-tac-toe game was made by John.");
		}

		private void eButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		public void refreshLabel()
		{
			string newText = "It is ";
			if(theBoard.getPlayerForTurn() == Board.X)
			{
				newText += "X";
			}else
			{
				newText += "O";
			}

			newText += "'s turn\n";
			newText += "X has won "+theBoard.getXWins()+" time"+(theBoard.getXWins()==1? "": "s") + "\nO has won "+theBoard.getOWins()+" time"+(theBoard.getOWins()==1? "" : "s");

			label1.Text = newText;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (MessageBox.Show("Do you want to play against the computer?", "Tic Tac Toe", MessageBoxButtons.YesNo)==DialogResult.Yes)
			{
				aiGame = true;
			}
		}
	}
}
