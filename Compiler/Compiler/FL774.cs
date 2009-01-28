//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL774 : UvBase
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
readonly UvVar TRANS_FILENAME = 1;
readonly UvVar TRANS_SELECT_LIST = 2;
readonly UvVar TRANS_PROCEDURE = 3;
readonly UvVar TRANS_DIRECTORY = 4;
readonly UvVar TRANS_DESTINATION = 5;
readonly UvVar TRANS_SEQ_OVER = 6;
readonly UvVar TRANS_TEMPLATE = 7;
readonly UvVar TRANS_DOCUMENT = 8;
readonly UvVar TRANS_MACRO = 9;
readonly UvVar TRANS_APPLICATION = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] TRANS_REC = new UvVar[20];
#endregion
#region Variables
UvVar FILE_TYPE = "";
UvVar FL_UNIVERSE_TRANSFER = "";
UvVar PROGRAM = "";
UvVar OK_TO_PROCEED = "";
UvVar DOC_DIRECTORY = "";
UvVar MAIN_DOCUMENT_PATH = "";
FL006 FL006;
UvVar DAT_DIRECTORY = "";
UvVar APPCOM = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL774(ref UvVar[] TRANS_REC, ref UvVar FILE_TYPE) {
this.TRANS_REC = TRANS_REC;
this.FILE_TYPE = FILE_TYPE;
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
/*  Fire up MS Word */
/*  DJA 1.11.99 Relies on export file having been created first */
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.UNIVERSE.TRANSFER

if (!(OPEN("FL.UNIVERSE.TRANSFER", out FL_UNIVERSE_TRANSFER))) {
STOP(201, "CANNOT OPEN FILES");
}

#endregion
/*  Set up variables */
PROGRAM = "FL774";
OK_TO_PROCEED = TRUE;
if (TRANS_REC[TRANS_DOCUMENT] != "") {
if (TRANS_REC[TRANS_DOCUMENT].Substring(1, 1) != "\\") {
if (READV(ref DOC_DIRECTORY, COMMON.FILES[FL_CONTROL], "WORD.DOC.DIR", 1)) {
MAIN_DOCUMENT_PATH = DOC_DIRECTORY + TRANS_REC[TRANS_DOCUMENT];
} else {
OK_TO_PROCEED = FALSE;
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
} else {
MAIN_DOCUMENT_PATH = TRANS_REC[TRANS_DOCUMENT];
}
} else {
/*  Launch application, defaulting to the name of the document */
/*  the transfer created. */
if (READV(ref DAT_DIRECTORY, COMMON.FILES[FL_CONTROL], "WORD.DOC.DIR", 2)) {
MAIN_DOCUMENT_PATH = DAT_DIRECTORY + TRANS_REC[TRANS_DESTINATION] + "." + FILE_TYPE;
} else {
OK_TO_PROCEED = FALSE;
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
}
if (OK_TO_PROCEED) {
/*  CALL EXPORT ROUTINE */
APPCOM = MAIN_DOCUMENT_PATH + " /M" + TRANS_REC[TRANS_MACRO];
PRINTCR(CHAR(28) + "4,WINWORD," + APPCOM + CHAR(20));
}
return;
}
}
}
