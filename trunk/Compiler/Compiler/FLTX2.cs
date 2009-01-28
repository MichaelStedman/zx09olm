//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FLTX2 : UvBase
   {
      #region Common instances
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Variables
      UvVar ACTION = "";
      UvVar FILE_NAME = "";
      UvVar ITEM_ID = "";
      UvVar TRANS_LOG_REC = "";
      UvVar TX_LOG1 = "";
      UvVar TX_LOG2 = "";
      UvVar TX_CONTROL = "";
      UvVar TX_ATT = "";
      UvVar TX_ENABLED = "";
      UvVar TX_FILES = "";
      UvVar TX_ACCOUNT = "";
      UvVar TX_TRANSFER = "";
      UvVar TX_TRANSFER_IND = "";
      UvVar AM = "";
      UvVar VM = "";
      UvVar POS = "";
      UvVar SEQ_NO = "";
      UvVar DUMMY = "";
      UvVar TX_LOG = "";
      UvVar WRITE_ID = "";
      UvVar TEMP_FILE = "";
      UvVar TRANS_ACT_REC = "";
      UvVar DEBUG_ENABLED = "";
      UvVar TX_TRANSFER_LOG = "";
      UvVar FLEX = "";
      #endregion
      public FLTX2(ref UvVar ACTION, ref UvVar FILE_NAME, ref UvVar ITEM_ID)
      {
         this.ACTION = ACTION;
         this.FILE_NAME = FILE_NAME;
         this.ITEM_ID = ITEM_ID;
         #region INCLUDE TX.INCLUDE TX.COMMON

         #endregion
         if (TX_ENABLED)
         {
            if (!(LOCATE(FILE_NAME, TX_FILES, 0, 0, 1, ref POS, "AL")))
            {
               if (!READVU(ref SEQ_NO, TX_CONTROL, "SEQ.NO", 1)) { SEQ_NO = 1; }
               if (READ(ref DUMMY, TX_CONTROL, "TX.DESPOOL"))
               {
                  TX_LOG = TX_LOG2;
               }
               else
               {
                  TX_LOG = TX_LOG1;
               }
               if (ACTION != "WV") { TX_ATT = ""; }
               WRITE(ACTION + TX_ATT + VM + TX_ACCOUNT + VM + FILE_NAME + VM + ITEM_ID + AM + TRANS_LOG_REC, TX_LOG, SEQ_NO);
               TRANS_LOG_REC = "";
               WRITEV(SEQ_NO + 1, TX_CONTROL, "SEQ.NO", 1);
            }
         }
         if (TX_TRANSFER_IND)
         {
            if (LOCATE(FILE_NAME, TX_FILES, 0, 0, 1, ref POS, "AL"))
            {
               WRITE_ID = TX_ACCOUNT + POS + "*!*" + ITEM_ID;
               //           IF ACTION = "WV" THEN
               if (OPEN(FILE_NAME, out TEMP_FILE))
               {
                  if (!READ(ref TRANS_ACT_REC, TEMP_FILE, ITEM_ID)) { TRANS_ACT_REC = ""; }
                  TX_ATT = "";
               }
               //           END
               WRITE(ACTION + TX_ATT + VM + TX_ACCOUNT + VM + FILE_NAME + VM + ITEM_ID + AM + TRANS_ACT_REC, TX_TRANSFER, WRITE_ID);
               if (!READV(ref DEBUG_ENABLED, TX_CONTROL, "DEBUG.ENABLED", 1)) { DEBUG_ENABLED = 0; }
               if (ACTION != "WV" && TRANS_LOG_REC != TRANS_ACT_REC && DEBUG_ENABLED && ACTION != "D")
               {
                  if (!OPEN("TX.TRANSFER.LOG", out TX_TRANSFER_LOG)) { STOP(201, "TX.TRANSFER.LOG"); }
                  WRITE(ACTION + TX_ATT + VM + TX_ACCOUNT + VM + FILE_NAME + VM + ITEM_ID + AM + TRANS_LOG_REC, TX_TRANSFER_LOG, WRITE_ID);
                  CRTCR("OI FLEX PEEP, THIS IS THE CAUSE OF OUR NEWHAM BUG OR SHOULD I SAY ONE OF THE CAUSES");
                  CRTCR("PRESS BREAK NOW, TYPE T, NOTE DOWN THE PROGRAM BEFORE FLTX2 AND LET RICH OR ANNE");
                  CRTCR("KNOW");
                  INPUTCR(out FLEX);
               }
               TRANS_LOG_REC = "";
            }
         }
         return;
      }
   }
}
