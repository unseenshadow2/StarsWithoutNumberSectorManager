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
	/// A class that handles drawing grids of regular hexagons.
	/// </summary>
	public class HexGrid
	{
		// Properties for accessing important or calculated values
		public float hexHeight
		{
			get { return _hexHeight; }
			set
			{
				_hexHeight = value;
				_hexWidth = HexWidth(_hexHeight);
			}
		}

		public float hexWidth { get { return _hexWidth; } }

		public RegularHexagon[,] Hexagons => _hexagons;

		// The size of the grid to be drawn
		public int rows = 10;
		public int columns = 8;

		// The font held by the HexGrid. Accessible for HexagonDrawEvenArgs.
		public Font font = new Font(FontFamily.GenericMonospace, 20f);

		// When drawing an image, how many hexs worth of padding should be added?
		public int xPad = 2;
		public int yPad = 2;

		// The HexGrid's events
		public event EventHandler<SingleHexagonDrawEventArgs> SingleHexDraw;
		public event EventHandler<HexagonGridDrawEventArgs> HexagonGridDraw;
		public event EventHandler<HexagonGridDrawEventArgs> BeforeGridDraw;

		// How high is each hex and the calculated value of each hexes width
		private float _hexHeight = 300f;
		private float _hexWidth;

		// An array of hexagons filled by the last call of DrawHexGrid
		// [row, column]
		private RegularHexagon[,] _hexagons;

		// The width ratio for more precise sizing when using the Draw function
		private const float WidthAdjust = 0.75f;

		public HexGrid()
		{
			ResizeGrid();
			_hexWidth = HexWidth(_hexHeight);
		}

		/// <summary>
		/// Draw an image from the hex grid the HexGrid would generate with DrawHexGrid using the default black pen.
		/// </summary>
		/// <param name="xOffset">The xOffset (in pixels) from the left hand side</param>
		/// <param name="yOffset">The yOffset (in pixels) from the top side</param>
		/// <returns>The generated image</returns>
		public Image Draw(float xOffset = 0, float yOffset = 0)
		{
			return Draw(Pens.Black, xOffset, yOffset);
		}

		/// <summary>
		/// Draw an image from the hex grid the HexGrid would generate with DrawHexGrid.
		/// </summary>
		/// <param name="pen">The pen with which to draw the lines</param>
		/// <param name="xOffset">The xOffset (in pixels) from the left hand side</param>
		/// <param name="yOffset">The yOffset (in pixels) from the top side</param>
		/// <returns>The generated image</returns>
		public Image Draw(Pen pen, float xOffset = 0, float yOffset = 0)
		{
			// Make our image
			int xSize = (int)Math.Ceiling(((columns * WidthAdjust) + xPad) * hexWidth);
			int ySize = (int)Math.Ceiling((rows + yPad) * hexHeight);
			Image toReturn = new Bitmap(xSize, ySize);

			Graphics gr = Graphics.FromImage(toReturn);

			// Draw the image
			DrawHexGrid(gr, pen, xOffset, yOffset);

			return toReturn;
		}

		/// <summary>
		/// Calculate the width of a hexagon based on its height.
		/// </summary>
		/// <param name="height">Height of the hexagon</param>
		/// <returns>Width of the hexagon</returns>
		private float HexWidth(float height)
		{
			return (float)(4 * (height / 2 / Math.Sqrt(3)));
		}
		
		/// <summary>
		/// Calculate the points of a hexagon at the given position. 
		/// Uses the height and width set in the class.
		/// </summary>
		/// <param name="row">The row of the hexagon</param>
		/// <param name="col">The column of the hexagon</param>
		/// <param name="xOffset">The offset to the right from the top left corner</param>
		/// <param name="yOffset">The offset to the bottom from the top left corner</param>
		/// <returns>The hexagon</returns>
		private RegularHexagon HexToPoints(float row, float col, float xOffset = 0, float yOffset = 0)
		{
			// Start with the leftmost corner of the upper left hexagon.
			float y = (hexHeight / 2) + yOffset;
			float x = xOffset;

			// Move down the required number of rows.
			y += row * hexHeight;

			// If the column is odd, move down half a hex more.
			if (col % 2 == 1) y += hexHeight / 2;

			// Move over for the column number.
			x += col * (hexWidth * 0.75f);

			// Generate the hexagon.
			return new RegularHexagon(new PointF[]
			{
				new PointF(x, y),
				new PointF(x + hexWidth * 0.25f, y - hexHeight / 2),
				new PointF(x + hexWidth * 0.75f, y - hexHeight / 2),
				new PointF(x + hexWidth, y),
				new PointF(x + hexWidth * 0.75f, y + hexHeight / 2),
				new PointF(x + hexWidth * 0.25f, y + hexHeight / 2),
			});
		}

		/// <summary>
		/// Get the row and column of the hexagon at a given position.
		/// </summary>
		/// <param name="x">The x position of the hexagon</param>
		/// <param name="y">The y position of the hexagon</param>
		/// <param name="row">The row of the hexagon</param>
		/// <param name="col">The column of the hexagon</param>
		public void PointToHex(float x, float y, out int row, out int col)
		{
			// Find the test rectangle containing the point.
			col = (int)(x / (hexWidth * 0.75f));

			if (col % 2 == 0)
				row = (int)(y / hexHeight);
			else
				row = (int)((y - hexHeight / 2) / hexHeight);

			// Find the test area.
			float testx = col * hexWidth * 0.75f;
			float testy = row * hexHeight;
			if (col % 2 == 1) testy += hexHeight / 2;

			// See if the point is above or
			// below the test hexagon on the left.
			bool is_above = false, is_below = false;
			float dx = x - testx;
			if (dx < hexWidth / 4)
			{
				float dy = y - (testy + hexHeight / 2);
				if (dx < 0.001)
				{
					// The point is on the left edge of the test rectangle.
					if (dy < 0) is_above = true;
					if (dy > 0) is_below = true;
				}
				else if (dy < 0)
				{
					// See if the point is above the test hexagon.
					if (-dy / dx > Math.Sqrt(3)) is_above = true;
				}
				else
				{
					// See if the point is below the test hexagon.
					if (dy / dx > Math.Sqrt(3)) is_below = true;
				}
			}

			// Adjust the row and column if necessary.
			if (is_above)
			{
				if (col % 2 == 0) row--;
				col--;
			}
			else if (is_below)
			{
				if (col % 2 == 1) row++;
				col--;
			}
		}

		/// <summary>
		/// Draws the hex grid on the given graphics.
		/// </summary>
		/// <param name="gr">The graphics to draw on</param>
		/// <param name="pen">The pen to draw the lines of the grid</param>
		/// <param name="xOffset">The offset to the right from the top left corner</param>
		/// <param name="yOffset">The offset to the bottom from the top left corner</param>
		public void DrawHexGrid(Graphics gr, Pen pen, float xOffset = 0, float yOffset = 0)
		{
			// Allow easier access to the points for drawing
			PointF[] points; 
			RegularHexagon hex;

			// Create our arguments outside of the loop to avoid extra garbage collection
			SingleHexagonDrawEventArgs singleArgs = new SingleHexagonDrawEventArgs();
			singleArgs.gr = gr;
			singleArgs.pen = pen;
			singleArgs.grid = this;

			HexagonGridDrawEventArgs gridArgs = new HexagonGridDrawEventArgs();
			gridArgs.gr = gr;
			gridArgs.pen = pen;
			gridArgs.grid = this;

			// Setup for drawing
			ResizeGrid();
			OnBeforeGridDraw(gridArgs);

			// Draw
			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < columns; col++)
				{
					// Calculate and draw the hexagon
					hex = HexToPoints(row, col, xOffset, yOffset);
					_hexagons[row, col] = hex;
					points = hex.vertices;
					gr.DrawPolygon(pen, points);

					// Update our event args
					singleArgs.hex = hex;
					singleArgs.row = row;
					singleArgs.column = col;

					// Run our hex events
					OnSingleHexDraw(singleArgs);
				}
			}

			// Run our grid draw events
			OnHexagonGridDraw(gridArgs);
		}

		/// <summary>
		/// Resizes the grid to the current size.
		/// </summary>
		private void ResizeGrid()
		{
			_hexagons = new RegularHexagon[rows, columns];
		}

		/// <summary>
		/// Runs the events for SingleHexDraw, protecting against null values.
		/// </summary>
		/// <param name="e">The arguments to be passed on</param>
		protected virtual void OnSingleHexDraw(SingleHexagonDrawEventArgs e)
		{
			SingleHexDraw?.Invoke(this, e);
		}

		/// <summary>
		/// Runs the events for HexagonGridDraw, protecting against null values.
		/// </summary>
		/// <param name="e">The arguments to be passed on</param>
		protected virtual void OnHexagonGridDraw(HexagonGridDrawEventArgs e)
		{
			HexagonGridDraw?.Invoke(this, e);
		}

		/// <summary>
		/// Runs the events for BeforeGridDraw, protecting against null values.
		/// </summary>
		/// <param name="e">The arguments to be passed on</param>
		protected virtual void OnBeforeGridDraw(HexagonGridDrawEventArgs e)
		{
			BeforeGridDraw?.Invoke(this, e);
		}
	}
}
