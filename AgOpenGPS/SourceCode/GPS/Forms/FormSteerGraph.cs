﻿using System;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AgOpenGPS
{
    public partial class FormSteerGraph : Form
    {
        private readonly FormGPS mf = null;
        private string[] words;

        private bool mode = true;
        private double error, actual = 0;

        //chart data
        private string dataSteerAngle = "0";

        private string dataPWM = "-1";

        public FormSteerGraph(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void DrawChart()
        {
#warning implement charts!
      ////just data
      //words = mf.mc.serialRecvAutoSteerStr.Split(',');
      //if (words.Length < 5)
      //{
      //    dataSteerAngle = "0";
      //    dataPWM = "-2";
      //    lblSteerAng.Text = "Actual";
      //    lblPWM.Text = "Set";
      //    if (!mode)
      //    {
      //        error = 0;
      //        dataPWM = "0";
      //    }
      //}
      //else
      //{
      //    //word 0 - steerangle, 1 - pwmDisplay
      //    dataSteerAngle = words[0];
      //    dataPWM = words[1];
      //    lblSteerAng.Text = words[0];
      //    lblPWM.Text = words[1];

      //    double.TryParse(words[0], NumberStyles.Float, CultureInfo.InvariantCulture, out actual);
      //    double.TryParse(words[1], NumberStyles.Float, CultureInfo.InvariantCulture, out error);
      //    error -= actual;
      //    lblError.Text = error.ToString();
      //    if (!mode)
      //    {
      //        dataPWM = "0";
      //        dataSteerAngle = error.ToString();
      //    }
      //}

      //chart data
      Series s = unoChart.Series["S"];
            Series w = unoChart.Series["PWM"];
            double nextX = 1;
            double nextX5 = 1;

            if (s.Points.Count > 0) nextX = s.Points[s.Points.Count - 1].XValue + 1;
            if (w.Points.Count > 0) nextX5 = w.Points[w.Points.Count - 1].XValue + 1;

            unoChart.Series["S"].Points.AddXY(nextX, dataSteerAngle);
            unoChart.Series["PWM"].Points.AddXY(nextX5, dataPWM);

            //if (isScroll)
            {
                while (s.Points.Count > 30)
                {
                    s.Points.RemoveAt(0);
                }
                while (w.Points.Count > 30)
                {
                    w.Points.RemoveAt(0);
                }
                unoChart.ResetAutoValues();
            }
        }

        private void FormSteerGraph_Load(object sender, EventArgs e)
        {
            timer1.Interval = (int)((1 / (double)mf.fixUpdateHz) * 1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            mode = !mode;
            if (mode) btnMode.Text = "A   S";
            else btnMode.Text = "A - S";
        }
    }
}