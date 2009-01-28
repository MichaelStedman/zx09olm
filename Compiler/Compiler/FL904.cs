//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL904 : UvBase
   {
      #region Variables
      UvVar PROGRAM = "";
      UvVar MD = "";
      UvVar UPDATE_PROC = "";
      #endregion
      public FL904()
      {
         /*  Routine to update account by executing a PROC */
         /*  MUST be added to the login proc to run prior to FL000 */
         /*  The user will see the proc running */
         if (!OPEN("MD", out MD)) { STOP(); }
         if (READ(ref UPDATE_PROC, MD, "FLEX.UPDATE.ACCOUNT.PROC"))
         {
            PRINT(AT(-1));
            PRINT(AT(10, 5) + "Now updating the account with current changes - Please wait");
            EXECUTE("FLEX.UPDATE.ACCOUNT.PROC", string.Empty, string.Empty, string.Empty, string.Empty);
            DELETE(MD, "FLEX.UPDATE.ACCOUNT.PROC");
         }
         STOP();
      }
   }
}
