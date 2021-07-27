using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditWordWithOpenXML.Models
{
    public class Document
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Template { get; set; } = (@"C:\Users\ITA8-TN04\OneDrive - IT-Akademie Dr. Heuer GmbH\git\EditWordWithOpenXML\Data\Vorher.docx");

        // To search and replace content in a document part.
        public static void SearchAndReplace(string document)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(document, true))
            {
                string docText = null;
                using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                {
                    docText = sr.ReadToEnd();
                }

                Regex regexText = new Regex("auszutschen");
                docText = regexText.Replace(docText, "Hi Everyone!");

                using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                {
                    sw.Write(docText);
                }
            }
        }
    }
}
