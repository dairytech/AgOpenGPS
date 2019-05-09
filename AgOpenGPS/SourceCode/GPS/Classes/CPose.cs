using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace AgOpenGPS {
  class CPose {
    public Vector2 position;
    public Quaternion orientation;

    public CPose( double northing,
      double easting,
      double heading,
      double pitch,
      double roll ) {
      position = new Vector2( (float)northing, (float)easting );
      orientation = Quaternion.CreateFromYawPitchRoll( (float)heading, (float)pitch, (float)roll );
    }
  }
}
