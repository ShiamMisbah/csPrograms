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
        //[CsvColumn(Name = "ApplicationCode")]
        //public int ApplicationCode { get; set; }

        //[CsvColumn(Name = "Name")]
        //public string Name { get; set; }

        //[CsvColumn(Name = "Mobile")]
        //public int Mobile { get; set; }

        //[CsvColumn(Name = "Email")]
        //public string Email { get; set; }

        ////[CsvColumn(Name = "Father Name")]
        ////public string FatherName { get; set; }
        ////[CsvColumn(Name = "Mother Name")]
        ////public string MotherName { get; set; }
        //[CsvColumn (Name = "DateOfBirth")]
        //public string DateOfBirth { get; set; }

        //[CsvColumn (Name = "Title")]
        //public string Title { get; set; }
        //[CsvColumn(Name = "DocumentName")]
        //public string DocumentName { get; set; }
        //[CsvColumn(Name = "Address")]
        //public string Address { get; set; }
        //[CsvColumn(Name = "Religion")]
        //public string Religion { get; set; }
        //[CsvColumn(Name = "Nationality")]
        //public string Nationality { get; set; }

        [CsvColumn(Name = "user")]
        public string applicationCode { get; set; }

        [CsvColumn(Name = "persoanl_info_applicants_name")]
        public string Name { get; set; }

        [CsvColumn(Name = "persoanl_info_fathers_name")]
        public string FatherName { get; set; }

        [CsvColumn(Name = "persoanl_info_mothers_name")]
        public string MotherName { get; set; }

        //[CsvColumn(Name = "Exam_Center")]
        //public string ExamCenter { get; set; }

        [CsvColumn(Name = "personal_info_place_of_birth")]
        public string District { get; set; }

        [CsvColumn(Name = "post_name")]
        public string Post_name { get; set; }
    }
}
