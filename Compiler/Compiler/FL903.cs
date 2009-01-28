//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL903 : UvBase
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
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] CENTRES_REC = new UvVar[4];
UvVar[] FILENAMES = new UvVar[100];
#endregion
#region Variables
UvVar PROGRAM = "";
UvVar MD = "";
FL006 FL006;
UvVar STOP_RUN = "";
UvVar FLEX = "";
FL306 FL306;
UvVar FILE_TO_COPY = "";
UvVar ANS = "";
UvVar FILE_REQ = "";
UvVar DICT_REQ = "";
UvVar ID_REQ = "";
UvVar CLEAR_REQ = "";
UvVar QPOINTER = "";
UvVar STATEMENT = "";
UvVar MESSAGE = "";
UvVar STATEMENT2 = "";
UvVar CURRENT_ACCOUNT = "";
UvVar LIVE_ACCOUNT = "";
UvVar ACCOUNT_DETAILS = "";
UvVar TEST_ACCOUNT = "";
UvVar CHECK_FILE = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL903() {
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
/* Routine to set-UP Test Account from Live Account */
PROGRAM = "FL903";
PROMPT("");
if (!(OPEN("MD", out MD))) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
MAT(ref FILENAMES, "");
/* ************************************** */
/*  Main Process */
/* ************************************** */
if (READV(ref STOP_RUN, COMMON.FILES[FL_CONTROL], "STOP.FL903", 1)) {
PRINT(COMMON.WASH);
PRINT(AT(10, 10) + "Cannot Run (Call Flex) - " + STOP_RUN);
INPUTCR(out FLEX, 1);
return;
}
L0100();
/*  Establish Account Details */
PRINT(COMMON.WASH);
FL306 = new FL306();
FILE_TO_COPY = 1;
do {
if (FILENAMES[FILE_TO_COPY] == "") break;
if (FILE_TO_COPY == 1) {
PRINTCR(AT(5, 10) + "This process will copy the set_up details from the Live Account");
PRINTCR(AT(10, 12) + "!!!!  YOU MUST BE ON THE TEST ACCOUNT    !!!!");
PRINT(AT(5, 14) + "Do You Wish To Continue (Y/N)");
INPUTCR(out ANS, 5);
if (ANS != "Y") {
return;
}
}
FILE_REQ = FILENAMES[FILE_TO_COPY][1, 1];
DICT_REQ = FILENAMES[FILE_TO_COPY][1, 2];
ID_REQ = FILENAMES[FILE_TO_COPY][1, 3];
CLEAR_REQ = FILENAMES[FILE_TO_COPY][1, 4];
/* Set UP Q-Pointer */
QPOINTER[3] = FILE_REQ;
WRITE(QPOINTER, MD, "LIVEACCT.QPTR");
/*  Set Up Statement for Execute */
if (CLEAR_REQ == "C" || CLEAR_REQ == "Y") {
STATEMENT = "CLEAR-FILE " + DICT_REQ + " " + FILE_REQ;
EXECUTE(STATEMENT, MESSAGE, string.Empty, string.Empty, string.Empty);
}
STATEMENT = "COPY " + DICT_REQ + " LIVEACCT.QPTR";
if (ID_REQ != "") {
STATEMENT = STATEMENT + " " + ID_REQ + " (O,S)";
} else {
STATEMENT = STATEMENT + " * (O,S)";
}
STATEMENT2 = "(";
if (DICT_REQ == "DICT") {
STATEMENT2 = STATEMENT2 + "DICT ";
}
STATEMENT2 = STATEMENT2 + FILE_REQ;
PRINT(AT(10, 17) + "Copying File " + FILE_REQ + COMMON.EOL);
DATA(STATEMENT2);
DATA(CHAR(13));
EXECUTE(STATEMENT, MESSAGE, string.Empty, string.Empty, string.Empty);
INPUT(out ANS, 1);
FILE_TO_COPY = FILE_TO_COPY + 1;
} while (true);
if (FILENAMES[1] != "") {
DATA("Y");
DATA(CHAR(13));
EXECUTE("COMP.DEL", MESSAGE, string.Empty, string.Empty, string.Empty);
CENTRES_REC[CENTRE_NAME] = "!!!!! TEST ACCOUNT !!!!!!";
WRITEV(CENTRES_REC[CENTRE_NAME], COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1);
PRINT(AT(10, 19) + "Copy Completed - Please Run Calendar");
/*  copy back the account details held on this account */
/*  as they have been copied from the LIVE account by this */
/*  process */
MATWRITE(FILENAMES, COMMON.FILES[FL_CONTROL], "SETUP.FILES");
INPUTCR(out ANS, 1);
}
return;
}
void L0100() {
/*  Establish Account Details */
CURRENT_ACCOUNT = OCONV(FIELD(OCONV(0, "U50BB"), " ", 2), "MCU");
LIVE_ACCOUNT = "";
if (READ(ref ACCOUNT_DETAILS, COMMON.FILES[FL_CONTROL], "ACCOUNT.DETAILS")) {
LIVE_ACCOUNT = ACCOUNT_DETAILS[1];
TEST_ACCOUNT = ACCOUNT_DETAILS[2];
} else {
if (CURRENT_ACCOUNT.Substring(1, 5) == "TRAIN" || CURRENT_ACCOUNT.Substring(1, 5) == "train") {
TEST_ACCOUNT = CURRENT_ACCOUNT;
LIVE_ACCOUNT = CURRENT_ACCOUNT.Substring(6, 99);
}
}
if (LIVE_ACCOUNT == "") {
nrf0 = 5;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (OCONV(TEST_ACCOUNT, "MCU") != CURRENT_ACCOUNT) {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
QPOINTER = "";
QPOINTER[1] = "Q";
QPOINTER[2] = LIVE_ACCOUNT;
QPOINTER[3] = "FL.CONTROL";
WRITE(QPOINTER, MD, "LIVEACCT.QPTR");
if (!(OPEN("LIVEACCT.QPTR", out CHECK_FILE))) {
nrf0 = 8;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (!(MATREAD(ref FILENAMES, COMMON.FILES[FL_CONTROL], "SETUP.FILES"))) {
nrf0 = 7;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
return;
/* ************************** */
/*  END */
/* ************************** */
}
}
}
