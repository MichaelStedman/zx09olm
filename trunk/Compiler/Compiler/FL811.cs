//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL811 : UvBase
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
UvVar[] PASS_REC = new UvVar[15];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar AM = "";
UvVar EXECUTE_PROG = "";
UvVar PROGRAM = "";
UvVar PRINT_REC = "";
UvVar TOTAL_REC = "";
UvVar VAT_ARRAY = "";
UvVar VAT_TOTAL = "";
UvVar CODE_ARRAY = "";
UvVar SPECIALS_ARRAY = "";
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
UvVar FORMS = "";
UvVar TICKET_HEAD = "";
UvVar PRINT_TYPE = "";
UvVar DATE_REQ = "";
UvVar SSTATEMENT = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar OTHERS = "";
UvVar MESSAGES = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar TICK_KEY = "";
UvVar TICK_REC = "";
UvVar TICKET_CENTRE = "";
UvVar TICKET_DATE = "";
UvVar CODE = "";
UvVar CONTROL_FEE_CODE = "";
UvVar CONTROL_FEE_REC = "";
UvVar PNTR = "";
UvVar FEE_DATE = "";
UvVar TICKET_CODE = "";
UvVar TKT_CODE = "";
UvVar TEST_HEAD = "";
UvVar TICKET_FEES_HEADCOUNT = "";
UvVar UNIT_PRICE = "";
UvVar UNITS = "";
UvVar CODE_AMT = "";
UvVar TOTAL_AMT = "";
UvVar POS = "";
UvVar ATT = "";
UvVar LCODE = "";
UvVar TOT_AM = "";
UvVar TOT_UNITS = "";
UvVar TOT_HEAD = "";
UvVar TOT_NEG = "";
UvVar TOT_NEG_UNITS = "";
UvVar AMOUNT = "";
UvVar TKT_UNITS = "";
UvVar HEADCOUNT = "";
UvVar NEG_AMT = "";
UvVar NEG_UNITS = "";
UvVar DESC = "";
FL000_15_STD FL000_15_STD;
UvVar NO_OF_LINES = "";
UvVar LINE_NO = "";
UvVar FLEX = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
UvVar nrf3 = "";
#endregion
public FL811() {
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
PROGRAM = "FL811";
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
#region INCLUDE FL.FILES FL.PASSWORDS

#endregion
/*  Initialize Variables */
PRINT_REC = "";
PRINT_REC[1] = " ";
PRINT_REC[2] = "RECONCILIATION REPORT";
PRINT_REC[3] = "=====================";
PRINT_REC[4] = " ";
TOTAL_REC = "";
VAT_ARRAY = "";
VAT_TOTAL = "";
CODE_ARRAY = "";
SPECIALS_ARRAY = "";
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
TICKET_HEAD = COMMON.CENTRE + "*TICKET.HEAD";
/*  Prompt for print destination */
PRINT(AT(0, 4) + COMMON.EOS);
PRINT(AT(10, 12) + "(T)icket or (R)eport Printer  " + COMMON.EOL);
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
DATE_REQ = OCONV(TODAYS_DATE, "D");
SSTATEMENT = "SELECT FL.RECONCILED.TICKETS WITH USER \"" + U_INITS + "\" AND WITH DATE \"" + DATE_REQ + "\"";
nrf0 = "OS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref SSTATEMENT, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHERS, ref MESSAGES);
if (LIST_AVAILABLE) {
do {
if (!READNEXT(ref TICK_KEY, 0, 0, RTN_LIST)) { EOF1 = 1; }
if (EOF1) break;
if (!READ(ref TICK_REC, COMMON.FILES[FL_RECONCILED_TICKETS], TICK_KEY)) { TICK_REC = ""; }
TICKET_CENTRE = FIELD(TICK_KEY, "/", 1);
TICKET_DATE = FIELD(TICK_KEY, "/", 2);
L0200();
} while (true);
}
/*  Add Total Rec */
L0300();
/*  Print Report */
L0400();
return;
/* ************************************************ */
/*  SUBROUTINES */
/* ************************************************ */
}
void L0200() {
CODE = 1;
do {
if (TICK_REC[1, CODE] == "") break;
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
TKT_CODE = TICK_REC[20];
} else {
TICKET_CODE = TICKET_CENTRE + "*" + TICK_REC[1, CODE] + "*" + FEE_DATE;
TKT_CODE = TICK_REC[1, CODE];
}
if (!(MATREAD(ref TICK_FEES_REC, COMMON.FILES[FL_TICKET_FEES], TICKET_CODE))) {
MAT(ref TICK_FEES_REC, "");
}
TEST_HEAD = TICK_FEES_REC[TICK_FEES_HEADCOUNT][1, CODE];
if (TEST_HEAD != "") { TICKET_FEES_HEADCOUNT = TEST_HEAD; }
UNIT_PRICE = TICK_REC[3, CODE];
UNITS = TICK_REC[2, CODE];
TICK_FEES_REC[TICK_FEES_HEADCOUNT] = TICK_FEES_REC[TICK_FEES_HEADCOUNT] * UNITS;
if (NOT(NUM(UNITS))) {
TICK_REC = DELETE(TICK_REC, 1, CODE);
TICK_REC = DELETE(TICK_REC, 2, CODE);
TICK_REC = DELETE(TICK_REC, 3, CODE);
} else {
CODE_AMT = UNIT_PRICE * UNITS;
TOTAL_AMT = CODE_AMT;
}
if (CODE_AMT < 0) {
POS = 4;
} else {
POS = 0;
}
if (!(LOCATE(TKT_CODE, CODE_ARRAY, 1, 0, 1, ref PNTR, "AR"))) {
CODE_ARRAY = INSERT(CODE_ARRAY, 1, PNTR, 0, TICK_REC[1, CODE]);
CODE_ARRAY = INSERT(CODE_ARRAY, 5, PNTR, 0, TICK_FEES_REC[TICK_FEES_DESC]);
for(ATT = 2; ATT <= 8; ATT += 1) {
if (ATT != 5) {
CODE_ARRAY = INSERT(CODE_ARRAY, ATT, PNTR, 0, "");
}
}
}
CODE_ARRAY[POS + 2, PNTR] = CODE_ARRAY[POS + 2, PNTR] + CODE_AMT;
CODE_ARRAY[POS + 3, PNTR] = CODE_ARRAY[POS + 3, PNTR] + UNITS;
CODE_ARRAY[POS + 4, PNTR] = CODE_ARRAY[POS + 4, PNTR] + TICK_FEES_REC[TICK_FEES_HEADCOUNT];
CODE = CODE + 1;
} while (true);
return;
}
void L0300() {
PRINT_REC[-1] = "CODE ANALYSIS";
PRINT_REC[-1] = " ";
LCODE = 0;
TOT_AM = 0;
TOT_UNITS = 0;
TOT_HEAD = 0;
TOT_NEG = 0;
TOT_NEG_UNITS = 0;
do {
LCODE = LCODE + 1;
CODE = CODE_ARRAY[1, LCODE];
if (CODE == "") break;
AMOUNT = CODE_ARRAY[2, LCODE];
TKT_UNITS = CODE_ARRAY[3, LCODE];
HEADCOUNT = CODE_ARRAY[4, LCODE];
NEG_AMT = CODE_ARRAY[6, LCODE];
NEG_UNITS = CODE_ARRAY[7, LCODE];
DESC = CODE_ARRAY[5, LCODE];
TOT_AM = TOT_AM + AMOUNT;
TOT_UNITS = TOT_UNITS + TKT_UNITS;
TOT_HEAD = TOT_HEAD + HEADCOUNT;
TOT_NEG = TOT_NEG + NEG_AMT;
TOT_NEG_UNITS = TOT_NEG_UNITS + NEG_UNITS;
PRINT_REC[-1] = FORMAT(DESC, "L#16");
PRINT_REC[-1] = SPACE(3) + FORMAT(OCONV(AMOUNT, COMMON.MD2), RJ2_7) + " " + FORMAT(TKT_UNITS, "R#6") + " " + FORMAT(OCONV(NEG_AMT, COMMON.MD2), "R#8") + FORMAT(NEG_UNITS, "R#6");
} while (true);
PRINT_REC[-1] = "TOTAL";
PRINT_REC[-1] = SPACE(3) + FORMAT(OCONV(TOT_AM, COMMON.MD2), RJ2_7) + " " + FORMAT(TOT_UNITS, "R#6") + " " + FORMAT(OCONV(TOT_NEG, COMMON.MD2), "R#8") + FORMAT(TOT_NEG_UNITS, "R#6");
PRINT_REC[-1] = " ";
PRINT_REC[-1] = " ";
PRINT_REC[-1] = " ";
PRINT_REC[-1] = " ";
PRINT_REC[-1] = " ";
PRINT_REC[-1] = " ";
return;
}
void L0400() {
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
PRINT(AT(20, 18) + "REPORT FINISHED - PRESS RETURN");
INPUT(out FLEX, 1);
}
return;
/* ********************************* */
/*  END OF PROG */
/* ********************************* */
}
}
}
