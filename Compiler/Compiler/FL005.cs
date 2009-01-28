//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL005 : UvBase
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
UvVar MACHINE_TYPE = "";
UvVar ALL_CLEAR = "";
UvVar PROGRAM = "";
UvVar SERIAL_WORD = "";
UvVar SERIAL = "";
UvVar KEY = "";
#endregion
public FL005() {
#region INCLUDE TX.INCLUDE TX.COMMON

#endregion
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
// CHECK WE'RE ON THE RIGHT MACHINE
PROGRAM = "FL005";
// File used
#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
if (MACHINE_TYPE == "M9000") {
SERIAL_WORD = "KEYWORD";
SERIAL = OCONV(0, "U10DD");
SERIAL = (SERIAL * 7) - 1000000;
if (!(READ(ref KEY, COMMON.FILES[FL_CONTROL], SERIAL_WORD))) {
PRINT(COMMON.WASH);
PRINT();
PRINTCR("SERIAL WORD NOT SET UP");
PRINT();
PRINTCR("Call Flex Systems Ltd");
PRINT();
PRINTCR("0474 537291");
goto L10;
}
if (SERIAL != KEY) { goto L10; }
}
ALL_CLEAR = 1;
goto L50;
L10:
CHAIN("OFF");
STOP();
L50:
return;
}
}
}
