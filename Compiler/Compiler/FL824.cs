//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL824 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar STUDENT_TITLE = 1;
      readonly UvVar STUDENT_FORENAME = 2;
      readonly UvVar STUDENT_SURNAME = 3;
      readonly UvVar STUDENT_ADDRESS1 = 4;
      readonly UvVar STUDENT_ADDRESS2 = 5;
      readonly UvVar STUDENT_ADDRESS3 = 6;
      readonly UvVar STUDENT_ADDRESS4 = 7;
      readonly UvVar STUDENT_POST_CODE = 8;
      readonly UvVar STUDENT_SEX = 9;
      readonly UvVar STUDENT_HOME_TEL = 10;
      readonly UvVar STUDENT_WORK_TEL = 11;
      readonly UvVar STUDENT_DOB = 12;
      readonly UvVar STUDENT_MEDICAL1 = 13;
      readonly UvVar STUDENT_MEDICAL2 = 14;
      readonly UvVar STUDENT_MEDICAL3 = 15;
      readonly UvVar STUDENT_COMMENT1 = 16;
      readonly UvVar STUDENT_COMMENT2 = 17;
      readonly UvVar STUDENT_COMMENT3 = 18;
      readonly UvVar STUDENT_COMMENT4 = 19;
      readonly UvVar STUDENT_CONTACT_NAME = 20;
      readonly UvVar STUDENT_CONTACT_PHONE = 21;
      readonly UvVar STUDENT_DETAIL_IDS = 22;
      readonly UvVar STUDENT_BALANCE = 23;
      readonly UvVar STUDENT_TRANS_DETAILS_IDS = 24;
      readonly UvVar STUDENT_TRANS_DATES = 25;
      readonly UvVar STUDENT_TRANS_TYPES = 26;
      readonly UvVar STUDENT_TRANS_AMOUNTS = 27;
      readonly UvVar STUDENT_TRANS_RECEIPT_NOS = 28;
      readonly UvVar STUDENT_TRANS_MOPS = 29;
      readonly UvVar STUDENT_TRANS_MAN_RECEIPT = 30;
      readonly UvVar STUDENT_TRANS_WEB = 30;
      readonly UvVar STUDENT_TRANS_ADJ_REASON = 31;
      readonly UvVar STUDENT_TRANS_USER = 32;
      readonly UvVar STUDENT_OLD_NUMBERS = 33;
      readonly UvVar STUDENT_AWARD1 = 34;
      readonly UvVar STUDENT_AWARD2 = 35;
      readonly UvVar STUDENT_AWARD3 = 36;
      readonly UvVar STUDENT_AWARD4 = 37;
      readonly UvVar STUDENT_DOCTOR_NAME = 38;
      readonly UvVar STUDENT_DOCTOR_TEL = 39;
      readonly UvVar STUDENT_KEYWORD = 40;
      readonly UvVar STUDENT_AWARD5 = 41;
      readonly UvVar STUDENT_AWARD6 = 42;
      readonly UvVar STUDENT_AWARD7 = 43;
      readonly UvVar STUDENT_AWARD8 = 44;
      readonly UvVar STUDENT_AWARD9 = 45;
      readonly UvVar STUDENT_AWARD10 = 46;
      readonly UvVar STUDENT_AWARD11 = 47;
      readonly UvVar STUDENT_AWARD12 = 48;
      readonly UvVar STUDENT_GROUP_ENROLLED = 49;
      readonly UvVar FL_MEMBERS = 2;
      readonly UvVar MEMBER_CENTRE = 1;
      readonly UvVar MEMBER_TYPE = 2;
      readonly UvVar MEMBER_ORIG_PRICE = 3;
      readonly UvVar MEMBER_SURNAMES = 4;
      readonly UvVar MEMBER_INITIALS = 5;
      readonly UvVar MEMBER_TITLES = 6;
      readonly UvVar MEMBER_SEXES = 7;
      readonly UvVar MEMBER_AGES = 8;
      readonly UvVar MEMBER_RENEW_LETTER = 9;
      readonly UvVar MEMBER_SALUTATION = 9;
      readonly UvVar MEMBER_ADDRESS = 10;
      readonly UvVar MEMBER_HOME_PHONE = 11;
      readonly UvVar MEMBER_BUS_PHONE = 12;
      readonly UvVar MEMBER_EXPIRY_DATE = 13;
      readonly UvVar MEMBER_DATE_JOINED = 14;
      readonly UvVar MEMBER_ISSUING_OPER = 15;
      readonly UvVar MEMBER_ANALYSIS_CODES = 16;
      readonly UvVar MEMBER_USED_CODES = 17;
      readonly UvVar MEMBER_MAIN = 18;
      readonly UvVar MEMBER_SUB = 19;
      readonly UvVar MEMBER_RECEIPT = 20;
      readonly UvVar MEMBER_DOBS = 21;
      readonly UvVar MEMBER_LAST_CHANGED = 22;
      readonly UvVar MEMBER_HF_CARD_DATE = 23;
      readonly UvVar MEMBER_INSTALMENTS = 24;
      readonly UvVar MEMBER_FULL_EXPIRY = 25;
      readonly UvVar MEMBER_REMINDER_DATES = 26;
      readonly UvVar MEMBER_RESTRICTIONS = 27;
      readonly UvVar MEMBER_DIRECT_DEBIT = 28;
      readonly UvVar MEMBER_FORENAMES = 29;
      readonly UvVar MEMBER_COMMENTS = 30;
      readonly UvVar MEMBER_PART_COMPLETE = 31;
      readonly UvVar MEMBER_START_DATE = 32;
      readonly UvVar MEMBER_RENEWAL_DATE = 33;
      readonly UvVar MEMBER_DD_DAY = 34;
      readonly UvVar MEMBER_PRICES = 35;
      readonly UvVar MEMBER_WEB_BARRED = 36;
      readonly UvVar MEMBER_EMAIL_ADDRESS = 37;
      readonly UvVar MEMBER_EMAIL_SALES = 38;
      readonly UvVar MEMBER_DDFLAGS = 39;
      readonly UvVar MEMBER_OLDNOS = 40;
      readonly UvVar MEMBER_PROSPECT_NO = 41;
      readonly UvVar MEMBER_APACS_NO = 42;
      readonly UvVar MEMBER_MOBILE_PHONE = 43;
      readonly UvVar MEMBER_JOB_TITLE = 44;
      readonly UvVar MEMBER_DEPARTMENT = 45;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] STUDENT_REC = new UvVar[60];
      UvVar[] MEMBERS_REC = new UvVar[45];
      UvVar[] COURSE_PARAM_REC = new UvVar[60];
      UvVar[] OLD_STUDENT_REC = new UvVar[40];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar ERR_LINE = "";
      UvVar CLR_ERR = "";
      UvVar SCREEN_BACK = "";
      UvVar SCREEN_TEXT = "";
      UvVar ERR_MESS_BACK = "";
      UvVar ERR_MESS_FORE = "";
      UvVar PROGRAM = "";
      UvVar EXEC_PROG = "";
      UvVar FL_STUDENTS = "";
      UvVar SIZE_OF_MEMBERS_REC = "";
      UvVar FL_COURSE_PARAMS = "";
      UvVar FORMAT_STUDENT_NO = "";
      FL000_10 FL000_10;
      UvVar OLD_NO = "";
      UvVar OLD_STUDENT_EXISTS = "";
      UvVar OLD_FORMATTED_NO = "";
      CallAt_FORMAT_STUDENT_NO CallAt_FORMAT_STUDENT_NO;
      FL000_40 FL000_40;
      UvVar OLD_STUDENT_IS_MEMBER = "";
      UvVar FORENAME = "";
      UvVar SURNAME = "";
      UvVar ADDRESS_LINE1 = "";
      UvVar ADDRESS_LINE2 = "";
      UvVar ADDRESS_LINE3 = "";
      UvVar ADDRESS_LINE4 = "";
      UvVar POSTCODE = "";
      UvVar VALID_OLD_NO = "";
      UvVar ROW = "";
      UvVar WAIT = "";
      UvVar NEW_NO = "";
      FL019 FL019;
      UvVar DUMMY = "";
      UvVar NEW_STUDENT_EXISTS = "";
      UvVar NEW_FORMATTED_NO = "";
      UvVar NEW_STUDENT_IS_MEMBER = "";
      UvVar VALID_NEW_NO = "";
      FL006 FL006;
      UvVar REPLY = "";
      FL825 FL825;
      UvVar INTERACT = "";
      UvVar ERROR_MESSAGE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL824()
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
         /*     COMBINE DUPLICATE STUDENT.RECORDS */
         PROGRAM = "FL824";
         EXEC_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
         #region INCLUDE FL.FILES FL.STUDENTS
         if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

         /*  Manual receipts are a redundant feature */
         /*  Attribute now used to indicate web re-enrolment */

         #endregion
         #region INCLUDE FL.FILES FL.MEMBERS

         /*  DJA 14.8.01 Separate file includes for web bookings */
         /*              (see FL.MEMBERS.VAR for field names) */
         #region INCLUDE FL.FILES FL.MEMBERS.EQU

         #endregion
         #region INCLUDE FL.FILES FL.MEMBERS.DIM

         SIZE_OF_MEMBERS_REC = 45;
         /*  Must keep in tandem */

         #endregion
         #region INCLUDE FL.FILES FL.MEMBERS.VAR

         /*  Hammersmith & Fulham - Membership Card production systems */
         /*  Two tier reminder system */

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.COURSE.PARAMS
         #region INCLUDE FL.FILES FL.COURSE.PARAMS.EQU
         if (!OPEN("FL.COURSE.PARAMS", out FL_COURSE_PARAMS)) { STOP("201", "FL.COURSE.PARAMS"); }

         #endregion

         #region INCLUDE FL.FILES FL.COURSE.PARAMS.DIM

         #endregion

         #endregion
         if (!READV(ref FORMAT_STUDENT_NO, FL_COURSE_PARAMS, "COURSE.PARAMS", 12)) { FORMAT_STUDENT_NO = ""; }
         nrf0 = 0;
         FL000_10 = new FL000_10(ref PROGRAM, ref nrf0);
      L10: ;
         do
         {
            PRINT(AT(10, 4) + "Incorrect student No    [                 ]");
            PRINT(AT(35, 4));
            INPUTCR(out OLD_NO, 17);
            if (OLD_NO == "." || OLD_NO == "") { return; }
            OLD_STUDENT_EXISTS = FALSE;
            if (MATREAD(ref STUDENT_REC, FL_STUDENTS, OLD_NO))
            {
               OLD_STUDENT_EXISTS = TRUE;
            }
            else
            {
               if (FORMAT_STUDENT_NO != "")
               {
                  CallAt_FORMAT_STUDENT_NO = new CallAt_FORMAT_STUDENT_NO(ref FORMAT_STUDENT_NO, ref OLD_NO, ref OLD_FORMATTED_NO);
                  PRINT(AT(35, 4) + FORMAT(OLD_FORMATTED_NO, "L#12"));
                  if (MATREAD(ref STUDENT_REC, FL_STUDENTS, OLD_FORMATTED_NO))
                  {
                     OLD_STUDENT_EXISTS = TRUE;
                     OLD_NO = OLD_FORMATTED_NO;
                  }
               }
               else
               {
                  FL000_40 = new FL000_40(ref OLD_NO);
                  PRINT(AT(35, 4) + FORMAT(OLD_NO, "L#12"));
                  if (MATREAD(ref STUDENT_REC, FL_STUDENTS, OLD_NO))
                  {
                     OLD_STUDENT_EXISTS = TRUE;
                  }
               }
            }
            if (OLD_STUDENT_EXISTS)
            {
               OLD_STUDENT_IS_MEMBER = FALSE;
               if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], OLD_NO))
               {
                  OLD_STUDENT_IS_MEMBER = TRUE;
                  FORENAME = MEMBERS_REC[MEMBER_FORENAMES][1, 1];
                  SURNAME = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
                  ADDRESS_LINE1 = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
                  ADDRESS_LINE2 = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
                  ADDRESS_LINE3 = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
                  ADDRESS_LINE4 = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
                  POSTCODE = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
                  VALID_OLD_NO = TRUE;
               }
               else
               {
                  FORENAME = STUDENT_REC[STUDENT_FORENAME];
                  SURNAME = STUDENT_REC[STUDENT_SURNAME];
                  ADDRESS_LINE1 = STUDENT_REC[STUDENT_ADDRESS1];
                  ADDRESS_LINE2 = STUDENT_REC[STUDENT_ADDRESS2];
                  ADDRESS_LINE3 = STUDENT_REC[STUDENT_ADDRESS3];
                  ADDRESS_LINE4 = STUDENT_REC[STUDENT_ADDRESS4];
                  POSTCODE = STUDENT_REC[STUDENT_POST_CODE];
               }
               PRINT(AT(10, 5) + "Forename                [               ]");
               PRINTCR(AT(35, 5) + FORENAME);
               PRINT(AT(10, 6) + "Surname                 [               ]");
               PRINTCR(AT(35, 6) + SURNAME);
               PRINT(AT(10, 7) + "Address                 [                         ]");
               PRINTCR(AT(35, 7) + ADDRESS_LINE1);
               ROW = 7;
               if (ADDRESS_LINE2 != "")
               {
                  ROW = ROW + 1;
                  PRINTCR(AT(34, ROW) + "[" + FORMAT(ADDRESS_LINE2, "L#25") + "]");
               }
               if (ADDRESS_LINE3 != "")
               {
                  ROW = ROW + 1;
                  PRINTCR(AT(34, ROW) + "[" + FORMAT(ADDRESS_LINE3, "L#25") + "]");
               }
               if (ADDRESS_LINE4 != "")
               {
                  ROW = ROW + 1;
                  PRINTCR(AT(34, ROW) + "[" + FORMAT(ADDRESS_LINE4, "L#25") + "]");
               }
               if (POSTCODE != "")
               {
                  ROW = ROW + 1;
                  PRINTCR(AT(34, ROW) + "[" + FORMAT(POSTCODE, "L#25") + "]");
               }
               VALID_OLD_NO = TRUE;
            }
            else
            {
               PRINT(ERR_LINE + ERR_MESS_BACK + ERR_MESS_FORE);
               PRINT("Unable to read student " + OLD_NO + " from file - <RETURN> to enter ");
               PRINT("another No ");
               INPUT(out WAIT, 1);
               PRINT(ERR_LINE + SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
               VALID_OLD_NO = FALSE;
            }
            if (VALID_OLD_NO) break;
         } while (true);
         MAT(ref OLD_STUDENT_REC, STUDENT_REC);
         do
         {
            PRINT(AT(10, 13) + "Correct Student No      [                 ]");
            PRINT(AT(35, 13));
            INPUT(out NEW_NO, 17);
            if (NEW_NO == "." || NEW_NO == "")
            {
               PRINT(ERR_LINE + SCREEN_BACK + SCREEN_TEXT + "  Process abandoned - no updates have been applied");
               nrf0 = 2;
               FL019 = new FL019(ref nrf0, ref DUMMY);
               return;
            }
            /* ******************** */
            NEW_STUDENT_EXISTS = FALSE;
            if (MATREAD(ref STUDENT_REC, FL_STUDENTS, NEW_NO))
            {
               NEW_STUDENT_EXISTS = TRUE;
            }
            else
            {
               if (FORMAT_STUDENT_NO != "")
               {
                  CallAt_FORMAT_STUDENT_NO = new CallAt_FORMAT_STUDENT_NO(ref FORMAT_STUDENT_NO, ref NEW_NO, ref NEW_FORMATTED_NO);
                  PRINT(AT(35, 13) + FORMAT(NEW_FORMATTED_NO, "L#12"));
                  if (MATREAD(ref STUDENT_REC, FL_STUDENTS, NEW_FORMATTED_NO))
                  {
                     NEW_STUDENT_EXISTS = TRUE;
                     NEW_NO = NEW_FORMATTED_NO;
                  }
               }
               else
               {
                  FL000_40 = new FL000_40(ref NEW_NO);
                  PRINT(AT(35, 13) + FORMAT(NEW_NO, "L#12"));
                  if (MATREAD(ref STUDENT_REC, FL_STUDENTS, NEW_NO))
                  {
                     NEW_STUDENT_EXISTS = TRUE;
                  }
               }
            }
            /*        IF NEW.STUDENT.EXISTS THEN */
            NEW_STUDENT_IS_MEMBER = FALSE;
            if (MATREAD(ref MEMBERS_REC, COMMON.FILES[FL_MEMBERS], NEW_NO))
            {
               NEW_STUDENT_IS_MEMBER = TRUE;
               if (NOT(NEW_STUDENT_EXISTS))
               {
                  MAT(ref STUDENT_REC, "");
                  NEW_STUDENT_EXISTS = TRUE;
               }
               FORENAME = MEMBERS_REC[MEMBER_FORENAMES][1, 1];
               SURNAME = MEMBERS_REC[MEMBER_SURNAMES][1, 1];
               ADDRESS_LINE1 = MEMBERS_REC[MEMBER_ADDRESS][1, 1];
               ADDRESS_LINE2 = MEMBERS_REC[MEMBER_ADDRESS][1, 2];
               ADDRESS_LINE3 = MEMBERS_REC[MEMBER_ADDRESS][1, 3];
               ADDRESS_LINE4 = MEMBERS_REC[MEMBER_ADDRESS][1, 4];
               POSTCODE = MEMBERS_REC[MEMBER_ADDRESS][1, 5];
               VALID_NEW_NO = TRUE;
            }
            else
            {
               FORENAME = STUDENT_REC[STUDENT_FORENAME];
               SURNAME = STUDENT_REC[STUDENT_SURNAME];
               ADDRESS_LINE1 = STUDENT_REC[STUDENT_ADDRESS1];
               ADDRESS_LINE2 = STUDENT_REC[STUDENT_ADDRESS2];
               ADDRESS_LINE3 = STUDENT_REC[STUDENT_ADDRESS3];
               ADDRESS_LINE4 = STUDENT_REC[STUDENT_ADDRESS4];
               POSTCODE = STUDENT_REC[STUDENT_POST_CODE];
            }
            if (NEW_STUDENT_EXISTS)
            {
               PRINT(AT(10, 14) + "Forename                [               ]");
               PRINTCR(AT(35, 14) + FORENAME);
               PRINT(AT(10, 15) + "Surname                 [               ]");
               PRINTCR(AT(35, 15) + SURNAME);
               PRINT(AT(10, 16) + "Address                 [                         ]");
               PRINTCR(AT(35, 16) + ADDRESS_LINE1);
               ROW = 16;
               if (ADDRESS_LINE2 != "")
               {
                  ROW = ROW + 1;
                  PRINTCR(AT(34, ROW) + "[" + FORMAT(ADDRESS_LINE2, "L#25") + "]");
               }
               if (ADDRESS_LINE3 != "")
               {
                  ROW = ROW + 1;
                  PRINTCR(AT(34, ROW) + "[" + FORMAT(ADDRESS_LINE3, "L#25") + "]");
               }
               if (ADDRESS_LINE4 != "")
               {
                  ROW = ROW + 1;
                  PRINTCR(AT(34, ROW) + "[" + FORMAT(ADDRESS_LINE4, "L#25") + "]");
               }
               if (POSTCODE != "")
               {
                  ROW = ROW + 1;
                  PRINTCR(AT(34, ROW) + "[" + FORMAT(POSTCODE, "L#25") + "]");
               }
               VALID_NEW_NO = TRUE;
               if (OLD_STUDENT_REC[2] != FORENAME || OLD_STUDENT_REC[3] != SURNAME)
               {
                  nrf0 = 1;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               }
            }
            else
            {
               PRINT(ERR_LINE + ERR_MESS_BACK + ERR_MESS_FORE);
               PRINT("Unable to read student " + NEW_NO + " from file - <RETURN> to enter ");
               PRINT("another No ");
               INPUT(out WAIT, 1);
               PRINT(ERR_LINE + SCREEN_BACK + SCREEN_TEXT + CLR_ERR);
               VALID_NEW_NO = FALSE;
            }
            if (VALID_NEW_NO == TRUE && OLD_NO == NEW_NO)
            {
               /*  Can't merge into the same record! */
               nrf0 = 2;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               VALID_NEW_NO = FALSE;
            }
            if (VALID_NEW_NO) break;
         } while (true);
         PRINT(ERR_LINE + SCREEN_BACK + SCREEN_TEXT + "First student's history will be merged with second student's. Continue? ");
         nrf0 = 4;
         FL019 = new FL019(ref nrf0, ref REPLY);
         REPLY = OCONV(REPLY, "MCU");
         if (REPLY == "Y")
         {
            FL825 = new FL825(ref OLD_NO, ref NEW_NO, ref OLD_STUDENT_REC, ref STUDENT_REC, ref INTERACT, ref ERROR_MESSAGE);
            PRINT(ERR_LINE + SCREEN_BACK + SCREEN_TEXT + "Successfully updated!" + COMMON.EOL);
            nrf0 = 1;
            FL019 = new FL019(ref nrf0, ref REPLY);
         }
         else
         {
            PRINT(ERR_LINE + ERR_MESS_BACK + ERR_MESS_FORE);
            PRINT(FORMAT("Process abandoned. No updates have taken place.", "L#75"));
            nrf0 = 1;
            FL019 = new FL019(ref nrf0, ref REPLY);
         }
         PRINT(AT(0, 3) + SCREEN_BACK + SCREEN_TEXT + COMMON.EOS);
         goto L10;
      }
   }
}
