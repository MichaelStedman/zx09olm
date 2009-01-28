//using LF1.Universe;
//using IBMU2.UODOTNET;
namespace Compiler
{
   public class FL_WINTI_SOCKET : UvBase
   {
      #region Common instances
      COMMON COMMON = COMMON.Instance;
      TXLOG TXLOG = TXLOG.Instance;
      #endregion
      #region Int Constants
      readonly UvVar TRUE = 1;
      readonly UvVar FALSE = 0;
      readonly UvVar OTHERWISE = 1;
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
      #region Variables
      UvVar TX_DATA = "";
      UvVar RX_DATA = "";
      UvVar CHIP = "";
      UvVar CALLING_PROG = "";
      UvVar INTERACT = "";
      UvVar PORT_NAME = "";
      UvVar PORT_NUMBER = "";
      UvVar VM = "";
      UvVar FL_EFT_SHARE = "";
      UvVar VERBOSE = "";
      UvVar SOCKETINFO = "";
      UvVar reoptVar = "";
      UvVar wroptVar = "";
      UvVar REUSEADDR = "";
      UvVar ZZZ_CONVERT = "";
      UvVar FM = "";
      UvVar POP3 = "";
      UvVar RESULT = "";
      UvVar protocolLogging = "";
      UvVar INADDR = "";
      UvVar INNAME = "";
      UvVar EFT_CONNECT = "";
      UvVar SERVER_IP_ADDRESS = "";
      UvVar SOCKET_PORT = "";
      UvVar MODE = "";
      UvVar SOCKETHANDLE1 = "";
      UvVar SOCKETHANDLE2 = "";
      UvVar SOCKETHANDLE3 = "";
      UvVar TIMEOUT = "";
      UvVar BACKLOG = "";
      UvVar SERFLAG = "";
      UvVar SDATLEN = "";
      UvVar CDATLEN = "";
      UvVar SRDATA = "";
      UvVar CLDATA = "";
      UvVar ACTSIZ = "";
      UvVar initServerSocket = "";
      UvVar getSocketInformation = "";
      UvVar PEERFLAG = "";
      UvVar openSocket = "";
      UvVar acceptConnection = "";
      UvVar writeSocket = "";
      UvVar readSocket = "";
      UvVar setSocketOptions = "";
      UvVar getSocketOptions = "";
      UvVar MXVARS = "";
      UvVar I = "";
      UvVar FMT = "";
      UvVar DONE = "";
      UvVar P = "";
      UvVar RESULTTEXT = "";
      UvVar closeSocket = "";
      FL_EFT_STATUS FL_EFT_STATUS;
      UvVar EFT_REPLY = "";
      #endregion
      #region Non Referenced Vars used by CALLs
      UvVar nrf0 = "";
      UvVar nrf1 = "";
      UvVar nrf2 = "";
      UvVar nrf3 = "";
      #endregion
      public FL_WINTI_SOCKET(ref UvVar TX_DATA, ref UvVar RX_DATA, ref UvVar CHIP, ref UvVar CALLING_PROG, ref UvVar INTERACT, ref UvVar PORT_NAME)
      {
         this.TX_DATA = TX_DATA;
         this.RX_DATA = RX_DATA;
         this.CHIP = CHIP;
         this.CALLING_PROG = CALLING_PROG;
         this.INTERACT = INTERACT;
         this.PORT_NAME = PORT_NAME;
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
         /*  This program originated from the IBM documentation and has been amended to suit flex */
         #region INCLUDE FL.FILES FL.EFT.SHARE

         if (OPEN("FL.EFT.SHARE*" + PORT_NUMBER, out FL_EFT_SHARE))
         {
         }
         else
         {
            if (!OPEN("FL.EFT.SHARE", out FL_EFT_SHARE)) { STOP(201, "FL.EFT.SHARE"); }
         }

         #endregion
         if (CHIP == INIT || CHIP == "")
         {
            CHIP = FALSE;
         }
         VERBOSE = FALSE;
         SOCKETINFO = "";
         /* *** Declare variables */
         reoptVar = "DEBUG,REUSEADDR,KEEPALIVE,DONTROUTE,LINGER,OOBINLINE,SNDBUF,RCVBUF,TYPE,ERROR";
         wroptVar = "DEBUG,REUSEADDR,KEEPALIVE,DONTROUTE,LINGER,OOBINLINE,SNDBUF,RCVBUF,TYPE,ERROR";
         REUSEADDR = "1";
         //ZZZ_CONVERT
         //","
         POP3 = AT(0, 0);
         INTERACT = VALID_DATA;
         /*  * * */
         /* *** Specify Protocol Logging information */
         //RESULT = protocolLogging["", "ON"];
         INADDR = "";
         INNAME = "";
         /* *** Specify server name and assign handles to each socket */
         if (!(READ(ref EFT_CONNECT, FL_EFT_SHARE, "EFT.CONNECT")))
         {
            EFT_CONNECT = "127.0.0.1" + VM + "Winti Host";
            EFT_CONNECT[2] = "1024" + VM + "WinTi Port";
            EFT_CONNECT[3] = 1 + VM + "Mode";
            EFT_CONNECT[4] = 10000 + VM + "Timeout";
            EFT_CONNECT[5] = "127.0.0.1" + VM + "Ilink Host(CHIP)";
            EFT_CONNECT[6] = "29000" + VM + "Ilink Port";
            EFT_CONNECT[7] = 1 + VM + "Socket Mode Enabled";
            WRITE(EFT_CONNECT, FL_EFT_SHARE, "EFT.CONNECT");
         }
         if (CHIP)
         {
            SERVER_IP_ADDRESS = EFT_CONNECT[5, 1];
            /* HOST NAME */
            SOCKET_PORT = EFT_CONNECT[6, 1];
         }
         else
         {
            SERVER_IP_ADDRESS = EFT_CONNECT[1, 1];
            /* HOST NAME */
            SOCKET_PORT = EFT_CONNECT[2, 1];
         }
         MODE = EFT_CONNECT[3, 1];
         /*  0=non-blocking, 1=blocking */
         SOCKETHANDLE1 = "";
         /*  Client handle */
         SOCKETHANDLE2 = "";
         /*  Server handle */
         SOCKETHANDLE3 = "";
         /*  Acceptor handle */
         TIMEOUT = EFT_CONNECT[4, 1];
         /*  milliseconds */
         BACKLOG = "2048";
         SERFLAG = "-1";
         /*  Self end = Server */
         /* ******************** */
         /*  CONNECT TO SOCKET * */
         /* ******************** */
         L0100();
         /*  Connect to socket (WINTI) */
         L0200();
         /*  Wake the socket */
         if (INTERACT == INVALID_DATA)
         {
            L0600();
            /*  CLOSE SOCKET */
            return;
         }
         /* * Generate Credit Card Request */
         SDATLEN = "";
         CDATLEN = "";
         SRDATA = TX_DATA;
         CLDATA = "";
         ACTSIZ = "";
         /* ** */
         /*  Write request & wait for WINTI to complete the action */
         /* ** */
         L0500();
         /*  Disconnect */
         L0600();
         RX_DATA = CLDATA;
         return;
         /* ********************************************************** */
      }
      void L0100()
      {
         /*  Connect to socket */
         /* *** Initialize the Server Socket */
         RESULT = initServerSocket[SERVER_IP_ADDRESS, SOCKET_PORT];
         /* *** Get information from the socket */
         RESULT = getSocketInformation[SOCKETHANDLE2, SERFLAG];
         if (SOCKETINFO != "" && VERBOSE)
         {
            CRTCR("Server Socket Info");
            CRTCR("-----------");
            CRTCR("Status : " + SOCKETINFO[1, 1]);
            CRTCR("Host : " + SOCKETINFO[1, 2]);
            CRTCR("Port :" + SOCKETINFO[1, 3]);
            CRTCR("Secure : " + SOCKETINFO[1, 4]);
            CRTCR("Mode :" + SOCKETINFO[1, 5]);
         }
         PEERFLAG = "0";
         /* *** Open a Client Socket */
         if (VERBOSE)
         {
            CRTCR("Opening Client");
         }
         RESULT = openSocket[SERVER_IP_ADDRESS, SOCKET_PORT];
         if (VERBOSE)
         {
            CRTCR("Result of client open = " + RESULT);
         }
         /* *** Get information from the Client Socket */
         RESULT = getSocketInformation[SOCKETHANDLE1, PEERFLAG];
         if (VERBOSE)
         {
            CRTCR("Client Socket Info");
            CRTCR("-----------");
            CRTCR("Status : " + SOCKETINFO[1, 1]);
            CRTCR("Host : " + SOCKETINFO[1, 2]);
            CRTCR("Port :" + SOCKETINFO[1, 3]);
            CRTCR("Secure : " + SOCKETINFO[1, 4]);
            CRTCR("Mode :" + SOCKETINFO[1, 5]);
            CRTCR("");
            /* *** Accept Connections on Server */
            CRTCR("Server Accepting connections");
         }
         RESULT = acceptConnection[SOCKETHANDLE2, MODE];
         if (VERBOSE)
         {
            CRTCR("Connection ACCEPT Status = " + RESULT);
         }
         return;
      }
      void L0200()
      {
         /*  Wake the socket */
         /*  Wake the socket (Write to and Read from the Socket) */
         SDATLEN = "";
         CDATLEN = "";
         if (CHIP)
         {
            SRDATA = "";
         }
         else
         {
            SRDATA = "Hello Server with this test to see the display and count";
         }
         CLDATA = "";
         ACTSIZ = "";
         RESULT = writeSocket[SOCKETHANDLE1, SRDATA];
         if (VERBOSE)
         {
            CRTCR("Wrote status = " + RESULT);
         }
         RESULT = readSocket[SOCKETHANDLE3, CLDATA];
         if (VERBOSE)
         {
            CRTCR("Read status = " + RESULT);
            /* CRT */
            CRTCR(" Value of inbuf = " + CLDATA);
            CRTCR(" Actual size of data = " + ACTSIZ);
            CRTCR(" Value of in_addr = " + INADDR);
            CRTCR(" Value of in_name = " + INNAME);
            CRT();
         }
         /* *** Set the socket options */
         /* wroptVar=�SNDBUF�:@VM:8192:@FM:�RCVBUF�:@VM:16384 */
         RESULT = setSocketOptions[SOCKETHANDLE2, wroptVar];
         if (VERBOSE)
         {
            CRTCR(" Set options is : " + RESULT);
         }
         /* *** Get the socket options */
         RESULT = getSocketOptions[SOCKETHANDLE1, reoptVar];
         if (VERBOSE)
         {
            CRTCR("Result of get socket handle Options is : " + RESULT);
            CRTCR("get socket options list");
         }
         MXVARS = DCOUNT(reoptVar, AT(FM));
         if (reoptVar[10, 2] != 0)
         {
            CRTCR("An error has occurred  - Check WinTI is running");
            for (I = 1; I <= MXVARS; I += 1)
            {
               //PRINTCR(FMT[reoptVar[I, 1], "L#10"]);
            }
            INTERACT = INVALID_DATA;
            return;
         }
         return;
      }
      void L0500()
      {
         /*  Write request and wait for response from WinTI */
         RESULT = writeSocket[SOCKETHANDLE1, SRDATA];
         if (VERBOSE)
         {
            CRTCR("Wrote status = " + RESULT);
         }
         DONE = FALSE;
         for (P = 1; P <= 300 && NOT(DONE || RESULT != 0); P += 1)
         {
            RESULT = readSocket[SOCKETHANDLE1, CLDATA];
            if (VERBOSE)
            {
               CRTCR("Read status = " + RESULT);
            }
            RESULTTEXT = FIELD(CLDATA, ",", 17);
            /*         CRT RESULTTEXT */
            L0700();
            if (VERBOSE)
            {
               CRTCR(" Actual size of data = " + ACTSIZ);
               CRTCR(" Value of in_addr = " + INADDR);
               CRTCR(" Value of in_name = " + INNAME);
               CRT();
            }
            if (FIELD(CLDATA, ",", 2) == 1)
            {
               DONE = TRUE;
            }
            RQM();
         }
         if (RESULT != 0)
         {
            CRTCR("AN ERROR HAS OCCURRED - WINTI SEEMS TO HAVE STOPPED");
            INTERACT = INVALID_DATA;
         }
         if (VERBOSE)
         {
            CRTCR(" Value of inbuf = " + CLDATA);
            CRTCR(" Actual size of data = " + ACTSIZ);
            CRTCR(" Value of in_addr = " + INADDR);
            CRTCR(" Value of in_name = " + INNAME);
            CRT();
         }
         return;
      }
      void L0600()
      {
         /* *** Close each of the Sockets */
         RESULT = closeSocket[SOCKETHANDLE1];
         if (VERBOSE) { CRTCR("result of close client = " + RESULT); }
         RESULT = closeSocket[SOCKETHANDLE2];
         if (VERBOSE) { CRTCR("result of close server = " + RESULT); }
         RESULT = closeSocket[SOCKETHANDLE3];
         if (VERBOSE) { CRTCR("result of close Acceptor = " + RESULT); }
         if (VERBOSE) { CRT(); }
         return;
         /* ************** */
      }
      void L0700()
      {
         /*  UPDATE PROGRESS */
         /* ********************* */
         if (CALLING_PROG != "FWEFT" && CALLING_PROG != "FL.EFT.NET")
         {
            /*  write the result so that status program can display it */
            WRITE(CLDATA, FL_EFT_SHARE, "T000" + PORT_NAME + ".OUT");
            nrf0 = "";
            nrf1 = 1;
            nrf2 = "";
            nrf3 = 0;
            FL_EFT_STATUS = new FL_EFT_STATUS(ref PORT_NAME, ref nrf0, ref nrf1, ref nrf2, ref nrf3, ref EFT_REPLY, ref CALLING_PROG);
         }
         /* !*  END */
         return;
      }
   }
}
