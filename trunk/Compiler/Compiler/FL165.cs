//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL165 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar PROMOTION_START_DATE = 1;
readonly UvVar PROMOTION_END_DATE = 2;
readonly UvVar PROMOTION_TYPE = 3;
readonly UvVar PROMOTION_PARTICIPANTS = 4;
readonly UvVar PROMOTION_MEM_TYPES = 5;
readonly UvVar PROMOTION_BONUS_LEVELS = 6;
readonly UvVar PROMOTION_REWARD = 7;
readonly UvVar PROMOTION_DISCOUNT = 8;
readonly UvVar BONUS_PROMOTION = 1;
readonly UvVar BONUS_START_DATE = 2;
readonly UvVar BONUS_END_DATE = 3;
readonly UvVar BONUS_PTS_WTS = 4;
readonly UvVar BONUS_FIXED_PTS = 5;
readonly UvVar BONUS_VALUE = 6;
readonly UvVar BONUS_CONCESSIONS = 7;
readonly UvVar BONUS_PEAK = 8;
readonly UvVar BONUS_OFF1 = 9;
readonly UvVar BONUS_OFF2 = 10;
readonly UvVar BONUS_OFF3 = 11;
readonly UvVar BONUS_OFF4 = 12;
readonly UvVar LOST_MEMBER = 1;
readonly UvVar LOST_SCHEME = 2;
readonly UvVar LOST_DATE_JOINED = 3;
readonly UvVar LOST_MONTH = 4;
readonly UvVar LOST_POINTS = 5;
readonly UvVar LOST_SPEND = 6;
readonly UvVar LOST_REDEEMED = 7;
readonly UvVar LOST_VALUE_REDEEMED = 8;
readonly UvVar LOST_NET_POINTS = 9;
readonly UvVar BONUS_MEMBER = 1;
readonly UvVar BONUS_SCHEME = 2;
readonly UvVar BONUS_DATE_JOINED = 3;
readonly UvVar BONUS_MONTH = 4;
readonly UvVar BONUS_POINTS = 5;
readonly UvVar BONUS_SPEND = 6;
readonly UvVar BONUS_REDEEMED = 7;
readonly UvVar BONUS_VALUE_REDEEMED = 8;
readonly UvVar BONUS_NET_POINTS = 9;
readonly UvVar BONUS_LAST_ALLOCATION_DATE = 10;
readonly UvVar BONUS_LAST_ALLOCATION_TIME = 11;
readonly UvVar BONUS_DECLINED_REDEMPTIONS = 12;
readonly UvVar FL_MEMBERS = 2;
readonly UvVar MEMBER_CENTRE = 1;
readonly UvVar MEMBER_TYPE = 2;
readonly UvVar MEMBER_ORIG_PRICE = 3;
readonly UvVar MEMBER_SURNAMES = 4;
readonly UvVar MEMBER_INITIALS = 5;
readonly UvVar MEMBER_TITLES = 6;
readonly UvVar MEMBER_SEXES = 7;
readonly UvVar MEMBER_AGES = 8;
readonly UvVar MEMBER_RENEW_LETTER = 9;
readonly UvVar MEMBER_SALUTATION = 9;
readonly UvVar MEMBER_ADDRESS = 10;
readonly UvVar MEMBER_HOME_PHONE = 11;
readonly UvVar MEMBER_BUS_PHONE = 12;
readonly UvVar MEMBER_EXPIRY_DATE = 13;
readonly UvVar MEMBER_DATE_JOINED = 14;
readonly UvVar MEMBER_ISSUING_OPER = 15;
readonly UvVar MEMBER_ANALYSIS_CODES = 16;
readonly UvVar MEMBER_USED_CODES = 17;
readonly UvVar MEMBER_MAIN = 18;
readonly UvVar MEMBER_SUB = 19;
readonly UvVar MEMBER_RECEIPT = 20;
readonly UvVar MEMBER_DOBS = 21;
readonly UvVar MEMBER_LAST_CHANGED = 22;
readonly UvVar MEMBER_HF_CARD_DATE = 23;
readonly UvVar MEMBER_INSTALMENTS = 24;
readonly UvVar MEMBER_FULL_EXPIRY = 25;
readonly UvVar MEMBER_REMINDER_DATES = 26;
readonly UvVar MEMBER_RESTRICTIONS = 27;
readonly UvVar MEMBER_DIRECT_DEBIT = 28;
readonly UvVar MEMBER_FORENAMES = 29;
readonly UvVar MEMBER_COMMENTS = 30;
readonly UvVar MEMBER_PART_COMPLETE = 31;
readonly UvVar MEMBER_START_DATE = 32;
readonly UvVar MEMBER_RENEWAL_DATE = 33;
readonly UvVar MEMBER_DD_DAY = 34;
readonly UvVar MEMBER_PRICES = 35;
readonly UvVar MEMBER_WEB_BARRED = 36;
readonly UvVar MEMBER_EMAIL_ADDRESS = 37;
readonly UvVar MEMBER_EMAIL_SALES = 38;
readonly UvVar MEMBER_DDFLAGS = 39;
readonly UvVar MEMBER_OLDNOS = 40;
readonly UvVar MEMBER_PROSPECT_NO = 41;
readonly UvVar MEMBER_APACS_NO = 42;
readonly UvVar MEMBER_MOBILE_PHONE = 43;
readonly UvVar MEMBER_JOB_TITLE = 44;
readonly UvVar MEMBER_DEPARTMENT = 45;
readonly UvVar FL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] PROMOTION_REC = new UvVar[10];
UvVar[] BONUS_CONTROL_REC = new UvVar[40];
UvVar[] BONUS_LOST_REC = new UvVar[40];
UvVar[] BONUS_REC = new UvVar[40];
UvVar[] MEMBERS_REC = new UvVar[45];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] NARRATIVES = new UvVar[999];
#endregion
#region Variables
UvVar TICK_REC = "";
UvVar SALE_DATE = "";
UvVar PERIOD = "";
UvVar CALL_REF = "";
UvVar TODAYS_DATE = "";
UvVar REV_VID = "";
UvVar NRM_VID = "";
UvVar DIM_REV_UND_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar BONUS = "";
UvVar THIS = "";
UvVar PROGRAM = "";
UvVar FL_PROMOTIONS = "";
UvVar FL_BONUS_CONTROL = "";
UvVar FL_BONUS_LOST = "";
UvVar FL_BONUS = "";
UvVar SIZE_OF_MEMBERS_REC = "";
UvVar BONUS_ALLOCATION_PROG = "";
CallAt_BONUS_ALLOCATION_PROG CallAt_BONUS_ALLOCATION_PROG;
UvVar REPLY = "";
UvVar STAND = "";
UvVar LJUST = "";
UvVar RJUST = "";
UvVar DEFAULT_COLOR = "";
UvVar THIS_ONE = "";
UvVar SECOND_NO = "";
UvVar FIRST_NUMBER = "";
UvVar NEXT_NUMBER = "";
UvVar PRINT_NUMBER = "";
UvVar NOT_JOINED = "";
UvVar BONUS_TOTAL = "";
UvVar SPEND_TOTAL = "";
UvVar CODE_CNT = "";
UvVar TICK_CODE = "";
UvVar START_DATES = "";
UvVar TICK_MEMBER = "";
UvVar TICK_CONCESS = "";
UvVar TICK_AMOUNT = "";
UvVar TICK_UNIT = "";
UvVar GROUP_ID = "";
UvVar GROUP_REC = "";
UvVar EOR_GROUP = "";
UvVar GROUP_COUNT = "";
UvVar PNTR = "";
UvVar SCHEME_NO = "";
UvVar MASTER_CODE = "";
UvVar CONTROL_BONUS_ID = "";
UvVar CONTROL_DATES = "";
UvVar BONUS_DATE = "";
UvVar BONUS_ID = "";
FL006 FL006;
UvVar MEM_TYPE = "";
UvVar CHECK_ID = "";
UvVar CHECK_REC = "";
UvVar CHOOSE = "";
UvVar CONCESSION = "";
UvVar LINE_NUMBER = "";
UvVar MULTIVALUE_NO = "";
UvVar MAX_CONCESSION = "";
UvVar TICKET_CONCESS = "";
UvVar COLOR_ON = "";
UvVar END_NARR = "";
UvVar BEG_NARR = "";
UvVar DEF_POS = "";
UvVar MONTH = "";
UvVar POS = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL165(ref UvVar TICK_REC, ref UvVar SALE_DATE, ref UvVar PERIOD, ref UvVar CALL_REF) {
this.TICK_REC = TICK_REC;
this.SALE_DATE = SALE_DATE;
this.PERIOD = PERIOD;
this.CALL_REF = CALL_REF;
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
/*  GET BONUS POINTS FOR ACTIVITY */
/* ******************************************************** */
/*  IMPORTANT: A COPY OF THIS PROGRAM HAS BEEN TAKEN FOR  * */
/*             USE WITH TOUCHSCREENS. IF ANY AMENDMENTS   * */
/*             ARE MADE PLEASE LET THE RELEVANT PEOPLE    * */
/*             KNOW SO THAT BOTH VERSIONS CAN BE KEPT IN  * */
/*             LINE                                       * */
/* ******************************************************** */
PROGRAM = "FL165";
/*  Files */
#region INCLUDE FL.FILES FL.PROMOTIONS
#region INCLUDE FL.FILES FL.PROMOTIONS.EQU
if (!OPEN("FL.PROMOTIONS", out FL_PROMOTIONS)) { STOP("201", "FL.PROMOTIONS"); }

#endregion

#region INCLUDE FL.FILES FL.PROMOTIONS.DIM

#endregion
#region INCLUDE FL.FILES FL.PROMOTIONS.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.BONUS.CONTROL
#region INCLUDE FL.FILES FL.BONUS.CONTROL.EQU
if (!OPEN("FL.BONUS.CONTROL", out FL_BONUS_CONTROL)) { STOP("201", "GGGGG.BONUS.CONTROL"); }

#endregion

#region INCLUDE FL.FILES FL.BONUS.CONTROL.DIM

#endregion
#region INCLUDE FL.FILES FL.BONUS.CONTROL.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.BONUS.LOST
#region INCLUDE FL.FILES FL.BONUS.LOST.EQU
if (!OPEN("FL.BONUS.LOST", out FL_BONUS_LOST)) { STOP("201", "FL.BONUS.LOST"); }

#endregion

#region INCLUDE FL.FILES FL.BONUS.LOST.DIM

#endregion
#region INCLUDE FL.FILES FL.BONUS.LOST.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.BONUS
#region INCLUDE FL.FILES FL.BONUS.EQU
if (!OPEN("FL.BONUS", out FL_BONUS)) { STOP("201", "FL.BONUS"); }

#endregion

#region INCLUDE FL.FILES FL.BONUS.DIM

#endregion
#region INCLUDE FL.FILES FL.BONUS.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.MEMBERS

/*  DJA 14.8.01 Separate file includes for web bookings */
/*              (see FL.MEMBERS.VAR for field names) */
#region INCLUDE FL.FILES FL.MEMBERS.EQU

#endregion
#region INCLUDE FL.FILES FL.MEMBERS.DIM

SIZE_OF_MEMBERS_REC = 45;
/*  Must keep in tandem */

#endregion
#region INCLUDE FL.FILES FL.MEMBERS.VAR

/*  Hammersmith & Fulham - Membership Card production systems */
/*  Two tier reminder system */

#endregion

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
/*  Variables */
if (!(READV(ref BONUS_ALLOCATION_PROG, COMMON.FILES[FL_CONTROL], "PROMOTIONS.CONTROL", 3))) {
BONUS_ALLOCATION_PROG = "FL165";
}
if (BONUS_ALLOCATION_PROG != "FL165" && BONUS_ALLOCATION_PROG != "") {
CallAt_BONUS_ALLOCATION_PROG = new CallAt_BONUS_ALLOCATION_PROG(ref BONUS_ALLOCATION_PROG, ref TICK_REC, ref SALE_DATE, ref PERIOD, ref CALL_REF);
return;
}
REPLY = "OK";
STAND = 1;
LJUST = "L#5";
RJUST = "R2#5";
MAT(ref NARRATIVES, "");
DEFAULT_COLOR = DIM_REV_UND_VID;
THIS_ONE = REV_VID;
SECOND_NO = FALSE;
PROMPT("");
FIRST_NUMBER = 1;
NEXT_NUMBER = 5;
PRINT_NUMBER = 0;
NOT_JOINED = FALSE;
MAT(ref BONUS_CONTROL_REC, "");
/*      For Each Activity  Establish Relevant Bonus Record */
if (TICK_REC[10] == "") {
return;
}
BONUS_TOTAL = 0;
SPEND_TOTAL = 0;
CODE_CNT = 1;
do {
TICK_CODE = TICK_REC[1, CODE_CNT];
MAT(ref BONUS_CONTROL_REC, "");
START_DATES = "";
if (TICK_CODE == "") break;
TICK_MEMBER = TICK_REC[10, CODE_CNT];
if (TICK_MEMBER == "") {
goto L0050;
/*  Next Ticket Code */
}
TICK_CONCESS = TICK_REC[13, CODE_CNT];
TICK_AMOUNT = TICK_REC[3, CODE_CNT];
TICK_UNIT = TICK_REC[2, CODE_CNT];
PERIOD = TICK_REC[11, CODE_CNT];
GROUP_ID = "GROUP*" + TICK_CODE;
if (READ(ref GROUP_REC, FL_BONUS_CONTROL, GROUP_ID)) {
EOR_GROUP = FALSE;
GROUP_COUNT = 1;
do {
START_DATES[-1] = GROUP_REC[GROUP_COUNT, 2];
GROUP_COUNT = GROUP_COUNT + 1;
if (GROUP_REC[GROUP_COUNT] == "") { EOR_GROUP = TRUE; }
if (START_DATES == "") { goto L0050; /*  Next Ticket Code */ }
} while (true);
if (LOCATE(SALE_DATE, START_DATES, 0, 0, 1, ref PNTR, "AR")) {
SCHEME_NO = PNTR;
} else {
PNTR = PNTR - 1;
if (PNTR < 1) { PNTR = 1; }
SCHEME_NO = PNTR;
}
MASTER_CODE = GROUP_REC[SCHEME_NO, 1];
} else {
MASTER_CODE = TICK_CODE;
}
CONTROL_BONUS_ID = "CONTROL*" + COMMON.CENTRE + "*" + MASTER_CODE;
if (READ(ref CONTROL_DATES, FL_BONUS_CONTROL, CONTROL_BONUS_ID)) {
if (LOCATE(SALE_DATE, CONTROL_DATES, 0, 0, 1, ref PNTR, "AR")) {
BONUS_DATE = SALE_DATE;
} else {
PNTR = PNTR - 1;
if (PNTR < 1) { PNTR = 1; }
BONUS_DATE = CONTROL_DATES[PNTR];
}
BONUS_ID = COMMON.CENTRE + "*" + MASTER_CODE + "*" + BONUS_DATE;
if (!(MATREAD(ref BONUS_CONTROL_REC, FL_BONUS_CONTROL, BONUS_ID))) {
goto L0050;
/*  Next Ticket Code */
}
} else {
goto L0050;
/*  Next Ticket Code */
}
if (SALE_DATE > BONUS_CONTROL_REC[BONUS_END_DATE] || SALE_DATE < BONUS_CONTROL_REC[BONUS_START_DATE]) {
goto L0050;
/*  Next Ticket Code */
}
/*  Establish points according to Payment Concession */
if (!(MATREAD(ref PROMOTION_REC, FL_PROMOTIONS, BONUS_CONTROL_REC[BONUS_PROMOTION]))) {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
goto L0050;
/*  Next Ticket Code */
}
// BEGIN CASE
// CASE
if (PROMOTION_REC[PROMOTION_PARTICIPANTS] == "A" && PROMOTION_REC[PROMOTION_MEM_TYPES] == "") {
}// CASE
else if (PROMOTION_REC[PROMOTION_PARTICIPANTS] == "A" && PROMOTION_REC[PROMOTION_MEM_TYPES] != "") {
if (!READV(ref MEM_TYPE, COMMON.FILES[FL_MEMBERS], TICK_MEMBER, 2)) { MEM_TYPE = ""; }
if (!(LOCATE(MEM_TYPE, PROMOTION_REC[PROMOTION_MEM_TYPES], 1, 0, 1, ref PNTR, "AL"))) {
goto L0050;
/*  Next Ticket Code */
}
}// CASE
else if (PROMOTION_REC[PROMOTION_PARTICIPANTS] == "C" && PROMOTION_REC[PROMOTION_MEM_TYPES] == "") {
CHECK_ID = TICK_MEMBER + "*" + BONUS_CONTROL_REC[BONUS_PROMOTION];
NOT_JOINED = FALSE;
if (!(READ(ref CHECK_REC, FL_BONUS, CHECK_ID))) {
NOT_JOINED = TRUE;
}
}// CASE
else if (PROMOTION_REC[PROMOTION_PARTICIPANTS] == "C" && PROMOTION_REC[PROMOTION_MEM_TYPES] != "") {
if (!READV(ref MEM_TYPE, COMMON.FILES[FL_MEMBERS], TICK_MEMBER, 2)) { MEM_TYPE = ""; }
if (LOCATE(MEM_TYPE, PROMOTION_REC[PROMOTION_MEM_TYPES], 1, 0, 1, ref PNTR, "AL")) {
CHECK_ID = TICK_MEMBER + "*" + BONUS_CONTROL_REC[BONUS_PROMOTION];
NOT_JOINED = FALSE;
if (!(READ(ref CHECK_REC, FL_BONUS, CHECK_ID))) {
NOT_JOINED = TRUE;
}
} else {
goto L0050;
/*  Next Ticket Code */
}
}
// END CASE
/* CRT @(0,0):'BONUS.FIXED.PTS = ':BONUS.FIXED.PTS:;INPUT FLEX,1: */
// BEGIN CASE
// CASE
if (BONUS_CONTROL_REC[BONUS_FIXED_PTS] != "") {
BONUS = BONUS_CONTROL_REC[BONUS_FIXED_PTS];
}// CASE
else if (OTHERWISE) {
if (LOCATE(TICK_CONCESS, BONUS_CONTROL_REC[BONUS_CONCESSIONS], 1, 0, 1, ref PNTR, "AL")) {
BONUS = BONUS_CONTROL_REC[7 + PERIOD][1, PNTR];
} else {
L0100();
/*  GET USER TO CHOOSE POINTS */
}
}
// END CASE
if (BONUS_CONTROL_REC[BONUS_PTS_WTS] == "W") {
if (BONUS_CONTROL_REC[BONUS_VALUE] != "") {
BONUS = BONUS * BONUS_CONTROL_REC[BONUS_VALUE];
} else {
BONUS = BONUS * TICK_AMOUNT;
}
}
BONUS = BONUS * TICK_UNIT;
/* CRT @(0,0):'TICK.UNIT = ':TICK.UNIT:;INPUT FLEX,1: */
if (TICK_AMOUNT < 0 || CALL_REF.Substring(1, 1) == "M") {
BONUS = 0 - BONUS;
}
if (BONUS != "" && BONUS != 0) {
TICK_REC[24, CODE_CNT] = BONUS;
TICK_REC[25, CODE_CNT] = BONUS_CONTROL_REC[BONUS_PROMOTION];
if (CALL_REF.Substring(1, 1) == "M") {
SPEND_TOTAL = SPEND_TOTAL - (TICK_REC[2, CODE_CNT] * TICK_REC[3, CODE_CNT]);
} else {
SPEND_TOTAL = SPEND_TOTAL + (TICK_REC[2, CODE_CNT] * TICK_REC[3, CODE_CNT]);
}
}
BONUS_TOTAL = BONUS_TOTAL + BONUS;
L0300();
L0050:;
CODE_CNT = CODE_CNT + 1;
BONUS = 0;
SPEND_TOTAL = 0;
} while (true);
L9999:;
/*      PRINT @(0,22):NRM.VID:SPACE(21): */
/*      PRINT @(0,23): SCREEN.BACK: SCREEN.DATA: EOL: */
return;
/* ********************************************************************* */
/*  SUBROUTINES */
/* ********************************************************************* */
}
void L0100() {
/*  ASK USER IF WANT TO USE STANDARD OR CONCESSION POINTS */
LINE_NUMBER = 23;
CHOOSE = " ";
/*  FIND OUT HOW MANY CONCESSIONS THERE ARE, ADD 1 FOR STANDARD * */
PRINT(AT(0, LINE_NUMBER) + SCREEN_BACK + SCREEN_DATA + COMMON.EOL);
MULTIVALUE_NO = 0;
MAX_CONCESSION = 0;
do {
MULTIVALUE_NO = MULTIVALUE_NO + 1;
if (BONUS_CONTROL_REC[BONUS_CONCESSIONS][1, MULTIVALUE_NO] == "") break;
if (BONUS_CONTROL_REC[7 + PERIOD][1, MULTIVALUE_NO] != "") {
BONUS = BONUS_CONTROL_REC[7 + PERIOD][1, MULTIVALUE_NO];
MAX_CONCESSION = MAX_CONCESSION + 1;
NARRATIVES[MAX_CONCESSION] = FORMAT(BONUS_CONTROL_REC[BONUS_CONCESSIONS][1, MULTIVALUE_NO], "L#7") + BONUS;
}
} while (true);
if (MAX_CONCESSION == 1) {
TICKET_CONCESS = BONUS_CONTROL_REC[BONUS_CONCESSIONS][1, 1];
BONUS = BONUS_CONTROL_REC[7 + PERIOD][1, 1];
return;
}
L0200:;
/*  DISPLAY THE OPTIONS */
PRINT(AT(0, LINE_NUMBER - 1) + "Bonus Points for " + TICK_CODE);
PRINT(AT(0, LINE_NUMBER) + SCREEN_BACK + SCREEN_DATA + COMMON.EOL);
for(CONCESSION = 1; CONCESSION <= 5; CONCESSION += 1) {
PRINT_NUMBER = PRINT_NUMBER + 1;
if (CONCESSION == 1) {
COLOR_ON = THIS_ONE;
} else {
COLOR_ON = DEFAULT_COLOR;
}
if (NARRATIVES[PRINT_NUMBER] != "") {
END_NARR = (14 * CONCESSION) + 2;
BEG_NARR = (14 * (CONCESSION - 1)) + 2;
PRINT(AT(END_NARR, LINE_NUMBER) + NRM_VID);
PRINT(AT(BEG_NARR, LINE_NUMBER) + NRM_VID);
PRINT(AT(BEG_NARR, LINE_NUMBER) + COLOR_ON);
PRINT(AT(BEG_NARR + 1, LINE_NUMBER) + NARRATIVES[PRINT_NUMBER]);
}
}
PRINT(AT(2, LINE_NUMBER));
BEG_NARR = 2;
THIS = 0;
do {
ECHO_OFF();
INPUT(out CHOOSE, 1);
ECHO_ON();
if (CHOOSE == REPLY) break;
/*  ABANDON DO */
// BEGIN CASE
// CASE
if (CHOOSE == "") {
/*  YES PLEASE */
TICKET_CONCESS = NARRATIVES[FIRST_NUMBER + THIS][1].Substring(1, 7);
TICKET_CONCESS = TRIM(TICKET_CONCESS);
BONUS = NARRATIVES[FIRST_NUMBER + THIS][1].Substring(8, 99);
BONUS = TRIM(BONUS);
PRINT(AT(0, LINE_NUMBER) + COMMON.EOL);
return;
}// CASE
else if (CHOOSE == "6" || CHOOSE == "R") {
/*  NEXT PRICE BAND */
DEF_POS = THIS;
THIS = THIS + 1;
if (NARRATIVES[FIRST_NUMBER + THIS] == "" || THIS >= 5) {
THIS = 0;
}
END_NARR = (14 * DEF_POS) + 2;
BEG_NARR = (14 * THIS) + 2;
PRINT(AT(END_NARR, LINE_NUMBER) + NRM_VID);
PRINT(AT(END_NARR, LINE_NUMBER) + DEFAULT_COLOR + AT(END_NARR + 1, LINE_NUMBER) + NARRATIVES[FIRST_NUMBER + DEF_POS]);
/* DEFAULT.COLOR: */
PRINT(AT(BEG_NARR, LINE_NUMBER) + THIS_ONE + AT(BEG_NARR + 1, LINE_NUMBER) + NARRATIVES[FIRST_NUMBER + THIS]);
/* THIS.ONE: */
PRINT(AT(BEG_NARR, LINE_NUMBER));
}// CASE
else if (CHOOSE == "4" || CHOOSE == "L") {
/*  NEXT PRICE BAND */
DEF_POS = THIS;
THIS = THIS - 1;
if (THIS < 0) {
THIS = 4;
if (NARRATIVES[FIRST_NUMBER + THIS] == "") {
do {
THIS = THIS - 1;
if (NARRATIVES[FIRST_NUMBER + THIS] != "") break;
} while (true);
}
}
END_NARR = (14 * DEF_POS) + 2;
BEG_NARR = (14 * THIS) + 2;
PRINT(AT(END_NARR, LINE_NUMBER) + NRM_VID);
PRINT(AT(END_NARR, LINE_NUMBER) + DEFAULT_COLOR + AT(END_NARR + 1, LINE_NUMBER) + NARRATIVES[FIRST_NUMBER + DEF_POS]);
/* DEFAULT.COLOR: */
PRINT(AT(BEG_NARR, LINE_NUMBER) + THIS_ONE + AT(BEG_NARR + 1, LINE_NUMBER) + NARRATIVES[FIRST_NUMBER + THIS]);
/* THIS.ONE: */
PRINT(AT(BEG_NARR, LINE_NUMBER));
}// CASE
else if (CHOOSE == "N") {
/*  NEXT LINE */
DEF_POS = THIS;
if (NEXT_NUMBER + 1 <= MAX_CONCESSION) {
NEXT_NUMBER = NEXT_NUMBER + 5;
FIRST_NUMBER = FIRST_NUMBER + 5;
} else {
NEXT_NUMBER = 5;
FIRST_NUMBER = 1;
PRINT_NUMBER = 0;
}
THIS = 0;
goto L0200;
}// CASE
else if (CHOOSE == COMMON.ABANDON) {
return;
}// CASE
else if (OTHERWISE) {
PRINT(AT(BEG_NARR, LINE_NUMBER) + " ");
PRINT(AT(BEG_NARR, LINE_NUMBER) + THIS_ONE);
/* THIS.ONE: */
PRINT(AT(BEG_NARR, LINE_NUMBER));
}
// END CASE
} while (true);
return;
}
void L0300() {
/*  Update Members Bonus Record */
BONUS_ID = TICK_MEMBER + "*" + BONUS_CONTROL_REC[BONUS_PROMOTION];
if (NOT_JOINED) {
if (!(MATREAD(ref BONUS_REC, FL_BONUS_LOST, BONUS_ID))) {
MAT(ref BONUS_REC, "");
BONUS_REC[BONUS_MEMBER] = TICK_MEMBER;
BONUS_REC[BONUS_SCHEME] = BONUS_CONTROL_REC[BONUS_PROMOTION];
BONUS_REC[BONUS_DATE_JOINED] = TODAYS_DATE;
}
} else {
if (!(MATREAD(ref BONUS_REC, FL_BONUS, BONUS_ID))) {
MAT(ref BONUS_REC, "");
BONUS_REC[BONUS_MEMBER] = TICK_MEMBER;
BONUS_REC[BONUS_SCHEME] = BONUS_CONTROL_REC[BONUS_PROMOTION];
BONUS_REC[BONUS_DATE_JOINED] = TODAYS_DATE;
}
}
MONTH = OCONV(TODAYS_DATE, "DY") + FORMAT(OCONV(TODAYS_DATE, "DM"), "R%2");
if (!(LOCATE(MONTH, BONUS_REC[BONUS_MONTH], 1, 0, 1, ref POS, "AR"))) {
BONUS_REC[BONUS_MONTH] = INSERT(BONUS_REC[BONUS_MONTH], 1, POS, 0, MONTH);
BONUS_REC[BONUS_POINTS] = INSERT(BONUS_REC[BONUS_POINTS], 1, POS, 0, "");
BONUS_REC[BONUS_SPEND] = INSERT(BONUS_REC[BONUS_SPEND], 1, POS, 0, "");
BONUS_REC[BONUS_REDEEMED] = INSERT(BONUS_REC[BONUS_REDEEMED], 1, POS, 0, "");
BONUS_REC[BONUS_VALUE_REDEEMED] = INSERT(BONUS_REC[BONUS_VALUE_REDEEMED], 1, POS, 0, "");
}
BONUS_REC[BONUS_POINTS][1, POS] = BONUS_REC[BONUS_POINTS][1, POS] + BONUS;
BONUS_REC[BONUS_SPEND][1, POS] = BONUS_REC[BONUS_SPEND][1, POS] + SPEND_TOTAL;
BONUS_REC[BONUS_NET_POINTS] = BONUS_REC[BONUS_NET_POINTS] + BONUS;
if (NOT_JOINED) {
MATWRITE(BONUS_REC, FL_BONUS_LOST, BONUS_ID);
} else {
if (BONUS_REC[BONUS_NET_POINTS] >= 0) {
MATWRITE(BONUS_REC, FL_BONUS, BONUS_ID);
}
}
return;
}
}
}
