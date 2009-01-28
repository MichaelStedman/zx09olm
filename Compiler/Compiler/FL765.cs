//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL765 : UvBase
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
UvVar TRANS_LOG_REC = "";
UvVar OLD = "";
UvVar NEW = "";
UvVar COMP_ACCOUNT = "";
UvVar MD = "";
UvVar QREC = "";
FLTX2 FLTX2;
UvVar OLD_COMMON = "";
UvVar NEW_COMMON = "";
UvVar OLD_FILES = "";
UvVar NEW_FILES = "";
UvVar CHANGES = "";
UvVar CNT = "";
UvVar INCL = "";
UvVar EOF = "";
UvVar PROG = "";
UvVar NEWPROG = "";
UvVar OLD_EXISTS = "";
UvVar OLDPROG = "";
UvVar LINE = "";
UvVar START = "";
UvVar ITEM = "";
UvVar NEWINCL = "";
UvVar OLDINCL = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
UvVar nrf2 = "";
#endregion
public FL765() {
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
/*  COMPARES OLD & NEW SOURCES */
PRINT(COMMON.WASH);
PRINT(AT(10, 10) + "What account do you wish to compare ");
INPUTCR(out COMP_ACCOUNT);
if (!OPEN("MD", out MD)) { STOP(201, "MD"); }
QREC = "";
QREC[1] = "Q";
QREC[2] = COMP_ACCOUNT;
QREC[3] = "LFLEX.PROGS";
TRANS_LOG_REC = QREC;
nrf0 = "W";nrf1 = "MD";nrf2 = "OLD.SOURCE";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
QREC[3] = "FL.FILES";
TRANS_LOG_REC = QREC;
nrf0 = "W";nrf1 = "MD";nrf2 = "OLD.FL.FILES";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
QREC[3] = "FL.COMMON";
TRANS_LOG_REC = QREC;
nrf0 = "W";nrf1 = "MD";nrf2 = "OLD.FL.COMMON";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
if (!OPEN("OLD.FL.COMMON", out OLD_COMMON)) { STOP(201, "OLD.FL.COMMON"); }
if (!OPEN("FL.COMMON", out NEW_COMMON)) { STOP(201, "FL.COMMON"); }
if (!OPEN("OLD.FL.FILES", out OLD_FILES)) { STOP(201, "OLD.FL.FILES"); }
if (!OPEN("FL.FILES", out NEW_FILES)) { STOP(201, "FL.FILES"); }
if (!OPEN("OLD.SOURCE", out OLD)) { STOP(201, "Old Source file"); }
if (!OPEN("LFLEX.PROGS", out NEW)) { STOP(201, "New Source file"); }
if (!OPEN("FL.CODE.AMENDMENTS", out CHANGES)) { STOP(201, "FL.CODE.AMENDMENTS"); }
SELECT(NEW);
CNT = 0;
INCL = "INCLUDE";
PRINT(COMMON.WASH);
EOF = FALSE;
do {
if (!READNEXT(ref PROG, 0, 0, "")) { EOF = TRUE; }
if (EOF) break;
CNT = CNT + 1;
PRINT(AT(10, 8) + COMMON.EOL + AT(10, 8) + CNT + " Comparing " + PROG);
if (!(READ(ref NEWPROG, NEW, PROG))) {
PRINTCR("Cant find program " + PROG + " in the new source file");
STOP();
}
OLD_EXISTS = TRUE;
if (!(READ(ref OLDPROG, OLD, PROG))) {
OLD_EXISTS = FALSE;
}
if (OLD_EXISTS) {
/*  COMPARE */
if (NEWPROG != OLDPROG) {
PRINT(AT(10, 10) + PROG + " has changed");
TRANS_LOG_REC = 2;
nrf0 = "W";nrf1 = "FL.CODE.AMENDMENTS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PROG);
} else {
/*  COMPARE INCLUDE CODE */
LINE = 3;
do {
if (NEWPROG[LINE] == "") break;
if (INDEX(NEWPROG[LINE], INCL, 1)) {
START = INDEX(NEWPROG[LINE], INCL, 1);
ITEM = FIELD(NEWPROG[LINE].Substring(START, 999), " ", 3);
if (!(READ(ref NEWINCL, NEW_FILES, ITEM))) {
NEWINCL = "";
}
if (!(READ(ref OLDINCL, OLD_FILES, ITEM))) {
OLDINCL = "";
}
/*  COMPARE $INCLUDED CODE */
if (NEWINCL != OLDINCL) {
PRINT(AT(10, 11) + "Include code for " + PROG + " has changed");
TRANS_LOG_REC = 3;
nrf0 = "W";nrf1 = "FL.CODE.AMENDMENTS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PROG);
}
}
LINE = LINE + 1;
} while (true);
}
} else {
PRINT(AT(10, 12) + "New program " + PROG);
TRANS_LOG_REC = 1;
nrf0 = "W";nrf1 = "FL.CODE.AMENDMENTS";FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PROG);
}
} while (true);
}
}
}
