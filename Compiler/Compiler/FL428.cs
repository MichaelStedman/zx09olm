//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL428 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar CODE = "";
UvVar ATT = "";
UvVar REC1 = "";
UvVar RECORD = "";
UvVar NOTHING_BOOKABLE = "";
UvVar WORKLINE = "";
UvVar PAGE_NO = "";
UvVar UNBK_REC = "";
UvVar UNBK_REC2 = "";
UvVar POSS = "";
UvVar LAST_LINE = "";
UvVar SCREEN_TEXT = "";
UvVar AM = "";
UvVar PROGRAM = "";
UvVar NO_OF_UNBOOKED = "";
UvVar FIRST = "";
UvVar NOTHING = "";
UvVar LAST = "";
UvVar FINAL_ATT = "";
UvVar SWITCH = "";
UvVar EXIT = "";
#endregion
public FL428(ref UvVar CODE, ref UvVar ATT, ref UvVar REC1, ref UvVar RECORD, ref UvVar NOTHING_BOOKABLE, ref UvVar WORKLINE, ref UvVar PAGE_NO, ref UvVar UNBK_REC, ref UvVar UNBK_REC2, ref UvVar POSS, ref UvVar LAST_LINE) {
this.CODE = CODE;
this.ATT = ATT;
this.REC1 = REC1;
this.RECORD = RECORD;
this.NOTHING_BOOKABLE = NOTHING_BOOKABLE;
this.WORKLINE = WORKLINE;
this.PAGE_NO = PAGE_NO;
this.UNBK_REC = UNBK_REC;
this.UNBK_REC2 = UNBK_REC2;
this.POSS = POSS;
this.LAST_LINE = LAST_LINE;
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
/*  Find Next Free */
/*  old prog num was FL0001.3.1.1.FIND */
PROMPT("");
PROGRAM = "FL428";
/* ********************************* */
/*  Main Process */
/* ********************************* */
NO_OF_UNBOOKED = DCOUNT(RECORD, AM);
FIRST = ((PAGE_NO * 26) - 25);
NOTHING = ((PAGE_NO * 26) - 26);
LAST = (PAGE_NO * 26);
// BEGIN CASE
// CASE
if (CODE == COMMON.DOWN || CODE == INIT) {
FINAL_ATT = ATT - 1;
if (FINAL_ATT <= NOTHING) { FINAL_ATT = FIRST; }
do {
ATT = ATT + 1;
if (ATT > LAST) { ATT = FIRST; }
WORKLINE = RECORD[ATT];
if (WORKLINE[1, 3] > 0 || FINAL_ATT == ATT) break;
} while (true);
if (FINAL_ATT == ATT && WORKLINE[1, 3] < 0) {
NOTHING_BOOKABLE = TRUE;
}
}// CASE
else if (CODE == COMMON.UP) {
FINAL_ATT = ATT + 1;
do {
ATT = ATT - 1;
if (ATT <= NOTHING) { ATT = LAST; }
WORKLINE = RECORD[ATT];
if (WORKLINE[1, 3] > 0 || FINAL_ATT == ATT) break;
} while (true);
if (FINAL_ATT == ATT && WORKLINE[1, 3] < 0) {
NOTHING_BOOKABLE = TRUE;
}
}// CASE
else if (CODE == COMMON.RIGHT) {
SWITCH = FALSE;
if (ATT > LAST) {
ATT = ATT - 27;
FINAL_ATT = ATT;
if (REC1 == TRUE) {
REC1 = FALSE;
RECORD = UNBK_REC2;
} else {
REC1 = TRUE;
RECORD = UNBK_REC;
}
NO_OF_UNBOOKED = DCOUNT(RECORD, AM);
if (NO_OF_UNBOOKED == 0) {
NOTHING_BOOKABLE = TRUE;
return;
}
SWITCH = TRUE;
} else {
FINAL_ATT = ATT - 13;
}
do {
ATT = ATT + 1;
if (ATT > (LAST - 13) && SWITCH == TRUE) {
do {
ATT = ATT - 1;
WORKLINE = RECORD[ATT];
if (WORKLINE[1, 3] > 0 || ATT == NOTHING) break;
} while (true);
if (ATT == NOTHING) {
ATT = ATT + 14;
SWITCH = FALSE;
}
}
if (ATT > LAST) {
if (SWITCH == FALSE) {
EXIT = FALSE;
ATT = LAST + 1;
do {
ATT = ATT - 1;
if (ATT < (LAST - 12)) {
if (REC1 == TRUE) {
REC1 = FALSE;
RECORD = UNBK_REC2;
} else {
REC1 = TRUE;
RECORD = UNBK_REC;
}
NO_OF_UNBOOKED = DCOUNT(RECORD, AM);
if (NO_OF_UNBOOKED == 0) {
NOTHING_BOOKABLE = TRUE;
return;
}
ATT = FINAL_ATT;
FINAL_ATT = FINAL_ATT - 1;
if (FINAL_ATT <= NOTHING) {
if (LAST >= NO_OF_UNBOOKED) { FINAL_ATT = NO_OF_UNBOOKED; } else { FINAL_ATT = LAST; }
}
SWITCH = TRUE;
EXIT = TRUE;
}
WORKLINE = RECORD[ATT];
if (WORKLINE[1, 3] > 0 || FINAL_ATT == ATT || EXIT == TRUE) break;
} while (true);
} else {
ATT = FIRST;
}
}
WORKLINE = RECORD[ATT];
if (WORKLINE[1, 3] > 0 || FINAL_ATT == ATT) break;
if (FINAL_ATT < FIRST) { FINAL_ATT = FIRST; }
} while (true);
if (FINAL_ATT == ATT && WORKLINE[1, 3] < 0) {
NOTHING_BOOKABLE = TRUE;
}
}// CASE
else if (CODE == COMMON.LEFT) {
SWITCH = FALSE;
if (ATT < FIRST) {
ATT = ATT + 27;
FINAL_ATT = ATT;
if (REC1 == TRUE) {
REC1 = FALSE;
RECORD = UNBK_REC2;
} else {
REC1 = TRUE;
RECORD = UNBK_REC;
}
NO_OF_UNBOOKED = DCOUNT(RECORD, AM);
if (NO_OF_UNBOOKED == 0) {
NOTHING_BOOKABLE = TRUE;
return;
}
SWITCH = TRUE;
} else {
FINAL_ATT = ATT + 13;
}
do {
ATT = ATT - 1;
if (ATT < (LAST - 12) && SWITCH == TRUE) {
do {
ATT = ATT + 1;
WORKLINE = RECORD[ATT];
if (WORKLINE[1, 3] > 0 || ATT >= LAST) break;
} while (true);
if (ATT >= LAST) {
ATT = FINAL_ATT - 14;
FINAL_ATT = ATT + 1;
if (FINAL_ATT > LAST) { FINAL_ATT = LAST; }
SWITCH = FALSE;
}
}
if (ATT < FIRST) {
if (SWITCH == FALSE) {
EXIT = FALSE;
FINAL_ATT = NO_OF_UNBOOKED;
do {
ATT = ATT + 1;
/* HS!               IF ATT > (LAST - 12) THEN */
if (ATT > LAST) {
if (REC1 == TRUE) {
REC1 = FALSE;
RECORD = UNBK_REC2;
} else {
REC1 = TRUE;
RECORD = UNBK_REC;
}
NO_OF_UNBOOKED = DCOUNT(RECORD, AM);
if (NO_OF_UNBOOKED == 0) {
NOTHING_BOOKABLE = TRUE;
return;
}
ATT = FINAL_ATT;
FINAL_ATT = FINAL_ATT + 1;
if (FINAL_ATT >= LAST && FINAL_ATT == NO_OF_UNBOOKED) {
FINAL_ATT = FIRST;
}
SWITCH = TRUE;
EXIT = TRUE;
}
WORKLINE = RECORD[ATT];
if (WORKLINE[1, 3] > 0 || FINAL_ATT == ATT || EXIT == TRUE) break;
} while (true);
} else {
if (LAST > NO_OF_UNBOOKED) { ATT = NO_OF_UNBOOKED; } else { ATT = LAST; }
}
}
WORKLINE = RECORD[ATT];
if (WORKLINE[1, 3] > 0 || FINAL_ATT == ATT) break;
if (FINAL_ATT > LAST) { FINAL_ATT = LAST; }
} while (true);
if (FINAL_ATT == ATT && WORKLINE[1, 3] < 0) {
NOTHING_BOOKABLE = TRUE;
}
}// CASE
else if (OTHERWISE) {
FINAL_ATT = ATT;
if (LAST_LINE != "") {
PRINT(AT(POSS - 1, LAST_LINE) + SCREEN_TEXT);
PRINT(AT(POSS, LAST_LINE) + SPACE(10));
}
do {
ATT = ATT + 1;
if (ATT > LAST) { ATT = FIRST; }
WORKLINE = RECORD[ATT];
if (WORKLINE[1, 3] > 0 || FINAL_ATT == ATT) break;
} while (true);
if (FINAL_ATT == ATT && WORKLINE[1, 3] < 0) {
NOTHING_BOOKABLE = TRUE;
}
}
// END CASE
return;
/* ****************************** */
/*  END OF PROGRAM */
/* ****************************** */
}
}
}
