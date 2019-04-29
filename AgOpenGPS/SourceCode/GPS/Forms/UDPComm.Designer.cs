﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Drawing;

namespace AgOpenGPS {
  public partial class FormGPS {
    // Send and Recv socket
    private Socket sendSocket;
    private Socket recvSocket;
    private bool isUDPSendConnected;

    //IP address and port of Auto Steer server
   // IPAddress epIP = IPAddress.Parse( Properties.Settings.Default.setIP_autoSteerIP );
    IPAddress epIP = IPAddress.Broadcast;

    // Data stream
    private byte[] buffer = new byte[1024];

    // Status delegate
    private delegate void UpdateRecvMessageDelegate( int port, byte[] msg );
    private UpdateRecvMessageDelegate updateRecvMessageDelegate = null;

    //sends ascii text message
    public void SendUDPMessage( string message ) {
      if( isUDPSendConnected ) {
        try {
          IPEndPoint epAutoSteer = new IPEndPoint( epIP, Properties.Settings.Default.setIP_autoSteerPort );

          // Get packet as byte array to send
          byte[] byteData = Encoding.ASCII.GetBytes( message );
          if( byteData.Length != 0 )
            sendSocket.BeginSendTo( byteData, 0, byteData.Length, SocketFlags.None, epAutoSteer, new AsyncCallback( SendData ), null );
        } catch( Exception e ) {
          WriteErrorLog( "Sending UDP Message" + e.ToString() );
          MessageBox.Show( "Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
      }
    }

    //sends byte array
    public void SendUDPMessage( byte[] byteData ) {
      if( isUDPSendConnected ) {
        try {
          IPEndPoint epAutoSteer = new IPEndPoint( epIP, Properties.Settings.Default.setIP_autoSteerPort );

          // Send packet to the zero
          if( byteData.Length != 0 )
            sendSocket.BeginSendTo( byteData, 0, byteData.Length, SocketFlags.None, epAutoSteer, new AsyncCallback( SendData ), null );
        } catch( Exception e ) {
          WriteErrorLog( "Sending UDP Message" + e.ToString() );
          MessageBox.Show( "Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
      }
    }

    //sends byte array
    public void SendUDPMessageNTRIP( byte[] byteData, int port ) {
      if( isUDPSendConnected ) {
        try {
          IPEndPoint epAutoSteer = new IPEndPoint( epIP, port );

          // Send packet to the zero
          if( byteData.Length != 0 )
            sendSocket.BeginSendTo( byteData, 0, byteData.Length, SocketFlags.None, epAutoSteer, new AsyncCallback( SendData ), null );
        } catch( Exception e ) {
          WriteErrorLog( "Sending UDP Message" + e.ToString() );
          MessageBox.Show( "Send Error: " + e.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
      }
    }

    private void SendData( IAsyncResult asyncResult ) {
      try {
        sendSocket.EndSend( asyncResult );
      } catch( Exception e ) {
        WriteErrorLog( " UDP Send Data" + e.ToString() );
        MessageBox.Show( "SendData Error: " + e.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error );
      }
    }

    private void ReceiveData( IAsyncResult asyncResult ) {
      try {
        // Initialise the IPEndPoint for the client
        EndPoint epSender = new IPEndPoint( IPAddress.Any, 0 );

        // Receive all data
        int msgLen = recvSocket.EndReceiveFrom( asyncResult, ref epSender );

        byte[] localMsg = new byte[msgLen];
        Array.Copy( buffer, localMsg, msgLen );

        // Listen for more connections again...
        recvSocket.BeginReceiveFrom( buffer, 0, buffer.Length, SocketFlags.None, ref epSender, new AsyncCallback( ReceiveData ), epSender );

        //string text =  Encoding.ASCII.GetString(localMsg);

        int port = ( (IPEndPoint)epSender ).Port;
        // Update status through a delegate
        Invoke( updateRecvMessageDelegate, new object[] { port, localMsg } );
      } catch( Exception e ) {
        WriteErrorLog( "UDP Recv data " + e.ToString() );
        MessageBox.Show( "ReceiveData Error: " + e.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error );
      }
    }

    private void UpdateRecvMessage( int port, byte[] data ) {
      //if it starts with a $, its an nmea sentence
      if( data[0] == '$' ) {
        pn.rawBuffer += Encoding.ASCII.GetString( data );
        recvSentenceSettings = pn.rawBuffer;
        return;
      }

      //quick check
      //if (data.Length != 10) return;

      Int16 pgn = (Int16)( ( data[0] << 8 ) + data[1] );

      switch( port ) {
        //autosteer
        case 5577: {
          //if (ahrs.isHeadingBNO)
          //by Matthias Hammer Jan 2019
          if( ( ahrs.isHeadingBNO ) & ( !ahrs.isBNOSeparate ) ) {
            mc.prevGyroHeading = mc.gyroHeading;
            mc.gyroHeading = (Int16)( ( data[4] << 8 ) + data[5] );
          }

          //if (ahrs.isRollDogs)
          //by Matthias Hammer Jan 2019
          if( ( ahrs.isRollDogs ) & ( !ahrs.isDogsSeparate ) ) {
            mc.rollRaw = (Int16)( ( data[6] << 8 ) + data[7] );
          }

          mc.steerSwitchValue = data[8];
          mc.workSwitchValue = mc.steerSwitchValue & 1;
          mc.steerSwitchValue = mc.steerSwitchValue & 2;

          //build string for display
          double actualSteerAngle = (Int16)( ( data[2] << 8 ) + data[3] );
          double setSteerAngle = (Int16)( ( data[4] << 8 ) + data[5] );
          byte pwm = data[9];

#warning implement Texts for labels
          ////load the usb recv string with udp recd data for chart and gui info
          //mc.serialRecvAutoSteerStr = (actualSteerAngle * 0.01).ToString("N2") + "," + (setSteerAngle * 0.01).ToString("N2")
          //       + "," + (mc.rollRaw * 0.0625).ToString("N1") + "," + mc.steerSwitchValue.ToString()
          //       + "," + (pwm).ToString();
          break;
        }

        //autoDrive
        case 5566: {
          //mc.recvUDPSentence = DateTime.Now.ToString() + "," + data[2].ToString();
          break;
        }

        //lidar
        case 5588: {
          mc.lidarDistance = (Int16)( ( data[2] << 8 ) + data[3] );
          //mc.recvUDPSentence = DateTime.Now.ToString() + "," + mc.lidarDistance.ToString();
          break;
        }

        //IMU
        case 5544: {
          //by Matthias Hammer Jan 2019
          if( ( data[0] == 127 ) & ( data[1] == 238 ) ) {
            if( ahrs.isBNOSeparate ) {
              if( ahrs.isHeadingBNO ) {
                mc.prevGyroHeading = mc.gyroHeading;
                mc.gyroHeading = (Int16)( ( data[4] << 8 ) + data[5] );
              }
            } else {
              if( ( data[4] != 0 ) | ( data[5] != 0 ) ) {
                ahrs.isBNOSeparate = true;
              }
            }

            if( ahrs.isDogsSeparate ) {
              if( ahrs.isRollDogs ) {
                mc.rollRaw = (Int16)( ( data[6] << 8 ) + data[7] );
              }
            } else {
              if( ( data[6] != 0 ) | ( data[7] != 0 ) ) {
                ahrs.isDogsSeparate = true;
              }
            }
          }
          break;
        }
        //Sections
        case 5555: {
          //check header
          if( ( data[0] != 0x7F ) | ( data[1] != 0xF9 ) )
            break;

          //left or single actual rate
          //int.TryParse(data[0], out mc.incomingInt);
          rcd.rateActualLeft = (double)data[2] * 0.01;

          //right actual rate
          rcd.rateActualRight = (double)data[3] * 0.01;

          //Volume for dual and single
          rcd.dualVolumeActual = data[4];

          //read Relay from Arduino = if high then AOG has to switch on = manual
          rcd.RelayFromArduinoHi = data[5];
          rcd.RelayFromArduinoLo = data[6];

          //read SectSWOffToAOG from Arduino = if high then AOG has to switch OFF = manual
          rcd.SectSWOffFromArduinoHi = data[7];
          rcd.SectSWOffFromArduinoLo = data[8];

          //read MainSW+RateSW
          rcd.SectMainSWFromArduino = data[9];
          break;
        }

        // Port 5599: new PGNs
        case 5599: {
          switch( pgn ) {
            // IMU
            case 0x7EA0: {
              // size check
              if( data.Length != 9 ) {
                return;
              }

              Byte mask = data[2];

              // roll
              if( ( mask & 0b0001 ) != 0 ) {
                mc.rollRaw = (Int16)( ( data[3] << 8 ) + data[4] ) / 100;
              }
              // pitch
              if( ( mask & 0b0010 ) != 0 ) {
                mc.pitchRaw = (Int16)( ( data[5] << 8 ) + data[6] ) / 100;
              }
              // heading
              if( ( mask & 0b0100 ) != 0 ) {
                mc.prevGyroHeading = mc.gyroHeading;
                mc.gyroHeading = (UInt16)( ( data[7] << 8 ) + data[8] ) / 100;
              }
              break;
            }

            // Autosteer response
            case 0x7EF1: {
              // size check
              if( data.Length != 6 ) {
                return;
              }

              Byte mask = data[2];

              // workswitch
              if( ( mask & 0b0001 ) != 0 ) {
                mc.workSwitchValue = data[3] & 0b0001;
              }

              // steerswitch
              if( ( mask & 0b0010 ) != 0 ) {
                mc.workSwitchValue = data[3] & 0b0010;
              }
              break;
            }
          }
          break;
        }
      }
    }

    #region Gesture

    // Private variables used to maintain the state of gestures
    //private DrawingObject _dwo = new DrawingObject();
    private Point _ptFirst = new Point();

    private Point _ptSecond = new Point();
    private int _iArguments = 0;

    // One of the fields in GESTUREINFO structure is type of Int64 (8 bytes).
    // The relevant gesture information is stored in lower 4 bytes. This
    // bit mask is used to get 4 lower bytes from this argument.
    private const Int64 ULL_ARGUMENTS_BIT_MASK = 0x00000000FFFFFFFF;

    //-----------------------------------------------------------------------
    // Multitouch/Touch glue (from winuser.h file)
    // Since the managed layer between C# and WinAPI functions does not
    // exist at the moment for multi-touch related functions this part of
    // code is required to replicate definitions from winuser.h file.
    //-----------------------------------------------------------------------
    // Touch event window message constants [winuser.h]
    private const int WM_GESTURENOTIFY = 0x011A;

    private const int WM_GESTURE = 0x0119;

    private const int GC_ALLGESTURES = 0x00000001;

    // Gesture IDs
    private const int GID_BEGIN = 1;

    private const int GID_END = 2;
    private const int GID_ZOOM = 3;
    private const int GID_PAN = 4;
    private const int GID_ROTATE = 5;
    private const int GID_TWOFINGERTAP = 6;


    private const int GID_PRESSANDTAP = 7;

    // Gesture flags - GESTUREINFO.dwFlags
    private const int GF_BEGIN = 0x00000001;

    private const int GF_INERTIA = 0x00000002;
    private const int GF_END = 0x00000004;

    //
    // Gesture configuration structure
    //   - Used in SetGestureConfig and GetGestureConfig
    //   - Note that any setting not included in either GESTURECONFIG.dwWant
    //     or GESTURECONFIG.dwBlock will use the parent window's preferences
    //     or system defaults.
    //
    // Touch API defined structures [winuser.h]
    [StructLayout( LayoutKind.Sequential )]
    private struct GESTURECONFIG {
      public int dwID;    // gesture ID
      public int dwWant;  // settings related to gesture ID that are to be

      // turned on
      public int dwBlock; // settings related to gesture ID that are to be

      // turned off
    }

    [StructLayout( LayoutKind.Sequential )]
    private struct POINTS {
      public short x;
      public short y;
    }

    //
    // Gesture information structure
    //   - Pass the HGESTUREINFO received in the WM_GESTURE message lParam
    //     into the GetGestureInfo function to retrieve this information.
    //   - If cbExtraArgs is non-zero, pass the HGESTUREINFO received in
    //     the WM_GESTURE message lParam into the GetGestureExtraArgs
    //     function to retrieve extended argument information.
    //
    [StructLayout( LayoutKind.Sequential )]
    private struct GESTUREINFO {
      public int cbSize;           // size, in bytes, of this structure

      // (including variable length Args
      // field)
      public int dwFlags;          // see GF_* flags

      public int dwID;             // gesture ID, see GID_* defines
      public IntPtr hwndTarget;    // handle to window targeted by this

      // gesture
      [MarshalAs( UnmanagedType.Struct )]
      internal POINTS ptsLocation; // current location of this gesture

      public int dwInstanceID;     // internally used
      public int dwSequenceID;     // internally used
      public Int64 ullArguments;   // arguments for gestures whose

      // arguments fit in 8 BYTES
      public int cbExtraArgs;      // size, in bytes, of extra arguments,

      // if any, that accompany this gesture
    }

    // Currently touch/multitouch access is done through unmanaged code
    // We must p/invoke into user32 [winuser.h]
    [DllImport( "user32" )]
    [return: MarshalAs( UnmanagedType.Bool )]
    private static extern bool SetGestureConfig( IntPtr hWnd, int dwReserved, int cIDs, ref GESTURECONFIG pGestureConfig, int cbSize );

    [DllImport( "user32" )]
    [return: MarshalAs( UnmanagedType.Bool )]
    private static extern bool GetGestureInfo( IntPtr hGestureInfo, ref GESTUREINFO pGestureInfo );

    // size of GESTURECONFIG structure
    private int _gestureConfigSize;

    // size of GESTUREINFO structure
    private int _gestureInfoSize;

    [SecurityPermission( SecurityAction.Demand )]
    private void SetupStructSizes() {
      // Both GetGestureCommandInfo and GetTouchInputInfo need to be
      // passed the size of the structure they will be filling
      // we get the sizes upfront so they can be used later.
      _gestureConfigSize = Marshal.SizeOf( new GESTURECONFIG() );
      _gestureInfoSize = Marshal.SizeOf( new GESTUREINFO() );
    }

    //-------------------------------------------------------------
    // Since there is no managed layer at the moment that supports
    // event handlers for WM_GESTURENOTIFY and WM_GESTURE
    // messages we have to override WndProc function
    //
    // in
    //   m - Message object
    //-------------------------------------------------------------
    [PermissionSet( SecurityAction.Demand, Name = "FullTrust" )]
    protected override void WndProc( ref Message m ) {
      bool handled = false;

      switch( m.Msg ) {
        case WM_GESTURENOTIFY: {
          // This is the right place to define the list of gestures
          // that this application will support. By populating
          // GESTURECONFIG structure and calling SetGestureConfig
          // function. We can choose gestures that we want to
          // handle in our application. In this app we decide to
          // handle all gestures.
          GESTURECONFIG gc = new GESTURECONFIG {
            dwID = 0,                // gesture ID
            dwWant = GC_ALLGESTURES, // settings related to gesture
                                     // ID that are to be turned on
            dwBlock = 0 // settings related to gesture ID that are
          };
          // to be

          // We must p/invoke into user32 [winuser.h]
          bool bResult = SetGestureConfig(
              Handle, // window for which configuration is specified
              0,      // reserved, must be 0
              1,      // count of GESTURECONFIG structures
              ref gc, // array of GESTURECONFIG structures, dwIDs
                      // will be processed in the order specified
                      // and repeated occurances will overwrite
                      // previous ones
              _gestureConfigSize // sizeof(GESTURECONFIG)
          );

          if( !bResult ) {
            throw new Exception( "Error in execution of SetGestureConfig" );
          }
        }
        handled = true;
        break;

        case WM_GESTURE:
          // The gesture processing code is implemented in
          // the DecodeGesture method
          handled = DecodeGesture( ref m );
          break;

        default:
          handled = false;
          break;
      }

      // Filter message back up to parents.
      base.WndProc( ref m );

      if( handled ) {
        // Acknowledge event if handled.
        try {
          m.Result = new System.IntPtr( 1 );
        } catch( Exception ) {
        }
      }
    }

    // Taken from GCI_ROTATE_ANGLE_FROM_ARGUMENT.
    // Converts from "binary radians" to traditional radians.
    static protected double ArgToRadians( Int64 arg ) {
      return ( arg / 65535.0 * 4.0 * 3.14159265 ) - ( 2.0 * 3.14159265 );
    }

    // Handler of gestures
    //in:
    //  m - Message object
    private bool DecodeGesture( ref Message m ) {
      GESTUREINFO gi;

      try {
        gi = new GESTUREINFO();
      } catch( Exception ) {
        return false;
      }

      gi.cbSize = _gestureInfoSize;

      // Load the gesture information.
      // We must p/invoke into user32 [winuser.h]
      if( !GetGestureInfo( m.LParam, ref gi ) ) {
        return false;
      }

      switch( gi.dwID ) {
        case GID_BEGIN:
        case GID_END:
          break;

        case GID_ZOOM:
          switch( gi.dwFlags ) {
            case GF_BEGIN:
              _iArguments = (int)( gi.ullArguments & ULL_ARGUMENTS_BIT_MASK );
              _ptFirst.X = gi.ptsLocation.x;
              _ptFirst.Y = gi.ptsLocation.y;
              _ptFirst = PointToClient( _ptFirst );
              break;

            default:
              // We read here the second point of the gesture. This
              // is middle point between fingers in this new
              // position.
              _ptSecond.X = gi.ptsLocation.x;
              _ptSecond.Y = gi.ptsLocation.y;
              _ptSecond = PointToClient( _ptSecond ); {
                // The zoom factor is the ratio of the new
                // and the old distance. The new distance
                // between two fingers is stored in
                // gi.ullArguments (lower 4 bytes) and the old
                // distance is stored in _iArguments.
                double k = (double)( _iArguments )
                            / (double)( gi.ullArguments & ULL_ARGUMENTS_BIT_MASK );
                //lblX.Text = k.ToString();
                camera.zoomValue *= k;
                if( camera.zoomValue < 6.0 )
                  camera.zoomValue = 6;
                camera.camSetDistance = camera.zoomValue * camera.zoomValue * -1;
                SetZoom();
              }

              // Now we have to store new information as a starting
              // information for the next step in this gesture.
              _ptFirst = _ptSecond;
              _iArguments = (int)( gi.ullArguments & ULL_ARGUMENTS_BIT_MASK );
              break;
          }
          break;

        //case GID_PAN:
        //    switch (gi.dwFlags)
        //    {
        //        case GF_BEGIN:
        //            _ptFirst.X = gi.ptsLocation.x;
        //            _ptFirst.Y = gi.ptsLocation.y;
        //            _ptFirst = PointToClient(_ptFirst);
        //            break;

        //        default:
        //            // We read the second point of this gesture. It is a
        //            // middle point between fingers in this new position
        //            _ptSecond.X = gi.ptsLocation.x;
        //            _ptSecond.Y = gi.ptsLocation.y;
        //            _ptSecond = PointToClient(_ptSecond);

        //            // We apply move operation of the object
        //            _dwo.Move(_ptSecond.X - _ptFirst.X, _ptSecond.Y - _ptFirst.Y);

        //            Invalidate();

        //            // We have to copy second point into first one to
        //            // prepare for the next step of this gesture.
        //            _ptFirst = _ptSecond;
        //            break;
        //    }
        //    break;

        case GID_ROTATE:
          switch( gi.dwFlags ) {
            case GF_BEGIN:
              _iArguments = 32768;
              break;

            default:
              // Gesture handler returns cumulative rotation angle. However we
              // have to pass the delta angle to our function responsible
              // to process the rotation gesture.
              double k = ( (int)( gi.ullArguments & ULL_ARGUMENTS_BIT_MASK ) - _iArguments ) * 0.01;
              camera.camPitch -= k;
              if( camera.camPitch < -80 )
                camera.camPitch = -80;
              if( camera.camPitch > 0 )
                camera.camPitch = 0;
              _iArguments = (int)( gi.ullArguments & ULL_ARGUMENTS_BIT_MASK );
              break;
          }
          break;

          //case GID_TWOFINGERTAP:
          //    // Toggle drawing of diagonals
          //    _dwo.ToggleDrawDiagonals();
          //    Invalidate();
          //    break;

          //case GID_PRESSANDTAP:
          //    if (gi.dwFlags == GF_BEGIN)
          //    {
          //        // Shift drawing color
          //        _dwo.ShiftColor();
          //        Invalidate();
          //    }
          //    break;
      }

      return true;
    }

    #endregion Gesture

    #region keystrokes
    //keystrokes for easy and quick startup
    protected override bool ProcessCmdKey( ref Message msg, Keys keyData ) {
      //reset Sim
      if( keyData == Keys.L ) {
        btnResetSim.PerformClick();
        return true;
      }

      //speed up
      if( keyData == Keys.Up ) {
        sim.stepDistance += 0.05;
        if( sim.stepDistance > 4.8 )
          sim.stepDistance = 4.8;
        hsbarStepDistance.Value = (int)( sim.stepDistance * 10.0 * fixUpdateHz );

        return true;
      }

      //Stop
      if( keyData == Keys.OemPeriod ) {
        sim.stepDistance = 0;
        hsbarStepDistance.Value = 0;
        return true;
      }

      //slow down
      if( keyData == Keys.Down ) {
        sim.stepDistance -= 0.05;
        if( sim.stepDistance < 0 )
          sim.stepDistance = 0;
        hsbarStepDistance.Value = (int)( sim.stepDistance * 10.0 * fixUpdateHz );
        return true;
      }

      //turn right
      if( keyData == Keys.Right ) {
        sim.steerAngle++;
        if( sim.steerAngle > 30 )
          sim.steerAngle = 30;
        sim.steerAngleScrollBar = sim.steerAngle;
        btnResetSteerAngle.Text = sim.steerAngle.ToString();
        hsbarSteerAngle.Value = (int)( 10 * sim.steerAngle ) + 300;
        return true;
      }

      //turn left
      if( keyData == Keys.Left ) {
        sim.steerAngle--;
        if( sim.steerAngle < -30 )
          sim.steerAngle = -30;
        sim.steerAngleScrollBar = sim.steerAngle;
        btnResetSteerAngle.Text = sim.steerAngle.ToString();
        hsbarSteerAngle.Value = (int)( 10 * sim.steerAngle ) + 300;
        return true;
      }

      //zero steering
      if( keyData == Keys.OemQuestion ) {
        sim.steerAngle = 0.0;
        sim.steerAngleScrollBar = sim.steerAngle;
        btnResetSteerAngle.Text = sim.steerAngle.ToString();
        hsbarSteerAngle.Value = (int)( 10 * sim.steerAngle ) + 300;
        return true;
      }

      if( keyData == ( Keys.F ) ) {
        JobNewOpenResume();
        return true;    // indicate that you handled this keystroke
      }

      if( keyData == ( Keys.A ) ) //autosteer button on off
      {
        btnAutoSteer.PerformClick();
        return true;    // indicate that you handled this keystroke
      }

      if( keyData == ( Keys.S ) ) //open the steer chart
      {
        toolstripAutoSteerConfig.PerformClick();
        return true;    // indicate that you handled this keystroke
      }

      if( keyData == ( Keys.P ) ) //open the steer chart
      {
        btnContourPriority.PerformClick();
        return true;    // indicate that you handled this keystroke
      }

      if( keyData == ( Keys.C ) ) //open the steer chart
      {
        toolStripAutoSteerChart.PerformClick();
        return true;    // indicate that you handled this keystroke
      }

      if( keyData == ( Keys.V ) ) //open the vehicle Settings
      {
        toolstripVehicleConfig.PerformClick();
        return true;    // indicate that you handled this keystroke
      }

      if( keyData == ( Keys.U ) ) //open the UTurn Settings
      {
        toolstripYouTurnConfig.PerformClick();
        return true;    // indicate that you handled this keystroke
      }

      if( keyData == ( Keys.NumPad1 ) ) //auto section on off
      {
        btnSectionOffAutoOn.PerformClick();
        return true;    // indicate that you handled this keystroke
      }

      if( keyData == ( Keys.G ) ) // Flag click
      {
        btnFlag.PerformClick();
        return true;    // indicate that you handled this keystroke
      }

      // Call the base class
      return base.ProcessCmdKey( ref msg, keyData );
    }
    #endregion
  }
}
