//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL133 : UvBase
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
      #endregion
      #region Variables
      UvVar MODULE = "";
      UvVar AUTHID = "";
      UvVar MACHINE_TYPE = "";
      UvVar TODAYS_DATE = "";
      UvVar ALL_CLEAR = "";
      UvVar PROGRAM = "";
      UvVar SERIAL = "";
      UvVar HEX_SERIAL = "";
      UvVar CONLOOP = "";
      UvVar HEX_VALUE = "";
      UvVar FLEX = "";
      UvVar KEY = "";
      UvVar DATE_EXP = "";
      #endregion
      public FL133(ref UvVar MODULE, ref UvVar AUTHID)
      {
         this.MODULE = MODULE;
         this.AUTHID = AUTHID;
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
         // CHECK WE'RE ON THE RIGHT MACHINE
         PROGRAM = "FL133";
         // File used
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         //**
         // Get Machine Type
         // and Serial Number
         //**
         SERIAL = 0;
         // BEGIN CASE
         // CASE
         if (MACHINE_TYPE == "PCPICK")
         {
            HEX_SERIAL = OCONV(0, "U713C");
         }// CASE
         else if (MACHINE_TYPE == "UNIVERSE")
         {
            HEX_SERIAL = "FLEX";
            if (MODULE == "FLEX")
            {
               PRINT("What is the Hex Serial Number of the Site ");
               INPUTCR(out HEX_SERIAL);
               if (HEX_SERIAL == ".") { return; }
               if (HEX_SERIAL == "")
               {
                  PRINT("Enter Universe OR M9000 serial number : ");
                  INPUTCR(out SERIAL);
               }
            }
            else
            {
               return;
               // Universe Sites Return without s/n
            }
         }// CASE
         else if (MACHINE_TYPE == "M9000")
         {
            SERIAL = OCONV(0, "U10DD");
         }// CASE
         else if (OTHERWISE)
         {
            HEX_SERIAL = "FLEXSYSTEMS";
         }
         // END CASE
         //*
         // CONVERT TO DECIMAL
         //*
         if (SERIAL == 0)
         {
            for (CONLOOP = 1; CONLOOP <= LEN(HEX_SERIAL); CONLOOP += 1)
            {
               HEX_VALUE = HEX_SERIAL.Substring(CONLOOP, 1);
               // BEGIN CASE
               // CASE
               if (MATCH(HEX_VALUE, "0N"))
               {
                  SERIAL = (SERIAL * 16) + HEX_VALUE;
               }// CASE
               else if (HEX_VALUE >= "A" && HEX_VALUE <= "F")
               {
                  SERIAL = (SERIAL * 16) + SEQ(HEX_VALUE) - 55;
               }// CASE
               else if (HEX_VALUE >= "a" && HEX_VALUE <= "f")
               {
                  SERIAL = (SERIAL * 16) + SEQ(HEX_VALUE) - 55;
               }// CASE
               else if (OTHERWISE)
               {
                  SERIAL = (SERIAL * 16) + 1;
               }
               // END CASE
            }
         }
         //*
         //*
         SERIAL = (SERIAL * 7) - 1000000;
         if (MODULE == "FLEX")
         {
            CRTCR(SERIAL + " Authorised");
            INPUTCR(out FLEX);
            WRITE(SERIAL, COMMON.FILES[FL_CONTROL], AUTHID);
            return;
         }
         if (!(READ(ref KEY, COMMON.FILES[FL_CONTROL], AUTHID)))
         {
            PRINT(COMMON.WASH);
            PRINTCR("SYSID = " + HEX_SERIAL);
            PRINT();
            PRINTCR("*** " + MODULE + "***");
            PRINT();
            PRINTCR("Is an Unauthorised Module");
            PRINT();
            PRINTCR("Call Flex Systems Ltd");
            PRINT();
            PRINTCR("01474 740030");
            INPUT(out FLEX, 1);
            goto L10;
         }
         DATE_EXP = KEY[1, 2];
         KEY = KEY[1, 1];
         if (DATE_EXP != "")
         {
            if (DATE_EXP > TODAYS_DATE)
            {
               KEY = "";
            }
         }
         if (SERIAL != KEY)
         {
            PRINTCR(COMMON.WASH);
            PRINTCR("*** " + MODULE + " ***");
            PRINT();
            PRINTCR("Has an invalid Access Code");
            PRINT();
            PRINTCR("Call Flex Systems Ltd");
            PRINT();
            PRINTCR("01474 740030");
            INPUT(out FLEX, 1);
            goto L10;
         }
         ALL_CLEAR = 1;
         goto L50;
      L10:
         // Logoff the culprit
         CHAIN("OFF");
         STOP();
      L50:
         // The End
         return;
      }
   }
}
