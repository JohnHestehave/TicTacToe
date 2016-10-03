using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TicTacToe
{
	public class Holder
	{
		private Point location;
		private int value = Board.B;
		public void setLocation(Point p)
		{
			location = p;
		}
		public Point getLocation()
		{
			return location;
		}
		public void setValue(int i)
		{
			value = i;
		}
		public int getValue()
		{
			return value;
		}
	}
}
