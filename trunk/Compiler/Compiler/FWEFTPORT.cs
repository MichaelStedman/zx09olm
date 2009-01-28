//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FWEFTPORT : UvBase
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
readonly UvVar LOCK_PORT = 1;
readonly UvVar UNLOCK_PORT = 0;
readonly UvVar LOCAL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Variables
UvVar CALLING_PROG = "";
UvVar PORT_NAME = "";
UvVar ACTION = "";
UvVar INTERACT = "";
UvVar PROGRAM = "";
UvVar TIMEOUT = "";
UvVar ATTEMPTS = "";
UvVar EFT_PORTS = "";
UvVar PORT_COUNT = "";
UvVar PORTID = "";
UvVar DUMMY = "";
UvVar LOCKED = "";
#endregion
public FWEFTPORT(ref UvVar CALLING_PROG, ref UvVar PORT_NAME, ref UvVar ACTION, ref UvVar INTERACT) {
this.CALLING_PROG = CALLING_PROG;
this.PORT_NAME = PORT_NAME;
this.ACTION = ACTION;
this.INTERACT = INTERACT;
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
// Control port allocation for web EFT
PROGRAM = "FWEFTPORT";
//************************
//    DEFINE FILES USED  *
//************************
//***************************
//    MAIN PROCESS SECTION  *
//***************************
// BEGIN CASE
// CASE
if (ACTION == LOCK_PORT) {
L0100();
}// CASE
else if (ACTION == UNLOCK_PORT) {
L0200();
}// CASE
else if (OTHERWISE) {
INTERACT = INVALID_DATA;
}
// END CASE
return;
//**********************************
}
void L0100() {
//  FIND AND LOCK AN EFT PORT  *
//**********************************
TIMEOUT = 120;
ATTEMPTS = 0;
if (READV(ref EFT_PORTS, COMMON.FILES[LOCAL_CONTROL], "FW.WEB.CONTROL", 11)) {
do {
INTERACT = INVALID_DATA;
PORT_COUNT = 1;
PORT_NAME = EFT_PORTS[1, PORT_COUNT];
do {
PORTID = "EFT." + PORT_NAME;
if (READU(ref DUMMY, COMMON.FILES[LOCAL_CONTROL], FORMAT(PORTID, LOCKED))){
PORT_COUNT = PORT_COUNT + 1;
PORT_NAME = EFT_PORTS[1, PORT_COUNT];
} else {
INTERACT = VALID_DATA;
}
if ((PORT_NAME == "") || (INTERACT == VALID_DATA)) break;
} while (true);
if ((ATTEMPTS == TIMEOUT) || (INTERACT == VALID_DATA)) break;
CRT(1);
ATTEMPTS = ATTEMPTS + 1;
} while (true);
} else {
INTERACT = INVALID_DATA;
}
return;
//****************************
}
void L0200() {
//  UNLOCK THE EFT PORT  *
//****************************
PORTID = "EFT." + PORT_NAME;
RELEASE();
return;
//************************
// End of program        *
//************************
}
}
}
