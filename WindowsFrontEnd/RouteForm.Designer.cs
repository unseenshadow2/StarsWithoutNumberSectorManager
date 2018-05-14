namespace WindowsFrontEnd
{
	partial class RouteForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lbxRoutes = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.nud1Y = new System.Windows.Forms.NumericUpDown();
			this.nud1X = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nud2Y = new System.Windows.Forms.NumericUpDown();
			this.nud2X = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbxGmOnly = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud1Y)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud1X)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud2Y)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud2X)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.btnNew);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(142, 262);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Trade Routes";
			// 
			// btnSave
			// 
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSave.Location = new System.Drawing.Point(3, 190);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(136, 23);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnNew
			// 
			this.btnNew.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnNew.Location = new System.Drawing.Point(3, 213);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(136, 23);
			this.btnNew.TabIndex = 7;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnDelete.Location = new System.Drawing.Point(3, 236);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(136, 23);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lbxRoutes
			// 
			this.lbxRoutes.DisplayMember = "display";
			this.lbxRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbxRoutes.FormattingEnabled = true;
			this.lbxRoutes.Location = new System.Drawing.Point(0, 0);
			this.lbxRoutes.Name = "lbxRoutes";
			this.lbxRoutes.Size = new System.Drawing.Size(136, 174);
			this.lbxRoutes.TabIndex = 0;
			this.lbxRoutes.TabStop = false;
			this.lbxRoutes.ValueMember = "display";
			this.lbxRoutes.SelectedIndexChanged += new System.EventHandler(this.lbxRoutes_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(149, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 52);
			this.label1.TabIndex = 1;
			this.label1.Text = "NOTE: Before assigning trade routes,\r\nit is advisable to have the stars and map\r\n" +
    "generated. Try to have trade routes go\r\nfrom one hex to an adjacent hex.";
			// 
			// nud1Y
			// 
			this.nud1Y.Location = new System.Drawing.Point(216, 84);
			this.nud1Y.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.nud1Y.Name = "nud1Y";
			this.nud1Y.Size = new System.Drawing.Size(48, 20);
			this.nud1Y.TabIndex = 2;
			// 
			// nud1X
			// 
			this.nud1X.Location = new System.Drawing.Point(216, 61);
			this.nud1X.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.nud1X.Name = "nud1X";
			this.nud1X.Size = new System.Drawing.Size(48, 20);
			this.nud1X.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(149, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Hex 1 Y:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(149, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Hex 1 X:";
			// 
			// nud2Y
			// 
			this.nud2Y.Location = new System.Drawing.Point(216, 138);
			this.nud2Y.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.nud2Y.Name = "nud2Y";
			this.nud2Y.Size = new System.Drawing.Size(48, 20);
			this.nud2Y.TabIndex = 4;
			// 
			// nud2X
			// 
			this.nud2X.Location = new System.Drawing.Point(216, 115);
			this.nud2X.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.nud2X.Name = "nud2X";
			this.nud2X.Size = new System.Drawing.Size(48, 20);
			this.nud2X.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(149, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Hex 2 Y:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(149, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Hex 2 X:";
			// 
			// cbxGmOnly
			// 
			this.cbxGmOnly.AutoSize = true;
			this.cbxGmOnly.Location = new System.Drawing.Point(149, 171);
			this.cbxGmOnly.Name = "cbxGmOnly";
			this.cbxGmOnly.Size = new System.Drawing.Size(67, 17);
			this.cbxGmOnly.TabIndex = 5;
			this.cbxGmOnly.Text = "GM Only";
			this.cbxGmOnly.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbxRoutes);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(136, 174);
			this.panel1.TabIndex = 12;
			// 
			// RouteForm
			// 
			this.AcceptButton = this.btnNew;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 262);
			this.Controls.Add(this.cbxGmOnly);
			this.Controls.Add(this.nud2Y);
			this.Controls.Add(this.nud2X);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nud1Y);
			this.Controls.Add(this.nud1X);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "RouteForm";
			this.Text = "RouteForm";
			this.Load += new System.EventHandler(this.RouteForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nud1Y)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud1X)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud2Y)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud2X)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ListBox lbxRoutes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nud1Y;
		private System.Windows.Forms.NumericUpDown nud1X;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nud2Y;
		private System.Windows.Forms.NumericUpDown nud2X;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox cbxGmOnly;
		private System.Windows.Forms.Panel panel1;
	}
}