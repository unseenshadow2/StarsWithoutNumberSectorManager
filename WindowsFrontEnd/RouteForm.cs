using DBAccess;
using StarsRecords.Supporting_Sheets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFrontEnd
{
	public partial class RouteForm : Form
	{
		private int currentRouteId = -1; // An Id of -1 indicates a new planet

		private List<Star> starList = new List<Star>();

		public RouteForm()
		{
			InitializeComponent();
		}

		private void RouteForm_Load(object sender, EventArgs e)
		{
			ResetListboxAndData();
		}

		/// <summary>
		/// Update the display when the index is changed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lbxRoutes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lbxRoutes.SelectedItem != null)
			{
				currentRouteId = ((TradeRoute)lbxRoutes.SelectedItem).id;

				using (SectorContext db = new SectorContext())
				{
					UpdateData((from t in db.routes
								where (t.id == currentRouteId)
								select t).FirstOrDefault());
				}
			}
		}

		/// <summary>
		/// Save the trade route.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSave_Click(object sender, EventArgs e)
		{
			using (SectorContext db = new SectorContext())
			{
				TradeRoute toSave;

				if (currentRouteId == -1)
				{
					toSave = new TradeRoute();
					db.routes.Add(toSave);
				}
				else
				{
					toSave =
						(from t in db.routes
						 where (t.id == currentRouteId)
						 select t).FirstOrDefault();
				}

				if (toSave != null)
				{
					toSave.star1X = (int)nud1X.Value;
					toSave.star1Y = (int)nud1Y.Value;
					toSave.star2X = (int)nud2X.Value;
					toSave.star2Y = (int)nud2Y.Value;

					db.SaveChanges();

					currentRouteId = toSave.id;
				}
			}

			UpdateListbox();
		}

		/// <summary>
		/// Setup a new trade route.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnNew_Click(object sender, EventArgs e)
		{
			nud1X.Value = 0;
			nud1Y.Value = 0;
			nud2X.Value = 0;
			nud2Y.Value = 0;

			currentRouteId = -1;
			lbxRoutes.ClearSelected();
		}

		/// <summary>
		/// Delete the current trade route.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			using (SectorContext db = new SectorContext())
			{
				if (db.routes.Count() > 0)
				{
					db.routes.Remove((from t in db.routes
									 where (t.id == currentRouteId)
									 select t).FirstOrDefault());

					db.SaveChanges();
				}
			}

			ResetListboxAndData();
		}

		/// <summary>
		/// Update the listbox and data sections.
		/// </summary>
		/// <param name="star"></param>
		private void UpdateGUI(TradeRoute route)
		{
			UpdateListbox();
			UpdateData(route);
		}

		/// <summary>
		/// Updates the listbox with all the current stars.
		/// </summary>
		private void UpdateListbox()
		{
			lbxRoutes.Items.Clear();

			using (SectorContext db = new SectorContext())
			{
				foreach (TradeRoute r in db.routes)
				{
					lbxRoutes.Items.Add(r);
				}
			}

			if (currentRouteId != -1)
			{
				lbxRoutes.SelectedItem = (from TradeRoute r in lbxRoutes.Items
										 where (r.id == currentRouteId)
										 select r).FirstOrDefault();
			}
			else
			{
				lbxRoutes.ClearSelected();
			}
		}

		/// <summary>
		/// Updates the data section of the form.
		/// </summary>
		/// <param name="star">The planet to display in the data section of the form</param>
		private void UpdateData(TradeRoute route)
		{
			nud1X.Value = route.star1X;
			nud1Y.Value = route.star1Y;
			nud2X.Value = route.star2X;
			nud2Y.Value = route.star2Y;
			nud1X.Focus();
		}

		/// <summary>
		/// Reset the listbox and data area.
		/// </summary>
		private void ResetListboxAndData()
		{
			using (SectorContext db = new SectorContext())
			{
				if (db.routes.Count() > 0)
				{
					TradeRoute current = (from r in db.routes
									orderby r.id ascending
									select r).FirstOrDefault();

					currentRouteId = current.id;
					UpdateGUI(current);
				}
				else UpdateListbox();
			}
		}
	}
}
