//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL106 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar VALID_DATA = 0;
      readonly UvVar EXIT = 2;
      readonly UvVar BACKUP = 3;
      readonly UvVar INVALID_DATA = 5;
      readonly UvVar FINISH = 6;
      readonly UvVar LIMIT = 4;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar TODAYS_DATE = "";
      UvVar ERR_LINE = "";
      UvVar CLR_ERROR = "";
      UvVar VM = "";
      UvVar TRANS_LOG_REC = "";
      UvVar TX_ATT = "";
      UvVar PROGRAM = "";
      UvVar INTERACT = "";
      FL000_10 FL000_10;
      UvVar WAIT = "";
      UvVar CONTROL_OPENED = "";
      UvVar FL_CONTROL = "";
      UvVar MACHINE_FRAME_SIZE = "";
      UvVar FL_FILE_SIZES = "";
      FL006 FL006;
      UvVar SPECIAL_PASSWD = "";
      UvVar SIZE = "";
      UvVar ITEMS = "";
      UvVar AVE_ITEM_SIZE = "";
      UvVar NO_IN_FRAME = "";
      UvVar APPROX_MODULO = "";
      UvVar RECOMMENDED = "";
      UvVar START_NO = "";
      UvVar FINISH_NO = "";
      UvVar SQA = "";
      UvVar SQRT = "";
      UvVar I = "";
      UvVar RECOMMENDED_MOD = "";
      UvVar FILENAME = "";
      UvVar FILEX = "";
      UvVar FILE_TYPE = "";
      FL019 FL019;
      UvVar NEW_MODULO = "";
      UvVar SPEC_PWD = "";
      UvVar SEPARATION = "";
      UvVar RESIZE_REC = "";
      UvVar NO_OF_EXIST_FILES = "";
      UvVar INS_POS = "";
      UvVar CLOOP = "";
      FLTX2 FLTX2;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL106()
      {
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
         /*  Resize File Maintenance */
         PROGRAM = "FL106";
         nrf0 = 0;
         FL000_10 = new FL000_10(ref PROGRAM, ref nrf0);
         PRINT(AT(50, 20));
         INPUTCR(out WAIT, 1);
         CONTROL_OPENED = TRUE;
         if (!(OPEN("FL.CONTROL", out FL_CONTROL)))
         {
            PRINT(COMMON.WASH);
            PRINT("What is this machine's frame size ");
            INPUTCR(out MACHINE_FRAME_SIZE);
            CONTROL_OPENED = FALSE;
         }
         if (!(OPEN("FL.FILE.SIZES", out FL_FILE_SIZES)))
         {
            nrf0 = 1;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            return;
         }
         if (CONTROL_OPENED)
         {
            if (!(READV(ref MACHINE_FRAME_SIZE, FL_CONTROL, "FRAME.SIZE", 1)))
            {
               MACHINE_FRAME_SIZE = 512;
            }
         }
         else
         {
            MACHINE_FRAME_SIZE = 512;
         }
         if (!(READ(ref SPECIAL_PASSWD, FL_CONTROL, "SPECIALS.PASS")))
         {
            SPECIAL_PASSWD = "SYZYGY";
         }
      L10: ;
         PRINT(AT(0, 3) + COMMON.EOS);
         PRINT(AT(2, 3) + "Note - Machine Frame Size is " + MACHINE_FRAME_SIZE);
         PRINT(AT(10, 4) + "Input Size (in bytes) ");
         INPUT(out SIZE, 9);
         if (SIZE == COMMON.ABANDON)
         {
            return;
         }
         if (SIZE == "" || NOT(NUM(SIZE)))
         {
            return;
         }
         PRINT(AT(10, 6) + "Input Items ");
         INPUT(out ITEMS, 7);
         if (ITEMS == COMMON.ABANDON)
         {
            return;
         }
         if (ITEMS == "" || NOT(NUM(ITEMS)))
         {
            return;
         }
         AVE_ITEM_SIZE = INT(SIZE / ITEMS) + 1;
         NO_IN_FRAME = MACHINE_FRAME_SIZE / AVE_ITEM_SIZE;
         APPROX_MODULO = INT((ITEMS / NO_IN_FRAME) + .5M);
         RECOMMENDED = 0;
         START_NO = APPROX_MODULO - 20;
         if (START_NO < 1)
         {
            START_NO = 1;
         }
         FINISH_NO = APPROX_MODULO + 20;
         goto L20;
      L20: ;
         if (MOD(START_NO, 2) == 0)
         {
            START_NO = START_NO + 1;
         }
      L30: ;
         SQA = INT(FORMAT(SQRT, START_NO) + 1);
         for (I = 3; I <= SQA; I += 2)
         {
            if (I != 3)
            {
               if (MOD(I, 3) == 0)
               {
                  goto L40;
               }
            }
            if (I != 5)
            {
               if (MOD(I, 5) == 0)
               {
                  goto L40;
               }
            }
            if (I != 7)
            {
               if (MOD(I, 7) == 0)
               {
                  goto L40;
               }
            }
            if (START_NO / I == INT(START_NO / I))
            {
               goto L60;
            }
         L40: ;
         }
         if (START_NO > APPROX_MODULO)
         {
            if (RECOMMENDED)
            {
            }
            else
            {
               RECOMMENDED = 1;
               PRINT(AT(10, 8) + "RECOMMENDED " + START_NO);
               RECOMMENDED_MOD = START_NO;
            }
         }
         if (START_NO < FINISH_NO)
         {
            START_NO = START_NO + 2;
            goto L30;
         }
      L50: ;
         PRINT(AT(10, 10) + COMMON.EOL + AT(10, 10) + "Input File name FL.");
         INPUT(out FILENAME, 25);
         if (FILENAME == "")
         {
            goto L10;
         }
         FILENAME = "FL." + FILENAME;
         if (!(OPEN(FILENAME, out FILEX)))
         {
            PRINT(ERR_LINE + "          " + FILENAME + " does not exist, try again. ");
            INPUT(out WAIT, 1);
            PRINT(CLR_ERROR);
            goto L50;
         }
         FILE_TYPE = STATUS();
         PRINT(AT(10, 12) + "Input New Modulo " + RECOMMENDED_MOD);
         INTERACT = INVALID_DATA;
         do
         {
            if (INTERACT != INVALID_DATA) break;
            PRINT(AT(27, 12));
            nrf0 = 7;
            FL019 = new FL019(ref nrf0, ref NEW_MODULO);
            // BEGIN CASE
            // CASE
            if (NEW_MODULO == "")
            {
               NEW_MODULO = RECOMMENDED_MOD;
               INTERACT = VALID_DATA;
            }// CASE
            else if (NEW_MODULO == COMMON.ABANDON)
            {
               INTERACT = EXIT;
               return;
            }// CASE
            else if (NOT(MATCH(NEW_MODULO, "0N")))
            {
               nrf0 = 2;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            }// CASE
            else if (NEW_MODULO == RECOMMENDED_MOD)
            {
               INTERACT = VALID_DATA;
            }// CASE
            else if (OTHERWISE)
            {
               PRINT(AT(10, 20) + "Modulos Differ, Please enter Special Password ");
               ECHO_OFF();
               INPUTCR(out SPEC_PWD, 12);
               ECHO_ON();
               if (SPECIAL_PASSWD == SPEC_PWD)
               {
                  INTERACT = VALID_DATA;
               }
               else
               {
                  INTERACT = INVALID_DATA;
                  nrf0 = 3;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
            }
            // END CASE
         } while (true);
         SEPARATION = 1;
         if (!(READ(ref RESIZE_REC, FL_FILE_SIZES, "FILES.TO.CHANGE")))
         {
            RESIZE_REC = "";
         }
         NO_OF_EXIST_FILES = DCOUNT(RESIZE_REC[2], VM);
         if (NO_OF_EXIST_FILES > 0)
         {
            INS_POS = NO_OF_EXIST_FILES + 1;
            for (CLOOP = 1; CLOOP <= NO_OF_EXIST_FILES; CLOOP += 1)
            {
               if (RESIZE_REC[2, CLOOP] == FILENAME)
               {
                  INS_POS = CLOOP;
                  CLOOP = NO_OF_EXIST_FILES;
               }
            }
         }
         else
         {
            INS_POS = 1;
         }
         RESIZE_REC[2, INS_POS] = FILENAME;
         RESIZE_REC[3, INS_POS] = FILE_TYPE;
         RESIZE_REC[4, INS_POS] = NEW_MODULO;
         RESIZE_REC[5, INS_POS] = TODAYS_DATE;
         RESIZE_REC[6, INS_POS] = SEPARATION;
         RESIZE_REC[1] = DCOUNT(RESIZE_REC[2], VM);
         TRANS_LOG_REC = RESIZE_REC;
         TX_ATT = "";
         nrf0 = "W"; nrf1 = "FL.FILE.SIZES"; nrf2 = "FILES.TO.CHANGE"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
         WRITE(RESIZE_REC, FL_FILE_SIZES, "FILES.TO.CHANGE");
         PRINT(AT(10, 14) + FILENAME + " will be resized to " + NEW_MODULO + " When resize process is run ");
         INPUT(out WAIT, 1);
         goto L10;
      L60: ;
         START_NO = START_NO + 2;
         goto L30;
      }
   }
}
