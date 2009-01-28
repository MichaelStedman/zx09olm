//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL116 : UvBase
{
#region Common instances
COMMON COMMON = COMMON.Instance;
TXLOG TXLOG = TXLOG.Instance;
#endregion
#region Int Constants
readonly UvVar TRUE = 1;
readonly UvVar FALSE = 0;
readonly UvVar OTHERWISE = 1;
readonly UvVar FL_MD = 58;
readonly UvVar FL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] CONTROLS_REC = new UvVar[20];
#endregion
#region Variables
UvVar AM = "";
UvVar TX_TRANSFER = "";
UvVar ITEM = "";
UvVar PROGRAM = "";
UvVar ALL_SITES = "";
UvVar FLEX = "";
UvVar THESE_SITES = "";
FL000_10 FL000_10;
UvVar S_FILENAME = "";
UvVar DICT_Y_N = "";
UvVar FILENAME = "";
UvVar THIS_FILE = "";
FL006 FL006;
UvVar LISTNAME = "";
UvVar STATEMENT = "";
UvVar LIST_STRING = "";
UvVar ITEMS_IN_LIST = "";
UvVar ITEM_IN_LIST = "";
UvVar ITEM_NAME = "";
UvVar RECORD = "";
UvVar LINE = "";
UvVar SURE = "";
UvVar WAIT = "";
UvVar YES_TO_ALL = "";
UvVar THIS_SITE = "";
UvVar CONFIRM = "";
UvVar XXX = "";
UvVar YYY = "";
UvVar EOF = "";
UvVar THIS_ITEM = "";
UvVar ACCT_NAME = "";
UvVar TX_ID = "";
UvVar TX_REC = "";
UvVar UPDATE_RECORD = "";
UvVar MDREC = "";
UvVar QFILENAME = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL116() {
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
/*  WRITES TX.TRANSFER ENTRIES FOR A ITEM TO GO TO SITE */
PROGRAM = "FL116";
if (!OPEN("TX.TRANSFER", out TX_TRANSFER)) { STOP(); }
#region INCLUDE FL.FILES FL.MD

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
if (!(READ(ref ALL_SITES, COMMON.FILES[FL_CONTROL], "ALL.SITES"))) {
PRINT("ALL.SITES control item NOT set up.  Try again when it is! ");
INPUT(out FLEX, 1);
return;
}
THESE_SITES = DCOUNT(ALL_SITES, AM);
nrf0 = 0;
FL000_10 = new FL000_10(ref PROGRAM, ref nrf0);
PRINT(AT(10, 3) + "Enter Source File ");
INPUT(out S_FILENAME, 25);
if (S_FILENAME == "" || S_FILENAME == COMMON.ABANDON) {
return;
}
/*   THE LOCAL UPDATE WILL NOT EXPECT dict ENTRIES SO OPTION NOT OFFERED AT THIS STAGE */
PRINT(AT(10, 4) + "Dictionary item Y/N ");
INPUT(out DICT_Y_N, 2);
if (DICT_Y_N == "Y") {
S_FILENAME = "DICT " + S_FILENAME;
}
PRINT(AT(10, 5) + "Enter Destination File ");
INPUT(out FILENAME, 25);
if (FILENAME == "") { FILENAME = S_FILENAME; }
if (FILENAME == "" || FILENAME == COMMON.ABANDON) {
return;
}
if (!(OPEN(S_FILENAME, out THIS_FILE))) {
nrf0 = 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref S_FILENAME);
return;
}
LISTNAME = "";
PRINT(AT(10, 6) + "Enter Item Name, * for all or <Return> for list ");
INPUTCR(out ITEM);
if (ITEM == "") {
PRINT(AT(10, 7) + "Input List Name ");
INPUTCR(out LISTNAME);
if (LISTNAME == "") {
return;
}
}
// BEGIN CASE
// CASE
if (ITEM == "*") {
PRINT(AT(10, 10) + "All items from the file " + S_FILENAME + " will be copied !! ");
STATEMENT = "SELECT " + S_FILENAME;
}// CASE
else if (INDEX(ITEM, ",", 1)) {
LIST_STRING = "";
ITEMS_IN_LIST = DCOUNT(ITEM, ",");
ITEM_IN_LIST = 0;
do {
ITEM_IN_LIST = ITEM_IN_LIST + 1;
if (ITEM_IN_LIST > ITEMS_IN_LIST) break;
ITEM_NAME = TRIM(FIELD(ITEM, ",", ITEM_IN_LIST));
LIST_STRING = LIST_STRING + "\"" + ITEM_NAME + "\"";
} while (true);
STATEMENT = "SELECT " + S_FILENAME + " = " + LIST_STRING;
}// CASE
else if (LISTNAME != "") {
PRINT(AT(10, 10) + "Items from the file " + S_FILENAME + " will be copied, using the ");
PRINT(AT(10, 12) + "list " + LISTNAME);
STATEMENT = "GET-LIST " + LISTNAME;
}// CASE
else if (OTHERWISE) {
if (!(READ(ref RECORD, THIS_FILE, ITEM))) {
nrf0 = 2;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref ITEM);
return;
}
/*  print first 10 lines of item */
for(LINE = 1; LINE <= 10 && NOT(RECORD[LINE] == ""); LINE += 1) {
PRINT(AT(11, LINE + 6) + FORMAT(LINE, "R#2") + ". " + FORMAT(OCONV(RECORD[LINE], "MCP"), "L#60"));
}
STATEMENT = "SELECT " + S_FILENAME + " = \"" + ITEM + "\"";
}
// END CASE
PRINT(AT(10, 20) + "Are you sure (Y/N) ");
INPUT(out SURE, 2);
if (SURE == "Y" || SURE == "y") {
L0200();
PRINT(AT(10, 21) + COMMON.EOL + AT(10, 21) + "All Sites Updated ");
} else {
PRINT("NO Updates Performed !! ");
}
INPUT(out WAIT, 1);
return;
}
void L0200() {
/*  update each site in turn */
YES_TO_ALL = FALSE;
for(THIS_SITE = 1; THIS_SITE <= THESE_SITES; THIS_SITE += 1) {
if (YES_TO_ALL) {
L0300();
} else {
PRINT(AT(10, 21) + COMMON.EOL + AT(10, 21) + "Do you want to update " + ALL_SITES[THIS_SITE] + " Y/N/ALL ");
INPUT(out CONFIRM, 4);
if (CONFIRM == "ALL") {
PRINT(AT(10, 21) + COMMON.EOL + AT(10, 21) + "Updating .... " + FORMAT(THIS_SITE, "R#2") + " " + ALL_SITES[THIS_SITE]);
YES_TO_ALL = TRUE;
CONFIRM = "Y";
}
if (CONFIRM == "Y" || CONFIRM == "y") {
L0300();
} else {
PRINT(AT(10, 21) + COMMON.EOL + AT(10, 21) + ALL_SITES[THIS_SITE] + " NOT updated, press <RETURN> ");
INPUT(out WAIT, 1);
}
}
}
return;
}
void L0300() {
/*  CREATE RECORD AND WRITE TO TX.TRANSFER */
EXECUTE(STATEMENT, XXX, string.Empty, string.Empty, YYY);
EOF = FALSE;
do {
if (!READNEXT(ref THIS_ITEM, 0, 0, "")) { EOF = TRUE; }
if (EOF) break;
if (!(READ(ref RECORD, THIS_FILE, THIS_ITEM))) {
nrf0 = 3;nrf1 = "[";FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
ACCT_NAME = ICONV(ALL_SITES[THIS_SITE], "MCL");
if (ACCT_NAME[1, 1] == "BASE") {
L0400();
/*  Write record to base account */
} else {
TX_ID = ACCT_NAME + FILENAME + "*!*" + THIS_ITEM;
TX_REC = "W";
TX_REC[1, 2] = ACCT_NAME;
TX_REC[1, 3] = FILENAME;
TX_REC[1, 4] = THIS_ITEM;
TX_REC = TX_REC + AM + RECORD;
WRITE(TX_REC, TX_TRANSFER, TX_ID);
}
} while (true);
return;
}
void L0400() {
/*  Write record to base account */
UPDATE_RECORD = TRUE;
MDREC = "Q";
MDREC[2] = ACCT_NAME[1, 2] + "\\" + FILENAME;
MDREC[3] = "D_VOC";
WRITE(MDREC, COMMON.FILES[FL_MD], "FLEX.AUTOQ");
if (DICT_Y_N == "Y") {
if (!(OPENDICT("FLEX.AUTOQ", out QFILENAME))) {
PRINT(AT(10, 21) + COMMON.EOL + AT(10, 21) + "There is a problem with the site " + ACCT_NAME);
INPUT(out WAIT, 2);
UPDATE_RECORD = FALSE;
}
} else {
if (!(OPEN("FLEX.AUTOQ", out QFILENAME))) {
PRINT(AT(10, 21) + COMMON.EOL + AT(10, 21) + "There us a problem with the site " + ACCT_NAME);
INPUT(out WAIT, 2);
UPDATE_RECORD = FALSE;
}
}
if (UPDATE_RECORD) {
WRITE(RECORD, QFILENAME, THIS_ITEM);
}
return;
/*  END OF PROGRAM */
}
/* ** */
}
}
