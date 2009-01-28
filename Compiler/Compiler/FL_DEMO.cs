//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_DEMO : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_CENTRES = 3;
      readonly UvVar FL_CONTROL = 10;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar U_INITS = "";
      UvVar TODAYS_DATE = "";
      UvVar REV_VID = "";
      UvVar NRM_VID = "";
      UvVar AM = "";
      UvVar VM = "";
      FL004 FL004;
      FL001 FL001;
      FL002 FL002;
      FL000_4 FL000_4;
      FL0002_910 FL0002_910;
      UvVar CNT = "";
      UvVar FINISH = "";
      UvVar SP_LOCS = "";
      UvVar DEMO_SPORTS = "";
      UvVar CENTRE_SPORTS = "";
      UvVar SPORTS = "";
      UvVar SPRT = "";
      UvVar FIRST_TIME = "";
      UvVar FOREVER = "";
      UvVar DSCNT = "";
      UvVar TOLD_TO_SUSPEND = "";
      FL473 FL473;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      //     SUBROUTINE FL.DEMO
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
      // SPORT DISPLAY
      public FL_DEMO()
      {
         FL004 = new FL004();
         FL001 = new FL001();
         FL002 = new FL002();
         FL000_4 = new FL000_4();
         U_INITS = "";
         nrf0 = FALSE;
         FL0002_910 = new FL0002_910(ref nrf0);
         CNT = 0;
         // Files
         FINISH = 2;
         L100();
         SP_LOCS = 1;
         if (!(READ(ref DEMO_SPORTS, COMMON.FILES[FL_CONTROL], COMMON.CENTRE + "*" + "DEMO.SPORTS")))
         {
            SP_LOCS = 2;
            if (!(READV(ref CENTRE_SPORTS, COMMON.FILES[FL_CENTRES], COMMON.CENTRE, 3)))
            {
               SP_LOCS = 3;
            }
         }
         if (SP_LOCS == 1)
         {
            SPORTS = DCOUNT(DEMO_SPORTS, AM);
         }
         else
         {
            if (SP_LOCS == 2)
            {
               SPORTS = DCOUNT(CENTRE_SPORTS, VM);
               DEMO_SPORTS = INIT;
               for (SPRT = 1; SPRT <= SPORTS; SPRT += 1)
               {
                  DEMO_SPORTS[SPRT] = CENTRE_SPORTS[1, SPRT];
               }
            }
         }
         FIRST_TIME = TRUE;
         FOREVER = FALSE;
         do
         {
            if (FOREVER) break;
            TODAYS_DATE = DATE();
            DSCNT = 1;
            do
            {
               if (DSCNT > SPORTS || TOLD_TO_SUSPEND) break;
               DATA(DEMO_SPORTS[DSCNT]);
               FL473 = new FL473(ref DEMO_SPORTS, ref DSCNT, ref FIRST_TIME);
               DSCNT = DSCNT + 1;
               L100();
            } while (true);
            if (TOLD_TO_SUSPEND)
            {
               PRINT(COMMON.WASH);
               PRINT(AT(53, 10) + NRM_VID);
               PRINT(AT(20, 10) + REV_VID + " Availability Display Suspended ");
               do
               {
                  if (NOT(TOLD_TO_SUSPEND)) break;
                  L100();
                  if (TOLD_TO_SUSPEND == FINISH)
                  {
                     CHAIN("OFF");
                  }
               } while (true);
            }
         } while (true);
      }
      void L100()
      {
         // Check Suspense Flag
         if (!(READV(ref TOLD_TO_SUSPEND, COMMON.FILES[FL_CONTROL], "STOP.DEMO", 1)))
         {
            TOLD_TO_SUSPEND = FALSE;
         }
         return;
         return;
      }
   }
}
