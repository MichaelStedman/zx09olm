//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_PHOTO : UvBase
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
      UvVar PHOTO_NAME = "";
      UvVar PH_COL = "";
      UvVar PH_ROW = "";
      UvVar PORT_NUMBER = "";
      UvVar PHOTO_ID = "";
      UvVar PHOTO_PATH = "";
      UvVar PHOTO_PATH_FWTERM = "";
      UvVar PHOTO_PATH_LOCAL = "";
      UvVar PHOTO_REQ = "";
      UvVar PHOTO_ON = "";
      UvVar PHOTO_OFF = "";
      UvVar MESSAGE_TYPE = "";
      UvVar PHOTO_FILE_NAME = "";
      UvVar PHOTO_DATE = "";
      UvVar PHOTO_FILE = "";
      UvVar REC = "";
      #endregion
      public FL_PHOTO(ref UvVar PHOTO_NAME, ref UvVar PH_COL, ref UvVar PH_ROW)
      {
         this.PHOTO_NAME = PHOTO_NAME;
         this.PH_COL = PH_COL;
         this.PH_ROW = PH_ROW;
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
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         /* PRINT @(PH.COL,PH.ROW-1):'[[AGE : 99]]': */
         PHOTO_ID = "PHOTO.PATH*" + PORT_NUMBER;
         if (!(READ(ref PHOTO_PATH, COMMON.FILES[FL_CONTROL], PHOTO_ID)))
         {
            if (!(READ(ref PHOTO_PATH, COMMON.FILES[FL_CONTROL], "PHOTO.PATH")))
            {
               PHOTO_PATH = "";
            }
         }
         PHOTO_PATH_FWTERM = PHOTO_PATH[1, 1];
         PHOTO_PATH_LOCAL = PHOTO_PATH[4, 1];
         if (!READV(ref PHOTO_REQ, COMMON.FILES[FL_CONTROL], "PHOTO.REQUIRED", 1)) { PHOTO_REQ = FALSE; }
         if (PHOTO_PATH_FWTERM != "" && PHOTO_REQ == "Y")
         {
            PHOTO_ON = CHAR(28);
            PHOTO_OFF = CHAR(20);
            MESSAGE_TYPE = "00";
            if (PH_ROW == "")
            {
               PH_ROW = 8;
            }
            if (NOT(FIELD(PHOTO_NAME, ".", 2)))
            {
               PHOTO_FILE_NAME = PHOTO_NAME + ".JPG";
            }
            else
            {
               PHOTO_FILE_NAME = PHOTO_NAME;
            }
            PHOTO_FILE_NAME = "\\" + PHOTO_FILE_NAME;
            PHOTO_DATE = "";
            /* IF PHOTO.PATH.LOCAL # "" THEN */
            if (OPENSEQ(PHOTO_PATH_FWTERM + PHOTO_FILE_NAME, out PHOTO_FILE))
            {
               if (!STATUS(ref REC, PHOTO_FILE)) { REC = ""; }
               PHOTO_DATE = REC[16];
            }
            /* END */
            PRINT(PHOTO_ON);
            PRINT(MESSAGE_TYPE + ",");
            PRINT(FORMAT(PH_COL, "R%2") + ",");
            PRINT(FORMAT(PH_ROW, "R%2") + ",");
            PRINT(PHOTO_PATH_FWTERM);
            PRINT(PHOTO_FILE_NAME);
            PRINT("," + PHOTO_DATE);
            PRINT(PHOTO_OFF);
         }
         return;
      }
   }
}
