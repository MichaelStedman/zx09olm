//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL000_21 : UvBase
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
readonly UvVar VALID_DATA = 0;
readonly UvVar EXIT = 2;
readonly UvVar BACKUP = 3;
readonly UvVar ERROR = 7;
readonly UvVar INVALID_DATA = 5;
readonly UvVar FINISH = 6;
readonly UvVar LIMIT = 4;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar MEMBER_NUMBER = "";
UvVar SEARCH_ROUTE = "";
UvVar LAST_SURNAME = "";
UvVar INTERACT = "";
UvVar MACHINE_TYPE = "";
UvVar PROGRAM = "";
UvVar FL_QUICK_INDEX = "";
FL_QUICK_REBUILD FL_QUICK_REBUILD;
UvVar SURNAME_LIST = "";
UvVar KEYJUST = "";
UvVar REQD_SURNAME = "";
UvVar EXECUTE_PROG = "";
UvVar OPTION_SELECTED = "";
FL_WINDOW FL_WINDOW;
UvVar REQD_NAME = "";
UvVar OPTION_LIST = "";
UvVar LAST_POS = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL000_21(ref UvVar MEMBER_NUMBER, ref UvVar SEARCH_ROUTE, ref UvVar LAST_SURNAME, ref UvVar INTERACT) {
this.MEMBER_NUMBER = MEMBER_NUMBER;
this.SEARCH_ROUTE = SEARCH_ROUTE;
this.LAST_SURNAME = LAST_SURNAME;
this.INTERACT = INTERACT;
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
/*  PROGRAM TO ALLOW SEARCH ON EXPIRED MEMBERSHIPS (TWELLS) */
/*  Created on 15th March 2001 by RT */
#region INCLUDE FL.FILES FL.QUICK.INDEX

if (!(OPEN("FL.QUICK.INDEX", out FL_QUICK_INDEX))) {
EXECUTE("CREATE-FILE FL.QUICK.INDEX 1 401", string.Empty, string.Empty, string.Empty, string.Empty);
FL_QUICK_REBUILD = new FL_QUICK_REBUILD();
if (!OPEN("FL.QUICK.INDEX", out FL_QUICK_INDEX)) { STOP(201, "FL.QUICK.INDEX"); }
}

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
SURNAME_LIST = "";
KEYJUST = "L#8";
REQD_SURNAME = "";
PROGRAM = "FL000.21";
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
/*      SSTATEMENT = "SSELECT FL.QUICK.INDEX" */
/*      CALL @EXECUTE.PROG(SSTATEMENT,"OS",RTN.LIST,LIST.AVAILABLE,MESSAGES,OTHERS) */
/*      IF LIST.AVAILABLE THEN */
/*         DONE = FALSE */
/*         LOOP */
/*            READNEXT SURNAME FROM RTN.LIST ELSE DONE = TRUE */
/*            UNTIL DONE DO */
/*            SURNAME.LIST<-1,2> = SURNAME */
/*         REPEAT */
if (READ(ref SURNAME_LIST, FL_QUICK_INDEX, "SURNAME.LIST")) {
do {
OPTION_SELECTED = LAST_SURNAME;
nrf0 = "";
nrf1 = "";
FL_WINDOW = new FL_WINDOW(ref PROGRAM, ref SURNAME_LIST, ref OPTION_SELECTED, ref nrf0, ref nrf1, ref INTERACT);
LAST_SURNAME = OPTION_SELECTED;
if (INTERACT == COMMON.ABANDON) {
MEMBER_NUMBER = "";
return;
}
REQD_NAME = SURNAME_LIST[OPTION_SELECTED, 2];
if (READ(ref OPTION_LIST, FL_QUICK_INDEX, REQD_NAME)) {
LAST_POS = 1;
OPTION_SELECTED = LAST_POS;
nrf0 = REQD_NAME + " ";
FL_WINDOW = new FL_WINDOW(ref PROGRAM, ref OPTION_LIST, ref OPTION_SELECTED, ref nrf0, ref KEYJUST, ref INTERACT);
LAST_POS = OPTION_SELECTED;
MEMBER_NUMBER = OPTION_LIST[OPTION_SELECTED, 1];
if (INTERACT != COMMON.ABANDON) {
return;
}
INTERACT = INIT;
/* RESET */
}
if (INTERACT == COMMON.ABANDON) break;
} while (true);
} else {
INTERACT = ERROR;
}
return;
}
}
}
