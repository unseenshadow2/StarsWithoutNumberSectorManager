using DBAccess;
using HexTools.Grid;
using HexTools.Regular;
using StarsRecords.Supporting_Sheets;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDrawer
{
	/// <summary>
	/// Uses the HexGrid to draw a Stars Without Number Sector Map.
	/// </summary>
    public class MapDraw
    {
		// TODO: Add the player sidebar

		public HexGrid grid = new HexGrid();
		public string title = "Sector Name";
		public Font titleFont = new Font(FontFamily.GenericMonospace, 75f);
		public float verticleOffset = 100f;
		public float routePercentFromCenter = 0.40f; // This should be below 0.5
		public int starDotDiameter = 20;
		public int starTextOffset = 5;
		public Pen routePen = new Pen(Brushes.Black, 5f);
		public Color backgroundColor = Color.White;

		public MapDraw()
		{
			// Add our event handlers to the HexGrid
			grid.SingleHexDraw += DrawHexLabel;
			grid.SingleHexDraw += DrawStar;
			grid.HexagonGridDraw += DrawTradeRoutes;
			grid.HexagonGridDraw += DrawTitle;
			grid.BeforeGridDraw += DrawBackground;
		}

		/// <summary>
		/// Draws a grid to an image.
		/// </summary>
		/// <returns>The drawn grid</returns>
		public Image DrawGrid()
		{
			return grid.Draw(0, verticleOffset);
		}

		/// <summary>
		/// Draw labels on the hexes.
		/// </summary>
		/// <param name="e"></param>
		/// <remarks>This is placed in the form just to display adding code to the hex drawing</remarks>
		private void DrawHexLabel(object sender, SingleHexagonDrawEventArgs e)
		{
			// Label the hexagon
			using (StringFormat sf = new StringFormat())
			{
				sf.Alignment = StringAlignment.Center;
				sf.LineAlignment = StringAlignment.Far;
				string label = String.Format("0{0}0{1}", e.column, e.row);

				// Center + half height
				PointF labelPoint = e.hex.center;
				labelPoint.Y += e.grid.hexHeight / 2;

				e.gr.DrawString(label, e.grid.font, Brushes.Black, labelPoint, sf);
			}
		}

		/// <summary>
		/// Draws a dot and the name of the star if a star exists in the current position.
		/// </summary>
		/// <param name="e"></param>
		private void DrawStar(object sender, SingleHexagonDrawEventArgs e)
		{
			Star star;
			int halfStar = starDotDiameter / 2;

			using (SectorContext db = new SectorContext())
			{
				star = (from s in db.stars
						where ((s.locX == e.column) && (s.locY == e.row))
						select s).FirstOrDefault();
			}

			if (star != null)
			{
				e.gr.FillEllipse(Brushes.Black, 
					e.hex.center.X - halfStar, e.hex.center.Y - halfStar,
					starDotDiameter, starDotDiameter);

				using (StringFormat sf = new StringFormat())
				{
					sf.Alignment = StringAlignment.Center;
					sf.LineAlignment = StringAlignment.Center;

					PointF textPoint = e.hex.center;
					textPoint.Y += halfStar + starTextOffset + (grid.font.Size / 2);

					e.gr.DrawString(star.name, grid.font, Brushes.Black, textPoint, sf);
				}
			}
		}

		/// <summary>
		/// Draws all the given trade routes.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DrawTradeRoutes(object sender, HexagonGridDrawEventArgs e)
		{
			TradeRoute[] routes;
			PointF start = new PointF();
			PointF end = new PointF();

			using (SectorContext db = new SectorContext())
			{
				if (db.routes.Count() > 0)
				{
					//routes = (from r in db.routes
					//		  select r).ToArray();
					routes = db.routes.ToArray();
				}
				else
				{
					routes = null;
					throw new Exception("Route count is zero!");
				}
			}

			if (routes != null)
			{
				foreach (TradeRoute r in routes)
				{
					RegularHexagon hex1 = e.grid.Hexagons[r.star1Y, r.star1X];
					RegularHexagon hex2 = e.grid.Hexagons[r.star2Y, r.star2X];

					start = PointBetween(hex1.center, hex2.center, routePercentFromCenter);
					end = PointBetween(hex2.center, hex1.center, routePercentFromCenter);

					e.gr.DrawLine(routePen, start, end);
				}
			}
		}

		/// <summary>
		/// Draw a title after the grid was completed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DrawTitle(object sender, HexagonGridDrawEventArgs e)
		{
			// Get the distance between the leftmost and rightmost vertices
			float x = (e.grid.Hexagons[0, 0].vertices[0].X + e.grid.Hexagons[0, e.grid.columns - 1].vertices[3].X) / 2;

			// Label the Grid
			using (StringFormat sf = new StringFormat())
			{
				sf.Alignment = StringAlignment.Center;
				sf.LineAlignment = StringAlignment.Near;

				e.gr.DrawString(title, titleFont, Brushes.Black, x, 0, sf);
			}
		}

		/// <summary>
		/// Draw a solid background for the grid.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DrawBackground(object sender, HexagonGridDrawEventArgs e)
		{
			e.gr.Clear(backgroundColor);
		}

		/// <summary>
		/// Get's the point a certain percentage between the two given points.
		/// If no percentDistance is given, defaults to 50% (or 0.5).
		/// </summary>
		/// <param name="p1">The first point. The percent distance is from this point.</param>
		/// <param name="p2">The second point. The percent distance is to this point.</param>
		/// <param name="percentDistance"></param>
		/// <returns>The point between the two given</returns>
		private PointF PointBetween(PointF p1, PointF p2, float percentDistance = 0.5f)
		{
			PointF toReturn = new PointF();

			toReturn.X = FloatBetween(p1.X, p2.X, percentDistance);
			toReturn.Y = FloatBetween(p1.Y, p2.Y, percentDistance);

			return toReturn;
		}

		/// <summary>
		/// Get's the number a certain percentage between two floats.
		/// If no percentDistance is given, defaults to 50% (or 0.5).
		/// </summary>
		/// <param name="f1">The first float. The percent distance is from this float.</param>
		/// <param name="f2">The second float. The percent distance is to this float.</param>
		/// <param name="percentDistance">The percentage distance between the two</param>
		/// <returns>The float between the two given</returns>
		private float FloatBetween(float f1, float f2, float percentDistance = 0.5f)
		{
			float difference = -(f1 - f2);

			return f1 + (difference * percentDistance);
		}
	}
}
