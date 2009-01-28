//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_ALTOS_EXECUTE : UvBase
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
      readonly UvVar INVALID_DATA = 5;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar STATEMENT = "";
      UvVar OPTIONS = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGE = "";
      UvVar ERRORS = "";
      UvVar INTERACT = "";
      UvVar EOF = "";
      UvVar ID = "";
      #endregion
      public FL_ALTOS_EXECUTE(ref UvVar STATEMENT, ref UvVar OPTIONS, ref UvVar RTN_LIST, ref UvVar LIST_AVAILABLE, ref UvVar MESSAGE, ref UvVar ERRORS)
      {
         this.STATEMENT = STATEMENT;
         this.OPTIONS = OPTIONS;
         this.RTN_LIST = RTN_LIST;
         this.LIST_AVAILABLE = LIST_AVAILABLE;
         this.MESSAGE = MESSAGE;
         this.ERRORS = ERRORS;
         #region INCLUDE FL.COMMON FL.COMMON

         // FILES
         //    Standard
         //    Screen Control
         //    Slave Printer Control
         //    Special Video
         //    User input control
         //    Application Specific
         //COMMON SC.POS
         //    Theatre
         //    Standard EQUates
         //    Client app control
         //\
         #region INCLUDE TX.INCLUDE TX.COMMON

         #endregion

         #endregion
         // EXECUTE FOR ALTOS MACHINES
         PROMPT("");
         //    INCLUDE STANDARD CODE FOR F_.ALTOS.EXECUTE  *
         #region INCLUDE FZ.LIBRARY FZ.ALTOS.EXECUTE
         //    INCLUDE FZ.ALTOS.EXECUTE

         //    STANDARD INCLUDE CODE FOR ALTOS EXECUTE STATEMENT
         //******************************
         //    MAIN PROCESSING SECTION  *
         //******************************
         INTERACT = VALID_DATA;
         MESSAGE = "";
         RTN_LIST = "";
         ERRORS = "";
         LIST_AVAILABLE = FALSE;
         //    DECIDE WHAT TYPE OF EXECUTE IS REQUIRED
         // BEGIN CASE
         // CASE
         if (OPTIONS == "O")
         {
            EXECUTE(STATEMENT, MESSAGE, string.Empty, string.Empty, string.Empty);
         }// CASE
         else if (OPTIONS == "SC" || OPTIONS == "CS" || OPTIONS == "S")
         {
            EXECUTE(STATEMENT, string.Empty, string.Empty, string.Empty, string.Empty);
            L0100();
         }// CASE
         else if (INDEX(OPTIONS, "S", 1) && INDEX(OPTIONS, "O", 1))
         {
            EXECUTE(STATEMENT, MESSAGE, string.Empty, string.Empty, string.Empty);
            L0100();
         }// CASE
         else if (OTHERWISE)
         {
            EXECUTE(STATEMENT, string.Empty, string.Empty, string.Empty, string.Empty);
         }
         // END CASE
         //    GET ERROR MESSAGE NUMBERS
         ERRORS = SYSTEM(17);
         return;
         //*************************************
      }
      void L0100()
      {
         //  CHECK FOR ACTIVE SELECT LIST
         //*************************************
         if (SYSTEM(11))
         {
            if (INDEX(OPTIONS, "C", 1))
            {
               L0200();
            }
            else
            {
               LIST_AVAILABLE = TRUE;
               SELECT_TO(RTN_LIST);
            }
         }
         else
         {
            LIST_AVAILABLE = FALSE;
         }
         return;
         //*********************************************
      }
      void L0200()
      {
         //  GET THE COUNT OF THE NUMBER OF ITEMS  *
         //*********************************************
         EXECUTE("SAVE-LIST TEMP.", string.Empty, string.Empty, string.Empty, string.Empty);
         EXECUTE("GET-LIST TEMP.", string.Empty, string.Empty, string.Empty, string.Empty);
         LIST_AVAILABLE = 0;
         EOF = FALSE;
         do
         {
            if (!READNEXT(ref ID, 0, 0, "")) { EOF = TRUE; }
            if (EOF) break;
            LIST_AVAILABLE = LIST_AVAILABLE + 1;
         } while (true);
         EXECUTE("GET-LIST TEMP.", string.Empty, string.Empty, string.Empty, string.Empty);
         SELECT_TO(RTN_LIST);
         EXECUTE("DELETE-LIST TEMP.", string.Empty, string.Empty, string.Empty, string.Empty);
         return;
         //**************************
         //    END OF INCLUDE CODE  *
         //**************************

         #endregion
         //    END OF PROGRAM  *
      }
   }
}
