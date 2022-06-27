using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFGenerator
{
    class StudentInfo
    {
        [CsvColumn(Name = "ID")]
        public int ID { get; set; }

        [CsvColumn(Name = "Name")]
        public string Name { get; set; }

        [CsvColumn(Name = "Phone")]
        public int Phone { get; set; }

        [CsvColumn(Name = "Email")]
        public string email { get; set; }

        [CsvColumn(Name = "Candidate")]
        public bool IsCandidate { get; set; }

    }
}
