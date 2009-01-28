//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL521 : UvBase
   {
      #region Int Constants
      readonly UvVar PORT_ADR = 1;
      readonly UvVar PORT_BYT = 2;
      #endregion
      #region String Constants
      readonly UvVar WRIT_PORT = "UE0BA";
      #endregion
      #region Variables
      UvVar PALETTE = "";
      UvVar RED = "";
      UvVar GREEN = "";
      UvVar BLUE = "";
      UvVar HEX_STR = "";
      UvVar ERROR = "";
      UvVar PORT = "";
      UvVar BYTE = "";
      UvVar UPPER = "";
      UvVar LOWER = "";
      UvVar DA = "";
      #endregion
      public FL521(ref UvVar PALETTE, ref UvVar RED, ref UvVar GREEN, ref UvVar BLUE)
      {
         this.PALETTE = PALETTE;
         this.RED = RED;
         this.GREEN = GREEN;
         this.BLUE = BLUE;
         //    SET PALETTE 'n' TO RED, GREEN, BLUE
         HEX_STR = "0123456789ABCDEF";
         //    Make sure the arguments passed are valid
         L0200();
         // Validate arguments
         if (ERROR) { return; }
         //    Access DAC 'n'
         PORT = "03C8";
         BYTE = PALETTE;
         L0050();
         L0100();
         //    Write new colour to DAC 'n'
         PORT = "03C9";
         BYTE = RED;
         L0050();
         L0100();
         BYTE = GREEN;
         L0050();
         L0100();
         BYTE = BLUE;
         L0050();
         L0100();
         return;
         //**********************************
      }
      void L0050()
      {
         //**********************************
         UPPER = INT(BYTE / 16);
         LOWER = MOD(BYTE, 16);
         BYTE = HEX_STR.Substring(UPPER + 1, 1) + HEX_STR.Substring(LOWER + 1, 1);
         return;
         //*************************
      }
      void L0100()
      {
         //*************************
         DA = 0;
         DA[PORT_ADR] = PORT;
         DA[PORT_BYT] = BYTE;
         DA = OCONV(DA, WRIT_PORT);
         return;
         //****************************
      }
      void L0200()
      {
         //****************************
         ERROR = 0;
         // BEGIN CASE
         if (NOT(NUM(PALETTE)))
         {
            ERROR = 1;
         }
         else if (PALETTE < 0 || PALETTE > 63)
         {
            ERROR = 1;
         }
         else if (NOT(NUM(RED)))
         {
            ERROR = 1;
         }
         else if (RED < 0 || RED > 63)
         {
            ERROR = 1;
         }
         else if (NOT(NUM(GREEN)))
         {
            ERROR = 1;
         }
         else if (GREEN < 0 || GREEN > 63)
         {
            ERROR = 1;
         }
         else if (NOT(NUM(BLUE)))
         {
            ERROR = 1;
         }
         else if (BLUE < 0 || BLUE > 63)
         {
            ERROR = 1;
         }
         return;
         //**********************
         //    End of program   *
         //**********************
      }
   }
}
