//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL002 : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] FILE_NAME = new UvVar[150];
      UvVar[] USER_FILE_NAME = new UvVar[20];
      #endregion
      #region Variables
      UvVar USER_FILES = "";
      UvVar ALL_CLEAR = "";
      UvVar TRANS_LOG_REC = "";
      UvVar PROGRAM = "";
      UvVar UNUSED_FILE = "";
      UvVar SYSTEM_FILES = "";
      UvVar USER_DEFINED_FILES = "";
      UvVar QPOINTER = "";
      UvVar MASTER = "";
      UvVar ERR = "";
      UvVar MD = "";
      UvVar FILE_NO = "";
      UvVar USER_FILE_NO = "";
      FLTX2 FLTX2;
      UvVar FILE = "";
      UvVar ANS = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL002()
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
         // OPENS ALL FILES
         PROGRAM = "FL002";
         UNUSED_FILE = "UNUSED.FILE";
         MAT(ref FILE_NAME, "");
         MAT(ref USER_FILE_NAME, "");
         SYSTEM_FILES = "FL.SYSTEM.FILES";
         USER_DEFINED_FILES = "FL.USER.FILES";
         QPOINTER = "";
         QPOINTER[1] = "Q";
         QPOINTER[9] = "L";
         QPOINTER[10] = 10;
         if (!(OPEN("FL.CONTROL", out MASTER)))
         {
            ERR = 1;
            goto L30;
         }
         if (!(OPEN("MD", out MD)))
         {
            ERR = 2;
            goto L30;
         }
         if (!(MATREAD(ref FILE_NAME, MASTER, SYSTEM_FILES)))
         {
            PRINTCR("!!!!!  ERROR  !!!!!");
            PRINT();
            PRINTCR("UNABLE TO READ 'FL.SYSTEM.FILES' ITEM FROM FL.CONTROL FILE");
            PRINT();
            PRINTCR("CONTACT THE SUPERVISOR FOR REMEDY");
            PRINT();
            PRINT();
            STOP();
         }
         //   OPEN ALL THE SYSTEM FILES   *
         for (FILE_NO = 1; FILE_NO <= 120; FILE_NO += 1)
         {
            if (FILE_NAME[FILE_NO] == "") { goto L10; }
            if (FILE_NAME[FILE_NO] != UNUSED_FILE)
            {
               // BEGIN CASE
               if (FILE_NAME[FILE_NO].Substring(1, 4) == "DICT")
               {
                  FILE_NAME[FILE_NO] = FILE_NAME[FILE_NO].Substring(6, LEN(FILE_NAME[FILE_NO]) - 5);
                  if (!(OPENDICT(FILE_NAME[FILE_NO], out COMMON.FILES[FILE_NO])))
                  {
                     ERR = 3;
                     goto L30;
                  }
               }
               else if (OTHERWISE)
               {
                  // DATA LEVEL FILES
                  if (!(OPEN(FILE_NAME[FILE_NO], out COMMON.FILES[FILE_NO])))
                  {
                     ERR = 4;
                     goto L30;
                  }
               }
            }
         }
      //* User Defined Files **
      L10:
         if (!(MATREAD(ref USER_FILE_NAME, MASTER, USER_DEFINED_FILES)))
         {
            PRINTCR("!!!!!  ERROR  !!!!!");
            PRINT();
            PRINTCR("UNABLE TO READ 'FL.USER.FILES' ITEM FROM FL.CONTROL FILE");
            PRINT();
            PRINTCR("CONTACT FLEX FOR REMEDY");
            PRINT();
            PRINT();
            STOP();
         }
         //   Open all the user files   *
         for (USER_FILE_NO = 1; USER_FILE_NO <= 20; USER_FILE_NO += 1)
         {
            if (USER_FILE_NAME[USER_FILE_NO] == "") { goto L20; }
            // BEGIN CASE
            if (USER_FILE_NAME[USER_FILE_NO][1, 2].Substring(1, 4) == "DICT")
            {
               USER_FILE_NAME[USER_FILE_NO] = USER_FILE_NAME[USER_FILE_NO][1, 2].Substring(6, LEN(USER_FILE_NAME[USER_FILE_NO][1, 2]) - 5);
               //           OPEN 'DICT' , 'FLU.':USER.FILE.NAME(USER.FILE.NO) TO USER.FILES(USER.FILE.NO) ELSE
               QPOINTER[2] = USER_FILE_NAME[USER_FILE_NO][1, 1];
               QPOINTER[3] = USER_FILE_NAME[USER_FILE_NO][1, 2];
               TRANS_LOG_REC = QPOINTER;
               nrf0 = "W"; nrf1 = "MD"; nrf2 = "FLU."; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
               if (!(OPENDICT(USER_FILE_NAME[USER_FILE_NO], out COMMON.USER_FILES[USER_FILE_NO])))
               {
                  ERR = 5;
                  goto L30;
               }
            }
            else if (OTHERWISE)
            {
               // DATA LEVEL FILES
               //           OPEN 'FLU.':USER.FILE.NAME(USER.FILE.NO)<1,2> TO USER.FILES(USER.FILE.NO) ELSE
               QPOINTER[2] = USER_FILE_NAME[USER_FILE_NO][1, 1];
               QPOINTER[3] = USER_FILE_NAME[USER_FILE_NO][1, 2];
               TRANS_LOG_REC = QPOINTER;
               nrf0 = "W"; nrf1 = "MD"; nrf2 = "FLU."; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref nrf2);
               if (!(OPEN("FLU." + USER_FILE_NAME[USER_FILE_NO][1, 2], out COMMON.USER_FILES[USER_FILE_NO])))
               {
                  ERR = 6;
                  goto L30;
               }
            }
         }
      L20:
         ALL_CLEAR = 1;
         // PROG HAS TERMINATED SUCCESSFULLY
         goto L40;
      L30:
         PRINT(COMMON.WASH);
         PRINTCR(AT(10, 10) + "OPEN FILE ERROR !!!!!!!!!!!!");
         // BEGIN CASE
         if (ERR == 1)
         {
            FILE = "FL.CONTROL";
         }
         else if (ERR == 2)
         {
            FILE = "MD";
         }
         else if (ERR == 3 || ERR == 4)
         {
            FILE = FILE_NAME[FILE_NO] + "  - (SYSTEM FILE)";
         }
         else if (ERR == 5 || ERR == 6)
         {
            FILE = USER_FILE_NAME[USER_FILE_NO][1, 2] + "  - (USER FILE)";
         }
         PRINTCR(AT(10, 12) + "UNABLE TO OPEN FILE -  " + FILE);
         PRINTCR(AT(10, 14) + "CONTACT COMPUTER SECTION IMMEDIATELY");
         PRINT(AT(10, 18) + "PRESS <RETURN>");
         INPUT(out ANS, 2);
         if (LEN(ANS) > 1) { PRINT(AT(-9) + " "); ANS = ANS.Substring(1, 1); }
         ALL_CLEAR = FALSE;
      // PROG HAS TERMINATED UNSUCCESSFULLY
      L40:
         return;
      }
   }
}
