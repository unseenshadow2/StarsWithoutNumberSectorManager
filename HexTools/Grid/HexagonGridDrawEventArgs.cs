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
	/// The EventArgs for a HexagonGridDraw event.
	/// </summary>
	public class HexagonGridDrawEventArgs : EventArgs
	{
		public Graphics gr;
		public Pen pen;
		public HexGrid grid;
	}
}
