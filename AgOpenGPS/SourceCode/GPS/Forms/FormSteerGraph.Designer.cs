﻿namespace AgOpenGPS {
  partial class FormSteerGraph {
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.timer1 = new System.Windows.Forms.Timer( this.components );
      this.unoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label5 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lblPWM = new System.Windows.Forms.Label();
      this.lblSteerAng = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.btnMode = new System.Windows.Forms.Button();
      this.lblError = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      ( (System.ComponentModel.ISupportInitialize)( this.unoChart ) ).BeginInit();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 200;
      this.timer1.Tick += new System.EventHandler( this.timer1_Tick );
      // 
      // unoChart
      // 
      this.unoChart.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
      | System.Windows.Forms.AnchorStyles.Left )
      | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.unoChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
      this.unoChart.BackColor = System.Drawing.Color.Black;
      chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
      chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
      chartArea1.AxisY.LineWidth = 2;
      chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
      chartArea1.BackColor = System.Drawing.Color.Black;
      chartArea1.BorderWidth = 0;
      chartArea1.Name = "ChartArea1";
      chartArea1.Position.Auto = false;
      chartArea1.Position.Height = 100F;
      chartArea1.Position.Width = 100F;
      this.unoChart.ChartAreas.Add( chartArea1 );
      this.unoChart.Location = new System.Drawing.Point( 44, 12 );
      this.unoChart.Margin = new System.Windows.Forms.Padding( 0 );
      this.unoChart.Name = "unoChart";
      this.unoChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
      series1.BackSecondaryColor = System.Drawing.Color.White;
      series1.BorderColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ) );
      series1.BorderWidth = 2;
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
      series1.Color = System.Drawing.Color.OrangeRed;
      series1.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      series1.Legend = "Legend1";
      series1.Name = "S";
      series1.YValuesPerPoint = 6;
      series2.BorderWidth = 2;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
      series2.Color = System.Drawing.Color.Lime;
      series2.IsVisibleInLegend = false;
      series2.Legend = "Legend1";
      series2.Name = "PWM";
      this.unoChart.Series.Add( series1 );
      this.unoChart.Series.Add( series2 );
      this.unoChart.Size = new System.Drawing.Size( 533, 191 );
      this.unoChart.TabIndex = 180;
      this.unoChart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
      // 
      // label5
      // 
      this.label5.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
      this.label5.AutoEllipsis = true;
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label5.Font = new System.Drawing.Font( "Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label5.Location = new System.Drawing.Point( 166, 189 );
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size( 78, 23 );
      this.label5.TabIndex = 196;
      this.label5.Text = "SetPoint";
      // 
      // label1
      // 
      this.label1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
      this.label1.AutoEllipsis = true;
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label1.Font = new System.Drawing.Font( "Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label1.Location = new System.Drawing.Point( 12, 189 );
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size( 61, 23 );
      this.label1.TabIndex = 195;
      this.label1.Text = "Actual";
      // 
      // lblPWM
      // 
      this.lblPWM.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
      this.lblPWM.AutoSize = true;
      this.lblPWM.BackColor = System.Drawing.SystemColors.ControlText;
      this.lblPWM.Font = new System.Drawing.Font( "Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblPWM.ForeColor = System.Drawing.Color.Lime;
      this.lblPWM.Location = new System.Drawing.Point( 240, 189 );
      this.lblPWM.Name = "lblPWM";
      this.lblPWM.Size = new System.Drawing.Size( 68, 23 );
      this.lblPWM.TabIndex = 194;
      this.lblPWM.Text = "label5";
      // 
      // lblSteerAng
      // 
      this.lblSteerAng.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
      this.lblSteerAng.AutoSize = true;
      this.lblSteerAng.BackColor = System.Drawing.SystemColors.ControlText;
      this.lblSteerAng.Font = new System.Drawing.Font( "Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblSteerAng.ForeColor = System.Drawing.Color.OrangeRed;
      this.lblSteerAng.Location = new System.Drawing.Point( 70, 189 );
      this.lblSteerAng.Name = "lblSteerAng";
      this.lblSteerAng.Size = new System.Drawing.Size( 68, 23 );
      this.lblSteerAng.TabIndex = 193;
      this.lblSteerAng.Text = "label1";
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button1.Font = new System.Drawing.Font( "Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.button1.ForeColor = System.Drawing.Color.Fuchsia;
      this.button1.Location = new System.Drawing.Point( 3, 12 );
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size( 79, 45 );
      this.button1.TabIndex = 234;
      this.button1.Text = "Exit";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler( this.button1_Click );
      // 
      // btnMode
      // 
      this.btnMode.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
      this.btnMode.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnMode.Font = new System.Drawing.Font( "Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.btnMode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnMode.Location = new System.Drawing.Point( 3, 136 );
      this.btnMode.Name = "btnMode";
      this.btnMode.Size = new System.Drawing.Size( 79, 45 );
      this.btnMode.TabIndex = 235;
      this.btnMode.Text = "A - S";
      this.btnMode.UseVisualStyleBackColor = true;
      this.btnMode.Click += new System.EventHandler( this.btnMode_Click );
      // 
      // lblError
      // 
      this.lblError.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
      this.lblError.AutoSize = true;
      this.lblError.BackColor = System.Drawing.SystemColors.ControlText;
      this.lblError.Font = new System.Drawing.Font( "Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.lblError.ForeColor = System.Drawing.Color.Yellow;
      this.lblError.Location = new System.Drawing.Point( 400, 189 );
      this.lblError.Name = "lblError";
      this.lblError.Size = new System.Drawing.Size( 40, 23 );
      this.lblError.TabIndex = 236;
      this.lblError.Text = "0.1";
      // 
      // label3
      // 
      this.label3.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
      this.label3.AutoEllipsis = true;
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label3.Font = new System.Drawing.Font( "Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
      this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.label3.Location = new System.Drawing.Point( 351, 189 );
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size( 52, 23 );
      this.label3.TabIndex = 237;
      this.label3.Text = "Error";
      // 
      // FormSteerGraph
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.CancelButton = this.button1;
      this.ClientSize = new System.Drawing.Size( 578, 212 );
      this.Controls.Add( this.lblError );
      this.Controls.Add( this.label3 );
      this.Controls.Add( this.lblPWM );
      this.Controls.Add( this.lblSteerAng );
      this.Controls.Add( this.btnMode );
      this.Controls.Add( this.button1 );
      this.Controls.Add( this.label5 );
      this.Controls.Add( this.label1 );
      this.Controls.Add( this.unoChart );
      this.Location = new System.Drawing.Point( 30, 30 );
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormSteerGraph";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AutoSteer Graph";
      this.TopMost = true;
      this.Load += new System.EventHandler( this.FormSteerGraph_Load );
      ( (System.ComponentModel.ISupportInitialize)( this.unoChart ) ).EndInit();
      this.ResumeLayout( false );
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.DataVisualization.Charting.Chart unoChart;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblPWM;
    private System.Windows.Forms.Label lblSteerAng;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnMode;
    private System.Windows.Forms.Label lblError;
    private System.Windows.Forms.Label label3;
  }
}