//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL0001_110 : UvBase
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
      readonly UvVar FL_FUNCTION_KEYS = 84;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Variables
      UvVar PROGRAM_NAME = "";
      UvVar FUNCTION_KEY_CONVERT = "";
      UvVar TERMINAL_TYPE = "";
      UvVar MACHINE_TYPE = "";
      UvVar EXECUTE_PROG = "";
      UvVar PROGRAM = "";
      UvVar DDD = "";
      UvVar ESCZ = "";
      UvVar INSTRUCTION = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGES = "";
      UvVar OTHERS = "";
      CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
      UvVar IDENT = "";
      UvVar KEY_TO_LOAD = "";
      UvVar KEY_REC = "";
      UvVar LOAD_LOOP = "";
      UvVar KEY_TO_PROGRAME = "";
      UvVar KEY = "";
      UvVar SHIFTED_KEY = "";
      UvVar IS_IT_THERE = "";
      UvVar NORM = "";
      UvVar SHIFTED = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL0001_110(ref UvVar PROGRAM_NAME, ref UvVar FUNCTION_KEY_CONVERT)
      {
         this.PROGRAM_NAME = PROGRAM_NAME;
         this.FUNCTION_KEY_CONVERT = FUNCTION_KEY_CONVERT;
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
         // ASSIGN FUNCTION KEYS TO USERS VALUES
         EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
         //********************
         // SET UP FILES USED *
         //********************
         //***************************
         // SET UP PROGRAM CONSTANTS *
         //***************************
         PROGRAM = "FL0001.1100";
         DDD = CHAR(127);
         ESCZ = CHAR(27) + "z";
         FUNCTION_KEY_CONVERT = "";
         //***************
         // MAIN PROCESS *
         //***************
         if (TERMINAL_TYPE != "I" && TERMINAL_TYPE != "M" && TERMINAL_TYPE != "S")
         {
            L100();
         }
         else
         {
            if (MACHINE_TYPE != "UNIVERSE")
            {
               INSTRUCTION = "SET-FUNC FL.FUNCTION.KEYS TERM*I*FUNCTION.KEYS";
               nrf0 = "O";
               CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref INSTRUCTION, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
            }
            IDENT = COMMON.CENTRE + "*" + PROGRAM_NAME + "*CONVERT*I";
            if (!(READ(ref FUNCTION_KEY_CONVERT, COMMON.FILES[FL_FUNCTION_KEYS], IDENT)))
            {
               FUNCTION_KEY_CONVERT = "";
            }
         }
         //****************************
         // RETURN TO CALLING ROUTINE *
         //****************************
         return;
      }
      void L100()
      {
         // MAIN SUBROUTINE *
         //******************
         KEY_TO_LOAD = 0;
         if (!(READ(ref KEY_REC, COMMON.FILES[FL_FUNCTION_KEYS], COMMON.CENTRE + "*" + PROGRAM_NAME)))
         {
            KEY_REC = INIT;
            KEY_REC[1] = "f1#";
            KEY_REC[3] = "f2#";
            KEY_REC[5] = "f3#";
            KEY_REC[7] = "f4#";
            KEY_REC[9] = "f5#";
            KEY_REC[11] = "f6#";
            KEY_REC[13] = "f7#";
            KEY_REC[15] = "f8#";
            KEY_REC[17] = "f9#";
            KEY_REC[19] = "fA#";
            KEY_REC[21] = "fB#";
            KEY_REC[23] = "fC#";
            KEY_REC[25] = "fD#";
            KEY_REC[27] = "fE#";
            KEY_REC[29] = "fF#";
            KEY_REC[31] = "f0#";
            //        RETURN
         }
         for (LOAD_LOOP = 0; LOAD_LOOP <= 31; LOAD_LOOP += 2)
         {
            KEY_TO_PROGRAME = LOAD_LOOP + 1;
            KEY_TO_LOAD = KEY_TO_LOAD + 1;
            KEY = CHAR(KEY_TO_LOAD + 63);
            SHIFTED_KEY = CHAR(KEY_TO_LOAD + 95);
            if (KEY_REC[KEY_TO_PROGRAME] != "")
            {
               IS_IT_THERE = DCOUNT(KEY_REC[KEY_TO_PROGRAME], "#");
               if (IS_IT_THERE > 1)
               {
                  KEY_REC[KEY_TO_PROGRAME] = FIELD(KEY_REC[KEY_TO_PROGRAME], "#", 1) + CHAR(13);
               }
               NORM = ESCZ + KEY + KEY_REC[KEY_TO_PROGRAME] + DDD;
            }
            else
            {
               NORM = ESCZ + KEY + " " + DDD;
            }
            if (KEY_REC[KEY_TO_PROGRAME + 1] != "")
            {
               IS_IT_THERE = 0;
               IS_IT_THERE = DCOUNT(KEY_REC[KEY_TO_PROGRAME + 1], "#");
               if (IS_IT_THERE > 1) { KEY_REC[KEY_TO_PROGRAME + 1] = FIELD(KEY_REC[KEY_TO_PROGRAME + 1], "#", 1) + CHAR(13); }
               SHIFTED = ESCZ + SHIFTED_KEY + KEY_REC[KEY_TO_PROGRAME + 1] + DDD;
            }
            else
            {
               SHIFTED = ESCZ + SHIFTED_KEY + " " + DDD;
            }
            PRINT(NORM);
            PRINT(SHIFTED);
         }
         return;
         //*******************
         // END FOR COMPILER *
         //*******************
      }
   }
}
