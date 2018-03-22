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

		private void btnPlanets_Click(object sender, EventArgs e)
		{
			new PlanetForm().Show();
		}
	}
}
