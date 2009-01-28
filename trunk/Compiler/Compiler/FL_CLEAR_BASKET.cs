//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_CLEAR_BASKET : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar VALID_DATA = 0;
readonly UvVar EXIT = 2;
readonly UvVar BACKUP = 3;
readonly UvVar INVALID_DATA = 5;
readonly UvVar FINISH = 6;
readonly UvVar LIMIT = 4;
readonly UvVar FL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar TILL_NUMBER = "";
UvVar VM = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar FL_MULTIPAY = "";
UvVar MULTIPAY_REC = "";
UvVar TRANS_COUNT = "";
UvVar SUPP_ID = "";
#endregion
public FL_CLEAR_BASKET() {
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
//    CLEAR SHOPPING BASKET AT SIGN ON
PROMPT("");
PROGRAM = "FL.CLEAR.BASKET";
SCREEN_CODE = PROGRAM;
//********************************
//  Define Files Used            *
//********************************
#region INCLUDE FL.FILES FL.MULTIPAY
if (!OPEN("FL.MULTIPAY", out FL_MULTIPAY)) { STOP("201", "FL.MULTIPAY"); }

#endregion
//************************************
//  Main Processing Section          *
//************************************
if (READU(ref MULTIPAY_REC, FL_MULTIPAY, TILL_NUMBER)) {
TRANS_COUNT = DCOUNT(MULTIPAY_REC[3], VM);
for(COMMON.X = 1; COMMON.X <= TRANS_COUNT; COMMON.X += 1) {
SUPP_ID = TILL_NUMBER + "*" + MULTIPAY_REC[1, COMMON.X] + "*" + MULTIPAY_REC[2, COMMON.X] + "*" + MULTIPAY_REC[3, COMMON.X];
DELETE(FL_MULTIPAY, SUPP_ID);
}
DELETE(FL_MULTIPAY, TILL_NUMBER);
}
return;
}
}
}
