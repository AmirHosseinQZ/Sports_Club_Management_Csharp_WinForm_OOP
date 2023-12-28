using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_course_project.Classes
{
    public abstract class Member
    {
        protected string name;
        protected string nationalCode;
        protected int age;

        public Member(string name, string national, int age)
        {
            this.name = name;
            this.nationalCode = national;
            this.age = age;
        }

        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetNationalCode => nationalCode;
        public abstract void Edit();
        public abstract string GetDataAsString();  // مقادیر متغیرهای کلاس را به عنوان یک رشته بر می گرداند
        public abstract void Print();
        public abstract string GetStringToSaveFile();
    }
}
