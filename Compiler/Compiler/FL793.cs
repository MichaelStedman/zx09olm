//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL793 : UvBase
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
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar COMMENT_MODE = "";
UvVar COMMENTS = "";
UvVar REDISPLAY_START_ROW = "";
UvVar REDISPLAY_END_ROW = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar COLOR_C = "";
UvVar PROGRAM = "";
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar WINDOW_ID = "";
UvVar WINDOW = "";
UvVar TOP_WINDOW = "";
UvVar BOTTOM_WINDOW = "";
UvVar LEFT_WINDOW = "";
UvVar RIGHT_WINDOW = "";
UvVar WINDOW_JUST = "";
UvVar WINDOW_DEPTH = "";
UvVar HEADING_TEXT = "";
UvVar FOOTER = "";
UvVar CNT = "";
UvVar BLANK_FOUND = "";
UvVar LINE_COLOR = "";
UvVar LINE_TEXT = "";
UvVar WAIT = "";
#endregion
public FL793(ref UvVar COMMENT_MODE, ref UvVar COMMENTS, ref UvVar REDISPLAY_START_ROW, ref UvVar REDISPLAY_END_ROW) {
this.COMMENT_MODE = COMMENT_MODE;
this.COMMENTS = COMMENTS;
this.REDISPLAY_START_ROW = REDISPLAY_START_ROW;
this.REDISPLAY_END_ROW = REDISPLAY_END_ROW;
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
/*     DISPLAY COURSE COMMENTS */
PROGRAM = "FL793";
REDISPLAY = "";
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
WINDOW_ID = PROGRAM + ".WINDOW";
if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID))) {
WINDOW = 9;
WINDOW[2] = 13;
WINDOW[3] = 18;
WINDOW[4] = 57;
}
TOP_WINDOW = WINDOW[1];
BOTTOM_WINDOW = WINDOW[2];
LEFT_WINDOW = WINDOW[3];
RIGHT_WINDOW = WINDOW[4];
WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
if (COMMENT_MODE == 1) {
/*  Course comments */
HEADING_TEXT = WINDOW[5];
} else {
HEADING_TEXT = " S T U D E N T   C O M M E N T S";
}
FOOTER = "";
if (COMMENTS[1, 1] != "" || COMMENTS[1, 2] != "" || COMMENTS[1, 3] != "" || COMMENTS[1, 4] != "") {
L0100();
REDISPLAY_START_ROW = TOP_WINDOW;
REDISPLAY_END_ROW = BOTTOM_WINDOW + 1;
} else {
/*  No redisplay necessary */
REDISPLAY_START_ROW = 1;
REDISPLAY_END_ROW = 0;
}
return;
/* *********************************** */
}
void L0100() {
/*  DISPLAY ROUTINE              * */
/* *********************************** */
PRINT(AT(RIGHT_WINDOW + 1, TOP_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW) + UND_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW) + FORMAT(HEADING_TEXT, WINDOW_JUST));
PRINT(NRM_VID);
CNT = 0;
BLANK_FOUND = FALSE;
do {
CNT = CNT + 1;
if (CNT > 4) break;
PRINT(AT(RIGHT_WINDOW, CNT + TOP_WINDOW) + NRM_VID);
LINE_COLOR = COLOR_C;
if (NOT(BLANK_FOUND)) {
LINE_TEXT = " " + COMMENTS[1, CNT];
} else {
LINE_TEXT = "";
}
PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW) + LINE_COLOR);
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW) + FORMAT(LINE_TEXT, WINDOW_JUST));
PRINT(NRM_VID);
} while (true);
L1000();
return;
}
void L1000() {
/*  Display last line message */
FOOTER = "  Press <RETURN> ";
PRINT(AT(RIGHT_WINDOW + 1, CNT + TOP_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW) + UND_VID);
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW) + FORMAT(FOOTER, WINDOW_JUST));
/* !*   PRINT NRM.VID */
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), CNT + TOP_WINDOW));
INPUT(out WAIT, 2);
return;
}
}
}
