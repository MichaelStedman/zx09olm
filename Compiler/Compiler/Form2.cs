using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Compiler
{
   public partial class Form2 : Form
   {
      string inputPath = "C:\\IBM\\accounts\\lflex";
      string inputFile = "LFLEX.PROGS";
      public Form2()
      {
         InitializeComponent();
      }

      private void Form2_Load(object sender, EventArgs e)
      {
         List<string> convertedFileNames = new List<string>();
         DirectoryInfo dir = new DirectoryInfo("C:\\Users\\mhs\\Documents\\Visual Studio 2008\\Projects\\Legacy\\Legacy\\LF");
         foreach (FileInfo file in dir.GetFiles())
         {
            string origFileName = file.Name.ToString().Replace('_', '.');
            convertedFileNames.Add(origFileName.Substring(0,origFileName.Length-3));
         }

         dir = new DirectoryInfo("C:\\IBM\\accounts\\lflex\\LFLEX.PROGS");
         foreach (FileInfo file in dir.GetFiles())
         {
            listBox1.Items.Add(file.Name.ToString());
            if (!convertedFileNames.Contains(file.Name.ToString()))
            {
               listBox2.Items.Add(file.Name.ToString());
            }
         }
      }

      private void listBox1_DoubleClick(object sender, EventArgs e)
      {
         string inputItem = (sender as ListBox).SelectedItem.ToString();
         ConverterEvening c = new ConverterEvening();
         c.ConvertFile(inputPath, inputFile, inputItem, "C:\\Users\\mhs\\Documents\\Visual Studio 2008\\Projects\\Legacy\\Legacy", "LF", inputItem);
      }

      private void listBox2_DoubleClick(object sender, EventArgs e)
      {
         string inputItem = (sender as ListBox).SelectedItem.ToString();
         listBox3.Items.Add(inputItem);
         ConverterEvening c = new ConverterEvening();
         c.ConvertFile(inputPath, inputFile, inputItem, "C:\\Users\\mhs\\Documents\\Visual Studio 2008\\Projects\\Legacy\\Legacy", "LF", inputItem);
      }

      private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
   }
}
