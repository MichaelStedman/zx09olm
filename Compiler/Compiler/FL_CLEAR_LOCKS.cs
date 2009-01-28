//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_CLEAR_LOCKS : UvBase
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
UvVar SPECIALS_PASS = "";
UvVar PROGRAM = "";
//FL000_10 FL000_10;
UvVar CLEARLOCK = "";
UvVar ANS = "";
UvVar WAIT = "";
UvVar XX = "";
UvVar YY = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
#endregion
public FL_CLEAR_LOCKS() {
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
if (!READV(ref SPECIALS_PASS, COMMON.FILES[FL_CONTROL], "SPECIALS.PASS", 1)) { SPECIALS_PASS = "SYZYGY"; }
// THIS PROGRAM WILL CLEAR THE FLOOR LOCK
// DANNY HAYES
PROGRAM = "CLEAR.LOCKS";
nrf0 = 0;
//FL000_10 = new FL000_10(ref PROGRAM, ref nrf0);
CLEARLOCK = "CLEAR-FILE DATA FL.FLOOR.LOCK";
PRINTCR(AT(5, 10) + "This process will clear any floor locks that you have");
PRINTCR(AT(5, 12) + "It Is Recommended That All Staff Stop Makings Bookings, During This Process");
PRINT(AT(5, 14) + "Do You Wish To Continue (Y/N) ");
INPUTCR(out ANS, 5);
if (ANS != "Y") {
PRINTCR(AT(5, 16) + "THIS PROCESS HAS BEEN UNSUCCESSFUL !!");
INPUT(out WAIT, 1);
return;
}
PRINT(AT(5, 16) + "Please Enter Password ");
ECHO_OFF();
INPUTCR(out ANS, 12);
ECHO_ON();
if (ANS != SPECIALS_PASS) {
PRINTCR("INCORRECT PASSWORD!!");
INPUT(out WAIT, 1);
return;
}
EXECUTE(CLEARLOCK, XX, string.Empty, string.Empty, YY);
PRINTCR(AT(5, 18) + "FINISHED !!");
PRINTCR(AT(5, 20) + "Floor Lock Has Been Cleared");
INPUT(out WAIT, 1);
}
}
}
