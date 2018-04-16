namespace WindowsFrontEnd
{
	partial class StarForm
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
			this.lbxStars = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.nudX = new System.Windows.Forms.NumericUpDown();
			this.nudY = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.btnNew);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.lbxStars);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(137, 275);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stars";
			// 
			// btnSave
			// 
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSave.Location = new System.Drawing.Point(3, 203);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(131, 23);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnNew
			// 
			this.btnNew.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnNew.Location = new System.Drawing.Point(3, 226);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(131, 23);
			this.btnNew.TabIndex = 2;
			this.btnNew.TabStop = false;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnDelete.Location = new System.Drawing.Point(3, 249);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(131, 23);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.TabStop = false;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lbxStars
			// 
			this.lbxStars.DisplayMember = "name";
			this.lbxStars.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbxStars.FormattingEnabled = true;
			this.lbxStars.Location = new System.Drawing.Point(3, 16);
			this.lbxStars.Name = "lbxStars";
			this.lbxStars.Size = new System.Drawing.Size(131, 256);
			this.lbxStars.TabIndex = 0;
			this.lbxStars.TabStop = false;
			this.lbxStars.ValueMember = "name";
			this.lbxStars.SelectedIndexChanged += new System.EventHandler(this.lbxStars_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(143, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(143, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Location X:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(143, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Location Y:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(210, 6);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(164, 20);
			this.txtName.TabIndex = 1;
			// 
			// nudX
			// 
			this.nudX.Location = new System.Drawing.Point(210, 45);
			this.nudX.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.nudX.Name = "nudX";
			this.nudX.Size = new System.Drawing.Size(48, 20);
			this.nudX.TabIndex = 2;
			// 
			// nudY
			// 
			this.nudY.Location = new System.Drawing.Point(210, 83);
			this.nudY.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.nudY.Name = "nudY";
			this.nudY.Size = new System.Drawing.Size(48, 20);
			this.nudY.TabIndex = 3;
			// 
			// StarForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 275);
			this.Controls.Add(this.nudY);
			this.Controls.Add(this.nudX);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Name = "StarForm";
			this.Text = "Stars";
			this.Load += new System.EventHandler(this.Stars_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox lbxStars;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.NumericUpDown nudX;
		private System.Windows.Forms.NumericUpDown nudY;
	}
}