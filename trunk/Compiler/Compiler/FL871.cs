//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL871 : UvBase
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
      UvVar INTERACT = "";
      UvVar REV_VID = "";
      UvVar NRM_VID = "";
      UvVar PROG_MESS = "";
      UvVar PROGRAM = "";
      FL019 FL019;
      UvVar ANS = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL871(ref UvVar INTERACT)
      {
         this.INTERACT = INTERACT;
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
         /*     CHECK IF USER REALLY WANTS TO ABANDON�1.0 */
         PROGRAM = "FL871";
         /* *************************** */
         /*     MAIN PROCESS SECTION  * */
         /* *************************** */
         if (PROG_MESS[2] == 2)
         {
            PRINT(AT(78, 23) + NRM_VID);
            PRINT(AT(1, 23) + REV_VID);
            PRINT(AT(2, 23) + SPACE(76));
            PRINT(AT(5, 23) + "ARE YOU SURE YOU WANT TO ABANDON? (Y/N) ");
            nrf0 = 3;
            FL019 = new FL019(ref nrf0, ref ANS);
            PRINT(AT(0, 23) + NRM_VID);
            PRINT(AT(0, 23) + COMMON.EOS);
            if (ANS == "Y")
            {
               INTERACT = EXIT;
            }
            else
            {
               INTERACT = INVALID_DATA;
            }
         }
         else
         {
            INTERACT = EXIT;
         }
         return;
         /* ********************* */
         /*     END OF PROGRAM  * */
         /* ********************* */
      }
   }
}
