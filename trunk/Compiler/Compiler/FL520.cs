//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL520 : UvBase
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
      UvVar[] COL = new UvVar[64];
      #endregion
      #region Variables
      UvVar PALETTE_NO = "";
      UvVar COLOUR = "";
      UvVar ATTRIBUTE = "";
      UvVar FILES = "";
      UvVar DATA_REC = "";
      UvVar ITEM_ID = "";
      UvVar USER_FILES = "";
      UvVar SP = "";
      UvVar TICKET_CODES = "";
      UvVar TICKET_CODES_POSITIONS = "";
      UvVar TICKET_CODES_USED = "";
      UvVar ESC = "";
      UvVar COLOUR_LIST = "";
      UvVar POS = "";
      UvVar RED = "";
      UvVar GREEN = "";
      UvVar BLUE = "";
      FL521 FL521;
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      UvVar nrf3 = "";
      #endregion
      public FL520(ref UvVar PALETTE_NO, ref UvVar COLOUR, ref UvVar ATTRIBUTE)
      {
         this.PALETTE_NO = PALETTE_NO;
         this.COLOUR = COLOUR;
         this.ATTRIBUTE = ATTRIBUTE;
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
         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         // BEGIN CASE
         if (COMMON.TERMINAL_TYPE == "I")
         {
            L0100();
         }
         else if (COMMON.TERMINAL_TYPE == "W" || COMMON.TERMINAL_TYPE == "S")
         {
            PRINT(ESC + "m" + PALETTE_NO + COLOUR + ATTRIBUTE);
         }
         return;
      }
      void L0100()
      {
         COLOUR_LIST = "!\"" + "*2#$9:+;,<3=>4%@?\\`(]^_'abcdef-g.hijkl/m0nopqr5st6uvwxyz{|7}~8";
         COL[1] = "000";
         COL[2] = "001";
         COL[3] = "002";
         COL[4] = "003";
         COL[5] = "010";
         COL[6] = "011";
         COL[7] = "012";
         COL[8] = "013";
         COL[9] = "020";
         COL[10] = "021";
         COL[11] = "022";
         COL[12] = "023";
         COL[13] = "030";
         COL[14] = "031";
         COL[15] = "032";
         COL[16] = "033";
         COL[17] = "100";
         COL[18] = "101";
         COL[19] = "102";
         COL[20] = "103";
         COL[21] = "110";
         COL[22] = "111";
         COL[23] = "112";
         COL[24] = "113";
         COL[25] = "120";
         COL[26] = "121";
         COL[27] = "122";
         COL[28] = "123";
         COL[29] = "130";
         COL[30] = "131";
         COL[31] = "132";
         COL[32] = "133";
         COL[33] = "200";
         COL[34] = "201";
         COL[35] = "202";
         COL[36] = "203";
         COL[37] = "210";
         COL[38] = "211";
         COL[39] = "212";
         COL[40] = "213";
         COL[41] = "220";
         COL[42] = "221";
         COL[43] = "222";
         COL[44] = "223";
         COL[45] = "230";
         COL[46] = "231";
         COL[47] = "232";
         COL[48] = "233";
         COL[49] = "300";
         COL[50] = "301";
         COL[51] = "302";
         COL[52] = "303";
         COL[53] = "310";
         COL[54] = "311";
         COL[55] = "312";
         COL[56] = "313";
         COL[57] = "320";
         COL[58] = "321";
         COL[59] = "322";
         COL[60] = "323";
         COL[61] = "330";
         COL[62] = "331";
         COL[63] = "332";
         COL[64] = "333";
         POS = INDEX(COLOUR_LIST, COLOUR, 1);
         if (POS > 0)
         {
            RED = COL[POS].Substring(1, 1) * 21;
            GREEN = COL[POS].Substring(2, 1) * 21;
            BLUE = COL[POS].Substring(3, 1) * 21;
            if (PALETTE_NO == 6) { PALETTE_NO = 20; }
            FL521 = new FL521(ref PALETTE_NO, ref RED, ref GREEN, ref BLUE);
            nrf0 = 56;
            nrf1 = 0;
            nrf2 = 0;
            nrf3 = 0;
            FL521 = new FL521(ref nrf0, ref nrf1, ref nrf2, ref nrf3);
         }
         return;
      }
   }
}
