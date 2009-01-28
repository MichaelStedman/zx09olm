//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_FULL_ADDRESS : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar THIS_CENTRE = "";
UvVar FULL_ADDRESS = "";
#endregion
public FL_FULL_ADDRESS(ref UvVar THIS_CENTRE, ref UvVar FULL_ADDRESS) {
this.THIS_CENTRE = THIS_CENTRE;
this.FULL_ADDRESS = FULL_ADDRESS;
#region INCLUDE FL.COMMON FL.COMMON

// FILES
//    Standard
//    Screen Control
//    Slave Printer Control
//    Special Video
//    User input control
//    Application Specific
//COMMON SC.POS
//    Theatre
//    Standard EQUates
//    Client app control
//\
#region INCLUDE TX.INCLUDE TX.COMMON

#endregion

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
// GETS FULL ADDRESS
if (!(READV(ref FULL_ADDRESS, COMMON.FILES[FL_CONTROL], THIS_CENTRE + "*ADDRESS", 1))) {
//     FULL.ADDRESS = 'Connaught Theatre, Union Place, Worthing, East Sussex BN12 9YH'
FULL_ADDRESS = "FL.CONTROL," + THIS_CENTRE + "*ADDRESS";
}
return;
}
}
}
