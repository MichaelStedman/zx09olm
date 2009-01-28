//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL932 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar DISPLAY_WINDOW = 0;
      readonly UvVar INPUT_ALL = 1;
      readonly UvVar INPUT_SINGLE = 2;
      readonly UvVar LOAD_CODES = 3;
      readonly UvVar REDISPLAY = 4;
      readonly UvVar INSERT_SINGLE = 5;
      readonly UvVar DELETE_SINGLE = 6;
      readonly UvVar SCROLL = 7;
      readonly UvVar FL_SPORTS = 23;
      readonly UvVar SPORTS_DESC = 1;
      readonly UvVar SPORTS_BOOKING_LEEWAY = 2;
      readonly UvVar SPORTS_CODE1 = 3;
      readonly UvVar SPORTS_CODE2 = 4;
      readonly UvVar SPORTS_BOOK_AHEAD_DAYS = 5;
      readonly UvVar SPORTS_TYPE = 6;
      readonly UvVar SPORTS_BOOK_OR_CAS = 7;
      readonly UvVar SPORTS_SPECIAL_ROUTINE = 8;
      readonly UvVar SPORTS_RESTRICTION_CODE = 9;
      readonly UvVar SPORTS_PERSON_BOOKING = 10;
      readonly UvVar SPORTS_BOOK_AHEAD_CONTROL = 11;
      readonly UvVar SPORTS_SETUP_TIME = 12;
      readonly UvVar SPORTS_TAKEDOWN_TIME = 13;
      readonly UvVar SPORTS_PLAYERS = 14;
      readonly UvVar SPORTS_ADMINISTRATOR = 15;
      readonly UvVar SPORTS_CAT_OR_RESOURCE = 16;
      readonly UvVar SPORTS_VISIBILITY = 17;
      readonly UvVar SPORTS_SUB_LIST = 18;
      readonly UvVar SPORTS_TOP_LEVEL = 19;
      readonly UvVar SPORTS_DEPENDANT_RESOURCE = 20;
      readonly UvVar FL_CONTROL = 10;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] SPORTS_REC;
      UvVar[] CONTROLS_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar ACTION = "";
      UvVar PASSED_CATEGORY_ID = "";
      UvVar OLD_SUB_LIST = "";
      UvVar REDISPLAY_LINE = "";
      UvVar UV_CALL = "";
      UvVar CENTRE_CODE = "";
      UvVar ERROR_STATUS = "";
      UvVar MESSAGE = "";
      UvVar MACHINE_TYPE = "";
      UvVar VM = "";
      UvVar TRANS_LOG_REC = "";
      UvVar FILES_OPEN = "";
      UvVar FL_CATEGORY_LEVELS = "";
      UvVar LOCAL_MASTER_CENTRES = "";
      UvVar LOCAL_MD = "";
      UvVar THIS_CENTRE_CODE = "";
      UvVar MASTER_CENTRE_REC = "";
      UvVar CENTRE_DESCRIPTION = "";
      UvVar ACCOUNT_NAME = "";
      UvVar WEB_BOOKABLE = "";
      UvVar CATEGORY_LEVELS_FILE = "";
      UvVar POINTER_REC = "";
      UvVar PROGRAM = "";
      UvVar PROCESS_EXECUTE = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar RTN_MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      UvVar EOF = "";
      UvVar THIS_CAT_ID = "";
      FLTX2 FLTX2;
      UvVar CAT_LEVEL_REC = "";
      UvVar UPDATE_REQUIRED = "";
      UvVar DEL_POS = "";
      UvVar TEST_REC = "";
      UvVar MVC = "";
      UvVar CR_IND = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL932(ref UvVar ACTION, ref UvVar PASSED_CATEGORY_ID, ref UvVar[] SPORTS_REC, ref UvVar OLD_SUB_LIST, ref UvVar REDISPLAY_LINE, ref UvVar UV_CALL, ref UvVar CENTRE_CODE, ref UvVar ERROR_STATUS, ref UvVar MESSAGE)
      {
         this.ACTION = ACTION;
         this.PASSED_CATEGORY_ID = PASSED_CATEGORY_ID;
         this.SPORTS_REC = SPORTS_REC;
         this.OLD_SUB_LIST = OLD_SUB_LIST;
         this.REDISPLAY_LINE = REDISPLAY_LINE;
         this.UV_CALL = UV_CALL;
         this.CENTRE_CODE = CENTRE_CODE;
         this.ERROR_STATUS = ERROR_STATUS;
         this.MESSAGE = MESSAGE;
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
         /*  (RE)BUILD CONTROL HIERARCHY OF CATEGORIES, SUB-CATEGORIES & RESOURCES */
         #region INCLUDE FL.FILES FL.SPORTS
         #region INCLUDE FL.FILES FL.SPORTS.EQU

         #endregion

         #region INCLUDE FL.FILES FL.SPORTS.DIM

         #endregion
         #region INCLUDE FL.FILES FL.SPORTS.VAR

         /*  Introduced for Warrington: */

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         FILES_OPEN = "";
         if (UV_CALL)
         {
            #region INCLUDE FL.FILES FL.CATEGORY.LEVELS.EQU
            if (!OPEN("FL.CATEGORY.LEVELS", out FL_CATEGORY_LEVELS)) { STOP("201", "FL.CATEGORY.LEVELS"); }

            #endregion
         }
         else
         {
            if (OPEN("FL.MASTER.CENTRES", out LOCAL_MASTER_CENTRES)) { FILES_OPEN[1] = TRUE; } else { ERROR_STATUS = 2044; MESSAGE = "Unable to access master centres file"; }
            if (OPEN("MD", out LOCAL_MD)) { FILES_OPEN[2] = TRUE; } else { ERROR_STATUS = 2043; MESSAGE = "Unable to open master dictionary"; }
            THIS_CENTRE_CODE = CENTRE_CODE;
            if (!READ(ref MASTER_CENTRE_REC, LOCAL_MASTER_CENTRES, THIS_CENTRE_CODE)) { MASTER_CENTRE_REC = ""; }
            CENTRE_DESCRIPTION = MASTER_CENTRE_REC[1];
            ACCOUNT_NAME = MASTER_CENTRE_REC[2];
            WEB_BOOKABLE = MASTER_CENTRE_REC[14];
            CATEGORY_LEVELS_FILE = "FWQ." + THIS_CENTRE_CODE + ".CATEGORY.LEVELS";
            if (OPEN(CATEGORY_LEVELS_FILE, out FL_CATEGORY_LEVELS))
            {
               FILES_OPEN[5] = TRUE;
            }
            else
            {
               POINTER_REC = "Q";
               POINTER_REC[2] = ACCOUNT_NAME;
               POINTER_REC[3] = "FL.CATEGORY.LEVELS";
               WRITE(POINTER_REC, LOCAL_MD, CATEGORY_LEVELS_FILE);
               if (OPEN(CATEGORY_LEVELS_FILE, out FL_CATEGORY_LEVELS)) { FILES_OPEN[5] = TRUE; } else { ERROR_STATUS = 2046; MESSAGE = PROGRAM + ": Unable to access category levels file"; }
            }
         }
         PROGRAM = "FL932";
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         REDISPLAY_LINE = "";
         // BEGIN CASE
         // CASE
         if (ACTION == DELETE_SINGLE)
         {
            L0100();
         }// CASE
         else if (ACTION == INPUT_SINGLE)
         {
            L0200();
         }
         // END CASE
         if (NOT(UV_CALL))
         {
            if (FILES_OPEN[1] == TRUE)
            {
               CLOSE(LOCAL_MASTER_CENTRES);
            }
            if (FILES_OPEN[2] == TRUE)
            {
               CLOSE(LOCAL_MD);
            }
            if (FILES_OPEN[5] == TRUE)
            {
               CLOSE(FL_CATEGORY_LEVELS);
            }
         }
         /*  Return to calling program */
         return;
         /* ********************************* */
      }
      void L0100()
      {
         /*  Delete a category */
         /* ********************************* */
         if (UV_CALL)
         {
            INSTRUCTION = "SELECT FL.CATEGORY.LEVELS";
         }
         else
         {
            INSTRUCTION = "SELECT FWQ." + CENTRE_CODE + ".CATEGORY.LEVELS";
         }
         nrf0 = "SO";
         CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref RTN_MESSAGE, ref ERRORS);
         EOF = FALSE;
         do
         {
            if (!READNEXT(ref THIS_CAT_ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
            if (EOF) break;
            if (THIS_CAT_ID == PASSED_CATEGORY_ID)
            {
               DELETE(FL_CATEGORY_LEVELS, PASSED_CATEGORY_ID);
               if (UV_CALL)
               {
                  nrf0 = "D";
                  nrf1 = "FL.CATEGORY.LEVELS";
                  FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PASSED_CATEGORY_ID);
               }
            }
            else
            {
               if (READU(ref CAT_LEVEL_REC, FL_CATEGORY_LEVELS, THIS_CAT_ID))
               {
                  UPDATE_REQUIRED = FALSE;
                  /*  Remove any references to the deleted category from */
                  /*  this record */
                  if (LOCATE(PASSED_CATEGORY_ID, CAT_LEVEL_REC, 1, 0, 1, ref DEL_POS, "AL"))
                  {
                     UPDATE_REQUIRED = TRUE;
                     CAT_LEVEL_REC = DELETE(CAT_LEVEL_REC, 1, DEL_POS, 0);
                     CAT_LEVEL_REC = DELETE(CAT_LEVEL_REC, 2, DEL_POS, 0);
                     if (UPDATE_REQUIRED)
                     {
                        if (CAT_LEVEL_REC[1, 1] == "")
                        {
                           /*  Empty record */
                           DELETE(FL_CATEGORY_LEVELS, THIS_CAT_ID);
                           if (UV_CALL)
                           {
                              nrf0 = "D";
                              nrf1 = "FL.CATEGORY.LEVELS";
                              FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref THIS_CAT_ID);
                           }
                        }
                        else
                        {
                           WRITE(CAT_LEVEL_REC, FL_CATEGORY_LEVELS, THIS_CAT_ID);
                           if (UV_CALL)
                           {
                              TRANS_LOG_REC = CAT_LEVEL_REC;
                              nrf0 = "W";
                              nrf1 = "FL.CATEGORY.LEVELS";
                              FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref THIS_CAT_ID);
                           }
                        }
                     }
                     else
                     {
                        RELEASE();
                     }
                  }
               }
               else
               {
                  RELEASE();
               }
            }
         } while (true);
         return;
         /* *********************************** */
      }
      void L0200()
      {
         /*  Insert/update category */
         /* *********************************** */
         if (SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "") { SPORTS_REC[SPORTS_CAT_OR_RESOURCE] = "R"; }
         /*  DJA 23.12.05 */
         if (SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "R" && SPORTS_REC[SPORTS_DEPENDANT_RESOURCE] != "N")
         {
            if (READ(ref TEST_REC, FL_CATEGORY_LEVELS, PASSED_CATEGORY_ID))
            {
               /*  Change from category to resource */
               DELETE(FL_CATEGORY_LEVELS, PASSED_CATEGORY_ID);
               if (UV_CALL)
               {
                  nrf0 = "D";
                  nrf1 = "FL.CATEGORY.LEVELS";
                  FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref PASSED_CATEGORY_ID);
               }
            }
         }
         else
         {
            /*  Create or update the 'master' record for the passed category.id */
            if (!READU(ref CAT_LEVEL_REC, FL_CATEGORY_LEVELS, PASSED_CATEGORY_ID)) { CAT_LEVEL_REC = ""; }
            CAT_LEVEL_REC[1] = SPORTS_REC[SPORTS_SUB_LIST];
            if (CAT_LEVEL_REC[1, 1] == "")
            {
               /*  Empty record */
               DELETE(FL_CATEGORY_LEVELS, PASSED_CATEGORY_ID);
               if (UV_CALL)
               {
                  nrf0 = "D";
                  nrf1 = "FL.CATEGORY.LEVELS";
                  FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref THIS_CAT_ID);
               }
            }
            else
            {
               CAT_LEVEL_REC[3] = SPORTS_REC[SPORTS_TOP_LEVEL];
               if (CAT_LEVEL_REC[3] == "") { CAT_LEVEL_REC[3] = "N"; }
               CAT_LEVEL_REC[2] = "";
               for (MVC = 1; MVC <= DCOUNT(SPORTS_REC[SPORTS_SUB_LIST], VM); MVC += 1)
               {
                  if (!READV(ref CR_IND, COMMON.FILES[FL_SPORTS], SPORTS_REC[SPORTS_SUB_LIST][1, MVC], 16)) { CR_IND = "R"; }
                  CAT_LEVEL_REC[2, MVC] = CR_IND;
               }
               WRITE(CAT_LEVEL_REC, FL_CATEGORY_LEVELS, PASSED_CATEGORY_ID);
            }
         }
         /*      PROCESS CHANGE OF CATEGORY/RESOURCE */
         if (UV_CALL)
         {
            INSTRUCTION = "SELECT FL.CATEGORY.LEVELS WITH 1 = \"" + PASSED_CATEGORY_ID + "\"";
         }
         else
         {
            INSTRUCTION = "SELECT FWQ." + CENTRE_CODE + ".CATEGORY.LEVELS WITH 1 = \"" + PASSED_CATEGORY_ID + "\"";
         }
         nrf0 = "SO";
         CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref RTN_MESSAGE, ref ERRORS);
         EOF = FALSE;
         do
         {
            if (!READNEXT(ref THIS_CAT_ID, 0, 0, RTN_LIST)) { EOF = TRUE; }
            if (EOF) break;
            if (THIS_CAT_ID == PASSED_CATEGORY_ID)
            {
               NULL();
               /*  Already dealt with above */
            }
            else
            {
               if (READU(ref CAT_LEVEL_REC, FL_CATEGORY_LEVELS, THIS_CAT_ID))
               {
                  /*  Check C/R indicator for PASSED.CATEGORY.ID */
                  if (LOCATE(PASSED_CATEGORY_ID, CAT_LEVEL_REC, 1, 0, 1, ref MVC, "AL"))
                  {
                     if (CAT_LEVEL_REC[2, MVC] != SPORTS_REC[SPORTS_CAT_OR_RESOURCE])
                     {
                        CAT_LEVEL_REC[2, MVC] = SPORTS_REC[SPORTS_CAT_OR_RESOURCE];
                        WRITE(CAT_LEVEL_REC, FL_CATEGORY_LEVELS, THIS_CAT_ID);
                        if (UV_CALL)
                        {
                           TRANS_LOG_REC = CAT_LEVEL_REC;
                           nrf0 = "W";
                           nrf1 = "FL.CATEGORY.LEVELS";
                           FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref THIS_CAT_ID);
                        }
                     }
                  }
               }
               RELEASE();
            }
         } while (true);
         /*  TRAP RECURSION PROBLEMS HERE */
         /*  Very difficult to code, and it's not important: */
         /*   1) When user is browsing hierarchically it won't */
         /*      hang; they just won't reach the bottom of the */
         /*      structure, ever(!) */
         /*   2) When running a search across a category we will */
         /*      just deduce a list of candidate resource ids. */
         /*      Just make sure this code doesn't loop when it */
         /*      comes across a particular code for the second */
         /*      time */
         /*  Select top level categories and work down */
         /* !!     INSTRUCTION = 'SELECT FL.CATEGORY.LEVELS WITH 3 = "Y"' */
         /* !!     CALL @PROCESS.EXECUTE(INSTRUCTION,"SO",RTN.LIST,LIST.AVAILABLE,RTN.MESSAGE,ERRORS) */
         /* !!     EOF = FALSE */
         /* !!     LOOP */
         /* !!        READNEXT TOP.CAT.ID FROM RTN.LIST ELSE EOF = TRUE */
         /* !!        UNTIL EOF DO */
         /* !!* */
         /* !!* */
         /* !!              TOP.MVC = TOP.MVC + 1 */
         /* !!           REPEAT */
         /* !!* */
         /* !!        END */
         /* !!* */
         /* !!* Next top level category */
         /* !!* */
         /* !!     REPEAT */
         return;
         /*  End of program */
      }
   }
}
