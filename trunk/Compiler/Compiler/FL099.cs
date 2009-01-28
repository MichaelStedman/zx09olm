//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL099 : UvBase
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
      UvVar PORT_NUMBER = "";
      UvVar MACHINE_TYPE = "";
      UvVar VM = "";
      UvVar EXECUTE_PROG = "";
      UvVar COMMAND = "";
      UvVar FL_PRINTER_ASSIGNMENTS = "";
      UvVar PRINTER_ASSIGNMENTS = "";
      UvVar NUMB = "";
      UvVar QUEUE = "";
      UvVar OPTS = "";
      UvVar RTN_LIST = "";
      UvVar LIST_AVAILABLE = "";
      UvVar MESSAGES = "";
      UvVar OTHERS = "";
      CallAt_EXECUTE_PROG CallAt_EXECUTE_PROG;
      UvVar OLD_ASSIGNS = "";
      UvVar ASS_REC = "";
      UvVar SPACER = "";
      UvVar TLOOP = "";
      UvVar TILL = "";
      UvVar COMM = "";
      UvVar OLDDEST = "";
      UvVar OLDDF1 = "";
      UvVar OLDDF2 = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      #endregion
      public FL099()
      {
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
         // Assigns printer output routes
         //EXEC.FIX 05.08.92 - LBCH
         EXECUTE_PROG = "FL." + MACHINE_TYPE + ".EXECUTE";
         // This program is to be used when the system has more than
         // one system printer in operation for one Account, or the
         // port is to use the auxilliary port as a printer.
         COMMAND = "";
         // Universe Specific Adjustment
         if (MACHINE_TYPE == "UNIVERSE")
         {
            #region INCLUDE FL.FILES FL.PRINTER.ASSIGNMENTS

            if (!(OPEN("FL.PRINTER.ASSIGNMENTS", out FL_PRINTER_ASSIGNMENTS)))
            {
               STOP(201, "FL.PRINTER.ASSIGNMENTS");
            }

            #endregion
            L1000();
            //DO it
            return;
         }
         // The Item 'PRINTER.ASSIGNMENTS' has all the ports on the
         // system Multivalued in att 1, and the associated printer
         // form queue numbers or 'AUX' in att 2, also multivalued.
         // and the Hold Or Store options in att 3.
         if (!(READ(ref PRINTER_ASSIGNMENTS, COMMON.FILES[FL_CONTROL], "PRINTER.ASSIGNMENTS")))
         {
            //        PRINTER.ASSIGNMENTS = ''
            //        FOR PNO = 0 TO 8
            //           PRINTER.ASSIGNMENTS<1,PNO+1> = PNO
            //           PRINTER.ASSIGNMENTS<2,PNO+1> = 0
            //        NEXT PNO
            //        WRITE PRINTER.ASSIGNMENTS ON FL.CONTROL , 'PRINTER.ASSIGNMENTS'
            // Modification on 30/7/91 to prevent all terminals being assigned to 0
            // if item not set up
            return;
         }
         if (LOCATE(PORT_NUMBER, PRINTER_ASSIGNMENTS, 1, 0, 1, ref NUMB, "AL"))
         {
            QUEUE = PRINTER_ASSIGNMENTS[2, NUMB];
            OPTS = PRINTER_ASSIGNMENTS[3, NUMB];
         }
         else
         {
            QUEUE = 0;
            OPTS = "";
         }
         if (QUEUE == "AUX")
         {
            COMMAND = "AUX-ON";
         }
         else
         {
            // BEGIN CASE
            // CASE
            if (MACHINE_TYPE == "M9000")
            {
               COMMAND = "SP-ASSIGN " + QUEUE + " " + OPTS;
            }// CASE
            else if (MACHINE_TYPE == "UNIVERSE")
            {
               COMMAND = PRINTER_ASSIGNMENTS[3, NUMB];
               if (COMMAND.Substring(1, 6) != "SETPTR")
               {
                  COMMAND = "";
               }
            }// CASE
            else if (OTHERWISE)
            {
               COMMAND = "SP-ASSIGN F" + QUEUE + " " + OPTS;
            }
            // END CASE
         }
         if (COMMAND != "")
         {
            nrf0 = "";
            CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref COMMAND, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
         }
         return;
      }
      void L1000()
      {
         // New printer assignments
         if (READ(ref OLD_ASSIGNS, COMMON.FILES[FL_CONTROL], "PRINTER.ASSIGNMENTS"))
         {
            L1100();
            //GENERATE NEW FORMAT
            WRITE(OLD_ASSIGNS, COMMON.FILES[FL_CONTROL], "PRINTER.ASSIGNMENTS.OLD");
            DELETE(COMMON.FILES[FL_CONTROL], "PRINTER.ASSIGNMENTS");
         }
         if (!(READ(ref ASS_REC, FL_PRINTER_ASSIGNMENTS, PORT_NUMBER)))
         {
            if (!(READ(ref ASS_REC, FL_PRINTER_ASSIGNMENTS, "ALL")))
            {
               return;
            }
         }
         //    If output is being directed to the &HOLD& file
         //    the COMMAND string should have no spaces
         if (FIELD(ASS_REC[3], ",", 6) == 3)
         {
            SPACER = "";
         }
         else
         {
            SPACER = " ";
         }
         COMMAND = ASS_REC[3] + SPACER + ASS_REC[1];
         if (ASS_REC[2] != "")
         {
            COMMAND = TRIM(COMMAND) + "\\" + ASS_REC[2];
         }
         COMMAND = TRIM(COMMAND) + SPACER + ASS_REC[4];
         nrf0 = "";
         CallAt_EXECUTE_PROG = new CallAt_EXECUTE_PROG(ref EXECUTE_PROG, ref COMMAND, ref nrf0, ref RTN_LIST, ref LIST_AVAILABLE, ref MESSAGES, ref OTHERS);
         return;
      }
      void L1100()
      {
         // CONVERT
         for (TLOOP = 1; TLOOP <= DCOUNT(OLD_ASSIGNS[1], VM); TLOOP += 1)
         {
            TILL = OLD_ASSIGNS[1, TLOOP];
            COMM = OLD_ASSIGNS[3, TLOOP];
            if (INDEX(COMM, "SETPTR", 1) > 0)
            {
               ASS_REC = "";
               ASS_REC[3] = COMM.Substring(1, INDEX(COMM, ",", 6)) + "AT";
               // ASS.REC<1> =TRIM( FIELD(COMM,",",7)[4,99])
               OLDDEST = FIELD(COMM, ",", 7);
               OLDDEST = TRIM(OLDDEST);
               OLDDF1 = FIELD(OLDDEST, " ", 1);
               OLDDF2 = FIELD(OLDDEST, " ", 2);
               if (OLDDF1 == "AT") { ASS_REC[1] = OLDDF2; } else { ASS_REC[1] = OLDDF1; }
               ASS_REC[2] = "";
               if (INDEX(COMM, ",", 7) > 0)
               {
                  ASS_REC[4] = TRIM(COMM.Substring(INDEX(COMM, ",", 7), 99));
               }
               if (ASS_REC[1].Substring(1, 2) == "\\\\" && INDEX(ASS_REC[1], "\\", 3) > 0)
               {
                  ASS_REC[2] = FIELD(ASS_REC[1], "\\", 4);
                  ASS_REC[1] = "\\\\" + FIELD(ASS_REC[1], "\\", 3);
               }
               WRITE(ASS_REC, FL_PRINTER_ASSIGNMENTS, TILL);
            }
         }
         return;
      }
   }
}
