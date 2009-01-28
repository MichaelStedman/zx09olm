namespace Compiler
{
   class TESTCOMMON
   {
      public UvVar[] FILES = new UvVar[110];
      public UvVar[] DATA_FILES = new UvVar[120];
      public UvVar[] FRED = new UvVar[3];
      public UvVar[] JACK = new UvVar[14];
      static readonly TESTCOMMON instance = new TESTCOMMON();
      TESTCOMMON()
      {
      }
      public static TESTCOMMON Instance
      {
         get { return instance; }
      }
      // Explicit static constructor to tell C# compiler
      // not to mark type as beforefieldinit
      static TESTCOMMON() { }
   }
}
