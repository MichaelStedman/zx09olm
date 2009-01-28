//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_MEMO_DISPLAY : UvBase
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
UvVar MEMO_LIST = "";
UvVar MEMO_POS = "";
UvVar MEMO_TOP = "";
UvVar MEMO_WIDTH = "";
UvVar MEMO_DEPTH = "";
UvVar MEMO_HEAD = "";
UvVar AM = "";
UvVar PROGRAM = "";
UvVar LINENO = "";
UvVar XX = "";
#endregion
public FL_MEMO_DISPLAY(ref UvVar MEMO_LIST, ref UvVar MEMO_POS, ref UvVar MEMO_TOP, ref UvVar MEMO_WIDTH, ref UvVar MEMO_DEPTH, ref UvVar MEMO_HEAD) {
this.MEMO_LIST = MEMO_LIST;
this.MEMO_POS = MEMO_POS;
this.MEMO_TOP = MEMO_TOP;
this.MEMO_WIDTH = MEMO_WIDTH;
this.MEMO_DEPTH = MEMO_DEPTH;
this.MEMO_HEAD = MEMO_HEAD;
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
/*  MEMO PROGRAM FOR FWTERM TO DISPLAY (Any attempt to change will be ignored) */
PROGRAM = "FL.MEMO";
PROMPT("");
/*     CLEAR THE SCREEN AND TURN THE CURSOR OFF */
PRINT(CHAR(28) + "45,NONE" + CHAR(20));
/*     SHOW THE MEMO BOX USING CHARACTER BASED POSITIONING */
PRINT(CHAR(28) + "19," + MEMO_POS + "," + MEMO_TOP + "," + MEMO_WIDTH + "," + MEMO_DEPTH + "," + MEMO_HEAD + CHAR(20));
/* !PRINT CHAR(28):"19,C10,C5,C70,C18":CHAR(20): */
/*     POPULATE THE MEMOBOX FROM THE MULTIATTRIBUTED LIST */
for(LINENO = 1; LINENO <= DCOUNT(MEMO_LIST, AM); LINENO += 1) {
PRINT(CHAR(28) + "20," + MEMO_LIST[LINENO] + CHAR(20));
}
/*     TELL THE MEMOBOX TO RETURN NO TEXT */
PRINT(CHAR(28) + "28,0" + CHAR(20));
/*     WAIT UNTIL THE USER CLICKS 'CLOSE' BUTTON */
ECHO_OFF();
INPUT(out XX);
INPUTCR(out XX);
ECHO_ON();
/*     TURN THE CURSOR BACK ON */
PRINT(CHAR(28) + "45,LINE" + CHAR(20));
return;
}
}
}
