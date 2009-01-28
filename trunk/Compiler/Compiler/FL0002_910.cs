//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL0002_910 : UvBase
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
      #region Variables
      UvVar FULL_COLOUR = "";
      UvVar TERMINAL_TYPE = "";
      UvVar U_INITS = "";
      UvVar DIM_REV_UND_VID = "";
      UvVar COLOR_C = "";
      UvVar DISP_LINE = "";
      UvVar PROGRAM = "";
      UvVar FULL_COLOR_TERMINAL = "";
      UvVar MONO_PC = "";
      UvVar ESC = "";
      UvVar ESCG = "";
      UvVar COLORS = "";
      FL006 FL006;
      FL520 FL520;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      #endregion
      public FL0002_910(ref UvVar FULL_COLOUR)
      {
         this.FULL_COLOUR = FULL_COLOUR;
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
         // SPECIAL FOR RESETTING SCREEN (LFLEX & TFLEX CORESIDENT)
         //RETURN
         PROGRAM = "FL0002.910";
         if (!(READV(ref FULL_COLOR_TERMINAL, COMMON.FILES[FL_CONTROL], "FULL.COLOUR.TERMINAL", 1)))
         {
            FULL_COLOR_TERMINAL = "N";
         }
         if (FULL_COLOR_TERMINAL != "Y")
         {
            FULL_COLOUR = FALSE;
            return;
         }
         FULL_COLOUR = TRUE;
         if (!READ(ref MONO_PC, COMMON.FILES[FL_CONTROL], "MONO.PC")) { MONO_PC = ""; }
         PRINT(COMMON.WASH);
         ESC = CHAR(27);
         ESCG = ESC + "G";
         PRINT(ESC + "%?");
         // DEFINE COLORS USED WITHIN THE PROCESS *
         PRINT(AT(0, 23) + DISP_LINE);
         if (TERMINAL_TYPE == "I" && MONO_PC[9] == "Y")
         {
            COLORS = MONO_PC;
         }
         else
         {
            if (!(READ(ref COLORS, COMMON.FILES[FL_CONTROL], U_INITS + "*COLOURS.TO.USE")))
            {
               if (!(READ(ref COLORS, COMMON.FILES[FL_CONTROL], "COLOURS.TO.USE")))
               {
                  nrf0 = 1;
                  nrf1 = "";
                  FL006 = new FL006(ref PROGRAM, ref nrf0, ref nrf1);
                  STOP();
               }
            }
         }
         //     PRINT ESC:'m0':COLORS<1,1>:'-':
         nrf0 = 0;
         nrf1 = COLORS[1, 1];
         nrf2 = COLORS[1, 2];
         FL520 = new FL520(ref nrf0, ref nrf1, ref nrf2);
         //     COLOR.X = ESC:'0'
         //     PRINT ESC:'m1':COLORS<2,1>:COLORS<2,2>:
         nrf0 = 1;
         nrf1 = COLORS[2, 1];
         nrf2 = COLORS[2, 2];
         FL520 = new FL520(ref nrf0, ref nrf1, ref nrf2);
         //     COLOR.BAR = ESC:'4'
         //     PRINT ESC:'m2':COLORS<3,1>:COLORS<3,2>:
         nrf0 = 2;
         nrf1 = COLORS[3, 1];
         nrf2 = COLORS[3, 2];
         FL520 = new FL520(ref nrf0, ref nrf1, ref nrf2);
         //     COLOR.A = ESC:'p'
         //     PRINT ESC:'m3':COLORS<4,1>:COLORS<4,2>:
         nrf0 = 3;
         nrf1 = COLORS[4, 1];
         nrf2 = COLORS[4, 2];
         FL520 = new FL520(ref nrf0, ref nrf1, ref nrf2);
         //     COLOR.B = ESC:'8'
         //     PRINT ESC:'m4':COLORS<5,1>:COLORS<5,2>:
         nrf0 = 4;
         nrf1 = COLORS[5, 1];
         nrf2 = COLORS[5, 2];
         FL520 = new FL520(ref nrf0, ref nrf1, ref nrf2);
         //     COLOR.C = ESC:'t'
         //     PRINT ESC:'m5':COLORS<6,1>:COLORS<6,2>:
         nrf0 = 5;
         nrf1 = COLORS[6, 1];
         nrf2 = COLORS[6, 2];
         FL520 = new FL520(ref nrf0, ref nrf1, ref nrf2);
         //     COLOR.D = ESC:'<'
         //     PRINT ESC:'m6':COLORS<7,1>:COLORS<7,2>:
         nrf0 = 6;
         nrf1 = COLORS[7, 1];
         nrf2 = COLORS[7, 2];
         FL520 = new FL520(ref nrf0, ref nrf1, ref nrf2);
         //     COLOR.E = ESC:'x'
         //     PRINT ESC:'m7':COLORS<8,1>:COLORS<8,2>:
         nrf0 = 7;
         nrf1 = COLORS[8, 1];
         nrf2 = COLORS[8, 2];
         FL520 = new FL520(ref nrf0, ref nrf1, ref nrf2);
         //     COLOR.F = ESC:''
         //!BEGIN CASE
         //!CASE TERMINAL.TYPE = 'M'
         //!COLOR.C = DIM.REV.UND.VID
         //!CASE TERMINAL.TYPE = 'I'
         //!!!*COLOR.C = SCREEN.FOOT.FORE : SCREEN.FOOT.BACK
         //!COLOR.C = ESC:"*":CHAR(37):ESC:"*":CHAR(64)
         //!COLOR.C = DIM.REV.UND.VID
         //!CASE OTHERWISE
         //!COLOR.C = ESCG:''
         //!END CASE
         COLOR_C = DIM_REV_UND_VID;
         return;
      }
      //     COLOR.X = ESC:'0'
      //     COLOR.BAR = ESC:'4'
      //     COLOR.A = ESC:'p'
      //     COLOR.B = ESC:'8'
      //     COLOR.C = ESC:'t'
      //     COLOR.D = ESC:'<'
      //     COLOR.E = ESC:'x'
      //     COLOR.F = ESC:''
   }
}
