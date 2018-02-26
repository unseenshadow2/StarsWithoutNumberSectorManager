using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using HexTools.Regular;

namespace HexTools.Grid
{
	/// <summary>
	/// The arguments for a SingleHexagonDraw event.
	/// </summary>
	public class SingleHexagonDrawEventArgs : EventArgs
	{
		public Graphics gr;
		public Pen pen;
		public HexGrid grid;
		public RegularHexagon hex;
		public int row;
		public int column;
	}
}
