//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL776 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
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
UvVar[] TRANS_REC = new UvVar[20];
#endregion
#region Variables
UvVar FILE_TYPE = "";
UvVar FL_UNIVERSE_TRANSFER = "";
UvVar ROW = "";
UvVar APP_TEXT = "";
UvVar REPLY = "";
FL774 FL774;
FL775 FL775;
FL798 FL798;
#endregion
public FL776(ref UvVar[] TRANS_REC, ref UvVar FILE_TYPE) {
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
/*  Offer user option of launching a windows application after */
/*  exporting data */
#region INCLUDE FL.FILES FL.UNIVERSE.TRANSFER

if (!(OPEN("FL.UNIVERSE.TRANSFER", out FL_UNIVERSE_TRANSFER))) {
STOP(201, "CANNOT OPEN FILES");
}

#endregion
if (TRANS_REC[TRANS_APPLICATION] != "") {
for(ROW = 3; ROW <= 19; ROW += 1) {
PRINT(AT(0, ROW) + COMMON.EOL);
}
// BEGIN CASE
// CASE
if (TRANS_REC[TRANS_APPLICATION] == "W") {
APP_TEXT = "MS Word";
}// CASE
else if (TRANS_REC[TRANS_APPLICATION] == "E") {
APP_TEXT = "MS Excel";
}// CASE
else if (OTHERWISE) {
APP_TEXT = "Windows App";
}
// END CASE
REPLY = "";
if (FILE_TYPE.Substring(1, 1) == "A") {
REPLY = "Y";
FILE_TYPE = FILE_TYPE.Substring(2, LEN(FILE_TYPE) - 1);
}
do {
if (REPLY == "Y" || REPLY == "y" || REPLY == "N" || REPLY == "n" || REPLY == COMMON.ABANDON) break;
PRINT(AT(5, 9) + "Do you wish to launch " + APP_TEXT + "? (Y/N) " + COMMON.EOL);
INPUT(out REPLY, 2);
} while (true);
if (REPLY == "Y" || REPLY == "y") {
// BEGIN CASE
// CASE
if (TRANS_REC[TRANS_APPLICATION] == "W") {
/*  MS Word */
FL774 = new FL774(ref TRANS_REC, ref FILE_TYPE);
}// CASE
else if (TRANS_REC[TRANS_APPLICATION] == "E") {
/*  MS Excel */
FL775 = new FL775(ref TRANS_REC, ref FILE_TYPE);
}// CASE
else if (TRANS_REC[TRANS_APPLICATION] == "X") {
FL798 = new FL798(ref TRANS_REC, ref FILE_TYPE);
}
// END CASE
}
}
return;
}
}
}
