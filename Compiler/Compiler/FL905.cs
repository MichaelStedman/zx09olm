//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL905 : UvBase
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
UvVar TERMINAL_TYPE = "";
UvVar MACHINE_TYPE = "";
UvVar REV_VID = "";
UvVar DIM_REV_VID = "";
UvVar NRM_VID = "";
UvVar PROGRAM = "";
UvVar FE_LOG = "";
UvVar FE_CONTROL = "";
UvVar FE_CARD = "";
UvVar FL_DATA_ENTRY = "";
UvVar FL_SYSTEM14 = "";
UvVar TL2 = "";
UvVar HZ2 = "";
UvVar TR2 = "";
UvVar VTL2 = "";
UvVar VTR2 = "";
UvVar LJ2 = "";
UvVar RJ2 = "";
UvVar HZ1 = "";
UvVar BL2 = "";
UvVar BR2 = "";
UvVar INTERFACE_REC = "";
UvVar GET_NAME = "";
UvVar DATA_ITEMS = "";
UvVar LAST_DATA_LINE = "";
UvVar LAST_LINE = "";
UvVar SEQ_NO = "";
UvVar REFRESH_DELAY = "";
UvVar LAST_SEQ_NO = "";
UvVar LAST_TIME = "";
UvVar LAST_DISP = "";
UvVar KEY = "";
UvVar SYSTEM14 = "";
CallAt_FL_SYSTEM14 CallAt_FL_SYSTEM14;
CallAt_FL_DATA_ENTRY CallAt_FL_DATA_ENTRY;
UvVar ROW = "";
UvVar END_ITEM = "";
UvVar ITEM = "";
UvVar NO_MORE_ENTRIES = "";
UvVar REC = "";
UvVar NAME = "";
CallAt_GET_NAME CallAt_GET_NAME;
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL905() {
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
/*     DISPLAY TODAYS DOOR ENTRY REJECTIONS */
PROGRAM = "FL905";
/* ************************ */
/*     DEFINE FILES USED  * */
/* ************************ */
if (!OPEN("FE.LOG", out FE_LOG)) { STOP(201, "FE.LOG"); }
if (!OPEN("FE.CONTROL", out FE_CONTROL)) { STOP(201, "FE.CONTROL"); }
if (!OPEN("FE.CARD", out FE_CARD)) { STOP(201, "FE.CARD"); }
/* *************************** */
/*     GET CONTROL ITEMS     * */
/* *************************** */
FL_DATA_ENTRY = "FL." + MACHINE_TYPE + ".DATA.ENTRY";
FL_SYSTEM14 = "FL." + MACHINE_TYPE + ".SYSTEM14";
if (TERMINAL_TYPE == "I") {
TL2 = CHAR(201);
HZ2 = CHAR(205);
TR2 = CHAR(187);
VTL2 = CHAR(186);
VTR2 = CHAR(186);
LJ2 = CHAR(199);
RJ2 = CHAR(182);
HZ1 = CHAR(196);
BL2 = CHAR(200);
BR2 = CHAR(188);
} else {
TL2 = "";
HZ2 = " ";
TR2 = NRM_VID;
VTL2 = "";
VTR2 = NRM_VID;
LJ2 = "";
RJ2 = NRM_VID;
HZ1 = " ";
BL2 = "";
BR2 = NRM_VID;
}
/* ************************** */
/*     MAIN PROCESS SECTION * */
/* ************************** */
if (!(READ(ref INTERFACE_REC, FE_CONTROL, "USER.ROUTINES"))) {
INTERFACE_REC = "";
}
if (INTERFACE_REC[6] != "") {
GET_NAME = "FL." + INTERFACE_REC[6];
} else {
GET_NAME = "";
}
DATA_ITEMS = 16;
LAST_DATA_LINE = DATA_ITEMS + 5;
LAST_LINE = LAST_DATA_LINE + 1;
if (!READ(ref SEQ_NO, FE_CONTROL, "LAST.LOG.NUMBER")) { SEQ_NO = 0; }
PRINT(NRM_VID);
PRINT(AT(-1));
L0100();
REFRESH_DELAY = 10;
LAST_SEQ_NO = SEQ_NO;
LAST_TIME = TIME();
LAST_DISP = TIME();
ECHO_OFF();
KEY = "";
do {
do {
CallAt_FL_SYSTEM14 = new CallAt_FL_SYSTEM14(ref FL_SYSTEM14, ref SYSTEM14);
if (!(SYSTEM14)) break;
nrf0 = 1;
nrf1 = "";
CallAt_FL_DATA_ENTRY = new CallAt_FL_DATA_ENTRY(ref FL_DATA_ENTRY, ref nrf0, ref nrf1, ref KEY);
} while (true);
if (KEY == SEQ(COMMON.ABANDON)) break;
/*  DJA 13.10.00 */
RQM();
if (TIME() - LAST_TIME > 1) {
if (!READ(ref SEQ_NO, FE_CONTROL, "LAST.LOG.NUMBER")) { SEQ_NO = 0; }
if (SEQ_NO != LAST_SEQ_NO) {
L0100();
LAST_SEQ_NO = SEQ_NO;
LAST_DISP = TIME();
}
LAST_TIME = TIME();
}
} while (true);
ECHO_ON();
return;
}
void L0100() {
/*   DISPLAY DATA */
PRINT(AT(0, 0) + DIM_REV_VID);
PRINT(TL2);
PRINT(AT(1, 0) + "(FL905)" + STR(HZ2, 71));
PRINT(TR2);
PRINT(AT(0, 1) + DIM_REV_VID);
PRINT(TL2);
PRINT(AT(1, 1) + SPACE(21) + "RECENT DOOR ACCESS REFUSALS" + STR(HZ2, 30));
PRINT(TR2);
PRINT(AT(0, 2) + DIM_REV_VID);
PRINT(AT(0, 2));
PRINT(VTL2);
PRINT(AT(1, 2));
PRINT(FORMAT("Card", "L#8"));
PRINT(FORMAT("Name", "L#20"));
/* *     PRINT "Door" "L#5": */
PRINT("Time  ");
PRINT(FORMAT("Reason rejected", "L#44"));
/* *   PRINT SPACE(6): */
PRINT(VTR2);
/* *   PRINT @(0,2):DIM.REV.VID: */
/* *   PRINT @(0,2): */
/* *   PRINT LJ2: */
/* *   PRINT @(1,2): */
/* *   PRINT STR(HZ1,78): */
/* *   PRINT RJ2: */
for(ROW = 3; ROW <= LAST_DATA_LINE; ROW += 1) {
PRINT(AT(0, ROW) + VTL2);
PRINT(AT(79, ROW) + VTR2);
}
/*  Underline (single) beneath data */
PRINT(AT(0, LAST_LINE - 2) + DIM_REV_VID);
PRINT(AT(0, LAST_LINE - 2));
PRINT(LJ2);
PRINT(AT(1, LAST_LINE - 2));
PRINT(STR(HZ1, 78));
PRINT(RJ2);
/*  Prompt line (beneath data) */
PRINT(AT(0, LAST_LINE - 1) + DIM_REV_VID);
PRINT(AT(0, LAST_LINE - 1));
PRINT(VTL2);
PRINT(AT(1, LAST_LINE - 1));
PRINT(FORMAT((SPACE(8) + "Press the abandon key (.) to exit this screen "), "L#78"));
/*  Double underline at foot of screen */
PRINT(AT(0, LAST_LINE) + DIM_REV_VID);
PRINT(AT(0, LAST_LINE));
PRINT(BL2);
PRINT(AT(1, LAST_LINE));
PRINT(STR(HZ2, 78));
PRINT(BR2);
END_ITEM = SEQ_NO - DATA_ITEMS;
if (END_ITEM < 1) { END_ITEM = 1; }
ROW = 3;
ITEM = SEQ_NO;
NO_MORE_ENTRIES = FALSE;
do {
if (ROW > 19 || NO_MORE_ENTRIES) break;
if (READ(ref REC, FE_LOG, ITEM)) {
if (REC[6, 1] != 0) {
/*  Invalid access attempt - we want this one displayed */
if (!READV(ref NAME, FE_CARD, REC[2], 2)) { NAME = ""; }
if (NAME == "") {
NAME = "Not on file";
if (GET_NAME != "") { nrf0 = REC[2];CallAt_GET_NAME = new CallAt_GET_NAME(ref GET_NAME, ref nrf0, ref NAME); }
}
PRINT(AT(0, ROW));
PRINT(REV_VID);
PRINT(AT(1, ROW));
PRINT(FORMAT(REC[2], "L#8"));
PRINT(FORMAT(NAME, "L#19") + SPACE(1));
/* *            PRINT REC<1> "L#5": */
if (REC[4] != "") {
PRINT(FORMAT(OCONV(REC[4], "MT"), "L#6"));
} else {
PRINT(SPACE(6));
}
PRINT(FORMAT(REC[6, 2], "L#44"));
ROW = ROW + 1;
}
ITEM = ITEM - 1;
} else {
NO_MORE_ENTRIES = TRUE;
}
} while (true);
/*  Position cursor */
PRINT(AT(0, LAST_LINE - 1) + DIM_REV_VID);
PRINT(AT(55, LAST_LINE - 1));
return;
}
}
}
