//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL818_NC : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar MEMBERS = 2;
readonly UvVar MEMBER_PARAMS = 64;
readonly UvVar D_MEMBERS = 65;
readonly UvVar FL_MEMBER_USAGE = 61;
readonly UvVar USAGE_DATE = 1;
readonly UvVar LIMIT_REACHED_DATE = 2;
readonly UvVar USAGE_TIME = 3;
readonly UvVar TIME_DISCLAIMER = 4;
readonly UvVar USER_TIME_DISCLRS = 5;
readonly UvVar USER_DATE_DISCLRS = 6;
readonly UvVar USAGE_COUNTER = 7;
readonly UvVar USAGE_DOOR_LOG = 8;
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
readonly UvVar LOST_MEMBER = 1;
readonly UvVar LOST_SCHEME = 2;
readonly UvVar LOST_DATE_JOINED = 3;
readonly UvVar LOST_MONTH = 4;
readonly UvVar LOST_POINTS = 5;
readonly UvVar LOST_SPEND = 6;
readonly UvVar LOST_REDEEMED = 7;
readonly UvVar LOST_VALUE_REDEEMED = 8;
readonly UvVar LOST_NET_POINTS = 9;
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
readonly UvVar ADT_RECORD_ID = 1;
readonly UvVar ADT_DATE = 2;
readonly UvVar ADT_USER = 3;
readonly UvVar ADT_ORIG_VALUE = 4;
readonly UvVar ADT_NEW_VALUE = 5;
readonly UvVar ADT_REASON = 6;
readonly UvVar ADT_TIME = 7;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] USAGE_REC = new UvVar[10];
UvVar[] BONUS_REC = new UvVar[40];
UvVar[] BONUS_LOST_REC = new UvVar[40];
UvVar[] TICK_FEES_REC = new UvVar[40];
UvVar[] ADT_REC = new UvVar[30];
#endregion
#region Variables
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar SCREEN_BACK = "";
UvVar SCREEN_DATA = "";
UvVar AMD_KEY = "";
UvVar AM = "";
UvVar VM = "";
UvVar TRANS_LOG_REC = "";
UvVar PROGRAM = "";
UvVar SCREEN_CODE = "";
UvVar EXECUTE_PROG = "";
UvVar FL_BONUS = "";
UvVar FL_BONUS_LOST = "";
UvVar FL_ADT_LOG = "";
UvVar DICT_ADT_LOG = "";
UvVar FL_MUDEL_WORK = "";
UvVar FL_BONUS_WORK = "";
UvVar FL_BONLST_WORK = "";
UvVar EXPIRED_TYPE = "";
UvVar EXPIRED_COUNT = "";
UvVar DOTS_ONLY = "";
UvVar DATE_AND_TIME = "";
UvVar MEM_COUNT = "";
UvVar PAGE_DEPTH = "";
UvVar PAGE_NO = "";
UvVar PRINT_REC = "";
UvVar HEADER_REC = "";
UvVar TOTAL_HLINES = "";
UvVar PAGE_HEADER_REC = "";
UvVar TOTAL_PHLINES = "";
UvVar USAGE_SUFFIX_USED = "";
UvVar FORMS = "";
UvVar DELETION_DAYS = "";
UvVar INPUT_NO = "";
UvVar ALL_FILES_DELETE = "";
UvVar WARNING = "";
UvVar WARNING2 = "";
UvVar WARNING3 = "";
UvVar WARNING4 = "";
FL000_10 FL000_10;
UvVar WAIT = "";
UvVar MEMBER_TYPES = "";
UvVar INSTRUCTION = "";
UvVar MESSAGE = "";
UvVar TYPE_COUNT = "";
UvVar THIS_TYPE = "";
UvVar TICKET_CODE = "";
FL355 FL355;
UvVar PRICE = "";
UvVar PERIOD = "";
UvVar RESPONSE = "";
FL006 FL006;
UvVar DEAD_COUNT = "";
UvVar EOF = "";
UvVar MU_ID = "";
UvVar THIS_MEMBER = "";
UvVar MU_REC = "";
UvVar BONUS_ID = "";
UvVar BON_REC = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar OTHER = "";
UvVar MESSAGES = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar MEMBERS_ID = "";
UvVar MEMBERS_REC = "";
UvVar CARDS_HELD = "";
UvVar CARDS_EXPIRED = "";
UvVar TRIES = "";
UvVar ALL_EXPIRED = "";
UvVar EXPIRED_MEMBERS_REC = "";
FLTX2 FLTX2;
UvVar DISPLAY_DATE = "";
UvVar DD_ID = "";
UvVar MEMBER_USAGE_ID = "";
UvVar BONUS_FLAG = "";
UvVar DEBTORS_FLAG = "";
UvVar COURSE_STUDENT_NO = "";
FL247 FL247;
FL000_45 FL000_45;
UvVar ADT_MEMBER_ID = "";
UvVar DELETION_SUFFIX = "";
UvVar DEC = "";
UvVar NEW_SUFFIX = "";
UvVar PRINT_START_COMMAND = "";
UvVar PRINT_END_COMMAND = "";
UvVar PRINT_COMMANDS = "";
FL235 FL235;
UvVar HLINE = "";
UvVar LINE_COUNT = "";
UvVar ANAL_COUNT = "";
UvVar DUMMY = "";
UvVar PHLINE = "";
UvVar PNTR = "";
UvVar SEQ_NO = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL818_NC() {
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
/*  Delete expired members according to parameter */
/*  Last updated by lfsw (MONTE_CARLO\lfsw) at 09:23:04 on 28/09/1999. */
/*  Amended by HS (4.9.96) to incorporate Reading's requirements */
/* **************************************************************** */
PROGRAM = "FL818.NC";
SCREEN_CODE = PROGRAM;
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  Files */
#region INCLUDE FL.FILES FL.MEMBER.USAGE

/*  This item separated into three components */
/*  by DJA 9.7.01 in conjunction with eBookings */
/*  upgrade */
#region INCLUDE FL.FILES FL.MEMBER.USAGE.EQU

#endregion
#region INCLUDE FL.FILES FL.MEMBER.USAGE.DIM

#endregion
#region INCLUDE FL.FILES FL.MEMBER.USAGE.VAR

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
#region INCLUDE FL.FILES FL.BONUS.LOST
#region INCLUDE FL.FILES FL.BONUS.LOST.EQU
if (!OPEN("FL.BONUS.LOST", out FL_BONUS_LOST)) { STOP("201", "FL.BONUS.LOST"); }

#endregion

#region INCLUDE FL.FILES FL.BONUS.LOST.DIM

#endregion
#region INCLUDE FL.FILES FL.BONUS.LOST.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES
#region INCLUDE FL.FILES FL.TICKET.FEES.EQU

#endregion

#region INCLUDE FL.FILES FL.TICKET.FEES.DIM

#endregion
#region INCLUDE FL.FILES FL.TICKET.FEES.VAR

#endregion

#endregion
#region INCLUDE FL.FILES FL.ADT.LOG

if (!OPEN("FL.ADT.LOG", out FL_ADT_LOG)) { STOP("201", "FL.ADT.LOG"); }
if (!OPENDICT("FL.ADT.LOG", out DICT_ADT_LOG)) { STOP("201", "DICT,FL.ADT.LOG"); }
/*  ATTRIBUTES 10+ CONTAIN <ATT#> ]ORIGINAL VALUE */

#endregion
if (!(OPEN("FL.MUDEL.WORK", out FL_MUDEL_WORK))) {
EXECUTE("CREATE-FILE FL.MUDEL.WORK 1 71", string.Empty, string.Empty, string.Empty, string.Empty);
if (!OPEN("FL.MUDEL.WORK", out FL_MUDEL_WORK)) { STOP(201, "FL.MUDEL.WORK"); }
}
if (!(OPEN("FL.BONUS.WORK", out FL_BONUS_WORK))) {
EXECUTE("CREATE-FILE FL.BONUS.WORK 1 71", string.Empty, string.Empty, string.Empty, string.Empty);
if (!OPEN("FL.BONUS.WORK", out FL_BONUS_WORK)) { STOP(201, "FL.BONUS.WORK"); }
}
if (!(OPEN("FL.BONLST.WORK", out FL_BONLST_WORK))) {
EXECUTE("CREATE-FILE FL.BONLST.WORK 1 71", string.Empty, string.Empty, string.Empty, string.Empty);
if (!OPEN("FL.BONLST.WORK", out FL_BONLST_WORK)) { STOP(201, "FL.BONLST.WORK"); }
}
/*  Initialise Variables */
EXPIRED_TYPE = INIT;
EXPIRED_COUNT = INIT;
DOTS_ONLY = 0;
DATE_AND_TIME = OCONV(TODAYS_DATE, "D") + " " + OCONV(TIME(), "MT");
MEM_COUNT = 0;
PAGE_DEPTH = 50;
PAGE_NO = 1;
PRINT_REC = "";
HEADER_REC = "";
HEADER_REC[1] = FORMAT(DATE_AND_TIME, "R#126");
HEADER_REC[2] = SPACE(50) + "EXPIRED MEMBERS REMOVED";
HEADER_REC[2] = HEADER_REC[2] + SPACE(36) + "PAGE " + PAGE_NO;
HEADER_REC[3] = SPACE(50) + "=======================";
HEADER_REC[4] = " ";
HEADER_REC[5] = " ";
TOTAL_HLINES = DCOUNT(HEADER_REC, AM);
PAGE_HEADER_REC = "";
PAGE_HEADER_REC[1] = STR("=", 130);
PAGE_HEADER_REC[2] = " ";
PAGE_HEADER_REC[3] = FORMAT("MEMBER NO", "L#15") + SPACE(4) + FORMAT("DIRECT DEBITS", "L#15") + SPACE(4) + FORMAT("MEMBER USAGE", "L#15") + SPACE(4) + FORMAT("BONUS REMOVED", "L#13") + SPACE(4) + FORMAT("DEBTOR REMOVED", "L#14") + SPACE(4) + "NEW STUDENT ID";
PAGE_HEADER_REC[4] = " ";
PAGE_HEADER_REC[5] = STR("=", 130);
PAGE_HEADER_REC[6] = " ";
TOTAL_PHLINES = DCOUNT(PAGE_HEADER_REC, AM);
PRINT_REC = "";
USAGE_SUFFIX_USED = FALSE;
/*  Read deletion period */
if (!(READV(ref DELETION_DAYS, COMMON.FILES[D_MEMBERS], "DAYS", 2))) {
INPUT_NO = 1;
goto L40;
}
if (DELETION_DAYS == "") { DELETION_DAYS = 14; }
if (!(READV(ref ALL_FILES_DELETE, COMMON.FILES[MEMBER_PARAMS], "ALL.FILES.DELETE", 1))) {
ALL_FILES_DELETE = "N";
}
WARNING = "WARNING !! This option will delete expired members";
WARNING2 = "";
if (ALL_FILES_DELETE == "Y") {
WARNING2 = "and will remove all references to those members in relevant files";
}
WARNING3 = "Any letter required for members where cards have expired should have been";
WARNING4 = "produced before running this process.";
/*  Display screen */
FL000_10 = new FL000_10(ref SCREEN_CODE, ref DOTS_ONLY);
PRINT(AT(0, 3) + SCREEN_BACK + SCREEN_DATA);
PRINTCR(AT(3, 10) + WARNING);
PRINTCR(AT(3, 11) + WARNING2);
PRINTCR(AT(3, 12) + WARNING3);
PRINTCR(AT(3, 13) + WARNING4);
PRINT(AT(3, 15) + "Press 'C' to Remove Members who expired more than " + DELETION_DAYS + " days ago ");
INPUT(out WAIT, 2);
if (WAIT != "C" && WAIT != "c") {
goto L80;
}
/*  Select types to be deleted */
PRINT(AT(3, 15) + "Member Types or ALL [");
PRINT(SPACE(50) + "]");
PRINT(AT(24, 15));
INPUT(out MEMBER_TYPES, 51);
// BEGIN CASE
// CASE
if (MEMBER_TYPES == COMMON.ABANDON) {
goto L80;
}// CASE
else if (MEMBER_TYPES == "") {
INSTRUCTION = "SELECT FL.MEMBERS";
MESSAGE = "Please wait - selecting all Members ...";
}// CASE
else if (MEMBER_TYPES == "ALL") {
INSTRUCTION = "SELECT FL.MEMBERS";
MESSAGE = "Please wait - selecting all Members ...";
}// CASE
else if (OTHERWISE) {
TYPE_COUNT = 0;
INSTRUCTION = "SELECT FL.MEMBERS WITH TYPE =";
do {
THIS_TYPE = FIELD(MEMBER_TYPES, " ", TYPE_COUNT);
if (THIS_TYPE == "") break;
TICKET_CODE = "M*" + THIS_TYPE;
nrf0 = "Z";
nrf1 = TIME();
FL355 = new FL355(ref TICKET_CODE, ref nrf0, ref TODAYS_DATE, ref nrf1, ref TICK_FEES_REC, ref PRICE, ref PERIOD, ref RESPONSE);
if (RESPONSE == FALSE) {
nrf0 = 10;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
goto L80;
}
INSTRUCTION = INSTRUCTION + " \"" + THIS_TYPE + "\"";
TYPE_COUNT = TYPE_COUNT + 1;
} while (true);
MESSAGE = "Please wait - selecting Members with these types ... ";
}
// END CASE
DEAD_COUNT = 0;
INPUT_NO = 0;
/*  Create work files for Member Usage and Bonus */
if (ALL_FILES_DELETE == "Y") {
EOF = FALSE;
PRINT(AT(3, 17) + COMMON.EOL + AT(3, 17) + "Please wait - selecting Member Usage file ...");
SELECT(COMMON.FILES[FL_MEMBER_USAGE]);
do {
if (!READNEXT(ref MU_ID, 0, 0, "")) { EOF = TRUE; }
if (EOF) break;
THIS_MEMBER = FIELD(MU_ID, "*", 1);
if (!READ(ref MU_REC, FL_MUDEL_WORK, THIS_MEMBER)) { MU_REC = ""; }
MU_REC[-1] = MU_ID;
WRITE(MU_REC, FL_MUDEL_WORK, THIS_MEMBER);
} while (true);
EOF = FALSE;
PRINT(AT(3, 17) + COMMON.EOL + AT(3, 17) + "Please wait - selecting Member Bonus file ...");
SELECT(FL_BONUS);
do {
if (!READNEXT(ref BONUS_ID, 0, 0, "")) { EOF = TRUE; }
if (EOF) break;
THIS_MEMBER = FIELD(BONUS_ID, "*", 1);
if (!READ(ref BON_REC, FL_BONUS_WORK, THIS_MEMBER)) { BON_REC = ""; }
BON_REC[-1] = BONUS_ID;
WRITE(BON_REC, FL_BONUS_WORK, THIS_MEMBER);
} while (true);
EOF = FALSE;
SELECT(FL_BONUS_LOST);
do {
if (!READNEXT(ref BONUS_ID, 0, 0, "")) { EOF = TRUE; }
if (EOF) break;
THIS_MEMBER = FIELD(BONUS_ID, "*", 1);
if (!READ(ref BON_REC, FL_BONLST_WORK, THIS_MEMBER)) { BON_REC = ""; }
BON_REC[-1] = BONUS_ID;
WRITE(BON_REC, FL_BONLST_WORK, THIS_MEMBER);
} while (true);
}
if (ALL_FILES_DELETE == "Y") {
/*         GOSUB 900 ;*Initialise Printer */
}
/*  Read Members file */
/*      CRT @(3,17):EOL:@(3,17):'Please wait - selecting Member file ...': */
CRT(AT(3, 17) + COMMON.EOL + AT(3, 17) + MESSAGE);
/*      SELECT MEMBERS */
nrf0 = "OS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref OTHER, ref MESSAGES);
if (NOT(LIST_AVAILABLE)) {
PRINT(AT(3, 18) + "No members found matching this criteria ");
INPUT(out WAIT, 1);
goto L80;
}
CRT(AT(3, 17) + COMMON.EOL + AT(3, 17) + "Members Processed - ");
L10:;
if (!(READNEXT(ref MEMBERS_ID, 0, 0, RTN_LIST))) {
goto L50;
}
MEM_COUNT = MEM_COUNT + 1;
CRTCR(AT(23, 17) + MEM_COUNT);
if (!(READ(ref MEMBERS_REC, COMMON.FILES[MEMBERS], MEMBERS_ID))) {
goto L10;
}
/*      EXP.DATE = MEMBERS.REC<13> */
/*      IF NOT(EXP.DATE MATCHES '0N') THEN GO 10 */
/*      IF EXP.DATE = "" THEN GO 10 */
/*      IF LEN(EXP.DATE) > 5 THEN */
/*         EXP.DATE = ICONV(EXP.DATE,'D2/') */
/*      END */
/*      IF TODAYS.DATE  <= EXP.DATE + DELETION.DAYS THEN GO 10 */
CARDS_HELD = DCOUNT(MEMBERS_REC[13], VM);
CARDS_EXPIRED = 0;
for(TRIES = 1; TRIES <= CARDS_HELD; TRIES += 1) {
if (LEN(MEMBERS_REC[13, TRIES]) > 5) {
MEMBERS_REC[13, TRIES] = ICONV(MEMBERS_REC[13, TRIES], "D");
}
if (TODAYS_DATE > MEMBERS_REC[13, TRIES] + DELETION_DAYS) {
CARDS_EXPIRED = CARDS_EXPIRED + 1;
}
}
if (CARDS_EXPIRED == 0) {
goto L10;
}
if (CARDS_EXPIRED == CARDS_HELD) {
ALL_EXPIRED = TRUE;
L30();
goto L10;
} else {
ALL_EXPIRED = FALSE;
}
if (ALL_EXPIRED == FALSE) {
EXPIRED_MEMBERS_REC = INIT;
for(TRIES = CARDS_HELD; TRIES <= 1; TRIES += -1) {
if (TODAYS_DATE > MEMBERS_REC[13, TRIES] + DELETION_DAYS) {
L100();
/*  Process individual cards */
}
}
}
TRANS_LOG_REC = MEMBERS_REC;
WRITE(MEMBERS_REC, COMMON.FILES[MEMBERS], MEMBERS_ID);
nrf0 = "W";
nrf1 = "FL.MEMBERS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MEMBERS_ID);
/*  Display written record on CRT */
/*      PRINT @(3,10):EOL */
/*      DISPLAY.DATE = OCONV(EXP.DATE,D2) */
/*      PRINT @(3,11):EOL:MEMBERS.ID */
/*      PRINT @(12,11):MEMBERS.REC<4,1> */
/*      PRINT @(39,11):MEMBERS.REC<10,1> */
/*      PRINT @(66,11):DISPLAY.DATE */
goto L10;
}
void L30() {
/*  Write/Delete dead Membership */
DEAD_COUNT = DEAD_COUNT + 1;
AMD_KEY = MEMBERS_ID;
DD_ID = "";
MEMBER_USAGE_ID = "";
BONUS_FLAG = FALSE;
DEBTORS_FLAG = FALSE;
COURSE_STUDENT_NO = "";
FL247 = new FL247(ref MEMBERS_REC, ref DD_ID, ref MEMBER_USAGE_ID, ref BONUS_FLAG, ref DEBTORS_FLAG, ref COURSE_STUDENT_NO, ref ALL_FILES_DELETE, ref PROGRAM);
if (ALL_FILES_DELETE == "Y") {
if (BONUS_FLAG == FALSE) {
BONUS_FLAG = "";
} else {
BONUS_FLAG = "YES";
}
if (DEBTORS_FLAG == FALSE) {
DEBTORS_FLAG = "";
} else {
DEBTORS_FLAG = "YES";
}
if (MEMBER_USAGE_ID != "") {
USAGE_SUFFIX_USED = TRUE;
}
PRINT_REC = FORMAT(MEMBERS_ID, "L#15") + SPACE(4) + FORMAT(MEMBERS_ID, "L#15") + SPACE(4) + FORMAT(MEMBER_USAGE_ID, "L#15") + SPACE(4) + FORMAT(BONUS_FLAG, "L#13") + SPACE(4) + FORMAT(DEBTORS_FLAG, "L#14") + SPACE(4) + COURSE_STUDENT_NO;
/*         GOSUB 90 */
} else {
FL000_45 = new FL000_45(ref MEMBERS_ID, ref MEMBERS_REC);
DELETE(COMMON.FILES[MEMBERS], MEMBERS_ID);
ADT_MEMBER_ID = MEMBERS_ID;
L0600();
/*  Update ADT.LOG */
nrf0 = "D";
nrf1 = "FL.MEMBERS";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref MEMBERS_ID);
}
/*  Display written record on CRT */
CRTCR(AT(3, 10) + COMMON.EOL);
DISPLAY_DATE = OCONV(MEMBERS_REC[13, TRIES], COMMON.D2);
CRTCR(AT(3, 11) + COMMON.EOL + MEMBERS_ID);
CRTCR(AT(12, 11) + MEMBERS_REC[4, 1]);
CRTCR(AT(39, 11) + MEMBERS_REC[10, 1]);
CRTCR(AT(66, 11) + DISPLAY_DATE);
return;
L40:;
/*  Print Error Message */
nrf0 = INIT;FL006 = new FL006(ref PROGRAM, ref INPUT_NO, ref nrf0);
goto L80;
L50:;
/*  Display total number removed */
if (USAGE_SUFFIX_USED) {
if (!(READV(ref DELETION_SUFFIX, COMMON.FILES[MEMBER_PARAMS], "DELETION.SUFFIX", 1))) {
DELETION_SUFFIX = "A";
}
DEC = SEQ(DELETION_SUFFIX);
DEC = DEC + 1;
NEW_SUFFIX = CHAR(DEC);
WRITEV(NEW_SUFFIX, COMMON.FILES[MEMBER_PARAMS], "DELETION.SUFFIX", 1);
}
/*      IF DEAD.COUNT # 0 THEN */
if (ALL_FILES_DELETE == "Y") {
CRT(AT(5, 21) + "Printing report - please wait ... ");
L60();
/* Print Totals */
}
/*         PRINT @(5,21):'PROCESS FINISHED - PRESS RETURN':EOL:;INPUT FLEX,1: */
/*      END ELSE */
/*         PRINT @(20,19):'No Expired (DEAD) Memberships' */
/*         PRINT @(5,21):'*** PROCESS FINISHED ***' */
/*         PRINT @(37,21):'Please press <RETURN> to Exit':;INPUT ANS,2:;IF LEN(ANS) > 1 THEN PRINT @(-9):' ':;ANS=ANS[1,1] */
/*      END */
RELEASE();
return;
}
void L60() {
/*  Print Totals */
/*      PRINT.START.COMMAND = "" */
/*      PRINT.END.COMMAND = "" */
/*      PRINT.COMMANDS = "" */
/*      CALL FL235("STANDARD",PRINT.START.COMMAND,PRINT.END.COMMAND,PRINT.COMMANDS) */
/*      PRINTER ON */
/*      PRINT PRINT.START.COMMAND: */
/* * Print Report Header */
/*      FOR HLINE = 1 TO TOTAL.HLINES */
/*         PRINT HEADER.REC<HLINE> */
/*      NEXT HLINE */
/*      GOSUB 70 ; * Print Page Header */
/*      LINE.COUNT = 0 */
/*      TOTAL.LINES = DCOUNT(PRINT.REC,AM) */
/*      FOR LINE.NO = 1 TO TOTAL.LINES */
/*         PRINT PRINT.REC<LINE.NO> */
/*         LINE.COUNT = LINE.COUNT + 1 */
/*         IF LINE.COUNT = PAGE.DEPTH AND LINE.COUNT NE TOTAL.LINES THEN */
/*            LINE.COUNT = 0 */
/*            PRINT FORMS */
/*            PAGE.NO = PAGE.NO + 1 */
/*            GOSUB 70 ; * Print Page Header */
/*         END */
/*      NEXT LINE.NO */
/*      PRINT STR("=",130) */
/*      PRINT "TOTAL NUMBER OF MEMBERS REMOVED : ":DEAD.COUNT */
/*      PRINT STR("=",130) */
/*      PRINT PRINT.END.COMMAND */
/*      PRINTER CLOSE */
/*      PRINTER OFF */
/*      PRINT FORMS */
CRT(AT(-1));
/*      PRINT STR("=",130) */
PRINTCR("Analysis of expired cards");
/*      CRT 'Analysis of expired cards' */
PRINT();
/*      CRT */
ANAL_COUNT = DCOUNT(EXPIRED_TYPE, AM);
for(TRIES = 1; TRIES <= ANAL_COUNT; TRIES += 1) {
PRINTCR(FORMAT(EXPIRED_TYPE[TRIES], "L#10") + FORMAT(EXPIRED_COUNT[TRIES], "R#4"));
CRTCR(FORMAT(EXPIRED_TYPE[TRIES], "L#10") + FORMAT(EXPIRED_COUNT[TRIES], "R#4"));
}
PRINT();
/*      CRT */
PRINTCR("TOTAL NUMBER OF MEMBERS REMOVED : " + DEAD_COUNT);
/*      CRT "TOTAL NUMBER OF MEMBERS REMOVED : ":DEAD.COUNT */
/*      PRINT STR("=",130) */
/*      PRINT PRINT.END.COMMAND */
/*      PRINTER OFF */
/*      PRINTER CLOSE */
PRINT();
PRINT();
PRINT("Press any key to return to menu ");
INPUTCR(out DUMMY, 1);
return;
L80:;
/*  End of Program */
RELEASE();
return;
L90:;
/*  Print */
if (LINE_COUNT > (PAGE_DEPTH - 1)) {
LINE_COUNT = 0;
PRINTCR(FORMS);
PAGE_NO = PAGE_NO + 1;
L70();
}
LINE_COUNT = LINE_COUNT + 1;
PRINTCR(PRINT_REC);
return;
}
void L70() {
/*  Print Page Header */
for(PHLINE = 1; PHLINE <= TOTAL_PHLINES; PHLINE += 1) {
PRINTCR(PAGE_HEADER_REC[PHLINE]);
}
return;
}
void L100() {
/*  Process card */
/* DEBUG */
if (LOCATE(MEMBERS_REC[2, TRIES], EXPIRED_TYPE, 2, 0, 1, ref PNTR, "AL")) {
EXPIRED_COUNT[PNTR] = EXPIRED_COUNT[PNTR] + 1;
} else {
EXPIRED_TYPE = INSERT(EXPIRED_TYPE, PNTR);
//MEMBERS_REC[2, TRIES]
EXPIRED_COUNT = INSERT(EXPIRED_COUNT, PNTR);
L1:;
}
EXPIRED_MEMBERS_REC[2, -1] = MEMBERS_REC[2, TRIES];
EXPIRED_MEMBERS_REC[13, -1] = MEMBERS_REC[13, TRIES];
MEMBERS_REC = DELETE(MEMBERS_REC, 2, TRIES);
MEMBERS_REC = DELETE(MEMBERS_REC, 13, TRIES);
MEMBERS_REC = DELETE(MEMBERS_REC, 35, TRIES);
return;
}
void L0600() {
/*  Update ADT.LOG */
MAT(ref ADT_REC, "");
ADT_REC[ADT_RECORD_ID] = "FL.MEMBERS" + VM + ADT_MEMBER_ID;
ADT_REC[ADT_DATE] = TODAYS_DATE;
ADT_REC[ADT_USER] = U_INITS;
ADT_REC[ADT_REASON] = "MEMBERSHIP DELETED - " + PROGRAM;
ADT_REC[ADT_TIME] = TIME();
if (!READVU(ref SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1)) { SEQ_NO = 0; }
SEQ_NO = SEQ_NO + 1;
MATWRITE(ADT_REC, FL_ADT_LOG, SEQ_NO);
WRITEV(SEQ_NO, DICT_ADT_LOG, "SEQ.NO", 1);
return;
L900:;
/* Initialise Printer */
if (ALL_FILES_DELETE == "Y") {
PRINT_START_COMMAND = "";
PRINT_END_COMMAND = "";
PRINT_COMMANDS = "";
nrf0 = "COURSES.LANDSCAPE";
FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
PRINTER_ON();
PRINT(PRINT_START_COMMAND);
/*  Print Report Header */
for(HLINE = 1; HLINE <= TOTAL_HLINES; HLINE += 1) {
PRINTCR(HEADER_REC[HLINE]);
}
LINE_COUNT = PAGE_DEPTH + 1;
}
return;
}
}
}
