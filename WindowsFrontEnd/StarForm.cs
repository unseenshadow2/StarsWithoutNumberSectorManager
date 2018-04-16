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
	public partial class StarForm : Form
	{
		private int currentStarId = -1; // An Id of -1 indicates a new planet

		public StarForm()
		{
			InitializeComponent();
		}

		private void Stars_Load(object sender, EventArgs e)
		{
			ResetListboxAndData();
		}

		/// <summary>
		/// Save our current star.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSave_Click(object sender, EventArgs e)
		{
			using (SectorContext db = new SectorContext())
			{
				Star toSave;

				if (currentStarId == -1)
				{
					toSave = new Star();
					db.stars.Add(toSave);
				}
				else
				{
					toSave =
						(from s in db.stars
						 where (s.id == currentStarId)
						 select s).FirstOrDefault();
				}

				if (toSave != null)
				{
					toSave.name = txtName.Text;
					toSave.locX = (int)nudX.Value;
					toSave.locY = (int)nudY.Value;

					db.SaveChanges();

					currentStarId = toSave.id;
				}
			}

			UpdateListbox();
		}

		/// <summary>
		/// Set the Gui up for a new star.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnNew_Click(object sender, EventArgs e)
		{
			txtName.Text = "";
			nudX.Value = 0;
			nudY.Value = 0;

			currentStarId = -1;
			lbxStars.ClearSelected();
		}

		/// <summary>
		/// Delete the currently selected star.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			using (SectorContext db = new SectorContext())
			{
				if (db.stars.Count() > 0)
				{
					db.stars.Remove((from s in db.stars
									   where (s.id == currentStarId)
									   select s).FirstOrDefault());

					db.SaveChanges();
				}
			}

			ResetListboxAndData();
		}

		/// <summary>
		/// Update the display when the index is changed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lbxStars_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lbxStars.SelectedItem != null)
			{
				currentStarId = ((Star)lbxStars.SelectedItem).id;

				using (SectorContext db = new SectorContext())
				{
					UpdateData((from s in db.stars
								where (s.id == currentStarId)
								select s).FirstOrDefault());
				}
			}
		}

		/// <summary>
		/// Update the listbox and data sections.
		/// </summary>
		/// <param name="star"></param>
		private void UpdateGUI(Star star)
		{
			UpdateListbox();
			UpdateData(star);
		}

		/// <summary>
		/// Updates the listbox with all the current stars.
		/// </summary>
		private void UpdateListbox()
		{
			lbxStars.Items.Clear();

			using (SectorContext db = new SectorContext())
			{
				foreach (Star s in db.stars)
				{
					lbxStars.Items.Add(s);
				}
			}

			if (currentStarId != -1)
			{
				lbxStars.SelectedItem = (from Star s in lbxStars.Items
										   where (s.id == currentStarId)
										   select s).FirstOrDefault();
			}
			else
			{
				lbxStars.ClearSelected();
			}
		}

		/// <summary>
		/// Updates the data section of the form.
		/// </summary>
		/// <param name="star">The planet to display in the data section of the form</param>
		private void UpdateData(Star star)
		{
			txtName.Text = star.name;
			nudX.Value = star.locX;
			nudY.Value = star.locY;
			txtName.Focus();
		}

		/// <summary>
		/// Reset the listbox and data area.
		/// </summary>
		private void ResetListboxAndData()
		{
			using (SectorContext db = new SectorContext())
			{
				if (db.stars.Count() > 0)
				{
					Star current = (from s in db.stars
									  orderby s.id ascending
									  select s).FirstOrDefault();

					currentStarId = current.id;
					UpdateGUI(current);
				}
				else UpdateListbox();
			}
		}
	}
}
