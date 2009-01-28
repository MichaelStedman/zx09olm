//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
public class FL566 : UvBase
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
readonly UvVar FL_CENTRES = 3;
readonly UvVar CENTRE_NAME = 1;
readonly UvVar CENTRE_FLOORS = 2;
readonly UvVar CENTRE_ACTIVITIES = 3;
readonly UvVar CENTRE_FACILITY_NUM = 4;
readonly UvVar normal = 0;
readonly UvVar italic = 1;
readonly UvVar bold = 2;
readonly UvVar title = 3;
readonly UvVar black = 0;
readonly UvVar red = 1;
readonly UvVar green = 2;
readonly UvVar blue = 3;
readonly UvVar left = 0;
readonly UvVar centre = 1;
readonly UvVar right = 2;
#endregion
#region String Constants
readonly UvVar INIT = "";
#endregion
#region Arrays
UvVar[] TRANS_REC = new UvVar[20];
UvVar[] CONTROLS_REC = new UvVar[20];
UvVar[] CENTRES_REC = new UvVar[4];
UvVar[] TRANSLATEFILE = new UvVar[100];
#endregion
#region Variables
UvVar TRANSFER_FILE_NAME = "";
UvVar TRANSFER_PARAM_NAME = "";
UvVar TRANSFER_DIRECTORY = "";
UvVar TRANSFER_OUTFILE = "";
UvVar TRANSLIST = "";
UvVar LIST_AVAILABLE = "";
UvVar SUCCESSFUL = "";
UvVar TODAYS_DATE = "";
UvVar AM = "";
UvVar VM = "";
UvVar PROGRAM = "";
UvVar FL_UNIVERSE_TRANSFER = "";
UvVar text_col_multiplyer = "";
UvVar date_col_multiplyer = "";
UvVar num_col_multiplyer = "";
UvVar NORECS = "";
UvVar NORECSOUT = "";
UvVar SEQFILE = "";
UvVar title_style = "";
UvVar title_colour = "";
UvVar title_just = "";
UvVar header_colour = "";
UvVar header_just = "";
UvVar header_style = "";
UvVar body_colour = "";
UvVar body_just = "";
UvVar body_style = "";
UvVar body_num_just = "";
UvVar body_neg_col = "";
UvVar total_colour = "";
UvVar total_style = "";
UvVar total_just = "";
UvVar TRANSFER_FILE = "";
FL006 FL006;
UvVar FILES_NOT_OPEN = "";
UvVar CONVDELIM = "";
UvVar BREAKREC = "";
UvVar BREAKFIELDS = "";
UvVar TOTALFIELDS = "";
UvVar BREAKONS = "";
UvVar COMMITRECORD = "";
UvVar HEADERREC = "";
UvVar HTMEND = "";
UvVar N = "";
UvVar TRANSREC = "";
UvVar REALHEADER = "";
UvVar NO_OF_FIELDS = "";
UvVar LAST_ROW = "";
UvVar LAST_COL = "";
UvVar THIS_COL = "";
UvVar THIS_ROW = "";
UvVar STYLE = "";
UvVar COLOUR = "";
UvVar JUST = "";
UvVar TEXT = "";
FL_GETHTM FL_GETHTM;
UvVar TITLETEXT = "";
UvVar HEADERTEXT = "";
UvVar FIELD_NO = "";
UvVar OUTTEXT = "";
UvVar COLWIDTH = "";
UvVar COLTYPE = "";
UvVar col_multiplyer = "";
UvVar COLTEXT = "";
UvVar FIELD_TYPE = "";
UvVar FLEN = "";
UvVar DLEN = "";
UvVar STYLEPOS = "";
UvVar HLINES = "";
UvVar HWRITE = "";
UvVar EOF = "";
UvVar SEQBIT = "";
UvVar KEY = "";
UvVar MEMREC = "";
UvVar TRANSMVCNT = "";
UvVar ALLMVSDONE = "";
UvVar TRANSFIELD = "";
UvVar SLINES = "";
UvVar SWRITE = "";
UvVar TOTALTEXT = "";
UvVar cell_col = "";
UvVar FWRITE = "";
UvVar WEOFSEQ = "";
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
UvVar BREAK_FIELD_NO = "";
#endregion
#region Non Referenced Vars used by CALLs
UvVar nrf0 = "";
UvVar nrf1 = "";
#endregion
public FL566(ref UvVar TRANSFER_FILE_NAME, ref UvVar TRANSFER_PARAM_NAME, ref UvVar TRANSFER_DIRECTORY, ref UvVar TRANSFER_OUTFILE, ref UvVar TRANSLIST, ref UvVar LIST_AVAILABLE, ref UvVar SUCCESSFUL) {
this.TRANSFER_FILE_NAME = TRANSFER_FILE_NAME;
this.TRANSFER_PARAM_NAME = TRANSFER_PARAM_NAME;
this.TRANSFER_DIRECTORY = TRANSFER_DIRECTORY;
this.TRANSFER_OUTFILE = TRANSFER_OUTFILE;
this.TRANSLIST = TRANSLIST;
this.LIST_AVAILABLE = LIST_AVAILABLE;
this.SUCCESSFUL = SUCCESSFUL;
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
/*  HTML FILE TRANSFER; BY Richard Turner */
PROGRAM = "FL566";
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
#region INCLUDE FL.FILES FL.CENTRES
#region INCLUDE FL.FILES FL.CENTRES.EQU

#endregion

#region INCLUDE FL.FILES FL.CENTRES.DIM

#endregion
#region INCLUDE FL.FILES FL.CENTRES.VAR

#endregion

#endregion
/* ** WARNING!!! THIS PROGRAM  OPENS FILES A IT GOES */
/* ** */
/*  OUTPUT FILE NAME */
/* ** */
text_col_multiplyer = 9;
date_col_multiplyer = 7;
num_col_multiplyer = 7;
if (!READV(ref CENTRES_REC[CENTRE_NAME], COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 1)) { CENTRES_REC[CENTRE_NAME] = "UNKNOWN"; }
if (TRANSFER_OUTFILE == "") { TRANSFER_OUTFILE = "MEMFILE.HTM"; } else {
TRANSFER_OUTFILE = TRANSFER_OUTFILE + ".HTM";
}
NORECS = 0;
NORECSOUT = 2;
SUCCESSFUL = TRUE;
SEQFILE = "";
/*      READ TRANSFER.DIRECTORY FROM FL.CONTROL,"UV.TRANS.DIR" ELSE */
/*         TRANSFER.DIRECTORY = "C:\TEMP\" */
/*      END */
title_style = title;
title_colour = green;
title_just = centre;
header_colour = blue;
header_just = centre;
header_style = bold;
body_colour = black;
body_just = left;
body_style = normal;
body_num_just = right;
body_neg_col = red;
total_colour = green;
total_style = bold;
total_just = right;
if (!(OPEN(TRANSFER_FILE_NAME, out TRANSFER_FILE))) {
nrf0 = 6;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
TRANSFER_OUTFILE = TRANSFER_DIRECTORY + TRANSFER_OUTFILE;
if (!(OPENSEQ(TRANSFER_OUTFILE, out SEQFILE))) {
CREATE(SEQFILE);
SUCCESSFUL = FALSE;
nrf0 = 4;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}

/*      OPEN TRANSFER.FILE.NAME TO TRANSFER.FILE ELSE STOP 201,"INVALID TRANSFER FILE" */
/* RT MOVED TO BEFORE LAST OPEN 1408      OPEN TRANSFER.FILE.NAME TO TRANSFER.FILE ELSE */
/* RT MOVED TO BEFORE LAST OPEN 1408         CALL FL006(PROGRAM,6,"") */
/* RT MOVED TO BEFORE LAST OPEN 1408         RETURN */
/* RT MOVED TO BEFORE LAST OPEN 1408      END */
/* **** */
/*  SET UP VARIABLES */
/* **** */
FILES_NOT_OPEN = TRUE;
CONVDELIM = "~";
BREAKREC = "";
BREAKFIELDS = "";
TOTALFIELDS = "";
BREAKONS = FALSE;
COMMITRECORD = TRUE;
/* ** */
/*  GET HEADER DETAILS */
/* ** */
/*      READ HEADERREC FROM FL.UNIVERSE.TRANSFER,"HTM.HEADER" ELSE STOP "NO HEADER" */
if (!(READ(ref HEADERREC, FL_UNIVERSE_TRANSFER, "HTM.HEADER"))) {
nrf0 = 8;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (!(READ(ref HTMEND, FL_UNIVERSE_TRANSFER, "HTM.FOOTER"))) {
nrf0 = 81;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
/*  FORMAT DATABASE FIELDS */
/* * */
/* !*   PRINT @(0,16):EOS: */
for(N = 3; N <= 19; N += 1) {
PRINT(AT(0, N) + COMMON.EOL);
}
PRINT(AT(10, 16) + "Creating file " + TRANSFER_OUTFILE);
if (!READ(ref TRANSREC, FL_UNIVERSE_TRANSFER, "FILE*" + TRANSFER_PARAM_NAME)) { STOP("NO TRANS REC"); }
REALHEADER = HEADERREC;
NO_OF_FIELDS = DCOUNT(TRANSREC, AM);
/*  Generate Headers */
LAST_ROW = 0;
LAST_COL = 0;
THIS_COL = 1;
THIS_ROW = 1;
STYLE = title_style;
COLOUR = title_colour;
JUST = title_just;
TEXT = "Flex Data Transfer from " + CENTRES_REC[CENTRE_NAME] + " - Generated on " + OCONV(TODAYS_DATE, "D4/") + " at " + OCONV(TIME(), "MTH");
FL_GETHTM = new FL_GETHTM(ref TEXT, ref TITLETEXT, ref LAST_ROW, ref LAST_COL, ref THIS_ROW, ref THIS_COL, ref STYLE, ref JUST, ref COLOUR);
THIS_ROW = THIS_ROW + 1;
COLOUR = header_colour;
JUST = header_just;
STYLE = header_style;
HEADERTEXT = "";
LAST_COL = 0;
for(FIELD_NO = 1; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1) {
TEXT = TRANSREC[FIELD_NO, 1];
if (INDEX(TEXT, "+", 1) >= LEN(TEXT)) {
TEXT = TEXT.Substring(1, LEN(TEXT) - 1);
}
FL_GETHTM = new FL_GETHTM(ref TEXT, ref OUTTEXT, ref LAST_ROW, ref LAST_COL, ref THIS_ROW, ref FIELD_NO, ref STYLE, ref JUST, ref COLOUR);
COLWIDTH = TRANSREC[FIELD_NO, 3];
COLTYPE = TRANSREC[FIELD_NO, 2];
// BEGIN CASE
// CASE
if (COLTYPE == "D") {
col_multiplyer = date_col_multiplyer;
}// CASE
else if (COLTYPE == "N") {
col_multiplyer = num_col_multiplyer;
}// CASE
else if (OTHERWISE) {
col_multiplyer = text_col_multiplyer;
}
// END CASE
COLWIDTH = COLWIDTH * col_multiplyer;
COLTEXT = "<col width=" + COLWIDTH + " style='mso-width-source:userset;mso-width-alt:" + INT(COLWIDTH * 36.57M) + ";width:" + INT((COLWIDTH * 36.57M) / 48.75M) + "pt'>";
REALHEADER = REALHEADER + AM + COLTEXT;
HEADERTEXT[-1] = OUTTEXT;
/*  ADD Field Type */
/*  If field type is a B then change to a C */
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
}
// END CASE
/*         REALHEADER = REALHEADER : TRANSREC<FIELD.NO,2> "L#1" */
FLEN = TRANSREC[FIELD_NO, 3];
if (TRANSREC[FIELD_NO, 6] == "MD2") {
DLEN = 2;
} else {
DLEN = 0;
}
}
/* ** */
/*  CREATE DATA PORTION */
/* ** */
/*      EXECUTE "SELECT TRANSFER.FILE (30" */
/*      PRINT "SELECTING" */
/*      SELECT TRANSFER.FILE TO TRANSLIST */
STYLEPOS = INDEX(TITLETEXT, "style", 2);
TITLETEXT = TITLETEXT.Substring(1, STYLEPOS - 1) + "colspan=10 " + TITLETEXT.Substring(STYLEPOS, 9999);
REALHEADER[-1] = TITLETEXT;
REALHEADER[-1] = HEADERTEXT;
/*      WRITEBLK REALHEADER ON SEQFILE ELSE STOP 201, "CANNOT WRITE HEADER ON SEQFILE" */
HLINES = DCOUNT(REALHEADER, AM);
for(HWRITE = 1; HWRITE <= HLINES; HWRITE += 1) {
if (!(WRITESEQ(REALHEADER[HWRITE], SEQFILE))) {
nrf0 = 9;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
}
/* ** */
/*  CREATE DATA PORTION */
/* ** */
EOF = 0;
COLOUR = body_colour;
STYLE = body_style;
JUST = body_just;
SEQBIT = "";
do {
if (!READNEXT(ref KEY, 0, 0, TRANSLIST)) { EOF = 1; }
if (EOF) break;
NORECS = NORECS + 1;
/* Moved to 198         THIS.ROW = THIS.ROW + 1 */
THIS_COL = 0;
if (MOD(NORECS, 7) == 1) {
PRINTCR(AT(20, 18) + "Processing record " + NORECS + " out of " + LIST_AVAILABLE);
}
if (!(READ(ref MEMREC, TRANSFER_FILE, KEY))) {
nrf0 = 1;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
if (BREAKONS) {
COMMITRECORD = FALSE;
L2000();
/*  Deal with break ons */
} else {
THIS_ROW = THIS_ROW + 1;
TRANSMVCNT = 1;
do {
SEQBIT = "";
ALLMVSDONE = TRUE;
LAST_COL = 0;
for(FIELD_NO = 1; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1) {
L0500();
/*  Translate the data */
TEXT = TRANSFIELD;
COLOUR = body_colour;
JUST = body_just;
if (NUM(TEXT)) {
if (TRANSREC[FIELD_NO, 2] == "N") {
JUST = body_num_just;
}
if (TEXT < 0) { COLOUR = body_neg_col; }
}
FL_GETHTM = new FL_GETHTM(ref TEXT, ref OUTTEXT, ref LAST_ROW, ref LAST_COL, ref THIS_ROW, ref FIELD_NO, ref STYLE, ref JUST, ref COLOUR);
SEQBIT[-1] = OUTTEXT;
}
NORECSOUT = NORECSOUT + 1;
FILES_NOT_OPEN = FALSE;
SLINES = DCOUNT(SEQBIT, AM);
for(SWRITE = 1; SWRITE <= SLINES; SWRITE += 1) {
if (!(WRITESEQ(SEQBIT[SWRITE], SEQFILE))) {
nrf0 = 7;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
}
if (ALLMVSDONE) break;
TRANSMVCNT = TRANSMVCNT + 1;
} while (true);
}
} while (true);
/* *** */
/*  IF BREAKONS DETECTED THEN WRITE RECORD IF NOT ALREADY COMMITED TO FILE */
/* ** */
if (BREAKONS && COMMITRECORD == FALSE) {
for(SWRITE = 1; SWRITE <= DCOUNT(SEQBIT, AM); SWRITE += 1) {
if (!(WRITESEQ(SEQBIT[SWRITE], SEQFILE))) {
nrf0 = 7;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
}
}
/*      FOR FIELD.NO = 1 TO NO.OF.FIELDS */
/*         WRITESEQ HTM.END ON SEQFILE ELSE STOP 201, "I/O ERROR CHECK TRANSFER FILE PRIV" */
/*      NEXT FIELD.NO */
PRINTCR(AT(20, 18) + "Processed  record " + NORECS + " out of " + LIST_AVAILABLE);
TOTALTEXT = "";
THIS_ROW = THIS_ROW + 1;
LAST_COL = 0;
for(FIELD_NO = 1; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1) {
/*          IF TRANSREC<FIELD.NO,2> = "N" AND INDEX(TRANSREC<FIELD.NO,1>,"+",1) = LEN(TRANSREC<FIELD.NO,1>) THEN */
/*          IF TRANSREC<FIELD.NO,2> = "N" AND */
if (INDEX(TRANSREC[FIELD_NO, 1], "+", 1) == LEN(TRANSREC[FIELD_NO, 1])) {
cell_col = CHAR(64 + MOD(FIELD_NO, 26));
if (FIELD_NO > 26) {
cell_col = CHAR(64 + MOD(FIELD_NO - 26, 26)) + cell_col;
}
/*             TEXT = 'x:fmla="=SUM(':cell.col:3:':':cell.col:NORECSOUT:')">=' */
TEXT = "&SUM(" + cell_col + 3 + ":" + cell_col + NORECSOUT + ")&";
COLOUR = total_colour;
JUST = total_just;
STYLE = total_style;
FL_GETHTM = new FL_GETHTM(ref TEXT, ref OUTTEXT, ref LAST_ROW, ref LAST_COL, ref THIS_ROW, ref FIELD_NO, ref STYLE, ref JUST, ref COLOUR);
TOTALTEXT[-1] = OUTTEXT;
}
}
HTMEND = TOTALTEXT + AM + HTMEND;
for(FWRITE = 1; FWRITE <= DCOUNT(HTMEND, AM); FWRITE += 1) {
if (!WRITESEQ(HTMEND[FWRITE], SEQFILE)) { STOP(201, " I/O ERROR CHECK"); }
}
//WEOFSEQ
//SEQFILE
CLOSESEQ(SEQFILE);
return;
/* **************** */
/*  TRANSLATE SUBROUTINE */
/* ***************** */
/* ****** */
}
void L0500() {
/*  Get the data for the field */
/* ****** */
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
/* ************************* */
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
         /* !           TRANSFIELD = "" */
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
for(BREAK_FIELD_NO = 1; BREAK_FIELD_NO <= NO_OF_BREAKS; BREAK_FIELD_NO += 1) {
FIELD_NO = BREAKFIELDS[1, BREAK_FIELD_NO];
L0500();
/*  Get data for field in question */
if (TRANSFIELD != BREAKFIELDS[2, BREAK_FIELD_NO]) {
BREAKFIELDS[2, BREAK_FIELD_NO] = TRANSFIELD;
COMMITRECORD = TRUE;
}
}
if (COMMITRECORD) {
SLINES = DCOUNT(SEQBIT, AM);
for(SWRITE = 1; SWRITE <= SLINES; SWRITE += 1) {
if (!(WRITESEQ(SEQBIT[SWRITE], SEQFILE))) {
nrf0 = 7;
nrf1 = "";
FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
return;
}
}
NORECSOUT = NORECSOUT + 1;
}
SEQBIT = "";
THIS_ROW = THIS_ROW + 1;
LAST_COL = 0;
for(FIELD_NO = 1; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1) {
L0500();
if (TOTALFIELDS[1, FIELD_NO] == FIELD_NO) {
if (COMMITRECORD == TRUE) {
TOTALFIELDS[2, FIELD_NO] = 0;
}
TOTALFIELDS[2, FIELD_NO] = TOTALFIELDS[2, FIELD_NO] + TRANSFIELD;
TRANSFIELD = TOTALFIELDS[2, FIELD_NO];
} else {
/* MAY BE FOUND NECESSARY TO PROVE carried forward data */
/* TRANSFIELD = "#":TRANSFIELD */
}
TEXT = TRANSFIELD;
COLOUR = body_colour;
JUST = body_just;
if (NUM(TEXT)) {
if (TRANSREC[FIELD_NO, 2] == "N") {
JUST = body_num_just;
}
if (TEXT < 0) { COLOUR = body_neg_col; }
}
FL_GETHTM = new FL_GETHTM(ref TEXT, ref OUTTEXT, ref LAST_ROW, ref LAST_COL, ref THIS_ROW, ref FIELD_NO, ref STYLE, ref JUST, ref COLOUR);
SEQBIT[-1] = OUTTEXT;
}
return;
/* ***** */
L9999:;
/*  THE END */
/* ***** */
}
}
}
