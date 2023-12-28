using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_course_project.Classes
{
    public class Coach : Member // TODO: Add Member as base class
    {
        public string field; // Can be declared as Enum instead!  زمینه کاری
        private int contractValue;  // مبلغ قرارداد

        public Coach(string name, string national, int age, string field, int contractValue) : base(name, national, age)
        {
            this.field = field;
            this.contractValue = contractValue;
        }
        public string GetField()
        {
            return field;
        }
        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override string GetDataAsString()
        {
            string a = $" نام مربی  : {base.name} | شماره ملی مربی : {base.nationalCode} | " +
             $"سن مربی : {base.age} |  فیلد کاری : {this.field} | مبلغ قرارداد : {this.contractValue} ";
            return a;
        }

        public override string GetStringToSaveFile()
        {
            string a = $"{base.nationalCode},{base.name},{base.age},{this.contractValue},{this.field}";
            return a;
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}
