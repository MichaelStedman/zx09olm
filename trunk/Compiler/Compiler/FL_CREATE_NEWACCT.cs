//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_CREATE_NEWACCT : UvBase
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
readonly UvVar FL_SCREENS = 8;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_MENUS = 51;
readonly UvVar MENU_DESC = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] MENUS_REC = new UvVar[50];
UvVar[] PARAM_REC = new UvVar[10];
#endregion
#region Variables
UvVar ACCT_NAME = "";
UvVar ACCT_DESC = "";
UvVar ACCT_CODE = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar FLEX = "";
UvVar SCREEN_CODE = "";
UvVar MD = "";
UvVar NEW_CONTROL = "";
FL006 FL006;
UvVar UV_ACCOUNT_PATH = "";
UvVar BASE_ACCOUNT = "";
UvVar NEW_ACCT = "";
UvVar INSTRUCTION = "";
UvVar ALL_SITES = "";
UvVar PNTR = "";
UvVar MENU_LINE = "";
UvVar MENU_REC = "";
UvVar QFILE = "";
UvVar FILEA = "";
UvVar EOR = "";
UvVar ID = "";
UvVar UV_ACCOUNT = "";
UvVar UV_REC = "";
UvVar UV_QFILE = "";
UvVar ACCT_NAME_LOWER = "";
UvVar QNAME = "";
UvVar QFILES = "";
UvVar FILE = "";
UvVar QREC = "";
UvVar QKEY = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL_CREATE_NEWACCT(ref UvVar ACCT_NAME, ref UvVar ACCT_DESC, ref UvVar ACCT_CODE) {
this.ACCT_NAME = ACCT_NAME;
this.ACCT_DESC = ACCT_DESC;
this.ACCT_CODE = ACCT_CODE;
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
// Create New Account @ HQ from base acct
PROMPT("");
PROGRAM = "CROWN.NEWACCT";
CRT("HERE");
INPUTCR(out FLEX, 1);
SCREEN_CODE = PROGRAM;
//********************************
//  Define Files Used            *
//********************************
#region INCLUDE FL.FILES FL.SCREENS

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.MENUS

#endregion
if (!OPEN("MD", out MD)) { STOP(); }
//*********************************
// Main Process                   *
//*********************************
//* Now Create Account and Do THE WORK
if (!(READ(ref NEW_CONTROL, COMMON.FILES[FL_CONTROL], "NEW.ACCOUNT.CONTROL"))) {
nrf0 = 14;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
UV_ACCOUNT_PATH = NEW_CONTROL[1, 1];
BASE_ACCOUNT = NEW_CONTROL[2, 1] + NEW_CONTROL[3, 1];
NEW_ACCT = NEW_CONTROL[2, 1] + ACCT_NAME;
INSTRUCTION = "DOS /C XCOPY " + BASE_ACCOUNT + " " + NEW_ACCT + " /E /V /C /Q /I /H";
PRINT(AT(15, 15) + "Creating New Account - Please be patient");
//*  First add to the ALL.SITES entry on FL.CONTROL & the Crown front Menu
if (!READ(ref ALL_SITES, COMMON.FILES[FL_CONTROL], "ALL.SITES")) { ALL_SITES = ""; }
if (LOCATE(ACCT_NAME, ALL_SITES, 0, 0, 1, ref PNTR, "AR")) {
nrf0 = 10;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
} else {
ALL_SITES = INSERT(ALL_SITES, PNTR, 0, 0, ACCT_NAME);
WRITE(ALL_SITES, COMMON.FILES[FL_CONTROL], "ALL.SITES");
MENU_LINE = "";
MENU_LINE[1, 1] = ACCT_DESC;
MENU_LINE[1, 2] = "P";
MENU_LINE[1, 3] = "FL992";
MENU_LINE[1, 4] = ACCT_NAME;
if (READ(ref MENU_REC, COMMON.FILES[FL_MENUS], "CROWN")) {
MENU_REC = INSERT(MENU_REC, PNTR + 1, 0, 0, MENU_LINE);
WRITE(MENU_REC, COMMON.FILES[FL_MENUS], "CROWN");
}
}
//*  Dos XCOPY the account
EXECUTE(INSTRUCTION, string.Empty, string.Empty, string.Empty, string.Empty);
//* Set up  the Centres Record and the Till number entries
QFILE[1] = "Q";
QFILE[2] = ACCT_NAME;
QFILE[3] = "FL.CENTRES";
WRITE(QFILE, MD, "NEWACCT.QFILE");
if (OPEN("NEWACCT.QFILE", out FILEA)) {
WRITE(ACCT_DESC, FILEA, ACCT_CODE);
} else {
nrf0 = 11;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
QFILE[3] = "FL.TILL.NUMBERS";
WRITE(QFILE, MD, "NEWACCT.QFILE");
if (OPEN("NEWACCT.QFILE", out FILEA)) {
EXECUTE("SELECT  NEWACCT.QFILE # '[PORT]'", string.Empty, string.Empty, string.Empty, string.Empty);
EOR = "";
L20:
do {
if (!READNEXT(ref ID, 0, 0, "")) { EOR = "E"; }
if (EOR == "E") break;
WRITEV(ACCT_CODE, FILEA, ID, 2);
} while (true);
}
//* Set up UV.ACCOUNT entries in Upper & Lower
UV_REC = "";
UV_REC[8] = ACCT_DESC;
UV_REC[11] = NEW_ACCT;
UV_QFILE[1] = "F";
UV_QFILE[2] = UV_ACCOUNT_PATH;
UV_QFILE[3] = UV_ACCOUNT_PATH;
WRITE(UV_QFILE, MD, "UV.ACCOUNT.QFILE");
if (OPEN("UV.ACCOUNT.QFILE", out UV_ACCOUNT)) {
WRITE(UV_REC, UV_ACCOUNT, ACCT_NAME);
ACCT_NAME_LOWER = OCONV(ACCT_NAME, "MCL");
WRITE(UV_REC, UV_ACCOUNT, ACCT_NAME_LOWER);
}
//* Amend Qpointers
QFILE[3] = "MD";
WRITE(QFILE, MD, "NEWACCT.QFILE");
if (OPEN("NEWACCT.QFILE", out FILEA)) {
QNAME = "";
QFILES = "";
QFILES[1] = "FLP";
QNAME[1] = "LFLEX.PROGS";
QFILES[2] = "ENQ";
QNAME[2] = "FL.AD.HOC.ENQUIRIES";
QFILES[3] = "TN";
QNAME[3] = "FL.TILL.NUMBERS";
QFILES[4] = "FUP";
QNAME[4] = "FL.USER.PROGS";
FILE = 1;
do {
if (QFILES[FILE] == "") break;
QREC = "";
QKEY = QFILES[FILE];
QREC[1] = "Q";
QREC[2] = ACCT_NAME;
QREC[3] = QNAME[FILE];
WRITE(QREC, FILEA, QKEY);
FILE = FILE + 1;
} while (true);
}
CRT("DONE");
INPUTCR(out FLEX, 1);
return;
//*********************
//  End               *
//*********************
}
}
}
