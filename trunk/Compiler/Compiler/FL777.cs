//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL777 : UvBase
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
      UvVar[] OPTIONS = new UvVar[3];
      #endregion
      #region Variables
      UvVar AM = "";
      UvVar TRANS_LOG_REC = "";
      UvVar TX_ATT = "";
      UvVar BACK_SLASH = "";
      UvVar STOP_DEMO = "";
      UvVar DEMO_DELAY = "";
      UvVar DISPLAY_PORT = "";
      UvVar WAIT = "";
      UvVar SPORTS_KEY = "";
      UvVar DEMO_SPORTS = "";
      UvVar OPTION = "";
      FLTX2 FLTX2;
      UvVar NEW_TIME = "";
      UvVar LINE = "";
      UvVar ACTIVITIES = "";
      UvVar ALTER = "";
      UvVar NEW_ACT = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL777()
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
         /*  DISPLAY CONTROL */
         BACK_SLASH = "\\";
         MAT(ref OPTIONS, "");
         OPTIONS[1] = "DISPLAY";
         OPTIONS[2] = "SUSPEND";
         OPTIONS[3] = "STOP";
         if (!(READV(ref STOP_DEMO, COMMON.FILES[FL_CONTROL], "STOP.DEMO", 1)))
         {
            STOP_DEMO = 0;
         }
         if (!(READV(ref DEMO_DELAY, COMMON.FILES[FL_CONTROL], "DEMO.DELAY", 1)))
         {
            DEMO_DELAY = 10;
         }
         if (!(READV(ref DISPLAY_PORT, COMMON.FILES[FL_CONTROL], COMMON.CENTRE + "*DISPLAY.PORT", 1)))
         {
            PRINT(COMMON.WASH);
            PRINT(AT(10, 10) + "DISPLAY PORT NOT SET UP ");
            INPUTCR(out WAIT, 1);
            return;
         }
         SPORTS_KEY = COMMON.CENTRE + "*DEMO.SPORTS";
         if (!(READ(ref DEMO_SPORTS, COMMON.FILES[FL_CONTROL], SPORTS_KEY)))
         {
            DEMO_SPORTS = "BAD";
         }
      L10: ;
         /*  Start */
         PRINT(COMMON.WASH);
         PRINTCR("LeisureFlex II Display Control");
         PRINTCR("==============================");
         PRINT();
         PRINT();
         PRINTCR("1. DISPLAY");
         PRINTCR("2. SUSPEND");
         PRINTCR("3. STOP");
         PRINTCR("4. REFRESH TIME");
         PRINTCR("5. AMEND ACTIVITIES");
         PRINTCR("6. CLEAR   DISPLAY PORT");
         PRINTCR("7. RESTART DISPLAY PORT");
         PRINT();
         PRINTCR("Currently set to : " + OPTIONS[STOP_DEMO + 1]);
         PRINT();
         PRINT("Input Option ");
         INPUTCR(out OPTION, 2);
         // BEGIN CASE
         // CASE
         if (OPTION == "" || OPTION == COMMON.ABANDON)
         {
            goto L20;
         }// CASE
         else if (OPTION == 1)
         {
            L100();
         }// CASE
         else if (OPTION == 2)
         {
            L100();
         }// CASE
         else if (OPTION == 3)
         {
            L100();
         }// CASE
         else if (OPTION == 4)
         {
            L200();
         }// CASE
         else if (OPTION == 5)
         {
            L300();
         }// CASE
         else if (OPTION == 6)
         {
            L400();
         }// CASE
         else if (OPTION == 7)
         {
            L500();
         }// CASE
         else if (OTHERWISE)
         {
         }
         // END CASE
         goto L10;
      L20: ;
         /*  END */
         return;
      }
      void L100()
      {
         /*  Display Status */
         STOP_DEMO = OPTION - 1;
         TRANS_LOG_REC = STOP_DEMO;
         TX_ATT = 1;
         nrf0 = "WV"; nrf1 = "FL.CONTROL"; nrf2 = "STOP.DEMO"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
         PRINT("Status has been updated ");
         INPUTCR(out WAIT, 2);
         return;
      }
      void L200()
      {
         /*  Update the delay */
         PRINTCR("Time Refresh Delay currently is : " + DEMO_DELAY + " seconds ");
         PRINT("Input the delay you require ");
         INPUTCR(out NEW_TIME, 3);
         // BEGIN CASE
         // CASE
         if (NEW_TIME == "")
         {
         }// CASE
         else if (NOT(NUM(NEW_TIME)))
         {
         }// CASE
         else if (NEW_TIME > 0 && NEW_TIME < 999)
         {
            DEMO_DELAY = NEW_TIME;
            TRANS_LOG_REC = DEMO_DELAY;
            TX_ATT = 1;
            nrf0 = "WV"; nrf1 = "FL.CONTROL"; nrf2 = "DEMO.DELAY"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
            PRINTCR("New Time is set to : " + NEW_TIME + " seconds ");
            INPUTCR(out WAIT, 1);
         }// CASE
         else if (OTHERWISE)
         {
         }
         // END CASE
         return;
      }
      void L300()
      {
      /*  Activities List */
      L301:
         ;
         PRINTCR("List of Activities to Display ");
         PRINTCR("=============================");
         PRINT();
         LINE = 1;
         ACTIVITIES = DCOUNT(DEMO_SPORTS, AM);
         do
         {
            if (LINE > ACTIVITIES) break;
            PRINTCR((FORMAT(LINE, "R#2")) + ". " + DEMO_SPORTS[LINE]);
            LINE = LINE + 1;
         } while (true);
         PRINT("What Line do you wish to alter ");
         INPUTCR(out ALTER, 3);
         if (ALTER != "")
         {
            PRINT("To What ");
            INPUTCR(out NEW_ACT, 5);
            if (NEW_ACT == "")
            {
               return;
            }
            if (NEW_ACT == BACK_SLASH)
            {
               DEMO_SPORTS = DELETE(DEMO_SPORTS, ALTER);
            }
            else
            {
               if (ALTER.Substring(1, 1) == "I")
               {
                  ALTER = ALTER.Substring(2, 999);
                  if (ALTER > ACTIVITIES + 1)
                  {
                     ALTER = ACTIVITIES + 1;
                  }
                  //DEMO_SPORTS = INSERT(DEMO_SPORTS, ALTER);
                  //NEW_ACT
               }
               else
               {
                  if (ALTER > ACTIVITIES + 1)
                  {
                     ALTER = ACTIVITIES + 1;
                  }
                  DEMO_SPORTS[ALTER] = NEW_ACT;
               }
            }
            TRANS_LOG_REC = DEMO_SPORTS;
            nrf0 = "W"; nrf1 = "FL.CONTROL"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref SPORTS_KEY);
            goto L301;
         }
         return;
      }
      void L400()
      {
         /*  Logoff Port */
         DATA(DISPLAY_PORT);
         EXECUTE("LOGOFF", string.Empty, string.Empty, string.Empty, string.Empty);
         return;
      }
      void L500()
      {
         /*  Logon port remotely */
         DATA(DISPLAY_PORT + ",LF.DEMO");
         EXECUTE("LOGON", string.Empty, string.Empty, string.Empty, string.Empty);
         return;
      }
   }
}
