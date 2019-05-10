using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace AgOpenGPS {
  public class CPose {
    // X: norting
    // Y: easting
    public Vector3 position;

    public double heading;
    public double pitch;
    public double roll;

    public Quaternion orientation;

    public CPose(
      double northing,
      double easting,
      double height,
      double heading,
      double pitch,
      double roll ) {
      position = new Vector3( (float)northing, (float)easting, (float)height );

      this.heading = heading;
      this.pitch = pitch;
      this.roll = roll;

      orientation = Quaternion.CreateFromYawPitchRoll( (float)heading, (float)pitch, (float)roll );
    }

    public CPose() {
      position = new Vector3();
      orientation = new Quaternion();
      this.heading = (float)0;
      this.pitch = (float)0;
      this.roll = (float)0;
    }
  }
}
