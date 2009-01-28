//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL560 : UvBase
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
readonly UvVar FL_CONTROL = 10;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] TRANS_REC = new UvVar[20];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] TRANSLATEFILE = new UvVar[100];
#endregion
#region Variables
UvVar TRANSFER_FILE_NAME = "";
UvVar TRANSFER_PARAM_NAME = "";
UvVar REPORT_TITLE = "";
UvVar BREAK_DETAILS = "";
UvVar TRANSLIST = "";
UvVar LIST_AVAILABLE = "";
UvVar AM = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar FL_UNIVERSE_TRANSFER = "";
UvVar NORECS = "";
UvVar REPORT_PAGE = "";
UvVar PAGE_ORIENT = "";
UvVar REPORT_LINES = "";
UvVar PAGE_POS = "";
UvVar REPORT_HEADER1 = "";
UvVar REPORT_HEADER2 = "";
UvVar SEQBIT = "";
UvVar BRKOFF = "";
UvVar FIRST_RUN = "";
UvVar SEQPRINT = "";
UvVar REPORT_HDRFMT = "";
UvVar REPORT_TOTAL = "";
UvVar TRANSFER_FILE = "";
UvVar FILES_NOT_OPEN = "";
UvVar CONVDELIM = "";
UvVar BREAK_REC = "";
UvVar BREAKFIELDS = "";
UvVar TOTALFIELDS = "";
UvVar TOTALCONVS = "";
UvVar BREAKONS = "";
UvVar COMMITRECORD = "";
UvVar GRANDTOTAL = "";
UvVar TRANSREC = "";
UvVar REPORT_COLPOS = "";
UvVar REPORT_FORMAT = "";
UvVar FIELD_TYPE = "";
UvVar MAXOCONVS = "";
UvVar POSTOTCONV = "";
UvVar NO_OF_FIELDS = "";
UvVar FIELD_NO = "";
UvVar THIS_COLPOS = "";
FL006 FL006;
FL_PRINT FL_PRINT;
UvVar EOF = "";
UvVar KEY = "";
UvVar MEMREC = "";
UvVar TRANSMVCNT = "";
UvVar ALLMVSDONE = "";
UvVar TRANSFIELD = "";
UvVar SEQTOTAL = "";
UvVar TLOOP = "";
UvVar THISTOTAL = "";
UvVar LENSTR = "";
UvVar OUTPUTCONV = "";
UvVar TRANSMV = "";
UvVar CLOOP = "";
UvVar THISOCONV = "";
UvVar EXTSUB = "";
CallAt_EXTSUB CallAt_EXTSUB;
UvVar FLEFIELD_NO = "";
UvVar TRANS_RECID = "";
UvVar TRANSID = "";
UvVar THISFIELD = "";
UvVar TRANSLINE = "";
UvVar NO_OF_BREAKS = "";
UvVar BROKEN = "";
UvVar BREAK_FIELD_NO = "";
UvVar THIS_FORMAT = "";
UvVar TOTBIT = "";
UvVar TOTBRK = "";
UvVar TOTFMT = "";
UvVar TOTALFLD = "";
UvVar TOTFIELD = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL560(ref UvVar TRANSFER_FILE_NAME, ref UvVar TRANSFER_PARAM_NAME, ref UvVar REPORT_TITLE, ref UvVar BREAK_DETAILS, ref UvVar TRANSLIST, ref UvVar LIST_AVAILABLE) {
this.TRANSFER_FILE_NAME = TRANSFER_FILE_NAME;
this.TRANSFER_PARAM_NAME = TRANSFER_PARAM_NAME;
this.REPORT_TITLE = REPORT_TITLE;
this.BREAK_DETAILS = BREAK_DETAILS;
this.TRANSLIST = TRANSLIST;
this.LIST_AVAILABLE = LIST_AVAILABLE;
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
/*  TEXT FILE TRANSFER */
PROGRAM = "FL560";
/* ***** */
/*  OPEN FILES */
/* ***** */
#region INCLUDE FL.FILES FL.UNIVERSE.TRANSFER

if (!(OPEN("FL.UNIVERSE.TRANSFER", out FL_UNIVERSE_TRANSFER))) {
STOP(201, "CANNOT OPEN FILES");
}

#endregion
#region INCLUDE FL.FILES FL.CONTROL
#region INCLUDE FL.FILES FL.CONTROL.EQU

#endregion

#region INCLUDE FL.FILES FL.CONTROL.DIM

#endregion

#endregion
/* ** WARNING!!! THIS PROGRAM  OPENS FILES A IT GOES */
/* ** */
/*  OUTPUT FILE NAME */
/* ** */
NORECS = 0;
REPORT_PAGE = 0;
PAGE_ORIENT = "L";
REPORT_LINES = "";
PAGE_POS = 0;
REPORT_HEADER1 = "";
REPORT_HEADER2 = "";
SEQBIT = "";
BRKOFF = 10;
FIRST_RUN = TRUE;
SEQPRINT = "";
REPORT_HDRFMT = "";
/*       REPORT.TITLE = "Hard coded title at the moment" */
REPORT_TOTAL = "Y";
if (!OPEN(TRANSFER_FILE_NAME, out TRANSFER_FILE)) { STOP(201, "INVALID TRANSFER FILE"); }
/* **** */
/*  SET UP VARIABLES */
/* **** */
FILES_NOT_OPEN = TRUE;
CONVDELIM = "~";
BREAK_REC = "";
BREAKFIELDS = "";
TOTALFIELDS = "";
TOTALCONVS = "";
BREAKONS = FALSE;
COMMITRECORD = TRUE;
GRANDTOTAL = "";
/* ** */
/*  GET HEADER DETAILS */
/* ** */
/* ** */
/*  FORMAT DATABASE FIELDS */
/* * */
/* !PRINT WASH: */
/* !CALL FL306 */
/* !PRINT @(25,4):'Transferring Details': */
PRINTCR(AT(10, 16) + "Creating Print Job");
if (!READ(ref TRANSREC, FL_UNIVERSE_TRANSFER, "FILE*" + TRANSFER_PARAM_NAME)) { STOP(201); }
REPORT_HEADER1 = TRANSREC[1, 1];
REPORT_HEADER2 = STR("-", TRANSREC[1, 3] * 10);
REPORT_COLPOS = TRANSREC[1, 3] * 10;
REPORT_HDRFMT = "0B";
REPORT_FORMAT = 0;
if (TRANSREC[1, 2] == "N") {
REPORT_HDRFMT = REPORT_COLPOS + "B";
REPORT_FORMAT = REPORT_COLPOS + "R";
}
REPORT_COLPOS = 0;
FIELD_TYPE = FORMAT(TRANSREC[1, 2], "L#1");
// BEGIN CASE
// CASE
if (FIELD_TYPE == "B") {
BREAKFIELDS[1, -1] = 1;
BREAKFIELDS[2, -1] = "";
BREAKONS = TRUE;
REPORT_TOTAL = "Y";
FIELD_TYPE = "C";
}// CASE
else if (FIELD_TYPE == "N") {
TOTALFIELDS[1, 1] = 1;
TOTALFIELDS[2, 1] = 0;
GRANDTOTAL[1, 1] = 0;
}
// END CASE
MAXOCONVS = DCOUNT(TRANSREC[1, 6], "~");
POSTOTCONV = FIELD(TRANSREC[1, 6], "~", MAXOCONVS);
if (POSTOTCONV.Substring(1, 2) == "MD") { TOTALCONVS[1, 1] = POSTOTCONV; }
NO_OF_FIELDS = DCOUNT(TRANSREC, AM);
for(FIELD_NO = 2; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1) {
FIELD_TYPE = FORMAT(TRANSREC[FIELD_NO, 2], "L#1");
// BEGIN CASE
// CASE
if (FIELD_TYPE == "B") {
BREAKFIELDS[1, -1] = FIELD_NO;
BREAKFIELDS[2, -1] = "";
BREAKONS = TRUE;
FIELD_TYPE = "C";
}// CASE
else if (FIELD_TYPE == "N") {
TOTALFIELDS[1, FIELD_NO] = FIELD_NO;
TOTALFIELDS[2, FIELD_NO] = 0;
GRANDTOTAL[1, FIELD_NO] = 0;
}
// END CASE
REPORT_HEADER1 = REPORT_HEADER1 + "|" + TRANSREC[FIELD_NO, 1];
REPORT_HEADER2 = REPORT_HEADER2 + "|" + STR("-", TRANSREC[FIELD_NO, 3] * 10);
REPORT_COLPOS = REPORT_COLPOS + (TRANSREC[FIELD_NO - 1, 3] * 10);
if (TRANSREC[FIELD_NO, 2] == "N") {
THIS_COLPOS = REPORT_COLPOS + (TRANSREC[FIELD_NO, 3] * 10) + "R";
} else {
THIS_COLPOS = REPORT_COLPOS;
}
REPORT_FORMAT = REPORT_FORMAT + VM + THIS_COLPOS;
REPORT_HDRFMT = REPORT_HDRFMT + VM + THIS_COLPOS + "B";
MAXOCONVS = DCOUNT(TRANSREC[FIELD_NO, 6], "~");
POSTOTCONV = FIELD(TRANSREC[FIELD_NO, 6], "~", MAXOCONVS);
if (POSTOTCONV.Substring(1, 2) == "MD") { TOTALCONVS[1, FIELD_NO] = POSTOTCONV; }
}
/* ** */
if (REPORT_COLPOS > 800) { PAGE_ORIENT = "L"; } else { PAGE_ORIENT = "P"; }
if (REPORT_COLPOS > 1100) {
nrf0 = 110;
nrf1 = "Report too big for page";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
}
/*  CREATE DATA PORTION */
/* ** */
/* DJA 29.10.99*  WRITESEQ REALHEADER ON SEQFILE ELSE STOP 201, "CANNOT WRITE HEADER ON SEQFILE" */
/*       CALL FL.PRINT(REPORT.TITLE,REPORT.HEADER1, REPORT.HEADER2,SEQBIT,REPORT.HDRFMT,REPORT.PAGE,PAGE.POS,PAGE.ORIENT,REPORT.LINES,REPORT.FORMAT) */
EOF = 0;
do {
if (!READNEXT(ref KEY, 0, 0, TRANSLIST)) { EOF = 1; }
if (EOF) break;
NORECS = NORECS + 1;
/*         IF MOD(NORECS,100) = 0 THEN PRINT ".": */
PRINTCR(AT(20, 18) + "Processing record " + NORECS + " out of " + LIST_AVAILABLE);
if (!(READ(ref MEMREC, TRANSFER_FILE, KEY))) {
nrf0 = 1;
FL006 = new FL006(ref PROGRAM, ref nrf0, ref KEY);
return;
}
if (BREAKONS) {
COMMITRECORD = FALSE;
L2000();
/*  Deal with Breakons */
} else {
TRANSMVCNT = 1;
do {
ALLMVSDONE = TRUE;
SEQBIT = "";
for(FIELD_NO = 1; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1) {
L0500();
/*  TRANSLATE DATA */
if (FIELD_NO == 1) {
SEQBIT = TRANSFIELD;
} else {
SEQBIT = SEQBIT + "|" + TRANSFIELD;
}
if (TRANSREC[FIELD_NO, 2] == "N") {
if (NUM(TRANSFIELD)) {
if (TOTALCONVS[1, FIELD_NO] != "") {
GRANDTOTAL[1, FIELD_NO] = GRANDTOTAL[1, FIELD_NO] + ICONV(TRANSFIELD, TOTALCONVS[1, FIELD_NO]);
} else {
GRANDTOTAL[1, FIELD_NO] = GRANDTOTAL[1, FIELD_NO] + TRANSFIELD;
}
}
}
}
FILES_NOT_OPEN = FALSE;
FL_PRINT = new FL_PRINT(ref REPORT_TITLE, ref REPORT_HEADER1, ref REPORT_HEADER2, ref SEQBIT, ref REPORT_HDRFMT, ref REPORT_PAGE, ref PAGE_POS, ref PAGE_ORIENT, ref REPORT_LINES, ref REPORT_FORMAT);
if (ALLMVSDONE) break;
TRANSMVCNT = TRANSMVCNT + 1;
} while (true);
}
} while (true);
/* *** */
/*  IF BREAKONS DETECTED THEN WRITE RECORD IF NOT ALREADY COMMITED TO FILE */
/* ** */
if (BREAKONS && COMMITRECORD == FALSE) {
FL_PRINT = new FL_PRINT(ref REPORT_TITLE, ref REPORT_HEADER1, ref REPORT_HEADER2, ref SEQBIT, ref REPORT_HDRFMT, ref REPORT_PAGE, ref PAGE_POS, ref PAGE_ORIENT, ref REPORT_LINES, ref REPORT_FORMAT);
/* GOSUB 3000;! */
SEQBIT = "";
}
if (REPORT_TOTAL == "Y") {
if (BREAKONS) {
L3000();
}
SEQBIT = GRANDTOTAL[1, 1];
SEQTOTAL = "";
if (SEQBIT != "") {
if (TOTALCONVS[1, 1] != "") {
SEQBIT = OCONV(SEQBIT, TOTALCONVS[1, 1]);
}
SEQTOTAL = STR("=", LEN(SEQBIT));
}
for(TLOOP = 2; TLOOP <= NO_OF_FIELDS; TLOOP += 1) {
THISTOTAL = GRANDTOTAL[1, TLOOP];
if (THISTOTAL != "") {
if (TOTALCONVS[1, TLOOP] != "") {
THISTOTAL = OCONV(THISTOTAL, TOTALCONVS[1, TLOOP]);
}
}
SEQBIT = SEQBIT + "|" + THISTOTAL;
SEQTOTAL = SEQTOTAL + "|" + STR("=", LEN(THISTOTAL));
}
FL_PRINT = new FL_PRINT(ref REPORT_TITLE, ref REPORT_HEADER1, ref REPORT_HEADER2, ref SEQTOTAL, ref REPORT_HDRFMT, ref REPORT_PAGE, ref PAGE_POS, ref PAGE_ORIENT, ref REPORT_LINES, ref REPORT_FORMAT);
FL_PRINT = new FL_PRINT(ref REPORT_TITLE, ref REPORT_HEADER1, ref REPORT_HEADER2, ref SEQBIT, ref REPORT_HDRFMT, ref REPORT_PAGE, ref PAGE_POS, ref PAGE_ORIENT, ref REPORT_LINES, ref REPORT_FORMAT);
}
REPORT_PAGE = -1;
FL_PRINT = new FL_PRINT(ref REPORT_TITLE, ref REPORT_HEADER1, ref REPORT_HEADER2, ref SEQBIT, ref REPORT_HDRFMT, ref REPORT_PAGE, ref PAGE_POS, ref PAGE_ORIENT, ref REPORT_LINES, ref REPORT_FORMAT);
/*      FOR FIELD.NO = 1 TO NO.OF.FIELDS */
/*  DJA 29.10.99 */
/* !*PRINT @(10,20):'Process complete ': ;INPUT FLEX,1: */
return;
/* **** */
}
void L0500() {
/*  work out data */
/* **** */
LENSTR = "L#" + TRANSREC[FIELD_NO, 3];
OUTPUTCONV = TRANSREC[FIELD_NO, 6];
if (TRANSREC[FIELD_NO, 4] == 0) {
TRANSFIELD = KEY;
} else {
TRANSMV = TRANSREC[FIELD_NO, 5];
if (TRANSMV == "ALL") {
TRANSFIELD = MEMREC[TRANSREC[FIELD_NO, 4], TRANSMVCNT];
if (TRIM(MEMREC[TRANSREC[FIELD_NO, 4], TRANSMVCNT + 1]) != "") {
ALLMVSDONE = FALSE;
}
} else {
TRANSFIELD = MEMREC[TRANSREC[FIELD_NO, 4], TRANSREC[FIELD_NO, 5]];
}
}
if (OUTPUTCONV != "") {
for(CLOOP = 1; CLOOP <= DCOUNT(OUTPUTCONV, CONVDELIM); CLOOP += 1) {
THISOCONV = FIELD(OUTPUTCONV, CONVDELIM, CLOOP);
TRANSFIELD = OCONV(TRANSFIELD, THISOCONV);
}
}
EXTSUB = TRANSREC[FIELD_NO, 12];
if (EXTSUB != "") {
CallAt_EXTSUB = new CallAt_EXTSUB(ref EXTSUB, ref KEY, ref TRANSFIELD, ref TRANSREC, ref FIELD_NO);
}
if (TRANSREC[FIELD_NO, 7] != "") {
L1000();
/*  Deal with translate */
}
return;
/* **************** */
/*  TRANSLATE SUBROUTINE */
/* ***************** */
}
void L1000()
{
   /*  DEAL WITH TRANSLATE */
   /* ************************* */
   if (FILES_NOT_OPEN)
   {
      if (!(OPEN(TRANSREC[FIELD_NO, 7], out TRANSLATEFILE[FIELD_NO])))
      {
         PRINTCR(TRANSREC[FIELD_NO, 7] + " MISSING!!!!!");
         PRINTCR("WARNING TRANSLATE FILE NOT FOUND");
         INPUTCR(out FLEFIELD_NO);
         return;
         /*  DO NOTHING IF INVALID TRANSLATE FILE */
      }
   }
   TRANS_RECID = TRANSREC[FIELD_NO, 11];
   if (TRANS_RECID == "")
   {
      TRANSID = TRANSFIELD;
   }
   else
   {
      TRANSID = "";
      for (CLOOP = 1; CLOOP <= DCOUNT(TRANS_RECID, CONVDELIM); CLOOP += 1)
      {
         THISFIELD = FIELD(TRANS_RECID, CONVDELIM, CLOOP);
         // BEGIN CASE
         // CASE
         if (MATCH(THISFIELD, "0N"))
         {
            TRANSID = TRANSID + MEMREC[THISFIELD];
         }// CASE
         else if (THISFIELD.Substring(1, 1) == "\"")
         {
            TRANSID = TRANSID + FIELD(THISFIELD, "\"", 2);
         }
         // END CASE
      }
      if (READV(ref TRANSLINE, TRANSLATEFILE[FIELD_NO], TRANSID, TRANSREC[FIELD_NO, 8]))
      {
         TRANSFIELD = TRANSLINE[1, TRANSREC[FIELD_NO, 9]];
         OUTPUTCONV = TRANSREC[FIELD_NO, 10];
         if (OUTPUTCONV != "")
         {
            for (CLOOP = 1; CLOOP <= DCOUNT(OUTPUTCONV, CONVDELIM); CLOOP += 1)
            {
               THISOCONV = FIELD(OUTPUTCONV, CONVDELIM, CLOOP);
               TRANSFIELD = OCONV(TRANSFIELD, THISOCONV);
            }
         }
      }
      else
      {
         TRANSFIELD = "!MISSING!";
         /* !        TRANSFIELD = "" */
      }
      return;
      /* **** */
   }
}
void L2000() {
/*  Deal with break ons */
/* **** */
/*  Detect Break on fields */
/*  BREAKREC field changes */
NO_OF_BREAKS = DCOUNT(BREAKFIELDS[1], VM);
BROKEN = FALSE;
for(BREAK_FIELD_NO = 1; BREAK_FIELD_NO <= NO_OF_BREAKS; BREAK_FIELD_NO += 1) {
FIELD_NO = BREAKFIELDS[1, BREAK_FIELD_NO];
L0500();
/*  Get data for field in question */
if (TRANSFIELD != BREAKFIELDS[2, BREAK_FIELD_NO]) {
if (FIRST_RUN == FALSE && BROKEN == FALSE) {
BROKEN = TRUE;
L3000();
}
BREAKFIELDS[2, BREAK_FIELD_NO] = TRANSFIELD;
THIS_FORMAT = (BREAK_FIELD_NO - 1) * BRKOFF + "BI";
FL_PRINT = new FL_PRINT(ref REPORT_TITLE, ref REPORT_HEADER1, ref REPORT_HEADER2, ref TRANSFIELD, ref REPORT_HDRFMT, ref REPORT_PAGE, ref PAGE_POS, ref PAGE_ORIENT, ref REPORT_LINES, ref THIS_FORMAT);
COMMITRECORD = TRUE;
}
}
FIRST_RUN = FALSE;
if (COMMITRECORD && BREAK_DETAILS == FALSE) {
FL_PRINT = new FL_PRINT(ref REPORT_TITLE, ref REPORT_HEADER1, ref REPORT_HEADER2, ref SEQBIT, ref REPORT_HDRFMT, ref REPORT_PAGE, ref PAGE_POS, ref PAGE_ORIENT, ref REPORT_LINES, ref REPORT_FORMAT);
SEQBIT = "";
}
SEQBIT = "";
for(FIELD_NO = 1; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1) {
L0500();
if (TOTALFIELDS[1, FIELD_NO] == FIELD_NO) {
/*                TOTALFIELDS<2,FIELD.NO> = OCONV( TOTALFIELDS<2,FIELD.NO> + TRANSFIELD, TOTALCONVS<1,FIELD.NO>) */
if (TOTALCONVS[1, FIELD_NO] != "") {
TOTALFIELDS[2, FIELD_NO] = TOTALFIELDS[2, FIELD_NO] + ICONV(TRANSFIELD, TOTALCONVS[1, FIELD_NO]);
GRANDTOTAL[1, FIELD_NO] = GRANDTOTAL[1, FIELD_NO] + ICONV(TRANSFIELD, TOTALCONVS[1, FIELD_NO]);
} else {
TOTALFIELDS[2, FIELD_NO] = TOTALFIELDS[2, FIELD_NO] + TRANSFIELD;
GRANDTOTAL[1, FIELD_NO] = GRANDTOTAL[1, FIELD_NO] + TRANSFIELD;
}
/*                   TRANSFIELD = TOTALFIELDS<2,FIELD.NO> */
} else {
/* MAY BE FOUND NECESSARY TO PROVE carried forward data */
/* TRANSFIELD = "#":TRANSFIELD */
}
SEQBIT = SEQBIT + TRANSFIELD + "|";
}
if (BREAK_DETAILS) {
FL_PRINT = new FL_PRINT(ref REPORT_TITLE, ref REPORT_HEADER1, ref REPORT_HEADER2, ref SEQBIT, ref REPORT_HDRFMT, ref REPORT_PAGE, ref PAGE_POS, ref PAGE_ORIENT, ref REPORT_LINES, ref REPORT_FORMAT);
}
return;
/* ***** */
}
void L3000() {
/* ***** */
TOTBIT = "";
TOTBRK = "";
TOTFMT = REPORT_FORMAT;
for(TOTALFLD = 1; TOTALFLD <= NO_OF_FIELDS; TOTALFLD += 1) {
TOTFIELD = "";
if (TOTALFIELDS[1, TOTALFLD] == TOTALFLD) {
TOTFIELD = OCONV(TOTALFIELDS[2, TOTALFLD], TOTALCONVS[1, TOTALFLD]);
TOTALFIELDS[2, TOTALFLD] = 0;
} else {
/* MAY BE FOUND NECESSARY TO PROVE carried forward data */
/* TRANSFIELD = "#":TRANSFIELD */
}
TOTBIT = TOTBIT + TOTFIELD + "|";
TOTBRK = TOTBRK + STR("-", LEN(TOTFIELD) * 1.5M) + "|";
TOTFMT[1, TOTALFLD] = TOTFMT[1, TOTALFLD] + "B";
}
FL_PRINT = new FL_PRINT(ref REPORT_TITLE, ref REPORT_HEADER1, ref REPORT_HEADER2, ref TOTBRK, ref REPORT_HDRFMT, ref REPORT_PAGE, ref PAGE_POS, ref PAGE_ORIENT, ref REPORT_LINES, ref TOTFMT);
FL_PRINT = new FL_PRINT(ref REPORT_TITLE, ref REPORT_HEADER1, ref REPORT_HEADER2, ref TOTBIT, ref REPORT_HDRFMT, ref REPORT_PAGE, ref PAGE_POS, ref PAGE_ORIENT, ref REPORT_LINES, ref TOTFMT);
FL_PRINT = new FL_PRINT(ref REPORT_TITLE, ref REPORT_HEADER1, ref REPORT_HEADER2, ref TOTBRK, ref REPORT_HDRFMT, ref REPORT_PAGE, ref PAGE_POS, ref PAGE_ORIENT, ref REPORT_LINES, ref TOTFMT);
return;
/* ***** */
L9999:;
/*  THE END */
/* ***** */
}
}
}

