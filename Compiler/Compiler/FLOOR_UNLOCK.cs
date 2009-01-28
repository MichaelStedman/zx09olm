//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FLOOR_UNLOCK : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
      readonly UvVar FL_FLOOR_LOCK = 9;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] LOCK_KEYS = new UvVar[30];
      UvVar[] LOCK_RECS = new UvVar[30];
      #endregion
      #region Variables
      UvVar FLOOR_AREAS = "";
      UvVar ZZZ_DATE = "";
      UvVar START_TIME = "";
      UvVar FINISH_TIME = "";
      UvVar VM = "";
      UvVar TRANS_LOG_REC = "";
      UvVar TAKEN = "";
      UvVar TILL_LOCK = "";
      FLTX2 FLTX2;
      UvVar NOT_TAKEN = "";
      UvVar INTERVAL = "";
      UvVar ST_TIME = "";
      UvVar FN_TIME = "";
      UvVar LAST_ATT = "";
      UvVar EMPTY = "";
      UvVar NO_OF_AREAS = "";
      UvVar FA = "";
      UvVar MIN = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      #endregion
      public FLOOR_UNLOCK(ref UvVar FLOOR_AREAS, ref UvVar ZZZ_DATE, ref UvVar START_TIME, ref UvVar FINISH_TIME)
      {
         this.FLOOR_AREAS = FLOOR_AREAS;
         this.ZZZ_DATE = ZZZ_DATE;
         this.START_TIME = START_TIME;
         this.FINISH_TIME = FINISH_TIME;
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
         /*  unlocks floor areas */
         /*  IMPORTANT: THIS ROUTINE HAS BEEN COPIED FOR USE IN */
         /*             INTERNET BOOKINGS. THEREFORE DETAILS OF ANY */
         /*             AMENDMENTS MUST BE PASSED ONTO THE RELEVANT PEOPLE */
         /*             SO THAT ALL VERSIONS CAN BE KEPT UP TO DATE */
         /*  Last updated : 11:36:36  22 SEP 1992 */
         /*  only one till at a time for the same day */
         TAKEN = TRUE;
         /* MHS!     READU TILL.LOCK FROM FL.FLOOR.LOCK , DATE ELSE */
         /* MHS!TRANS.LOG.REC = TAKEN; CALL FLTX2('W','FL.FLOOR.LOCK', DATE );        WRITE TAKEN ON FL.FLOOR.LOCK , DATE */
         /* MHS!       READU TILL.LOCK FROM FL.FLOOR.LOCK , DATE ELSE NULL */
         /* MHS!     END */
         if (!READU(ref TILL_LOCK, COMMON.FILES[FL_FLOOR_LOCK], ZZZ_DATE)) { NULL(); }
         NOT_TAKEN = "";
         /*     START AT 00:00 AM */
         /*     REDUCE TO EVERY 5 MINUTES */
         INTERVAL = 300;
         /*  No. of secs in 5 mins */
         ST_TIME = (START_TIME / INTERVAL) + 1;
         FN_TIME = (FINISH_TIME / INTERVAL);
         LAST_ATT = (86400 / INTERVAL) + 1;
         EMPTY = "";
         EMPTY[LAST_ATT] = "END";
         MAT(ref LOCK_KEYS, "");
         MAT(ref LOCK_RECS, "");
         NO_OF_AREAS = COUNT(FLOOR_AREAS, VM) + 1;
         /*  main checking loop */
         FA = 0;
         do
         {
            FA = FA + 1;
            if (FLOOR_AREAS[1, FA] == "") break;
            LOCK_KEYS[FA] = FLOOR_AREAS[1, FA] + "*" + ZZZ_DATE;
            if (!(READ(ref LOCK_RECS[FA], COMMON.FILES[FL_FLOOR_LOCK], LOCK_KEYS[FA])))
            {
               RELEASE();
               return;
            }
            for (MIN = ST_TIME; MIN <= FN_TIME; MIN += 1)
            {
               LOCK_RECS[FA][MIN] = NOT_TAKEN;
            }
         } while (true);
         /*  now write all the lock records */
         FA = 0;
         do
         {
            FA = FA + 1;
            if (FLOOR_AREAS[1, FA] == "") break;
            if (LOCK_RECS[FA] == EMPTY)
            {
               nrf0 = "D"; nrf1 = "FL.FLOOR.LOCK"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref LOCK_KEYS[FA]);
            }
            else
            {
               TRANS_LOG_REC = LOCK_RECS[FA];
               nrf0 = "W"; nrf1 = "FL.FLOOR.LOCK"; FLTX2 = new FLTX2(ref nrf0, ref nrf1, ref LOCK_KEYS[FA]);
            }
         } while (true);
         RELEASE();
         return;
      }
   }
}
