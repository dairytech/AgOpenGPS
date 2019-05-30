using System;
using System.Windows.Forms;

namespace AgOpenGPS {
  public partial class FormTimedMessage : Form {
    //class variables
    //private FormGPS mf = null;

    public FormTimedMessage( int timeInMsec, string str, string str2 ) {
      InitializeComponent();

      //get copy of the calling main form
      //mf = callingForm as FormGPS;

      lblMessage.Text = str;
      lblMessage2.Text = str2;

      timer1.Interval = timeInMsec;

      //str2 is a string that may contain substrings separated by newline characters
      //find the length of the longest substring and use it to set the width of the message box
      Width = FindLongestStringSegmentLength( str2 ) * 15 + 75;
    }

    //for a string composed of substrings separated by newline charaters, return the length of the longest substring
    public int FindLongestStringSegmentLength( string Str ) {
      string[] Substrs = Str.Split( new[] { System.Environment.NewLine }, StringSplitOptions.None );
      int LongestSegmentLength = 0;
      foreach( String Segment in Substrs ) {
        if( Segment.Length > LongestSegmentLength ) {
          LongestSegmentLength = Segment.Length;
        }
      }
      return LongestSegmentLength;
    }
    private void timer1_Tick( object sender, EventArgs e ) {
      Close();
    }
  }
}