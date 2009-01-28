//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_WINDOW : UvBase
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
      readonly UvVar VALID_DATA = 0;
      readonly UvVar EXIT = 2;
      readonly UvVar BACKUP = 3;
      readonly UvVar INVALID_DATA = 5;
      readonly UvVar FINISH = 6;
      readonly UvVar LIMIT = 4;
      #endregion
      #region String Constants
      readonly UvVar INIT = "";
      #endregion
      #region Arrays
      UvVar[] CONTROLS_REC = new UvVar[20];
      #endregion
      #region Variables
      UvVar CALLING_PROGRAM = "";
      UvVar OPTION_LIST = "";
      UvVar OPTION_SELECTED = "";
      UvVar LOCATE_TEXT = "";
      UvVar KEYJUST = "";
      UvVar INTERACT = "";
      UvVar TERMINAL_TYPE = "";
      UvVar MACHINE_TYPE = "";
      UvVar REV_VID = "";
      UvVar DIM_REV_VID = "";
      UvVar DIM_VID = "";
      UvVar NRM_VID = "";
      UvVar UND_VID = "";
      UvVar GO_BACK = "";
      UvVar AM = "";
      UvVar CLIENT_APP_TYPE = "";
      UvVar PROGRAM = "";
      UvVar FL_CURSOR = "";
      UvVar DISPLAY_ONLY = "";
      UvVar PROMPT_MESS = "";
      UvVar CONT = "";
      UvVar PG_UP = "";
      UvVar PG_DOWN = "";
      UvVar PG_HOME = "";
      UvVar PG_END = "";
      UvVar DF_START = "";
      UvVar DF = "";
      UvVar KEY_UP = "";
      UvVar KEY_DOWN = "";
      UvVar KEY_LEFT = "";
      UvVar KEY_RIGHT = "";
      UvVar UPWARDS = "";
      UvVar DOWNWARDS = "";
      UvVar WINDOW_REC = "";
      UvVar START = "";
      UvVar WINDOW_DEPTH = "";
      UvVar WINDOW_JUST = "";
      UvVar TYPE_JUST = "";
      UvVar MAX_EVENTS = "";
      UvVar START_ROW = "";
      UvVar START_COL = "";
      UvVar COLUMN_HEADINGS = "";
      UvVar WINDOW_HEADING = "";
      UvVar I = "";
      UvVar MOVE = "";
      UvVar RESP = "";
      UvVar THIS_ROW = "";
      UvVar LAST_LINE = "";
      UvVar MOVEA = "";
      UvVar KEEP_LOCATE = "";
      UvVar EXTRA_CHAR = "";
      UvVar COMPL = "";
      UvVar LTL = "";
      UvVar TYPE_DESC = "";
      UvVar POINTER = "";
      UvVar LINE = "";
      UvVar TYPE_CODE = "";
      UvVar TERMINAL_CONTROL_REC = "";
      UvVar FL_CURSOR_ERROR = "";
      UvVar THIS_COLOR = "";
      #endregion
      public FL_WINDOW(ref UvVar CALLING_PROGRAM, ref UvVar OPTION_LIST, ref UvVar OPTION_SELECTED, ref UvVar LOCATE_TEXT, ref UvVar KEYJUST, ref UvVar INTERACT)
      {
         this.CALLING_PROGRAM = CALLING_PROGRAM;
         this.OPTION_LIST = OPTION_LIST;
         this.OPTION_SELECTED = OPTION_SELECTED;
         this.LOCATE_TEXT = LOCATE_TEXT;
         this.KEYJUST = KEYJUST;
         this.INTERACT = INTERACT;
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
         /* ** Universal Window Program (RT Cribbed from elsewhere) */
         /*  Send multivalued list of options, key]desc */
         /*  Send the starting point if requied (used for multiple selects) */
         /*  Send the calling program (used to resolve position of window) */
         /*  Returns the attribute relating to the selected field */
         /*  Returns interact of abandon or valid.data */
         PROGRAM = "FL.WINDOW";
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         if (!OPEN("FL.CURSOR", out FL_CURSOR)) { STOP(201, "FL.CURSOR"); }
         if (FIELD(LOCATE_TEXT, "&", 1) == "DISPLAY.ONLY")
         {
            DISPLAY_ONLY = TRUE;
            LOCATE_TEXT = FIELD(LOCATE_TEXT, "&", 2);
            PROMPT_MESS = " ";
         }
         else
         {
            DISPLAY_ONLY = FALSE;
         }
         /*  Copy the display */
         PRINTCR(CHAR(28) + "36,0,0,80,30" + CHAR(20));
         CONT = "Y";
         PG_UP = 9;
         PG_DOWN = 3;
         PG_HOME = 7;
         PG_END = 1;
         DF_START = 1;
         DF = 1;
         /*      KEY.UP = "U" */
         /*      KEY.DOWN = "D" */
         KEY_UP = 8;
         KEY_DOWN = 2;
         KEY_UP = 8;
         KEY_DOWN = 2;
         KEY_LEFT = 4;
         KEY_RIGHT = 6;
         PRINTCR(CHAR(28) + "30," + KEY_UP + "," + KEY_DOWN + "," + KEY_LEFT + "," + KEY_RIGHT + CHAR(20));
         UPWARDS = 8;
         DOWNWARDS = 2;
         if (!(READ(ref WINDOW_REC, COMMON.FILES[FL_CONTROL], CALLING_PROGRAM + ".WINDOW.PARAMS")))
         {
            WINDOW_REC = "";
            WINDOW_REC[1] = 14;
            WINDOW_REC[2] = 73;
            WINDOW_REC[3] = 2;
            /* START COL */
            WINDOW_REC[4] = 4;
            /*  START ROW */
            WINDOW_REC[5] = "Select Item or '.' to exit ";
            WINDOW_REC[6] = "";
            WINDOW_REC[7] = "";
         }
         WINDOW_DEPTH = WINDOW_REC[1] - 1;
         if (WINDOW_DEPTH < 10) { WINDOW_DEPTH = 10; }
         WINDOW_JUST = "L#" + WINDOW_REC[2];
         TYPE_JUST = "L#" + (WINDOW_REC[2] - 11);
         MAX_EVENTS = DCOUNT(OPTION_LIST, AM);
         if (MAX_EVENTS < WINDOW_DEPTH + 1)
         {
            WINDOW_DEPTH = MAX_EVENTS - 1;
         }
         START_ROW = WINDOW_REC[4];
         /*  INT((20 - (WINDOW.DEPTH + 2)) / 2) + 1 */
         START_COL = WINDOW_REC[3];
         COLUMN_HEADINGS = WINDOW_REC[6];
         WINDOW_HEADING = WINDOW_REC[7];
         START = OPTION_SELECTED;
         /*      OPTION.SELECTED = START */
         if (START > (MAX_EVENTS - WINDOW_DEPTH))
         {
            START = MAX_EVENTS - WINDOW_DEPTH;
         }
         /* **** */
         /* !*     CALL FL.CLIENT.TYPE(CLIENT.APP.TYPE) */
         // BEGIN CASE
         // CASE
         if (CLIENT_APP_TYPE.Substring(1, 1) == "W")
         {
            /*  Windows FRONT END */
            PRINT(CHAR(28) + "405");
            /*  Print Window heading & footer */
            PRINT(CHAR(28) + "406");
            PRINTCR(AT(START_COL, START_ROW) + WINDOW_HEADING);
            PROMPT_MESS = WINDOW_REC[5];
            PRINTCR(PROMPT_MESS);
            /*  Print Column headings & data */
            PRINTCR(CHAR(28) + "407" + "," + OPTION_SELECTED);
            PRINTCR(COLUMN_HEADINGS[1, 1] + "," + COLUMN_HEADINGS[1, 2]);
            for (I = 1; I <= DCOUNT(OPTION_LIST, AM); I += 1)
            {
               PRINTCR(OPTION_LIST[I, 1] + "," + OPTION_LIST[I, 2]);
            }
            /*  Print Buttons */
            PRINT(CHAR(28) + "401");
            PRINT(CHAR(20));
            INPUT(out MOVE, 10);
            if (MOVE == COMMON.ABANDON || MOVE == "")
            {
               RESP = "N";
            }
            else
            {
               OPTION_SELECTED = MOVE;
            }
            /* *** */
         }// CASE
         else if (OTHERWISE)
         {
            RESP = "N";
            do
            {
               if (RESP == CONT) break;
               PRINT(AT(START_COL, START_ROW) + DIM_REV_VID + FORMAT(("Available Items " + MAX_EVENTS), WINDOW_JUST) + NRM_VID);
               THIS_ROW = START_ROW + WINDOW_DEPTH + 2;
               L0100();
               do
               {
                  /*            THIS.ROW = START.ROW + (LAST.LINE - START) + 2 */
                  THIS_ROW = START_ROW + WINDOW_DEPTH + 2;
                  if (DISPLAY_ONLY)
                  {
                     MOVE = "";
                     PRINT(AT(START_COL, THIS_ROW) + DIM_REV_VID + FORMAT(PROMPT_MESS, WINDOW_JUST) + NRM_VID + " ");
                     PRINT(AT(START_COL + LEN(PROMPT_MESS), THIS_ROW));
                  }
                  else
                  {
                     PROMPT_MESS = WINDOW_REC[5];
                     if (PROMPT_MESS == "")
                     {
                        PROMPT_MESS = "Select Item or '.' to exit " + LOCATE_TEXT;
                     }
                     else
                     {
                        PROMPT_MESS = PROMPT_MESS + " " + LOCATE_TEXT;
                     }
                     PRINT(AT(START_COL, THIS_ROW) + DIM_REV_VID + FORMAT(PROMPT_MESS, WINDOW_JUST) + NRM_VID + " ");
                     PRINT(AT(START_COL + LEN(PROMPT_MESS), THIS_ROW));
                     do
                     {
                        INPUTCR(out MOVEA, -1);
                        MOVE = KEYIN();
                        if (MOVE != "" || MOVEA == 49) break;
                     } while (true);
                  }
                  if (SEQ(MOVE) == 10) { MOVE = INIT; /* RETURN */ }
                  KEEP_LOCATE = FALSE;
                  DF_START = 1;
                  /*            INPUT MOVE,1: */
                  if (MOVE == COMMON.ABANDON || MOVE == GO_BACK) { PRINT(DIM_REV_VID + MOVE); }
                  // BEGIN CASE
                  // CASE
                  if (MOVE == COMMON.ABANDON || MOVE == GO_BACK)
                  {
                     INPUT(out EXTRA_CHAR, 1);
                  }// CASE
                  else if (MOVE == PG_HOME)
                  {
                     START = 1;
                     OPTION_SELECTED = 1;
                     L0100();
                  }// CASE
                  else if (MOVE == PG_END)
                  {
                     START = MAX_EVENTS - WINDOW_DEPTH;
                     OPTION_SELECTED = MAX_EVENTS;
                     L0100();
                  }// CASE
                  else if (OCONV(MOVE, "MCA") != "" && LEN(LOCATE_TEXT) < 20 || (MOVE == " " && LOCATE_TEXT > 0))
                  {
                     KEEP_LOCATE = TRUE;
                     DF_START = DF;
                     LOCATE_TEXT = LOCATE_TEXT + MOVE;
                     COMPL = FALSE;
                     LTL = LEN(LOCATE_TEXT);
                     for (DF = DF_START; DF <= MAX_EVENTS && NOT(COMPL); DF += 1)
                     {
                        if (OPTION_LIST[DF, 2].Substring(1, LTL) == LOCATE_TEXT)
                        {
                           START = DF;
                           OPTION_SELECTED = DF;
                           COMPL = TRUE;
                           L0100();
                        }
                     }
                     /* !              IF NOT(COMPL) THEN LOCATE.TEXT = OLD.LOCATE */
                  }// CASE
                  else if (SEQ(MOVE) == 8)
                  {
                     /*  Backspace */
                     KEEP_LOCATE = TRUE;
                     DF_START = 1;
                     COMPL = FALSE;
                     LTL = LEN(LOCATE_TEXT);
                     if (LTL > 1)
                     {
                        LOCATE_TEXT = LOCATE_TEXT.Substring(1, LTL - 1);
                     }
                     else
                     {
                        LOCATE_TEXT = "";
                     }
                     LTL = LEN(LOCATE_TEXT);
                     for (DF = DF_START; DF <= MAX_EVENTS && NOT(COMPL); DF += 1)
                     {
                        if (OPTION_LIST[DF, 2].Substring(1, LTL) == LOCATE_TEXT)
                        {
                           START = DF;
                           OPTION_SELECTED = DF;
                           L0100();
                           COMPL = TRUE;
                        }
                     }
                  }// CASE
                  else if (MOVE == PG_UP)
                  {
                     START = START - WINDOW_DEPTH;
                     if (START < 1)
                     {
                        START = 1;
                     }
                     else
                     {
                     }
                     if (OPTION_SELECTED < START || OPTION_SELECTED > (START + WINDOW_DEPTH))
                     {
                        OPTION_SELECTED = START + WINDOW_DEPTH;
                     }
                     L0100();
                  }// CASE
                  else if (MOVE == PG_DOWN)
                  {
                     START = START + (WINDOW_DEPTH + 1);
                     LAST_LINE = START + WINDOW_DEPTH;
                     if (LAST_LINE > MAX_EVENTS)
                     {
                        START = MAX_EVENTS - WINDOW_DEPTH;
                     }
                     else
                     {
                     }
                     if (OPTION_SELECTED < START || OPTION_SELECTED > (START + (WINDOW_DEPTH + 1)))
                     {
                        OPTION_SELECTED = START;
                     }
                     L0100();
                  }// CASE
                  else if (MOVE == UPWARDS || MOVE == KEY_UP)
                  {
                     if (START == OPTION_SELECTED)
                     {
                        if (OPTION_SELECTED != 1)
                        {
                           START = OPTION_SELECTED - WINDOW_DEPTH;
                           if (START < 1) { START = 1; }
                           OPTION_SELECTED = OPTION_SELECTED - 1;
                           L0100();
                        }
                     }
                     else
                     {
                        TYPE_DESC = OPTION_LIST[OPTION_SELECTED, 2];
                        TYPE_DESC = FORMAT(OPTION_LIST[OPTION_SELECTED, 1], KEYJUST) + " " + FORMAT(TYPE_DESC, TYPE_JUST);
                        THIS_ROW = START_ROW + (POINTER - START) + 1;
                        PRINT(AT(START_COL, THIS_ROW) + DIM_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                        OPTION_SELECTED = OPTION_SELECTED - 1;
                        TYPE_DESC = OPTION_LIST[OPTION_SELECTED, 2];
                        TYPE_DESC = FORMAT(OPTION_LIST[OPTION_SELECTED, 1], KEYJUST) + " " + FORMAT(TYPE_DESC, TYPE_JUST);
                        POINTER = POINTER - 1;
                        THIS_ROW = THIS_ROW - 1;
                        if (POINTER == 1)
                        {
                           PRINT(AT(START_COL, THIS_ROW) + REV_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                        }
                        else
                        {
                           PRINT(AT(START_COL, THIS_ROW) + UND_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                        }
                     }
                  }// CASE
                  else if (MOVE == DOWNWARDS || MOVE == KEY_DOWN)
                  {
                     if (LAST_LINE == OPTION_SELECTED)
                     {
                        if (OPTION_SELECTED != MAX_EVENTS)
                        {
                           START = OPTION_SELECTED + 1;
                           if ((START + WINDOW_DEPTH) > MAX_EVENTS)
                           {
                              START = MAX_EVENTS - WINDOW_DEPTH;
                           }
                           OPTION_SELECTED = OPTION_SELECTED + 1;
                           L0100();
                        }
                     }
                     else
                     {
                        TYPE_DESC = OPTION_LIST[OPTION_SELECTED, 2];
                        TYPE_DESC = FORMAT(OPTION_LIST[OPTION_SELECTED, 1], KEYJUST) + " " + FORMAT(TYPE_DESC, TYPE_JUST);
                        THIS_ROW = START_ROW + (POINTER - START) + 1;
                        PRINT(AT(START_COL, THIS_ROW) + DIM_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                        OPTION_SELECTED = OPTION_SELECTED + 1;
                        TYPE_DESC = OPTION_LIST[OPTION_SELECTED, 2];
                        TYPE_DESC = FORMAT(OPTION_LIST[OPTION_SELECTED, 1], KEYJUST) + " " + FORMAT(TYPE_DESC, TYPE_JUST);
                        POINTER = POINTER + 1;
                        THIS_ROW = THIS_ROW + 1;
                        if (POINTER == MAX_EVENTS)
                        {
                           PRINT(AT(START_COL, THIS_ROW) + REV_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                        }
                        else
                        {
                           PRINT(AT(START_COL, THIS_ROW) + UND_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                        }
                     }
                  }// CASE
                  else if (MOVE == INIT)
                  {
                     /*  CHOSEN SHOW */
                  }
                  // END CASE
                  /*            UNTIL MOVE = '' OR MOVE = ABANDON DO */
                  if (MOVE == "" || MOVE == COMMON.ABANDON || MOVE == GO_BACK) break;
                  if (KEEP_LOCATE == FALSE)
                  {
                     LOCATE_TEXT = "";
                     DF_START = 1;
                  }
               } while (true);
               /*        FOR LINE = START.ROW TO START.ROW + WINDOW.REC<1> */
               /*          PRINT @(START.COL,LINE):EOL: */
               /*        NEXT LINE */
               /*         IF MOVE = ABANDON THEN */
               if (MOVE == COMMON.ABANDON || MOVE == GO_BACK)
               {
                  /*            TYPE.CODE = ABANDON */
                  /*            INTERACT = ABANDON */
                  TYPE_CODE = MOVE;
                  INTERACT = MOVE;
                  /*  PUT CURSOR KEYS BACK TO NORMAL AND PASTE BACK DISPLAY */
                  if (!READ(ref TERMINAL_CONTROL_REC, FL_CURSOR, MACHINE_TYPE + "*" + TERMINAL_TYPE + "*CONTROL")) { FL_CURSOR_ERROR = 1; }
                  KEY_UP = TERMINAL_CONTROL_REC[7];
                  KEY_DOWN = TERMINAL_CONTROL_REC[9];
                  KEY_LEFT = TERMINAL_CONTROL_REC[6];
                  KEY_RIGHT = TERMINAL_CONTROL_REC[8];
                  PRINTCR(CHAR(28) + "30," + KEY_UP + "," + KEY_DOWN + "," + KEY_LEFT + "," + KEY_RIGHT + CHAR(20));
                  PRINTCR(CHAR(28) + "37,0,0" + CHAR(20));
                  return;
               }
               TYPE_CODE = OPTION_LIST[OPTION_SELECTED, 1];
               RESP = "Y";
            } while (true);
         }
         // END CASE
         /*  PUT CURSOR KEYS BACK TO NORMAL AND PASTE BACK DISPLAY */
         if (!READ(ref TERMINAL_CONTROL_REC, FL_CURSOR, MACHINE_TYPE + "*" + TERMINAL_TYPE + "*CONTROL")) { FL_CURSOR_ERROR = 1; }
         KEY_UP = TERMINAL_CONTROL_REC[7];
         KEY_DOWN = TERMINAL_CONTROL_REC[9];
         KEY_LEFT = TERMINAL_CONTROL_REC[6];
         KEY_RIGHT = TERMINAL_CONTROL_REC[8];
         PRINTCR(CHAR(28) + "30," + KEY_UP + "," + KEY_DOWN + "," + KEY_LEFT + "," + KEY_RIGHT + CHAR(20));
         /*  Paste Display back unless display only is required */
         if (DISPLAY_ONLY == FALSE)
         {
            PRINTCR(CHAR(28) + "37,0,0" + CHAR(20));
         }
         INTERACT = VALID_DATA;
         return;
      }
      void L0100()
      {
         LAST_LINE = START + WINDOW_DEPTH;
         if (LAST_LINE > MAX_EVENTS) { LAST_LINE = MAX_EVENTS; }
         for (LINE = START; LINE <= LAST_LINE; LINE += 1)
         {
            TYPE_DESC = OPTION_LIST[LINE, 2];
            /* IF TYPE.DESC # "" THEN */
            THIS_ROW = START_ROW + (LINE - START) + 1;
            THIS_COLOR = DIM_VID;
            if (LINE == OPTION_SELECTED && DISPLAY_ONLY == FALSE)
            {
               if (LINE == 1 || LINE == MAX_EVENTS)
               {
                  THIS_COLOR = REV_VID;
               }
               else
               {
                  THIS_COLOR = UND_VID;
               }
               POINTER = LINE;
            }
            TYPE_DESC = FORMAT(OPTION_LIST[LINE, 1], KEYJUST) + " " + FORMAT(TYPE_DESC, TYPE_JUST);
            PRINT(AT(START_COL, THIS_ROW) + THIS_COLOR + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
            /*        END */
         }
         if (THIS_ROW < WINDOW_DEPTH + START_ROW)
         {
            for (THIS_ROW = THIS_ROW + 1; THIS_ROW <= WINDOW_DEPTH + START_ROW + 1; THIS_ROW += 1)
            {
               PRINT(AT(START_COL, THIS_ROW) + DIM_VID + FORMAT(" ", WINDOW_JUST) + NRM_VID + " ");
            }
         }
         return;
      }
   }
}
