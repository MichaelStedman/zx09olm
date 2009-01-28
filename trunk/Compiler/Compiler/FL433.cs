//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL433 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_BOOKINGS = 6;
readonly UvVar BOOK_MEMBER = 1;
readonly UvVar BOOK_NAME = 2;
readonly UvVar BOOK_FLOOR_AREAS = 3;
readonly UvVar BOOK_PAYMENT_STAT = 4;
readonly UvVar BOOK_PRICE = 5;
readonly UvVar BOOK_CANCEL_DATE = 6;
readonly UvVar BOOK_CANCEL_REASON = 7;
readonly UvVar BOOK_MADE_USER = 8;
readonly UvVar BOOK_MADE_DATE = 9;
readonly UvVar BOOK_MADE_TIME = 10;
readonly UvVar BOOK_TICKET = 11;
readonly UvVar BOOK_CONCESS = 12;
readonly UvVar BOOK_WRITE_OFF_DATE = 13;
readonly UvVar BOOK_WRITE_OFF_USER = 14;
readonly UvVar BOOK_PER_PERSON_NOS = 15;
readonly UvVar BOOK_PERSON = 16;
readonly UvVar BOOK_PERSON_AMOUNT = 17;
readonly UvVar BOOK_PERSON_DATE = 18;
readonly UvVar BOOK_PERSON_TICKET = 19;
readonly UvVar BOOK_REDEEM_POINTS = 20;
readonly UvVar BOOK_REDEEM_VALUE = 21;
readonly UvVar BOOK_WEB = 22;
readonly UvVar BOOK_UNIT_QUANTITY = 23;
readonly UvVar BOOK_UNIT_PRICE = 24;
readonly UvVar BOOK_AUTH_CODE = 25;
readonly UvVar BOOK_BASKET_REF = 26;
readonly UvVar BOOK_BONUS_POINTS = 27;
readonly UvVar BOOK_PROMOTION = 28;
readonly UvVar FL_CONTROL = 10;
readonly UvVar FL_SPORTS = 23;
readonly UvVar SPORTS_DESC = 1;
readonly UvVar SPORTS_BOOKING_LEEWAY = 2;
readonly UvVar SPORTS_CODE1 = 3;
readonly UvVar SPORTS_CODE2 = 4;
readonly UvVar SPORTS_BOOK_AHEAD_DAYS = 5;
readonly UvVar SPORTS_TYPE = 6;
readonly UvVar SPORTS_BOOK_OR_CAS = 7;
readonly UvVar SPORTS_SPECIAL_ROUTINE = 8;
readonly UvVar SPORTS_RESTRICTION_CODE = 9;
readonly UvVar SPORTS_PERSON_BOOKING = 10;
readonly UvVar SPORTS_BOOK_AHEAD_CONTROL = 11;
readonly UvVar SPORTS_SETUP_TIME = 12;
readonly UvVar SPORTS_TAKEDOWN_TIME = 13;
readonly UvVar SPORTS_PLAYERS = 14;
readonly UvVar SPORTS_ADMINISTRATOR = 15;
readonly UvVar SPORTS_CAT_OR_RESOURCE = 16;
readonly UvVar SPORTS_VISIBILITY = 17;
readonly UvVar SPORTS_SUB_LIST = 18;
readonly UvVar SPORTS_TOP_LEVEL = 19;
readonly UvVar SPORTS_DEPENDANT_RESOURCE = 20;
readonly UvVar FL_FLOOR_AREAS = 24;
readonly UvVar FLOOR_DESC = 1;
readonly UvVar FLOOR_FACILITIES = 2;
readonly UvVar FLOOR_PRICE = 3;
readonly UvVar FL_USED_AREAS = 29;
readonly UvVar USED_START_TIME = 1;
readonly UvVar USED_FINISH_TIME = 2;
readonly UvVar USED_BOOKINGS = 3;
readonly UvVar FL_BLOCK_BOOKS = 32;
readonly UvVar BLOCK_BOOK_ACTIVITY = 1;
readonly UvVar BLOCK_BOOK_START_TIME = 2;
readonly UvVar BLOCK_BOOK_END_TIME = 3;
readonly UvVar BLOCK_BOOK_DATES = 4;
readonly UvVar BLOCK_BOOK_FLOORS = 5;
readonly UvVar BLOCK_BOOK_PRICE = 6;
readonly UvVar BLOCK_BOOK_FEE_REF = 7;
readonly UvVar BLOCK_BOOK_WK_AMTS = 8;
readonly UvVar FL_BLOCK_HEADER = 87;
readonly UvVar BLOCK_SDESC = 1;
readonly UvVar BLOCK_STIME = 2;
readonly UvVar BLOCK_ETIME = 3;
readonly UvVar BLOCK_SPORT = 4;
readonly UvVar BLOCK_FLOORS1 = 5;
readonly UvVar BLOCK_FLOORS2 = 6;
readonly UvVar BLOCK_FLOORS3 = 7;
readonly UvVar BLOCK_DATES1 = 8;
readonly UvVar BLOCK_DATES2 = 9;
readonly UvVar BLOCK_DATES3 = 10;
readonly UvVar BLOCK_PRICE_REF = 11;
readonly UvVar BLOCK_LETTER = 12;
readonly UvVar BLOCK_INSTALL = 13;
readonly UvVar BLOCK_START = 14;
readonly UvVar BLOCK_FREQUENCY = 15;
readonly UvVar BLOCK_NO_INSTALLS = 16;
readonly UvVar BLOCK_NOTES = 17;
readonly UvVar BLOCK_DATE_MADE = 18;
readonly UvVar BLOCK_USER = 19;
readonly UvVar BLOCK_DEALER = 20;
readonly UvVar BLOCK_FLOORS4 = 21;
readonly UvVar BLOCK_FLOORS5 = 22;
readonly UvVar BLOCK_FLOORS6 = 23;
readonly UvVar BLOCK_FLOORS7 = 24;
readonly UvVar BLOCK_DATES4 = 25;
readonly UvVar BLOCK_DATES5 = 26;
readonly UvVar BLOCK_DATES6 = 27;
readonly UvVar BLOCK_DATES7 = 28;
readonly UvVar FL_BLOCK_PAY = 88;
readonly UvVar BLOCK_PAY_DUE = 1;
readonly UvVar BLOCK_PAY_OWES = 2;
readonly UvVar BLOCK_PAY_PAID = 3;
readonly UvVar BLOCK_PAY_OUTSTAND = 4;
readonly UvVar BLOCK_PAY_TOTAL_OWED = 5;
readonly UvVar BLOCK_PAY_TOTAL_PAID = 6;
readonly UvVar BLOCK_PAY_DATES_PAID = 7;
readonly UvVar BLOCK_PAY_AMOUNTS_PAID = 8;
readonly UvVar BLOCK_PAY_ADJ = 9;
readonly UvVar BLOCK_PAY_ADJ_TYPE = 10;
readonly UvVar BLOCK_PAY_ADJ_DATE = 11;
readonly UvVar BLOCK_PAY_ADJ_INST = 12;
readonly UvVar BLOCK_PAY_SPORTS1 = 13;
readonly UvVar BLOCK_PAY_HEADCOUNTS1 = 14;
readonly UvVar BLOCK_PAY_SPORTS2 = 15;
readonly UvVar BLOCK_PAY_HEADCOUNTS2 = 16;
readonly UvVar BLOCK_PAY_SPORTS3 = 17;
readonly UvVar BLOCK_PAY_HEADCOUNTS3 = 18;
readonly UvVar BLOCK_PAY_SPORTS4 = 19;
readonly UvVar BLOCK_PAY_HEADCOUNTS4 = 20;
readonly UvVar BLOCK_PAY_SPORTS5 = 21;
readonly UvVar BLOCK_PAY_HEADCOUNTS5 = 22;
#endregion
#region String Constants
readonly UvVar INIT = "";
readonly UvVar STAR = "*";
readonly UvVar YES = "Y";
readonly UvVar NO = "N";
readonly UvVar ERRM1 = "ERRM1";
readonly UvVar ERRM2 = "ERRM2";
readonly UvVar BLANK = "";
readonly UvVar MT = "MT";
readonly UvVar DT = "D2";
readonly UvVar ODT = "D2/";
readonly UvVar DASH19 = "----------";
#endregion
#region Arrays
UvVar[] BOOKINGS_REC = new UvVar[30];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] SPORTS_REC = new UvVar[25];
UvVar[] FLOORS_REC = new UvVar[10];
UvVar[] USED_AREAS_REC = new UvVar[3];
UvVar[] BLOCK_BOOKS_REC = new UvVar[10];
UvVar[] BLOCK_REC = new UvVar[30];
UvVar[] BLOCK_PAY_REC = new UvVar[50];
UvVar[,] FREERECS = new UvVar[150,150];
UvVar[] PRINT_LINE = new UvVar[1000];
#endregion
#region Variables
UvVar MASTER_FLOOR_ID = "";
UvVar REP_DATE = "";
UvVar ZZZ_TIME = "";
UvVar TODAYS_DATE = "";
UvVar REV_VID = "";
UvVar DIM_REV_VID = "";
UvVar NRM_VID = "";
UvVar PROG_MESS = "";
UvVar ERR_PARAMS = "";
UvVar PROGRAM = "";
UvVar TWO_HOURS = "";
UvVar COLOR_ON = "";
UvVar FIVEM = "";
UvVar LINE_NO = "";
UvVar FA_CODES = "";
FL006 FL006;
UvVar MAX_FLOOR_AREAS = "";
UvVar RESPONSE = "";
UvVar FIRST_TIME_IN_DAY = "";
UvVar FVMC = "";
UvVar FCNT = "";
UvVar FADS = "";
UvVar FIDS = "";
UvVar SPORT = "";
UvVar DOW = "";
UvVar FA = "";
UvVar FID = "";
UvVar FA_DESC = "";
UvVar START_FLOOR_POS = "";
UvVar FLOOR_POS = "";
UvVar FLOOR_START = "";
UvVar START_LINE = "";
UvVar LINE_POS = "";
UvVar CHANGE_DATE = "";
UvVar LINE = "";
UvVar LINE_TO_PRINT = "";
UvVar MAX_LINES = "";
UvVar REPING = "";
UvVar CNT = "";
UvVar FREE_ID = "";
UvVar FREC = "";
UvVar BVMC = "";
UvVar BK_ID = "";
UvVar BREC = "";
UvVar PAID = "";
UvVar DATE_FIELD = "";
UvVar PAGE_POS = "";
UvVar PNTR = "";
UvVar TOTAL_DUE = "";
UvVar PAY_DATES = "";
UvVar P_L = "";
UvVar USEFUL_INFO = "";
UvVar OTIME = "";
UvVar ATTN = "";
UvVar REPITEM = "";
UvVar SPID = "";
UvVar TYPECODE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL433(ref UvVar MASTER_FLOOR_ID, ref UvVar REP_DATE, ref UvVar ZZZ_TIME) {
this.MASTER_FLOOR_ID = MASTER_FLOOR_ID;
this.REP_DATE = REP_DATE;
this.ZZZ_TIME = ZZZ_TIME;
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
/*  BOOKING SHEET DISPLAY */
ERR_PARAMS = INIT;
PROGRAM = "FL433";
TWO_HOURS = 7200;
COLOR_ON = NRM_VID;
/*  FILE NAMES */
#region INCLUDE FL.FILES FL.BOOKINGS

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.SPORTS
#region INCLUDE FL.FILES FL.SPORTS.EQU

#endregion

#region INCLUDE FL.FILES FL.SPORTS.DIM

#endregion
#region INCLUDE FL.FILES FL.SPORTS.VAR

/*  Introduced for Warrington: */

#endregion

#endregion
#region INCLUDE FL.FILES FL.FLOOR.AREAS

/* REMOVED THIS TO PREVENT CONFUSION, MUST BE SENT WITH MASTER HALL MAINT PROGRAM!     EQU HALL.DESC                         TO FLOORS.REC(2) */
/*  This entry has been corrected as at 9/3/01 for Release 6.4 */
/*  Floor price was wrongly equated to floor.rec */
/*  Hall desc was only used by master hall maint so this prog was amended */

#endregion
#region INCLUDE FL.FILES FL.USED.AREAS
#region INCLUDE FL.FILES FL.USED.AREAS.EQU

#endregion

#region INCLUDE FL.FILES FL.USED.AREAS.DIM

#endregion
#region INCLUDE FL.FILES FL.USED.AREAS.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.BLOCK.BOOKS

/*   WK.AMTS HOLDS WEEKLY AMTS DUE FOR EASE OF RE-CALC */

#endregion
#region INCLUDE FL.FILES FL.BLOCK.HEADER

#endregion
#region INCLUDE FL.FILES FL.BLOCK.PAY

#endregion
if (!READV(ref FIVEM, COMMON.FILES[FL_CONTROL], "BSHEET.STEPS", 1)) { FIVEM = 5; }
LINE_NO = 1;
FIVEM = FIVEM * 60;
/*  DJA 14.12.05 */
/*      FA.CODES may be deduced/passed in by FL963 */
if (PROG_MESS[37] == "") {
if (MASTER_FLOOR_ID == "") { MASTER_FLOOR_ID = "MH"; }
MASTER_FLOOR_ID = COMMON.CENTRE + "*MASTER*" + MASTER_FLOOR_ID;
if (!(READ(ref FA_CODES, COMMON.FILES[FL_FLOOR_AREAS], MASTER_FLOOR_ID))) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
} else {
FA_CODES = PROG_MESS[37];
}
MAX_FLOOR_AREAS = DCOUNT(FA_CODES, CHAR(253));
REP_DATE = ICONV(REP_DATE, "D");
RESPONSE = "";
FIRST_TIME_IN_DAY = 25200;
do {
if (RESPONSE == "END") break;
MAT(ref PRINT_LINE, "");
PRINT(AT(10, 14) + "THIS REPORT IS BEING PREPARED PLEASE BE PATIENT");
FVMC = 0;
FCNT = 0;
FADS = BLANK;
FIDS = BLANK;
SPORT = "";
PRINT_LINE[1] = OCONV(REP_DATE, "D").Substring(1, 6);
DOW = OCONV(REP_DATE, "DWA");
PRINT_LINE[2] = DOW + "+" + STR("-", 120) + "+";
do {
FVMC = FVMC + 1;
FA = FA_CODES[1, FVMC];
if (FA == BLANK) break;
FID = COMMON.CENTRE + STAR + FA;
if (!READV(ref FA_DESC, COMMON.FILES[FL_FLOOR_AREAS], FID, 1)) { FA_DESC = FA; }
FCNT = FCNT + 1;
FADS[FCNT] = FA_DESC;
PRINT_LINE[1] = PRINT_LINE[1] + "+" + FORMAT(FA_DESC, "L#10");
FIDS[FCNT] = FID;
} while (true);
if (FCNT != 0) { L30(); }
START_FLOOR_POS = 1;
L0100();
/*  Prepare print lines */
PRINT(COMMON.WASH);
FLOOR_POS = 1;
FLOOR_START = 7;
START_LINE = 3;
PRINTCR(AT(1, 1) + PRINT_LINE[1].Substring(1, 78));
PRINTCR(AT(1, 2) + PRINT_LINE[2].Substring(1, 78));
LINE_POS = 3;
CHANGE_DATE = FALSE;
do {
if (RESPONSE == "END" || CHANGE_DATE == TRUE) break;
if (START_LINE == 0) { START_LINE = 1; }
LINE = START_LINE;
for(LINE_NO = LINE_POS; LINE_NO <= 21; LINE_NO += 1) {
/* !**!!              PRINT @(1,LINE.NO):PRINT.LINE(LINE)[1,6]:PRINT.LINE(LINE)[FLOOR.START,73] 'L#73':NRM.VID: */
LINE_TO_PRINT = "";
FLOOR_POS = START_FLOOR_POS + 1;
do {
if (FLOOR_POS == START_FLOOR_POS + 10) break;
LINE_TO_PRINT = LINE_TO_PRINT + PRINT_LINE[LINE][1, FLOOR_POS];
FLOOR_POS = FLOOR_POS + 1;
} while (true);
PRINT(AT(1, LINE_NO) + PRINT_LINE[LINE].Substring(1, 6) + LINE_TO_PRINT.Substring(1, 72) + NRM_VID);
LINE = LINE + 1;
}
ECHO_OFF();
INPUT(out RESPONSE, 1);
ECHO_ON();
// BEGIN CASE
// CASE
if (RESPONSE == "D") {
START_LINE = START_LINE + 4;
if (START_LINE + 19 > MAX_LINES) {
START_LINE = MAX_LINES - 19;
}
LINE_POS = 3;
}// CASE
else if (RESPONSE == "U") {
START_LINE = START_LINE - 4;
LINE_POS = 3;
if (START_LINE < 3) { START_LINE = 3; }
}// CASE
else if (RESPONSE == "R") {
if (START_FLOOR_POS + 6 <= MAX_FLOOR_AREAS) {
START_FLOOR_POS = START_FLOOR_POS + 1;
FLOOR_START = FLOOR_START + 11;
PRINT(AT(1, 1) + PRINT_LINE[1].Substring(1, 6) + FORMAT(PRINT_LINE[1].Substring(FLOOR_START, 72), "L#72"));
}
}// CASE
else if (RESPONSE == "L") {
if (START_FLOOR_POS - 1 > 0) {
START_FLOOR_POS = START_FLOOR_POS - 1;
FLOOR_START = FLOOR_START - 11;
PRINT(AT(1, 1) + PRINT_LINE[1].Substring(1, 6) + FORMAT(PRINT_LINE[1].Substring(FLOOR_START, 72), "L#72"));
}
}// CASE
else if (RESPONSE == ".") {
RESPONSE = "END";
}// CASE
else if (RESPONSE == "F") {
CHANGE_DATE = TRUE;
REP_DATE = REP_DATE + 1;
}// CASE
else if (RESPONSE == "B") {
CHANGE_DATE = TRUE;
REP_DATE = REP_DATE - 1;
}// CASE
else if (RESPONSE == "X") {
if (FA_CODES[3] != "") {
MASTER_FLOOR_ID = FA_CODES[3];
MASTER_FLOOR_ID = COMMON.CENTRE + "*MASTER*" + MASTER_FLOOR_ID;
}
CHANGE_DATE = TRUE;
}// CASE
else if (OTHERWISE) {
}
// END CASE
} while (true);
} while (true);
/*  DJA 15.12.05 */
/* !!  PRINT @(10,16):"PRINT FINISHED PRESS <RETURN> ": */
/* !!  INPUT FIN.ANS,2:;IF LEN(FIN.ANS) > 1 THEN PRINT @(-9):' ':;FIN.ANS=FIN.ANS[1,1] */
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
void L30() {
/* ******************************************************** */
REPING = BLANK;
MAT(ref FREERECS, BLANK);
for(CNT = 1; CNT <= MAX_FLOOR_AREAS; CNT += 1) {
FREE_ID = FIDS[CNT] + STAR + REP_DATE;
if (READ(ref FREC, COMMON.FILES[FL_USED_AREAS], FREE_ID)) {
if (FREC[1, 1] != "") {
if (FIRST_TIME_IN_DAY == "") {
FIRST_TIME_IN_DAY = FREC[1, 1];
}
if (FIRST_TIME_IN_DAY > FREC[1, 1]) {
FIRST_TIME_IN_DAY = FREC[1, 1];
}
FREERECS[CNT, 1] = FREC[1];
FREERECS[CNT, 2] = FREC[2];
BVMC = 0;
do {
if (!READ(ref BREC, COMMON.FILES[FL_BOOKINGS], BK_ID)) { goto L40; }
FREERECS[CNT, 3][1, BVMC] = FIELD(BK_ID, STAR, 2);
/*  SPORT */
FREERECS[CNT, 4][1, BVMC] = BREC[2];
/*  NAME */
FREERECS[CNT, 5][1, BVMC] = BREC[1];
/*  MEMBERSHIP ID */
FREERECS[CNT, 6][1, BVMC] = BREC[4];
/*  PAID */
goto L60;
L40:;
/* *************TRY BLOCK BOOKING*************** */
if (!READ(ref BREC, COMMON.FILES[FL_BLOCK_BOOKS], BK_ID)) { goto L55; }
FREERECS[CNT, 3][1, BVMC] = BREC[1];
/*  SPORT */
FREERECS[CNT, 4][1, BVMC] = "BLOCK BOOKING";
FREERECS[CNT, 5][1, BVMC] = FORMAT((BK_ID), "L#10");
FREERECS[CNT, 5][1, BVMC] = FORMAT((DIM_REV_VID + (BK_ID)), "L#10") + NRM_VID;
FREERECS[CNT, 6][1, BVMC] = "BB";
goto L60;
L55:;
/* ***********TRY NEW BLOCK BOOKINGS******************* */
if (!(MATREAD(ref BLOCK_REC, COMMON.FILES[FL_BLOCK_HEADER], BK_ID))) {
FREERECS[CNT, 3][1, BVMC] = BLANK;
FREERECS[CNT, 4][1, BVMC] = BLANK;
/* *                    FREERECS(CNT,5)<1,BVMC>=BLANK */
FREERECS[CNT, 5][1, BVMC] = (BK_ID);
FREERECS[CNT, 6][1, BVMC] = BLANK;
goto L60;
}
for(DATE_FIELD = 8; DATE_FIELD <= 28; DATE_FIELD += 1) {
if (DATE_FIELD == 11) { DATE_FIELD = 25; }
if (DATE_FIELD < 11) {
PAGE_POS = DATE_FIELD - 7;
FLOOR_POS = DATE_FIELD - 3;
} else {
PAGE_POS = DATE_FIELD - 21;
FLOOR_POS = DATE_FIELD - 4;
}
if (FREC[1, BVMC] == BLOCK_REC[2][1, PAGE_POS] && FREC[2, BVMC] == BLOCK_REC[3][1, PAGE_POS]) {
if (LOCATE(REP_DATE, BLOCK_REC[DATE_FIELD], 1, 0, 1, ref PNTR, "AL")) {
if (LOCATE(FIELD(FREE_ID, "*", 2), BLOCK_REC[FLOOR_POS], 1, 0, 1, ref PNTR, "AL")) {
SPORT = BLOCK_REC[4][1, PAGE_POS];
}
}
}
}
FREERECS[CNT, 3][1, BVMC] = SPORT;
/*  SPORT */
FREERECS[CNT, 4][1, BVMC] = BLOCK_REC[BLOCK_SDESC];
FREERECS[CNT, 5][1, BVMC] = FORMAT((BK_ID), "L#10");
FREERECS[CNT, 5][1, BVMC] = (BK_ID);
if (!MATREAD(ref BLOCK_PAY_REC, COMMON.FILES[FL_BLOCK_PAY], BK_ID)) { MAT(ref BLOCK_PAY_REC, ""); }
TOTAL_DUE = 0;
PAY_DATES = 0;
do {
PAY_DATES = PAY_DATES + 1;
if (BLOCK_PAY_REC[BLOCK_PAY_DUE][1, PAY_DATES] == "") break;
if (BLOCK_PAY_REC[BLOCK_PAY_DUE][1, PAY_DATES] <= TODAYS_DATE || BLOCK_PAY_REC[BLOCK_PAY_PAID][1, PAY_DATES] > 0) {
if (BLOCK_PAY_REC[BLOCK_PAY_DUE][1, PAY_DATES] <= TODAYS_DATE) {
TOTAL_DUE = TOTAL_DUE + BLOCK_PAY_REC[BLOCK_PAY_OUTSTAND][1, PAY_DATES];
}
}
} while (true);
if (TOTAL_DUE <= 0) {
if (BLOCK_PAY_REC[BLOCK_PAY_TOTAL_OWED] == BLOCK_PAY_REC[BLOCK_PAY_TOTAL_PAID]) {
FREERECS[CNT, 6][1, BVMC] = "Y";
} else {
FREERECS[CNT, 6][1, BVMC] = "ND";
}
}
/* !                 FREERECS(CNT,6)<1,BVMC>='BB' */
L60:;
} while (true);
}
}
}
return;
}
void L0100() {
/*  PRINT DETAILS */
FLOOR_POS = START_FLOOR_POS;
LINE_NO = 3;
ZZZ_TIME = FIRST_TIME_IN_DAY;
do {
if (ZZZ_TIME == 86400) break;
P_L = "";
USEFUL_INFO = 0;
OTIME = OCONV(ZZZ_TIME, MT);
if (FORMAT(OTIME, "R#2") != "00") { OTIME = COMMON.SP[3] + (FORMAT(OTIME, "R#2")); }
if (FORMAT(OTIME, "R#2") == "00") { USEFUL_INFO = 1; }
P_L[1, -1] = OTIME + COMMON.SP[1] + ":";
for(CNT = FLOOR_POS; CNT <= MAX_FLOOR_AREAS; CNT += 1) {
if (FREERECS[CNT, 2][1, 1] == ZZZ_TIME || FREERECS[CNT, 2][1, 1] == ZZZ_TIME - 60) {
for(ATTN = 1; ATTN <= 6; ATTN += 1) {
FREERECS[CNT, ATTN] = DELETE(FREERECS[CNT, ATTN], 1, 1, 0);
}
REPING[CNT] = "FIN";
}
if (FREERECS[CNT, 1][1, 1] == ZZZ_TIME) {
REPING[CNT, 1] = 1;
}
REPITEM = REPING[CNT];
// BEGIN CASE
// CASE
if (REPITEM == "FIN") {
REPING[CNT] = BLANK;
P_L[1, -1] = DASH19;
USEFUL_INFO = 1;
}// CASE
else if (REPITEM == 1) {
REPING[CNT] = 2;
P_L[1, -1] = DASH19;
USEFUL_INFO = 1;
}// CASE
else if (REPITEM == 2) {
SPID = FREERECS[CNT, 3][1, 1];
P_L[1, -1] = FORMAT(OCONV(SPID, "TFL.SPORTS;C;1;1"), "L#10");
USEFUL_INFO = 1;
REPING[CNT] = 3;
}// CASE
else if (REPITEM == 3) {
P_L[1, -1] = FORMAT(FREERECS[CNT, 4][1, 1], "L#10");
USEFUL_INFO = 1;
REPING[CNT] = 4;
}// CASE
else if (REPITEM == 4) {
TYPECODE = FREERECS[CNT, 6][1, 1];
if (TYPECODE == "BB" || TYPECODE == "MAINT") {
P_L[1, -1] = FORMAT(FREERECS[CNT, 5][1, 1], "L#10");
FREERECS[CNT, 5][1, 1] = "";
USEFUL_INFO = 1;
} else {
PAID = "NOT.PAID";
if (FREERECS[CNT, 6][1, 1] == YES) { PAID = "PAID    "; }
if (FREERECS[CNT, 6][1, 1] == "ND") { PAID = "Not Due  "; }
if (PAID.Substring(1, 4) != "PAID") {
P_L[1, -1] = REV_VID + FORMAT(PAID, "L#10") + NRM_VID;
} else {
P_L[1, -1] = FORMAT(PAID, "L#10");
}
USEFUL_INFO = 1;
}
REPING[CNT] = 5;
}// CASE
else if (REPITEM == 5) {
/* *              P.L = P.L : '***':SPACE(7) */
if (FREERECS[CNT, 5][1, 1] != "") {
P_L[1, -1] = FORMAT(FREERECS[CNT, 5][1, 1], "L#10");
FREERECS[CNT, 5][1, 1] = "";
USEFUL_INFO = 1;
} else {
P_L[1, -1] = "**********";
}
}// CASE DEFAULT
else {
P_L[1, -1] = COMMON.SP[10];
}
// END CASE
P_L = P_L + ":";
}
if (USEFUL_INFO) {
PRINT_LINE[LINE_NO] = P_L;
LINE_NO = LINE_NO + 1;
}
ZZZ_TIME = ZZZ_TIME + FIVEM;
} while (true);
MAX_LINES = LINE_NO;
return;
L140:;
/*  THE END */
return;
}
}
}
