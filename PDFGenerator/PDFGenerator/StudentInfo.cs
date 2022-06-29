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

        [CsvColumn(Name = "Father Name")]
        public string FatherName { get; set; }
        [CsvColumn(Name = "Mother Name")]
        public string MotherName { get; set; }
        [CsvColumn (Name = "Date of Birth")]
        public string DateOfBirth { get; set; }
        [CsvColumn(Name = "Address")]
        public string Address { get; set; }
        [CsvColumn(Name = "Religion")]
        public string Religion { get; set; }
        [CsvColumn(Name = "Nationality")]
        public string Nationality { get; set; }

    }
}
