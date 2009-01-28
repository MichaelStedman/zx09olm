//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL000_15 : UvBase
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
#region Variables
UvVar TICKET_NUMBER = "";
UvVar TICKET_REC = "";
UvVar NARRATIVE = "";
UvVar COURT_DATE = "";
UvVar PORT_NUMBER = "";
UvVar TERMINAL_TYPE = "";
UvVar PROGRAM = "";
UvVar F_OR_S = "";
FL000_19 FL000_19;
UvVar SUBR = "";
CallAt_SUBR CallAt_SUBR;
#endregion
public FL000_15(ref UvVar TICKET_NUMBER, ref UvVar TICKET_REC, ref UvVar NARRATIVE, ref UvVar COURT_DATE) {
this.TICKET_NUMBER = TICKET_NUMBER;
this.TICKET_REC = TICKET_REC;
this.NARRATIVE = NARRATIVE;
this.COURT_DATE = COURT_DATE;
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
/*  FIND WHICH TERMINAL TYPE FROM WHICH TO PRINT TICKET */
/*  AND CALL APPROPRIATE ROUTINE */
PROGRAM = "FL000.15";
if (!(READ(ref F_OR_S, COMMON.FILES[FL_CONTROL], PORT_NUMBER + "*F.OR.S"))) {
F_OR_S = "";
}
/*  make sure the till control is open */
if (FIELD(TICKET_NUMBER, "/", 3) == "CANCEL") {
/*  Don't want to open a session for a null item */
/*    i.e  a cancellation ticket with no refund */
} else {
FL000_19 = new FL000_19();
}
SUBR = PROGRAM + "." + TERMINAL_TYPE;
if (F_OR_S == "F") {
SUBR = SUBR + ".FAST.THERMAL";
}
CallAt_SUBR = new CallAt_SUBR(ref SUBR, ref TICKET_NUMBER, ref TICKET_REC, ref NARRATIVE, ref COURT_DATE);
return;
}
}
}
