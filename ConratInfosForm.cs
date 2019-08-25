using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Globalization;
using System.Drawing.Drawing2D; // si on veut ajouter une photo"logo"
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;




namespace ajoutxt
{
    public partial class ConratInfosForm : Form
    {
        public ConratInfosForm()
        {
            InitializeComponent();

            var ci = new CultureInfo("ar-AR");

            Thread.CurrentThread.CurrentCulture = ci;

            List<string> partenaires = new List<string>()
            {
                "عمالة مكناس", "عمالة ويسلان"
            };
            foreach (var part in partenaires)
                list_partenaires1.Items.Add(part);
        }

        private void FindAndReplace( object pattern, object replacementText)
        {

         /*  bject matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            Word.Application wdApp = new Word.Application();
            wdApp.Application.Selection.Find.Execute(ref findText,
                       ref matchCase, ref matchWholeWord,
                       ref matchWildCards, ref matchSoundLike,
                       ref nmatchAllForms, ref forward,
                       ref wrap, ref format, ref replaceWithText,
                       ref replace, ref matchKashida,
                       ref matchDiactitics, ref matchAlefHamza,
                       ref matchControl);*/



              object findText = pattern;
              var wdApp = Globals.ThisAddIn.Application;
              findText = wdApp.Selection.Find;
              wdApp.Selection.Find.ClearFormatting();
              bool isFound = wdApp.Selection.Find.Execute(FindText: findText, ReplaceWith: replacementText);
              if (!isFound)
              Debug.Print("Searched Text \"{0}\" not found !", pattern);
        }
     
      /*  public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }*/
      /*  private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }*/
        
        private void Txt_premiers_partenaires_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string partners1 = list_partenaires1.Text;
          //  this.FindAndReplace("$$premiers_partenaires$$", partners1);
        }
        private void Txt_intitule_projet_TextChanged(object sender, EventArgs e)
        {
           // string intutuleprojet = txt_intitule_projet.Text;
           // this.FindAndReplace("$$intitule_projet$$", intutuleprojet);

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // decimal montantGlobal = num_montant.Value;
           // this.FindAndReplace("$$montant$$", montantGlobal.ToString());

        }

        private void Textobjectif_TextChanged(object sender, EventArgs e)
        {
          //  string obj = txt_intitule_projet.Text;
          //  this.FindAndReplace("$$intitule_projet$$", obj);


        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void ConratInfosForm_Load(object sender, EventArgs e)
        {

        }

       

        private void Premiers_partenaires_Click(object sender, EventArgs e)
        {

        }

        //Load the Template Document:
        private void Button2_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.Open_existingdoc();
            object readOnly = false; //default
            object isVisible = false;
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = false;
       //     tEnabled(true); // Bloquer la saisie des données jusqu'au l'ouverture du Doc
        }


             //Méthode Enabled Controles:
       /*  private void tEnabled(bool state)
             {
                list_partenaires1.Enabled = state;
                txt_intitule_projet.Enabled = state;
                num_montant.Enabled = state;
                textobjectif.Enabled = state;
             }*/

        private void BnApplyData_Click(object sender, EventArgs e)
        {
            string partners1 = list_partenaires1.Text;
            string intutuleprojet = txt_intitule_projet.Text;
            decimal montantGlobal = num_montant.Value;
            string  obj= txt_intitule_projet.Text;

            this.FindAndReplace("{{premiers_partenaires}}", partners1);
            this.FindAndReplace("{{intitule_projet}}", intutuleprojet);
            this.FindAndReplace("{{montant}}", montantGlobal.ToString());
            this.FindAndReplace("{{intitule_projet}}", obj);

        }

       
    }
}
