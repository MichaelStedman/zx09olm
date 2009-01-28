//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL997 : UvBase
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
readonly UvVar FL_PASSWORDS = 1;
readonly UvVar PASS_PASS = 1;
readonly UvVar PASS_NAME = 2;
readonly UvVar PASS_STATUS = 3;
readonly UvVar PASS_PRIVILEGE = 4;
readonly UvVar PASS_SPECIAL = 5;
readonly UvVar PASS_DEPT = 6;
readonly UvVar PASS_DATE = 7;
readonly UvVar PASS_USER_CHANGED = 8;
readonly UvVar PASS_DATE_CHANGED = 9;
readonly UvVar PASS_TIME_CHANGED = 10;
readonly UvVar PASS_EMAIL_ADDRESS = 11;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] PASS_REC = new UvVar[15];
#endregion
#region Variables
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar EXECUTE_PROG = "";
UvVar PROGRAM = "";
UvVar THEATRE_MD = "";
UvVar LOGTO_ACCOUNT = "";
UvVar CHEAT_REC = "";
UvVar LOGTO_MESSAGE = "";
#endregion
public FL997() {
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
/*  LogThru to TheatreFlex */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROGRAM = "FL997";
PROMPT("");
/*  INCLUDE FILES */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.PASSWORDS

#endregion
if (!OPEN("THEATRE.MD", out THEATRE_MD)) { return; }
/*  INITIALIZE VARIABLES */
if (!READV(ref LOGTO_ACCOUNT, COMMON.FILES[FL_CONTROL], "LOGTO.THEATRE.ACCOUNT", 1)) { return; }
if (!READV(ref COMMON.PASSWORD, COMMON.FILES[FL_PASSWORDS], U_INITS, 1)) { COMMON.PASSWORD = ""; }
/*  WRITE CHEAT TO THEATRE ACCOUNT */
CHEAT_REC = "";
CHEAT_REC[1] = PORT_NUMBER;
CHEAT_REC[2] = U_INITS;
CHEAT_REC[3] = COMMON.PASSWORD[1, 1];
WRITE(CHEAT_REC, THEATRE_MD, "THEATRE.BYPASS");
/*  EXECUTE PROCESS */
LOGTO_MESSAGE = "logto  " + LOGTO_ACCOUNT;
CHAIN(LOGTO_MESSAGE);
/*      CALL @EXECUTE.PROG(LOGTO.MESSAGE,"",RTN.LIST,LIST.AVAILABLE,MESSAGES,OTHERS) */
DATA("_1");
return;
}
}
}
