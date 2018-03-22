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
			this.btnSaveGrid = new System.Windows.Forms.Button();
			this.sfdImage = new System.Windows.Forms.SaveFileDialog();
			this.btnPlanets = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSaveGrid
			// 
			this.btnSaveGrid.Location = new System.Drawing.Point(197, 227);
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
			// EntryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnPlanets);
			this.Controls.Add(this.btnSaveGrid);
			this.Name = "EntryForm";
			this.Load += new System.EventHandler(this.EntryForm_Load);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button btnSaveGrid;
		private System.Windows.Forms.SaveFileDialog sfdImage;
		private System.Windows.Forms.Button btnPlanets;
	}
}

