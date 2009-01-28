//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL725 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_CONTROL = 10;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar MACHINE_TYPE = "";
      UvVar PROGRAM = "";
      UvVar FIRST_PAGE = "";
      UvVar PRINT_START_COMMAND = "";
      UvVar PRINT_END_COMMAND = "";
      UvVar PRINT_COMMANDS = "";
      FL235 FL235;
      UvVar PROCESS_EXECUTE = "";
      UvVar START_DATE = "";
      UvVar END_DATE = "";
      UvVar REQUESTED_CENTRE = "";
      UvVar HEADIN = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      CallAt_PROCESS_EXECUTE CallAt_PROCESS_EXECUTE;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL725()
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
         /*     PRINT LIST OF COURSES REPORT */
         PROGRAM = "FL725";
         /* ************************ */
         /*     DEFINE FILES USED  * */
         /* ************************ */
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         /* * Routine to set printer parameters  (condensed print) */
         FIRST_PAGE = TRUE;
         PRINT_START_COMMAND = "";
         PRINT_END_COMMAND = "";
         PRINT_COMMANDS = "";
         nrf0 = "COURSES.LANDSCAPE";
         FL235 = new FL235(ref nrf0, ref PRINT_START_COMMAND, ref PRINT_END_COMMAND, ref PRINT_COMMANDS);
         /* *************************** */
         /*     MAIN PROCESS SECTION  * */
         /* *************************** */
         PROCESS_EXECUTE = "FL." + MACHINE_TYPE + ".EXECUTE";
         if (!MATREAD(ref CONTROLS_REC, COMMON.FILES[FL_CONTROL], PROGRAM + ".RUN.PARAMS")) { return; }
         START_DATE = OCONV(CONTROLS_REC[5], "D");
         END_DATE = OCONV(CONTROLS_REC[6], "D");
         REQUESTED_CENTRE = CONTROLS_REC[7];
         HEADIN = "(FL725)" + SPACE(20) + "COURSES STARTING IN THE PERIOD " + START_DATE + " TO " + END_DATE + "        'T'  Page 'P'  'L'" + SPACE(27) + STR("=", 57) + "'LL'";
         /* !*OPTION1 = "'" : "L" : "'" */
         if (REQUESTED_CENTRE == "")
         {
            INSTRUCTION = "SORT FL.COURSE.DETAILS WITH START.DATE >= \"" + START_DATE + "\" AND WITH START.DATE <= \"" + END_DATE + "\" BY START.DATE BY ST BREAK-ON START.DATE DASH END.DATE SP1 COURSE.CODE DESC ST ET CENTRE.CODE INSTRUCTOR HEADING \"" + HEADIN + "\" ID-SUPP TCL-SUPP LPTR";
         }
         else
         {
            INSTRUCTION = "SORT FL.COURSE.DETAILS WITH START.DATE >= \"" + START_DATE + "\" AND WITH START.DATE <= \"" + END_DATE + "\" AND WITH CENTRE.CODE = \"" + REQUESTED_CENTRE + "\" BY START.DATE BREAK-ON START.DATE DASH END.DATE SP1 COURSE.CODE DESC ST ET CENTRE.CODE INSTRUCTOR HEADING \"" + HEADIN + "\" ID-SUPP TCL-SUPP LPTR";
         }
         if (PRINT_START_COMMAND != "")
         {
            PRINTER_ON();
            PRINT(PRINT_START_COMMAND);
            PRINTER_OFF();
         }
         nrf0 = "";
         CallAt_PROCESS_EXECUTE = new CallAt_PROCESS_EXECUTE(ref PROCESS_EXECUTE, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGE, ref ERRORS);
         /* !*  CALL FL235("STANDARD",PRINT.START.COMMAND, PRINT.END.COMMAND, PRINT.COMMANDS) */
         /*     IF PRINT.END.COMMAND # "" THEN */
         /*        PRINTER ON */
         /*        PRINT PRINT.END.COMMAND: */
         /*        PRINTER CLOSE */
         /*        PRINTER OFF */
         /*     END */
         return;
         /* ********************* */
         /*     END OF PROGRAM  * */
         /* ********************* */
      }
   }
}
