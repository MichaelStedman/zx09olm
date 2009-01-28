using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compiler
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }
      private void RunPass1TestWithParse(string testName, string inputText, string expectedResult)
      {
         Symbol[] symbolList;
         string[] tokenList;

         ConverterEvening c = new ConverterEvening();

         c.Parse(inputText, out symbolList, out tokenList);

         c.Pass1(symbolList, tokenList);

         //if (result == (expectedResult + "\r\n"))
         //{
         //   listBox1.Items.Add(testName + " Success");
         //}
         //else
         //{
         //   listBox1.Items.Add(testName + " Failed");
         //   listBox1.Items.Add("Result  :" + result);
         //   listBox1.Items.Add("Expected:" + expectedResult);
         //}
      }
      private void RunCompileTestWithParse(string testName, string inputText, string expectedResult)
      {
         Symbol[] symbolList;
         string[] tokenList;

         ConverterEvening c = new ConverterEvening();

         c.Parse(inputText, out symbolList, out tokenList);

         string result = c.Compile(symbolList, tokenList);

         if (result == (expectedResult + "\r\n"))
         {
            listBox1.Items.Add(testName + " Success");
         }
         else
         {
            listBox1.Items.Add(testName + " Failed");
            listBox1.Items.Add("Result  :" + result);
            listBox1.Items.Add("Expected:" + expectedResult);
         }
      }
      private void RunTestWithParse(string testName, string inputText, string expectedResult)
      {
         Symbol[] symbolList;
         string[] tokenList;

         ConverterEvening c = new ConverterEvening();

         c.Parse(inputText, out symbolList, out tokenList);

         string result = c.Convert(symbolList, tokenList);

         if (result == expectedResult)
         {
            listBox1.Items.Add(testName + " Success");
         }
         else
         {
            listBox1.Items.Add(testName + " Failed");
            listBox1.Items.Add("Result  :" + result);
            listBox1.Items.Add("Expected:" + expectedResult);
         }
      }
      private void RunTest(string testName, string expectedResult, Symbol[] symbolList, string[] tokenList)
      {
         ConverterEvening c = new ConverterEvening();

         //c.Parse(expectedResult, out symbolList, out tokenList);

         string result = c.Convert(symbolList, tokenList);

         if (result == expectedResult)
         {
            listBox1.Items.Add(testName + " Success");
         }
         else
         {
            listBox1.Items.Add(testName + " Failed");
            listBox1.Items.Add("Result  :" + result);
            listBox1.Items.Add("Expected:" + expectedResult);
         }
      }
      private void btnRunAll_Click(object sender, EventArgs e)
      {
         listBox1.Items.Clear();
         button1_Click(sender, e);
         button2_Click(sender, e);
         button3_Click(sender, e);
         button4_Click(sender, e);
         button5_Click(sender, e);
         button6_Click(sender, e);
         button7_Click(sender, e);
         button8_Click(sender, e);
         button9_Click(sender, e);
         button10_Click(sender, e);
         button11_Click(sender, e);
         button12_Click(sender, e);
         button13_Click(sender, e);
         button14_Click(sender, e);
         button15_Click(sender, e);
         button16_Click(sender, e);
         button17_Click(sender, e);
         button18_Click(sender, e);
         button19_Click(sender, e);
         button20_Click(sender, e);
         button21_Click(sender, e);
         button22_Click(sender, e);
         button23_Click(sender, e);
         button24_Click(sender, e);
         button25_Click(sender, e);
         button26_Click(sender, e);
         button27_Click(sender, e);
         button28_Click(sender, e);
         button29_Click(sender, e);
         button30_Click(sender, e);
         button31_Click(sender, e);
         button32_Click(sender, e);
         button33_Click(sender, e);
         button34_Click(sender, e);
         button35_Click(sender, e);
         button36_Click(sender, e);
         button37_Click(sender, e);
         button38_Click(sender, e);
         button39_Click(sender, e);
         button40_Click(sender, e);
         button41_Click(sender, e);
         button42_Click(sender, e);
         button43_Click(sender, e);
         button44_Click(sender, e);
         button45_Click(sender, e);
         button46_Click(sender, e);
         button47_Click(sender, e);
         button48_Click(sender, e);
         button49_Click(sender, e);
         button50_Click(sender, e);
         button51_Click(sender, e);
         button52_Click(sender, e);
      }
      private void button1_Click(object sender, EventArgs e)
      {
         string expectedResult = "A[B] > C";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.gt;
         symbolList[4] = Symbol.gt;
         symbolList[5] = Symbol.ident; identList[5] = "C";

         RunTest("Test 1", expectedResult, symbolList, identList);
         RunTestWithParse("Test1a", "A<B> > C", expectedResult);
      }

      private void button2_Click(object sender, EventArgs e)
      {
         string expectedResult = "A < B";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt2;
         symbolList[2] = Symbol.ident; identList[2] = "B";

         RunTest("Test 2", expectedResult, symbolList, identList);
         RunTestWithParse("Test2a", "A < B", expectedResult);
      }

      private void button3_Click(object sender, EventArgs e)
      {
         string expectedResult = "A[B, C]";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.comma;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.gt;

         RunTest("Test 3", expectedResult, symbolList, identList);
         RunTestWithParse("Test3a", "A<B,C>", expectedResult);
      }

      private void button4_Click(object sender, EventArgs e)
      {
         string expectedResult = "A[B, C, D]";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.comma;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.comma;
         symbolList[6] = Symbol.ident; identList[6] = "D";
         symbolList[7] = Symbol.gt;

         RunTest("Test 4", expectedResult, symbolList, identList);
         RunTestWithParse("Test4a", "A<B,C,D>", expectedResult);
      }

      private void button5_Click(object sender, EventArgs e)
      {
         string expectedResult = "A[B] > C";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.gt;
         symbolList[4] = Symbol.gt;
         symbolList[5] = Symbol.ident; identList[5] = "C";

         RunTest("Test 5", expectedResult, symbolList, identList);
         RunTestWithParse("Test5a", "A<B> > C", expectedResult);
      }

      private void button6_Click(object sender, EventArgs e)
      {
         string expectedResult = "A < B[C]";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.lt;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.gt;

         RunTest("Test 6", expectedResult, symbolList, identList);
         RunTestWithParse("Test6a", "A < B<C>", expectedResult);
      }

      private void button7_Click(object sender, EventArgs e)
      {
         string expectedResult = "A < B[C, D, E]";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.lt;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.comma;
         symbolList[6] = Symbol.ident; identList[6] = "D";
         symbolList[7] = Symbol.comma;
         symbolList[8] = Symbol.ident; identList[8] = "E";
         symbolList[9] = Symbol.gt;

         RunTest("Test 7", expectedResult, symbolList, identList);
         RunTestWithParse("Test7a", "A < B<C,D,E>", expectedResult);
      }

      private void button8_Click(object sender, EventArgs e)
      {
         string expectedResult = "A[B[C, D, E]]";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.lt;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.comma;
         symbolList[6] = Symbol.ident; identList[6] = "D";
         symbolList[7] = Symbol.comma;
         symbolList[8] = Symbol.ident; identList[8] = "E";
         symbolList[9] = Symbol.gt;
         symbolList[10] = Symbol.gt;

         RunTest("Test 8", expectedResult, symbolList, identList);
         RunTestWithParse("Test8a", "A<B<C,D,E>>", expectedResult);
      }

      private void button9_Click(object sender, EventArgs e)
      {
         string expectedResult = "A < B[C, D, E] && G > H";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.lt;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.comma;
         symbolList[6] = Symbol.ident; identList[6] = "D";
         symbolList[7] = Symbol.comma;
         symbolList[8] = Symbol.ident; identList[8] = "E";
         symbolList[9] = Symbol.gt;
         symbolList[10] = Symbol.and;
         symbolList[11] = Symbol.ident; identList[11] = "G";
         symbolList[12] = Symbol.gt;
         symbolList[13] = Symbol.ident; identList[13] = "H";

         RunTest("Test 9", expectedResult, symbolList, identList);
         RunTestWithParse("Test9a", "A < B<C,D,E> AND G > H", expectedResult);
      }

      private void button10_Click(object sender, EventArgs e)
      {
         string expectedResult = "A < B[C[D]]";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.lt;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.lt;
         symbolList[6] = Symbol.ident; identList[6] = "D";
         symbolList[7] = Symbol.gt;
         symbolList[8] = Symbol.gt;

         RunTest("Test 10", expectedResult, symbolList, identList);
         RunTestWithParse("Test10a", "A < B<C<D>>", expectedResult);
      }

      private void button11_Click(object sender, EventArgs e)
      {
         string expectedResult = "A[B]";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.openround;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.closeround;

         RunTest("Test 11", expectedResult, symbolList, identList);
         RunTestWithParse("Test11a", "A(B)", expectedResult);
      }

      private void button12_Click(object sender, EventArgs e)
      {
         string expectedResult = "A[B, C]";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.openround;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.comma;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.closeround;

         RunTest("Test 12", expectedResult, symbolList, identList);
         RunTestWithParse("Test12a", "A(B,C)", expectedResult);
      }

      private void button13_Click(object sender, EventArgs e)
      {
         string expectedResult = "A.Substring(B, C)";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.opensquare;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.comma;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.closesquare;

         RunTest("Test 13", expectedResult, symbolList, identList);
         RunTestWithParse("Test13a", "A[B,C]", expectedResult);
      }

      private void button14_Click(object sender, EventArgs e)
      {
         string expectedResult = "A[B, C].Substring(D, E)";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];
         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.comma;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.gt;
         symbolList[6] = Symbol.opensquare;
         symbolList[7] = Symbol.ident; identList[7] = "D";
         symbolList[8] = Symbol.comma;
         symbolList[9] = Symbol.ident; identList[9] = "E";
         symbolList[10] = Symbol.closesquare;

         RunTest("Test 14", expectedResult, symbolList, identList);
         RunTestWithParse("Test14a", "A<B,C>[D,E]", expectedResult);
      }

      private void button15_Click(object sender, EventArgs e)
      {
         string expectedResult = "A.Substring(B, C) > D[E]";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.opensquare;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.comma;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.closesquare;
         symbolList[6] = Symbol.gt;
         symbolList[7] = Symbol.ident; identList[7] = "D";
         symbolList[8] = Symbol.lt;
         symbolList[9] = Symbol.ident; identList[9] = "E";
         symbolList[10] = Symbol.gt;

         RunTest("Test 15", expectedResult, symbolList, identList);
         RunTestWithParse("Test15a", "A[B,C] > D<E>", expectedResult);
      }

      private void button16_Click(object sender, EventArgs e)
      {
         string expectedResult = "A.Substring(B) > C.Substring(D)";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.opensquare;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.closesquare;
         symbolList[4] = Symbol.gt;
         symbolList[5] = Symbol.ident; identList[5] = "C";
         symbolList[6] = Symbol.opensquare;
         symbolList[7] = Symbol.ident; identList[7] = "D";
         symbolList[8] = Symbol.closesquare;

         RunTest("Test 16", expectedResult, symbolList, identList);
         RunTestWithParse("Test16a", "A[B] > C[D]", expectedResult);
      }

      private void button17_Click(object sender, EventArgs e)
      {
         string expectedResult = "DIM_VID + FORMAT(MEM_PARAMS_REC[7, CODE_NUM], JUSTIF)";

         Symbol[] symbolList = new Symbol[20];
         string[] identList = new string[20];

         //DIM.VID:MEM.PARAMS.REC<7,CODE.NUM> JUSTIF
         symbolList[0] = Symbol.ident; identList[0] = "DIM.VID";
         symbolList[1] = Symbol.colon;
         symbolList[2] = Symbol.ident; identList[2] = "MEM.PARAMS.REC";
         symbolList[3] = Symbol.lt;
         symbolList[4] = Symbol.ident; identList[4] = "7";
         symbolList[5] = Symbol.comma;
         symbolList[6] = Symbol.ident; identList[6] = "CODE.NUM";
         symbolList[7] = Symbol.gt;
         symbolList[8] = Symbol.ident; identList[8] = "JUSTIF";

         RunTest("Test 17", expectedResult, symbolList, identList);
         expectedResult = "DIM_VID + FORMAT(MEM_PARAMS_REC[7, CODE_NUM], JUSTIF)";
         RunTestWithParse("Test17a", "DIM.VID:MEM.PARAMS.REC<7,CODE.NUM> JUSTIF", expectedResult);
      }


      private void button18_Click(object sender, EventArgs e)
      {
         string expectedResult = "A[B, C, D[E]] < F && G > H[I]";

         Symbol[] symbolList = new Symbol[25];
         string[] identList = new string[25];

         symbolList[0] = Symbol.ident; identList[0] = "A";
         symbolList[1] = Symbol.lt;
         symbolList[2] = Symbol.ident; identList[2] = "B";
         symbolList[3] = Symbol.comma;
         symbolList[4] = Symbol.ident; identList[4] = "C";
         symbolList[5] = Symbol.comma;
         symbolList[6] = Symbol.ident; identList[6] = "D";
         symbolList[7] = Symbol.lt;
         symbolList[8] = Symbol.ident; identList[8] = "E";
         symbolList[9] = Symbol.gt;
         symbolList[10] = Symbol.gt;
         symbolList[11] = Symbol.lt;
         symbolList[12] = Symbol.ident; identList[12] = "F";
         symbolList[13] = Symbol.and;
         symbolList[14] = Symbol.ident; identList[14] = "G";
         symbolList[15] = Symbol.gt;
         symbolList[16] = Symbol.ident; identList[16] = "H";
         symbolList[17] = Symbol.lt;
         symbolList[18] = Symbol.ident; identList[18] = "I";
         symbolList[19] = Symbol.gt;

         RunTest("Test 18", expectedResult, symbolList, identList);
         RunTestWithParse("Test18a", "A<B,C,D<E>> < F AND G > H<I>", expectedResult);
      }

      private void button19_Click(object sender, EventArgs e)
      {
         string expectedResult = "A * (B + C)";
         RunTestWithParse("Test19a", "A * (B + C)", expectedResult);
      }

      private void button20_Click(object sender, EventArgs e)
      {
         string expectedResult = "FORMAT(A * (B + C) / D, \"R#4\")";
         RunTestWithParse("Test20a", "A * (B + C) / D 'R#4'", expectedResult);
      }

      private void button21_Click(object sender, EventArgs e)
      {
         string expectedResult = "MEM_PARAMS_REC[9] != \"\" && MEM_PARAMS_REC[9].Substring(1, 1) != \"*\"";
         RunTestWithParse("Test21a", "MEM.PARAMS.REC<9> NE '' AND MEM.PARAMS.REC<9>[1,1] NE '*'", expectedResult);
      }

      private void button22_Click(object sender, EventArgs e)
      {
         string expectedResult = "AT(ST_COL, ST_ROW) + SPACE(15) + AT(ST_COL, ST_ROW) + MEMBER_NUMBER + CHAR(28) + \"403\"";
         RunTestWithParse("Test22a", "@(ST.COL,ST.ROW) : SPACE(15) :@(ST.COL,ST.ROW) : MEMBER.NUMBER : CHAR(28):\"403\"", expectedResult);
      }

      private void button23_Click(object sender, EventArgs e)
      {
         string expectedResult = "ANS.Substring(PREFIX_LEN + 1, LEN(ANS) - PREFIX_LEN)";
         RunTestWithParse("Test23a", "ANS[PREFIX.LEN+1,LEN(ANS)-PREFIX.LEN]", expectedResult);
      }

      private void button24_Click(object sender, EventArgs e)
      {
         string expectedResult = "AT(SC_POS[THE_MEMBERSHIP_TYPE, 1] + LEN(SC_POS[THE_MEMBERSHIP_TYPE, 3]) + 1, SC_POS[THE_MEMBERSHIP_TYPE, 2]) + SCREEN_DATA";
         RunTestWithParse("Test24a", "@(SC.POS<THE.MEMBERSHIP.TYPE,1>+LEN(SC.POS<THE.MEMBERSHIP.TYPE,3>)+1,SC.POS<THE.MEMBERSHIP.TYPE,2>):SCREEN.DATA", expectedResult);
      }

      private void button25_Click(object sender, EventArgs e)
      {
         string expectedResult = "A = ANS.Substring(PREFIX_LEN + 1, LEN(ANS) - PREFIX_LEN);";
         RunCompileTestWithParse("Test25b", "A = ANS[PREFIX.LEN+1,LEN(ANS)-PREFIX.LEN]", expectedResult);
      }

      private void button26_Click(object sender, EventArgs e)
      {
         string expectedResult = "PRINTCR(AT(SC_POS[THE_MEMBERSHIP_TYPE, 1] + LEN(SC_POS[THE_MEMBERSHIP_TYPE, 3]) + 1, SC_POS[THE_MEMBERSHIP_TYPE, 2]) + SCREEN_DATA);";
         RunCompileTestWithParse("Test26b", "PRINT @(SC.POS<THE.MEMBERSHIP.TYPE,1>+LEN(SC.POS<THE.MEMBERSHIP.TYPE,3>)+1,SC.POS<THE.MEMBERSHIP.TYPE,2>):SCREEN.DATA", expectedResult);
      }

      private void button27_Click(object sender, EventArgs e)
      {
         string expectedResult = "if (!(A > B)) {";
         RunCompileTestWithParse("Test27b", "IF A > B ELSE", expectedResult);
      }

      private void button28_Click(object sender, EventArgs e)
      {
         string expectedResult = "for(A = 1; A <= 10; A += 1) {";
         RunCompileTestWithParse("Test28b", "FOR A = 1 TO 10", expectedResult);
      }

      private void button29_Click(object sender, EventArgs e)
      {
         string expectedResult = "for(A = 1; A <= 10; A += 2) {";
         RunCompileTestWithParse("Test29b", "FOR A = 1 TO 10 STEP 2", expectedResult);
      }

      private void button30_Click(object sender, EventArgs e)
      {
         string expectedResult = "for(A = 1; A <= 10 && NOT(ALL_DONE == TRUE); A += 2) {";
         RunCompileTestWithParse("Test30b", "FOR A = 1 TO 10 STEP 2 UNTIL ALL.DONE=TRUE", expectedResult);
      }

      private void button31_Click(object sender, EventArgs e)
      {
         string expectedResult = "DELETE(FL_MEMBERS, MEMBER_NO);";
         RunCompileTestWithParse("Test31b", "DELETE FL.MEMBERS, MEMBER.NO", expectedResult);
      }

      private void button32_Click(object sender, EventArgs e)
      {
         string expectedResult = "INDEX_REC = DELETE(INDEX_REC, 1);";
         RunCompileTestWithParse("Test32b", "INDEX.REC = DELETE(INDEX.REC, 1)", expectedResult);
      }

      private void button33_Click(object sender, EventArgs e)
      {
         string expectedResult = "INDEX_REC = DELETE(INDEX_REC, 1, 2);";
         RunCompileTestWithParse("Test33b", "INDEX.REC = DELETE(INDEX.REC, 1, 2)", expectedResult);
      }

      private void button34_Click(object sender, EventArgs e)
      {
         string expectedResult = "INDEX_REC = DELETE(INDEX_REC, 1, 2, 3);";
         RunCompileTestWithParse("Test34b", "INDEX.REC = DELETE(INDEX.REC, 1, 2, 3)", expectedResult);
      }

      private void button35_Click(object sender, EventArgs e)
      {
         string expectedResult = "EXECUTE(\"SORT FL.MEMBERS\", string.Empty, string.Empty, string.Empty, string.Empty);";
         RunCompileTestWithParse("Test35b", "EXECUTE 'SORT FL.MEMBERS'", expectedResult);
      }

      private void button36_Click(object sender, EventArgs e)
      {
         string expectedResult = "EXECUTE(\"SORT FL.MEMBERS\", OUTPUT, string.Empty, RTN_LIST, string.Empty);";
         RunCompileTestWithParse("Test36b", "EXECUTE 'SORT FL.MEMBERS' RTNLIST RTN.LIST CAPTURING OUTPUT", expectedResult);
      }

      private void button37_Click(object sender, EventArgs e)
      {
         string expectedResult = "EXECUTE(\"SORT FL.MEMBERS\", string.Empty, PASSING, string.Empty, SETLIST);";
         RunCompileTestWithParse("Test37b", "EXECUTE 'SORT FL.MEMBERS' PASSLIST PASSING SETTING SETLIST", expectedResult);
      }

      private void button38_Click(object sender, EventArgs e)
      {
         string expectedResult = "FOOTING(\"value at foot of page \" + PAGE_NO);";
         RunCompileTestWithParse("Test38b", "FOOTING 'value at foot of page ' : PAGE.NO", expectedResult);
      }

      private void button39_Click(object sender, EventArgs e)
      {
         string expectedResult = "goto L0100;";
         RunCompileTestWithParse("Test39b", "GOTO 0100", expectedResult);
      }

      private void button40_Click(object sender, EventArgs e)
      {
         string expectedResult = "goto EndOfFile;";
         RunCompileTestWithParse("Test40b", "GOTO EndOfFile", expectedResult);
      }

      private void button41_Click(object sender, EventArgs e)
      {
         string expectedResult = "INPUTCR(out A);";
         RunCompileTestWithParse("Test41b.1", "INPUT A", expectedResult);
         expectedResult = "INPUTCR(out A, 10);";
         RunCompileTestWithParse("Test41b.2", "INPUT A,10", expectedResult);
         expectedResult = "INPUT(out A);";
         RunCompileTestWithParse("Test41b.3", "INPUT A:", expectedResult);
         expectedResult = "INPUT(out A, 10);";
         RunCompileTestWithParse("Test41b.4", "INPUT A,10:", expectedResult);
      }

      private void button42_Click(object sender, EventArgs e)
      {
         ConverterEvening c = new ConverterEvening();
         c.ConvertFile("C:\\IBM\\accounts\\lflex", "LFLEX.PROGS", "TEST", "C:\\Users\\mhs\\Documents\\Visual Studio 2008\\Projects\\MyTestProjects\\Compiler", "Compiler\\", "TEST");
      }

      private void button43_Click(object sender, EventArgs e)
      {
         string expectedResult = "if (OPEN(A, out B)) {";
         RunCompileTestWithParse("Test43b.1", "OPEN A TO B THEN", expectedResult);
         expectedResult = "if (!(OPEN(A, out B))) {";
         RunCompileTestWithParse("Test43b.2", "OPEN A TO B ELSE", expectedResult);
      }

      private void button44_Click(object sender, EventArgs e)
      {
         string expectedResult = "PROMPT(\"\");";
         RunCompileTestWithParse("Test44b.1", "PROMPT \"\"", expectedResult);
         expectedResult = "PROMPT(A);";
         RunCompileTestWithParse("Test44b.2", "PROMPT A", expectedResult);
      }

      private void button45_Click(object sender, EventArgs e)
      {
         string expectedResult = "if (READ(ref A, B, C)) {";
         RunCompileTestWithParse("Test45b.1", "READ A FROM B, C THEN", expectedResult);
         expectedResult = "if (READU(ref A, B, C)) {";
         RunCompileTestWithParse("Test45b.2", "READU A FROM B, C THEN", expectedResult);
         expectedResult = "if (READV(ref A, B, C, D)) {";
         RunCompileTestWithParse("Test45b.3", "READV A FROM B, C, D THEN", expectedResult);
         expectedResult = "if (READVU(ref A, B, C, D)) {";
         RunCompileTestWithParse("Test45b.4", "READVU A FROM B, C, D THEN", expectedResult);
      }

      private void button46_Click(object sender, EventArgs e)
      {
         string expectedResult = "WRITE(A, B, C);";
         RunCompileTestWithParse("Test46b.1", "WRITE A ON B, C", expectedResult);
         expectedResult = "if (WRITE(A, B, C)) {";
         RunCompileTestWithParse("Test46b.2", "WRITE A ON B, C THEN", expectedResult);
         expectedResult = "WRITEU(A, B, C);";
         RunCompileTestWithParse("Test46b.3", "WRITEU A ON B, C", expectedResult);
         expectedResult = "WRITEV(A, B, C, D);";
         RunCompileTestWithParse("Test46b.4", "WRITEV A ON B, C, D", expectedResult);
         expectedResult = "WRITEVU(A, B, C, D);";
         RunCompileTestWithParse("Test46b.5", "WRITEVU A ON B, C, D", expectedResult);
      }

      private void button47_Click(object sender, EventArgs e)
      {
         string expectedResult = "";
         RunPass1TestWithParse("Test47b.1", "EQU MEMBER.SURNAME TO MEMBER.REC(4), TRUE TO 1", expectedResult);
      }

      private void button48_Click(object sender, EventArgs e)
      {
         string expectedResult = "STOP();";
         RunCompileTestWithParse("Test48b.1", "STOP", expectedResult);
         expectedResult = "STOP(201);";
         RunCompileTestWithParse("Test48b.2", "STOP 201", expectedResult);
         expectedResult = "STOP(\"201\");";
         RunCompileTestWithParse("Test48b.3", "STOP \"201\"", expectedResult);
         expectedResult = "STOP(\"201\", \"message\");";
         RunCompileTestWithParse("Test48b.4", "STOP \"201\", \"message\"", expectedResult);
      }

      private void button49_Click(object sender, EventArgs e)
      {
         string expectedResult = "if (LOCATE(A, B, 1, 2, 1, ref C, D)) {";
         RunCompileTestWithParse("Test49b.1", "LOCATE(A,B,1,2;C;D) THEN", expectedResult);
         RunCompileTestWithParse("Test49b.2", "LOCATE A IN B<1,2>, 1 BY D SETTING C THEN", expectedResult);
         expectedResult = "if (LOCATE(TICKET_REC[4, MULTIVALUE], CONTROL_FEE_REC, 0, 0, 1, ref PNTR, \"AR\")) {";
         RunCompileTestWithParse("Test49b.3", "LOCATE(TICKET.REC<4,MULTIVALUE>,CONTROL.FEE.REC;PNTR;\"AR\") THEN", expectedResult);
         expectedResult = "if (LOCATE(DAY_OF_MONTH, BACS_CONTROL[1], 1, 0, 1, ref DD_POS, \"AR\")) {";
         RunCompileTestWithParse("Test49b.4", "LOCATE(DAY.OF.MONTH,BACS.CONTROL<1>,1;DD.POS;\"AR\") THEN", expectedResult);
      }

      private void button50_Click(object sender, EventArgs e)
      {
         string expectedResult = "PRINT(AT(2, 21) + \"Press <RETURN> for next page \");\r\nINPUT(out WAIT, 1);";
         RunCompileTestWithParse("Test50b.1", "PRINT @(2, 21): \"Press <RETURN> for next page \":; INPUT WAIT,1:", expectedResult);
      }

      private void button51_Click(object sender, EventArgs e)
      {
         string expectedResult = "MAT(ref A, B);";
         RunCompileTestWithParse("Test51b.1", "MAT A = B", expectedResult);
         expectedResult = "MAT(ref A, B);";
         RunCompileTestWithParse("Test51b.2", "MAT A = MAT B", expectedResult);
      }

      private void button52_Click(object sender, EventArgs e)
      {
         string expectedResult = "if (!(READNEXT(ref ID, 0, 0, \"\"))) {";
         RunCompileTestWithParse("Test52b.1", "READNEXT ID ELSE", expectedResult);
         expectedResult = "if (!(READNEXT(ref ID, 0, 0, LIST))) {";
         RunCompileTestWithParse("Test52b.2", "READNEXT ID FROM LIST ELSE", expectedResult);
         expectedResult = "if (!(READNEXT(ref ID, VALUE, 0, LIST))) {";
         RunCompileTestWithParse("Test52b.3", "READNEXT ID, VALUE FROM LIST ELSE", expectedResult);
         expectedResult = "if (!(READNEXT(ref ID, VALUE, SUBVALUE, LIST))) {";
         RunCompileTestWithParse("Test52b.4", "READNEXT ID, VALUE, SUBVALUE FROM LIST ELSE", expectedResult);
      }

      private void button53_Click(object sender, EventArgs e)
      {
         string expectedResult = "if (A == B) {";
         RunCompileTestWithParse("Test53b.1", "IF A = B THEN", expectedResult);
         expectedResult = "if (A != B) {";
         RunCompileTestWithParse("Test53b.2", "IF A <> B THEN", expectedResult);
         expectedResult = "if (A != B) {";
         RunCompileTestWithParse("Test53b.3", "IF A # B THEN", expectedResult);
         expectedResult = "if (A < B) {";
         RunCompileTestWithParse("Test53b.4", "IF A < B THEN", expectedResult);
         expectedResult = "if (A <= B) {";
         RunCompileTestWithParse("Test53b.5", "IF A <= B THEN", expectedResult);
         expectedResult = "if (A > B) {";
         RunCompileTestWithParse("Test53b.6", "IF A > B THEN", expectedResult);
         expectedResult = "if (A >= B) {";
         RunCompileTestWithParse("Test53b.7", "IF A >= B THEN", expectedResult);
      }

      private void button54_Click(object sender, EventArgs e)
      {
         string expectedResult = "A = B;";
         RunCompileTestWithParse("Test54b.1", "A = B", expectedResult);
         expectedResult = "A += B;";
         RunCompileTestWithParse("Test54b.2", "A += B", expectedResult);
         expectedResult = "A -= B;";
         RunCompileTestWithParse("Test54b.3", "A -= B", expectedResult);
         expectedResult = "A *= B;";
         RunCompileTestWithParse("Test54b.4", "A *= B", expectedResult);
         expectedResult = "A /= B;";
         RunCompileTestWithParse("Test54b.5", "A /= B", expectedResult);
         expectedResult = "A := B;";
         RunCompileTestWithParse("Test54b.6", "A := B", expectedResult);
      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void openToolStripMenuItem_Click(object sender, EventArgs e)
      {
         openFileDialog1.ShowDialog();
         string fileName = openFileDialog1.FileName;
         Array elements = fileName.Split('\\');
         StringBuilder inputPath = new StringBuilder();
         for (int i = 0; i < elements.Length - 2; i++)
         {
            inputPath.Append(elements.GetValue(i) + "\\");
         }
         string inputFile = (string)elements.GetValue(elements.Length - 2);
         string inputItem = (string)elements.GetValue(elements.Length - 1);
         ConverterEvening c = new ConverterEvening();
         c.ConvertFile(inputPath.ToString(), inputFile, inputItem, "C:\\Users\\mhs\\Documents\\Visual Studio 2008\\Projects\\Legacy\\Legacy", "LF", inputItem);
      }

      private void exp1ToolStripMenuItem_Click(object sender, EventArgs e)
      {
         
      }

      private void button55_Click(object sender, EventArgs e)
      {
         string expectedResult = "if (READ(ref A, B, C[D[4], 2] + \"*\" + E)) {";
         RunCompileTestWithParse("Test54b.1", "READ A FROM B,C<D<4>,2>:\"*\":E THEN", expectedResult);
         expectedResult = "DATA(A1, B2, C3, D4);";
         RunCompileTestWithParse("Test54b.2", "DATA A1, B2, C3, D4", expectedResult);
      }

      private void allToolStripMenuItem_Click(object sender, EventArgs e)
      {

      }
   }
   //public static class Extension
   //{
   //   public static string EXTRACT(this string value, int AttributeNumber)
   //   {
   //      return "";
   //   }
   //   public static string EXTRACT(this string value, int AttributeNumber, int ValueNumber)
   //   {
   //      return "";
   //   }
   //   public static string EXTRACT(this string value, int AttributeNumber, int ValueNumber, int SubValueNumber)
   //   {
   //      return "";
   //   }
   //   public static string INSERT(this string value, int AttributeNumber, string insertValue)
   //   {
   //      return "";
   //   }
   //   public static string DELETE(this string value, int AttributeNumber)
   //   {
   //      return "";
   //   }
   //   public static void ASSIGN(this string value, int intValue)
   //   {
   //      value = intValue.ToString();
   //   }
   //   public static void ASSIGN(this string value, string stringValue)
   //   {
   //      value = stringValue;
   //   }
   //   public static string ADD(this string value, int intValue)
   //   {
   //      return (Int32.Parse(value) + intValue).ToString();
   //   }
   //   public static string ADD(this string value, string stringValue)
   //   {
   //      return (Int32.Parse(value) + Int32.Parse(stringValue)).ToString();
   //   }
   //}
}
