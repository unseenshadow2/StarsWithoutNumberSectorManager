namespace WindowsFrontEnd
{
    partial class EntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
			this.btnSaveGrid = new System.Windows.Forms.Button();
			this.sfdImage = new System.Windows.Forms.SaveFileDialog();
			this.btnPlanets = new System.Windows.Forms.Button();
			this.btnStars = new System.Windows.Forms.Button();
			this.btnRoutes = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSaveGrid
			// 
			this.btnSaveGrid.Location = new System.Drawing.Point(226, 227);
			this.btnSaveGrid.Name = "btnSaveGrid";
			this.btnSaveGrid.Size = new System.Drawing.Size(75, 23);
			this.btnSaveGrid.TabIndex = 0;
			this.btnSaveGrid.Text = "Save Grid";
			this.btnSaveGrid.UseVisualStyleBackColor = true;
			this.btnSaveGrid.Click += new System.EventHandler(this.btnSaveGrid_Click);
			// 
			// sfdImage
			// 
			this.sfdImage.DefaultExt = "png";
			this.sfdImage.FileName = "default";
			this.sfdImage.Filter = "Protable Network Graphics|*.png|JPEG|*.jpg|Bitmap|*.bmp";
			// 
			// btnPlanets
			// 
			this.btnPlanets.Location = new System.Drawing.Point(13, 13);
			this.btnPlanets.Name = "btnPlanets";
			this.btnPlanets.Size = new System.Drawing.Size(75, 23);
			this.btnPlanets.TabIndex = 1;
			this.btnPlanets.Text = "Planets";
			this.btnPlanets.UseVisualStyleBackColor = true;
			this.btnPlanets.Click += new System.EventHandler(this.btnPlanets_Click);
			// 
			// btnStars
			// 
			this.btnStars.Location = new System.Drawing.Point(13, 42);
			this.btnStars.Name = "btnStars";
			this.btnStars.Size = new System.Drawing.Size(75, 23);
			this.btnStars.TabIndex = 2;
			this.btnStars.Text = "Stars";
			this.btnStars.UseVisualStyleBackColor = true;
			this.btnStars.Click += new System.EventHandler(this.btnStars_Click);
			// 
			// btnRoutes
			// 
			this.btnRoutes.Location = new System.Drawing.Point(13, 71);
			this.btnRoutes.Name = "btnRoutes";
			this.btnRoutes.Size = new System.Drawing.Size(75, 23);
			this.btnRoutes.TabIndex = 3;
			this.btnRoutes.Text = "Routes";
			this.btnRoutes.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(95, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 117);
			this.label1.TabIndex = 4;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// EntryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 262);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRoutes);
			this.Controls.Add(this.btnStars);
			this.Controls.Add(this.btnPlanets);
			this.Controls.Add(this.btnSaveGrid);
			this.Name = "EntryForm";
			this.Load += new System.EventHandler(this.EntryForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btnSaveGrid;
		private System.Windows.Forms.SaveFileDialog sfdImage;
		private System.Windows.Forms.Button btnPlanets;
		private System.Windows.Forms.Button btnStars;
		private System.Windows.Forms.Button btnRoutes;
		private System.Windows.Forms.Label label1;
	}
}

