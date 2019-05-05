﻿namespace AgOpenGPS {
  partial class FormWizardSteer {
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
      this.btnCalculate = new System.Windows.Forms.Button();
      this.lblRawSteer = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer( this.components );
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.nudRadius = new System.Windows.Forms.NumericUpDown();
      this.nudRawData = new System.Windows.Forms.NumericUpDown();
      this.label6 = new System.Windows.Forms.Label();
      this.lblWheelbase = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.lblSteerAngle = new System.Windows.Forms.Label();
      this.lblCountsPerDegree = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnSerialCancel = new System.Windows.Forms.Button();
      ( (System.ComponentModel.ISupportInitialize)( this.nudRadius ) ).BeginInit();
      ( (System.ComponentModel.ISupportInitialize)( this.nudRawData ) ).BeginInit();
      this.SuspendLayout();
      // 
      // btnCalculate
      // 
      this.btnCalculate.Font = new System.Drawing.Font( "Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
      this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.btnCalculate.Location = new System.Drawing.Point( 12, 383 );
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size( 139, 77 );
      this.btnCalculate.TabIndex = 6;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.Click += new System.EventHandler( this.btnCalculate_Click );
      // 
      // lblRawSteer
      // 
      this.lblRawSteer.AutoSize = true;
      this.lblRawSteer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblRawSteer.Font = new System.Drawing.Font( "Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblRawSteer.ForeColor = System.Drawing.Color.Yellow;
      this.lblRawSteer.Location = new System.Drawing.Point( 60, 76 );
      this.lblRawSteer.Name = "lblRawSteer";
      this.lblRawSteer.Size = new System.Drawing.Size( 108, 27 );
      this.lblRawSteer.TabIndex = 65;
      this.lblRawSteer.Text = "????????";
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 200;
      this.timer1.Tick += new System.EventHandler( this.timer1_Tick );
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label2.Location = new System.Drawing.Point( 11, 10 );
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size( 427, 38 );
      this.label2.TabIndex = 66;
      this.label2.Text = "1. First make sure when going straight ahead the raw data \r\n    reads 0. Go Back " +
"if not.";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label1.Location = new System.Drawing.Point( 33, 50 );
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size( 171, 19 );
      this.label1.TabIndex = 198;
      this.label1.Text = "Raw Data From Sensor";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label3.Location = new System.Drawing.Point( 11, 110 );
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size( 360, 38 );
      this.label3.TabIndex = 199;
      this.label3.Text = "2. Turn the steering wheels to about 15 degrees. \r\n    Make sure raw data is a po" +
"sitive value";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label4.Location = new System.Drawing.Point( 11, 173 );
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size( 475, 38 );
      this.label4.TabIndex = 200;
      this.label4.Text = "3. Note the raw data value, and drive in a complete circle making \r\n    sure the " +
"steering does not change, raw data number either.\r\n";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label5.Location = new System.Drawing.Point( 12, 299 );
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size( 306, 57 );
      this.label5.TabIndex = 201;
      this.label5.Text = "5. Measure the DIAMETER in METERS \r\n    of the circle from center of pivot point " +
"\r\n    tracks all the way across, and enter -->";
      // 
      // nudRadius
      // 
      this.nudRadius.DecimalPlaces = 1;
      this.nudRadius.Font = new System.Drawing.Font( "Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.nudRadius.Increment = new decimal( new int[] {
            1,
            0,
            0,
            65536} );
      this.nudRadius.Location = new System.Drawing.Point( 324, 305 );
      this.nudRadius.Minimum = new decimal( new int[] {
            40,
            0,
            0,
            65536} );
      this.nudRadius.Name = "nudRadius";
      this.nudRadius.Size = new System.Drawing.Size( 166, 53 );
      this.nudRadius.TabIndex = 203;
      this.nudRadius.Value = new decimal( new int[] {
            252,
            0,
            0,
            65536} );
      this.nudRadius.ValueChanged += new System.EventHandler( this.nudRadius_ValueChanged );
      // 
      // nudRawData
      // 
      this.nudRawData.Font = new System.Drawing.Font( "Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.nudRawData.Location = new System.Drawing.Point( 320, 230 );
      this.nudRawData.Maximum = new decimal( new int[] {
            500,
            0,
            0,
            0} );
      this.nudRawData.Name = "nudRawData";
      this.nudRawData.Size = new System.Drawing.Size( 166, 53 );
      this.nudRawData.TabIndex = 204;
      this.nudRawData.Value = new decimal( new int[] {
            100,
            0,
            0,
            0} );
      this.nudRawData.ValueChanged += new System.EventHandler( this.nudRawData_ValueChanged );
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label6.Location = new System.Drawing.Point( 12, 236 );
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size( 296, 38 );
      this.label6.TabIndex = 205;
      this.label6.Text = "4. Enter the raw data from sensor\r\n    number you see above, and enter -->";
      // 
      // lblWheelbase
      // 
      this.lblWheelbase.AutoSize = true;
      this.lblWheelbase.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblWheelbase.Font = new System.Drawing.Font( "Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblWheelbase.ForeColor = System.Drawing.Color.Yellow;
      this.lblWheelbase.Location = new System.Drawing.Point( 230, 76 );
      this.lblWheelbase.Name = "lblWheelbase";
      this.lblWheelbase.Size = new System.Drawing.Size( 72, 27 );
      this.lblWheelbase.TabIndex = 206;
      this.lblWheelbase.Text = "?????";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label10.Location = new System.Drawing.Point( 215, 50 );
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size( 149, 19 );
      this.label10.TabIndex = 207;
      this.label10.Text = "Wheelbase (meters)";
      // 
      // lblSteerAngle
      // 
      this.lblSteerAngle.AutoSize = true;
      this.lblSteerAngle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblSteerAngle.Font = new System.Drawing.Font( "Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblSteerAngle.ForeColor = System.Drawing.Color.Yellow;
      this.lblSteerAngle.Location = new System.Drawing.Point( 397, 414 );
      this.lblSteerAngle.Name = "lblSteerAngle";
      this.lblSteerAngle.Size = new System.Drawing.Size( 67, 35 );
      this.lblSteerAngle.TabIndex = 209;
      this.lblSteerAngle.Text = "----";
      // 
      // lblCountsPerDegree
      // 
      this.lblCountsPerDegree.AutoSize = true;
      this.lblCountsPerDegree.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lblCountsPerDegree.Font = new System.Drawing.Font( "Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblCountsPerDegree.ForeColor = System.Drawing.Color.Yellow;
      this.lblCountsPerDegree.Location = new System.Drawing.Point( 222, 414 );
      this.lblCountsPerDegree.Name = "lblCountsPerDegree";
      this.lblCountsPerDegree.Size = new System.Drawing.Size( 67, 35 );
      this.lblCountsPerDegree.TabIndex = 210;
      this.lblCountsPerDegree.Text = "----";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label13.Location = new System.Drawing.Point( 385, 390 );
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size( 91, 19 );
      this.label13.TabIndex = 211;
      this.label13.Text = "Steer Angle";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label14.Location = new System.Drawing.Point( 209, 390 );
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size( 141, 19 );
      this.label14.TabIndex = 212;
      this.label14.Text = "Counts per Degree";
      // 
      // panel1
      // 
      this.panel1.BackgroundImage = global::AgOpenGPS.Properties.Resources.tire;
      this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.panel1.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.panel1.Location = new System.Drawing.Point( 514, 13 );
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size( 394, 357 );
      this.panel1.TabIndex = 202;
      // 
      // btnSerialCancel
      // 
      this.btnSerialCancel.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSerialCancel.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.btnSerialCancel.Image = global::AgOpenGPS.Properties.Resources.Cancel64;
      this.btnSerialCancel.Location = new System.Drawing.Point( 811, 385 );
      this.btnSerialCancel.Name = "btnSerialCancel";
      this.btnSerialCancel.Size = new System.Drawing.Size( 97, 76 );
      this.btnSerialCancel.TabIndex = 64;
      this.btnSerialCancel.UseVisualStyleBackColor = true;
      this.btnSerialCancel.Click += new System.EventHandler( this.btnSerialCancel_Click );
      // 
      // FormWizardSteer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 9F, 19F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size( 919, 473 );
      this.ControlBox = false;
      this.Controls.Add( this.label14 );
      this.Controls.Add( this.label13 );
      this.Controls.Add( this.lblCountsPerDegree );
      this.Controls.Add( this.lblSteerAngle );
      this.Controls.Add( this.label10 );
      this.Controls.Add( this.lblWheelbase );
      this.Controls.Add( this.label6 );
      this.Controls.Add( this.nudRawData );
      this.Controls.Add( this.nudRadius );
      this.Controls.Add( this.panel1 );
      this.Controls.Add( this.label5 );
      this.Controls.Add( this.label4 );
      this.Controls.Add( this.label3 );
      this.Controls.Add( this.label1 );
      this.Controls.Add( this.label2 );
      this.Controls.Add( this.lblRawSteer );
      this.Controls.Add( this.btnSerialCancel );
      this.Controls.Add( this.btnCalculate );
      this.Font = new System.Drawing.Font( "Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding( 4, 5, 4, 5 );
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormWizardSteer";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Steering Wizard";
      this.Load += new System.EventHandler( this.FormWizardSteer_Load );
      ( (System.ComponentModel.ISupportInitialize)( this.nudRadius ) ).EndInit();
      ( (System.ComponentModel.ISupportInitialize)( this.nudRawData ) ).EndInit();
      this.ResumeLayout( false );
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCalculate;
    private System.Windows.Forms.Button btnSerialCancel;
    private System.Windows.Forms.Label lblRawSteer;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.NumericUpDown nudRadius;
    private System.Windows.Forms.NumericUpDown nudRawData;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lblWheelbase;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label lblSteerAngle;
    private System.Windows.Forms.Label lblCountsPerDegree;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
  }
}