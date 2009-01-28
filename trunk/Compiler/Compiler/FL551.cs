//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL551 : UvBase
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
      UvVar TRANSFER_DIRECTORY = "";
      UvVar TRANSFER_OUTFILE = "";
      UvVar TRANSLIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar SUCCESSFUL = "";
      UvVar AM = "";
      UvVar VM = "";
      UvVar PROGRAM = "";
      UvVar FL_UNIVERSE_TRANSFER = "";
      UvVar NORECS = "";
      UvVar SEQFILE = "";
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
      UvVar DBF_HEADER = "";
      UvVar DBF_FIELD2 = "";
      UvVar DBF_TYPE = "";
      UvVar DBF_END = "";
      UvVar N = "";
      UvVar TRANSREC = "";
      UvVar REALHEADER = "";
      UvVar FPOS = "";
      UvVar NO_OF_FIELDS = "";
      UvVar FIELD_NO = "";
      UvVar FIELD_TYPE = "";
      UvVar FLEN = "";
      UvVar DLEN = "";
      UvVar TOTAL_LEN = "";
      UvVar EOF = "";
      UvVar SEQBIT = "";
      UvVar KEY = "";
      UvVar MEMREC = "";
      UvVar TRANSMVCNT = "";
      UvVar ALLMVSDONE = "";
      UvVar TRANSFIELD = "";
      UvVar LENSTR = "";
      UvVar SEQFILE_APPEND = "";
      UvVar NULLREC = "";
      UvVar BYTE1 = "";
      UvVar BYTE2 = "";
      UvVar BYTE3 = "";
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
      public FL551(ref UvVar TRANSFER_FILE_NAME, ref UvVar TRANSFER_PARAM_NAME, ref UvVar TRANSFER_DIRECTORY, ref UvVar TRANSFER_OUTFILE, ref UvVar TRANSLIST, ref UvVar LIST_AVAILABLE, ref UvVar SUCCESSFUL)
      {
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
         /*  ODBC FILE TRANSFER; BY Richard Turner */
         PROGRAM = "FL551";
         /* ***** */
         /*  OPEN FILES */
         /* ***** */
         #region INCLUDE FL.FILES FL.UNIVERSE.TRANSFER

         if (!(OPEN("FL.UNIVERSE.TRANSFER", out FL_UNIVERSE_TRANSFER)))
         {
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
         if (TRANSFER_OUTFILE == "") { TRANSFER_OUTFILE = "MEMFILE.DBF"; }
         else
         {
            TRANSFER_OUTFILE = TRANSFER_OUTFILE + ".DBF";
         }
         NORECS = 0;
         SUCCESSFUL = TRUE;
         SEQFILE = "";
         /*      READ TRANSFER.DIRECTORY FROM FL.CONTROL,"UV.TRANS.DIR" ELSE */
         /*         TRANSFER.DIRECTORY = "C:\TEMP\" */
         /*      END */
         if (!(OPEN(TRANSFER_FILE_NAME, out TRANSFER_FILE)))
         {
            nrf0 = 6;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         TRANSFER_OUTFILE = TRANSFER_DIRECTORY + TRANSFER_OUTFILE;
         if (!(OPENSEQ(TRANSFER_OUTFILE, out SEQFILE)))
         {
            if (!(CREATE(SEQFILE)))
            {
               SUCCESSFUL = FALSE;
               nrf0 = 4;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               return;
            }
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
         /*      READ HEADERREC FROM FL.UNIVERSE.TRANSFER,"DBFHEAD" ELSE STOP "NO HEADER" */
         /* RT 123FIX!     READ HEADERREC FROM FL.UNIVERSE.TRANSFER,"DBFHEAD" ELSE */
         /* RT 123FIX!        CALL FL006(PROGRAM,8,"") */
         /* RT 123FIX!        RETURN */
         /* RT 123FIX!     END */
         HEADERREC = STR(CHAR(0), 32);
         //HEADERREC
         DBF_HEADER = HEADERREC.Substring(1, 32);
         DBF_FIELD2 = STR(CHAR(0), 14);
         DBF_TYPE = "C";
         /* RT (123FIX)     DBF.END = CHAR(13):CHAR(0): CHAR(32) */
         DBF_END = CHAR(13) + CHAR(0);
         /* ** */
         /*  FORMAT DATABASE FIELDS */
         /* * */
         /* !*   PRINT @(0,16):EOS: */
         for (N = 3; N <= 19; N += 1)
         {
            PRINT(AT(0, N) + COMMON.EOL);
         }
         PRINT(AT(10, 16) + "Creating file " + TRANSFER_OUTFILE);
         if (!READ(ref TRANSREC, FL_UNIVERSE_TRANSFER, "FILE*" + TRANSFER_PARAM_NAME)) { STOP("NO TRANS REC"); }
         REALHEADER = DBF_HEADER;
         /* RT 123FIX!     FPOS = 0 */
         FPOS = 1;
         NO_OF_FIELDS = DCOUNT(TRANSREC, AM);
         for (FIELD_NO = 1; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1)
         {
            REALHEADER = REALHEADER + TRANSREC[FIELD_NO, 1];
            for (COMMON.X = LEN(TRANSREC[FIELD_NO, 1]); COMMON.X <= 10; COMMON.X += 1)
            {
               REALHEADER = REALHEADER + CHAR(0);
            }
            /*  ADD Field Type */
            /*  If field type is a B then change to a C */
            FIELD_TYPE = FORMAT(TRANSREC[FIELD_NO, 2], "L#1");
            // BEGIN CASE
            // CASE
            if (FIELD_TYPE == "B")
            {
               BREAKFIELDS[1, -1] = FIELD_NO;
               BREAKFIELDS[2, -1] = "";
               BREAKONS = TRUE;
               FIELD_TYPE = "C";
            }// CASE
            else if (FIELD_TYPE == "N")
            {
               TOTALFIELDS[1, FIELD_NO] = FIELD_NO;
               TOTALFIELDS[2, FIELD_NO] = 0;
            }
            // END CASE
            /*         REALHEADER = REALHEADER : TRANSREC<FIELD.NO,2> "L#1" */
            REALHEADER = REALHEADER + FORMAT(FIELD_TYPE, "L#1");
            FPOS = FPOS + TRANSREC[FIELD_NO, 3];
            FLEN = TRANSREC[FIELD_NO, 3];
            if (TRANSREC[FIELD_NO, 6] == "MD2")
            {
               DLEN = 2;
            }
            else
            {
               DLEN = 0;
            }
            REALHEADER = REALHEADER + STR(CHAR(0), 4);
            REALHEADER = REALHEADER + CHAR(MOD(FLEN, 256));
            REALHEADER = REALHEADER + CHAR(MOD(DLEN, 256));
            /*         REALHEADER = REALHEADER : CHAR(INT(FLEN/256)) */
            REALHEADER = REALHEADER + DBF_FIELD2;
         }
         /* MHS REALHEADER = REALHEADER : DBF.END */
         /* MHS REALHEADER[5,1] = CHAR(MOD(NORECS,256)) */
         /* MHS REALHEADER[6,1] = CHAR(INT(NORECS/256)) */
         /* MHS REALHEADER[12,1] = CHAR(INT (FPOS/256)) */
         TOTAL_LEN = LEN(REALHEADER) - 1;
         /* MHS REALHEADER[11,1] = CHAR(MOD(FPOS,256)) */
         /* MHS REALHEADER[9,1] = CHAR(MOD(TOTAL.LEN,256)) */
         /* MHS REALHEADER[10,1] = CHAR(INT (TOTAL.LEN/256)) */
         /* ** */
         /*  CREATE DATA PORTION */
         /* ** */
         /*      EXECUTE "SELECT TRANSFER.FILE (30" */
         /*      PRINT "SELECTING" */
         /*      SELECT TRANSFER.FILE TO TRANSLIST */
         /*      WRITEBLK REALHEADER ON SEQFILE ELSE STOP 201, "CANNOT WRITE HEADER ON SEQFILE" */
         if (!(WRITEBLK(REALHEADER, SEQFILE)))
         {
            nrf0 = 9;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         EOF = 0;
         SEQBIT = "";
         do
         {
            if (!READNEXT(ref KEY, 0, 0, TRANSLIST)) { EOF = 1; }
            if (EOF) break;
            NORECS = NORECS + 1;
            if (MOD(NORECS, 7) == 1)
            {
               PRINTCR(AT(20, 18) + "Processing record " + NORECS + " out of " + LIST_AVAILABLE);
            }
            if (!(READ(ref MEMREC, TRANSFER_FILE, KEY)))
            {
               nrf0 = 1;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               return;
            }
            if (BREAKONS)
            {
               COMMITRECORD = FALSE;
               L2000();
               /*  Deal with break ons */
            }
            else
            {
               TRANSMVCNT = 1;
               do
               {
                  SEQBIT = "";
                  ALLMVSDONE = TRUE;
                  for (FIELD_NO = 1; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1)
                  {
                     L0500();
                     /*  Translate the data */
                     SEQBIT = SEQBIT + FORMAT(TRANSFIELD, LENSTR);
                  }
                  /* RTv 123FIX */
                  SEQBIT = SEQBIT + " ";
                  /* RT^123FIX */
                  FILES_NOT_OPEN = FALSE;
                  if (!(WRITEBLK(SEQBIT, SEQFILE)))
                  {
                     nrf0 = 7;
                     nrf1 = "";
                     FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                     return;
                  }
                  if (ALLMVSDONE) break;
                  TRANSMVCNT = TRANSMVCNT + 1;
               } while (true);
            }
         } while (true);
         /* *** */
         /*  IF BREAKONS DETECTED THEN WRITE RECORD IF NOT ALREADY COMMITED TO FILE */
         /* ** */
         if (BREAKONS && COMMITRECORD == FALSE)
         {
            /* RTv 123FIX */
            SEQBIT = SEQBIT + " ";
            /* RT^ 123FIX */
            if (!(WRITEBLK(SEQBIT, SEQFILE)))
            {
               nrf0 = 7;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               return;
            }
         }
         /*      FOR FIELD.NO = 1 TO NO.OF.FIELDS */
         /*         WRITEBLK DBF.END ON SEQFILE ELSE STOP 201, "I/O ERROR CHECK TRANSFER FILE PRIV" */
         /*      NEXT FIELD.NO */
         PRINTCR(AT(20, 18) + "Processed  record " + NORECS + " out of " + LIST_AVAILABLE);
         if (!WRITEBLK(CHAR(26), SEQFILE)) { STOP(201, " I/O ERROR CHECK"); }
         WEOFSEQ(SEQFILE);
         CLOSESEQ(SEQFILE);
         /* ** */
         /*  RE ADDRESS HEADER RECORD */
         /* ** */
         if (!(OPENSEQ(TRANSFER_OUTFILE, out SEQFILE_APPEND)))
         {
            if (!CREATE(SEQFILE_APPEND)) { CRTCR("CANT CREATE"); }
         }
         if (!READ(ref NULLREC, SEQFILE_APPEND, 4)) { STOP("NO DATA IN FILE"); }
         /*  RT 123FIX     WRITEBLK CHAR(MOD(NORECS,256)) : CHAR(INT(NORECS/256)) ON SEQFILE.APPEND ELSE STOP 201, "CANNOT UPDATE FIELD COUNTER " */
         BYTE1 = CHAR(MOD(NORECS, 256));
         BYTE2 = CHAR(MOD(INT(NORECS / 256), 256));
         BYTE3 = CHAR(INT(NORECS / (256 * 256)));
         if (!WRITEBLK(BYTE1 + BYTE2 + BYTE3, SEQFILE_APPEND)) { STOP(201, "CANNOT UPDATE FIELD COUNTER"); }
         /*  RT 123 FIX END */
         CLOSESEQ(SEQFILE_APPEND);
         /* !*  PRINT @(10,20):'Process complete ': ;INPUT FLEX,1: */
         return;
         /* **************** */
         /*  TRANSLATE SUBROUTINE */
         /* ***************** */
         /* ****** */
      }
      void L0500()
      {
         /*  Get the data for the field */
         /* ****** */
         LENSTR = "L#" + TRANSREC[FIELD_NO, 3];
         OUTPUTCONV = TRANSREC[FIELD_NO, 6];
         if (TRANSREC[FIELD_NO, 4] == 0)
         {
            TRANSFIELD = KEY;
         }
         else
         {
            TRANSMV = TRANSREC[FIELD_NO, 5];
            if (TRANSMV == "ALL")
            {
               TRANSFIELD = MEMREC[TRANSREC[FIELD_NO, 4], TRANSMVCNT];
               if (TRIM(MEMREC[TRANSREC[FIELD_NO, 4], TRANSMVCNT + 1]) != "")
               {
                  ALLMVSDONE = FALSE;
               }
            }
            else
            {
               TRANSFIELD = MEMREC[TRANSREC[FIELD_NO, 4], TRANSREC[FIELD_NO, 5]];
            }
         }
         if (OUTPUTCONV != "")
         {
            for (CLOOP = 1; CLOOP <= DCOUNT(OUTPUTCONV, CONVDELIM); CLOOP += 1)
            {
               THISOCONV = FIELD(OUTPUTCONV, CONVDELIM, CLOOP);
               TRANSFIELD = OCONV(TRANSFIELD, THISOCONV);
            }
         }
         EXTSUB = TRANSREC[FIELD_NO, 12];
         if (EXTSUB != "")
         {
            CallAt_EXTSUB = new CallAt_EXTSUB(ref EXTSUB, ref KEY, ref TRANSFIELD, ref TRANSREC, ref FIELD_NO);
         }
         if (TRANSREC[FIELD_NO, 7] != "")
         {
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
         }
         return;
         /* **** */
      }
      void L2000()
      {
         /*  Deal with break ons */
         /* **** */
         /*  Detect Break on fields */
         /*  BREAKREC field changes */
         NO_OF_BREAKS = DCOUNT(BREAKFIELDS[1], VM);
         for (BREAK_FIELD_NO = 1; BREAK_FIELD_NO <= NO_OF_BREAKS; BREAK_FIELD_NO += 1)
         {
            FIELD_NO = BREAKFIELDS[1, BREAK_FIELD_NO];
            L0500();
            /*  Get data for field in question */
            if (TRANSFIELD != BREAKFIELDS[2, BREAK_FIELD_NO])
            {
               BREAKFIELDS[2, BREAK_FIELD_NO] = TRANSFIELD;
               COMMITRECORD = TRUE;
            }
         }
         if (COMMITRECORD)
         {
            /* RTv 123FIX */
            SEQBIT = SEQBIT + " ";
            /* RT^ 123FIX */
            if (!(WRITEBLK(SEQBIT, SEQFILE)))
            {
               nrf0 = 7;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               return;
            }
         }
         SEQBIT = "";
         for (FIELD_NO = 1; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1)
         {
            L0500();
            if (TOTALFIELDS[1, FIELD_NO] == FIELD_NO)
            {
               if (COMMITRECORD == TRUE)
               {
                  TOTALFIELDS[2, FIELD_NO] = 0;
               }
               TOTALFIELDS[2, FIELD_NO] = TOTALFIELDS[2, FIELD_NO] + TRANSFIELD;
               TRANSFIELD = TOTALFIELDS[2, FIELD_NO];
            }
            else
            {
               /* MAY BE FOUND NECESSARY TO PROVE carried forward data */
               /* TRANSFIELD = "#":TRANSFIELD */
            }
            SEQBIT = SEQBIT + FORMAT(TRANSFIELD, LENSTR);
         }
         return;
      /* ***** */
      L9999: ;
         /*  THE END */
         /* ***** */
      }
   }
}
