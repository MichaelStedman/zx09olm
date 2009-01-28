//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL810 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_TILL_CONTROL = 91;
readonly UvVar FL_TICKET_FEES = 12;
readonly UvVar TICK_FEES_DESC = 1;
readonly UvVar TICK_FEES_PRICE = 2;
readonly UvVar TICK_FEES_GLCODE = 3;
readonly UvVar TICK_FEES_OFF_PRICES_QUESTION = 4;
readonly UvVar TICK_FEES_OFF_PRICES = 5;
readonly UvVar TICK_FEES_OFF_START_MON = 6;
readonly UvVar TICK_FEES_OFF_FINISH_MON = 7;
readonly UvVar TICK_FEES_OFF_START_SAT = 8;
readonly UvVar TICK_FEES_OFF_FINISH_SAT = 9;
readonly UvVar TICK_FEES_OFF_START_SUN = 10;
readonly UvVar TICK_FEES_OFF_FINISH_SUN = 11;
readonly UvVar TICK_FEES_PRICE_CHANGE_DATE = 12;
readonly UvVar TICK_FEES_NEW_PRICE = 13;
readonly UvVar TICK_FEES_OPEN_RANGE = 14;
readonly UvVar TICK_FEES_CONCESS_QUESTION = 15;
readonly UvVar TICK_FEES_CONCESS_PEAK_DESC = 16;
readonly UvVar TICK_FEES_CONCESS_PEAK_PRICES = 17;
readonly UvVar TICK_FEES_CONCESS_OFF_DESC = 18;
readonly UvVar TICK_FEES_CONCESS_OFF_PRICE = 19;
readonly UvVar TICK_FEES_VAT_QUESTION = 20;
readonly UvVar TICK_FEES_PRICE_LOOKUP = 21;
readonly UvVar TICK_FEES_GROUP_CODE = 22;
readonly UvVar TICK_FEES_HEADCOUNT = 23;
readonly UvVar TICK_FEES_CONCESSIONS = 24;
readonly UvVar TICK_FEES_PEAK_PRICES = 25;
readonly UvVar TICK_FEES_OFF1_PRICES = 26;
readonly UvVar TICK_FEES_OFF2_PRICES = 27;
readonly UvVar TICK_FEES_OFF3_PRICES = 28;
readonly UvVar TICK_FEES_OFF4_PRICES = 29;
readonly UvVar TICK_FEES_SPLIT_OWED = 30;
readonly UvVar TICK_FEES_SPLIT_PAID = 31;
readonly UvVar TICK_FEES_SPORTS = 32;
readonly UvVar TICK_FEES_RESALE_RATE = 33;
readonly UvVar TICK_FEES_GROUP_CODE_2 = 34;
readonly UvVar TICK_FEES_TEXT = 35;
readonly UvVar TICK_FEES_MEMBER_REQ = 36;
readonly UvVar TICK_FEES_STYLE = 37;
readonly UvVar TICK_FEES_GROUPED = 38;
readonly UvVar FL_RECONCILED_TICKETS = 36;
readonly UvVar RECONCIL_TICK_CODE = 1;
readonly UvVar RECONCIL_TICK_UNIT = 2;
readonly UvVar RECONCIL_TICK_UNIT_PRICE = 3;
readonly UvVar RECONCIL_TICK_DATE = 4;
readonly UvVar RECONCIL_TICK_TIME = 5;
readonly UvVar RECONCIL_TICK_TOTAL = 6;
readonly UvVar RECONCIL_TICK_MOP = 7;
readonly UvVar RECONCIL_TICK_CLERK = 8;
readonly UvVar RECONCIL_TICK_TILL = 9;
readonly UvVar RECONCIL_TICK_MEMBER = 10;
readonly UvVar RECONCIL_TICK_CONCESS = 13;
readonly UvVar RECONCIL_TICK_CC_REF = 14;
readonly UvVar RECONCIL_TICK_CC_EXP = 15;
readonly UvVar RECONCIL_TICK_SESSION_NO = 16;
readonly UvVar RECONCIL_TICK_LEDGER = 17;
readonly UvVar RECONCIL_TICK_LEDGER_CODE = 18;
readonly UvVar RECONCIL_TICK_GROUP = 19;
readonly UvVar RECONCIL_TICK_BB_REF = 20;
readonly UvVar RECONCIL_TICK_HCOUNT = 21;
readonly UvVar RECONCIL_TICK_ACT_DATE = 22;
readonly UvVar RECONCIL_TICK_CUST_NAME = 23;
readonly UvVar RECONCIL_TICK_BONUS_PTS = 24;
readonly UvVar RECONCIL_TICK_PROMOTION = 25;
readonly UvVar RECONCIL_TICK_CANCEL = 26;
readonly UvVar RECONCIL_TICK_REDEEMED = 27;
readonly UvVar RECONCIL_POINTS_REDEEMED = 28;
readonly UvVar RECONCIL_SEQNO = 30;
readonly UvVar RECONCIL_SWIPE = 31;
readonly UvVar RECONCIL_ORIGINAL_NO = 32;
readonly UvVar RECONCIL_VAT_IND = 32;
readonly UvVar RECONCIL_HOME_CENTRE = 34;
readonly UvVar RECONCIL_APACS_NO = 36;
readonly UvVar RECONCIL_STUDENT_ID = 37;
readonly UvVar RECONCIL_COURSE_DETAILS_ID = 38;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_TILL_NUMBERS = 14;
readonly UvVar TILL_TILL_NUMBER = 1;
readonly UvVar TILL_LOCATION = 2;
readonly UvVar TILL_TICKET_PRINTER_TYPE = 3;
readonly UvVar TILL_TERMINAL_TYPE = 4;
readonly UvVar TILL_AUDITORIUM_CODE = 5;
readonly UvVar TILL_CASH_DRAWER = 6;
readonly UvVar TILL_TRANS_TICK_PRINT = 7;
readonly UvVar TILL_TICKET_PRINTER_QUE = 8;
readonly UvVar TILL_ACTUAL_PORT = 9;
readonly UvVar TILL_REC_SLIP_PRINT = 10;
readonly UvVar TILL_AMT_TENDERED = 11;
readonly UvVar TILL_POD = 12;
readonly UvVar TILL_ENDORSE_CHEQUE = 13;
readonly UvVar TILL_HOME_LOCATION = 14;
readonly UvVar TILL_MULTIUSER_TOUCHSCREEN = 15;
readonly UvVar TILL_TICKET_PRINTER_INTERFACE = 16;
readonly UvVar TILL_TICKET_PRINTER_NAME = 17;
readonly UvVar TILL_KITCHEN_PRINTER_INTERFACE = 18;
readonly UvVar TILL_KITCHEN_PRINTER_NAME = 19;
readonly UvVar TILL_LOCATION_DESC = 20;
readonly UvVar TILL_THROW_LINES = 21;
readonly UvVar TILL_TICKET_STUB = 22;
readonly UvVar FL_DICT_TICKETS = 63;
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
UvVar[] TICK_FEES_REC = new UvVar[40];
UvVar[] RECONCIL_TICKET_REC = new UvVar[40];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] TILL_REC = new UvVar[25];
UvVar[] PASS_REC = new UvVar[15];
UvVar[] VAT_CONT_REC = new UvVar[2];
#endregion
#region Variables
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar AM = "";
UvVar VM = "";
UvVar EXECUTE_PROG = "";
UvVar PROGRAM = "";
FL000_10 FL000_10;
UvVar MOP_TYPES = "";
UvVar NO_OF_MOPS = "";
UvVar MY_DEPT = "";
UvVar DEPT_REQD = "";
UvVar HOME_LOCATION = "";
UvVar HOME_LOCATION_REQD = "";
UvVar NETT_OR_GROSS = "";
UvVar PRINT_REC = "";
UvVar TOTAL_REC = "";
UvVar VAT_ARRAY = "";
UvVar VAT_TOTAL = "";
UvVar LEDGER_ARRAY = "";
UvVar REC_CNT = "";
UvVar EOF = "";
UvVar EOF1 = "";
UvVar RJ2 = "";
UvVar RJ2_10 = "";
UvVar RJ2_7 = "";
UvVar RJ10 = "";
UvVar LJ2 = "";
UvVar LJ3 = "";
UvVar LJ4 = "";
UvVar LJ5 = "";
UvVar LJ6 = "";
UvVar LJ8 = "";
UvVar LJ12 = "";
UvVar LJ20 = "";
UvVar LJ25 = "";
UvVar VATRATE = "";
UvVar FULLVATCODE = "";
UvVar FORMS = "";
UvVar TICKET_HEAD = "";
UvVar FDATE = "";
UvVar TEST_FDATE = "";
UvVar FIRST_DATE = "";
UvVar PRINT_TYPE = "";
UvVar SSTATEMENT = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar CONTINUE = "";
UvVar TILL_KEY = "";
UvVar TILL_CONTROL_REC = "";
UvVar GLOBAL_REC = "";
UvVar USER_ID = "";
UvVar THIS_TILL = "";
UvVar USER_DEPT = "";
UvVar THIS_HOME = "";
UvVar NO_OF_USERS = "";
UvVar USER_NO = "";
UvVar USER_KEY = "";
UvVar USER_REC = "";
UvVar ADJUST_TOTAL = "";
UvVar ADJUSTMENTS = "";
UvVar SESS = "";
UvVar TILL_NO = "";
UvVar TICK_LIST = "";
UvVar TICK_KEY = "";
UvVar TICK_REC = "";
UvVar TICKET_CENTRE = "";
UvVar TICKET_DATE = "";
UvVar REC_TIME = "";
UvVar TILL_TAKINGS = "";
UvVar MOP_ATTS = "";
UvVar MOP = "";
UvVar MOP_DESC = "";
UvVar PNTR = "";
UvVar NEW_POS = "";
UvVar SLIP_NO = "";
UvVar USER_NAME = "";
UvVar CODE = "";
UvVar VAT_PART = "";
UvVar CONTROL_FEE_CODE = "";
UvVar CONTROL_FEE_REC = "";
UvVar FEE_DATE = "";
UvVar TICKET_CODE = "";
UvVar FULL_GL_CODE = "";
UvVar TEST_GL = "";
UvVar HEADCOUNT_FIGURE = "";
UvVar TEST_HEAD = "";
UvVar VATABLENESS = "";
UvVar TEST_VAT = "";
UvVar POS = "";
UvVar UNIT_PRICE = "";
UvVar UNITS = "";
UvVar CODE_AMT = "";
UvVar TOTAL_AMT = "";
UvVar VAT_POS = "";
UvVar LCODE = "";
UvVar TOT_AM = "";
UvVar TOT_HEAD = "";
UvVar LEDGER = "";
UvVar AMOUNT = "";
UvVar VATTING = "";
UvVar HEADCOUNT = "";
FL000_15_STD FL000_15_STD;
UvVar NO_OF_LINES = "";
UvVar LINE_NO = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
UvVar nrf3 = "";
#endregion
public FL810() {
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
/*  RECONCILIATIONS REPORT */
/* EXEC.FIX 07.08.92 - LBCH */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
PROGRAM = "FL810";
nrf0 = 0;
FL000_10 = new FL000_10(ref PROGRAM, ref nrf0);
/*  Open Files */
#region INCLUDE FL.FILES FL.TILL.CONTROL

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES
#region INCLUDE FL.FILES FL.TICKET.FEES.EQU

#endregion

#region INCLUDE FL.FILES FL.TICKET.FEES.DIM

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.RECONCILED.TICKETS

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.TILL.NUMBERS
#region INCLUDE FL.FILES FL.TILL.NUMBERS.EQU

#endregion

#region INCLUDE FL.FILES FL.TILL.NUMBERS.DIM

#endregion
#region INCLUDE FL.FILES FL.TILL.NUMBERS.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.PASSWORDS

#endregion
/*  Initialize Variables */
if (!(READ(ref MOP_TYPES, COMMON.FILES[FL_DICT_TICKETS], "MOP.TYPES"))) {
MOP_TYPES = "";
MOP_TYPES[1] = "C";
MOP_TYPES[2] = "X";
}
NO_OF_MOPS = DCOUNT(MOP_TYPES, AM);
if (!READV(ref MY_DEPT, COMMON.FILES[FL_PASSWORDS], U_INITS, 6)) { MY_DEPT = ""; }
if (!READV(ref DEPT_REQD, COMMON.FILES[FL_CONTROL], "DEPARTMENT.CONTROL", 1)) { DEPT_REQD = "N"; }
if (MY_DEPT == "*") { DEPT_REQD = "N"; }
/*  Home site */
if (!(READV(ref HOME_LOCATION, COMMON.FILES[FL_TILL_NUMBERS], PORT_NUMBER, 14))) {
HOME_LOCATION = "";
}
if (!(READV(ref HOME_LOCATION_REQD, COMMON.FILES[FL_CONTROL], "HOME.LOCATION.REQD", 1))) {
HOME_LOCATION_REQD = FALSE;
}
if (!READ(ref NETT_OR_GROSS, COMMON.FILES[FL_CONTROL], "NETT.OR.GROSS")) { NETT_OR_GROSS = FALSE; }
PRINT_REC = "";
PRINT_REC[1] = "RECONCILIATION REPORT";
PRINT_REC[2] = "=====================";
PRINT_REC[3] = " ";
TOTAL_REC = "";
VAT_ARRAY = "";
VAT_TOTAL = "";
LEDGER_ARRAY = "";
REC_CNT = 0;
EOF = 0;
EOF1 = 0;
RJ2 = "R#2";
RJ2_10 = "R2#10";
RJ2_7 = "R2#7";
RJ10 = "R#10";
LJ2 = "L#2";
LJ3 = "L#3";
LJ4 = "L#4";
LJ5 = "L#5";
LJ6 = "L#6";
LJ8 = "L#8";
LJ12 = "L#12";
LJ20 = "L#20";
LJ25 = "L#25";
/*      READV VATRATE FROM FL.CONTROL, "VATRATE", 1 ELSE VATRATE = "1750" */
MAT(ref VAT_CONT_REC, "");
if (!(MATREAD(ref VAT_CONT_REC, COMMON.FILES[FL_CONTROL], "VATRATE"))) {
VAT_CONT_REC[1] = "1750";
VAT_CONT_REC[2] = "Y";
}
/*      VAT.ARRAY<1,1> = OCONV(VATRATE,MD2)'R2#6':"%" */
VAT_ARRAY[1, 1] = "VATABLE";
VAT_ARRAY[1, 2] = FORMAT("0%", "R#7");
if (!(READV(ref FULLVATCODE, COMMON.FILES[FL_CONTROL], "FULLVATCODE", 1))) {
FULLVATCODE = "NOTYETSET";
}
TICKET_HEAD = COMMON.CENTRE + "*TICKET.HEAD";
/*  prompt for dates */
PRINT(AT(0, 4) + COMMON.EOS);
PRINT(AT(10, 10) + "Input Date                    " + COMMON.EOL);
PRINT(AT(10, 12) + "(T)icket or (R)eport Printer  " + COMMON.EOL);
do {
PRINT(AT(50, 10) + COMMON.EOL);
PRINT(AT(50, 10));
INPUT(out FDATE, 12);
if (FDATE == "") {
FDATE = OCONV(TODAYS_DATE, COMMON.D2);
}
TEST_FDATE = ICONV(FDATE, COMMON.D2);
if (TEST_FDATE != "" || FDATE == COMMON.ABANDON || FDATE == "") break;
} while (true);
if (FDATE == COMMON.ABANDON || FDATE == "") {
return;
}
FIRST_DATE = OCONV(TEST_FDATE, "D");
PRINTCR(AT(50, 10) + FIRST_DATE);
do {
PRINT(AT(50, 12) + COMMON.EOL);
PRINT(AT(50, 12));
INPUT(out PRINT_TYPE, 2);
if (PRINT_TYPE == "") {
PRINT_TYPE = "T";
}
if (PRINT_TYPE != "T" && PRINT_TYPE != "R" && PRINT_TYPE != COMMON.ABANDON) {
PRINT_TYPE = "";
}
if (PRINT_TYPE != "" || PRINT_TYPE == COMMON.ABANDON) break;
} while (true);
if (PRINT_TYPE == COMMON.ABANDON) {
return;
}
PRINT(AT(50, 12) + PRINT_TYPE);
PRINT(AT(20, 16) + "Please Wait, Producing Report");
SSTATEMENT = "SSELECT FL.TILL.CONTROL WITH 4 = \"" + FIRST_DATE + "\" AND WITH KEY1 = \"SESSION\" AND WITH 7 = \"3\" BY 5";
/*      EXECUTE SSTATEMENT CAPTURING MESSAGES RETURNING OTHERS */
nrf0 = "OS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref SSTATEMENT, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
if (NOT(LIST_AVAILABLE)) {
PRINT(AT(20, 20) + "NO ITEMS PRESENT");
INPUTCR(out CONTINUE, 1);
return;
}
/*      SELECT TO TILL.LIST */
/*  Re-Print Reconciliation Slips & Get Totals */
do {
if (!READNEXT(ref TILL_KEY, 0, 0, RTN_LIST)) { EOF = 1; }
if (EOF) break;
if (!READ(ref TILL_CONTROL_REC, COMMON.FILES[FL_TILL_CONTROL], TILL_KEY)) { TILL_CONTROL_REC = ""; }
GLOBAL_REC = FALSE;
/* * */
/*  PUT IN DEPT CHECK */
/* * */
USER_ID = TILL_CONTROL_REC[1, 1];
THIS_TILL = FIELD(TILL_KEY, ".", 2);
if (!READV(ref USER_DEPT, COMMON.FILES[FL_PASSWORDS], USER_ID, 6)) { USER_DEPT = ""; }
if (DEPT_REQD == "N" || USER_DEPT == MY_DEPT) {
if (!(READV(ref THIS_HOME, COMMON.FILES[FL_TILL_NUMBERS], THIS_TILL, 14))) {
THIS_HOME = "";
}
if (HOME_LOCATION_REQD == FALSE || THIS_HOME == HOME_LOCATION) {
/*  DEPT CHECK END */
NO_OF_USERS = DCOUNT(TILL_CONTROL_REC[1], VM);
for(USER_NO = 1; USER_NO <= NO_OF_USERS; USER_NO += 1) {
if (TILL_CONTROL_REC[2, USER_NO] == "RGZ") {
if (GLOBAL_REC == FALSE) {
GLOBAL_REC = TRUE;
USER_KEY = "USER." + "glb" + FIELD(TILL_KEY, ".", 2) + "." + FIELD(TILL_KEY, ".", 2) + "." + FIELD(TILL_KEY, ".", 3);
if (!READ(ref USER_REC, COMMON.FILES[FL_TILL_CONTROL], USER_KEY)) { USER_REC = ""; }
L0100();
if (USER_REC[22] != "") {
ADJUST_TOTAL = USER_REC[22];
for(ADJUSTMENTS = 1; ADJUSTMENTS <= ADJUST_TOTAL; ADJUSTMENTS += 1) {
USER_KEY = "USER.glb" + FIELD(TILL_KEY, ".", 2) + "." + FIELD(TILL_KEY, ".", 2) + "." + FIELD(TILL_KEY, ".", 3) + "." + ADJUSTMENTS;
if (!READ(ref USER_REC, COMMON.FILES[FL_TILL_CONTROL], USER_KEY)) { USER_REC = ""; }
L0100();
}
}
}
} else {
USER_KEY = "USER." + TILL_CONTROL_REC[1, USER_NO] + "." + FIELD(TILL_KEY, ".", 2) + "." + FIELD(TILL_KEY, ".", 3);
if (!READ(ref USER_REC, COMMON.FILES[FL_TILL_CONTROL], USER_KEY)) { USER_REC = ""; }
L0100();
if (USER_REC[22] != "") {
ADJUST_TOTAL = USER_REC[22];
for(ADJUSTMENTS = 1; ADJUSTMENTS <= ADJUST_TOTAL; ADJUSTMENTS += 1) {
USER_KEY = "USER." + TILL_CONTROL_REC[1, USER_NO] + "." + FIELD(TILL_KEY, ".", 2) + "." + FIELD(TILL_KEY, ".", 3) + "." + ADJUSTMENTS;
if (!READ(ref USER_REC, COMMON.FILES[FL_TILL_CONTROL], USER_KEY)) { USER_REC = ""; }
L0100();
}
}
}
}
/*  Get Tickets */
EOF1 = 0;
SESS = TILL_CONTROL_REC[8];
TILL_NO = FIELD(TILL_KEY, ".", 2);
SSTATEMENT = "SELECT FL.RECONCILED.TICKETS WITH TILL = \"" + TILL_NO + "\" AND WITH 16 = \"" + SESS + "\"";
/*        EXECUTE SSTATEMENT CAPTURING MESSAGES RETURNING OTHERS */
nrf0 = "OS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref SSTATEMENT, ref nrf0, ref TICK_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
if (LIST_AVAILABLE) {
do {
if (!READNEXT(ref TICK_KEY, 0, 0, TICK_LIST)) { EOF1 = 1; }
if (EOF1) break;
if (!READ(ref TICK_REC, COMMON.FILES[FL_RECONCILED_TICKETS], TICK_KEY)) { TICK_REC = ""; }
TICKET_CENTRE = FIELD(TICK_KEY, "/", 1);
TICKET_DATE = FIELD(TICK_KEY, "/", 2);
L0200();
} while (true);
/* * END FOR DEPT CHECK */
}
}
}
} while (true);
/*  Add Total Rec */
L0300();
/*  Print Report */
L0400();
return;
/* ************************************************ */
/*  SUBROUTINES */
/* ************************************************ */
}
void L0100() {
REC_CNT = REC_CNT + 1;
REC_TIME = OCONV(USER_REC[3, 2], "MT");
PRINT_REC[-1] = "USER RECONCILIATION  " + FORMAT(REC_CNT, LJ2);
TILL_TAKINGS = 0;
for(MOP_ATTS = 9; MOP_ATTS <= (NO_OF_MOPS + 9); MOP_ATTS += 1) {
TILL_TAKINGS = TILL_TAKINGS + USER_REC[MOP_ATTS, 3];
}
TOTAL_REC[1] = TOTAL_REC[1] + TILL_TAKINGS;
PRINT_REC[-1] = FORMAT("Nett Till Takings are ", LJ25) + FORMAT(OCONV(TILL_TAKINGS, COMMON.MD2), RJ2_10);
PRINT_REC[-1] = FORMAT("Total Monies input ", LJ25) + FORMAT(OCONV(USER_REC[5], COMMON.MD2), RJ2_10);
TOTAL_REC[2] = TOTAL_REC[2] + USER_REC[5];
PRINT_REC[-1] = FORMAT("Unders/Overs Recorded ", LJ25) + FORMAT(OCONV(USER_REC[4], COMMON.MD2), RJ2_10);
TOTAL_REC[3] = TOTAL_REC[3] + USER_REC[4];
PRINT_REC[-1] = FORMAT("No. of Transactions ", LJ25) + FORMAT(USER_REC[8], RJ10);
TOTAL_REC[4] = TOTAL_REC[4] + USER_REC[8];
for(MOP = 9; MOP <= (NO_OF_MOPS + 9); MOP += 1) {
if (USER_REC[MOP, 2] != "") {
if (!READV(ref MOP_DESC, COMMON.FILES[FL_DICT_TICKETS], USER_REC[MOP, 1], 3)) { MOP_DESC = "Unknown"; }
PRINT_REC[-1] = FORMAT(MOP_DESC, "L#25") + FORMAT(USER_REC[MOP, 2], "R#10");
PRINT_REC[-1] = FORMAT((MOP_DESC + " Takings "), "L#25") + FORMAT(OCONV(USER_REC[MOP, 3], COMMON.MD2), "R2#10");
if (LOCATE(USER_REC[MOP, 1], TOTAL_REC, 5, 0, 1, ref PNTR, "AL")) {
TOTAL_REC[6, PNTR] = TOTAL_REC[6, PNTR] + USER_REC[MOP, 2];
TOTAL_REC[7, PNTR] = TOTAL_REC[7, PNTR] + USER_REC[MOP, 3];
} else {
NEW_POS = DCOUNT(TOTAL_REC[5], AT(VM) + 1);
TOTAL_REC[5, NEW_POS] = USER_REC[MOP, 1];
TOTAL_REC[6, NEW_POS] = USER_REC[MOP, 2];
TOTAL_REC[7, NEW_POS] = USER_REC[MOP, 3];
}
}
}
PRINT_REC[-1] = " ";
SLIP_NO = USER_KEY;
PRINT_REC[-1] = "Slip No. " + SLIP_NO;
PRINT_REC[-1] = FORMAT(("Till " + USER_REC[7]), LJ25);
/*  get users name */
if (!(READV(ref USER_NAME, COMMON.FILES[FL_PASSWORDS], USER_REC[6], 2))) {
USER_NAME = "Unknown";
}
PRINT_REC[-1] = FORMAT(("User " + USER_NAME), LJ25);
PRINT_REC[-1] = FORMAT(("Date " + OCONV(USER_REC[2, 2], "D")), LJ25);
PRINT_REC[-1] = FORMAT(("Time " + OCONV(USER_REC[3, 2], "MT")), LJ25);
PRINT_REC[-1] = " ";
return;
}
void L0200() {
CODE = 1;
do {
if (TICK_REC[1, CODE] == "") break;
VAT_PART = 0;
if (TICK_REC[20] != "") {
CONTROL_FEE_CODE = "CONTROL*" + TICKET_CENTRE + "*" + TICK_REC[20];
} else {
CONTROL_FEE_CODE = "CONTROL*" + TICKET_CENTRE + "*" + TICK_REC[1, CODE];
}
if (!(READ(ref CONTROL_FEE_REC, COMMON.FILES[FL_TICKET_FEES], CONTROL_FEE_CODE))) {
CONTROL_FEE_REC = "";
}
if (LOCATE(TICKET_DATE, CONTROL_FEE_REC, 0, 0, 1, ref PNTR, "AR")) {
FEE_DATE = TICKET_DATE;
} else {
PNTR = PNTR - 1;
if (PNTR <= 0) { PNTR = 1; }
FEE_DATE = CONTROL_FEE_REC[PNTR];
}
if (TICK_REC[20] != "") {
TICKET_CODE = TICKET_CENTRE + "*" + TICK_REC[20] + "*" + FEE_DATE;
} else {
TICKET_CODE = TICKET_CENTRE + "*" + TICK_REC[1, CODE] + "*" + FEE_DATE;
}
if (!(READV(ref FULL_GL_CODE, COMMON.FILES[FL_TICKET_FEES], TICKET_CODE, 3))) {
FULL_GL_CODE = "999999999999";
}
TEST_GL = FULL_GL_CODE[1, CODE];
if (TEST_GL != "") { FULL_GL_CODE = TEST_GL; }
if (!(READV(ref HEADCOUNT_FIGURE, COMMON.FILES[FL_TICKET_FEES], TICKET_CODE, 23))) {
HEADCOUNT_FIGURE = 1;
}
TEST_HEAD = HEADCOUNT_FIGURE[1, CODE];
if (TEST_HEAD != "") { HEADCOUNT_FIGURE = TEST_HEAD; }
if (!(READV(ref VATABLENESS, COMMON.FILES[FL_TICKET_FEES], TICKET_CODE, 20))) {
VATABLENESS = "Y";
}
TEST_VAT = VATABLENESS[1, CODE];
if (TEST_VAT != "") { VATABLENESS = TEST_VAT; }
if (LOCATE(VATABLENESS, VAT_CONT_REC[2], 1, 0, 1, ref POS, "AL")) {
VATRATE = VAT_CONT_REC[1][1, POS];
} else {
if (VATABLENESS == "Y") { VATRATE = VAT_CONT_REC[1]; } else { VATRATE = 0; }
}
if (FULL_GL_CODE == "") { FULL_GL_CODE = "999999999999"; }
UNIT_PRICE = TICK_REC[3, CODE];
UNITS = TICK_REC[2, CODE];
HEADCOUNT_FIGURE = HEADCOUNT_FIGURE * UNITS;
if (NOT(NUM(UNITS))) {
TICK_REC = DELETE(TICK_REC, 1, CODE);
TICK_REC = DELETE(TICK_REC, 2, CODE);
TICK_REC = DELETE(TICK_REC, 3, CODE);
} else {
CODE_AMT = UNIT_PRICE * UNITS;
TOTAL_AMT = CODE_AMT;
/*  Deal with VAT */
VAT_POS = 2;
if (VATABLENESS != "N" && VATABLENESS != "") {
VAT_POS = 1;
/*         ************ */
/*         *REMOVE VAT* */
/*         ************ */
VAT_PART = (CODE_AMT * VATRATE) / (10000 + VATRATE);
/*         ************************* */
/*         *ROUND TO THE NEAREST 1p* */
/*         ************************* */
if (VAT_PART > 0) {
VAT_PART = INT(VAT_PART + 0.5M);
} else {
VAT_PART = INT(VAT_PART - 0.5M);
}
} else {
VAT_PART = 0;
}
VAT_TOTAL = VAT_TOTAL + VAT_PART;
if (LOCATE(FULL_GL_CODE, LEDGER_ARRAY, 1, 0, 1, ref PNTR, "AL")) {
LEDGER_ARRAY[2, PNTR] = LEDGER_ARRAY[2, PNTR] + CODE_AMT;
LEDGER_ARRAY[3, PNTR] = LEDGER_ARRAY[3, PNTR] + VAT_PART;
LEDGER_ARRAY[4, PNTR] = LEDGER_ARRAY[4, PNTR] + HEADCOUNT_FIGURE;
} else {
LEDGER_ARRAY[1, -1] = FULL_GL_CODE;
LEDGER_ARRAY[2, -1] = CODE_AMT;
LEDGER_ARRAY[3, -1] = VAT_PART;
LEDGER_ARRAY[4, -1] = HEADCOUNT_FIGURE;
}
CODE_AMT = CODE_AMT - VAT_PART;
VAT_ARRAY[2, VAT_POS] = VAT_ARRAY[2, VAT_POS] + CODE_AMT;
VAT_ARRAY[3, VAT_POS] = VAT_ARRAY[3, VAT_POS] + VAT_PART;
VAT_ARRAY[4, VAT_POS] = VAT_ARRAY[4, VAT_POS] + TOTAL_AMT;
}
CODE = CODE + 1;
} while (true);
return;
}
void L0300() {
PRINT_REC[-1] = "TOTAL OF RECONCILIATIONS";
PRINT_REC[-1] = " ";
PRINT_REC[-1] = FORMAT("Nett Till Takings are ", LJ25) + FORMAT(OCONV(TOTAL_REC[1], COMMON.MD2), RJ2_10);
PRINT_REC[-1] = FORMAT("Total Monies input ", LJ25) + FORMAT(OCONV(TOTAL_REC[2], COMMON.MD2), RJ2_10);
PRINT_REC[-1] = FORMAT("Unders/Overs Recorded ", LJ25) + FORMAT(OCONV(TOTAL_REC[3], COMMON.MD2), RJ2_10);
PRINT_REC[-1] = FORMAT("No. of Transactions ", LJ25) + FORMAT(TOTAL_REC[4], RJ10);
for(MOP = 1; MOP <= DCOUNT(TOTAL_REC[5], VM); MOP += 1) {
if (!READV(ref MOP_DESC, COMMON.FILES[FL_DICT_TICKETS], TOTAL_REC[5, MOP], 3)) { MOP_DESC = "Unknown"; }
PRINT_REC[-1] = FORMAT(MOP_DESC, "L#25") + FORMAT(TOTAL_REC[6, MOP], "R#10");
PRINT_REC[-1] = FORMAT((MOP_DESC + " Takings "), "L#25") + FORMAT(OCONV(TOTAL_REC[7, MOP], COMMON.MD2), "R2#10");
}
PRINT_REC[-1] = " ";
PRINT_REC[-1] = "VAT ANALYSIS";
PRINT_REC[-1] = " ";
PRINT_REC[-1] = SPACE(8) + VAT_ARRAY[1, 1] + "   " + VAT_ARRAY[1, 2];
PRINT_REC[-1] = " ";
PRINT_REC[-1] = "NETT  " + FORMAT(OCONV(VAT_ARRAY[2, 1], COMMON.MD2), "R2#8") + "  " + FORMAT(OCONV(VAT_ARRAY[2, 2], COMMON.MD2), "R2#8");
PRINT_REC[-1] = "VAT   " + FORMAT(OCONV(VAT_ARRAY[3, 1], COMMON.MD2), "R2#8") + "  " + FORMAT(OCONV(VAT_ARRAY[3, 2], COMMON.MD2), "R2#8");
PRINT_REC[-1] = "TOTAL " + FORMAT(OCONV(VAT_ARRAY[4, 1], COMMON.MD2), "R2#8") + "  " + FORMAT(OCONV(VAT_ARRAY[4, 2], COMMON.MD2), "R2#8");
PRINT_REC[-1] = " ";
PRINT_REC[-1] = "LEDGER ANALYSIS";
PRINT_REC[-1] = " ";
LCODE = 0;
TOT_AM = 0;
TOT_HEAD = 0;
do {
LCODE = LCODE + 1;
LEDGER = LEDGER_ARRAY[1, LCODE];
if (LEDGER == "") break;
if (NETT_OR_GROSS) {
AMOUNT = LEDGER_ARRAY[2, LCODE] - LEDGER_ARRAY[3, LCODE];
} else {
AMOUNT = LEDGER_ARRAY[2, LCODE];
}
VATTING = LEDGER_ARRAY[3, LCODE];
HEADCOUNT = LEDGER_ARRAY[4, LCODE];
TOT_AM = TOT_AM + AMOUNT;
TOT_HEAD = TOT_HEAD + HEADCOUNT;
PRINT_REC[-1] = FORMAT(LEDGER, "L#16");
PRINT_REC[-1] = SPACE(6) + FORMAT(OCONV(AMOUNT, COMMON.MD2), RJ2_7) + " " + FORMAT(OCONV(VATTING, COMMON.MD2), RJ2_7) + " " + FORMAT(HEADCOUNT, "R#4");
} while (true);
PRINT_REC[-1] = " ";
PRINT_REC[-1] = FORMAT(FULLVATCODE, "L#13") + " " + FORMAT(OCONV(VAT_TOTAL, COMMON.MD2), RJ2_7);
PRINT_REC[-1] = " ";
PRINT_REC[-1] = "TOTAL " + FORMAT(OCONV(TOT_AM, COMMON.MD2), RJ2_7) + "         " + FORMAT(TOT_HEAD, "R#4");
return;
}
void L0400() {
/* WRITE LEDGER.ARRAY ON FL.CONTROL, 'LEE.LEDGER' */
if (PRINT_TYPE == "T") {
nrf0 = "";
nrf1 = "";
nrf2 = 2;
nrf3 = 2;
FL000_15_STD = new FL000_15_STD(ref nrf0, ref PRINT_REC, ref TICKET_HEAD, ref nrf1, ref nrf2, ref nrf3);
} else {
PRINT(AT(10, 20));
PRINTER_ON();
PRINTCR(FORMS);
NO_OF_LINES = DCOUNT(PRINT_REC, AM);
for(LINE_NO = 1; LINE_NO <= NO_OF_LINES; LINE_NO += 1) {
PRINTCR(SPACE(6) + PRINT_REC[LINE_NO]);
}
PRINTER_CLOSE();
PRINTER_OFF();
}
return;
/* ********************************* */
/*  END OF PROG */
/* ********************************* */
}
}
}
