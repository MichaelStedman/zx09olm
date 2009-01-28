//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL731 : UvBase
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
readonly UvVar SCROLL = 1;
readonly UvVar FL_CONTROL = 10;
readonly UvVar STUDENT_TITLE = 1;
readonly UvVar STUDENT_FORENAME = 2;
readonly UvVar STUDENT_SURNAME = 3;
readonly UvVar STUDENT_ADDRESS1 = 4;
readonly UvVar STUDENT_ADDRESS2 = 5;
readonly UvVar STUDENT_ADDRESS3 = 6;
readonly UvVar STUDENT_ADDRESS4 = 7;
readonly UvVar STUDENT_POST_CODE = 8;
readonly UvVar STUDENT_SEX = 9;
readonly UvVar STUDENT_HOME_TEL = 10;
readonly UvVar STUDENT_WORK_TEL = 11;
readonly UvVar STUDENT_DOB = 12;
readonly UvVar STUDENT_MEDICAL1 = 13;
readonly UvVar STUDENT_MEDICAL2 = 14;
readonly UvVar STUDENT_MEDICAL3 = 15;
readonly UvVar STUDENT_COMMENT1 = 16;
readonly UvVar STUDENT_COMMENT2 = 17;
readonly UvVar STUDENT_COMMENT3 = 18;
readonly UvVar STUDENT_COMMENT4 = 19;
readonly UvVar STUDENT_CONTACT_NAME = 20;
readonly UvVar STUDENT_CONTACT_PHONE = 21;
readonly UvVar STUDENT_DETAIL_IDS = 22;
readonly UvVar STUDENT_BALANCE = 23;
readonly UvVar STUDENT_TRANS_DETAILS_IDS = 24;
readonly UvVar STUDENT_TRANS_DATES = 25;
readonly UvVar STUDENT_TRANS_TYPES = 26;
readonly UvVar STUDENT_TRANS_AMOUNTS = 27;
readonly UvVar STUDENT_TRANS_RECEIPT_NOS = 28;
readonly UvVar STUDENT_TRANS_MOPS = 29;
readonly UvVar STUDENT_TRANS_MAN_RECEIPT = 30;
readonly UvVar STUDENT_TRANS_WEB = 30;
readonly UvVar STUDENT_TRANS_ADJ_REASON = 31;
readonly UvVar STUDENT_TRANS_USER = 32;
readonly UvVar STUDENT_OLD_NUMBERS = 33;
readonly UvVar STUDENT_AWARD1 = 34;
readonly UvVar STUDENT_AWARD2 = 35;
readonly UvVar STUDENT_AWARD3 = 36;
readonly UvVar STUDENT_AWARD4 = 37;
readonly UvVar STUDENT_DOCTOR_NAME = 38;
readonly UvVar STUDENT_DOCTOR_TEL = 39;
readonly UvVar STUDENT_KEYWORD = 40;
readonly UvVar STUDENT_AWARD5 = 41;
readonly UvVar STUDENT_AWARD6 = 42;
readonly UvVar STUDENT_AWARD7 = 43;
readonly UvVar STUDENT_AWARD8 = 44;
readonly UvVar STUDENT_AWARD9 = 45;
readonly UvVar STUDENT_AWARD10 = 46;
readonly UvVar STUDENT_AWARD11 = 47;
readonly UvVar STUDENT_AWARD12 = 48;
readonly UvVar STUDENT_GROUP_ENROLLED = 49;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] STUDENT_REC = new UvVar[60];
#endregion
#region Variables
UvVar ACTION = "";
UvVar STUDENT_ID = "";
UvVar DETAILS_ID = "";
UvVar TRANS_LIST = "";
UvVar DISPLAY_MODE = "";
UvVar REDISPLAY = "";
UvVar TRANS_CNT = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar COLOR_C = "";
UvVar PROGRAM = "";
UvVar INTERACT = "";
UvVar FL_STUDENTS = "";
UvVar WINDOW_ID = "";
UvVar WINDOW = "";
UvVar TOP_WINDOW = "";
UvVar BOTTOM_WINDOW = "";
UvVar LEFT_WINDOW = "";
UvVar RIGHT_WINDOW = "";
UvVar WINDOW_JUST = "";
UvVar WINDOW_DEPTH = "";
UvVar HEADING_TEXT = "";
UvVar HEADING_TEXT2 = "";
UvVar FOOTER = "";
UvVar CNT = "";
UvVar DISP_ROW = "";
UvVar TRANS_MVC = "";
UvVar TRANS_LINE = "";
UvVar DESC = "";
#endregion
public FL731(ref UvVar ACTION, ref UvVar STUDENT_ID, ref UvVar DETAILS_ID, ref UvVar TRANS_LIST, ref UvVar[] STUDENT_REC, ref UvVar DISPLAY_MODE, ref UvVar REDISPLAY, ref UvVar TRANS_CNT) {
this.ACTION = ACTION;
this.STUDENT_ID = STUDENT_ID;
this.DETAILS_ID = DETAILS_ID;
this.TRANS_LIST = TRANS_LIST;
this.STUDENT_REC = STUDENT_REC;
this.DISPLAY_MODE = DISPLAY_MODE;
this.REDISPLAY = REDISPLAY;
this.TRANS_CNT = TRANS_CNT;
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
/*     DISPLAY TRANSACTION HISTORY FOR A STUDENT */
PROGRAM = "FL731";
INTERACT = INVALID_DATA;
REDISPLAY = "";
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.STUDENTS
if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

/*  Manual receipts are a redundant feature */
/*  Attribute now used to indicate web re-enrolment */

#endregion
WINDOW_ID = PROGRAM + ".WINDOW";
if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID))) {
WINDOW = 12;
WINDOW[2] = 18;
WINDOW[3] = 2;
WINDOW[4] = 77;
}
if (DISPLAY_MODE == 1) {
TOP_WINDOW = WINDOW[1];
BOTTOM_WINDOW = WINDOW[2];
LEFT_WINDOW = WINDOW[3];
RIGHT_WINDOW = WINDOW[4];
WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
HEADING_TEXT = WINDOW[5];
HEADING_TEXT2 = WINDOW[6];
} else {
TOP_WINDOW = WINDOW[7];
BOTTOM_WINDOW = WINDOW[8];
LEFT_WINDOW = WINDOW[9];
RIGHT_WINDOW = WINDOW[10];
WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
HEADING_TEXT = WINDOW[11];
HEADING_TEXT2 = WINDOW[12];
}
if (ACTION == SCROLL) {
if (DISPLAY_MODE == 1) {
if (TRANS_LIST[1, TRANS_CNT] == "") { TRANS_CNT = 1; }
} else {
if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_CNT] == "") { TRANS_CNT = 1; }
}
}
if (DISPLAY_MODE == 2) {
FOOTER = "                                 Overall balance for all courses = " + FORMAT(OCONV(STUDENT_REC[STUDENT_BALANCE], "MD2"), "R#7");
} else {
FOOTER = "";
}
PRINT(AT(79, TOP_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW) + UND_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW) + FORMAT(HEADING_TEXT, WINDOW_JUST));
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 1) + UND_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + FORMAT(HEADING_TEXT2, WINDOW_JUST));
CNT = 0;
do {
if (!(INTERACT == INVALID_DATA || INTERACT == LIMIT)) break;
do {
CNT = CNT + 1;
if (CNT >= WINDOW_DEPTH) break;
DISP_ROW = CNT + TOP_WINDOW + 1;
PRINT(AT(79, DISP_ROW) + NRM_VID);
PRINT(AT(RIGHT_WINDOW, DISP_ROW) + NRM_VID);
if (DISPLAY_MODE == 2) {
TRANS_MVC = TRANS_CNT;
} else {
TRANS_MVC = TRANS_LIST[1, TRANS_CNT];
}
// BEGIN CASE
// CASE
if (TRANS_MVC == "") {
PRINT(AT(LEFT_WINDOW - 1, DISP_ROW) + COLOR_C);
PRINT(AT(LEFT_WINDOW, DISP_ROW) + FORMAT("", WINDOW_JUST));
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_MVC] == "") {
PRINT(AT(LEFT_WINDOW - 1, DISP_ROW) + COLOR_C);
PRINT(AT(LEFT_WINDOW, DISP_ROW) + FORMAT("", WINDOW_JUST));
}// CASE
else if (DISPLAY_MODE == 1) {
TRANS_LINE = "";
TRANS_LINE = TRANS_LINE + FORMAT(TRANS_CNT, "R#3") + SPACE(1);
/* *           TRANS.LINE = TRANS.LINE : FIELD(STUDENT.TRANS.DETAILS.IDS<1,TRANS.MVC>,"*",2) "L#8" : SPACE(1) */
L2000();
TRANS_LINE = TRANS_LINE + FORMAT(DESC, "L#7");
TRANS_LINE = TRANS_LINE + FORMAT(OCONV(STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_MVC], "D2/"), "R#8") + SPACE(1);
TRANS_LINE = TRANS_LINE + FORMAT(OCONV(STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_MVC], "MD2"), "R#6") + SPACE(1);
/* *         IF STUDENT.TRANS.TYPES<1,TRANS.MVC> = "A" THEN */
/* *           TRANS.LINE = TRANS.LINE : STUDENT.TRANS.ADJ.REASON<1,TRANS.MVC> "L#17" */
/* *         END ELSE */
TRANS_LINE = TRANS_LINE + FORMAT(STUDENT_REC[STUDENT_TRANS_MOPS][1, TRANS_MVC], "R#2") + SPACE(1);
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_MVC] == "O" && STUDENT_REC[STUDENT_TRANS_MAN_RECEIPT][1, TRANS_MVC] == "W") {
/*  Enrolment via the web */
TRANS_LINE = TRANS_LINE + "(via web)";
} else {
TRANS_LINE = TRANS_LINE + FORMAT(STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, TRANS_MVC], "L#14");
}
/* *         END */
PRINT(AT(LEFT_WINDOW - 1, DISP_ROW) + COLOR_C);
PRINT(AT(LEFT_WINDOW, DISP_ROW) + FORMAT(TRANS_LINE, WINDOW_JUST));
}// CASE
else if (OTHERWISE) {
/*  Display mode = 2 */
TRANS_LINE = "";
TRANS_LINE = TRANS_LINE + FORMAT(TRANS_CNT, "R#4") + SPACE(2);
TRANS_LINE = TRANS_LINE + FORMAT(FIELD(STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_MVC], "*", 2), "L#11") + SPACE(1);
TRANS_LINE = TRANS_LINE + FORMAT(OCONV(FIELD(STUDENT_REC[STUDENT_TRANS_DETAILS_IDS][1, TRANS_MVC], "*", 1), "D2/"), "L#8") + SPACE(2);
L2000();
TRANS_LINE = TRANS_LINE + FORMAT(DESC, "L#7");
TRANS_LINE = TRANS_LINE + FORMAT(OCONV(STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_MVC], "D2/"), "R#8") + SPACE(2);
TRANS_LINE = TRANS_LINE + FORMAT(OCONV(STUDENT_REC[STUDENT_TRANS_AMOUNTS][1, TRANS_MVC], "MD2"), "R#6") + SPACE(2);
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_MVC] == "A" || STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_MVC] == "O" || STUDENT_REC[STUDENT_TRANS_WEB][1, TRANS_MVC] == "T") {
TRANS_LINE = TRANS_LINE + FORMAT(STUDENT_REC[STUDENT_TRANS_ADJ_REASON][1, TRANS_MVC], "L#22");
} else {
TRANS_LINE = TRANS_LINE + FORMAT(STUDENT_REC[STUDENT_TRANS_MOPS][1, TRANS_MVC], "L#2") + SPACE(1);
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_MVC] == "O" && STUDENT_REC[STUDENT_TRANS_MAN_RECEIPT][1, TRANS_MVC] == "W") {
/*  Enrolment via the web */
TRANS_LINE = TRANS_LINE + "(via web)";
} else {
TRANS_LINE = TRANS_LINE + FORMAT(STUDENT_REC[STUDENT_TRANS_RECEIPT_NOS][1, TRANS_MVC], "L#14");
}
}
PRINT(AT(LEFT_WINDOW - 1, DISP_ROW) + COLOR_C);
PRINT(AT(LEFT_WINDOW, DISP_ROW) + FORMAT(TRANS_LINE, WINDOW_JUST));
}
// END CASE
TRANS_CNT = TRANS_CNT + 1;
} while (true);
L1000();
INTERACT = VALID_DATA;
/*  Restart display from first date when end of list is reached */
// BEGIN CASE
// CASE
if (TRANS_MVC == "") {
TRANS_CNT = 1;
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_DATES][1, TRANS_MVC] == "") {
TRANS_CNT = 1;
}
// END CASE
CNT = 0;
} while (true);
/*  Return to calling program */
if (INTERACT == FINISH) {
INTERACT = VALID_DATA;
}
return;
}
void L1000() {
/*  Display last line message */
PRINT(AT(79, CNT + TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW + 1) + UND_VID);
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + FORMAT(FOOTER, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), CNT + TOP_WINDOW + 1));
return;
/* *********************************************************** */
}
void L2000() {
/*  Determine transaction description                    * */
/* *********************************************************** */
// BEGIN CASE
// CASE
if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_MVC] == "O") {
if (STUDENT_REC[STUDENT_TRANS_WEB][1, TRANS_MVC] == "T") {
DESC = "Moved";
} else {
DESC = "Fee";
}
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_MVC] == "P") {
DESC = "Paid";
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_MVC] == "D") {
if (STUDENT_REC[STUDENT_TRANS_WEB][1, TRANS_MVC] == "T") {
DESC = "Moved";
} else {
DESC = "Unenrol";
}
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_MVC] == "R") {
DESC = "Refund";
}// CASE
else if (STUDENT_REC[STUDENT_TRANS_TYPES][1, TRANS_MVC] == "A") {
DESC = "Adjust";
}// CASE
else if (OTHERWISE) {
DESC = "Other";
}
// END CASE
return;
}
}
}
