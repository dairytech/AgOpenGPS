using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgOpenGPS.Classes {
  /// <summary>
  /// This class contains all of the methods used to follow paths (lines)
  /// </summary>
  class CPath {
    //Reduces the steering angle, if necessary, to comply with the user supplied maximum angular velocity for this vehicle 
    public static void VelocityLimitSteerAngle(
      double wheelbase,
      double speed,
      double maxAngularVelocity,
      double steerAngle ) {
      //Calculate angular velocity
      //angular velocity in rads/sec = 2PI * m/sec * radians/meters
      double angVel = glm.twoPI * 0.277777 * speed * ( Math.Tan( glm.toRadians( steerAngle ) ) ) / wheelbase;
     
      //clamp the steering angle to not exceed safe angular velocity
      if( Math.Abs( angVel ) > maxAngularVelocity ) {
        steerAngle = glm.toDegrees( steerAngle > 0 ?
                ( Math.Atan( ( wheelbase * maxAngularVelocity ) / ( glm.twoPI * speed * 0.277777 ) ) )
            : ( Math.Atan( ( wheelbase * -maxAngularVelocity ) / ( glm.twoPI * speed * 0.277777 ) ) ) );
      }
      return;
    }
  }
}
