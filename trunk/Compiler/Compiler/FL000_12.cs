//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL000_12 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_TICKETS = 11;
readonly UvVar TICKET_SEQ = 63;
readonly UvVar FL_TILL_CONTROL = 91;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar CALLING_PROGRAM = "";
UvVar NEXT_TICKET_NUMBER = "";
UvVar UPDATE_TICKET_NUMBER = "";
UvVar CURRENT_SESSION = "";
UvVar MACHINE_TYPE = "";
UvVar U_INITS = "";
UvVar TODAYS_DATE = "";
UvVar TILL_NUMBER = "";
UvVar PROG_MESS = "";
UvVar TRANS_LOG_REC = "";
UvVar EXECUTE_PROG = "";
UvVar LAST_NUMBER = "";
UvVar LTN_REC = "";
UvVar SESSION_MASTER = "";
UvVar TEST_SYSTEM_DATE = "";
UvVar TEST_DATE = "";
UvVar ACTUAL_TICKET = "";
FLTX2 FLTX2;
UvVar TICK_REC = "";
UvVar SSTATEMENT = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar EOF = "";
UvVar TILL_KEY = "";
UvVar TILL_REC = "";
UvVar TILL_TO_CHOSE = "";
UvVar SESSION_NUMBER = "";
UvVar LAST_SESSION = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL000_12(ref UvVar CALLING_PROGRAM, ref UvVar NEXT_TICKET_NUMBER, ref UvVar UPDATE_TICKET_NUMBER, ref UvVar CURRENT_SESSION) {
this.CALLING_PROGRAM = CALLING_PROGRAM;
this.NEXT_TICKET_NUMBER = NEXT_TICKET_NUMBER;
this.UPDATE_TICKET_NUMBER = UPDATE_TICKET_NUMBER;
this.CURRENT_SESSION = CURRENT_SESSION;
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
/*  GETS THE NEXT TICKET/RECEIPT NUMBER * */
/*  I M P O R T A N T !!! */
/*  THIS ROUTINE IS CALLED TO GENERATE TICKET NUMBERS FOR A */
/*  'VIRTUAL TILL' DURING WEB BOOKINGS. THEREFORE IT MUST NOT */
/*  PRODUCE SCREEN OUTPUT, INPUT PROMPTS OR ERROR MESSAGES. */
/*  WEB BOOKINGS HAS TO EXPLICITLY OPEN THE FILES IT REQUIRES */
/*  AS FL002 IS NOT RUN. */
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
/*  files used */
#region INCLUDE FL.FILES FL.TILL.CONTROL

#endregion
if (PROG_MESS[24] != "") {
/*  DJA 15.1.02 */
/*  Web/cross-centre booking. Use the correct centre code */
/*  which has been passed in the common variable prog.mess */
LAST_NUMBER = PROG_MESS[24] + "*LAST.NUMBER";
} else {
LAST_NUMBER = COMMON.CENTRE + "*LAST.NUMBER";
}
/*  get a new ticket number */
if (!(READU(ref LTN_REC, COMMON.FILES[TICKET_SEQ], LAST_NUMBER))) {
LTN_REC = "";
}
SESSION_MASTER = "SESSION.MASTER.TILL." + TILL_NUMBER;
if (!(READV(ref CURRENT_SESSION, COMMON.FILES[FL_TILL_CONTROL], SESSION_MASTER, 1))) {
CURRENT_SESSION = 1;
}
// BEGIN CASE
// CASE
if (LTN_REC[2] == TODAYS_DATE) {
NEXT_TICKET_NUMBER = LTN_REC[1] + 1;
}// CASE
else if (OTHERWISE) {
/* ** */
/*  in case a terminal has been left logged on from the previous day */
/* ** */
if (LTN_REC[2] < TODAYS_DATE) {
NEXT_TICKET_NUMBER = 1;
L1000();
/*  Close all outstanding sessions */
} else {
TODAYS_DATE = DATE();
if (CALLING_PROGRAM != "FWBOOK" && CALLING_PROGRAM != "FWUPDATEBOOKING" && CALLING_PROGRAM != "FWMEMBERSHIPPAYMENT") {
if (OPEN("FL.TEST.SYSTEM.DATE", out TEST_SYSTEM_DATE)) {
if (READV(ref TEST_DATE, TEST_SYSTEM_DATE, "DATE", 1)) {
TODAYS_DATE = TEST_DATE;
}
}
}
NEXT_TICKET_NUMBER = LTN_REC[1] + 1;
}
}
// END CASE
if (PROG_MESS[24] != "") {
/*  DJA 15.1.02 */
/*  Web/cross-centre booking. Use the correct centre code */
/*  which has been passed in the common variable prog.mess */
ACTUAL_TICKET = PROG_MESS[24] + "/" + TODAYS_DATE + "/" + NEXT_TICKET_NUMBER;
} else {
ACTUAL_TICKET = COMMON.CENTRE + "/" + TODAYS_DATE + "/" + NEXT_TICKET_NUMBER;
}
/*  the end */
LTN_REC[1] = NEXT_TICKET_NUMBER;
LTN_REC[2] = TODAYS_DATE;
WRITE(LTN_REC, COMMON.FILES[TICKET_SEQ], LAST_NUMBER);
TRANS_LOG_REC = LTN_REC;
nrf0 = "W";nrf1 = "DICT FL.TICKETS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref LAST_NUMBER);
NEXT_TICKET_NUMBER = ACTUAL_TICKET;
UPDATE_TICKET_NUMBER = TRUE;
/*  issue 'not issued' ticket (which will be overwritten if */
/*  process is not abandoned) */
TICK_REC = "";
TICK_REC[1] = "XXX";
TICK_REC[2] = 1;
TICK_REC[3] = 0;
TICK_REC[4] = TODAYS_DATE;
TICK_REC[5] = ICONV(TIMEDATE().Substring(1, 8), COMMON.MTS);
TICK_REC[6] = 0;
TICK_REC[7] = "C";
TICK_REC[8] = U_INITS + " - " + CALLING_PROGRAM;
TICK_REC[9] = TILL_NUMBER;
TICK_REC[16] = CURRENT_SESSION;
WRITE(TICK_REC, COMMON.FILES[FL_TICKETS], ACTUAL_TICKET);
TRANS_LOG_REC = TICK_REC;
nrf0 = "W";nrf1 = "FL.TICKETS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref ACTUAL_TICKET);
return;
}
void L1000() {
/*   Close all outstanding sessions */
if (CALLING_PROGRAM == "FWBOOK" || CALLING_PROGRAM == "FWUPDATEBOOKING" && CALLING_PROGRAM != "FWMEMBERSHIPPAYMENT") {
/*  Web bookings should only close down sessions for the */
/*  virtual till */
/* DJA 20.5.02*WRITE TILL.NUMBER ON FL.TILL.CONTROL,"MANNI.TILL.NUMBER" */
/* !*     SSTATEMENT = 'SELECT FL.TILL.CONTROL WITH KEY1 = "SESSION" AND WITH KEY2 = "':TILL.NUMBER:'" AND WITH 7 = "1" AND WITH EVERY 4 < "':OCONV(TODAYS.DATE,'D2/'):'"' */
SSTATEMENT = "SELECT FWQ." + PROG_MESS[24] + ".TILL.CONTROL WITH KEY1 = \"SESSION\" AND WITH 7 = \"1\" AND WITH EVERY 4 < \"" + OCONV(TODAYS_DATE, "D2/") + "\"";
} else {
SSTATEMENT = "SELECT FL.TILL.CONTROL WITH KEY1 = \"SESSION\" AND WITH 7 = \"1\" AND WITH EVERY 4 < \"" + OCONV(TODAYS_DATE, "D2/") + "\"";
}
/*      EXECUTE SSTATEMENT CAPTURING MESSAGES RETURNING OTHERS */
nrf0 = "OS";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref SSTATEMENT, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
/* DJA 20.5.02*WRITE LIST.AVAILABLE ON FL.TILL.CONTROL,"MANNI.LIST" */
EOF = FALSE;
if (LIST_AVAILABLE) {
do {
if (!READNEXT(ref TILL_KEY, 0, 0, RTN_LIST)) { EOF = TRUE; }
if (EOF) break;
if (READ(ref TILL_REC, COMMON.FILES[FL_TILL_CONTROL], TILL_KEY)) {
TILL_TO_CHOSE = FIELD(TILL_KEY, ".", 2);
/* !*           IF TILL.TO.CHOSE = TILL.NUMBER OR CALLING.PROGRAM <> "FWBOOK" THEN */
TILL_REC[3, 2] = "S";
TILL_REC[4, 2] = TODAYS_DATE;
TILL_REC[5, 2] = ICONV(TIMEDATE().Substring(1, 8), COMMON.MTS);
TILL_REC[6, 2] = U_INITS;
TILL_REC[7] = 2;
WRITE(TILL_REC, COMMON.FILES[FL_TILL_CONTROL], TILL_KEY);
TRANS_LOG_REC = TILL_REC;
nrf0 = "W";nrf1 = "FL.TILL.CONTROL";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref TILL_KEY);
SESSION_MASTER = "SESSION.MASTER.TILL." + TILL_TO_CHOSE;
if (READ(ref SESSION_NUMBER, COMMON.FILES[FL_TILL_CONTROL], SESSION_MASTER)) {
LAST_SESSION = SESSION_NUMBER;
CURRENT_SESSION = LAST_SESSION + 1;
WRITE(CURRENT_SESSION, COMMON.FILES[FL_TILL_CONTROL], SESSION_MASTER);
TRANS_LOG_REC = CURRENT_SESSION;
nrf0 = "W";nrf1 = "FL.TILL.CONTROL";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref SESSION_MASTER);
}
/* !*           END */
}
} while (true);
}
SESSION_MASTER = "SESSION.MASTER.TILL." + TILL_NUMBER;
if (!(READV(ref CURRENT_SESSION, COMMON.FILES[FL_TILL_CONTROL], SESSION_MASTER, 1))) {
CURRENT_SESSION = 1;
}
return;
}
}
}
