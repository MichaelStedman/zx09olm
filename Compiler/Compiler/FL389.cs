//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL389 : UvBase
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
readonly UvVar FL_CUSTOMERS = 85;
readonly UvVar CUST_NAME = 1;
readonly UvVar CUST_INITS = 2;
readonly UvVar CUST_TITLE = 3;
readonly UvVar CUST_ADDRESS1 = 4;
readonly UvVar CUST_ADDRESS2 = 5;
readonly UvVar CUST_ADDRESS3 = 6;
readonly UvVar CUST_ADDRESS4 = 7;
readonly UvVar CUST_POST = 8;
readonly UvVar CUST_HTEL = 9;
readonly UvVar CUST_WTEL = 10;
readonly UvVar CUST_COMMENTS = 11;
readonly UvVar CUST_ACCOUNTS = 12;
readonly UvVar CUST_LAST_ACC = 13;
readonly UvVar CUST_MEMBER_NO = 14;
readonly UvVar CUST_DUE = 15;
readonly UvVar CUST_ORGANISATION = 16;
readonly UvVar CUST_EMAIL_ADDRESS = 17;
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
readonly UvVar TOP_WINDOW = 1;
readonly UvVar BOTTOM_WINDOW = 2;
readonly UvVar LEFT_WINDOW = 3;
readonly UvVar RIGHT_WINDOW = 4;
readonly UvVar WIDTH = 5;
readonly UvVar CLR_LINE = 6;
readonly UvVar WINDOW_SIZE = 7;
readonly UvVar HEADING_TEXT = 8;
#endregion
#region String Constants
readonly UvVar INIT = "";
readonly UvVar MOVE_DOWN = "D";
readonly UvVar MOVE_UP = "U";
readonly UvVar PAGE_DOWN = "F";
readonly UvVar PAGE_UP = "B";
#endregion
#region Arrays
UvVar[] CUST_REC = new UvVar[20];
UvVar[] BLOCK_REC = new UvVar[30];
UvVar[] PASS_REC = new UvVar[15];
UvVar[] BOX_DETAILS = new UvVar[10];
#endregion
#region Variables
UvVar CUST_KEY = "";
UvVar RESPONSE = "";
UvVar BOOKING_KEY = "";
UvVar NRM_VID = "";
UvVar DIM_REV_UND_VID = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
FL391 FL391;
UvVar COL_NO = "";
UvVar ROW_NO = "";
UvVar LAST_ROW = "";
UvVar START_ROW = "";
UvVar HIGHLIGHT_ROW = "";
UvVar HIGHLIGHT_ACCOUNT = "";
UvVar FIRST_ACCOUNT_ON_PAGE = "";
UvVar NO_OF_ACCOUNTS_ON_PAGE = "";
UvVar ACCOUNTS_DISPLAYED = "";
UvVar BOOK_KEY = "";
UvVar PRINT_KEY = "";
UvVar ROW_POS = "";
UvVar ANS = "";
UvVar LENINP = "";
FL019 FL019;
UvVar ANS2 = "";
UvVar HIGHTLIGHT_ROW = "";
FL006 FL006;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL389(ref UvVar[] BOX_DETAILS, ref UvVar CUST_KEY, ref UvVar[] CUST_REC, ref UvVar RESPONSE, ref UvVar BOOKING_KEY) {
this.BOX_DETAILS = BOX_DETAILS;
this.CUST_KEY = CUST_KEY;
this.CUST_REC = CUST_REC;
this.RESPONSE = RESPONSE;
this.BOOKING_KEY = BOOKING_KEY;
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
/*  Display List of Accounts */
PROMPT("");
PROGRAM = "FL389";
/* ******************************* */
/*  Include Files */
/* ******************************* */
#region INCLUDE FL.FILES FL.CUSTOMERS

#endregion
#region INCLUDE FL.FILES FL.BLOCK.HEADER

#endregion
#region INCLUDE FL.FILES FL.PASSWORDS

#endregion
/* ****************************** */
/*  Assign Variables */
/* ****************************** */
BOX_DETAILS[HEADING_TEXT] = "\"U\"p, \"D\"own, \"F\"orward, \"B\"ack, number, and <RETURN>, or e\"X\"it ";
RESPONSE = INIT;
BOOKING_KEY = INIT;
/* **************************************** */
/*  Display Accounts */
/* ***************************************** */
if (CUST_REC[CUST_ACCOUNTS] == "") {
/*  No Accounts exist */
goto L99;
}
FL391 = new FL391(ref BOX_DETAILS);
COL_NO = BOX_DETAILS[LEFT_WINDOW] + 4;
ROW_NO = BOX_DETAILS[TOP_WINDOW] + 1;
LAST_ROW = BOX_DETAILS[BOTTOM_WINDOW];
START_ROW = ROW_NO;
HIGHLIGHT_ROW = START_ROW;
HIGHLIGHT_ACCOUNT = 1;
FIRST_ACCOUNT_ON_PAGE = 1;
NO_OF_ACCOUNTS_ON_PAGE = LAST_ROW - START_ROW;
ACCOUNTS_DISPLAYED = 1;
INTERACT = INVALID_DATA;
do {
if (INTERACT == EXIT) break;
INTERACT = INVALID_DATA;
/*  Display All Accounts */
do {
if (CUST_REC[CUST_ACCOUNTS][1, ACCOUNTS_DISPLAYED] == "" || ROW_NO == LAST_ROW) break;
BOOK_KEY = CUST_REC[CUST_ACCOUNTS][1, ACCOUNTS_DISPLAYED];
PRINT_KEY = CUST_KEY + "/" + BOOK_KEY;
if (!(MATREAD(ref BLOCK_REC, COMMON.FILES[FL_BLOCK_HEADER], PRINT_KEY))) {
MAT(ref BLOCK_REC, "");
}
if (!(MATREAD(ref PASS_REC, COMMON.FILES[FL_PASSWORDS], BLOCK_REC[BLOCK_DEALER]))) {
MAT(ref PASS_REC, "");
}
PRINT(AT(COL_NO + 50, ROW_NO) + NRM_VID);
PRINT(AT(COL_NO - 2, ROW_NO) + DIM_REV_UND_VID);
PRINT(AT(COL_NO, ROW_NO) + FORMAT(ACCOUNTS_DISPLAYED, "L#5") + SPACE(3) + FORMAT(BLOCK_REC[BLOCK_SDESC], "L#20") + FORMAT(OCONV(BLOCK_REC[BLOCK_DATE_MADE], "D"), "L#12") + SPACE(3) + FORMAT(PASS_REC[PASS_NAME], "L#20"));
ROW_NO = ROW_NO + 1;
ACCOUNTS_DISPLAYED = ACCOUNTS_DISPLAYED + 1;
} while (true);
if (LAST_ROW == ROW_NO) { ACCOUNTS_DISPLAYED = ACCOUNTS_DISPLAYED - 1; }
if (LAST_ROW != ROW_NO) {
for(ROW_POS = ROW_NO; ROW_POS <= LAST_ROW; ROW_POS += 1) {
PRINT(AT(1, ROW_POS) + NRM_VID + COMMON.EOL);
}
}
PRINT(AT(COL_NO + 60, HIGHLIGHT_ROW) + NRM_VID);
PRINT(AT(COL_NO - 2, HIGHLIGHT_ROW) + DIM_REV_UND_VID);
PRINT(NRM_VID);
/*  Cursor Control */
do {
if (INTERACT == EXIT || INTERACT == VALID_DATA) break;
ECHO_OFF();
PRINT(AT(BOX_DETAILS[LEFT_WINDOW] + 50, BOX_DETAILS[BOTTOM_WINDOW]));
INPUT(out ANS, 1);
// BEGIN CASE
// CASE
if (MATCH(ANS,"0N") && ANS != "" && ANS != ".") {
PRINT(AT(BOX_DETAILS[LEFT_WINDOW] + 51, BOX_DETAILS[BOTTOM_WINDOW]));
LENINP = 5;
FL019 = new FL019(ref LENINP, ref ANS2);
ANS = ANS + ANS2;
}// CASE
else if (OTHERWISE) {
}
// END CASE
INTERACT = INVALID_DATA;
// BEGIN CASE
/*  Move Up */
// CASE
if (ANS == MOVE_UP) {
L0600();
/*  Move Down */
}// CASE
else if (ANS == MOVE_DOWN) {
L0700();
/*  Page Down */
}// CASE
else if (ANS == PAGE_DOWN) {
L0800();
/*  Page Up */
}// CASE
else if (ANS == PAGE_UP) {
L0900();
/*  Accept */
}// CASE
else if (ANS == "") {
L1000();
/*  Exit */
}// CASE
else if (ANS == "X") {
L1100();
/*  Abandon */
}// CASE
else if (ANS == COMMON.ABANDON) {
INTERACT = EXIT;
RESPONSE = COMMON.ABANDON;
/*  Line Number */
}// CASE
else if (MATCH(ANS,"0N")) {
HIGHLIGHT_ACCOUNT = ANS;
L1000();
/*  Otherwise */
}// CASE
else if (OTHERWISE) {
}
// END CASE
ECHO_ON();
} while (true);
} while (true);
/*  The End */
L99:;
return;
/* ****************************************** */
/*  SUBROUTINES                             * */
/* ****************************************** */
}
void L0400() {
PRINT(AT(COL_NO - 2, HIGHLIGHT_ROW) + NRM_VID);
return;
}
void L0500() {
PRINT(AT(COL_NO + 60, HIGHLIGHT_ROW) + NRM_VID);
PRINT(AT(COL_NO - 2, HIGHLIGHT_ROW) + DIM_REV_UND_VID);
return;
}
void L0600() {
if (HIGHLIGHT_ROW - 1 >= START_ROW) {
L0400();
/*  - Downlight */
HIGHLIGHT_ROW = HIGHLIGHT_ROW - 1;
HIGHLIGHT_ACCOUNT = HIGHLIGHT_ACCOUNT - 1;
L0500();
/*  - Highlight */
}
return;
}
void L0700() {
if (CUST_REC[CUST_ACCOUNTS][1, HIGHLIGHT_ACCOUNT + 1] != "") {
if (HIGHLIGHT_ROW + 1 < LAST_ROW) {
L0400();
HIGHLIGHT_ROW = HIGHLIGHT_ROW + 1;
HIGHLIGHT_ACCOUNT = HIGHLIGHT_ACCOUNT + 1;
L0500();
}
}
return;
}
void L0800() {
if (CUST_REC[CUST_ACCOUNTS][1, ACCOUNTS_DISPLAYED + 1] != "") {
FL391 = new FL391(ref BOX_DETAILS);
INTERACT = VALID_DATA;
HIGHLIGHT_ROW = START_ROW;
FIRST_ACCOUNT_ON_PAGE = FIRST_ACCOUNT_ON_PAGE + NO_OF_ACCOUNTS_ON_PAGE;
HIGHLIGHT_ACCOUNT = ACCOUNTS_DISPLAYED;
ROW_NO = START_ROW;
}
return;
}
void L0900() {
if (ACCOUNTS_DISPLAYED > NO_OF_ACCOUNTS_ON_PAGE) {
FL391 = new FL391(ref BOX_DETAILS);
INTERACT = VALID_DATA;
FIRST_ACCOUNT_ON_PAGE = FIRST_ACCOUNT_ON_PAGE - NO_OF_ACCOUNTS_ON_PAGE;
ACCOUNTS_DISPLAYED = FIRST_ACCOUNT_ON_PAGE;
HIGHLIGHT_ACCOUNT = ACCOUNTS_DISPLAYED;
HIGHTLIGHT_ROW = START_ROW;
ROW_NO = START_ROW;
}
return;
}
void L1000() {
BOOKING_KEY = CUST_REC[CUST_ACCOUNTS][1, HIGHLIGHT_ACCOUNT];
BOOKING_KEY = CUST_KEY + "/" + BOOKING_KEY;
if (!(MATREAD(ref BLOCK_REC, COMMON.FILES[FL_BLOCK_HEADER], BOOKING_KEY))) {
MAT(ref BLOCK_REC, "");
BOOKING_KEY = "";
}
// BEGIN CASE
// CASE
if (BLOCK_REC[BLOCK_SDESC] == "DELETED") {
nrf0 = 13;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (BOOKING_KEY == "") {
nrf0 = 14;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (OTHERWISE) {
RESPONSE = TRUE;
BOOKING_KEY = FIELD(BOOKING_KEY, "/", 2);
INTERACT = EXIT;
}
// END CASE
return;
}
void L1100() {
RESPONSE = FALSE;
INTERACT = EXIT;
BOOKING_KEY = "";
return;
/* ******************************************** */
/*  End for Compiler */
/* ******************************************** */
}
}
}
