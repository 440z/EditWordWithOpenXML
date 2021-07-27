using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditWordWithOpenXML.Models
{
    public class Document
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Template { get; set; } = (@"C:\Users\ITA8-TN04\OneDrive - IT-Akademie Dr. Heuer GmbH\git\EditWordWithOpenXML\Data\Vorher.docx");
    }
}
