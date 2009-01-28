//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FWCATEGORYTREE : UvBase
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
      readonly UvVar LIMIT = 4;
      readonly UvVar INVALID_DATA = 5;
      readonly UvVar FINISH = 6;
      readonly UvVar FIRST_FATAL_ERROR = 1000;
      readonly UvVar INTERNET = 0;
      readonly UvVar WAP = 1;
      readonly UvVar STAFF = 2;
      readonly UvVar LOCAL_CONTROL = 10;
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
      readonly UvVar CAT_LEVEL_SUB_LIST = 1;
      readonly UvVar CAT_LEVEL_CAT_OR_RESOURCE_LIST = 2;
      readonly UvVar CAT_LEVEL_TOP_LEVEL = 3;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] SPORTS_REC = new UvVar[25];
      UvVar[] CAT_LEVEL_REC = new UvVar[5];
      #endregion
      #region Variables
      UvVar ERROR_STATUS = "";
      UvVar MESSAGE = "";
      UvVar MODE = "";
      UvVar TREE_ARRAY = "";
      UvVar CATEGORIES_ONLY = "";
      UvVar SPARE2 = "";
      UvVar SPARE3 = "";
      UvVar SPARE4 = "";
      UvVar SPARE5 = "";
      UvVar MACHINE_TYPE = "";
      UvVar VM = "";
      FW001 FW001;
      UvVar PROGRAM = "";
      UvVar FILES_OPEN = "";
      UvVar LOCAL_MASTER_CENTRES = "";
      UvVar LOCAL_MD = "";
      UvVar PROCESS_EXECUTE = "";
      UvVar TREE_MVC = "";
      UvVar EOF = "";
      UvVar THIS_CENTRE_CODE = "";
      UvVar MASTER_CENTRE_REC = "";
      UvVar CENTRE_DESCRIPTION = "";
      UvVar ACCOUNT_NAME = "";
      UvVar WEB_BOOKABLE = "";
      UvVar CATEGORY_LIST = "";
      UvVar LEVEL_LIST = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar SELMESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      UvVar TLC_EOF = "";
      UvVar PARENT_CATEGORY = "";
      UvVar FL_SPORTS = "";
      UvVar FL_CATEGORY_LEVELS = "";
      UvVar NO_MVS = "";
      UvVar CODE_POS = "";
      UvVar THIS_CODE = "";
      UvVar THIS_TYPE = "";
      UvVar TEST_POS = "";
      UvVar PARENT_POS = "";
      UvVar CHILD_SUB_REC = "";
      UvVar NO_CHILD_CODES = "";
      UvVar CHILD_MVC = "";
      UvVar CHILD_CODE = "";
      UvVar CHILD_TYPE = "";
      UvVar CATEGORY_LEVELS_FILE = "";
      UvVar POINTER_REC = "";
      UvVar SPORTS_FILE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FWCATEGORYTREE(ref UvVar ERROR_STATUS, ref UvVar MESSAGE, ref UvVar MODE, ref UvVar TREE_ARRAY, ref UvVar CATEGORIES_ONLY, ref UvVar SPARE2, ref UvVar SPARE3, ref UvVar SPARE4, ref UvVar SPARE5)
      {
         this.ERROR_STATUS = ERROR_STATUS;
         this.MESSAGE = MESSAGE;
         this.MODE = MODE;
         this.TREE_ARRAY = TREE_ARRAY;
         this.CATEGORIES_ONLY = CATEGORIES_ONLY;
         this.SPARE2 = SPARE2;
         this.SPARE3 = SPARE3;
         this.SPARE4 = SPARE4;
         this.SPARE5 = SPARE5;
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
         FW001 = new FW001(ref ERROR_STATUS, ref MESSAGE);
         PROGRAM = "FWCATEGORYTREE";
         FILES_OPEN = "";
         if (OPEN("FL.MASTER.CENTRES", out LOCAL_MASTER_CENTRES)) { FILES_OPEN[1] = TRUE; } else { ERROR_STATUS = 2044; MESSAGE = "Unable to access master centres file"; }
         if (OPEN("MD", out LOCAL_MD)) { FILES_OPEN[2] = TRUE; } else { ERROR_STATUS = 2043; MESSAGE = "Unable to open master dictionary"; }
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         #region INCLUDE FL.FILES FL.SPORTS.DIM

         #endregion
         #region INCLUDE FL.FILES FL.SPORTS.VAR

         /*  Introduced for Warrington: */

         #endregion
         #region INCLUDE FL.FILES FL.CATEGORY.LEVELS.DIM

         #endregion
         #region INCLUDE FL.FILES FL.CATEGORY.LEVELS.VAR

         #endregion
         /*  Initialise variables */
         ERROR_STATUS = 0;
         MESSAGE = "";
         FILES_OPEN = "";
         TREE_ARRAY = "";
         TREE_MVC = 0;
         if (ERROR_STATUS < FIRST_FATAL_ERROR)
         {
            EOF = FALSE;
            SELECT(LOCAL_MASTER_CENTRES);
            do
            {
               if (!READNEXT(ref THIS_CENTRE_CODE, 0, 0, "")) { EOF = TRUE; }
               if (EOF || ERROR_STATUS >= FIRST_FATAL_ERROR) break;
               if (!READ(ref MASTER_CENTRE_REC, LOCAL_MASTER_CENTRES, THIS_CENTRE_CODE)) { MASTER_CENTRE_REC = ""; }
               CENTRE_DESCRIPTION = MASTER_CENTRE_REC[1];
               ACCOUNT_NAME = MASTER_CENTRE_REC[2];
               WEB_BOOKABLE = MASTER_CENTRE_REC[14];
               if (WEB_BOOKABLE == "Y" && ACCOUNT_NAME != "")
               {
                  L0500();
                  /*  Open files */
                  if (ERROR_STATUS < FIRST_FATAL_ERROR)
                  {
                     TREE_MVC = TREE_MVC + 1;
                     TREE_ARRAY[1, TREE_MVC] = CENTRE_DESCRIPTION;
                     TREE_ARRAY[2, TREE_MVC] = TREE_ARRAY[1, TREE_MVC];
                     TREE_ARRAY[3, TREE_MVC] = 0;
                     /*  Centre (root) */
                     TREE_ARRAY[4, TREE_MVC] = 1;
                     /*  Default to open */
                     TREE_ARRAY[5, TREE_MVC] = THIS_CENTRE_CODE;
                     TREE_ARRAY[6, TREE_MVC] = 0;
                     /*  Centre Icon */
                     L0100();
                     /*  Main processing */
                  }
               }
               L0600();
               /*  Close files */
            } while (true);
         }
         if (FILES_OPEN[1] == TRUE)
         {
            CLOSE(LOCAL_MASTER_CENTRES);
         }
         if (FILES_OPEN[2] == TRUE)
         {
            CLOSE(LOCAL_MD);
         }
         /*  Return to calling program */
         return;
         /* ********************************************* */
      }
      void L0100()
      {
         /*  Append category/resource details for   * */
         /*      a single centre                        * */
         /* ********************************************* */
         /* !!     ACTIVITY.LIST = ""; * Here this is just maintained as a validation list to prevent duplication */
         CATEGORY_LIST = "";
         LEVEL_LIST = "";
         /*  Maintain in tandem with CAT.LEVEL.REC(1) & (2) */
         INSTRUCTION = "SSELECT FWQ." + THIS_CENTRE_CODE + ".CATEGORY.LEVELS WITH 3 = \"Y\" BY DESC";
         nrf0 = "SO";
         CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref SELMESSAGE, ref ERRORS);
         TLC_EOF = FALSE;
         do
         {
            if (!READNEXT(ref PARENT_CATEGORY, 0, 0, RTN_LIST)) { TLC_EOF = TRUE; }
            if (TLC_EOF || ERROR_STATUS >= FIRST_FATAL_ERROR) break;
            if (!MATREAD(ref SPORTS_REC, FL_SPORTS, PARENT_CATEGORY)) { MAT(ref SPORTS_REC, ""); }
            TREE_MVC = TREE_MVC + 1;
            TREE_ARRAY[1, TREE_MVC] = SPORTS_REC[SPORTS_DESC];
            TREE_ARRAY[2, TREE_MVC] = TREE_ARRAY[1, TREE_MVC];
            TREE_ARRAY[3, TREE_MVC] = 1;
            /*  Top level category */
            TREE_ARRAY[4, TREE_MVC] = 1;
            /*  Default to open */
            TREE_ARRAY[5, TREE_MVC] = THIS_CENTRE_CODE + "*" + PARENT_CATEGORY;
            TREE_ARRAY[6, TREE_MVC] = 1;
            /*  Category Icon */
            if (MATREAD(ref CAT_LEVEL_REC, FL_CATEGORY_LEVELS, PARENT_CATEGORY))
            {
               LEVEL_LIST = "2" + STR((VM + "2"), DCOUNT(CAT_LEVEL_REC[CAT_LEVEL_SUB_LIST], VM) - 1);
               NO_MVS = DCOUNT(CAT_LEVEL_REC[CAT_LEVEL_SUB_LIST], VM);
               CODE_POS = 1;
               do
               {
                  if (CODE_POS > NO_MVS) break;
                  THIS_CODE = CAT_LEVEL_REC[CAT_LEVEL_SUB_LIST][1, CODE_POS];
                  THIS_TYPE = CAT_LEVEL_REC[CAT_LEVEL_CAT_OR_RESOURCE_LIST][1, CODE_POS];
                  if (THIS_TYPE == "") { THIS_TYPE = "R"; /*  Default to Resource */ }
                  /* !!           IF SPORTS.VISIBILITY = "" THEN SPORTS.VISIBILTY = "B" */
                  // BEGIN CASE
                  // CASE
                  if (THIS_CODE == "")
                  {
                     NULL();
                     /*  Check visibility */
                     /* !!           CASE SPORTS.VISIBILITY = "I" AND MODE = 0 */
                     /*  Internal resource - not visible on Internet */
                     /* !!              NULL */
                     /* !!           CASE SPORTS.VISIBILITY = "E" AND MODE = 2 */
                     /*  External resource - not visible on Intranet */
                     /* !!              NULL */
                  }// CASE
                  else if (THIS_TYPE == "R" && CATEGORIES_ONLY)
                  {
                     NULL();
                     /* DJA 23.12.05!              CASE THIS.TYPE = "R" */
                     /* !!                 LOCATE(THIS.CODE,ACTIVITY.LIST;TEST.POS) ELSE */
                     /* !!                    ACTIVITY.LIST<-1> = THIS.CODE */
                     /* DJA 23.12.05!    TREE.MVC = TREE.MVC + 1 */
                     /* DJA 23.12.05!    READV SPORTS.DESC FROM FL.SPORTS, THIS.CODE, 1 ELSE SPORTS.DESC = "" */
                     /* DJA 23.12.05!    TREE.ARRAY<1,TREE.MVC> = SPORTS.DESC */
                     /* DJA 23.12.05!    TREE.ARRAY<2,TREE.MVC> = TREE.ARRAY<1,TREE.MVC> */
                     /* DJA 23.12.05!    TREE.ARRAY<3,TREE.MVC> = LEVEL.LIST<1,CODE.POS> */
                     /* DJA 23.12.05!    TREE.ARRAY<4,TREE.MVC> = 0 ; * Default to closed */
                     /* DJA 23.12.05!    TREE.ARRAY<5,TREE.MVC> = THIS.CENTRE.CODE:"*":THIS.CODE */
                     /* DJA 23.12.05!    TREE.ARRAY<6,TREE.MVC> = 2 ; * Resource Icon */
                     /* !!                 END */
                  }// CASE
                  else if (OTHERWISE)
                  {
                     if (LOCATE(THIS_CODE, CATEGORY_LIST, 0, 0, 1, ref TEST_POS, "AL"))
                     {
                        /*  We've already processed this category - recursive category */
                        /*  structure must have been defined */
                        ERROR_STATUS = 2022;
                        MESSAGE = "Invalid category structure. Recursion below " + PARENT_CATEGORY + " involving " + THIS_CODE + " for centre " + THIS_CENTRE_CODE;
                     }
                     else
                     {
                        TREE_MVC = TREE_MVC + 1;
                        if (!READV(ref SPORTS_REC[SPORTS_DESC], FL_SPORTS, THIS_CODE, 1)) { SPORTS_REC[SPORTS_DESC] = ""; }
                        TREE_ARRAY[1, TREE_MVC] = SPORTS_REC[SPORTS_DESC];
                        TREE_ARRAY[2, TREE_MVC] = TREE_ARRAY[1, TREE_MVC];
                        TREE_ARRAY[3, TREE_MVC] = LEVEL_LIST[1, CODE_POS];
                        TREE_ARRAY[4, TREE_MVC] = 0;
                        /*  Default to closed */
                        TREE_ARRAY[5, TREE_MVC] = THIS_CENTRE_CODE + "*" + THIS_CODE;
                        if (THIS_TYPE == "C")
                        {
                           TREE_ARRAY[6, TREE_MVC] = 1;
                           /*  Category Icon */
                           CATEGORY_LIST[-1] = THIS_CODE;
                        }
                        else
                        {
                           TREE_ARRAY[6, TREE_MVC] = 2;
                           /*  Resource Icon */
                        }
                        /*  Modify CAT.LEVEL.SUB.LIST, inserting the sub-code. This */
                        /*  will cause a recursive call down the category structure. */
                        /*  (The record containing the sub.list is not filed) */
                        PARENT_POS = CODE_POS;
                        if (READ(ref CHILD_SUB_REC, FL_CATEGORY_LEVELS, THIS_CODE))
                        {
                           NO_CHILD_CODES = DCOUNT(CHILD_SUB_REC[1], VM);
                           for (CHILD_MVC = 1; CHILD_MVC <= NO_CHILD_CODES; CHILD_MVC += 1)
                           {
                              CHILD_CODE = CHILD_SUB_REC[1, CHILD_MVC];
                              CHILD_TYPE = CHILD_SUB_REC[2, CHILD_MVC];
                              if (CHILD_CODE != "")
                              {
                                 NO_MVS = NO_MVS + 1;
                                 /* !!                          CAT.LEVEL.SUB.LIST<1,NO.MVS> = CHILD.CODE */
                                 CAT_LEVEL_REC[CAT_LEVEL_SUB_LIST] = INSERT(CAT_LEVEL_REC[CAT_LEVEL_SUB_LIST], 1, (CODE_POS + CHILD_MVC), 0, CHILD_CODE);
                                 /* !!                          CAT.LEVEL.CAT.OR.RESOURCE.LIST<1,NO.MVS> = CHILD.TYPE */
                                 CAT_LEVEL_REC[CAT_LEVEL_CAT_OR_RESOURCE_LIST] = INSERT(CAT_LEVEL_REC[CAT_LEVEL_CAT_OR_RESOURCE_LIST], 1, (CODE_POS + CHILD_MVC), 0, CHILD_TYPE);
                                 /*  Indicate that we've descended another level. The tree view */
                                 /*  will use this to generate another child node */
                                 /* !!                          LEVEL.LIST<1,NO.MVS> = LEVEL.LIST<1,PARENT.POS> + 1 */
                                 LEVEL_LIST = INSERT(LEVEL_LIST, 1, (CODE_POS + CHILD_MVC), 0, LEVEL_LIST[1, PARENT_POS] + 1);
                              }
                           }
                        }
                     }
                  }
                  // END CASE
                  CODE_POS = CODE_POS + 1;
               } while (true);
            }
         } while (true);
         return;
         /* ******************************* */
      }
      void L0500()
      {
         /*  Open remote files */
         /* ******************************* */
         if (ERROR_STATUS < FIRST_FATAL_ERROR)
         {
            CATEGORY_LEVELS_FILE = "FWQ." + THIS_CENTRE_CODE + ".CATEGORY.LEVELS";
            if (OPEN(CATEGORY_LEVELS_FILE, out FL_CATEGORY_LEVELS))
            {
               FILES_OPEN[4] = TRUE;
            }
            else
            {
               POINTER_REC = "Q";
               POINTER_REC[2] = ACCOUNT_NAME;
               POINTER_REC[3] = "FL.CATEGORY.LEVELS";
               WRITE(POINTER_REC, LOCAL_MD, CATEGORY_LEVELS_FILE);
               if (OPEN(CATEGORY_LEVELS_FILE, out FL_CATEGORY_LEVELS)) { FILES_OPEN[4] = TRUE; } else { ERROR_STATUS = 2045; MESSAGE = PROGRAM + ": Unable to access category levels file"; }
            }
            SPORTS_FILE = "FWQ." + THIS_CENTRE_CODE + ".SPORTS";
            if (OPEN(SPORTS_FILE, out FL_SPORTS))
            {
               FILES_OPEN[5] = TRUE;
            }
            else
            {
               POINTER_REC = "Q";
               POINTER_REC[2] = ACCOUNT_NAME;
               POINTER_REC[3] = "FL.SPORTS";
               WRITE(POINTER_REC, LOCAL_MD, SPORTS_FILE);
               if (OPEN(SPORTS_FILE, out FL_SPORTS)) { FILES_OPEN[5] = TRUE; } else { ERROR_STATUS = 2046; MESSAGE = PROGRAM + ": Unable to access category and resource file"; }
            }
         }
         return;
         /* *********************************** */
      }
      void L0600()
      {
         /*  Close remote files */
         /* *********************************** */
         if (FILES_OPEN[4] == TRUE)
         {
            CLOSE(FL_CATEGORY_LEVELS);
         }
         if (FILES_OPEN[5] == TRUE)
         {
            CLOSE(FL_SPORTS);
         }
         return;
      }
   }
}
