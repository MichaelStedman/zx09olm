//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL473 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar CENTRES = 3;
readonly UvVar CONTROL = 10;
readonly UvVar SPORTS = 23;
readonly UvVar FLOOR_AREAS = 24;
readonly UvVar OPTIONS = 25;
readonly UvVar STD_DAYS = 26;
readonly UvVar UNBOOKED = 27;
readonly UvVar USED_AREAS = 29;
readonly UvVar CALENDAR = 30;
readonly UvVar FL_BOOK_WAITING = 120;
readonly UvVar CEN_NAME = 1;
readonly UvVar FA_CODES = 2;
readonly UvVar SP_CODES = 3;
readonly UvVar SP_CNT = 4;
readonly UvVar BOOK_PRI = 1;
readonly UvVar FACODES = 2;
readonly UvVar DAY_TITLE = 1;
readonly UvVar START_TIMES = 2;
readonly UvVar LAST_TIMES = 3;
readonly UvVar DURATIONS = 4;
readonly UvVar STD_SPCODES = 5;
readonly UvVar STD_SPCNTS = 6;
readonly UvVar OPENING = 7;
readonly UvVar CLOSING = 8;
#endregion
#region String Constants
readonly UvVar INIT = "";
readonly UvVar ERRM2 = "ERRM2";
readonly UvVar BLANK = "";
readonly UvVar MT = "MT";
readonly UvVar DT = "D2";
readonly UvVar ODT = "D2/";
readonly UvVar YES = "Y";
readonly UvVar NO = "N";
readonly UvVar ERRM1 = "ERRM1";
readonly UvVar TWINK = "*";
readonly UvVar UNSATISFIED = "Z";
#endregion
#region Arrays
UvVar[] BOOK_WAIT_REC = new UvVar[20];
UvVar[] CEN_REC = new UvVar[20];
UvVar[] OPT_REC = new UvVar[2];
UvVar[] STD_DAY_REC = new UvVar[10];
UvVar[] DAYS = new UvVar[7];
#endregion
#region Variables
UvVar DEMO_SPORTS = "";
UvVar DSCNT = "";
UvVar FIRST_TIME = "";
UvVar TODAYS_DATE = "";
UvVar REV_VID = "";
UvVar NRM_VID = "";
UvVar REV_UND_VID = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_TEXT = "";
UvVar SCREEN_TEXT2 = "";
UvVar SCREEN_DATA = "";
UvVar ERR_MESS_BACK = "";
UvVar ERR_MESS_FORE = "";
UvVar SCREEN_WIDTH = "";
UvVar VIDEO_STYLE = "";
UvVar AM = "";
UvVar ERR_PARAMS = "";
UvVar PROGRAM = "";
UvVar ESCG = "";
UvVar WHATS_ON = "";
UvVar ERRR = "";
UvVar COURT_CHANGE = "";
UvVar DEMO_DELAY = "";
UvVar BOOK_AHEAD = "";
UvVar DEMO_FOOT = "";
UvVar FOOTLINES = "";
UvVar SPACE_STRING = "";
UvVar SP_CODE = "";
UvVar SPORT_REC = "";
FL006 FL006;
UvVar SP_DESC = "";
UvVar SP_BOOKING_LEEWAY = "";
UvVar GROUP_SP_CODE = "";
UvVar SP_CODE1 = "";
UvVar SP_DESC1 = "";
UvVar SP_CODE2 = "";
UvVar SP_DESC2 = "";
FL427 FL427;
UvVar INTERACT = "";
UvVar WR_DATE = "";
UvVar WR_DATE2 = "";
UvVar UNBK_REC = "";
UvVar UNBK_REC2 = "";
UvVar UNBK_REC_SAVED1 = "";
UvVar UNBK_REC_SAVED2 = "";
UvVar REC1 = "";
UvVar RECORD = "";
UvVar ENTRY_TIME = "";
UvVar DAY = "";
UvVar DAY2 = "";
UvVar DEMO_DESC = "";
UvVar DDESC = "";
UvVar DDDESC = "";
UvVar LETTERS = "";
UvVar LETTER = "";
UvVar TOP_TEXT = "";
UvVar LEFT_POS = "";
UvVar SECOND = "";
UvVar SECONDX = "";
UvVar SCREEN_CODE = "";
UvVar CEN_CODE = "";
UvVar TICKET_REC = "";
UvVar CODE = "";
UvVar LAST_NUMBER = "";
UvVar ATT = "";
UvVar LAST_LINE = "";
UvVar LINE = "";
UvVar PAGE_NO = "";
UvVar FREE = "";
UvVar FREE2 = "";
UvVar POSS = "";
UvVar NOTHING_BOOKABLE = "";
UvVar END_POINT = "";
UvVar JUST = "";
UvVar PRINT_ATT = "";
UvVar PLINE = "";
UvVar WORKLINE = "";
UvVar VAR = "";
UvVar CTS_FREE = "";
UvVar RW = "";
UvVar FOOTLINE = "";
UvVar COL = "";
FL428 FL428;
UvVar ZZZ_COL2 = "";
UvVar REM = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL473(ref UvVar DEMO_SPORTS, ref UvVar DSCNT, ref UvVar FIRST_TIME) {
this.DEMO_SPORTS = DEMO_SPORTS;
this.DSCNT = DSCNT;
this.FIRST_TIME = FIRST_TIME;
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
/*  TIMED COURT DEMO */
ERR_PARAMS = "";
PROGRAM = "FL473";
ESCG = CHAR(27) + "G";
WHATS_ON = "+";
ERRR = ERR_MESS_BACK + ERR_MESS_FORE;
COURT_CHANGE = "/";
/*  Filenames * */
#region INCLUDE FL.FILES FL.BOOK.WAITING

#endregion
if (!(READV(ref DEMO_DELAY, COMMON.FILES[CONTROL], "DEMO.DELAY", 1))) {
DEMO_DELAY = 10;
}
/*  Booking Period */
/*      READV BOOK.AHEAD FROM CONTROL , 'BOOK.AHEAD' , 1 ELSE BOOK.AHEAD = 7 */
BOOK_AHEAD = 2;
/*  Show Today and Tommorrow regardless of BOOK.AHEAD */
if (!(READ(ref DEMO_FOOT, COMMON.FILES[CONTROL], "DEMO.FOOT"))) {
DEMO_FOOT = "";
}
FOOTLINES = DCOUNT(DEMO_FOOT, AM);
if (VIDEO_STYLE == "C") { SPACE_STRING = " "; } else { SPACE_STRING = ""; }
L1000();
/*  Initialize Ticket Record & Centres & Variables */
L900();
/*  Print Top of Screen */
INPUT(out SP_CODE, 4);
if (LEN(SP_CODE) > 3) { PRINT(AT(-9) + "]"); SP_CODE = SP_CODE.Substring(1, 3); }
if (!(READ(ref SPORT_REC, COMMON.FILES[SPORTS], SP_CODE))) {
nrf0 = 2;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
SP_DESC = SPORT_REC[1];
SP_BOOKING_LEEWAY = SPORT_REC[2];
GROUP_SP_CODE = SP_CODE;
if (SPORT_REC[4] != "") {
SP_CODE1 = SPORT_REC[3];
if (!READV(ref SP_DESC1, COMMON.FILES[SPORTS], SP_CODE1, 1)) { SP_DESC1 = SP_CODE1; }
SP_CODE2 = SPORT_REC[4];
if (!READV(ref SP_DESC2, COMMON.FILES[SPORTS], SP_CODE2, 1)) { SP_DESC2 = SP_CODE2; }
} else {
SP_CODE1 = SP_CODE;
SP_CODE2 = "";
}
if (SP_BOOKING_LEEWAY == "") {
if (!(READV(ref SP_BOOKING_LEEWAY, COMMON.FILES[CONTROL], "BOOKING.LEEWAY", 1))) {
SP_BOOKING_LEEWAY = 0;
}
}
SP_BOOKING_LEEWAY = SP_BOOKING_LEEWAY * 60;
FL427 = new FL427(ref INTERACT, ref SP_CODE1, ref SP_CODE2, ref WR_DATE, ref WR_DATE2, ref UNBK_REC, ref UNBK_REC2, ref UNBK_REC_SAVED1, ref UNBK_REC_SAVED2, ref REC1, ref RECORD, ref ENTRY_TIME, ref SP_BOOKING_LEEWAY, ref DAY, ref DAY2);
if (!(READV(ref DEMO_DESC, COMMON.FILES[SPORTS], DEMO_SPORTS[DSCNT], 1))) {
DEMO_DESC = "Unknown";
}
DDESC = OCONV(DEMO_DESC, "MCU");
DDDESC = "";
LETTERS = LEN(DDESC);
for(LETTER = 1; LETTER <= LETTERS; LETTER += 1) {
DDDESC = DDDESC + DDESC.Substring(LETTER, 1) + "  ";
}
PRINT(AT(0, 0) + COMMON.EOL);
PRINT(AT(78, 0) + NRM_VID);
PRINT(AT(0, 0) + REV_UND_VID);
TOP_TEXT = DDDESC + "   A V A I L A B I L I T Y";
if (LEN(TOP_TEXT) > 79) {
TOP_TEXT = DDDESC;
}
LEFT_POS = INT((79 - LEN(TOP_TEXT)) / 2);
PRINT(AT(LEFT_POS, 0) + TOP_TEXT);
PRINT();
L3000();
/*  Print Screen */
PRINT(AT(67, 17) + COMMON.EOL);
PRINT(AT(78, 17) + NRM_VID);
PRINT(AT(67, 17) + REV_VID);
for(SECOND = DEMO_DELAY; SECOND <= 1; SECOND += -1) {
if (SECOND > 10) {
SECONDX = 10;
} else {
SECONDX = SECOND;
}
PRINT(AT(68 + SECONDX, 17) + NRM_VID);
if (SECOND == 9) {
/*          PRINT @(68,17):SECOND:' ': */
} else {
/*          PRINT @(68,17):SECOND: */
}
RQM();
}
/*      PRINT @(67,17):'  ': */
return;
}
void L900() {
/*  Print Top of Screen */
SCREEN_CODE = PROGRAM;
if (FIRST_TIME) {
PRINT(COMMON.WASH);
FIRST_TIME = FALSE;
} else {
PRINT(AT(0, 3) + SPACE(60));
}
return;
}
void L1000() {
/*  Initialize Variables */
if (!(MATREAD(ref CEN_REC, COMMON.FILES[CENTRES], COMMON.CENTRE))) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
CEN_CODE = COMMON.CENTRE;
DAYS[1] = "Mon";
DAYS[2] = "Tue";
DAYS[3] = "Wed";
DAYS[4] = "Thu";
DAYS[5] = "Fri";
DAYS[6] = "Sat";
DAYS[7] = "Sun";
TICKET_REC = "";
TICKET_REC[1] = "";
/*  TIC CODE */
TICKET_REC[2] = 1;
/*  UNITS */
TICKET_REC[3] = "";
/*  CODE PRICE */
TICKET_REC[4] = TODAYS_DATE;
TICKET_REC[5] = "";
/*  TIME OF ISSUE */
TICKET_REC[6] = "";
/*  SAME AS <3> I.E. TICKET TOTAL */
TICKET_REC[7] = "";
/*  CASH OR CHEQUE */
/*      TICKET.REC<8> = U.INITS */
/*      TICKET.REC<9> = TILL.NUMBER */
LAST_NUMBER = COMMON.CENTRE + "*LAST.NUMBER";
ATT = 1;
LAST_LINE = "";
LINE = 7;
PAGE_NO = 1;
FREE = 0;
FREE2 = 0;
REC1 = FALSE;
ENTRY_TIME = TIME();
WR_DATE = TODAYS_DATE;
WR_DATE2 = TODAYS_DATE + (BOOK_AHEAD - 1);
POSS = 47;
CODE = "";
SP_CODE = "";
NOTHING_BOOKABLE = FALSE;
return;
}
void L3000() {
/*  Print Screen */
if (SP_CODE2 != "") {
PRINT(AT(0, 5) + SCREEN_BACK + SCREEN_TEXT + COMMON.EOL);
END_POINT = LEN(SP_DESC1) + 18;
PRINT(AT(END_POINT, 5) + NRM_VID);
PRINT(AT(16, 5) + REV_UND_VID);
PRINT(AT(17, 5) + SP_DESC1);
END_POINT = LEN(SP_DESC2) + 57;
PRINT(AT(END_POINT, 5) + NRM_VID);
PRINT(AT(55, 5) + REV_UND_VID);
PRINT(AT(56, 5) + SP_DESC2);
PRINT(AT(0, 6) + SCREEN_BACK + SCREEN_TEXT + COMMON.EOL + AT(2, 6) + DAYS[DAY] + " " + OCONV(WR_DATE, ODT) + AT(41, 6) + DAYS[DAY] + " " + OCONV(WR_DATE, ODT) + COMMON.EOS);
} else {
PRINT(AT(0, 2) + SCREEN_BACK + SCREEN_TEXT + COMMON.EOL + AT(9, 2) + "T O D A Y" + AT(48, 2) + "T O M O R R O W" + COMMON.EOS);
}
JUST = "L#" + SCREEN_WIDTH;
PRINT_ATT = ATT - 1;
for(PLINE = 4; PLINE <= 16; PLINE += 1) {
PRINT_ATT = PRINT_ATT + 1;
WORKLINE = UNBK_REC[PRINT_ATT];
PRINT(AT(0, PLINE) + SCREEN_BACK + SCREEN_TEXT);
PRINT(AT(2, PLINE) + OCONV(WORKLINE[1, 2], MT));
if (!LOCATE("-1", UNBK_REC, PRINT_ATT, 0, 1, ref VAR, "AL")) { VAR = 3; }
CTS_FREE = VAR - 3;
if (CTS_FREE > 0) {
PRINT(AT(20, PLINE) + NRM_VID);
PRINT(AT(7, PLINE) + SCREEN_TEXT2);
PRINT(AT(8, PLINE) + " Vacant" + FORMAT(CTS_FREE, "R#3"));
FREE = 1;
}
WORKLINE = UNBK_REC[PRINT_ATT + 13];
PRINT(AT(20, PLINE) + SCREEN_TEXT);
PRINT(AT(21, PLINE) + OCONV(WORKLINE[1, 2], MT));
if (!LOCATE("-1", UNBK_REC, PRINT_ATT + 13, 0, 1, ref VAR, "AL")) { VAR = 3; }
CTS_FREE = VAR - 3;
if (CTS_FREE > 0) {
PRINT(AT(39, PLINE) + NRM_VID);
PRINT(AT(26, PLINE) + SCREEN_TEXT2);
PRINT(AT(27, PLINE) + " Vacant" + FORMAT(CTS_FREE, "R#3"));
FREE = 1;
}
WORKLINE = UNBK_REC2[PRINT_ATT];
PRINT(AT(40, PLINE) + SCREEN_TEXT);
PRINT(AT(41, PLINE) + OCONV(WORKLINE[1, 2], MT));
if (!LOCATE("-1", UNBK_REC2, PRINT_ATT, 0, 1, ref VAR, "AL")) { VAR = 3; }
CTS_FREE = VAR - 3;
if (CTS_FREE > 0) {
PRINT(AT(59, PLINE) + NRM_VID);
PRINT(AT(46, PLINE) + SCREEN_TEXT2);
PRINT(AT(47, PLINE) + " Vacant" + FORMAT(CTS_FREE, "R#3"));
FREE2 = 1;
}
WORKLINE = UNBK_REC2[PRINT_ATT + 13];
PRINT(AT(59, PLINE) + SCREEN_TEXT);
PRINT(AT(60, PLINE) + OCONV(WORKLINE[1, 2], MT));
if (!LOCATE("-1", UNBK_REC2, PRINT_ATT + 13, 0, 1, ref VAR, "AL")) { VAR = 3; }
CTS_FREE = VAR - 3;
if (CTS_FREE > 0) {
PRINT(AT(78, PLINE) + NRM_VID);
PRINT(AT(65, PLINE) + SCREEN_TEXT2);
PRINT(AT(66, PLINE) + " Vacant" + FORMAT(CTS_FREE, "R#3"));
FREE2 = 1;
}
}
PRINT(AT(0, 23) + SCREEN_BACK + SCREEN_DATA);
for(RW = 22; RW <= 18; RW += -1) {
PRINT(AT(0, RW) + REV_UND_VID);
PRINT(AT(2, RW) + SPACE(SCREEN_WIDTH - 2));
}
for(FOOTLINE = 1; FOOTLINE <= FOOTLINES; FOOTLINE += 1) {
PRINT(AT(2, FOOTLINE + 17) + DEMO_FOOT[FOOTLINE]);
}
return;
}
void L4000() {
/*  Nothing Bookable */
if (REC1) { COL = 12; } else { COL = 52; }
PRINT(AT(COL + 21, 6) + NRM_VID);
PRINT(AT(COL + 4, 6) + ERR_MESS_BACK);
PRINT(AT(COL + 4, 6) + ERR_MESS_FORE);
PRINT(AT(COL + 5, 6) + "NOTHING BOOKABLE");
PRINT(AT(0, 6) + SCREEN_BACK + SCREEN_TEXT);
PRINT(AT(COL + 3, 6));
INPUT(out CODE, 1);
PRINT(AT(COL + 3, 6) + SPACE(21));
LINE = "";
LAST_LINE = "";
return;
L5000:;
/*  Find Next Free */
FL428 = new FL428(ref CODE, ref ATT, ref REC1, ref RECORD, ref NOTHING_BOOKABLE, ref WORKLINE, ref PAGE_NO, ref UNBK_REC, ref UNBK_REC2, ref POSS, ref LAST_LINE);
if (NOTHING_BOOKABLE == TRUE) {
L4000();
}
COL = INT(ATT / 13);
ZZZ_COL2 = REM[ATT, 13];
if (REC1) {
if ((REM[COL, 2] == 0 && ZZZ_COL2 != 0) || (REM[COL, 2] == 1 && ZZZ_COL2 == 0)) {
POSS = 8;
} else {
POSS = 27;
}
} else {
if ((REM[COL, 2] == 0 && ZZZ_COL2 != 0) || (REM[COL, 2] == 1 && ZZZ_COL2 == 0)) {
POSS = 47;
} else {
POSS = 66;
}
}
LINE = MOD(ATT, 13);
if (LINE == 0) { LINE = 13; }
LINE = LINE + 6;
L5999:;
return;
}
}
}
