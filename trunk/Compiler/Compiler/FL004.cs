//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL004 : UvBase
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
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar ALL_CLEAR = "";
UvVar TRANS_LOG_REC = "";
UvVar TX_ATT = "";
UvVar PROGRAM = "";
UvVar FL_CONTROL = "";
UvVar FL_TILL_NUMBERS = "";
UvVar FL_PASSWORDS = "";
UvVar PORT_ID = "";
UvVar EXECUTE_PROG = "";
UvVar INSTRUCTION = "";
UvVar RTN_LIST = "";
UvVar LIST_AVAILABLE = "";
UvVar MESSAGES = "";
UvVar OTHERS = "";
CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
UvVar CCI = "";
UvVar PORT_NUMBER_AND_ACCOUNT = "";
UvVar LINE_NUMBER = "";
UvVar TSRESPONSE = "";
UvVar PRE4_CHECK = "";
UvVar KEYIN = "";
UvVar TILL_ERROR_ID = "";
UvVar AGAIN = "";
UvVar PORT_NUMB = "";
FL004_1 FL004_1;
FLTX2 FLTX2;
UvVar EMULATION_TYPE = "";
FL006 FL006;
UvVar INPUT_NO = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL004() {
#region INCLUDE TX.INCLUDE TX.COMMON

#endregion
#region INCLUDE FL.COMMON FL.COMMON

// FILES
//    Standard
//    Screen Control
//    Slave Printer Control
//    Special Video
//    User input control
//    Application Specific
//COMMON SC.POS
//    Theatre
//    Standard EQUates
//    Client app control
//\
#region INCLUDE TX.INCLUDE TX.COMMON

#endregion

#endregion
PROMPT("");
// GET THE PORT NUMBER
// Last updated : 17:48 13/11/92�* Compiled : 10:17 10/11/92
PROGRAM = "FL004";
//*********************************
//   FILES USED IN THIS PROCESS   *
//*********************************
if (!OPEN("FL.CONTROL", out FL_CONTROL)) { STOP(); }
if (!OPEN("FL.TILL.NUMBERS", out FL_TILL_NUMBERS)) { STOP(); }
if (!OPEN("FL.PASSWORDS", out FL_PASSWORDS)) { STOP(); }
if (!(READV(ref PORT_ID, FL_CONTROL, "UNIQUE.PORT", 1))) {
PORT_ID = "";
}
if (!(READ(ref MACHINE_TYPE, FL_CONTROL, "MACHINE.TYPE"))) {
MACHINE_TYPE = "M9000";
}
EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
// BEGIN CASE
if (MACHINE_TYPE == "M9000" && PORT_ID == "TYPE1") {
INSTRUCTION = "PLID";
nrf0 = "O";
CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
if (MESSAGES.Substring(1, 4) == "TSRV") {
PORT_NUMBER = MESSAGES.Substring(33, 4);
} else {
PORT_NUMBER = MESSAGES.Substring(27, 4);
}
} else if (MACHINE_TYPE == "M9000" && PORT_ID == "TYPE2") {
CCI = SYSTEM(48);
if (CCI == 0) {
PORT_NUMBER = SYSTEM(18);
} else {
PORT_NUMBER = CCI;
}
} else if (MACHINE_TYPE == "UNIVERSE" && PORT_ID == "NT") {
PORT_NUMBER = FIELD(SYSTEM(42), ".", 4);
PORT_NUMBER_AND_ACCOUNT = OCONV(0, "U50BB");
LINE_NUMBER = FIELD(PORT_NUMBER_AND_ACCOUNT, " ", 1);
ALL_CLEAR = 1;
} else if (MACHINE_TYPE == "UNIVERSE" && PORT_ID == "NT/TS") {
PORT_NUMBER = FIELD(SYSTEM(42), ".", 4);
PORT_NUMBER_AND_ACCOUNT = OCONV(0, "U50BB");
LINE_NUMBER = FIELD(PORT_NUMBER_AND_ACCOUNT, " ", 1);
ALL_CLEAR = 1;
// Check for Terminal Services
PRINT(CHAR(28) + "49" + CHAR(20));
TSRESPONSE = "";
ECHO(0);
for(PRE4_CHECK = 1; PRE4_CHECK <= 10 && NOT(TSRESPONSE != ""); PRE4_CHECK += 1) {
INPUTCR(out KEYIN, -1);
if (KEYIN == 1) {
INPUTCR(out TSRESPONSE);
} else {
CRT(50);
}
}
if (TSRESPONSE != "") {
PORT_NUMBER = FIELD(TSRESPONSE, ".", 4);
if (PORT_NUMBER == "") {
TILL_ERROR_ID = "TILL.ERROR." + TIMEDATE();
WRITE(TSRESPONSE, FL_TILL_NUMBERS, TILL_ERROR_ID);
ECHO(1);
PRINT(AT(-1));
PRINTCR(AT(10, 10) + "There seems to be a problem at the moment.");
PRINTCR(AT(10, 12) + "Please try again later. Press <RETURN>");
INPUT(out AGAIN, 1);
CHAIN("OFF");
}
}
ECHO(1);
} else if (MACHINE_TYPE == "UNIVERSE" && PORT_ID == "FWTERM") {
ECHO(0);
PRINT(CHAR(28) + "61" + CHAR(20));
INPUT(out PORT_NUMBER);
ECHO(1);
if (PORT_NUMBER > 0) {
ALL_CLEAR = 1;
} else {
PRINTCR(AT(-1));
PRINTCR("The Till Number has not been defined in FWTERM.INI");
PRINTCR("in this format:-");
PRINT();
PRINTCR("[TillNumber]");
PRINTCR("Till=nnn   (where nnn is the required Till Number to use)");
RQM();
ALL_CLEAR = 0;
}
//!!        PORT.NUMBER = @TERM.TYPE
//!!        PORT.NUMBER = FIELD(PORT.NUMBER,"-",2)
//!!        PORT.NUMB = @USERNO
//!!        PORTID = 'FWTERM':PORT.NUMB
//!!        IF PORT.NUMBER # "" THEN
//!!           WRITEV PORT.NUMB ON FL.TILL.NUMBERS,PORT.NUMBER,9
//!!           WRITEV PORT.NUMBER ON FL.TILL.NUMBERS,PORTID,1
//!!           WRITEV PORT.NUMBER ON FL.PASSWORDS,PORTID,1
//!!        END ELSE
//!!           READV PORT.NUMBER FROM FL.PASSWORDS,PORTID,1 ELSE
//!!              READV PORT.NUMBER FROM FL.TILL.NUMBERS,PORTID,1 ELSE
//!!                 PORT.NUMBER = 99
//!!              END
//!!           END
//!!        END
//!!        ALL.CLEAR = 1
} else if (MACHINE_TYPE == "UNIVERSE" && PORT_ID == "NT/TERMITE") {
PORT_NUMBER_AND_ACCOUNT = OCONV(0, "U50BB");
PORT_NUMB = FIELD(PORT_NUMBER_AND_ACCOUNT, " ", 1);
FL004_1 = new FL004_1();
TRANS_LOG_REC = PORT_NUMB;
TX_ATT = 9;
nrf0 = "WV";nrf1 = "FL.TILL.NUMBERS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PORT_NUMBER);
WRITEV(PORT_NUMB, FL_TILL_NUMBERS, PORT_NUMBER, 9);
ALL_CLEAR = 1;
} else if (MACHINE_TYPE == "UNIVERSE" && PORT_ID == "NT/TERMITE/UVTERM") {
PRINT("(T)ermite/(U)vterm   ");
INPUTCR(out EMULATION_TYPE);
if (EMULATION_TYPE == "X" || EMULATION_TYPE == "x") { STOP(); }
PORT_NUMBER_AND_ACCOUNT = OCONV(0, "U50BB");
PORT_NUMB = FIELD(PORT_NUMBER_AND_ACCOUNT, " ", 1);
if (EMULATION_TYPE == "T" || EMULATION_TYPE == "t") {
FL004_1 = new FL004_1();
} else {
PORT_NUMBER = PORT_NUMB;
}
TRANS_LOG_REC = PORT_NUMB;
TX_ATT = 9;
nrf0 = "WV";nrf1 = "FL.TILL.NUMBERS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PORT_NUMBER);
WRITEV(PORT_NUMB, FL_TILL_NUMBERS, PORT_NUMBER, 9);
ALL_CLEAR = 1;
} else if (OTHERWISE) {
PORT_NUMBER_AND_ACCOUNT = OCONV(0, "U50BB");
PORT_NUMBER = FIELD(PORT_NUMBER_AND_ACCOUNT, " ", 1);
ALL_CLEAR = 1;
}
if (PORT_NUMBER == "") {
ECHO(1);
PRINT(AT(-1));
PRINTCR(AT(10, 10) + "There seems to be a problem at the moment.");
PRINTCR(AT(10, 12) + "Please try again later. Press <RETURN>");
INPUT(out AGAIN, 1);
CHAIN("OFF");
}
goto L9999;
L2000:
//   ERROR PRINT SUBROUTINE   *
//*****************************
nrf0 = INIT;FL006 = new FL006(ref PROGRAM, ref INPUT_NO, ref nrf0);
// PRINT ERROR
ALL_CLEAR = 0;
goto L9999;
L9999:
return;
}
}
}
