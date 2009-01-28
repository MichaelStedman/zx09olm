//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL990 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_SCREENS = 8;
readonly UvVar FL_FILES = 52;
readonly UvVar FL_FUNCTION_KEYS = 84;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] FUNCTION_KEYS_REC = new UvVar[32];
#endregion
#region Variables
UvVar SCR = "";
UvVar TRANS_LOG_REC = "";
UvVar TX_ATT = "";
UvVar FPOS = "";
UvVar FIRST_TIME = "";
UvVar SCREEN_KEY = "";
UvVar SCREEN = "";
UvVar LINE = "";
UvVar COLUMN = "";
UvVar CODE = "";
UvVar TEXT = "";
UvVar FKEY = "";
UvVar ATT = "";
FLTX2 FLTX2;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL990(ref UvVar SCR) {
this.SCR = SCR;
#region INCLUDE FL.COMMON FL.COMMON

/*  FILES */
/*     Standard */
/*     Screen Control */
/*     Slave Printer Control */
/*     Special Video */
/*     User input control */
/*     Application Specific */
/* COMMON SC.POS */
/*     Theatre */
/*     Standard EQUates */
/*     Client app control */
/* \ */
#region INCLUDE TX.INCLUDE TX.COMMON

#endregion

#endregion
/*  Resets the function keys for a supplied screen */
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.FUNCTION.KEYS

#endregion
if (!(READ(ref FPOS, COMMON.FILES[FL_FILES], "FPOS"))) {
FPOS = "";
}
FIRST_TIME = 1;
SCREEN_KEY = COMMON.CENTRE + "*" + SCR;
if (!(READ(ref SCREEN, COMMON.FILES[FL_SCREENS], SCREEN_KEY + "*INT"))) {
SCREEN = "";
}
for(LINE = 2; LINE <= 16; LINE += 1) {
for(COLUMN = 1; COLUMN <= 3; COLUMN += 1) {
CODE = SCREEN[LINE, COLUMN, 2];
if (CODE != "") {
TEXT = SCREEN[LINE, COLUMN, 1];
FKEY = FIELD(TEXT, " ", 1);
if (LOCATE(FKEY, FPOS, 0, 0, 1, ref ATT, "AL")) {
if (FIRST_TIME) {
FIRST_TIME = 0;
nrf0 = "D";nrf1 = "FL.FUNCTION.KEYS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref SCREEN_KEY);
}
TRANS_LOG_REC = CODE + "#";
TX_ATT = ATT;
nrf0 = "WV";nrf1 = "FL.FUNCTION.KEYS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref SCREEN_KEY);
}
}
}
}
return;
}
}
}
