﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgOpenGPS {
  public partial class FormSteer : Form {
    private readonly FormGPS mf = null;

    //the trackbar angle for free drive
    private Int16 driveFreeSteerAngle = 0;

    //Form stuff
    public FormSteer( Form callingForm ) {
      mf = callingForm as FormGPS;
      InitializeComponent();
    }

    private void FormSteer_Load( object sender, EventArgs e ) {
      //btnPMinus.Text = mf.mc.autoSteerSettings[mf.mc.ssKp].ToString();
      //btnIMinus.Text = mf.mc.autoSteerSettings[mf.mc.ssKi].ToString();
      //btnDMinus.Text = mf.mc.autoSteerSettings[mf.mc.ssKd].ToString();
      //btnOMinus.Text = mf.mc.autoSteerSettings[mf.mc.ssKo].ToString();

      hsbarSteerAngleSensorZero.Value = Properties.Settings.Default.setAS_steerAngleOffset - 127;
      lblSteerAngleSensorZero.Text = hsbarSteerAngleSensorZero.Value.ToString();

      hsbarCountsPerDegree.Value = Properties.Settings.Default.setAS_countsPerDegree;
      lblCountsPerDegree.Text = hsbarCountsPerDegree.Value.ToString();

      hsbarMinPWM.Value = Properties.Settings.Default.setAS_minSteerPWM;
      lblMinPWM.Text = hsbarMinPWM.Value.ToString();

      hsbarProportionalGain.Value = Properties.Settings.Default.setAS_Kp;
      lblProportionalGain.Text = hsbarProportionalGain.Value.ToString();

      hsbarOutputGain.Value = Properties.Settings.Default.setAS_Ko;
      lblOutputGain.Text = hsbarOutputGain.Value.ToString();

      hsbarSidehillDraftGain.Value = Properties.Settings.Default.setAS_Kd;
      lblSidehillDraftGain.Text = hsbarSidehillDraftGain.Value.ToString();

      hsbarIntegralGain.Value = Properties.Settings.Default.setAS_Ki;
      lblIntegralGain.Text = hsbarIntegralGain.Value.ToString();

      hsbarIntegralMax.Value = Properties.Settings.Default.setAS_maxIntegral;
      lblIntegralMax.Text = hsbarIntegralMax.Value.ToString();

      mf.vehicle.maxSteerAngle = Properties.Vehicle.Default.setVehicle_maxSteerAngle;
      hsbarMaxSteerAngle.Value = (Int16)mf.vehicle.maxSteerAngle;
      lblMaxSteerAngle.Text = hsbarMaxSteerAngle.Value.ToString();

      mf.vehicle.goalPointLookAheadSeconds = Properties.Vehicle.Default.setVehicle_goalPointLookAhead;
      hsbarLookAhead.Value = (Int16)( mf.vehicle.goalPointLookAheadSeconds * 10 );
      lblLookAhead.Text = mf.vehicle.goalPointLookAheadSeconds.ToString();

      mf.vehicle.goalPointLookAheadMinimumDistance = Properties.Vehicle.Default.setVehicle_lookAheadMinimum;
      hsbarLookAheadMin.Value = (Int16)( mf.vehicle.goalPointLookAheadMinimumDistance * 10 );
      lblLookAheadMinimum.Text = mf.vehicle.goalPointLookAheadMinimumDistance.ToString();

      mf.vehicle.goalPointDistanceMultiplier = Properties.Vehicle.Default.setVehicle_lookAheadDistanceFromLine;
      hsbarDistanceFromLine.Value = (Int16)( mf.vehicle.goalPointDistanceMultiplier * 10 );
      lblDistanceFromLine.Text = ( mf.vehicle.goalPointDistanceMultiplier + 1 ).ToString();

      hsbarLookAheadUturnMult.Value = (Int16)( mf.vehicle.goalPointLookAheadUturnMult * 10 );
      lblLookAheadUturnMult.Text = mf.vehicle.goalPointLookAheadUturnMult.ToString();

      mf.vehicle.maxAngularVelocity = Properties.Vehicle.Default.setVehicle_maxAngularVelocity;
      hsbarMaxAngularVelocity.Value = (Int16)mf.vehicle.maxAngularVelocity;
      lblMaxAngularVelocity.Text = hsbarMaxAngularVelocity.Value.ToString();

      //make sure free drive is off
      btnFreeDrive.BackColor = Color.Red;
      mf.ast.isInFreeDriveMode = false;
      btnFreeDriveZero.Enabled = false;
      hSBarFreeDrive.Enabled = false;
      hSBarFreeDrive.Value = 0;
      driveFreeSteerAngle = 0;
      lblFreeDriveAngle.Text = "0";
    }

    private void FormSteer_FormClosing( object sender, FormClosingEventArgs e ) {
      mf.ast.isInFreeDriveMode = false;
    }

    //Timer
    private void timer1_Tick( object sender, EventArgs e ) {
#warning implement texts for labels
      ////if (!mf.ast.isInFreeDriveMode)
      ////{
      ////    //normal mode
      ////    tboxSerialFromAutoSteer.Text = mf.mc.serialRecvAutoSteerStr;
      ////    tboxSerialToAutoSteer.Text = mf.mc.autoSteerData[mf.mc.sdRelayLo] + ", " + mf.mc.autoSteerData[mf.mc.sdSpeed]
      ////                            + ", " + mf.guidanceLineDistanceOff + ", " + mf.guidanceLineSteerAngle;
      ////}
      ////else
      ////{
      ////    //free drive mode
      ////    mf.mc.autoSteerData[mf.mc.sdSteerAngleHi] = (byte)((driveFreeSteerAngle * 100) >> 8);
      ////    mf.mc.autoSteerData[mf.mc.sdSteerAngleLo] = (byte)(driveFreeSteerAngle * 100);

      ////    tboxSerialFromAutoSteer.Text = mf.mc.serialRecvAutoSteerStr;
      ////    tboxSerialToAutoSteer.Text = mf.mc.autoSteerData[mf.mc.sdRelayLo] + ", " + mf.mc.autoSteerData[mf.mc.sdSpeed]
      ////                            + ", " + mf.mc.autoSteerData[mf.mc.sdDistanceLo] + ", " + (driveFreeSteerAngle * 100);
      ////}
    }

    //Scrollbars
    private void hsbarLookAhead_ValueChanged( object sender, EventArgs e ) {
      mf.vehicle.goalPointLookAheadSeconds = hsbarLookAhead.Value * 0.1;
      lblLookAhead.Text = mf.vehicle.goalPointLookAheadSeconds.ToString();
      Properties.Vehicle.Default.setVehicle_goalPointLookAhead = mf.vehicle.goalPointLookAheadSeconds;
      Properties.Vehicle.Default.Save();
      //mf.AutoSteerSettingsOutToPort();
    }

    private void hsbarLookAheadUturnMult_ValueChanged( object sender, EventArgs e ) {
      mf.vehicle.goalPointLookAheadUturnMult = hsbarLookAheadUturnMult.Value * 0.1;
      lblLookAheadUturnMult.Text = mf.vehicle.goalPointLookAheadUturnMult.ToString();
      Properties.Vehicle.Default.setVehicle_goalPointLookAheadUturnMult = mf.vehicle.goalPointLookAheadUturnMult;
      Properties.Vehicle.Default.Save();
    }

    private void hsbarDistanceFromLine_ValueChanged( object sender, EventArgs e ) {
      mf.vehicle.goalPointDistanceMultiplier = hsbarDistanceFromLine.Value * 0.1;
      lblDistanceFromLine.Text = ( mf.vehicle.goalPointDistanceMultiplier + 1 ).ToString();
      Properties.Vehicle.Default.setVehicle_lookAheadDistanceFromLine = mf.vehicle.goalPointDistanceMultiplier;
      Properties.Vehicle.Default.Save();
    }

    private void hsbarLookAheadMin_ValueChanged( object sender, EventArgs e ) {
      mf.vehicle.goalPointLookAheadMinimumDistance = hsbarLookAheadMin.Value * 0.1;
      lblLookAheadMinimum.Text = mf.vehicle.goalPointLookAheadMinimumDistance.ToString();
      Properties.Vehicle.Default.setVehicle_lookAheadMinimum = mf.vehicle.goalPointLookAheadMinimumDistance;
      Properties.Vehicle.Default.Save();
    }

    private void hsbarCountsPerDegree_ValueChanged( object sender, EventArgs e ) {
      lblCountsPerDegree.Text = ( hsbarCountsPerDegree.Value ).ToString();
      Properties.Settings.Default.setAS_countsPerDegree = (byte)hsbarCountsPerDegree.Value;
      Properties.Settings.Default.Save();
      mf.AutoSteerSettingsOutToPort();
    }

    private void hsbarMaxSteerAngle_ValueChanged( object sender, EventArgs e ) {
      mf.vehicle.maxSteerAngle = hsbarMaxSteerAngle.Value;
      lblMaxSteerAngle.Text = hsbarMaxSteerAngle.Value.ToString();
      Properties.Vehicle.Default.setVehicle_maxSteerAngle = mf.vehicle.maxSteerAngle;
      Properties.Vehicle.Default.Save();
    }

    private void hsbarSteerAngleSensorZero_ValueChanged( object sender, EventArgs e ) {
      lblSteerAngleSensorZero.Text = hsbarSteerAngleSensorZero.Value.ToString();
      //mf.mc.autoSteerSettings[mf.mc.ssSteerOffset] = (byte)(127 + hsbarSteerAngleSensorZero.Value);
      Properties.Settings.Default.setAS_steerAngleOffset = (byte)( 127 + hsbarSteerAngleSensorZero.Value );
      Properties.Settings.Default.Save();
      mf.AutoSteerSettingsOutToPort();
    }

    private void hsbarMinPWM_ValueChanged( object sender, EventArgs e ) {
      //mf.mc.autoSteerSettings[mf.mc.ssMinPWM] = (byte)hsbarMinPWM.Value;
      lblMinPWM.Text = ( hsbarMinPWM.Value ).ToString();
      Properties.Settings.Default.setAS_minSteerPWM = (byte)hsbarMinPWM.Value;
      Properties.Settings.Default.Save();
      mf.AutoSteerSettingsOutToPort();
    }

    private void hsbarProportionalGain_ValueChanged( object sender, EventArgs e ) {
      //mf.mc.autoSteerSettings[mf.mc.ssKp] = (byte)hsbarProportionalGain.Value;
      lblProportionalGain.Text = ( hsbarProportionalGain.Value ).ToString();
      Properties.Settings.Default.setAS_Kp = (byte)hsbarProportionalGain.Value;
      Properties.Settings.Default.Save();
      mf.AutoSteerSettingsOutToPort();
    }

    private void hsbarOutputGain_ValueChanged( object sender, EventArgs e ) {
      lblOutputGain.Text = ( hsbarOutputGain.Value ).ToString();
      Properties.Settings.Default.setAS_Ko = (byte)hsbarOutputGain.Value;
      Properties.Settings.Default.Save();
      mf.AutoSteerSettingsOutToPort();
    }

    private void hsbarSidehillDraftGain_ValueChanged( object sender, EventArgs e ) {
      //mf.mc.autoSteerSettings[mf.mc.ssKd] = (byte)hsbarSidehillDraftGain.Value;
      lblSidehillDraftGain.Text = ( hsbarSidehillDraftGain.Value ).ToString();
      Properties.Settings.Default.setAS_Kd = (byte)hsbarSidehillDraftGain.Value;
      Properties.Settings.Default.Save();
      mf.AutoSteerSettingsOutToPort();
    }

    private void hsbarIntegralGain_ValueChanged( object sender, EventArgs e ) {
      //mf.mc.autoSteerSettings[mf.mc.ssKi] = (byte)hsbarIntegralGain.Value;
      lblIntegralGain.Text = ( hsbarIntegralGain.Value ).ToString();
      Properties.Settings.Default.setAS_Ki = (byte)hsbarIntegralGain.Value;
      Properties.Settings.Default.Save();
      mf.AutoSteerSettingsOutToPort();
    }

    private void hsbarIntegralMax_ValueChanged( object sender, EventArgs e ) {
      //mf.mc.autoSteerSettings[mf.mc.ssMaxIntegral] = (byte)hsbarIntegralMax.Value;
      lblIntegralMax.Text = ( hsbarIntegralMax.Value ).ToString();
      Properties.Settings.Default.setAS_maxIntegral = (byte)hsbarIntegralMax.Value;
      Properties.Settings.Default.Save();
      mf.AutoSteerSettingsOutToPort();
    }

    private void hsbarMaxAngularVelocity_ValueChanged( object sender, EventArgs e ) {
      mf.vehicle.maxAngularVelocity = (byte)hsbarMaxAngularVelocity.Value;
      lblMaxAngularVelocity.Text = mf.vehicle.maxAngularVelocity.ToString();
      Properties.Vehicle.Default.setVehicle_maxAngularVelocity = mf.vehicle.maxAngularVelocity;
      Properties.Vehicle.Default.Save();
      mf.AutoSteerSettingsOutToPort();
    }

    //FREE DRIVE SECTION
    private void btnSteerWizard_Click( object sender, EventArgs e ) {
      if( mf.isJobStarted ) {
        var form = new FormTimedMessage( 3000, gStr.gsFieldIsOpen, gStr.gsCloseFieldFirst );
        form.Show();
        return;
      }

      WindowState = FormWindowState.Minimized;
      Hide();

      using( var form = new FormWizardSteer( mf ) ) {
        var result = form.ShowDialog();
        if( result == DialogResult.OK ) {
          //lblCountsPerDegree.Text = (mf.mc.autoSteerSettings[mf.mc.ssCountsPerDegree]).ToString();
          //btnSteerMinus.Text = mf.mc.autoSteerSettings[mf.mc.ssSteerOffset].ToString();
          //mf.AutoSteerSettingsOutToPort();
        } else {
          //btnCountsPerDegreeMinus.Text = (mf.mc.autoSteerSettings[mf.mc.ssCountsPerDegree]).ToString();
          //btnSteerMinus.Text = mf.mc.autoSteerSettings[mf.mc.ssSteerOffset].ToString();
          //mf.AutoSteerSettingsOutToPort();
        }
      }

      //restore the autosteer window
      Show();
      WindowState = FormWindowState.Normal;
    }

    private void hSBarFreeDrive_ValueChanged( object sender, EventArgs e ) {
      driveFreeSteerAngle = (Int16)hSBarFreeDrive.Value;
      lblFreeDriveAngle.Text = Convert.ToString( driveFreeSteerAngle );
    }

    private void btnFreeDrive_Click( object sender, EventArgs e ) {
      if( mf.ast.isInFreeDriveMode ) {
        //turn OFF free drive mode
        btnFreeDrive.BackColor = Color.Red;
        mf.ast.isInFreeDriveMode = false;
        btnFreeDriveZero.Enabled = false;
        hSBarFreeDrive.Enabled = false;
        hSBarFreeDrive.Value = 0;
        driveFreeSteerAngle = 0;
        lblFreeDriveAngle.Text = "0";
      } else {
        //turn ON free drive mode
        btnFreeDrive.BackColor = Color.LimeGreen;
        mf.ast.isInFreeDriveMode = true;
        btnFreeDriveZero.Enabled = true;
        hSBarFreeDrive.Enabled = true;
        hSBarFreeDrive.Value = 0;
        driveFreeSteerAngle = 0;
        lblFreeDriveAngle.Text = "0";
      }
    }

    private void btnFreeDriveZero_Click( object sender, EventArgs e ) {
      driveFreeSteerAngle = 0;
      hSBarFreeDrive.Value = driveFreeSteerAngle;
      lblFreeDriveAngle.Text = Convert.ToString( driveFreeSteerAngle );
    }

    private void btnExit_Click( object sender, EventArgs e ) {
      Close();
    }

    private void btnMax_Click( object sender, EventArgs e ) {
      if( Height < 600 ) {
        Height = 650;
      } else {
        Height = 400;
      }
    }

    private void btnChart_Click( object sender, EventArgs e ) {
      mf.toolStripAutoSteerChart.PerformClick();
    }
  }
}