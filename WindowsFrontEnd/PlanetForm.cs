using DBAccess;
using StarsRecords.Main_Sheets;
using StarsRecords.Supporting_Sheets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFrontEnd
{
	public partial class PlanetForm : Form
	{
		private int currentPlanetId = -1; // An Id of -1 indicates a new planet

		public PlanetForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Setup default planet on load
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlanetForm_Load(object sender, EventArgs e)
		{
			ResetListboxAndData();
		}

		/// <summary>
		/// Save the planet to the database.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSave_Click(object sender, EventArgs e)
		{
			using (SectorContext db = new SectorContext())
			{
				Planet toSave;

				if (currentPlanetId == -1)
				{
					toSave = new Planet();
					db.planets.Add(toSave);
				}
				else
				{
					toSave = 
						(from p in db.planets
						 where (p.id == currentPlanetId)
						 select p).FirstOrDefault();
				}

				if (toSave != null)
				{
					toSave.name = txtName.Text;
					toSave.locId = (cbxLocation.SelectedItem != null) ? ((Star)cbxLocation.SelectedItem).id : -1;
					toSave.atmosphere = txtAtmosphere.Text;
					toSave.temperature = txtTemperature.Text;
					toSave.biosphere = txtBiosphere.Text;
					toSave.population = txtPopulation.Text;
					toSave.techLevel = txtTechLevel.Text;
					toSave.tags = txtTags.Text;
					toSave.capitalAndGovernment = txtCapitalAndGovernment.Text;
					toSave.culturalNotes = txtCulturalNotes.Text;
					toSave.friends = txtFriends.Text;
					toSave.enemies = txtEnemies.Text;
					toSave.complications = txtComplications.Text;
					toSave.places = txtPlaces.Text;
					toSave.things = txtThings.Text;
					toSave.partyActivities = txtPartyActivities.Text;
					toSave.notes = txtNotes.Text;

					db.SaveChanges();

					currentPlanetId = toSave.id;
				}
			}

			UpdateListbox();
		}

		/// <summary>
		/// Sets up for a new planet.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnNew_Click(object sender, EventArgs e)
		{
			txtName.Text = "";
			cbxLocation.SelectedItem = null;
			txtAtmosphere.Text = "";
			txtTemperature.Text = "";
			txtBiosphere.Text = "";
			txtPopulation.Text = "";
			txtTechLevel.Text = "";
			txtTags.Text = "";
			txtCapitalAndGovernment.Text = "";
			txtCulturalNotes.Text = "";
			txtFriends.Text = "";
			txtEnemies.Text = "";
			txtComplications.Text = "";
			txtPlaces.Text = "";
			txtThings.Text = "";
			txtPartyActivities.Text = "";
			txtNotes.Text = "";

			currentPlanetId = -1;
			lbxPlanets.ClearSelected();
		}

		/// <summary>
		/// Delete the selected planet.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			using (SectorContext db = new SectorContext())
			{
				if (db.planets.Count() > 0)
				{
					db.planets.Remove((from p in db.planets
									   where (p.id == currentPlanetId)
									   select p).FirstOrDefault());

					db.SaveChanges();
				}
			}

			ResetListboxAndData();
		}

		/// <summary>
		/// When a new planet is selected, update the id.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lbxPlanets_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lbxPlanets.SelectedItem != null)
			{
				currentPlanetId = ((Planet)lbxPlanets.SelectedItem).id;

				using (SectorContext db = new SectorContext())
				{
					UpdateData((from p in db.planets
					 where (p.id == currentPlanetId)
					 select p).FirstOrDefault());
				}
			}
		}

		/// <summary>
		/// Updates all parts of the gui with the currently selected planet.
		/// </summary>
		/// /// <param name="planet">The planet to display in the data section of the form</param>
		private void UpdateGUI(Planet planet)
		{
			UpdateListbox();
			UpdateCombobox();
			UpdateData(planet);
		}

		/// <summary>
		/// Updates the listbox with all the current planets.
		/// </summary>
		private void UpdateListbox()
		{
			lbxPlanets.Items.Clear();

			using (SectorContext db = new SectorContext())
			{
				foreach (Planet p in db.planets)
				{
					lbxPlanets.Items.Add(p);
				}
			}

			if (currentPlanetId != -1)
			{
				lbxPlanets.SelectedItem = (from Planet p in lbxPlanets.Items
										   where (p.id == currentPlanetId)
										   select p).FirstOrDefault();
			}
			else
			{
				lbxPlanets.ClearSelected();
			}
		}

		/// <summary>
		/// Updates the data section of the form.
		/// </summary>
		/// <param name="planet">The planet to display in the data section of the form</param>
		private void UpdateData(Planet planet)
		{
			txtName.Text = planet.name;
			txtAtmosphere.Text = planet.atmosphere;
			txtTemperature.Text = planet.temperature;
			txtBiosphere.Text = planet.biosphere;
			txtPopulation.Text = planet.population;
			txtTechLevel.Text = planet.techLevel;
			txtTags.Text = planet.tags;
			txtCapitalAndGovernment.Text = planet.capitalAndGovernment;
			txtCulturalNotes.Text = planet.culturalNotes;
			txtFriends.Text = planet.friends;
			txtEnemies.Text = planet.enemies;
			txtComplications.Text = planet.complications;
			txtPlaces.Text = planet.places;
			txtThings.Text = planet.things;
			txtPartyActivities.Text = planet.partyActivities;
			txtNotes.Text = planet.notes;

			cbxLocation.SelectedItem = (from Star s in cbxLocation.Items
										where (planet.locId == s.id)
										select s).FirstOrDefault();
		}

		/// <summary>
		/// Updates the location combobox.
		/// </summary>
		private void UpdateCombobox()
		{
			cbxLocation.Items.Clear();

			using (SectorContext db = new SectorContext())
			{
				foreach (Star s in db.stars)
				{
					cbxLocation.Items.Add(s);
				}
			}
		}

		/// <summary>
		/// Reset the listbox and data area.
		/// </summary>
		private void ResetListboxAndData()
		{
			using (SectorContext db = new SectorContext())
			{
				if (db.planets.Count() > 0)
				{
					Planet current = (from p in db.planets
									  orderby p.id ascending
									  select p).FirstOrDefault();

					currentPlanetId = current.id;
					UpdateGUI(current);
				}
				else
				{
					UpdateListbox();
					UpdateCombobox();
				}
			}
		}
	}
}
