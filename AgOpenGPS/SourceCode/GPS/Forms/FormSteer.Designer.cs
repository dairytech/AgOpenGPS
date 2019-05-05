﻿namespace AgOpenGPS {
  partial class FormSteer {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing ) {
      if( disposing && ( components != null ) ) {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( FormSteer ) );
      this.tboxSerialFromAutoSteer = new System.Windows.Forms.TextBox();
      this.tboxSerialToAutoSteer = new System.Windows.Forms.TextBox();
      this.timer1 = new System.Windows.Forms.Timer( this.components );
      this.btnSteerWizard = new System.Windows.Forms.Button();
      this.btnFreeDriveZero = new System.Windows.Forms.Button();
      this.btnFreeDrive = new System.Windows.Forms.Button();
      this.label20 = new System.Windows.Forms.Label();
      this.label21 = new System.Windows.Forms.Label();
      this.lblFreeDriveAngle = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabLook = new System.Windows.Forms.TabPage();
      this.btnChart = new System.Windows.Forms.Button();
      this.hsbarLookAheadMin = new System.Windows.Forms.HScrollBar();
      this.hsbarDistanceFromLine = new System.Windows.Forms.HScrollBar();
      this.lblLookAhead = new System.Windows.Forms.Label();
      this.hsbarLookAhead = new System.Windows.Forms.HScrollBar();
      this.label37 = new System.Windows.Forms.Label();
      this.lblLookAheadMinimum = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.lblDistanceFromLine = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tabGain = new System.Windows.Forms.TabPage();
      this.hsbarIntegralMax = new System.Windows.Forms.HScrollBar();
      this.hsbarIntegralGain = new System.Windows.Forms.HScrollBar();
      this.hsbarSidehillDraftGain = new System.Windows.Forms.HScrollBar();
      this.hsbarOutputGain = new System.Windows.Forms.HScrollBar();
      this.hsbarProportionalGain = new System.Windows.Forms.HScrollBar();
      this.lblIntegralMax = new System.Windows.Forms.Label();
      this.label45 = new System.Windows.Forms.Label();
      this.lblIntegralGain = new System.Windows.Forms.Label();
      this.label33 = new System.Windows.Forms.Label();
      this.lblSidehillDraftGain = new System.Windows.Forms.Label();
      this.label29 = new System.Windows.Forms.Label();
      this.lblOutputGain = new System.Windows.Forms.Label();
      this.label22 = new System.Windows.Forms.Label();
      this.lblProportionalGain = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.tabSteer = new System.Windows.Forms.TabPage();
      this.hsbarMinPWM = new System.Windows.Forms.HScrollBar();
      this.lblCountsPerDegree = new System.Windows.Forms.Label();
      this.label25 = new System.Windows.Forms.Label();
      this.hsbarCountsPerDegree = new System.Windows.Forms.HScrollBar();
      this.lblMaxSteerAngle = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.lblMinPWM = new System.Windows.Forms.Label();
      this.label41 = new System.Windows.Forms.Label();
      this.hsbarMaxSteerAngle = new System.Windows.Forms.HScrollBar();
      this.lblSteerAngleSensorZero = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.hsbarSteerAngleSensorZero = new System.Windows.Forms.HScrollBar();
      this.lblMaxAngularVelocity = new System.Windows.Forms.Label();
      this.hsbarMaxAngularVelocity = new System.Windows.Forms.HScrollBar();
      this.label30 = new System.Windows.Forms.Label();
      this.tabDrive = new System.Windows.Forms.TabPage();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.hSBarFreeDrive = new System.Windows.Forms.HScrollBar();
      this.btnExit = new System.Windows.Forms.Button();
      this.hsbarLookAheadUturnMult = new System.Windows.Forms.HScrollBar();
      this.lblLookAheadUturnMult = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabLook.SuspendLayout();
      this.tabGain.SuspendLayout();
      this.tabSteer.SuspendLayout();
      this.tabDrive.SuspendLayout();
      this.SuspendLayout();
      // 
      // tboxSerialFromAutoSteer
      // 
      this.tboxSerialFromAutoSteer.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
      this.tboxSerialFromAutoSteer.BackColor = System.Drawing.SystemColors.Control;
      this.tboxSerialFromAutoSteer.Enabled = false;
      this.tboxSerialFromAutoSteer.Font = new System.Drawing.Font( "Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.tboxSerialFromAutoSteer.Location = new System.Drawing.Point( 173, 455 );
      this.tboxSerialFromAutoSteer.Margin = new System.Windows.Forms.Padding( 4, 6, 4, 6 );
      this.tboxSerialFromAutoSteer.Name = "tboxSerialFromAutoSteer";
      this.tboxSerialFromAutoSteer.ReadOnly = true;
      this.tboxSerialFromAutoSteer.Size = new System.Drawing.Size( 167, 22 );
      this.tboxSerialFromAutoSteer.TabIndex = 125;
      // 
      // tboxSerialToAutoSteer
      // 
      this.tboxSerialToAutoSteer.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
      this.tboxSerialToAutoSteer.BackColor = System.Drawing.SystemColors.Control;
      this.tboxSerialToAutoSteer.Enabled = false;
      this.tboxSerialToAutoSteer.Font = new System.Drawing.Font( "Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.tboxSerialToAutoSteer.Location = new System.Drawing.Point( 3, 455 );
      this.tboxSerialToAutoSteer.Margin = new System.Windows.Forms.Padding( 4, 6, 4, 6 );
      this.tboxSerialToAutoSteer.Name = "tboxSerialToAutoSteer";
      this.tboxSerialToAutoSteer.ReadOnly = true;
      this.tboxSerialToAutoSteer.Size = new System.Drawing.Size( 167, 22 );
      this.tboxSerialToAutoSteer.TabIndex = 123;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 500;
      this.timer1.Tick += new System.EventHandler( this.timer1_Tick );
      // 
      // btnSteerWizard
      // 
      this.btnSteerWizard.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.btnSteerWizard.Location = new System.Drawing.Point( 340, 24 );
      this.btnSteerWizard.Name = "btnSteerWizard";
      this.btnSteerWizard.Size = new System.Drawing.Size( 80, 60 );
      this.btnSteerWizard.TabIndex = 220;
      this.btnSteerWizard.Text = "Steer Wizard";
      this.btnSteerWizard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.btnSteerWizard.UseVisualStyleBackColor = true;
      this.btnSteerWizard.Click += new System.EventHandler( this.btnSteerWizard_Click );
      // 
      // btnFreeDriveZero
      // 
      this.btnFreeDriveZero.Font = new System.Drawing.Font( "Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.btnFreeDriveZero.Location = new System.Drawing.Point( 170, 24 );
      this.btnFreeDriveZero.Name = "btnFreeDriveZero";
      this.btnFreeDriveZero.Size = new System.Drawing.Size( 89, 65 );
      this.btnFreeDriveZero.TabIndex = 226;
      this.btnFreeDriveZero.Text = "> 0 <";
      this.btnFreeDriveZero.UseVisualStyleBackColor = true;
      this.btnFreeDriveZero.Click += new System.EventHandler( this.btnFreeDriveZero_Click );
      // 
      // btnFreeDrive
      // 
      this.btnFreeDrive.Font = new System.Drawing.Font( "Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.btnFreeDrive.Location = new System.Drawing.Point( 7, 24 );
      this.btnFreeDrive.Name = "btnFreeDrive";
      this.btnFreeDrive.Size = new System.Drawing.Size( 95, 65 );
      this.btnFreeDrive.TabIndex = 228;
      this.btnFreeDrive.Text = "Drive";
      this.btnFreeDrive.UseVisualStyleBackColor = true;
      this.btnFreeDrive.Click += new System.EventHandler( this.btnFreeDrive_Click );
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label20.Location = new System.Drawing.Point( 377, 183 );
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size( 27, 19 );
      this.label20.TabIndex = 229;
      this.label20.Text = "40";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label21.Location = new System.Drawing.Point( 29, 183 );
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size( 33, 19 );
      this.label21.TabIndex = 230;
      this.label21.Text = "-40";
      // 
      // lblFreeDriveAngle
      // 
      this.lblFreeDriveAngle.AutoSize = true;
      this.lblFreeDriveAngle.Font = new System.Drawing.Font( "Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblFreeDriveAngle.Location = new System.Drawing.Point( 204, 100 );
      this.lblFreeDriveAngle.Name = "lblFreeDriveAngle";
      this.lblFreeDriveAngle.Size = new System.Drawing.Size( 22, 23 );
      this.lblFreeDriveAngle.TabIndex = 231;
      this.lblFreeDriveAngle.Text = "0";
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
      | System.Windows.Forms.AnchorStyles.Left )
      | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
      this.tabControl1.Controls.Add( this.tabLook );
      this.tabControl1.Controls.Add( this.tabGain );
      this.tabControl1.Controls.Add( this.tabSteer );
      this.tabControl1.Controls.Add( this.tabDrive );
      this.tabControl1.Font = new System.Drawing.Font( "Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.tabControl1.ItemSize = new System.Drawing.Size( 105, 32 );
      this.tabControl1.Location = new System.Drawing.Point( 3, 7 );
      this.tabControl1.Margin = new System.Windows.Forms.Padding( 4 );
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size( 434, 438 );
      this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
      this.tabControl1.TabIndex = 232;
      // 
      // tabLook
      // 
      this.tabLook.BackColor = System.Drawing.Color.PowderBlue;
      this.tabLook.Controls.Add( this.hsbarLookAheadUturnMult );
      this.tabLook.Controls.Add( this.lblLookAheadUturnMult );
      this.tabLook.Controls.Add( this.label2 );
      this.tabLook.Controls.Add( this.btnChart );
      this.tabLook.Controls.Add( this.hsbarLookAheadMin );
      this.tabLook.Controls.Add( this.hsbarDistanceFromLine );
      this.tabLook.Controls.Add( this.lblLookAhead );
      this.tabLook.Controls.Add( this.hsbarLookAhead );
      this.tabLook.Controls.Add( this.label37 );
      this.tabLook.Controls.Add( this.lblLookAheadMinimum );
      this.tabLook.Controls.Add( this.label4 );
      this.tabLook.Controls.Add( this.lblDistanceFromLine );
      this.tabLook.Controls.Add( this.label6 );
      this.tabLook.Location = new System.Drawing.Point( 4, 36 );
      this.tabLook.Name = "tabLook";
      this.tabLook.Size = new System.Drawing.Size( 426, 398 );
      this.tabLook.TabIndex = 14;
      this.tabLook.Text = "Look";
      // 
      // btnChart
      // 
      this.btnChart.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.btnChart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnChart.Font = new System.Drawing.Font( "Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.btnChart.ForeColor = System.Drawing.Color.Black;
      this.btnChart.Location = new System.Drawing.Point( 10, 357 );
      this.btnChart.Name = "btnChart";
      this.btnChart.Size = new System.Drawing.Size( 97, 34 );
      this.btnChart.TabIndex = 234;
      this.btnChart.Text = "Chart";
      this.btnChart.UseVisualStyleBackColor = true;
      this.btnChart.Click += new System.EventHandler( this.btnChart_Click );
      // 
      // hsbarLookAheadMin
      // 
      this.hsbarLookAheadMin.LargeChange = 1;
      this.hsbarLookAheadMin.Location = new System.Drawing.Point( 17, 209 );
      this.hsbarLookAheadMin.Maximum = 50;
      this.hsbarLookAheadMin.Minimum = 2;
      this.hsbarLookAheadMin.Name = "hsbarLookAheadMin";
      this.hsbarLookAheadMin.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarLookAheadMin.TabIndex = 272;
      this.hsbarLookAheadMin.Value = 10;
      this.hsbarLookAheadMin.ValueChanged += new System.EventHandler( this.hsbarLookAheadMin_ValueChanged );
      // 
      // hsbarDistanceFromLine
      // 
      this.hsbarDistanceFromLine.LargeChange = 1;
      this.hsbarDistanceFromLine.Location = new System.Drawing.Point( 17, 124 );
      this.hsbarDistanceFromLine.Maximum = 30;
      this.hsbarDistanceFromLine.Name = "hsbarDistanceFromLine";
      this.hsbarDistanceFromLine.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarDistanceFromLine.TabIndex = 269;
      this.hsbarDistanceFromLine.Value = 10;
      this.hsbarDistanceFromLine.ValueChanged += new System.EventHandler( this.hsbarDistanceFromLine_ValueChanged );
      // 
      // lblLookAhead
      // 
      this.lblLookAhead.AutoSize = true;
      this.lblLookAhead.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblLookAhead.Location = new System.Drawing.Point( 310, 30 );
      this.lblLookAhead.Name = "lblLookAhead";
      this.lblLookAhead.Size = new System.Drawing.Size( 108, 45 );
      this.lblLookAhead.TabIndex = 293;
      this.lblLookAhead.Text = "-888";
      // 
      // hsbarLookAhead
      // 
      this.hsbarLookAhead.LargeChange = 1;
      this.hsbarLookAhead.Location = new System.Drawing.Point( 17, 45 );
      this.hsbarLookAhead.Maximum = 60;
      this.hsbarLookAhead.Minimum = 5;
      this.hsbarLookAhead.Name = "hsbarLookAhead";
      this.hsbarLookAhead.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarLookAhead.TabIndex = 289;
      this.hsbarLookAhead.Value = 25;
      this.hsbarLookAhead.ValueChanged += new System.EventHandler( this.hsbarLookAhead_ValueChanged );
      // 
      // label37
      // 
      this.label37.AutoSize = true;
      this.label37.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label37.Location = new System.Drawing.Point( 30, 19 );
      this.label37.Name = "label37";
      this.label37.Size = new System.Drawing.Size( 197, 23 );
      this.label37.TabIndex = 290;
      this.label37.Text = "Look Ahead (Seconds)";
      // 
      // lblLookAheadMinimum
      // 
      this.lblLookAheadMinimum.AutoSize = true;
      this.lblLookAheadMinimum.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblLookAheadMinimum.Location = new System.Drawing.Point( 310, 196 );
      this.lblLookAheadMinimum.Name = "lblLookAheadMinimum";
      this.lblLookAheadMinimum.Size = new System.Drawing.Size( 108, 45 );
      this.lblLookAheadMinimum.TabIndex = 274;
      this.lblLookAheadMinimum.Text = "-888";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label4.Location = new System.Drawing.Point( 30, 98 );
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size( 249, 23 );
      this.label4.TabIndex = 273;
      this.label4.Text = "Look Ahead Offline Multiplier";
      // 
      // lblDistanceFromLine
      // 
      this.lblDistanceFromLine.AutoSize = true;
      this.lblDistanceFromLine.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblDistanceFromLine.Location = new System.Drawing.Point( 310, 112 );
      this.lblDistanceFromLine.Name = "lblDistanceFromLine";
      this.lblDistanceFromLine.Size = new System.Drawing.Size( 108, 45 );
      this.lblDistanceFromLine.TabIndex = 271;
      this.lblDistanceFromLine.Text = "-888";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label6.Location = new System.Drawing.Point( 30, 182 );
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size( 219, 23 );
      this.label6.TabIndex = 270;
      this.label6.Text = "Min Look Ahead (Meters)";
      // 
      // tabGain
      // 
      this.tabGain.AutoScroll = true;
      this.tabGain.BackColor = System.Drawing.Color.PowderBlue;
      this.tabGain.Controls.Add( this.hsbarIntegralMax );
      this.tabGain.Controls.Add( this.hsbarIntegralGain );
      this.tabGain.Controls.Add( this.hsbarSidehillDraftGain );
      this.tabGain.Controls.Add( this.hsbarOutputGain );
      this.tabGain.Controls.Add( this.hsbarProportionalGain );
      this.tabGain.Controls.Add( this.lblIntegralMax );
      this.tabGain.Controls.Add( this.label45 );
      this.tabGain.Controls.Add( this.lblIntegralGain );
      this.tabGain.Controls.Add( this.label33 );
      this.tabGain.Controls.Add( this.lblSidehillDraftGain );
      this.tabGain.Controls.Add( this.label29 );
      this.tabGain.Controls.Add( this.lblOutputGain );
      this.tabGain.Controls.Add( this.label22 );
      this.tabGain.Controls.Add( this.lblProportionalGain );
      this.tabGain.Controls.Add( this.label7 );
      this.tabGain.Location = new System.Drawing.Point( 4, 36 );
      this.tabGain.Name = "tabGain";
      this.tabGain.Size = new System.Drawing.Size( 426, 398 );
      this.tabGain.TabIndex = 13;
      this.tabGain.Text = "PID";
      // 
      // hsbarIntegralMax
      // 
      this.hsbarIntegralMax.Enabled = false;
      this.hsbarIntegralMax.LargeChange = 2;
      this.hsbarIntegralMax.Location = new System.Drawing.Point( 16, 351 );
      this.hsbarIntegralMax.Maximum = 50;
      this.hsbarIntegralMax.Name = "hsbarIntegralMax";
      this.hsbarIntegralMax.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarIntegralMax.TabIndex = 274;
      this.hsbarIntegralMax.Value = 50;
      this.hsbarIntegralMax.ValueChanged += new System.EventHandler( this.hsbarIntegralMax_ValueChanged );
      // 
      // hsbarIntegralGain
      // 
      this.hsbarIntegralGain.Enabled = false;
      this.hsbarIntegralGain.LargeChange = 1;
      this.hsbarIntegralGain.Location = new System.Drawing.Point( 16, 274 );
      this.hsbarIntegralGain.Maximum = 255;
      this.hsbarIntegralGain.Name = "hsbarIntegralGain";
      this.hsbarIntegralGain.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarIntegralGain.TabIndex = 269;
      this.hsbarIntegralGain.Value = 127;
      this.hsbarIntegralGain.ValueChanged += new System.EventHandler( this.hsbarIntegralGain_ValueChanged );
      // 
      // hsbarSidehillDraftGain
      // 
      this.hsbarSidehillDraftGain.LargeChange = 1;
      this.hsbarSidehillDraftGain.Location = new System.Drawing.Point( 17, 197 );
      this.hsbarSidehillDraftGain.Maximum = 24;
      this.hsbarSidehillDraftGain.Name = "hsbarSidehillDraftGain";
      this.hsbarSidehillDraftGain.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarSidehillDraftGain.TabIndex = 264;
      this.hsbarSidehillDraftGain.Value = 24;
      this.hsbarSidehillDraftGain.ValueChanged += new System.EventHandler( this.hsbarSidehillDraftGain_ValueChanged );
      // 
      // hsbarOutputGain
      // 
      this.hsbarOutputGain.LargeChange = 1;
      this.hsbarOutputGain.Location = new System.Drawing.Point( 18, 120 );
      this.hsbarOutputGain.Maximum = 255;
      this.hsbarOutputGain.Name = "hsbarOutputGain";
      this.hsbarOutputGain.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarOutputGain.TabIndex = 259;
      this.hsbarOutputGain.Value = 127;
      this.hsbarOutputGain.ValueChanged += new System.EventHandler( this.hsbarOutputGain_ValueChanged );
      // 
      // hsbarProportionalGain
      // 
      this.hsbarProportionalGain.LargeChange = 1;
      this.hsbarProportionalGain.Location = new System.Drawing.Point( 16, 43 );
      this.hsbarProportionalGain.Maximum = 255;
      this.hsbarProportionalGain.Name = "hsbarProportionalGain";
      this.hsbarProportionalGain.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarProportionalGain.TabIndex = 254;
      this.hsbarProportionalGain.Value = 127;
      this.hsbarProportionalGain.ValueChanged += new System.EventHandler( this.hsbarProportionalGain_ValueChanged );
      // 
      // lblIntegralMax
      // 
      this.lblIntegralMax.AutoSize = true;
      this.lblIntegralMax.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblIntegralMax.Location = new System.Drawing.Point( 310, 338 );
      this.lblIntegralMax.Name = "lblIntegralMax";
      this.lblIntegralMax.Size = new System.Drawing.Size( 108, 45 );
      this.lblIntegralMax.TabIndex = 278;
      this.lblIntegralMax.Text = "-888";
      // 
      // label45
      // 
      this.label45.AutoSize = true;
      this.label45.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label45.Location = new System.Drawing.Point( 29, 325 );
      this.label45.Name = "label45";
      this.label45.Size = new System.Drawing.Size( 168, 23 );
      this.label45.TabIndex = 275;
      this.label45.Text = "Max Integral Value";
      // 
      // lblIntegralGain
      // 
      this.lblIntegralGain.AutoSize = true;
      this.lblIntegralGain.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblIntegralGain.Location = new System.Drawing.Point( 310, 261 );
      this.lblIntegralGain.Name = "lblIntegralGain";
      this.lblIntegralGain.Size = new System.Drawing.Size( 108, 45 );
      this.lblIntegralGain.TabIndex = 273;
      this.lblIntegralGain.Text = "-888";
      // 
      // label33
      // 
      this.label33.AutoSize = true;
      this.label33.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label33.Location = new System.Drawing.Point( 29, 248 );
      this.label33.Name = "label33";
      this.label33.Size = new System.Drawing.Size( 120, 23 );
      this.label33.TabIndex = 270;
      this.label33.Text = "Integral Gain";
      // 
      // lblSidehillDraftGain
      // 
      this.lblSidehillDraftGain.AutoSize = true;
      this.lblSidehillDraftGain.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblSidehillDraftGain.Location = new System.Drawing.Point( 310, 185 );
      this.lblSidehillDraftGain.Name = "lblSidehillDraftGain";
      this.lblSidehillDraftGain.Size = new System.Drawing.Size( 108, 45 );
      this.lblSidehillDraftGain.TabIndex = 268;
      this.lblSidehillDraftGain.Text = "-888";
      // 
      // label29
      // 
      this.label29.AutoSize = true;
      this.label29.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label29.Location = new System.Drawing.Point( 29, 171 );
      this.label29.Name = "label29";
      this.label29.Size = new System.Drawing.Size( 161, 23 );
      this.label29.TabIndex = 265;
      this.label29.Text = "Sidehill Draft Gain";
      // 
      // lblOutputGain
      // 
      this.lblOutputGain.AutoSize = true;
      this.lblOutputGain.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblOutputGain.Location = new System.Drawing.Point( 310, 107 );
      this.lblOutputGain.Name = "lblOutputGain";
      this.lblOutputGain.Size = new System.Drawing.Size( 108, 45 );
      this.lblOutputGain.TabIndex = 263;
      this.lblOutputGain.Text = "-888";
      // 
      // label22
      // 
      this.label22.AutoSize = true;
      this.label22.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label22.Location = new System.Drawing.Point( 29, 94 );
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size( 112, 23 );
      this.label22.TabIndex = 260;
      this.label22.Text = "Output Gain";
      // 
      // lblProportionalGain
      // 
      this.lblProportionalGain.AutoSize = true;
      this.lblProportionalGain.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblProportionalGain.Location = new System.Drawing.Point( 310, 30 );
      this.lblProportionalGain.Name = "lblProportionalGain";
      this.lblProportionalGain.Size = new System.Drawing.Size( 108, 45 );
      this.lblProportionalGain.TabIndex = 258;
      this.lblProportionalGain.Text = "-888";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label7.Location = new System.Drawing.Point( 29, 19 );
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size( 154, 23 );
      this.label7.TabIndex = 255;
      this.label7.Text = "Proportional Gain";
      // 
      // tabSteer
      // 
      this.tabSteer.AutoScroll = true;
      this.tabSteer.BackColor = System.Drawing.Color.PowderBlue;
      this.tabSteer.Controls.Add( this.hsbarMinPWM );
      this.tabSteer.Controls.Add( this.lblCountsPerDegree );
      this.tabSteer.Controls.Add( this.label25 );
      this.tabSteer.Controls.Add( this.hsbarCountsPerDegree );
      this.tabSteer.Controls.Add( this.lblMaxSteerAngle );
      this.tabSteer.Controls.Add( this.label19 );
      this.tabSteer.Controls.Add( this.lblMinPWM );
      this.tabSteer.Controls.Add( this.label41 );
      this.tabSteer.Controls.Add( this.hsbarMaxSteerAngle );
      this.tabSteer.Controls.Add( this.lblSteerAngleSensorZero );
      this.tabSteer.Controls.Add( this.label10 );
      this.tabSteer.Controls.Add( this.hsbarSteerAngleSensorZero );
      this.tabSteer.Controls.Add( this.lblMaxAngularVelocity );
      this.tabSteer.Controls.Add( this.hsbarMaxAngularVelocity );
      this.tabSteer.Controls.Add( this.label30 );
      this.tabSteer.Location = new System.Drawing.Point( 4, 36 );
      this.tabSteer.Name = "tabSteer";
      this.tabSteer.Size = new System.Drawing.Size( 426, 398 );
      this.tabSteer.TabIndex = 5;
      this.tabSteer.Text = "Steer";
      // 
      // hsbarMinPWM
      // 
      this.hsbarMinPWM.LargeChange = 1;
      this.hsbarMinPWM.Location = new System.Drawing.Point( 16, 352 );
      this.hsbarMinPWM.Minimum = 1;
      this.hsbarMinPWM.Name = "hsbarMinPWM";
      this.hsbarMinPWM.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarMinPWM.TabIndex = 284;
      this.hsbarMinPWM.Value = 100;
      this.hsbarMinPWM.ValueChanged += new System.EventHandler( this.hsbarMinPWM_ValueChanged );
      // 
      // lblCountsPerDegree
      // 
      this.lblCountsPerDegree.AutoSize = true;
      this.lblCountsPerDegree.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblCountsPerDegree.Location = new System.Drawing.Point( 310, 106 );
      this.lblCountsPerDegree.Name = "lblCountsPerDegree";
      this.lblCountsPerDegree.Size = new System.Drawing.Size( 108, 45 );
      this.lblCountsPerDegree.TabIndex = 308;
      this.lblCountsPerDegree.Text = "-888";
      // 
      // label25
      // 
      this.label25.AutoSize = true;
      this.label25.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label25.Location = new System.Drawing.Point( 29, 93 );
      this.label25.Name = "label25";
      this.label25.Size = new System.Drawing.Size( 168, 23 );
      this.label25.TabIndex = 305;
      this.label25.Text = "Counts per Degree";
      // 
      // hsbarCountsPerDegree
      // 
      this.hsbarCountsPerDegree.LargeChange = 1;
      this.hsbarCountsPerDegree.Location = new System.Drawing.Point( 16, 119 );
      this.hsbarCountsPerDegree.Maximum = 255;
      this.hsbarCountsPerDegree.Minimum = 1;
      this.hsbarCountsPerDegree.Name = "hsbarCountsPerDegree";
      this.hsbarCountsPerDegree.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarCountsPerDegree.TabIndex = 304;
      this.hsbarCountsPerDegree.Value = 255;
      this.hsbarCountsPerDegree.ValueChanged += new System.EventHandler( this.hsbarCountsPerDegree_ValueChanged );
      // 
      // lblMaxSteerAngle
      // 
      this.lblMaxSteerAngle.AutoSize = true;
      this.lblMaxSteerAngle.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblMaxSteerAngle.Location = new System.Drawing.Point( 310, 185 );
      this.lblMaxSteerAngle.Name = "lblMaxSteerAngle";
      this.lblMaxSteerAngle.Size = new System.Drawing.Size( 108, 45 );
      this.lblMaxSteerAngle.TabIndex = 303;
      this.lblMaxSteerAngle.Text = "-888";
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label19.Location = new System.Drawing.Point( 29, 172 );
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size( 243, 23 );
      this.label19.TabIndex = 300;
      this.label19.Text = "Max Steer Angle in Degrees";
      // 
      // lblMinPWM
      // 
      this.lblMinPWM.AutoSize = true;
      this.lblMinPWM.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblMinPWM.Location = new System.Drawing.Point( 310, 338 );
      this.lblMinPWM.Name = "lblMinPWM";
      this.lblMinPWM.Size = new System.Drawing.Size( 108, 45 );
      this.lblMinPWM.TabIndex = 288;
      this.lblMinPWM.Text = "-888";
      // 
      // label41
      // 
      this.label41.AutoSize = true;
      this.label41.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label41.Location = new System.Drawing.Point( 29, 326 );
      this.label41.Name = "label41";
      this.label41.Size = new System.Drawing.Size( 184, 23 );
      this.label41.TabIndex = 285;
      this.label41.Text = "Minimum PWM Drive";
      // 
      // hsbarMaxSteerAngle
      // 
      this.hsbarMaxSteerAngle.LargeChange = 1;
      this.hsbarMaxSteerAngle.Location = new System.Drawing.Point( 16, 199 );
      this.hsbarMaxSteerAngle.Maximum = 80;
      this.hsbarMaxSteerAngle.Minimum = 10;
      this.hsbarMaxSteerAngle.Name = "hsbarMaxSteerAngle";
      this.hsbarMaxSteerAngle.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarMaxSteerAngle.TabIndex = 299;
      this.hsbarMaxSteerAngle.Value = 10;
      this.hsbarMaxSteerAngle.ValueChanged += new System.EventHandler( this.hsbarMaxSteerAngle_ValueChanged );
      // 
      // lblSteerAngleSensorZero
      // 
      this.lblSteerAngleSensorZero.AutoSize = true;
      this.lblSteerAngleSensorZero.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblSteerAngleSensorZero.Location = new System.Drawing.Point( 310, 30 );
      this.lblSteerAngleSensorZero.Name = "lblSteerAngleSensorZero";
      this.lblSteerAngleSensorZero.Size = new System.Drawing.Size( 108, 45 );
      this.lblSteerAngleSensorZero.TabIndex = 298;
      this.lblSteerAngleSensorZero.Text = "-888";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label10.Location = new System.Drawing.Point( 29, 17 );
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size( 258, 23 );
      this.label10.TabIndex = 295;
      this.label10.Text = "Steer Angle Sensor Zero >0<";
      // 
      // hsbarSteerAngleSensorZero
      // 
      this.hsbarSteerAngleSensorZero.LargeChange = 1;
      this.hsbarSteerAngleSensorZero.Location = new System.Drawing.Point( 16, 43 );
      this.hsbarSteerAngleSensorZero.Maximum = 127;
      this.hsbarSteerAngleSensorZero.Minimum = -127;
      this.hsbarSteerAngleSensorZero.Name = "hsbarSteerAngleSensorZero";
      this.hsbarSteerAngleSensorZero.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarSteerAngleSensorZero.TabIndex = 294;
      this.hsbarSteerAngleSensorZero.ValueChanged += new System.EventHandler( this.hsbarSteerAngleSensorZero_ValueChanged );
      // 
      // lblMaxAngularVelocity
      // 
      this.lblMaxAngularVelocity.AutoSize = true;
      this.lblMaxAngularVelocity.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblMaxAngularVelocity.Location = new System.Drawing.Point( 310, 261 );
      this.lblMaxAngularVelocity.Name = "lblMaxAngularVelocity";
      this.lblMaxAngularVelocity.Size = new System.Drawing.Size( 108, 45 );
      this.lblMaxAngularVelocity.TabIndex = 288;
      this.lblMaxAngularVelocity.Text = "-888";
      // 
      // hsbarMaxAngularVelocity
      // 
      this.hsbarMaxAngularVelocity.LargeChange = 1;
      this.hsbarMaxAngularVelocity.Location = new System.Drawing.Point( 16, 275 );
      this.hsbarMaxAngularVelocity.Maximum = 10;
      this.hsbarMaxAngularVelocity.Minimum = 2;
      this.hsbarMaxAngularVelocity.Name = "hsbarMaxAngularVelocity";
      this.hsbarMaxAngularVelocity.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarMaxAngularVelocity.TabIndex = 284;
      this.hsbarMaxAngularVelocity.Value = 10;
      this.hsbarMaxAngularVelocity.ValueChanged += new System.EventHandler( this.hsbarMaxAngularVelocity_ValueChanged );
      // 
      // label30
      // 
      this.label30.AutoSize = true;
      this.label30.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label30.Location = new System.Drawing.Point( 29, 249 );
      this.label30.Name = "label30";
      this.label30.Size = new System.Drawing.Size( 249, 23 );
      this.label30.TabIndex = 285;
      this.label30.Text = "Safe Turn (Max Angular Vel)";
      // 
      // tabDrive
      // 
      this.tabDrive.BackColor = System.Drawing.Color.PowderBlue;
      this.tabDrive.Controls.Add( this.richTextBox1 );
      this.tabDrive.Controls.Add( this.btnSteerWizard );
      this.tabDrive.Controls.Add( this.hSBarFreeDrive );
      this.tabDrive.Controls.Add( this.lblFreeDriveAngle );
      this.tabDrive.Controls.Add( this.btnFreeDrive );
      this.tabDrive.Controls.Add( this.label21 );
      this.tabDrive.Controls.Add( this.label20 );
      this.tabDrive.Controls.Add( this.btnFreeDriveZero );
      this.tabDrive.Location = new System.Drawing.Point( 4, 36 );
      this.tabDrive.Name = "tabDrive";
      this.tabDrive.Size = new System.Drawing.Size( 426, 398 );
      this.tabDrive.TabIndex = 11;
      this.tabDrive.Text = "Drive";
      // 
      // richTextBox1
      // 
      this.richTextBox1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
      | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.richTextBox1.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.richTextBox1.Location = new System.Drawing.Point( 3, 205 );
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size( 416, 266 );
      this.richTextBox1.TabIndex = 234;
      this.richTextBox1.Text = resources.GetString( "richTextBox1.Text" );
      // 
      // hSBarFreeDrive
      // 
      this.hSBarFreeDrive.LargeChange = 1;
      this.hSBarFreeDrive.Location = new System.Drawing.Point( 26, 127 );
      this.hSBarFreeDrive.Maximum = 40;
      this.hSBarFreeDrive.Minimum = -40;
      this.hSBarFreeDrive.Name = "hSBarFreeDrive";
      this.hSBarFreeDrive.Size = new System.Drawing.Size( 371, 50 );
      this.hSBarFreeDrive.TabIndex = 233;
      this.hSBarFreeDrive.ValueChanged += new System.EventHandler( this.hSBarFreeDrive_ValueChanged );
      // 
      // btnExit
      // 
      this.btnExit.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnExit.Font = new System.Drawing.Font( "Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.btnExit.ForeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 64 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );
      this.btnExit.Location = new System.Drawing.Point( 343, 446 );
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size( 90, 34 );
      this.btnExit.TabIndex = 233;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler( this.btnExit_Click );
      // 
      // hsbarLookAheadUturnMult
      // 
      this.hsbarLookAheadUturnMult.LargeChange = 1;
      this.hsbarLookAheadUturnMult.Location = new System.Drawing.Point( 17, 291 );
      this.hsbarLookAheadUturnMult.Maximum = 10;
      this.hsbarLookAheadUturnMult.Minimum = 1;
      this.hsbarLookAheadUturnMult.Name = "hsbarLookAheadUturnMult";
      this.hsbarLookAheadUturnMult.Size = new System.Drawing.Size( 287, 23 );
      this.hsbarLookAheadUturnMult.TabIndex = 298;
      this.hsbarLookAheadUturnMult.Value = 4;
      this.hsbarLookAheadUturnMult.ValueChanged += new System.EventHandler( this.hsbarLookAheadUturnMult_ValueChanged );
      // 
      // lblLookAheadUturnMult
      // 
      this.lblLookAheadUturnMult.AutoSize = true;
      this.lblLookAheadUturnMult.Font = new System.Drawing.Font( "Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblLookAheadUturnMult.Location = new System.Drawing.Point( 310, 278 );
      this.lblLookAheadUturnMult.Name = "lblLookAheadUturnMult";
      this.lblLookAheadUturnMult.Size = new System.Drawing.Size( 108, 45 );
      this.lblLookAheadUturnMult.TabIndex = 299;
      this.lblLookAheadUturnMult.Text = "-888";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font( "Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label2.Location = new System.Drawing.Point( 30, 264 );
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size( 261, 23 );
      this.label2.TabIndex = 297;
      this.label2.Text = "UTurn Look Ahead (Multiplier)";
      // 
      // FormSteer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 96F, 96F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.CancelButton = this.btnExit;
      this.ClientSize = new System.Drawing.Size( 440, 483 );
      this.Controls.Add( this.btnExit );
      this.Controls.Add( this.tboxSerialFromAutoSteer );
      this.Controls.Add( this.tboxSerialToAutoSteer );
      this.Controls.Add( this.tabControl1 );
      this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormSteer";
      this.ShowIcon = false;
      this.Text = "Auto Steer Configuration";
      this.TopMost = true;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.FormSteer_FormClosing );
      this.Load += new System.EventHandler( this.FormSteer_Load );
      this.tabControl1.ResumeLayout( false );
      this.tabLook.ResumeLayout( false );
      this.tabLook.PerformLayout();
      this.tabGain.ResumeLayout( false );
      this.tabGain.PerformLayout();
      this.tabSteer.ResumeLayout( false );
      this.tabSteer.PerformLayout();
      this.tabDrive.ResumeLayout( false );
      this.tabDrive.PerformLayout();
      this.ResumeLayout( false );
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox tboxSerialFromAutoSteer;
    private System.Windows.Forms.TextBox tboxSerialToAutoSteer;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnSteerWizard;
    private System.Windows.Forms.Button btnFreeDriveZero;
    private System.Windows.Forms.Button btnFreeDrive;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label lblFreeDriveAngle;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabSteer;
    private System.Windows.Forms.TabPage tabGain;
    private System.Windows.Forms.TabPage tabDrive;
    private System.Windows.Forms.HScrollBar hSBarFreeDrive;
    private System.Windows.Forms.Label lblIntegralMax;
    private System.Windows.Forms.Label label45;
    private System.Windows.Forms.HScrollBar hsbarIntegralMax;
    private System.Windows.Forms.Label lblIntegralGain;
    private System.Windows.Forms.Label label33;
    private System.Windows.Forms.HScrollBar hsbarIntegralGain;
    private System.Windows.Forms.Label lblSidehillDraftGain;
    private System.Windows.Forms.Label label29;
    private System.Windows.Forms.HScrollBar hsbarSidehillDraftGain;
    private System.Windows.Forms.Label lblOutputGain;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.HScrollBar hsbarOutputGain;
    private System.Windows.Forms.Label lblProportionalGain;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.HScrollBar hsbarProportionalGain;
    private System.Windows.Forms.Label lblLookAhead;
    private System.Windows.Forms.HScrollBar hsbarLookAhead;
    private System.Windows.Forms.Label label37;
    private System.Windows.Forms.Label lblMaxAngularVelocity;
    private System.Windows.Forms.HScrollBar hsbarMaxAngularVelocity;
    private System.Windows.Forms.Label label30;
    private System.Windows.Forms.Label lblMinPWM;
    private System.Windows.Forms.HScrollBar hsbarMinPWM;
    private System.Windows.Forms.Label label41;
    private System.Windows.Forms.Label lblCountsPerDegree;
    private System.Windows.Forms.Label label25;
    private System.Windows.Forms.HScrollBar hsbarCountsPerDegree;
    private System.Windows.Forms.Label lblMaxSteerAngle;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.HScrollBar hsbarMaxSteerAngle;
    private System.Windows.Forms.Label lblSteerAngleSensorZero;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.HScrollBar hsbarSteerAngleSensorZero;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.TabPage tabLook;
    private System.Windows.Forms.HScrollBar hsbarLookAheadMin;
    private System.Windows.Forms.HScrollBar hsbarDistanceFromLine;
    private System.Windows.Forms.Label lblLookAheadMinimum;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblDistanceFromLine;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnChart;
    private System.Windows.Forms.HScrollBar hsbarLookAheadUturnMult;
    private System.Windows.Forms.Label lblLookAheadUturnMult;
    private System.Windows.Forms.Label label2;
  }
}