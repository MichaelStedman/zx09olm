//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_XTD_WINDOW : UvBase
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
      UvVar WINDOW_REC = "";
      UvVar PRESENTED_LIST = "";
      UvVar OPTION_SELECTED = "";
      UvVar LOCATE_TEXT = "";
      UvVar KEYJUST = "";
      UvVar INTERACT = "";
      UvVar COPY_DISPLAY = "";
      UvVar TERMINAL_TYPE = "";
      UvVar MACHINE_TYPE = "";
      UvVar REV_VID = "";
      UvVar DIM_REV_VID = "";
      UvVar NRM_VID = "";
      UvVar DIM_REV_UND_VID = "";
      UvVar REV_UND_VID = "";
      UvVar AM = "";
      UvVar PROGRAM = "";
      UvVar FL_CURSOR = "";
      UvVar OPTION_LIST = "";
      UvVar DISPLAY_ONLY = "";
      UvVar PROMPT_MESS = "";
      UvVar CONT = "";
      UvVar BOX_BACK_VID = "";
      UvVar TITLE_COLOR_VID = "";
      UvVar FSTLAST_COLOR_VID = "";
      UvVar THISONE_COLOR_VID = "";
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
      UvVar START = "";
      UvVar WINDOW_DEPTH = "";
      UvVar WINDOW_JUST = "";
      UvVar KEYJUSTNUM = "";
      UvVar TYPE_JUST = "";
      UvVar MAX_EVENTS = "";
      UvVar MAX_DISPLAY = "";
      UvVar TITLE_BAR = "";
      UvVar ALS = "";
      UvVar START_ROW = "";
      UvVar RESP = "";
      UvVar START_COL = "";
      UvVar THIS_ROW = "";
      UvVar LAST_LINE = "";
      UvVar MOVE = "";
      UvVar MOVEA = "";
      UvVar KEEP_LOCATE = "";
      UvVar A = "";
      UvVar B = "";
      UvVar COMPL = "";
      UvVar LTL = "";
      UvVar TYPE_DESC = "";
      UvVar POINTER = "";
      UvVar LINE = "";
      UvVar TYPE_CODE = "";
      UvVar TERMINAL_CONTROL_REC = "";
      UvVar FL_CURSOR_ERROR = "";
      UvVar THIS_COLOR = "";
      UvVar THIS_INDICATOR = "";
      #endregion
      public FL_XTD_WINDOW(ref UvVar WINDOW_REC, ref UvVar PRESENTED_LIST, ref UvVar OPTION_SELECTED, ref UvVar LOCATE_TEXT, ref UvVar KEYJUST, ref UvVar INTERACT, ref UvVar COPY_DISPLAY)
      {
         this.WINDOW_REC = WINDOW_REC;
         this.PRESENTED_LIST = PRESENTED_LIST;
         this.OPTION_SELECTED = OPTION_SELECTED;
         this.LOCATE_TEXT = LOCATE_TEXT;
         this.KEYJUST = KEYJUST;
         this.INTERACT = INTERACT;
         this.COPY_DISPLAY = COPY_DISPLAY;
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
         //** Universal Window Program (RT Cribbed from elsewhere)
         // Send multivalued list of options, key]desc
         // Send the starting point if requied (used for multiple selects)
         // Send the calling program (used to resolve position of window)
         // Returns the attribute relating to the selected field
         // Returns interact of abandon or valid.data
         PROGRAM = "FL.WINDOW";
         #region INCLUDE FL.FILES FL.CONTROL
         #region INCLUDE FL.FILES FL.CONTROL.EQU

         #endregion

         #region INCLUDE FL.FILES FL.CONTROL.DIM

         #endregion

         #endregion
         if (!OPEN("FL.CURSOR", out FL_CURSOR)) { STOP(201, "FL.CURSOR"); }
         OPTION_LIST = PRESENTED_LIST;
         if (FIELD(LOCATE_TEXT, "&", 1) == "DISPLAY.ONLY")
         {
            DISPLAY_ONLY = TRUE;
            LOCATE_TEXT = FIELD(LOCATE_TEXT, "&", 2);
            PROMPT_MESS = " ";
         }
         else
         {
            DISPLAY_ONLY = FALSE;
            // Copy the display
            if (COPY_DISPLAY)
            {
               PRINTCR(CHAR(28) + "36,0,0,80,30" + CHAR(20));
            }
         }
         CONT = "Y";
         BOX_BACK_VID = DIM_REV_UND_VID;
         TITLE_COLOR_VID = REV_VID;
         FSTLAST_COLOR_VID = DIM_REV_VID;
         THISONE_COLOR_VID = REV_UND_VID;
         PG_UP = 9;
         PG_DOWN = 3;
         PG_HOME = 7;
         PG_END = 1;
         DF_START = 1;
         DF = 1;
         //     KEY.UP = "U"
         //     KEY.DOWN = "D"
         KEY_UP = 8;
         KEY_DOWN = 2;
         KEY_UP = 8;
         KEY_DOWN = 2;
         KEY_LEFT = 4;
         KEY_RIGHT = 6;
         PRINTCR(CHAR(28) + "30," + KEY_UP + "," + KEY_DOWN + "," + KEY_LEFT + "," + KEY_RIGHT + CHAR(20));
         UPWARDS = 8;
         DOWNWARDS = 2;
         //     READ WINDOW.REC FROM FL.CONTROL , CALLING.PROGRAM:'.WINDOW.PARAMS' ELSE
         //       WINDOW.REC = ''
         //       WINDOW.REC<1> = 14
         //       WINDOW.REC<2> = 73
         //       WINDOW.REC<3> = 2 ; *START COL
         //       WINDOW.REC<4> = 4 ; * START ROW
         //       WINDOW.REC<5> = "Select Item or '.' to exit "
         //     END
         WINDOW_DEPTH = WINDOW_REC[1] - 1;
         //     IF WINDOW.DEPTH < 10 THEN WINDOW.DEPTH = 10
         WINDOW_JUST = "L#" + WINDOW_REC[2];
         KEYJUSTNUM = OCONV(KEYJUST, "MCN");
         if (KEYJUSTNUM != "")
         {
            TYPE_JUST = "L#" + (WINDOW_REC[2] - KEYJUSTNUM);
         }
         else
         {
            TYPE_JUST = "L#" + (WINDOW_REC[2] - 11);
         }
         MAX_EVENTS = DCOUNT(OPTION_LIST, AM);
         MAX_DISPLAY = MAX_EVENTS;
         TITLE_BAR = WINDOW_REC[6];
         if (TITLE_BAR == "")
         {
            TITLE_BAR = "Available Items " + MAX_DISPLAY;
         }
         if (MAX_DISPLAY == 0) { return; }
         if (MAX_EVENTS < WINDOW_DEPTH + 1)
         {
            for (ALS = MAX_EVENTS; ALS <= WINDOW_DEPTH + 1; ALS += 1)
            {
               OPTION_LIST[-1] = "";
            }
            MAX_EVENTS = WINDOW_DEPTH + 1;
         }
         //     IF MAX.EVENTS < WINDOW.DEPTH + 1 THEN
         //       WINDOW.DEPTH = MAX.EVENTS - 1
         //     END
         START_ROW = WINDOW_REC[4];
         // INT((20 - (WINDOW.DEPTH + 2)) / 2) + 1
         START = OPTION_SELECTED;
         //     OPTION.SELECTED = START
         if (START > (MAX_DISPLAY - WINDOW_DEPTH))
         {
            START = MAX_EVENTS - WINDOW_DEPTH;
         }
         RESP = "N";
         do
         {
            if (RESP == CONT) break;
            START_COL = WINDOW_REC[3];
            PRINT(AT(START_COL, START_ROW) + TITLE_COLOR_VID + FORMAT((TITLE_BAR), WINDOW_JUST) + NRM_VID);
            L0100();
            do
            {
               //           THIS.ROW = START.ROW + (LAST.LINE - START) + 2
               THIS_ROW = START_ROW + WINDOW_DEPTH + 2;
               if (DISPLAY_ONLY)
               {
                  MOVE = "";
                  PRINT(AT(START_COL, THIS_ROW) + TITLE_COLOR_VID + FORMAT(PROMPT_MESS, WINDOW_JUST) + NRM_VID + " ");
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
                  PRINT(AT(START_COL, THIS_ROW) + TITLE_COLOR_VID + FORMAT(PROMPT_MESS, WINDOW_JUST) + NRM_VID + " ");
                  PRINT(AT(START_COL + LEN(PROMPT_MESS) + 1, THIS_ROW));
                  do
                  {
                     INPUTCR(out MOVEA, -1);
                     MOVE = KEYIN();
                     if (MOVE != "" || MOVEA == 49) break;
                  } while (true);
               }
               if (SEQ(MOVE) == 10) { MOVE = INIT; }
               KEEP_LOCATE = FALSE;
               DF_START = 1;
               //           INPUT MOVE,1:
               if (MOVE == COMMON.ABANDON)
               {
                  PRINT(AT(START_COL, THIS_ROW) + TITLE_COLOR_VID + (PROMPT_MESS + "."));
               }
               // BEGIN CASE
               // CASE
               if (MOVE == COMMON.ABANDON && LOCATE_TEXT != "")
               {
                  MOVE = "x";
                  PRINT(NRM_VID);
               }// CASE
               else if (MOVE == COMMON.ABANDON)
               {
                  do
                  {
                     INPUTCR(out A, -1);
                     B = KEYIN();
                     if (B != "" || A == 49) break;
                  } while (true);
                  if (B == CHAR(8))
                  {
                     MOVE = "x";
                  }
                  PRINT(AT(0, 0) + NRM_VID);
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
                  OPTION_SELECTED = MAX_DISPLAY;
                  L0100();
               }// CASE
               else if (MOVE == "/")
               {
                  LOCATE_TEXT = "/";
                  MOVE = INIT;
               }// CASE
               else if (OCONV(MOVE, "MCA") != "" && LEN(LOCATE_TEXT) < 20 || (MOVE == " " && LOCATE_TEXT > 0))
               {
                  KEEP_LOCATE = TRUE;
                  DF_START = DF;
                  LOCATE_TEXT = LOCATE_TEXT + MOVE;
                  COMPL = FALSE;
                  LTL = LEN(LOCATE_TEXT);
                  for (DF = DF_START; DF <= MAX_DISPLAY && NOT(COMPL); DF += 1)
                  {
                     if (OCONV(OPTION_LIST[DF, 2].Substring(1, LTL), "MCU") == OCONV(LOCATE_TEXT, "MCU"))
                     {
                        START = DF;
                        OPTION_SELECTED = DF;
                        COMPL = TRUE;
                        L0100();
                     }
                  }
                  //!              IF NOT(COMPL) THEN LOCATE.TEXT = OLD.LOCATE
               }// CASE
               else if (SEQ(MOVE) == 8)
               {
                  // Backspace
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
                  for (DF = DF_START; DF <= MAX_DISPLAY && NOT(COMPL); DF += 1)
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
                  if (LAST_LINE > MAX_DISPLAY)
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
                     if (KEYJUST != "L#0")
                     {
                        TYPE_DESC = " " + FORMAT(OPTION_LIST[OPTION_SELECTED, 1], KEYJUST) + " " + FORMAT(TYPE_DESC, TYPE_JUST);
                     }
                     else
                     {
                        TYPE_DESC = " " + FORMAT(TYPE_DESC, TYPE_JUST);
                     }
                     THIS_ROW = START_ROW + (POINTER - START) + 1;
                     PRINT(AT(START_COL, THIS_ROW) + BOX_BACK_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                     OPTION_SELECTED = OPTION_SELECTED - 1;
                     TYPE_DESC = OPTION_LIST[OPTION_SELECTED, 2];
                     if (KEYJUST == "L#0")
                     {
                        TYPE_DESC = ">" + FORMAT(TYPE_DESC, TYPE_JUST);
                     }
                     else
                     {
                        TYPE_DESC = ">" + FORMAT(OPTION_LIST[OPTION_SELECTED, 1], KEYJUST) + " " + FORMAT(TYPE_DESC, TYPE_JUST);
                     }
                     POINTER = POINTER - 1;
                     THIS_ROW = THIS_ROW - 1;
                     if (POINTER == 1)
                     {
                        PRINT(AT(START_COL, THIS_ROW) + FSTLAST_COLOR_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                     }
                     else
                     {
                        PRINT(AT(START_COL, THIS_ROW) + THISONE_COLOR_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                     }
                  }
               }// CASE
               else if (MOVE == DOWNWARDS || MOVE == KEY_DOWN)
               {
                  if (LAST_LINE == OPTION_SELECTED || OPTION_SELECTED == MAX_DISPLAY)
                  {
                     if (OPTION_SELECTED != MAX_DISPLAY)
                     {
                        START = OPTION_SELECTED + 1;
                        if ((START + WINDOW_DEPTH) > MAX_DISPLAY)
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
                     if (KEYJUST != "L#0")
                     {
                        TYPE_DESC = " " + FORMAT(OPTION_LIST[OPTION_SELECTED, 1], KEYJUST) + " " + FORMAT(TYPE_DESC, TYPE_JUST);
                     }
                     else
                     {
                        TYPE_DESC = " " + FORMAT(TYPE_DESC, TYPE_JUST);
                     }
                     THIS_ROW = START_ROW + (POINTER - START) + 1;
                     PRINT(AT(START_COL, THIS_ROW) + BOX_BACK_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                     OPTION_SELECTED = OPTION_SELECTED + 1;
                     TYPE_DESC = OPTION_LIST[OPTION_SELECTED, 2];
                     if (KEYJUST != "L#0")
                     {
                        TYPE_DESC = ">" + FORMAT(OPTION_LIST[OPTION_SELECTED, 1], KEYJUST) + " " + FORMAT(TYPE_DESC, TYPE_JUST);
                     }
                     else
                     {
                        TYPE_DESC = ">" + FORMAT(TYPE_DESC, TYPE_JUST);
                     }
                     POINTER = POINTER + 1;
                     THIS_ROW = THIS_ROW + 1;
                     if (POINTER == MAX_DISPLAY)
                     {
                        PRINT(AT(START_COL, THIS_ROW) + FSTLAST_COLOR_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                     }
                     else
                     {
                        PRINT(AT(START_COL, THIS_ROW) + THISONE_COLOR_VID + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
                     }
                  }
               }// CASE
               else if (MOVE == "_")
               {
                  LOCATE_TEXT = "_" + KEYIN();
                  MOVE = "";
               }// CASE
               else if (MOVE == INIT)
               {
                  // CHOSEN SHOW
               }
               // END CASE
               if (MOVE == "" || MOVE == COMMON.ABANDON) break;
               if (KEEP_LOCATE == FALSE)
               {
                  LOCATE_TEXT = "";
                  DF_START = 1;
                  DF = 1;
               }
            } while (true);
            //       FOR LINE = START.ROW TO START.ROW + WINDOW.REC<1>
            //         PRINT @(START.COL,LINE):EOL:
            //       NEXT LINE
            if (MOVE == COMMON.ABANDON)
            {
               TYPE_CODE = COMMON.ABANDON;
               INTERACT = COMMON.ABANDON;
               // PUT CURSOR KEYS BACK TO NORMAL AND PASTE BACK DISPLAY
               if (!READ(ref TERMINAL_CONTROL_REC, FL_CURSOR, MACHINE_TYPE + "*" + TERMINAL_TYPE + "*CONTROL")) { FL_CURSOR_ERROR = 1; }
               KEY_UP = TERMINAL_CONTROL_REC[7];
               KEY_DOWN = TERMINAL_CONTROL_REC[9];
               KEY_LEFT = TERMINAL_CONTROL_REC[6];
               KEY_RIGHT = TERMINAL_CONTROL_REC[8];
               PRINT(NRM_VID);
               PRINTCR(CHAR(28) + "30," + KEY_UP + "," + KEY_DOWN + "," + KEY_LEFT + "," + KEY_RIGHT + CHAR(20));
               if (COPY_DISPLAY)
               {
                  PRINTCR(CHAR(28) + "37,0,0" + CHAR(20));
               }
               return;
            }
            TYPE_CODE = OPTION_LIST[OPTION_SELECTED, 1];
            RESP = "Y";
         } while (true);
         // PUT CURSOR KEYS BACK TO NORMAL AND PASTE BACK DISPLAY
         if (!READ(ref TERMINAL_CONTROL_REC, FL_CURSOR, MACHINE_TYPE + "*" + TERMINAL_TYPE + "*CONTROL")) { FL_CURSOR_ERROR = 1; }
         KEY_UP = TERMINAL_CONTROL_REC[7];
         KEY_DOWN = TERMINAL_CONTROL_REC[9];
         KEY_LEFT = TERMINAL_CONTROL_REC[6];
         KEY_RIGHT = TERMINAL_CONTROL_REC[8];
         PRINTCR(CHAR(28) + "30," + KEY_UP + "," + KEY_DOWN + "," + KEY_LEFT + "," + KEY_RIGHT + CHAR(20));
         // Paste Display back unless display only is required
         if (DISPLAY_ONLY == FALSE)
         {
            if (COPY_DISPLAY)
            {
               PRINTCR(CHAR(28) + "37,0,0" + CHAR(20));
            }
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
            //IF TYPE.DESC # "" THEN
            THIS_ROW = START_ROW + (LINE - START) + 1;
            THIS_COLOR = BOX_BACK_VID;
            THIS_INDICATOR = " ";
            if (LINE == OPTION_SELECTED && DISPLAY_ONLY == FALSE)
            {
               THIS_INDICATOR = ">";
               if (LINE == 1 || LINE == MAX_DISPLAY)
               {
                  THIS_COLOR = FSTLAST_COLOR_VID;
               }
               else
               {
                  THIS_COLOR = THISONE_COLOR_VID;
               }
               POINTER = LINE;
            }
            if (KEYJUST != "L#0")
            {
               TYPE_DESC = THIS_INDICATOR + FORMAT(OPTION_LIST[LINE, 1], KEYJUST) + " " + FORMAT(TYPE_DESC, TYPE_JUST);
            }
            else
            {
               TYPE_DESC = THIS_INDICATOR + FORMAT(TYPE_DESC, TYPE_JUST);
            }
            PRINT(AT(START_COL, THIS_ROW) + THIS_COLOR + FORMAT(TYPE_DESC, WINDOW_JUST) + NRM_VID + " ");
            //       END
         }
         if (THIS_ROW < WINDOW_DEPTH + START_ROW)
         {
            for (THIS_ROW = THIS_ROW + 1; THIS_ROW <= WINDOW_DEPTH + START_ROW + 1; THIS_ROW += 1)
            {
               PRINT(AT(START_COL, THIS_ROW) + BOX_BACK_VID + FORMAT(" ", WINDOW_JUST) + NRM_VID + " ");
            }
         }
         return;
      }
   }
}
