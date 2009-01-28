//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL555_PHANTOM : UvBase
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
      UvVar PROGRAM = "";
      UvVar FL_UNIVERSE_TRANSFER = "";
      UvVar TRANSFER_FILE = "";
      UvVar NORECS = "";
      UvVar SEQFILE = "";
      FL006 FL006;
      UvVar FILES_NOT_OPEN = "";
      UvVar CONVDELIM = "";
      UvVar TRANSREC = "";
      UvVar REALHEADER = "";
      UvVar NO_OF_FIELDS = "";
      UvVar FIELD_NO = "";
      UvVar EOF = "";
      UvVar KEY = "";
      UvVar MEMREC = "";
      UvVar TRANSMVCNT = "";
      UvVar ALLMVSDONE = "";
      UvVar SEQBIT = "";
      UvVar LENSTR = "";
      UvVar OUTPUTCONV = "";
      UvVar TRANSFIELD = "";
      UvVar TRANSMV = "";
      UvVar CLOOP = "";
      UvVar THISOCONV = "";
      UvVar EXTSUB = "";
      CallAt_EXTSUB CallAt_EXTSUB;
      UvVar WEOFSEQ = "";
      UvVar FLEFIELD_NO = "";
      UvVar TRANS_RECID = "";
      UvVar TRANSID = "";
      UvVar THISFIELD = "";
      UvVar TRANSLINE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL555_PHANTOM(ref UvVar TRANSFER_FILE_NAME, ref UvVar TRANSFER_PARAM_NAME, ref UvVar TRANSFER_DIRECTORY, ref UvVar TRANSFER_OUTFILE, ref UvVar TRANSLIST, ref UvVar LIST_AVAILABLE, ref UvVar SUCCESSFUL)
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
         /*  TEXT FILE TRANSFER */
         PROGRAM = "FL555.PHANTOM";
         SUCCESSFUL = TRUE;
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
         if (!OPEN(TRANSFER_FILE_NAME, out TRANSFER_FILE)) { STOP(201, "INVALID TRANSFER FILE"); }
         if (TRANSFER_OUTFILE == "") { TRANSFER_OUTFILE = "MEMFILE.CSV"; }
         else
         {
            TRANSFER_OUTFILE = TRANSFER_OUTFILE + ".CSV";
         }
         NORECS = 0;
         TRANSFER_OUTFILE = TRANSFER_DIRECTORY + TRANSFER_OUTFILE;
         if (!(OPENSEQ(TRANSFER_OUTFILE, out SEQFILE)))
         {
            CREATE(SEQFILE);
            nrf0 = 4;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }

         /*  RT MOVED TO ABOVE     OPEN TRANSFER.FILE.NAME TO TRANSFER.FILE ELSE STOP 201,"INVALID TRANSFER FILE" */
         /* **** */
         /*  SET UP VARIABLES */
         /* **** */
         FILES_NOT_OPEN = TRUE;
         CONVDELIM = "~";
         /* ** */
         /*  GET HEADER DETAILS */
         /* ** */
         /* ** */
         /*  FORMAT DATABASE FIELDS */
         /* * */
         if (!READ(ref TRANSREC, FL_UNIVERSE_TRANSFER, "FILE*" + TRANSFER_PARAM_NAME)) { STOP(201); }
         REALHEADER = "\"" + TRANSREC[1, 1] + "\"";
         NO_OF_FIELDS = DCOUNT(TRANSREC, AM);
         for (FIELD_NO = 2; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1)
         {
            REALHEADER = REALHEADER + ",\"" + TRANSREC[FIELD_NO, 1] + "\"";
         }
         /* ** */
         /*  CREATE DATA PORTION */
         /* ** */
         /* DJA 29.10.99*  WRITESEQ REALHEADER ON SEQFILE ELSE STOP 201, "CANNOT WRITE HEADER ON SEQFILE" */
         if (WRITESEQ(REALHEADER, SEQFILE))
         {
            EOF = 0;
            do
            {
               if (!READNEXT(ref KEY, 0, 0, TRANSLIST)) { EOF = 1; }
               if (EOF) break;
               NORECS = NORECS + 1;
               /*         IF MOD(NORECS,100) = 0 THEN PRINT ".": */
               if (!(READ(ref MEMREC, TRANSFER_FILE, KEY)))
               {
                  nrf0 = 1;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref KEY);
                  return;
               }
               TRANSMVCNT = 1;
               do
               {
                  ALLMVSDONE = TRUE;
                  SEQBIT = "";
                  for (FIELD_NO = 1; FIELD_NO <= NO_OF_FIELDS; FIELD_NO += 1)
                  {
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
                     if (INDEX(TRANSFIELD, ",", 1))
                     {
                        TRANSFIELD = CHANGE(TRANSFIELD, ",");
                     }
                     if (INDEX(TRANSFIELD, "\"", 1))
                     {
                        TRANSFIELD = CHANGE(TRANSFIELD, "\"");
                     }
                     if (FIELD_NO == 1)
                     {
                        SEQBIT = "\"" + TRANSFIELD + "\"";
                     }
                     else
                     {
                        SEQBIT = SEQBIT + ",\"" + TRANSFIELD + "\"";
                     }
                  }
                  FILES_NOT_OPEN = FALSE;
                  if (!WRITESEQ(SEQBIT, SEQFILE)) { STOP(201, "CANNOT WRITE TO "); }
                  if (ALLMVSDONE) break;
                  TRANSMVCNT = TRANSMVCNT + 1;
               } while (true);
            } while (true);
            WEOFSEQ(SEQFILE);
            /*      FOR FIELD.NO = 1 TO NO.OF.FIELDS */
            /*  DJA 29.10.99 */
         }
         else
         {
            nrf0 = 5;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            SUCCESSFUL = FALSE;
         }
         CLOSESEQ(SEQFILE);
         /* !*PRINT @(10,20):'Process complete ': ;INPUT FLEX,1: */
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
         /* ***** */
         L9999: ;
            /*  THE END */
            /* ***** */
         }
      }
   }
}
