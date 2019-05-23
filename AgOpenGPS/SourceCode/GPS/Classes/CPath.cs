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
    public static void SteerAngle_AngularVelocityLimit(
      double VehicleWheelbase,
      double VehicleSpeed,
      double MaxAngularVelocity,
      double SteerAngle ) {
      
      //Calculate angular velocity
      //angular velocity in rads/sec = 2PI * m/sec * radians/meters
      double angVel = glm.twoPI * 0.277777 * VehicleSpeed * ( Math.Tan( glm.toRadians( SteerAngle ) ) ) / VehicleWheelbase;

      //clamp the steering angle to not exceed safe angular velocity
      if( Math.Abs( angVel ) > MaxAngularVelocity ) {
        SteerAngle = glm.toDegrees( SteerAngle > 0 ?
                ( Math.Atan( ( VehicleWheelbase * MaxAngularVelocity ) / ( glm.twoPI * VehicleSpeed * 0.277777 ) ) )
            : ( Math.Atan( ( VehicleWheelbase * -MaxAngularVelocity ) / ( glm.twoPI * VehicleSpeed * 0.277777 ) ) ) );
      }
    }
    
    //Reduces the steering angle, if necessary, to comply with the user supplied maximum steer angle for this vehicle
    public static void SteerAngle_VehicleLimit(
      double MaxSteerAngle,
      double SteerAngle ) {

      if( SteerAngle < -MaxSteerAngle )
        SteerAngle = -MaxSteerAngle;
      if( SteerAngle > MaxSteerAngle )
        SteerAngle = MaxSteerAngle;
    }

    //Reduces the displayed turning radius, if necessary, to 500
    public static void SteeringCircleDisplay_RadiusLimit(
      double DisplayedTurningRadius ) {
      if( DisplayedTurningRadius < -500 )
        DisplayedTurningRadius = -500;
      if( DisplayedTurningRadius > 500 )
        DisplayedTurningRadius = 500;
    }

    //Calculate Turning Radius
    public static double CalculateTurningRadius(
      vec2 GoalPoint,
      vec3 CurrentPoint,
      double VehicleHeading) {

      double LocalHeading = glm.twoPI - VehicleHeading;
      double EastingDifference = GoalPoint.easting - CurrentPoint.easting;
      double NorthingDifference = GoalPoint.northing - CurrentPoint.northing;
      double DistanceSquared = Math.Pow( EastingDifference, 2 ) + Math.Pow( NorthingDifference, 2 );

      return DistanceSquared / 2 * ( ( EastingDifference * Math.Cos( LocalHeading ) ) + ( NorthingDifference * Math.Sin( LocalHeading ) ) );
    }
    //Calculate SteeringAngle
    public static double CalculateSteeringAngle(
      vec2 GoalPoint,
      vec3 CurrentPoint,
      double VehicleHeading,
      double VehicleWheelbase ) {

      double LocalHeading = glm.twoPI - VehicleHeading;
      double EastingDifference = GoalPoint.easting - CurrentPoint.easting;
      double NorthingDifference = GoalPoint.northing - CurrentPoint.northing;
      double DistanceSquared = Math.Pow( EastingDifference, 2 ) + Math.Pow( NorthingDifference, 2 );

      return glm.toDegrees( Math.Atan( 2 * ( ( EastingDifference * Math.Cos( LocalHeading ) ) ) + ( NorthingDifference * Math.Sin( LocalHeading ) ) * VehicleWheelbase / DistanceSquared ));
    }
    public static vec2 CalculateTurningRadiusCenterPoint(
      vec3 VehiclePoint,
      double TurningRadius,
      double VehicleHeading ) {

      vec2 CenterPoint = new vec2( 0, 0 );
      double LocalHeading = glm.twoPI - VehicleHeading;

      CenterPoint.easting = VehiclePoint.easting + ( TurningRadius * Math.Cos( LocalHeading ) );
      CenterPoint.easting = VehiclePoint.northing + ( TurningRadius * Math.Sin( LocalHeading ) );

      return CenterPoint;
    }
    }
}
