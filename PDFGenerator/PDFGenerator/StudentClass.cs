using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFGenerator
{
    class StudentClass
    {
        public int ID;
        public string Name;
        public int Phone;
        public string Email;
        public string FatherName;
        public string MotherName;
        public string DateOfBirth;
        public string Address;
        public string Religion;
        public string Nationality;
        public StudentClass(int ID, string Name, int Phone, string Email, string FatherName, string MotherName, string DateOfBirth, string Address, string Religion, string Nationality)
        {
            this.ID = ID;
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
            this.FatherName = FatherName;
            this.MotherName = MotherName;
            this.DateOfBirth = DateOfBirth;       
            this.Address = Address;
            this.Religion = Religion;
            this.Nationality = Nationality;

        }

    }
}
