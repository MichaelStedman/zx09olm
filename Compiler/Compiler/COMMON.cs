namespace Compiler {
class COMMON {
public UvVar[] DATA_REC = new UvVar[100];
public UvVar[] ITEM_ID = new UvVar[100];
public UvVar[] FILES = new UvVar[120];
public UvVar[] USER_FILES = new UvVar[20];
public UvVar PORT_NUMBER = "";
public UvVar TERMINAL_TYPE = "";
public UvVar MACHINE_TYPE = "";
public UvVar U_INITS = "";
public UvVar TODAYS_DATE = "";
public UvVar PASSWORD = "";
public UvVar PRV_CODE = "";
public UvVar USER_STATUS = "";
public UvVar BELL = "";
public UvVar MD2 = "";
public UvVar MTS = "";
public UvVar D2 = "";
public UvVar ERR_LINE = "";
public UvVar CLR_ERR = "";
public UvVar ALL_CLEAR = "";
public UvVar WASH = "";
public UvVar EOL = "";
public UvVar EOS = "";
public UvVar REV_VID = "";
public UvVar DIM_REV_VID = "";
public UvVar DIM_VID = "";
public UvVar NRM_VID = "";
public UvVar DIM_REV_UND_VID = "";
public UvVar REV_UND_VID = "";
public UvVar UND_VID = "";
public UvVar DIM_UND_VID = "";
public UvVar BLINK_VID = "";
public UvVar CUR_BACK = "";
public UvVar CUR_DOWN = "";
public UvVar CUR_UP = "";
public UvVar CUR_RIGHT = "";
public UvVar SLAVE_ON = "";
public UvVar SLAVE_OFF = "";
public UvVar SLAVE_DBL_WID_ON = "";
public UvVar SLAVE_DBL_WID_OFF = "";
public UvVar SLAVE_RED_ON = "";
public UvVar SLAVE_RED_OFF = "";
public UvVar SLAVE_DRAWER_OPEN = "";
public UvVar FORM_FEED = "";
public UvVar LINE_FEED = "";
public UvVar MENU_HEAD_BACK = "";
public UvVar MENU_HEAD_FORE = "";
public UvVar MENU_NOS = "";
public UvVar MENU_TEXT = "";
public UvVar MENU_BACK = "";
public UvVar SCREEN_HEAD_BACK = "";
public UvVar SCREEN_HEAD_FORE = "";
public UvVar SCREEN_BACK = "";
public UvVar SCREEN_TEXT = "";
public UvVar SCREEN_TEXT2 = "";
public UvVar SCREEN_DATA = "";
public UvVar SCREEN_FOOT_BACK = "";
public UvVar SCREEN_FOOT_FORE = "";
public UvVar SCREEN_FOOT_FORE2 = "";
public UvVar ERR_MESS_BACK = "";
public UvVar ERR_MESS_FORE = "";
public UvVar TOP_HALF = "";
public UvVar BOT_HALF = "";
public UvVar DBL_WID_ON = "";
public UvVar DBL_WID_OFF = "";
public UvVar DBL_HEIGHT_TOP_ON = "";
public UvVar DBL_HEIGHT_TOP_OFF = "";
public UvVar DBL_HEIGHT_BOT_ON = "";
public UvVar DBL_HEIGHT_BOT_OFF = "";
public UvVar SCREEN_WIDTH = "";
public UvVar VIDEO_STYLE = "";
public UvVar DIVISOR = "";
public UvVar ABANDON = "";
public UvVar BACK = "";
public UvVar CLR = "";
public UvVar SKIP = "";
public UvVar HELP = "";
public UvVar UP = "";
public UvVar DOWN = "";
public UvVar RIGHT = "";
public UvVar LEFT = "";
public UvVar AUTH_ID = "";
public UvVar[] SP = new UvVar[30];
public UvVar GO_BACK = "";
public UvVar QUERY = "";
public UvVar CLR_ERROR = "";
public UvVar AUTHORITY_ID = "";
public UvVar TILL_NUMBER = "";
public UvVar CENTRE = "";
public UvVar AMD_KEY = "";
public UvVar AMD_REC = "";
public UvVar SCREEN_LINES = "";
public UvVar TICKET_SWITCH = "";
public UvVar[] TICKET_CODES = new UvVar[20];
public UvVar[] TICKET_CODES_POSITIONS = new UvVar[20];
public UvVar[] TICKET_CODES_USED = new UvVar[20];
public UvVar PROG_MESS = "";
public UvVar WINDOW_ACTION = "";
public UvVar FIELD_FLAG = "";
public UvVar OUTPUT_DISPLAY_SCREEN = "";
public UvVar X = "";
public UvVar Y = "";
public UvVar COLOR_X = "";
public UvVar COLOR_BAR = "";
public UvVar COLOR_A = "";
public UvVar COLOR_B = "";
public UvVar COLOR_C = "";
public UvVar COLOR_D = "";
public UvVar COLOR_E = "";
public UvVar COLOR_F = "";
public UvVar DISP_OFF = "";
public UvVar DISP_LINE = "";
public UvVar DISP_BLOCK = "";
public UvVar CLIENT_APP_TYPE = "";
static readonly COMMON instance = new COMMON();
COMMON() {
}
public static COMMON Instance {
get { return instance; }
}
// Explicit static constructor to tell C# compiler
// not to mark type as beforefieldinit
static COMMON() { }
}
}
