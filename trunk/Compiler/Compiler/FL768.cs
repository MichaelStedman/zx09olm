//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL768 : UvBase
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
readonly UvVar FL_CONTROL = 10;
readonly UvVar TRANS_FILENAME = 1;
readonly UvVar TRANS_SELECT_LIST = 2;
readonly UvVar TRANS_PROCEDURE = 3;
readonly UvVar TRANS_DIRECTORY = 4;
readonly UvVar TRANS_DESTINATION = 5;
readonly UvVar TRANS_SEQ_OVER = 6;
readonly UvVar TRANS_TEMPLATE = 7;
readonly UvVar TRANS_DOCUMENT = 8;
readonly UvVar TRANS_MACRO = 9;
readonly UvVar TRANS_APPLICATION = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] TRANS_REC = new UvVar[20];
#endregion
#region Variables
UvVar TEMPLATE_ID = "";
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar MACHINE_TYPE = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar COLOR_C = "";
UvVar PROGRAM = "";
UvVar PROCESS_EXECUTE = "";
UvVar FL_UNIVERSE_TRANSFER = "";
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
UvVar TEMPLATE_LIST = "";
UvVar CODES_FOUND = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGE = "";
UvVar ERRORS = "";
CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
UvVar EOF = "";
UvVar CC = "";
UvVar ID = "";
FL006 FL006;
UvVar WAIT = "";
UvVar FOOTER2 = "";
UvVar REPLY2 = "";
FLTX2 FLTX2;
UvVar TEMPLATE_NO = "";
UvVar BLANK_DISPLAY_COMPLETE = "";
UvVar CNT = "";
UvVar DISPLAY_LINE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL768(ref UvVar TEMPLATE_ID, ref UvVar INTERACT, ref UvVar REDISPLAY) {
this.TEMPLATE_ID = TEMPLATE_ID;
this.INTERACT = INTERACT;
this.REDISPLAY = REDISPLAY;
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
/*     EXPORT TEMPLATE LIST / SELECTION SCREEN */
PROGRAM = "FL768";
INTERACT = INVALID_DATA;
REDISPLAY = "";
COMMON.CLR = "\\";
TEMPLATE_ID = "";
PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.UNIVERSE.TRANSFER

if (!(OPEN("FL.UNIVERSE.TRANSFER", out FL_UNIVERSE_TRANSFER))) {
STOP(201, "CANNOT OPEN FILES");
}

#endregion
WINDOW_ID = PROGRAM + ".WINDOW";
if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID))) {
WINDOW = 9;
WINDOW[2] = 18;
WINDOW[3] = 1;
WINDOW[4] = 77;
}
TOP_WINDOW = WINDOW[1];
BOTTOM_WINDOW = WINDOW[2];
LEFT_WINDOW = WINDOW[3];
RIGHT_WINDOW = WINDOW[4];
WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
HEADING_TEXT = WINDOW[5];
HEADING_TEXT2 = WINDOW[6];
FOOTER = " Template No, 'Dn' to Delete, 'N'ew or <Return> ";
TEMPLATE_LIST = "";
/*  Box heading */
PRINT(AT(79, TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + UND_VID + FORMAT(HEADING_TEXT, WINDOW_JUST));
/*  Box Sub-Heading */
PRINT(AT(79, TOP_WINDOW + 2) + NRM_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 2) + UND_VID + FORMAT(HEADING_TEXT2, WINDOW_JUST));
L3000();
/*  Display data portion of window */
/*  Display blank box footing */
PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + UND_VID + FORMAT(INIT, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
CODES_FOUND = FALSE;
do {
if (INTERACT == EXIT || CODES_FOUND) break;
INSTRUCTION = "SSELECT FL.UNIVERSE.TRANSFER = \"FILE*]\"";
nrf0 = "SO";
CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
EOF = FALSE;
CC = 0;
do {
if (!READNEXT(ref ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
CC = CC + 1;
TEMPLATE_LIST[1, CC] = ID;
} while (true);
if (CC == 0) {
/*     No items selected */
nrf0 = 2;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
INTERACT = EXIT;
} else {
CODES_FOUND = TRUE;
}
} while (true);
/*  Function is set to LIMIT if the user hits <Return> to scroll the display */
if (INTERACT != EXIT) {
L3000();
/*  Display data portion of window */
}
/*  Return to calling program */
if (INTERACT == FINISH) {
INTERACT = VALID_DATA;
}
return;
}
void L1000() {
/*  Display last line message */
INTERACT = INVALID_DATA;
do {
PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + UND_VID + FORMAT(FOOTER, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 1 + LEN(FOOTER), 2 + BOTTOM_WINDOW));
INPUT(out WAIT, 4);
// BEGIN CASE
// CASE
if (WAIT == COMMON.ABANDON) {
INTERACT = EXIT;
REDISPLAY = TOP_WINDOW;
}// CASE
else if (WAIT == "N" || WAIT == "n") {
/*  New entry */
INTERACT = FINISH;
TEMPLATE_ID = "N";
REDISPLAY = TOP_WINDOW;
}// CASE
else if (WAIT == "0") {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}// CASE
else if (MATCH(WAIT,"0N") && WAIT != "") {
TEMPLATE_ID = TEMPLATE_LIST[1, WAIT].Substring(6, 99);
if (TEMPLATE_ID == "") {
nrf0 = 1;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
INTERACT = FINISH;
REDISPLAY = TOP_WINDOW;
}
}// CASE
else if ((WAIT.Substring(1, 1) == "D" || WAIT == "d") && MATCH(WAIT.Substring(2, 99),"0N")) {
TEMPLATE_ID = TEMPLATE_LIST[1, WAIT.Substring(2, 99)];
if (TEMPLATE_ID == "") {
nrf0 = 3;
nrf1 = INIT;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
} else {
FOOTER2 = " Delete " + TEMPLATE_ID.Substring(6, 99) + "? (Y/N) ";
PRINT(AT(79, 2 + BOTTOM_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW, 2 + BOTTOM_WINDOW) + UND_VID + FORMAT(FOOTER2, WINDOW_JUST));
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER2), 2 + BOTTOM_WINDOW));
INPUT(out REPLY2, 2);
if (REPLY2 == "Y" || REPLY2 == "y") {
DELETE(FL_UNIVERSE_TRANSFER, TEMPLATE_ID);
nrf0 = "D";
nrf1 = "FL.UNIVERSE.TRANSFER";
FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref TEMPLATE_ID);
TEMPLATE_LIST = DELETE(TEMPLATE_LIST, 1, WAIT.Substring(2, 99), 0);
}
TEMPLATE_NO = 1;
INTERACT = LIMIT;
}
}// CASE
else if (OTHERWISE) {
INTERACT = LIMIT;
}
// END CASE
if (!(INTERACT == INVALID_DATA)) break;
} while (true);
return;
/* *************************************************** */
}
void L3000() {
/*   Display data section of window              * */
/* *************************************************** */
TEMPLATE_NO = 1;
INTERACT = INVALID_DATA;
BLANK_DISPLAY_COMPLETE = FALSE;
do {
if (!((INTERACT == INVALID_DATA || INTERACT == LIMIT) && BLANK_DISPLAY_COMPLETE == FALSE)) break;
CNT = 0;
do {
CNT = CNT + 1;
TEMPLATE_ID = TEMPLATE_LIST[1, TEMPLATE_NO];
if (CNT >= WINDOW_DEPTH) break;
PRINT(AT(79, CNT + 10) + NRM_VID);
if (TEMPLATE_ID == "") {
PRINT(AT(LEFT_WINDOW, CNT + 10) + COLOR_C + FORMAT("", WINDOW_JUST));
} else {
if (!MATREAD(ref TRANS_REC, FL_UNIVERSE_TRANSFER, TEMPLATE_ID)) { MAT(ref TRANS_REC, ""); }
DISPLAY_LINE = FORMAT(TEMPLATE_NO, "R#4") + "  " + FORMAT(TEMPLATE_ID.Substring(6, 99), "L#15");
PRINT(AT(LEFT_WINDOW, CNT + 10) + COLOR_C + FORMAT(DISPLAY_LINE, WINDOW_JUST));
}
TEMPLATE_NO = TEMPLATE_NO + 1;
} while (true);
/*  Don't prompt for template no. if this is the initial call to display a */
/*  'blank' window */
if (TEMPLATE_LIST != "") { L1000(); } else { BLANK_DISPLAY_COMPLETE = TRUE; }
/*  Restart display from first date when end of list is reached */
if (TEMPLATE_ID == "") {
TEMPLATE_NO = 1;
}
CNT = 0;
} while (true);
return;
}
}
}
