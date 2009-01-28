//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL355 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
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
readonly UvVar FL_TICKET_TIMES = 72;
readonly UvVar TICKET_TIMES_DAY = 1;
readonly UvVar TICKET_TIMES_OFF1 = 2;
readonly UvVar TICKET_TIMES_OFF2 = 3;
readonly UvVar TICKET_TIMES_OFF3 = 4;
readonly UvVar TICKET_TIMES_OFF4 = 5;
readonly UvVar FL_CALENDAR = 30;
readonly UvVar CALENDAR_DAY_CODE = 1;
readonly UvVar CALENDAR_BLOCK_BOOK_FLAG = 2;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] TICK_FEES_REC = new UvVar[40];
UvVar[] TICKET_TIMES_REC = new UvVar[10];
UvVar[] CALENDAR_REC = new UvVar[2];
#endregion
#region Variables
UvVar TICKET_CODE = "";
UvVar TICKET_TYPE = "";
UvVar SALE_DATE = "";
UvVar SALE_TIME = "";
UvVar PRICE = "";
UvVar PERIOD = "";
UvVar RESPONSE = "";
UvVar PROGRAM = "";
UvVar CONTROL_TICKET_CODE = "";
UvVar CONTROL_FEE_REC = "";
UvVar PNTR = "";
UvVar FEE_DATE = "";
UvVar CENTRE_TICKET_CODE = "";
UvVar PERIOD_TYPE = "";
UvVar FIRST_TIME_KEY = "";
UvVar SECOND_TIME_KEY = "";
UvVar DAY_LINE = "";
UvVar OFF_PERIOD = "";
UvVar DOW = "";
UvVar OP_ST = "";
UvVar OP_FN = "";
#endregion
public FL355(ref UvVar TICKET_CODE, ref UvVar TICKET_TYPE, ref UvVar SALE_DATE, ref UvVar SALE_TIME, ref UvVar[] TICK_FEES_REC, ref UvVar PRICE, ref UvVar PERIOD, ref UvVar RESPONSE) {
this.TICKET_CODE = TICKET_CODE;
this.TICKET_TYPE = TICKET_TYPE;
this.SALE_DATE = SALE_DATE;
this.SALE_TIME = SALE_TIME;
this.TICK_FEES_REC = TICK_FEES_REC;
this.PRICE = PRICE;
this.PERIOD = PERIOD;
this.RESPONSE = RESPONSE;
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
/*  Locate Ticket Fees Record */
/*  IMPORTANT: THIS ROUTINE HAS BEEN COPIED FOR USE IN TOUCHSCREENS */
/*             AND INTERNET BOOKINGS. THEREFORE DETAILS OF ANY */
/*             AMENDMENTS MUST BE PASSED ONTO THE RELEVANT PEOPLE */
/*             SO THAT ALL VERSIONS CAN BE KEPT UP TO DATE */
/*  Last updated : 16:33 06/11/92 */
PROGRAM = "FL355";
PROMPT("");
/* ******************************** */
/*  INCLUDE FILES */
/* ******************************** */
#region INCLUDE FL.FILES FL.TICKET.FEES
#region INCLUDE FL.FILES FL.TICKET.FEES.EQU

#endregion

#region INCLUDE FL.FILES FL.TICKET.FEES.DIM

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.TICKET.TIMES

#endregion
#region INCLUDE FL.FILES FL.CALENDAR

#endregion
/* ******************************** */
/*  FIND RECORD */
/* ******************************** */
PERIOD = 1;
RESPONSE = TRUE;
PRICE = "";
CONTROL_TICKET_CODE = "CONTROL*" + COMMON.CENTRE + "*" + TICKET_CODE;
if (!(READ(ref CONTROL_FEE_REC, COMMON.FILES[FL_TICKET_FEES], CONTROL_TICKET_CODE))) {
MAT(ref TICK_FEES_REC, INIT);
RESPONSE = FALSE;
goto L999;
}
if (CONTROL_FEE_REC[1] == "SUS") {
MAT(ref TICK_FEES_REC, INIT);
RESPONSE = 2;
goto L999;
}
if (LOCATE(SALE_DATE, CONTROL_FEE_REC, 0, 0, 1, ref PNTR, "AR")) {
FEE_DATE = SALE_DATE;
} else {
PNTR = PNTR - 1;
if (PNTR <= 0) { PNTR = 1; }
FEE_DATE = CONTROL_FEE_REC[PNTR];
}
if (TICKET_CODE.Substring(1, 2) == "P*") {
CENTRE_TICKET_CODE = FIELD(TICKET_CODE, "*", 1) + "*" + FIELD(TICKET_CODE, "*", 2);
CENTRE_TICKET_CODE = COMMON.CENTRE + "*" + CENTRE_TICKET_CODE + "*" + FEE_DATE;
CENTRE_TICKET_CODE = CENTRE_TICKET_CODE + "*" + FIELD(TICKET_CODE, "*", 3);
} else {
CENTRE_TICKET_CODE = COMMON.CENTRE + "*" + TICKET_CODE + "*" + FEE_DATE;
}
if (!(MATREAD(ref TICK_FEES_REC, COMMON.FILES[FL_TICKET_FEES], CENTRE_TICKET_CODE))) {
MAT(ref TICK_FEES_REC, INIT);
RESPONSE = FALSE;
goto L999;
}
PRICE = TICK_FEES_REC[TICK_FEES_PEAK_PRICES][1, 1];
/* ******************************* */
/*  FIND PERIOD */
/* ******************************* */
// BEGIN CASE
// CASE
if (TICKET_TYPE == "") {
PERIOD_TYPE = "C";
FIRST_TIME_KEY = COMMON.CENTRE + "*" + PERIOD_TYPE + "*" + TICKET_CODE;
}// CASE
else if (TICKET_TYPE == "B") {
PERIOD_TYPE = "B";
if (TICKET_CODE.Substring(1, 1) == "P") {
FIRST_TIME_KEY = COMMON.CENTRE + "*P" + TICKET_CODE.Substring(2, 4);
} else {
FIRST_TIME_KEY = COMMON.CENTRE + "*" + TICKET_CODE;
}
}// CASE
else if (OTHERWISE) {
/*  Off Peak Periods not applicable */
goto L999;
}
// END CASE
/*      FIRST.TIME.KEY = CENTRE:"*":PERIOD.TYPE:"*":TICKET.CODE */
if (!(MATREAD(ref TICKET_TIMES_REC, COMMON.FILES[FL_TICKET_TIMES], FIRST_TIME_KEY))) {
SECOND_TIME_KEY = COMMON.CENTRE + "*" + PERIOD_TYPE;
if (!(MATREAD(ref TICKET_TIMES_REC, COMMON.FILES[FL_TICKET_TIMES], SECOND_TIME_KEY))) {
/*  Still on old system */
L1000();
/*  Look at old concession times on ticket fee record */
goto L999;
}
}
if (!(MATREAD(ref CALENDAR_REC, COMMON.FILES[FL_CALENDAR], COMMON.CENTRE + "*" + SALE_DATE))) {
MAT(ref CALENDAR_REC, "");
}
if (LOCATE(CALENDAR_REC[CALENDAR_DAY_CODE], TICKET_TIMES_REC[TICKET_TIMES_DAY], 1, 0, 1, ref PNTR, "AL")) {
DAY_LINE = PNTR;
} else {
DAY_LINE = 1;
/*  Standard Times */
}
for(OFF_PERIOD = 2; OFF_PERIOD <= 5; OFF_PERIOD += 1) {
if (SALE_TIME >= TICKET_TIMES_REC[OFF_PERIOD][1, DAY_LINE, 1] && SALE_TIME <= TICKET_TIMES_REC[OFF_PERIOD][1, DAY_LINE, 2]) {
/*  This Period */
PERIOD = OFF_PERIOD;
if (TICK_FEES_REC[24 + PERIOD][1, 1] != "") {
PRICE = TICK_FEES_REC[24 + PERIOD][1, 1];
}
goto L999;
}
}
L999:;
/* ** The following code line put in as null causes the ticket program */
/* ** to fall over under certain conditions */
if (PRICE == "") { PRICE = 0; }
return;
/* ******************************************* */
/*  SUBROUTINES */
/* ******************************************* */
}
void L1000() {
/*  Old Off Peak Times Still Apply */
if (TICK_FEES_REC[TICK_FEES_OFF_PRICES_QUESTION] == "Y") {
DOW = MOD(SALE_DATE, 7);
// BEGIN CASE
// CASE
if (DOW == 0) {
/*  SUNDAY */
OP_ST = TICK_FEES_REC[TICK_FEES_OFF_START_SUN];
OP_FN = TICK_FEES_REC[TICK_FEES_OFF_FINISH_SUN];
}// CASE
else if (DOW == 6) {
/*  SATURDAY */
OP_ST = TICK_FEES_REC[TICK_FEES_OFF_START_SAT];
OP_FN = TICK_FEES_REC[TICK_FEES_OFF_FINISH_SAT];
}// CASE
else if (OTHERWISE) {
/*  MONDAY - FRIDAY */
OP_ST = TICK_FEES_REC[TICK_FEES_OFF_START_MON];
OP_FN = TICK_FEES_REC[TICK_FEES_OFF_FINISH_MON];
}
// END CASE
if (SALE_TIME >= OP_ST && SALE_TIME <= OP_FN) {
PRICE = TICK_FEES_REC[TICK_FEES_OFF1_PRICES][1, 1];
PERIOD = 2;
}
}
L1999:;
return;
/* ********************************** */
/*  END OF PROGRAM */
/* ********************************** */
}
}
}
