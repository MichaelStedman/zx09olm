//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL738 : UvBase
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
UvVar[] COURSE_PARAM_REC = new UvVar[60];
#endregion
#region Variables
UvVar LEVELS_ALLOWED = "";
UvVar BOOKING_DATES = "";
UvVar NO_LEVELS = "";
UvVar NRM_VID = "";
UvVar UND_VID = "";
UvVar ERR_MESS_BACK = "";
UvVar ERR_MESS_FORE = "";
UvVar COLOR_C = "";
UvVar PROGRAM = "";
UvVar INTERACT = "";
UvVar REDISPLAY = "";
UvVar FL_COURSE_PARAMS = "";
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
UvVar BLANK_FOUND = "";
UvVar LINE_COLOR = "";
UvVar YES_OR_NO = "";
UvVar LINE_TEXT = "";
UvVar WAIT = "";
#endregion
public FL738(ref UvVar[] COURSE_PARAM_REC, ref UvVar LEVELS_ALLOWED, ref UvVar BOOKING_DATES, ref UvVar NO_LEVELS) {
this.COURSE_PARAM_REC = COURSE_PARAM_REC;
this.LEVELS_ALLOWED = LEVELS_ALLOWED;
this.BOOKING_DATES = BOOKING_DATES;
this.NO_LEVELS = NO_LEVELS;
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
/*     WARN USER THAT THERE ARE BOOKING LEVELS WHICH CANNOT BE BOOKED YET */
PROGRAM = "FL738";
INTERACT = INVALID_DATA;
REDISPLAY = "";
/*  Include relevant file info */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.COURSE.PARAMS
#region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

#endregion

#region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

#endregion

#endregion
WINDOW_ID = PROGRAM + ".WINDOW";
if (!(READ(ref WINDOW, COMMON.FILES[FL_CONTROL], WINDOW_ID))) {
WINDOW = 9;
WINDOW[2] = 18;
WINDOW[3] = 16;
WINDOW[4] = 58;
}
TOP_WINDOW = WINDOW[1];
BOTTOM_WINDOW = WINDOW[2];
LEFT_WINDOW = WINDOW[3];
RIGHT_WINDOW = WINDOW[4];
WINDOW_JUST = "L#" + (RIGHT_WINDOW - LEFT_WINDOW + 1);
WINDOW_DEPTH = BOTTOM_WINDOW - TOP_WINDOW;
HEADING_TEXT = WINDOW[5];
HEADING_TEXT2 = WINDOW[6];
FOOTER = "";
PRINT(AT(RIGHT_WINDOW + 1, TOP_WINDOW) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW) + UND_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW) + FORMAT(HEADING_TEXT, WINDOW_JUST));
PRINT(NRM_VID);
PRINT(AT(RIGHT_WINDOW + 1, TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, TOP_WINDOW + 1) + UND_VID);
PRINT(AT(LEFT_WINDOW, TOP_WINDOW + 1) + FORMAT(HEADING_TEXT2, WINDOW_JUST));
PRINT(NRM_VID);
/*  Function is set to LIMIT if the user hits <Return> to scroll the display */
CNT = 0;
do {
if (!(INTERACT == INVALID_DATA || INTERACT == LIMIT)) break;
BLANK_FOUND = FALSE;
do {
CNT = CNT + 1;
if (CNT > 8) break;
if (COURSE_PARAM_REC[CNT] == "") { BLANK_FOUND = TRUE; }
PRINT(AT(RIGHT_WINDOW, CNT + TOP_WINDOW + 1) + NRM_VID);
if (LEVELS_ALLOWED[CNT] == TRUE || BLANK_FOUND == TRUE) {
LINE_COLOR = COLOR_C;
YES_OR_NO = "Yes";
} else {
LINE_COLOR = ERR_MESS_BACK + ERR_MESS_FORE;
YES_OR_NO = "No";
}
if (NOT(BLANK_FOUND)) {
LINE_TEXT = FORMAT(CNT, "R#2") + SPACE(2) + FORMAT(COURSE_PARAM_REC[CNT], "L#11") + OCONV(BOOKING_DATES[1, CNT], "D") + SPACE(5) + YES_OR_NO;
} else {
LINE_TEXT = "";
}
PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW + 1) + LINE_COLOR);
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + FORMAT(LINE_TEXT, WINDOW_JUST));
PRINT(NRM_VID);
} while (true);
L1000();
INTERACT = VALID_DATA;
} while (true);
/*  Return to calling program */
if (INTERACT == FINISH) {
INTERACT = VALID_DATA;
}
return;
}
void L1000() {
/*  Display last line message */
FOOTER = "  Press <RETURN> ";
PRINT(AT(RIGHT_WINDOW + 1, CNT + TOP_WINDOW + 1) + NRM_VID);
PRINT(AT(LEFT_WINDOW - 1, CNT + TOP_WINDOW + 1) + UND_VID);
PRINT(AT(LEFT_WINDOW, CNT + TOP_WINDOW + 1) + FORMAT(FOOTER, WINDOW_JUST));
PRINTCR(NRM_VID);
PRINT(AT(LEFT_WINDOW + 2 + LEN(FOOTER), CNT + TOP_WINDOW + 1));
INPUT(out WAIT, 2);
return;
}
}
}
