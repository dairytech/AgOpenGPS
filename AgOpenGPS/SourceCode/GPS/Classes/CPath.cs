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
    public static void VehicleSteerAngle_AngularVelocityLimit(
      double VehicleWheelbase,
      double VehicleSpeed,
      double VehicleMaxAngularVelocity,
      double VehicleSteerAngle ) {

      //Calculate angular velocity
      //angular velocity in rads/sec = 2PI * m/sec * radians/meters
      double angVel = glm.twoPI * 0.277777 * VehicleSpeed * ( Math.Tan( glm.toRadians( VehicleSteerAngle ) ) ) / VehicleWheelbase;

      //clamp the steering angle to not exceed safe angular velocity
      if( Math.Abs( angVel ) > VehicleMaxAngularVelocity ) {
        VehicleSteerAngle = glm.toDegrees( VehicleSteerAngle > 0 ?
                ( Math.Atan( ( VehicleWheelbase * VehicleMaxAngularVelocity ) / ( glm.twoPI * VehicleSpeed * 0.277777 ) ) )
            : ( Math.Atan( ( VehicleWheelbase * -VehicleMaxAngularVelocity ) / ( glm.twoPI * VehicleSpeed * 0.277777 ) ) ) );
      }
    }

    //Reduces the steering angle, if necessary, to comply with the user supplied maximum steer angle for this vehicle
    public static void VehicleSteerAngle_VehicleLimit(
      double VehicleMaxSteerAngle,
      double VehicleSteerAngle ) {

      if( VehicleSteerAngle < -VehicleMaxSteerAngle )
        VehicleSteerAngle = -VehicleMaxSteerAngle;
      if( VehicleSteerAngle > VehicleMaxSteerAngle )
        VehicleSteerAngle = VehicleMaxSteerAngle;
    }

    //Reduces the displayed turning radius, if necessary, to 500
    public static void VehicleSteeringCircleDisplay_RadiusLimit(
      double DisplayedTurningRadius ) {
      if( DisplayedTurningRadius < -500 )
        DisplayedTurningRadius = -500;
      if( DisplayedTurningRadius > 500 )
        DisplayedTurningRadius = 500;
    }

    //Calculate Turning Radius
    public static double CalculateVehicleTurningRadius(
      vec2 VehicleGoalPoint,
      vec3 VehicleCurrentPoint,
      double VehicleHeading ) {

      double LocalHeading = glm.twoPI - VehicleHeading;
      double EastingDifference = VehicleGoalPoint.easting - VehicleCurrentPoint.easting;
      double NorthingDifference = VehicleGoalPoint.northing - VehicleCurrentPoint.northing;
      double DistanceSquared = Math.Pow( EastingDifference, 2 ) + Math.Pow( NorthingDifference, 2 );

      return DistanceSquared / 2 * ( ( EastingDifference * Math.Cos( LocalHeading ) ) + ( NorthingDifference * Math.Sin( LocalHeading ) ) );
    }
    //Calculate SteeringAngle
    public static double CalculateVehicleSteeringAngle(
      vec2 VehicleGoalPoint,
      vec3 VehicleCurrentPoint,
      double VehicleHeading,
      double VehicleWheelbase ) {

      double LocalHeading = glm.twoPI - VehicleHeading;
      double EastingDifference = VehicleGoalPoint.easting - VehicleCurrentPoint.easting;
      double NorthingDifference = VehicleGoalPoint.northing - VehicleCurrentPoint.northing;
      double DistanceSquared = Math.Pow( EastingDifference, 2 ) + Math.Pow( NorthingDifference, 2 );

      return glm.toDegrees( Math.Atan( 2 * ( ( EastingDifference * Math.Cos( LocalHeading ) ) ) + ( NorthingDifference * Math.Sin( LocalHeading ) ) * VehicleWheelbase / DistanceSquared ) );
    }
    public static vec2 CalculateVehicleTurningRadiusToGoalCenterPoint(  //This function returns the center point of the vehicle's required turning radius to reach the goal point 
      vec3 VehicleCurrentPoint, //This is where we currently are
      double VehicleTurningRadiusToGoal, //TODO: Move to last parameter  //This is the vehicle turning radius required to reach the goal point
      double VehicleHeading ) { //This is measured by vehicle mounted sensors

      vec2 VehicleTurningRadiusCenterPoint = new vec2( 0, 0 );
      double LocalHeading = glm.twoPI - VehicleHeading;

      VehicleTurningRadiusCenterPoint.easting = VehicleCurrentPoint.easting + ( VehicleTurningRadiusToGoal * Math.Cos( LocalHeading ) );
      VehicleTurningRadiusCenterPoint.easting = VehicleCurrentPoint.northing + ( VehicleTurningRadiusToGoal * Math.Sin( LocalHeading ) );

      return VehicleTurningRadiusCenterPoint;
    }

    //Convert the vehicle's absolute distance from the line in meters to the signed distance in centimeters
    public static void CalculateDistanceFromCurrentGuidanceLine(
      double VehicleDistanceFromCurrentGuidanceLine, //pass in the absolute distance in meters, passes out the signed distance in centimeters
      bool IsGuidanceLineHeadingSameAsVehicleHeading,
      bool IsVehicleOnRightSideOfCurrentGuidanceLine ) {

      //Convert distance to centimeters
      VehicleDistanceFromCurrentGuidanceLine = Math.Round( VehicleDistanceFromCurrentGuidanceLine * 1000.0, MidpointRounding.AwayFromZero );

      //Distance is negative if line is to the left of vehicle, positive if line is to the right of vehicle
      if( IsGuidanceLineHeadingSameAsVehicleHeading ) {
        if( !IsVehicleOnRightSideOfCurrentGuidanceLine ) {
          VehicleDistanceFromCurrentGuidanceLine *= -1.0;  //Change distance to negative, line is to the left of the vehicle
        }
      } else {  //If path heading is not same as vehicle heading
        if( IsVehicleOnRightSideOfCurrentGuidanceLine ) {
          VehicleDistanceFromCurrentGuidanceLine *= -1.0;  //Change distance to negative, line is to the left of the vehicle
        }
      }
    }
    public static void PurePursuit(
      vec2 VehicleGoalPoint,  //This is where we want to go
      vec3 VehicleCurrentPoint,  //This is where we currently are
      double VehicleSpeed,  //This is measured by vehicle mounted sensors
      double VehicleHeading,  //This is measured by vehicle mounted sensors
      double VehicleWheelbase,  //This is a vehicle property
      double VehicleMaxSteeringAngle, //This is a vehicle property
      double VehicleMaxAngularVelocity, //This is a user supplied parameter
      bool IsGuidanceLineHeadingSameAsVehicleHeading,  //This is a status variable from the calling function
      bool IsVehicleOnRightSideOfCurrentGuidanceLine,  //This is a status variable from the calling function
      double VehicleTurningRadiusToGoal, //This is one of the values we are calculating
      vec2 VehicleTurningRadiusToGoalCenterPoint, //This is one of the values we are calculating
      double VehicleSteeringAngle, //This is one of the values we are calculating
      double VehicleDistanceFromCurrentGuidanceLine,  //This is one of the values we are calculating
      Int16 VehicleDistanceFromCurrentGuidanceLine_MainForm,  //This is one of the values we are updating for the MainForm
      Int16 VehicleSteeringAngle_MainForm ) {  //This is one of the values we are updating for the MainForm

      //Calculate Turning Radius
      VehicleTurningRadiusToGoal = CalculateVehicleTurningRadius( VehicleGoalPoint, VehicleCurrentPoint, VehicleHeading );

      //Calculate Steering Angle
      VehicleSteeringAngle = CalculateVehicleSteeringAngle( VehicleGoalPoint, VehicleCurrentPoint, VehicleHeading, VehicleWheelbase );

      //Reduce the steering angle, if necessary, to comply with the user supplied maximum steer angle for this vehicle
      VehicleSteerAngle_VehicleLimit( VehicleMaxSteeringAngle, VehicleSteeringAngle );

      //Reduce the radius, if necessary, of the steering circle on the display to 500
      VehicleSteeringCircleDisplay_RadiusLimit( VehicleTurningRadiusToGoal );

      //Calculate Turning Radius Center Point
      VehicleTurningRadiusToGoalCenterPoint = CalculateVehicleTurningRadiusToGoalCenterPoint( VehicleCurrentPoint, VehicleTurningRadiusToGoal, VehicleHeading );

      //Reduce the steering angle, if necessary, to comply with the user supplied maximum angular velocity for this vehicle 
      VehicleSteerAngle_AngularVelocityLimit( VehicleWheelbase, VehicleSpeed, VehicleMaxAngularVelocity, VehicleSteeringAngle );

      //Convert the vehicle's absolute distance from the line in meters to the signed distance in centimeters
      CalculateDistanceFromCurrentGuidanceLine( VehicleDistanceFromCurrentGuidanceLine, IsGuidanceLineHeadingSameAsVehicleHeading, IsVehicleOnRightSideOfCurrentGuidanceLine );

      //Convert these values from Double to Int16 for the main form
      VehicleDistanceFromCurrentGuidanceLine_MainForm = (Int16)VehicleDistanceFromCurrentGuidanceLine;
      VehicleDistanceFromCurrentGuidanceLine_MainForm = (Int16)( VehicleSteeringAngle * 100 );
    }
  }
}