
# AgOpenGPS  ****  Guidance software

https://agopengps.jimdosite.com/

Discussed in detail http://www.thecombineforum.com/forums/31-technology/278810-agopengps.html

*** Important ****

This software is for discussion and learning of Precision Ag
algorithms and techniques. It is not in any way to be used on
any physical equipment and is meant for use by a simulator only.

Any use of AgOpenGPS on real physical equipment is not allowed
and is not recommended in any way, neither off road or on road. 

It is completely unsafe and has no safety limits built in or implied.

AgOpenGPS is strictly an example of C# programming for
demonstration purposes only and shall not be used for any other purpose.


Ag Precision Mapping and Section Control Software

This software reads NMEA strings for the purpose of recording and mapping position information 
for Agricultural use. Also it has up to 12 sections of Section Control to control implements application of product
preventing over-application.

Also ouputs Pure pursuit steer angles from reference line for AB line, AB Curve and Contour guidance. Auto Headland called UTurn on Curve 
and AB Line with loops for narrow equipment

Included is an application, and source folders, ino's for steering and rate control and a built in NMEA simulators. 

It has English, German, Spanish, French, italian, Dutch and Russian Language - But haven't been updated in far too long.

# development/building

First you have to generate a certificate. To do this, you right-click on the project in the project-view
and go to "signing". There you click on the button to generate a test certificate. If this doesn't
work ("Access Denied"), you have to make the folder "C:\ProgramData\Microsoft\Crypto\RSA\MachineKeys"
writable by you user (right click on the folder -> settings -> sercurity -> change it).

Then you to the menu "Build" and choose the point "Publish". Execute the published application.
