using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using System.Windows.Forms;
//using System.IO.File.WriteAllText;



using System.IO;
using System.Diagnostics;

namespace ajoutxt
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.DocumentOpen += Application_DocumentOpen;
            ((Word.ApplicationEvents4_Event)this.Application).NewDocument += ThisAddIn_NewDocument;

            this.Application.WindowActivate += new Word.ApplicationEvents4_WindowActivateEventHandler(App_WindowActivate);
            this.Application.WindowDeactivate += new Word.ApplicationEvents4_WindowDeactivateEventHandler(App_WindowDeactivate);
          //  this.Application.DocumentChange += new Word.ApplicationEvents4_DocumentChangeEventHandler(App_DocumentChange);

            //Prevent Word from doing the default action associated with a double click or right clik
            this.Application.WindowBeforeDoubleClick += new Word.ApplicationEvents4_WindowBeforeDoubleClickEventHandler(App_WindowBeforeDoubleClick);
          //  this.Application.WindowBeforeRightClick += new Word.ApplicationEvents4_WindowBeforeRightClickEventHandler(App_WindowBeforeRightClick);

            // Prevent Word from Updating the screen while code is running
         /*   bool oldScreenUpdateSetting = this.Application.ScreenUpdating;
           Word.Range range = this.Application.ActiveDocument.Range();
            try
            {
                this.Application.ActiveWindow.View.Zoom.Percentage = 15;
                this.Application.ScreenUpdating = true;
                Random r = new Random();
                for ( int i=1; i<5000; i++)
                {
                    range.InsertAfter(r.NextDouble().ToString());
                    if (i % 1000 == 0)
                    {
                        this.Application.ScreenUpdating= false;
                        this.Application.ScreenRefresh();
                        this.Application.ScreenUpdating = true;

                    }
                }
            }
            finally
            {
                this.Application.ScreenUpdating = oldScreenUpdateSetting;
            }*/

        }

       void App_WindowActivate(Word.Document document, Word.Window window)
        {
            MessageBox.Show(String.Format("Window{0} was activated." , window.Caption));
        }
        void App_WindowDeactivate(Word.Document document, Word.Window window)
        {
            MessageBox.Show(String.Format("Window{0} was Deactivated.", window.Caption));
        }
      /*  void App_DocumentChange()
        {
            MessageBox.Show(String.Format("The active document is now {0} .", this.Application.ActiveDocument.Name));
        }*/

        void App_WindowBeforeDoubleClick(Word.Selection selection , ref bool cancel)
            {
              if(selection.Type == Word.WdSelectionType.wdSelectionNormal)
        {
                selection.Range.Case = Word.WdCharacterCase.wdTitleWord;
                cancel = true;
        }
        }
      /*  void App_WindowBeforeRightClick(Word.Selection selection, ref bool cancel)
        {
            if (selection.Type == Word.WdSelectionType.wdSelectionNormal || selection.Type == Word.WdSelectionType.wdSelectionIP || selection.Type == Word.WdSelectionType.wdSelectionBlock)
            {
                selection.Range.Case = Word.WdCharacterCase.wdUpperCase;
                cancel = true;
            } else if (
                selection.Type == Word.WdSelectionType.wdSelectionShape
                )
            {
                selection.ShapeRange.Fill.ForeColor.RGB = 3000;
                cancel = true;
            }
        }*/


        public void Open_existingdoc()
        {
            string path = "C:\\Users\\PC\\Desktop\\test\\تأهيل ملعب رياضي للقرب بحي الزرهونية .docx";

            if (File.Exists(path))
            {
                this.Application.Documents.Open(path);
                Word.Document aDoc = this.Application.Documents.Open(path);
                aDoc.Activate();
            }
            else
            {
                MessageBox.Show("File does not exist");
                Debug.Print("File not found @ {0}", path);
            }
        }
        private void ThisAddIn_NewDocument(Word.Document Doc)
        {
          //  MessageBox.Show(String.Format("NewDocument event on {0}", Doc.Name));
          //  Word.Range range = Doc.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
           // range.Text = String.Format("created on {0} by {1}", System.DateTime.Now, Application.UserName);
        }
        private void Application_DocumentOpen(Word.Document Doc)
        {

           //  MessageBox.Show(String.Format("DocumentOpen event on {0}", Doc.Name));
            //  Word.Range range = Doc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
             // range.Text = String.Format("Lasted on {0} by {1}", System.DateTime.Now, Application.UserName);
        }

        public void WorkWithDocument(Word.Document doc)
        {
            //Globals.ThisAddIn.Application.Language = Office.MsoLanguageID.msoLanguageIDArabic;


            // Using InsertBefore method inserts text   
            doc.Content.InsertBefore("Text @ the          Start - ");
            // Using InsertAfter method inserts text   
            doc.Content.InsertAfter(" - Text @          the End");
        }


        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion

        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
    }
}
