using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace AgOpenGPS {
  public class COrientation {
    public Quaternion orientation;

    public COrientation() {
      orientation = new Quaternion();
    }

    public COrientation( Quaternion orientation ) {
      this.orientation = orientation;
    }

    public COrientation( float heading, float pitch, float roll ) {
      orientation = Quaternion.CreateFromYawPitchRoll( (float)heading, (float)pitch, (float)roll );
    }

    public Quaternion getQuaternion() {
      return orientation;
    }

    // X: heading, Y: pitch, Z: roll
    public Vector3 toEulerRad() {
      Vector3 euler;

      // if the input quaternion is normalized, this is exactly one. Otherwise, this acts as a correction factor for the quaternion's not-normalizedness
      float unit = ( orientation.X * orientation.X ) + ( orientation.Y * orientation.Y ) + ( orientation.Z * orientation.Z ) + ( orientation.W * orientation.W );

      // this will have a magnitude of 0.5 or greater if and only if this is a singularity case
      float test = orientation.X * orientation.W - orientation.Y * orientation.Z;

      if( test >= 0.5f * unit ) // singularity at north pole
      {
        euler.X = (float)( Math.PI / 2 );
        euler.Y = (float)( 2 * Math.Atan2( orientation.Y, orientation.X ) );
        euler.Z = 0;
      } else if( test <= -0.5f * unit ) // singularity at south pole
        {
        euler.X = -(float)( Math.PI / 2 );
        euler.Y = -(float)( 2 * Math.Atan2( orientation.Y, orientation.X ) );
        euler.Z = 0;
      } else // no singularity - this is the majority of cases
        {
        euler.X = (float)Math.Asin( 2f * ( orientation.W * orientation.X - orientation.Y * orientation.Z ) );
        euler.Y = (float)Math.Atan2( 2f * orientation.W * orientation.Y + 2f * orientation.Z * orientation.X, 1 - 2f * ( orientation.X * orientation.X + orientation.Y * orientation.Y ) );
        euler.Z = (float)Math.Atan2( 2f * orientation.W * orientation.Z + 2f * orientation.X * orientation.Y, 1 - 2f * ( orientation.Z * orientation.Z + orientation.X * orientation.X ) );
      }

      //...and then ensure the degree values are between 0 and 360
      euler.X %= (float)Math.PI * 2;
      euler.Y %= (float)Math.PI * 2;
      euler.Z %= (float)Math.PI * 2;

      return euler;
    }

    public Vector3 toEulerDegrees() {
      Vector3 euler = this.toEulerRad();

      // all the math so far has been done in radians. Before returning, we convert to degrees...
      euler *= 57.295779513082325225835265587528f;

      //...and then ensure the degree values are between 0 and 360
      euler.X %= 360;
      euler.Y %= 360;
      euler.Z %= 360;
      return euler;
    }
  }


  public class CPose {
    // X: norting
    // Y: easting
    public Vector3 position;

    //public double heading;
    //public double pitch;
    //public double roll;

    public COrientation orientation;

    public CPose(
      float northing,
      float easting,
      float height,
      float heading,
      float pitch,
      float roll ) {
      position = new Vector3( northing, easting, height );

      //this.heading = heading;
      //this.pitch = pitch;
      //this.roll = roll;

      orientation = new COrientation( heading, pitch, roll );
    }

    public CPose() {
      position = new Vector3();
      orientation = new COrientation();
      //this.heading = (float)0;
      //this.pitch = (float)0;
      //this.roll = (float)0;
    }

    public float distanceTo( CPose buf ) {
      return System.Numerics.Vector3.Distance( position, buf.position );
    }
  }
}
