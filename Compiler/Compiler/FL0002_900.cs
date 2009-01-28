//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL0002_900 : UvBase
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
      readonly UvVar MD = 58;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar AM = "";
      UvVar PROGRAM = "";
      UvVar SPECIAL_PROGS = "";
      UvVar PROGS = "";
      UvVar PROG = "";
      UvVar PROGNAME = "";
      UvVar MD_ENTRY_EXISTS = "";
      //CallAt_PROGNAME CallAt_PROGNAME;
      #endregion
      public FL0002_900()
      {
         #region INCLUDE TX.INCLUDE TX.COMMON

         #endregion
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
         // RUNS ANY SPECIAL PROGRAMS REQUIRED
         PROGRAM = "FL0002.900";
         if (!(READ(ref SPECIAL_PROGS, COMMON.FILES[FL_CONTROL], "FL.SPECIALS")))
         {
            SPECIAL_PROGS = INIT;
         }
         if (SPECIAL_PROGS == INIT) { return; }
         PROGS = DCOUNT(SPECIAL_PROGS, AM);
         for (PROG = 1; PROG <= PROGS; PROG += 1)
         {
            PROGNAME = SPECIAL_PROGS[PROG];
            if (READV(ref MD_ENTRY_EXISTS, COMMON.FILES[MD], PROGNAME, 1))
            {
               //CallAt_PROGNAME = new CallAt_PROGNAME(PROGNAME);
            }
         }
         return;
      }
   }
}
