//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL_EFT_CARD : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar CALLING_PROG = "";
UvVar CC_REF = "";
UvVar PROMPT_FOR_START = "";
UvVar PROMPT_FOR_ISSUE = "";
UvVar ISSUE_LEN = "";
UvVar AM = "";
UvVar PROGRAM = "";
UvVar CARD_CONTROL = "";
FL006 FL006;
UvVar CRD_CHK = "";
UvVar CRD_MAX = "";
UvVar CRD_CNT = "";
UvVar DONE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL_EFT_CARD(ref UvVar CALLING_PROG, ref UvVar CC_REF, ref UvVar PROMPT_FOR_START, ref UvVar PROMPT_FOR_ISSUE, ref UvVar ISSUE_LEN) {
this.CALLING_PROG = CALLING_PROG;
this.CC_REF = CC_REF;
this.PROMPT_FOR_START = PROMPT_FOR_START;
this.PROMPT_FOR_ISSUE = PROMPT_FOR_ISSUE;
this.ISSUE_LEN = ISSUE_LEN;
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
/*     Locate parameters for credit card or switch number */
/*     IMPORTANT: This routine is called for touchscreens. It cannot */
/*                include any PRINT or INPUT statements unless they are */
/*                conditional on CALLING.PROG. This includes error */
/*                messages via FL006. */
/*  Initialisation */
PROGRAM = "FL.EFT.CARD";
/*  Include relevant file information */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
if (!(READ(ref CARD_CONTROL, COMMON.FILES[FL_CONTROL], "EFT.CARD.CONTROL"))) {
if (CALLING_PROG != "TICKET.TOUCH") {
nrf0 = 99;nrf1 = "";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
/*  Main processing section */
/*      CRD.CHK = CC.REF[1,6] */
CRD_MAX = DCOUNT(CARD_CONTROL, AM);
CRD_CNT = 0;
DONE = FALSE;
PROMPT_FOR_START = FALSE;
PROMPT_FOR_ISSUE = FALSE;
do {
CRD_CNT = CRD_CNT + 1;
if (CRD_CNT > CRD_MAX || DONE) break;
CRD_CHK = CC_REF.Substring(1, LEN(CARD_CONTROL[CRD_CNT, 1]));
if (CRD_CHK >= CARD_CONTROL[CRD_CNT, 1] && CRD_CHK <= CARD_CONTROL[CRD_CNT, 2]) {
if (CARD_CONTROL[CRD_CNT, 4] == TRUE) { PROMPT_FOR_START = TRUE; }
if (CARD_CONTROL[CRD_CNT, 5] > 0) {
PROMPT_FOR_ISSUE = TRUE;
ISSUE_LEN = CARD_CONTROL[CRD_CNT, 5];
}
DONE = TRUE;
}
} while (true);
/*  Return to calling program */
return;
/*  End of program */
}
}
}
