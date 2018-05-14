namespace WindowsFrontEnd
{
	partial class PlanetForm
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
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.lbxPlanets = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtBiosphere = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.cbxLocation = new System.Windows.Forms.ComboBox();
			this.txtTags = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTechLevel = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPopulation = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTemperature = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAtmosphere = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtCapitalAndGovernment = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtCulturalNotes = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtFriends = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txtEnemies = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtComplications = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.txtPlaces = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.txtThings = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txtPartyActivities = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.panel10 = new System.Windows.Forms.Panel();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.panel11.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel10.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSave.Location = new System.Drawing.Point(3, 446);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(141, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.TabStop = false;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnDelete.Location = new System.Drawing.Point(3, 492);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(141, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.TabStop = false;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnNew
			// 
			this.btnNew.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnNew.Location = new System.Drawing.Point(3, 469);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(141, 23);
			this.btnNew.TabIndex = 3;
			this.btnNew.TabStop = false;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// lbxPlanets
			// 
			this.lbxPlanets.DisplayMember = "name";
			this.lbxPlanets.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbxPlanets.HorizontalScrollbar = true;
			this.lbxPlanets.Location = new System.Drawing.Point(0, 0);
			this.lbxPlanets.Name = "lbxPlanets";
			this.lbxPlanets.Size = new System.Drawing.Size(141, 430);
			this.lbxPlanets.TabIndex = 4;
			this.lbxPlanets.TabStop = false;
			this.lbxPlanets.ValueMember = "name";
			this.lbxPlanets.SelectedIndexChanged += new System.EventHandler(this.lbxPlanets_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel11);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.btnNew);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(147, 518);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Planets:";
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.lbxPlanets);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel11.Location = new System.Drawing.Point(3, 16);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(141, 430);
			this.panel11.TabIndex = 10;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Controls.Add(this.panel5);
			this.flowLayoutPanel1.Controls.Add(this.panel6);
			this.flowLayoutPanel1.Controls.Add(this.panel7);
			this.flowLayoutPanel1.Controls.Add(this.panel8);
			this.flowLayoutPanel1.Controls.Add(this.panel9);
			this.flowLayoutPanel1.Controls.Add(this.panel10);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(147, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(654, 518);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.txtBiosphere);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.cbxLocation);
			this.panel1.Controls.Add(this.txtTags);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtTechLevel);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtPopulation);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtTemperature);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtAtmosphere);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.SetFlowBreak(this.panel1, true);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.MinimumSize = new System.Drawing.Size(100, 100);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(421, 148);
			this.panel1.TabIndex = 0;
			// 
			// txtBiosphere
			// 
			this.txtBiosphere.Location = new System.Drawing.Point(75, 83);
			this.txtBiosphere.Name = "txtBiosphere";
			this.txtBiosphere.Size = new System.Drawing.Size(135, 20);
			this.txtBiosphere.TabIndex = 6;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(3, 86);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(57, 13);
			this.label17.TabIndex = 14;
			this.label17.Text = "Biosphere:";
			// 
			// cbxLocation
			// 
			this.cbxLocation.DisplayMember = "displayName";
			this.cbxLocation.Location = new System.Drawing.Point(245, 6);
			this.cbxLocation.Name = "cbxLocation";
			this.cbxLocation.Size = new System.Drawing.Size(173, 21);
			this.cbxLocation.TabIndex = 13;
			this.cbxLocation.ValueMember = "displayName";
			// 
			// txtTags
			// 
			this.txtTags.AcceptsReturn = true;
			this.txtTags.Location = new System.Drawing.Point(219, 100);
			this.txtTags.Multiline = true;
			this.txtTags.Name = "txtTags";
			this.txtTags.Size = new System.Drawing.Size(135, 45);
			this.txtTags.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(216, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Tags:";
			// 
			// txtTechLevel
			// 
			this.txtTechLevel.Location = new System.Drawing.Point(283, 58);
			this.txtTechLevel.Name = "txtTechLevel";
			this.txtTechLevel.Size = new System.Drawing.Size(135, 20);
			this.txtTechLevel.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(216, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Tech Level:";
			// 
			// txtPopulation
			// 
			this.txtPopulation.Location = new System.Drawing.Point(75, 58);
			this.txtPopulation.Name = "txtPopulation";
			this.txtPopulation.Size = new System.Drawing.Size(135, 20);
			this.txtPopulation.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Population:";
			// 
			// txtTemperature
			// 
			this.txtTemperature.Location = new System.Drawing.Point(283, 32);
			this.txtTemperature.Name = "txtTemperature";
			this.txtTemperature.Size = new System.Drawing.Size(135, 20);
			this.txtTemperature.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(216, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Temperature:";
			// 
			// txtAtmosphere
			// 
			this.txtAtmosphere.Location = new System.Drawing.Point(75, 32);
			this.txtAtmosphere.Name = "txtAtmosphere";
			this.txtAtmosphere.Size = new System.Drawing.Size(135, 20);
			this.txtAtmosphere.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Atmosphere:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(188, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Location:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(47, 6);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(135, 20);
			this.txtName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.txtCapitalAndGovernment);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Location = new System.Drawing.Point(3, 157);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(306, 269);
			this.panel2.TabIndex = 1;
			// 
			// txtCapitalAndGovernment
			// 
			this.txtCapitalAndGovernment.AcceptsReturn = true;
			this.txtCapitalAndGovernment.AcceptsTab = true;
			this.txtCapitalAndGovernment.AllowDrop = true;
			this.txtCapitalAndGovernment.Location = new System.Drawing.Point(3, 16);
			this.txtCapitalAndGovernment.Multiline = true;
			this.txtCapitalAndGovernment.Name = "txtCapitalAndGovernment";
			this.txtCapitalAndGovernment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCapitalAndGovernment.Size = new System.Drawing.Size(300, 250);
			this.txtCapitalAndGovernment.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Top;
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Capital And Government:";
			// 
			// panel3
			// 
			this.panel3.AutoScroll = true;
			this.panel3.AutoSize = true;
			this.panel3.Controls.Add(this.txtCulturalNotes);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Location = new System.Drawing.Point(315, 157);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(306, 269);
			this.panel3.TabIndex = 2;
			// 
			// txtCulturalNotes
			// 
			this.txtCulturalNotes.AcceptsReturn = true;
			this.txtCulturalNotes.AcceptsTab = true;
			this.txtCulturalNotes.AllowDrop = true;
			this.txtCulturalNotes.Location = new System.Drawing.Point(3, 16);
			this.txtCulturalNotes.Multiline = true;
			this.txtCulturalNotes.Name = "txtCulturalNotes";
			this.txtCulturalNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCulturalNotes.Size = new System.Drawing.Size(300, 250);
			this.txtCulturalNotes.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Top;
			this.label9.Location = new System.Drawing.Point(0, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Cultural Notes:";
			// 
			// panel4
			// 
			this.panel4.AutoScroll = true;
			this.panel4.AutoSize = true;
			this.panel4.Controls.Add(this.txtFriends);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Location = new System.Drawing.Point(3, 432);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(306, 269);
			this.panel4.TabIndex = 3;
			// 
			// txtFriends
			// 
			this.txtFriends.AcceptsReturn = true;
			this.txtFriends.AcceptsTab = true;
			this.txtFriends.AllowDrop = true;
			this.txtFriends.Location = new System.Drawing.Point(3, 16);
			this.txtFriends.Multiline = true;
			this.txtFriends.Name = "txtFriends";
			this.txtFriends.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtFriends.Size = new System.Drawing.Size(300, 250);
			this.txtFriends.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = System.Windows.Forms.DockStyle.Top;
			this.label10.Location = new System.Drawing.Point(0, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "Friends:";
			// 
			// panel5
			// 
			this.panel5.AutoScroll = true;
			this.panel5.AutoSize = true;
			this.panel5.Controls.Add(this.txtEnemies);
			this.panel5.Controls.Add(this.label11);
			this.panel5.Location = new System.Drawing.Point(315, 432);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(306, 269);
			this.panel5.TabIndex = 4;
			// 
			// txtEnemies
			// 
			this.txtEnemies.AcceptsReturn = true;
			this.txtEnemies.AcceptsTab = true;
			this.txtEnemies.AllowDrop = true;
			this.txtEnemies.Location = new System.Drawing.Point(3, 16);
			this.txtEnemies.Multiline = true;
			this.txtEnemies.Name = "txtEnemies";
			this.txtEnemies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtEnemies.Size = new System.Drawing.Size(300, 250);
			this.txtEnemies.TabIndex = 1;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Dock = System.Windows.Forms.DockStyle.Top;
			this.label11.Location = new System.Drawing.Point(0, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(50, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Enemies:";
			// 
			// panel6
			// 
			this.panel6.AutoScroll = true;
			this.panel6.AutoSize = true;
			this.panel6.Controls.Add(this.txtComplications);
			this.panel6.Controls.Add(this.label12);
			this.panel6.Location = new System.Drawing.Point(3, 707);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(306, 269);
			this.panel6.TabIndex = 5;
			// 
			// txtComplications
			// 
			this.txtComplications.AcceptsReturn = true;
			this.txtComplications.AcceptsTab = true;
			this.txtComplications.AllowDrop = true;
			this.txtComplications.Location = new System.Drawing.Point(3, 16);
			this.txtComplications.Multiline = true;
			this.txtComplications.Name = "txtComplications";
			this.txtComplications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtComplications.Size = new System.Drawing.Size(300, 250);
			this.txtComplications.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Dock = System.Windows.Forms.DockStyle.Top;
			this.label12.Location = new System.Drawing.Point(0, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(75, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "Complications:";
			// 
			// panel7
			// 
			this.panel7.AutoScroll = true;
			this.panel7.AutoSize = true;
			this.panel7.Controls.Add(this.txtPlaces);
			this.panel7.Controls.Add(this.label13);
			this.panel7.Location = new System.Drawing.Point(315, 707);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(306, 269);
			this.panel7.TabIndex = 6;
			// 
			// txtPlaces
			// 
			this.txtPlaces.AcceptsReturn = true;
			this.txtPlaces.AcceptsTab = true;
			this.txtPlaces.AllowDrop = true;
			this.txtPlaces.Location = new System.Drawing.Point(3, 16);
			this.txtPlaces.Multiline = true;
			this.txtPlaces.Name = "txtPlaces";
			this.txtPlaces.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtPlaces.Size = new System.Drawing.Size(300, 250);
			this.txtPlaces.TabIndex = 1;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Dock = System.Windows.Forms.DockStyle.Top;
			this.label13.Location = new System.Drawing.Point(0, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(42, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Places:";
			// 
			// panel8
			// 
			this.panel8.AutoScroll = true;
			this.panel8.AutoSize = true;
			this.panel8.Controls.Add(this.txtThings);
			this.panel8.Controls.Add(this.label14);
			this.panel8.Location = new System.Drawing.Point(3, 982);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(306, 269);
			this.panel8.TabIndex = 7;
			// 
			// txtThings
			// 
			this.txtThings.AcceptsReturn = true;
			this.txtThings.AcceptsTab = true;
			this.txtThings.AllowDrop = true;
			this.txtThings.Location = new System.Drawing.Point(3, 16);
			this.txtThings.Multiline = true;
			this.txtThings.Name = "txtThings";
			this.txtThings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtThings.Size = new System.Drawing.Size(300, 250);
			this.txtThings.TabIndex = 1;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Dock = System.Windows.Forms.DockStyle.Top;
			this.label14.Location = new System.Drawing.Point(0, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(42, 13);
			this.label14.TabIndex = 0;
			this.label14.Text = "Things:";
			// 
			// panel9
			// 
			this.panel9.AutoScroll = true;
			this.panel9.AutoSize = true;
			this.panel9.Controls.Add(this.txtPartyActivities);
			this.panel9.Controls.Add(this.label15);
			this.panel9.Location = new System.Drawing.Point(315, 982);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(306, 269);
			this.panel9.TabIndex = 8;
			// 
			// txtPartyActivities
			// 
			this.txtPartyActivities.AcceptsReturn = true;
			this.txtPartyActivities.AcceptsTab = true;
			this.txtPartyActivities.AllowDrop = true;
			this.txtPartyActivities.Location = new System.Drawing.Point(3, 16);
			this.txtPartyActivities.Multiline = true;
			this.txtPartyActivities.Name = "txtPartyActivities";
			this.txtPartyActivities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtPartyActivities.Size = new System.Drawing.Size(300, 250);
			this.txtPartyActivities.TabIndex = 1;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Dock = System.Windows.Forms.DockStyle.Top;
			this.label15.Location = new System.Drawing.Point(0, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(79, 13);
			this.label15.TabIndex = 0;
			this.label15.Text = "Party Activities:";
			// 
			// panel10
			// 
			this.panel10.AutoScroll = true;
			this.panel10.AutoSize = true;
			this.panel10.Controls.Add(this.txtNotes);
			this.panel10.Controls.Add(this.label16);
			this.panel10.Location = new System.Drawing.Point(3, 1257);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(306, 269);
			this.panel10.TabIndex = 9;
			// 
			// txtNotes
			// 
			this.txtNotes.AcceptsReturn = true;
			this.txtNotes.AcceptsTab = true;
			this.txtNotes.AllowDrop = true;
			this.txtNotes.Location = new System.Drawing.Point(3, 16);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotes.Size = new System.Drawing.Size(300, 250);
			this.txtNotes.TabIndex = 1;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Dock = System.Windows.Forms.DockStyle.Top;
			this.label16.Location = new System.Drawing.Point(0, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(38, 13);
			this.label16.TabIndex = 0;
			this.label16.Text = "Notes:";
			// 
			// PlanetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 518);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.groupBox1);
			this.Name = "PlanetForm";
			this.Text = "PlanetForm";
			this.Load += new System.EventHandler(this.PlanetForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.ListBox lbxPlanets;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtTemperature;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAtmosphere;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTags;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtTechLevel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPopulation;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtCapitalAndGovernment;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtCulturalNotes;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtFriends;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox txtEnemies;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox txtComplications;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TextBox txtPlaces;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox txtThings;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.TextBox txtPartyActivities;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cbxLocation;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.TextBox txtBiosphere;
		private System.Windows.Forms.Label label17;
	}
}