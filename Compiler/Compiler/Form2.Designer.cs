﻿namespace Compiler
{
   partial class Form2
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.listBox2 = new System.Windows.Forms.ListBox();
         this.listBox3 = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
         // 
         // listBox1
         // 
         this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)));
         this.listBox1.FormattingEnabled = true;
         this.listBox1.Location = new System.Drawing.Point(0, 0);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(284, 264);
         this.listBox1.TabIndex = 0;
         this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
         // 
         // listBox2
         // 
         this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)));
         this.listBox2.FormattingEnabled = true;
         this.listBox2.Location = new System.Drawing.Point(290, 0);
         this.listBox2.Name = "listBox2";
         this.listBox2.Size = new System.Drawing.Size(284, 264);
         this.listBox2.TabIndex = 1;
         this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
         this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
         // 
         // listBox3
         // 
         this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)));
         this.listBox3.FormattingEnabled = true;
         this.listBox3.Location = new System.Drawing.Point(580, 0);
         this.listBox3.Name = "listBox3";
         this.listBox3.Size = new System.Drawing.Size(284, 264);
         this.listBox3.TabIndex = 2;
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(866, 264);
         this.Controls.Add(this.listBox3);
         this.Controls.Add(this.listBox2);
         this.Controls.Add(this.listBox1);
         this.Name = "Form2";
         this.Text = "Form2";
         this.Load += new System.EventHandler(this.Form2_Load);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ListBox listBox1;
      private System.Windows.Forms.ListBox listBox2;
      private System.Windows.Forms.ListBox listBox3;
   }
}