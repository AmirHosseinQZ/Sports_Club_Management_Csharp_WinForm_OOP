using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_course_project.Classes
{
    public class Employee : Member// TODO: Add Member as base class
    {
        private string personnalCode;  // کد پرسنلی
        private string position;   // پست سازمانی
        private int salary;  // حقوق

        public Employee(string personnalCode, string position, int salary, string name, string national, int age) : base(name, national, age)
        {
            this.personnalCode = personnalCode;
            this.position = position;
            this.salary = salary;
        }

        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override string GetDataAsString()
        {
            string a = $" نام کارمند  : {base.name} | شماره ملی کارمند : {base.nationalCode} | " +
            $"سن کارمند : {base.age} |  فیلد کاری : {this.position} | میزان حقوق : {this.salary} ";
            return a;
        }

        public override string GetStringToSaveFile()
        {
            string a = $"{base.nationalCode},{base.name},{base.age},{this.personnalCode},{this.position},{this.salary}";
            return a;

        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
