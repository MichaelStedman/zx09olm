//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL920 : UvBase
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
      readonly UvVar COPY = 1;
      readonly UvVar DUPLICATE = 2;
      readonly UvVar GET = 3;
      readonly UvVar PUT = 4;
      readonly UvVar FLUSH = 6;
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
      readonly UvVar FL_TICKET_CONTROL = 19;
      readonly UvVar FL_FINANCE_DESCRIPTIONS = 103;
      readonly UvVar FIN_DESCRIPTION = 1;
      readonly UvVar FIN_DAY_TARGET = 2;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] SPORTS_REC = new UvVar[25];
      UvVar[] TICK_CONTROL_REC = new UvVar[20];
      UvVar[] FIN_DESC_REC = new UvVar[3];
      #endregion
      #region Variables
      UvVar SCREEN_FOOT_BACK = "";
      UvVar SCREEN_FOOT_FORE = "";
      UvVar PROG_MESS = "";
      UvVar VM = "";
      UvVar TRANS_LOG_REC = "";
      UvVar TX_ATT = "";
      UvVar INTERACT = "";
      UvVar PROGRAM = "";
      UvVar SCREEN_CODE = "";
      UvVar FIRST_FATAL_ERROR = "";
      UvVar OLD_PAGE_NO = "";
      UvVar NEW_RESOURCE = "";
      UvVar PAGE_NO = "";
      FL921 FL921;
      FL922 FL922;
      FL923 FL923;
      FL006 FL006;
      UvVar RESOURCE_CODE = "";
      UvVar OLD_SUB_LIST = "";
      UvVar NO_SUBS = "";
      UvVar THIS_SUB_MVC = "";
      UvVar TEST_DEPENDANT_RESOURCE = "";
      UvVar TEST_CAT_OR_RESOURCE = "";
      FLTX2 FLTX2;
      UvVar TEXT_ID = "";
      UvVar FINDESC_ID_BKG = "";
      UvVar FINDESC_ID_BB = "";
      UvVar TEST_REC = "";
      UvVar STATUS_LINE = "";
      UvVar ACTION = "";
      UvVar UV_CALL = "";
      FL932 FL932;
      UvVar REDISPLAY_LINE = "";
      UvVar CENTRE_CODE = "";
      UvVar ERROR_STATUS = "";
      UvVar MESSAGE = "";
      UvVar CATEGORIES_ONLY = "";
      FWCATEGORYTREE FWCATEGORYTREE;
      UvVar MODE = "";
      UvVar TREE_ARRAY = "";
      UvVar SPARE2 = "";
      UvVar SPARE3 = "";
      UvVar SPARE4 = "";
      UvVar SPARE5 = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL920()
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
         /*     CONTROLLING ROUTINE FOR RESOURCE & CATEGORY MAINTENANCE */
         PROMPT("");
         PROGRAM = "FL920";
         SCREEN_CODE = PROGRAM;
         INTERACT = "";
         FIRST_FATAL_ERROR = 1000;
         /* ******************************** */
         /*   DEFINE FILES USED            * */
         /* ******************************** */
         #region INCLUDE FL.FILES FL.SPORTS
         #region INCLUDE FL.FILES FL.SPORTS.EQU

         #endregion

         #region INCLUDE FL.FILES FL.SPORTS.DIM

         #endregion
         #region INCLUDE FL.FILES FL.SPORTS.VAR

         /*  Introduced for Warrington: */

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.TICKET.CONTROL

         #endregion
         #region INCLUDE FL.FILES FL.FINANCE.DESCRIPTIONS

         #endregion
         /* ******************************** */
         /*   DEFINE STANDARD VARIABLES    * */
         /* ******************************** */
         /*  Prog.mess<1> holds the page no.  If it is null this indicates */
         /*  'finish' (i.e. update files).  It can also contain the 'abandon' */
         /*  character */
         /* !     DIM TEMP.REC(50) */
         /* ******************************* */
         /*   MAIN PROCESSING SECTION     * */
         /* ******************************* */
         OLD_PAGE_NO = 1;
         NEW_RESOURCE = FALSE;
         do
         {
            /* !        MAT TEMP.REC = '' */
            MAT(ref TICK_CONTROL_REC, "");
            MAT(ref SPORTS_REC, "");
            PROG_MESS = 1;
            do
            {
               if (PROG_MESS[1] == "" || PROG_MESS[1] == COMMON.ABANDON) break;
               PAGE_NO = PROG_MESS[1];
               // BEGIN CASE
               // CASE
               if (PAGE_NO == 1)
               {
                  FL921 = new FL921(ref SPORTS_REC, ref NEW_RESOURCE, ref TICK_CONTROL_REC);
               }// CASE
               else if (PAGE_NO == 2)
               {
                  /*  Subsidiaries */
                  FL922 = new FL922(ref SPORTS_REC, ref NEW_RESOURCE, ref TICK_CONTROL_REC);
               }// CASE
               else if (PAGE_NO == 3)
               {
                  /*  Ticket Text and fields of no interest on web */
                  FL923 = new FL923(ref SPORTS_REC, ref NEW_RESOURCE, ref TICK_CONTROL_REC);
               }// CASE
               else if (OTHERWISE)
               {
                  nrf0 = 1;
                  nrf1 = INIT;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  PROG_MESS[1] = OLD_PAGE_NO;
               }
               // END CASE
               OLD_PAGE_NO = PAGE_NO;
            } while (true);
            if (PROG_MESS[1] == "" && PROG_MESS[2] != "")
            {
               /*  Apply File Updates */
               RESOURCE_CODE = PROG_MESS[2];
               if (!READV(ref OLD_SUB_LIST, COMMON.FILES[FL_SPORTS], RESOURCE_CODE, 18)) { OLD_SUB_LIST = ""; }
               /*  DJA 23.12.05 No codes can be nested below a dependant */
               if (SPORTS_REC[SPORTS_DEPENDANT_RESOURCE] != "N")
               {
                  SPORTS_REC[SPORTS_SUB_LIST] = "";
               }
               /*  ...and no dependant codes can be nested below a category */
               /*     (they must be the dependants of a parent Resource) */
               if (SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "C")
               {
                  NO_SUBS = DCOUNT(SPORTS_REC[SPORTS_SUB_LIST][1], VM);
                  THIS_SUB_MVC = 1;
                  do
                  {
                     if (THIS_SUB_MVC > NO_SUBS) break;
                     if (!READV(ref TEST_DEPENDANT_RESOURCE, COMMON.FILES[FL_SPORTS], SPORTS_REC[SPORTS_SUB_LIST][1, THIS_SUB_MVC], 20)) { TEST_DEPENDANT_RESOURCE = ""; }
                     if (TEST_DEPENDANT_RESOURCE == "Y")
                     {
                        SPORTS_REC[SPORTS_SUB_LIST] = DELETE(SPORTS_REC[SPORTS_SUB_LIST][1], 1, THIS_SUB_MVC, 0);
                        NO_SUBS = NO_SUBS - 1;
                     }
                     else
                     {
                        THIS_SUB_MVC = THIS_SUB_MVC + 1;
                     }
                  } while (true);
               }
               /*  ...and multiple resource nesting is not permitted. A non-dep */
               /*     resource can have deps beneath it. But non-deps cannot be */
               /*     nested */
               if (SPORTS_REC[SPORTS_CAT_OR_RESOURCE] == "R")
               {
                  NO_SUBS = DCOUNT(SPORTS_REC[SPORTS_SUB_LIST][1], VM);
                  THIS_SUB_MVC = 1;
                  do
                  {
                     if (THIS_SUB_MVC > NO_SUBS) break;
                     if (!READV(ref TEST_DEPENDANT_RESOURCE, COMMON.FILES[FL_SPORTS], SPORTS_REC[SPORTS_SUB_LIST][1, THIS_SUB_MVC], 20)) { TEST_DEPENDANT_RESOURCE = ""; }
                     if (!READV(ref TEST_CAT_OR_RESOURCE, COMMON.FILES[FL_SPORTS], SPORTS_REC[SPORTS_SUB_LIST][1, THIS_SUB_MVC], 16)) { TEST_CAT_OR_RESOURCE = "R"; }
                     if (TEST_DEPENDANT_RESOURCE != "Y" || TEST_CAT_OR_RESOURCE == "C")
                     {
                        /*  We've found a non-dep nested below a parent resource */
                        SPORTS_REC[SPORTS_SUB_LIST] = DELETE(SPORTS_REC[SPORTS_SUB_LIST][1], 1, THIS_SUB_MVC, 0);
                        NO_SUBS = NO_SUBS - 1;
                     }
                     else
                     {
                        THIS_SUB_MVC = THIS_SUB_MVC + 1;
                     }
                  } while (true);
               }
               MATWRITE(SPORTS_REC, COMMON.FILES[FL_SPORTS], RESOURCE_CODE);
               if (!READ(ref TRANS_LOG_REC, COMMON.FILES[FL_SPORTS], RESOURCE_CODE)) { TRANS_LOG_REC = ""; }
               nrf0 = "W";
               nrf1 = "FL.SPORTS";
               FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref RESOURCE_CODE);
               TEXT_ID = "B*" + RESOURCE_CODE + ".TEXT";
               MATWRITE(TICK_CONTROL_REC, COMMON.FILES[FL_TICKET_CONTROL], TEXT_ID);
               if (!READ(ref TRANS_LOG_REC, COMMON.FILES[FL_TICKET_CONTROL], TEXT_ID)) { TRANS_LOG_REC = ""; }
               nrf0 = "W";
               nrf1 = "FL.TICKET.CONTROL";
               FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref TEXT_ID);
               FINDESC_ID_BKG = "2*" + RESOURCE_CODE;
               FINDESC_ID_BB = "4*" + RESOURCE_CODE;
               if (!(READ(ref TEST_REC, COMMON.FILES[FL_FINANCE_DESCRIPTIONS], FINDESC_ID_BKG)))
               {
                  WRITEV(SPORTS_REC[SPORTS_DESC], COMMON.FILES[FL_FINANCE_DESCRIPTIONS], FINDESC_ID_BKG, 1);
                  TRANS_LOG_REC = SPORTS_REC[SPORTS_DESC];
                  TX_ATT = 1;
                  nrf0 = "WV"; nrf1 = "FL.FINANCE.DESCRIPTIONS"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref FINDESC_ID_BKG);
               }
               WRITEV(SPORTS_REC[SPORTS_DESC], COMMON.FILES[FL_FINANCE_DESCRIPTIONS], FINDESC_ID_BB, 1);
               TRANS_LOG_REC = SPORTS_REC[SPORTS_DESC];
               TX_ATT = 1;
               nrf0 = "WV"; nrf1 = "FL.FINANCE.DESCRIPTIONS"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref FINDESC_ID_BB);
               /*  Rebuild category/sub-category/resource control hierarchy */
               STATUS_LINE = "   Re-calculating category hierarchy...";
               PRINT(AT(0, 21) + SCREEN_FOOT_BACK + SCREEN_FOOT_FORE);
               PRINT(AT(2, 21) + SPACE(70));
               PRINT(AT(2, 21) + STATUS_LINE);
               ACTION = INPUT_SINGLE;
               UV_CALL = TRUE;
               FL932 = new FL932(ref ACTION, ref RESOURCE_CODE, ref SPORTS_REC, ref OLD_SUB_LIST, ref REDISPLAY_LINE, ref UV_CALL, ref CENTRE_CODE, ref ERROR_STATUS, ref MESSAGE);
               /*  Double-check that user hasn't created a structure which includes */
               /*  invalid category recursion */
               CATEGORIES_ONLY = FALSE;
               FWCATEGORYTREE = new FWCATEGORYTREE(ref ERROR_STATUS, ref MESSAGE, ref MODE, ref TREE_ARRAY, ref CATEGORIES_ONLY, ref SPARE2, ref SPARE3, ref SPARE4, ref SPARE5);
               if (ERROR_STATUS >= FIRST_FATAL_ERROR)
               {
                  nrf0 = 1;
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref MESSAGE);
               }
               PRINT(AT(2, 21) + SPACE(70));
            }
            RELEASE();
            if (!(PROG_MESS[2] != "")) break;
         } while (true);
         return;
      }
   }
}
