//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL000_4 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar TILLS = 14;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar PORT_NUMBER = "";
UvVar ALL_CLEAR = "";
UvVar TILL_NUMBER = "";
UvVar PROGRAM = "";
UvVar TILL_REC = "";
FL006 FL006;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL000_4() {
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
// GET THE TERMINAL NUMBER & ALLOCATES THE TILL NUMBER
PROGRAM = "FL000.4";
//*********************************
//   FILES USED IN THIS PROCESS   *
//*********************************
if (!(READ(ref TILL_REC, COMMON.FILES[TILLS], PORT_NUMBER))) {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
ALL_CLEAR = 0;
goto L10;
}
TILL_NUMBER = TILL_REC[1];
COMMON.CENTRE = TILL_REC[2];
ALL_CLEAR = 1;
L10:
// THE END
return;
}
}
}
