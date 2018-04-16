using MapDrawer;
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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

		private void EntryForm_Load(object sender, EventArgs e)
		{
			Text = Program.Title;
		}

		/// <summary>
		/// Generate and save a hexagon grid map.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSaveGrid_Click(object sender, EventArgs e)
		{
			sfdImage.ShowDialog();

			if (sfdImage.FileName != String.Empty)
			{
				MapDraw draw = new MapDraw();
				Image image = draw.DrawGrid();
				image.Save(sfdImage.FileName);
			}
		}

		/// <summary>
		/// Show a new Planets form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPlanets_Click(object sender, EventArgs e)
		{
			new PlanetForm().Show();
		}

		/// <summary>
		/// Show a new Stars form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnStars_Click(object sender, EventArgs e)
		{
			new StarForm().Show();
		}
	}
}
