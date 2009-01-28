//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FLQAS : UvBase
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
UvVar ADDRESS = "";
UvVar PORT_NUMBER = "";
UvVar MACHINE_TYPE = "";
UvVar AM = "";
UvVar CLIENT_APP_TYPE = "";
UvVar PROGRAM = "";
UvVar STX = "";
UvVar QASSITE = "";
UvVar FWCLIENT_VERSION = "";
UvVar SYSTEM14 = "";
UvVar KEY = "";
#endregion
public FLQAS(ref UvVar ADDRESS) {
this.ADDRESS = ADDRESS;
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
/*  Routine to initiate Quick Address Software */
PROGRAM = "FLQAS";
PROMPT("");
/* RT 28/7 Added next bit to stop old versions & non qas sites from crashing */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
if (!(READV(ref QASSITE, COMMON.FILES[FL_CONTROL], "QAS*" + PORT_NUMBER, 1))) {
QASSITE = FALSE;
ADDRESS = "";
return;
}
if (!(READ(ref FWCLIENT_VERSION, COMMON.FILES[FL_CONTROL], "FWCLIENT.VERSION"))) {
FWCLIENT_VERSION = "";
}
/* !*CALL FL.CLIENT.TYPE(CLIENT.APP.TYPE) */
ECHO_OFF();
/*     Clear the Keyboard Input Buffer */
do {
if (MACHINE_TYPE == "UNIVERSE") {
SYSTEM14 = OCONV(0, "U7201");
} else {
SYSTEM14 = SYSTEM(14);
}
if (!(SYSTEM14)) break;
INPUT(out KEY, 1);
} while (true);
/* *  Instruct FWTERM to fire up Quick Address */
PRINT(CHAR(28) + "43" + CHAR(20));
if (FWCLIENT_VERSION >= 4.6M && CLIENT_APP_TYPE.Substring(1, 1) != "W") {
do {
INPUTCR(out ADDRESS);
if (INDEX(ADDRESS, STX, 1) > 0 || COUNT(ADDRESS, AM) > 0) break;
} while (true);
} else {
INPUTCR(out ADDRESS);
}
if (INDEX(ADDRESS, STX, 1)) {
ADDRESS = FIELD(ADDRESS, STX, 2);
}
ECHO_ON();
/* WRITE "OUT" ON FL.CONTROL,'FLEXTERM' */
WRITE("OUT", COMMON.FILES[FL_CONTROL], "FLEXTERM.OUT");
return;
/* *  END */
}
}
}
