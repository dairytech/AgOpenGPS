namespace AgOpenGPS {
  public class CModuleComm {
    //copy of the mainform address
    private readonly FormGPS mf = null;

    //Critical Safety Properties
    public bool isOutOfBounds = true;

    //RateRelay -------------------------------------

    //AutoSteer -------------------------------------
    public int rawSteer = 0;

    //LIDAR
    //UDP sentence just rec'd
    public string recvUDPSentence = "Inital UDP";

    public int lidarDistance;

    //for the workswitch
    public bool isWorkSwitchActiveLow,
      isWorkSwitchEnabled;

    public int workSwitchValue;

    //imu and roll inclinometer
    public int steerSwitchValue,
      prevGyroHeading = 9999,
      gyroHeading = 9999,
      rollRaw = 9999,
      pitchRaw = 9999; //inclinometer ?

    public byte pedalControl = 0;

    //constructor
    public CModuleComm( FormGPS _f ) {
      mf = _f;

      //WorkSwitch logic
      isWorkSwitchEnabled = false;

      //does a low, grounded out, mean on
      isWorkSwitchActiveLow = true;
    }
  }
}