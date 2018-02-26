using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexTools.Regular
{
	/// <summary>
	/// A single regular hexagon defined by PointF vertices.
	/// </summary>
	public class RegularHexagon
	{
		private PointF[] _points = new PointF[6];
		private PointF _center = new PointF();

		public RegularHexagon(PointF[] vertices)
		{
			if (vertices.Count() == 6)
			{
				for (int i = 0; i < vertices.Count(); i++)
				{
					// Ensure a deep copy of the PointFs
					_points[i] = new PointF(vertices[i].X, vertices[i].Y);
				}
			}

			Update();
		}

		/// <summary>
		/// Updates the center value.
		/// </summary>
		public void Update()
		{
			_center.X = (vertices[0].X + vertices[3].X) / 2;
			_center.Y = (vertices[0].Y + vertices[3].Y) / 2;
		}

		// Getters and Setters
		public PointF[] vertices { get { return _points; } }
		public PointF center { get { return _center; } }
	}
}
