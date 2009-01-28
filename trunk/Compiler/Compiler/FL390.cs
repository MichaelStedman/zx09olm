//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL390 : UvBase
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
readonly UvVar FL_CUST_INDEX = 86;
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
UvVar[] CUST_INDEX_REC = new UvVar[24];
UvVar[] BOX_DETAILS = new UvVar[10];
#endregion
#region Variables
UvVar NAME = "";
UvVar RESPONSE = "";
UvVar CUST_KEY = "";
UvVar NRM_VID = "";
UvVar DIM_REV_UND_VID = "";
UvVar VM = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar ALPHABET = "";
UvVar LENGTH_OF_NAME = "";
UvVar FIRST = "";
UvVar SECOND = "";
UvVar THIRD = "";
UvVar KEY = "";
UvVar REC = "";
UvVar PNTR = "";
UvVar MV = "";
FL391 FL391;
UvVar COL_NO = "";
UvVar ROW_NO = "";
UvVar LAST_ROW = "";
UvVar START_ROW = "";
UvVar HIGHLIGHT_ROW = "";
UvVar PRINT_NUMBER = "";
UvVar TEMP_REC = "";
UvVar END_NUMBER = "";
UvVar NAMES_DISPLAYED = "";
UvVar KREC = "";
UvVar AREC = "";
UvVar ATT = "";
UvVar PRINT_NAME = "";
UvVar CLINE = "";
UvVar CONTINUE = "";
UvVar ANS = "";
UvVar LENINP = "";
FL019 FL019;
UvVar ANS2 = "";
UvVar ROW_POS = "";
UvVar TEST_MV = "";
UvVar NO_OF_MVS = "";
UvVar HIGHTLIGHT_ROW = "";
FL006 FL006;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL390(ref UvVar NAME, ref UvVar[] BOX_DETAILS, ref UvVar RESPONSE, ref UvVar CUST_KEY) {
this.NAME = NAME;
this.BOX_DETAILS = BOX_DETAILS;
this.RESPONSE = RESPONSE;
this.CUST_KEY = CUST_KEY;
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
/*  Display Possible Names */
PROMPT("");
PROGRAM = "FL390";
/* ******************************* */
/*  Include Files */
/* ******************************* */
#region INCLUDE FL.FILES FL.CUSTOMERS

#endregion
#region INCLUDE FL.FILES FL.CUST.INDEX

#endregion
/* ****************************** */
/*  Assign Variables */
/* ****************************** */
BOX_DETAILS[HEADING_TEXT] = "  \"U\"p, \"D\"own, \"F\"orward, \"B\"ack, number, and <RETURN>, or e\"X\"it ";
RESPONSE = INIT;
CUST_KEY = INIT;
ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
/* ALPHABET = "./' &()-+ABCDEFGHIJKLMNOPQRSTUVWXYZ" */
NAME = OCONV(NAME, "MCU");
/* **************************************** */
/*  Display Accounts */
/* ***************************************** */
LENGTH_OF_NAME = LEN(NAME);
// BEGIN CASE
// CASE
if (LENGTH_OF_NAME == 1) {
FIRST = INDEX(ALPHABET, NAME, 1);
if (FIRST == 0) { FIRST = 1; }
SECOND = 1;
THIRD = 1;
KEY = NAME + "A";
}// CASE
else if (LENGTH_OF_NAME == 2) {
FIRST = INDEX(ALPHABET, NAME.Substring(1, 1), 1);
if (FIRST == 0) { FIRST = 1; }
SECOND = INDEX(ALPHABET, NAME.Substring(2, 1), 1);
if (SECOND == 0) { SECOND = 1; }
THIRD = 1;
KEY = NAME;
}// CASE
else if (OTHERWISE) {
FIRST = INDEX(ALPHABET, NAME.Substring(1, 1), 1);
if (FIRST == 0) { FIRST = 1; }
SECOND = INDEX(ALPHABET, NAME.Substring(2, 1), 1);
if (SECOND == 0) { SECOND = 1; }
THIRD = INDEX(ALPHABET, NAME.Substring(3, 1), 1);
if (THIRD == 0) { THIRD = 1; }
KEY = NAME.Substring(1, 2);
}
// END CASE
if (READ(ref REC, COMMON.FILES[FL_CUST_INDEX], KEY)) {
if (LOCATE(NAME, REC, THIRD, 0, 1, ref PNTR, "AL")) {
MV = PNTR - 1;
} else {
MV = 0;
}
} else {
MV = 0;
}
FL391 = new FL391(ref BOX_DETAILS);
COL_NO = BOX_DETAILS[LEFT_WINDOW] + 4;
ROW_NO = BOX_DETAILS[TOP_WINDOW] + 1;
LAST_ROW = BOX_DETAILS[BOTTOM_WINDOW];
START_ROW = ROW_NO;
HIGHLIGHT_ROW = START_ROW;
PRINT_NUMBER = 0;
TEMP_REC = "";
END_NUMBER = LAST_ROW - START_ROW;
NAMES_DISPLAYED = 1;
INTERACT = INVALID_DATA;
ROW_NO = ROW_NO - 1;
do {
KEY = ALPHABET.Substring(FIRST, 1);
do {
KEY = KEY + ALPHABET.Substring(SECOND, 1);
if (!(READ(ref REC, COMMON.FILES[FL_CUST_INDEX], KEY))) {
REC = "";
INTERACT = LIMIT;
}
if (!READ(ref KREC, COMMON.FILES[FL_CUST_INDEX], "K*" + KEY)) { KREC = ""; }
if (!READ(ref AREC, COMMON.FILES[FL_CUST_INDEX], "A*" + KEY)) { AREC = ""; }
do {
ATT = THIRD;
do {
do {
MV = MV + 1;
PRINT_NAME = REC[ATT, MV];
ROW_NO = ROW_NO + 1;
if (PRINT_NAME == "" || ROW_NO >= LAST_ROW) break;
PRINT_NUMBER = PRINT_NUMBER + 1;
TEMP_REC[PRINT_NUMBER, 1] = PRINT_NAME;
TEMP_REC[PRINT_NUMBER, 2] = AREC[ATT, MV];
TEMP_REC[PRINT_NUMBER, 3] = KREC[ATT, MV];
if (ROW_NO == START_ROW) {
PRINT(AT(COL_NO + 60, ROW_NO) + NRM_VID);
PRINT(AT(COL_NO - 2, ROW_NO) + DIM_REV_UND_VID);
} else {
PRINT(AT(COL_NO - 2, ROW_NO) + NRM_VID);
}
PRINT(AT(COL_NO + 4, ROW_NO) + FORMAT(PRINT_NUMBER, "L#2") + SPACE(3) + FORMAT(PRINT_NAME, "L#20") + SPACE(3) + FORMAT(AREC[ATT, MV], "L#25"));
} while (true);
// BEGIN CASE
// CASE
if (PRINT_NAME == "" && ROW_NO >= LAST_ROW) {
MV = MV - 1;
L0100();
TEMP_REC = "";
}// CASE
else if (PRINT_NAME == "") {
ROW_NO = ROW_NO - 1;
}// CASE
else if (ROW_NO >= LAST_ROW) {
MV = MV - 1;
L0100();
TEMP_REC = "";
}
// END CASE
if (PRINT_NAME == "" || INTERACT == EXIT) break;
} while (true);
if (INTERACT != EXIT) {
THIRD = THIRD + 1;
MV = 0;
if (THIRD > 26) { INTERACT = LIMIT; }
}
if (INTERACT == LIMIT || INTERACT == EXIT) break;
} while (true);
if (INTERACT != EXIT) {
INTERACT = INVALID_DATA;
KEY = ALPHABET.Substring(FIRST, 1);
SECOND = SECOND + 1;
THIRD = 1;
if (SECOND > 26) { INTERACT = LIMIT; }
}
if (INTERACT == LIMIT || INTERACT == EXIT) break;
} while (true);
if (INTERACT != EXIT) {
INTERACT = INVALID_DATA;
FIRST = FIRST + 1;
SECOND = 1;
if (FIRST > 26) {
for(CLINE = ROW_NO + 1; CLINE <= LAST_ROW - 1; CLINE += 1) {
PRINT(AT(COL_NO + 4, CLINE) + SPACE(55));
}
PRINT(AT(BOX_DETAILS[LEFT_WINDOW] + 4, BOX_DETAILS[BOTTOM_WINDOW]) + "END OF LIST");
L0100();
}
}
if (INTERACT == EXIT) break;
} while (true);
/*  The End */
L99:;
return;
/* ****************************************** */
/*  SUBROUTINES                             * */
/* ****************************************** */
}
void L0100() {
/*  Ask for Action */
/*      PRINT @(COL.NO+60,HIGHLIGHT.ROW):NRM.VID: */
/*      PRINT @(COL.NO-2,HIGHLIGHT.ROW):DIM.REV.UND.VID: */
CONTINUE = FALSE;
ECHO_OFF();
do {
if (INTERACT == EXIT || CONTINUE == TRUE) break;
/*        PRINT @(LEFT.WINDOW+50,BOTTOM.WINDOW):NRM.VID: */
PRINT(AT(BOX_DETAILS[LEFT_WINDOW] + 50, BOX_DETAILS[BOTTOM_WINDOW]));
INPUT(out ANS, 1);
// BEGIN CASE
// CASE
if (MATCH(ANS,"0N") && ANS != "") {
PRINT(AT(BOX_DETAILS[LEFT_WINDOW] + 51, BOX_DETAILS[BOTTOM_WINDOW]));
LENINP = 5;
FL019 = new FL019(ref LENINP, ref ANS2);
ANS = ANS + ANS2;
}// CASE
else if (OTHERWISE) {
}
// END CASE
PRINT(AT(BOX_DETAILS[LEFT_WINDOW] + 4, BOX_DETAILS[BOTTOM_WINDOW]) + SPACE(25));
// BEGIN CASE
// CASE
if (ANS == COMMON.ABANDON) {
RESPONSE = COMMON.ABANDON;
INTERACT = EXIT;
/*  Move Up */
}// CASE
else if (ANS == MOVE_UP) {
L0600();
/*  Move Down */
}// CASE
else if (ANS == MOVE_DOWN) {
L0700();
/*  Page Down */
}// CASE
else if (ANS == PAGE_DOWN) {
if (FIRST > 26) { FIRST = 1; }
L0800();
/*  Page Up */
}// CASE
else if (ANS == PAGE_UP) {
L0900();
/*  Accept */
}// CASE
else if (ANS == "") {
ANS = HIGHLIGHT_ROW - BOX_DETAILS[TOP_WINDOW];
CUST_KEY = TEMP_REC[ANS, 3];
L1000();
/*  Exit */
}// CASE
else if (ANS == "X") {
L1100();
/*  Line Number */
}// CASE
else if (MATCH(ANS,"0N")) {
CUST_KEY = TEMP_REC[ANS, 3];
L1000();
/*  Otherwise */
}// CASE
else if (OTHERWISE) {
}
// END CASE
} while (true);
ECHO_ON();
return;
}
void L0400() {
/*  Downlight */
ROW_POS = HIGHLIGHT_ROW - 8;
if (TEMP_REC[ROW_POS, 1] != "") {
PRINT(AT(COL_NO - 2, HIGHLIGHT_ROW) + NRM_VID);
PRINT(AT(COL_NO + 4, HIGHLIGHT_ROW) + FORMAT(ROW_POS, "L#2") + SPACE(3) + FORMAT(TEMP_REC[ROW_POS, 1], "L#20") + SPACE(3) + FORMAT(TEMP_REC[ROW_POS, 2], "L#25"));
}
return;
}
void L0500() {
/*  Highlight */
ROW_POS = HIGHLIGHT_ROW - 8;
if (TEMP_REC[ROW_POS, 1] != "") {
PRINT(AT(COL_NO + 60, HIGHLIGHT_ROW) + NRM_VID);
PRINT(AT(COL_NO - 2, HIGHLIGHT_ROW) + DIM_REV_UND_VID);
PRINT(AT(COL_NO + 4, HIGHLIGHT_ROW) + FORMAT(ROW_POS, "L#2") + SPACE(3) + FORMAT(TEMP_REC[ROW_POS, 1], "L#20") + SPACE(3) + FORMAT(TEMP_REC[ROW_POS, 2], "L#25"));
}
return;
}
void L0600() {
/*  Move Up */
if (HIGHLIGHT_ROW - 1 >= START_ROW) {
L0400();
/*  - Downlight */
HIGHLIGHT_ROW = HIGHLIGHT_ROW - 1;
L0500();
/*  - Highlight */
/*      END ELSE */
/*        CONTINUE = TRUE */
/*        TEMP.REC = "" */
/*        PRINT.NUMBER = "" */
}
return;
}
void L0700() {
/*  Move Down */
if (HIGHLIGHT_ROW + 1 < LAST_ROW) {
L0400();
HIGHLIGHT_ROW = HIGHLIGHT_ROW + 1;
L0500();
/*      END ELSE */
/*        CONTINUE = TRUE */
/*        TEMP.REC = "" */
/*        PRINT.NUMBER = "" */
}
return;
}
void L0800() {
CONTINUE = TRUE;
L0400();
HIGHLIGHT_ROW = START_ROW;
ROW_NO = START_ROW - 1;
TEMP_REC = "";
PRINT_NUMBER = 0;
return;
}
void L0900() {
CONTINUE = TRUE;
L0400();
TEST_MV = MV - (END_NUMBER * 2);
if (TEST_MV <= 0) {
MV = (TEST_MV * (-1));
L0910:;
do {
ATT = ATT - 1;
if (ATT == 0) {
ATT = 26;
SECOND = SECOND - 1;
if (SECOND == 0) {
FIRST = FIRST - 1;
SECOND = 26;
if (FIRST == 0) {
FIRST = 1;
SECOND = 1;
ATT = 0;
goto L0975;
}
}
KEY = ALPHABET.Substring(FIRST, 1) + ALPHABET.Substring(SECOND, 1);
if (!READ(ref REC, COMMON.FILES[FL_CUST_INDEX], KEY)) { REC = ""; }
if (!READ(ref KREC, COMMON.FILES[FL_CUST_INDEX], "K*" + KEY)) { KREC = ""; }
if (!READ(ref AREC, COMMON.FILES[FL_CUST_INDEX], "A*" + KEY)) { AREC = ""; }
}
if (REC[ATT] != "") break;
} while (true);
NO_OF_MVS = DCOUNT(REC[ATT], VM);
if (MV > NO_OF_MVS) {
MV = MV - NO_OF_MVS;
goto L0910;
} else {
MV = NO_OF_MVS - MV;
}
} else {
MV = MV - (END_NUMBER * 2);
}
L0975:;
HIGHTLIGHT_ROW = START_ROW;
ROW_NO = START_ROW - 1;
TEMP_REC = "";
PRINT_NUMBER = 0;
THIRD = ATT;
PRINT_NAME = REC[ATT, MV];
return;
}
void L1000() {
INTERACT = EXIT;
if (!(MATREAD(ref CUST_REC, COMMON.FILES[FL_CUSTOMERS], CUST_KEY))) {
MAT(ref CUST_REC, "");
INTERACT = INVALID_DATA;
nrf0 = 15;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
return;
}
void L1100() {
RESPONSE = FALSE;
INTERACT = EXIT;
return;
/* ******************************************** */
/*  End for Compiler */
/* ******************************************** */
}
}
}
