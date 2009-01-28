//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL915_CSV : UvBase
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
      readonly UvVar FL_CONTROL = 10;
      readonly UvVar COURSE_MSTR_DESC = 1;
      readonly UvVar COURSE_MSTR_DATES = 2;
      readonly UvVar COURSE_MSTR_ACTIVITY_CODE = 3;
      readonly UvVar COURSE_MSTR_CENTRE = 4;
      readonly UvVar COURSE_MSTR_WET_DRY = 5;
      readonly UvVar COURSE_MSTR_AWARD_CODE1 = 6;
      readonly UvVar COURSE_MSTR_PAY_CODE = 7;
      readonly UvVar COURSE_MSTR_AWARD_CODE2 = 8;
      readonly UvVar COURSE_MSTR_AWARD_CODE3 = 9;
      readonly UvVar COURSE_MSTR_AWARD_CODE4 = 10;
      readonly UvVar COURSE_MSTR_TYPE = 11;
      readonly UvVar COURSE_MSTR_WEB_TYPE = 12;
      readonly UvVar COURSE_MSTR_WEB_BOOKABLE = 13;
      readonly UvVar COURSE_MSTR_EXCEPTIONS = 14;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] STUDENT_REC = new UvVar[60];
      UvVar[] CONTROLS_REC = new UvVar[20];
      UvVar[] COURSE_MSTR_REC = new UvVar[15];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar VM = "";
      UvVar FL_STUDENTS = "";
      UvVar FL_COURSE_MASTER = "";
      UvVar PROGRAM = "";
      UvVar PROCESS_EXECUTE = "";
      UvVar FATAL_ERROR = "";
      UvVar START_DATE = "";
      UvVar END_DATE = "";
      UvVar REQUESTED_COURSE = "";
      UvVar REQUESTED_TYPE = "";
      UvVar REQUESTED_CENTRE = "";
      UvVar EXPORT_PATH = "";
      UvVar EXPORT_FILE = "";
      FL006 FL006;
      UvVar REPLINE = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      UvVar EOF = "";
      UvVar STUDENT_ID = "";
      UvVar R_STUDENTS = "";
      UvVar DETAIL_COUNT = "";
      UvVar DETAIL_NO = "";
      UvVar TRAN_DATE = "";
      UvVar INCLUDE_ITEM = "";
      UvVar K_COURSE = "";
      UvVar R_COURSE = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FL915_CSV()
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
         /*  Course adjustment enquiry */
         #region INCLUDE FL.FILES FL.STUDENTS
         if (!OPEN("FL.STUDENTS", out FL_STUDENTS)) { STOP("201", "FL.STUDENTS"); }

         /*  Manual receipts are a redundant feature */
         /*  Attribute now used to indicate web re-enrolment */

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         #region INCLUDE FL.FILES FL.COURSE.MASTER

         if (!OPEN("FL.COURSE.MASTER", out FL_COURSE_MASTER)) { STOP("201", "FL.COURSE.MASTER"); }
         /*  A = Activity Day or Null for standard course :- */
         /*  Optional code corresponding to FL.COURSE.TYPES :- */

         #endregion
         PROGRAM = "FL915.CSV";
         PRINT(AT(0, 20));
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         if (!MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { return; }
         FATAL_ERROR = FALSE;
         START_DATE = CONTROLS_REC[5];
         END_DATE = CONTROLS_REC[6];
         REQUESTED_COURSE = CONTROLS_REC[7];
         REQUESTED_TYPE = CONTROLS_REC[8];
         REQUESTED_CENTRE = CONTROLS_REC[9];
         EXPORT_PATH = CONTROLS_REC[10];
         if (!(OPENSEQ(EXPORT_PATH, out EXPORT_FILE)))
         {
            if (!(CREATE(EXPORT_FILE)))
            {
               nrf0 = 1;
               nrf1 = "";
               FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
               FATAL_ERROR = TRUE;
            }

            REPLINE = "\"Student\",";
            REPLINE += "\"Course\",";
            REPLINE += "\"Starts\",";
            REPLINE += "\"Amount\",";
            REPLINE += "\"User\",";
            REPLINE += "\"Actioned on\",";
            REPLINE += "\"Reason\"";
            if (NOT(FATAL_ERROR))
            {
               if (!(WRITESEQ(REPLINE, EXPORT_FILE)))
               {
                  nrf0 = 2;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  FATAL_ERROR = TRUE;
               }
            }
            INSTRUCTION = "SSELECT FL.STUDENTS BY ID";
            nrf0 = "SO";
            CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
            EOF = 0;
            do
            {
               if (!READNEXT(ref STUDENT_ID, 0, 0, RTN_LIST)) { EOF = 1; }
               if (EOF || FATAL_ERROR) break;
               if (READ(ref R_STUDENTS, FL_STUDENTS, STUDENT_ID))
               {
                  DETAIL_COUNT = DCOUNT(R_STUDENTS[25], VM);
                  for (DETAIL_NO = 1; DETAIL_NO <= DETAIL_COUNT; DETAIL_NO += 1)
                  {
                     TRAN_DATE = R_STUDENTS[25, DETAIL_NO];
                     if (TRAN_DATE >= START_DATE && TRAN_DATE <= END_DATE)
                     {
                        if (R_STUDENTS[26, DETAIL_NO] == "A")
                        {
                           if (R_STUDENTS[30, DETAIL_NO] != "M")
                           {
                              L100();
                              /*  Check if required for report. */
                              if (INCLUDE_ITEM)
                              {
                                 L200();
                                 /*  Add line to output. */
                              }
                           }
                        }
                     }
                  }
               }
            } while (true);
            if (NOT(FATAL_ERROR))
            {
               WEOFSEQ(EXPORT_FILE);
               CLOSESEQ(EXPORT_FILE);
            }
         }
         return;
         /*  Does this course fit request parameters? */
      }
      void L100()
      {
         INCLUDE_ITEM = TRUE;
         K_COURSE = FIELD(R_STUDENTS[24, DETAIL_NO], "*", 2);
         if (REQUESTED_COURSE != "")
         {
            if (K_COURSE != REQUESTED_COURSE)
            {
               INCLUDE_ITEM = FALSE;
            }
            if (REQUESTED_CENTRE != "" || REQUESTED_TYPE != "")
            {
               if (!(READ(ref R_COURSE, FL_COURSE_MASTER, K_COURSE)))
               {
                  R_COURSE = "";
               }
               if (REQUESTED_CENTRE != "")
               {
                  if (R_COURSE[4] != REQUESTED_CENTRE)
                  {
                     INCLUDE_ITEM = FALSE;
                  }
               }
               if (REQUESTED_TYPE != "")
               {
                  if (R_COURSE[12] != REQUESTED_TYPE)
                  {
                     INCLUDE_ITEM = FALSE;
                  }
               }
            }
         }
         return;
         /*  Add a line to the output. */
      }
      void L200()
      {
         REPLINE = "\"" + STUDENT_ID + "\",";
         REPLINE += "\"" + K_COURSE + "\",";
         REPLINE += "\"" + OCONV(FIELD(R_STUDENTS[24, DETAIL_NO], "*", 1), "D2") + "\",";
         REPLINE += "\"" + OCONV(R_STUDENTS[27, DETAIL_NO], "MD2") + "\",";
         REPLINE += "\"" + R_STUDENTS[32, DETAIL_NO] + "\",";
         REPLINE += "\"" + OCONV(R_STUDENTS[25, DETAIL_NO], "D2") + "\",";
         REPLINE += "\"" + R_STUDENTS[31, DETAIL_NO] + "\"";
         if (!(WRITESEQ(REPLINE, EXPORT_FILE)))
         {
            nrf0 = 2;
            nrf1 = "";
            FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
            FATAL_ERROR = TRUE;
         }
         return;
         /* ********************* */
         /*  End of source code * */
         /* ********************* */
      }
   }
}
