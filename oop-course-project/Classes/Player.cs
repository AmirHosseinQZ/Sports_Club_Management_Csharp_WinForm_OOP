using oop_course_project.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_course_project.Classes
{
    public class Player : Member
    {
        // Model
        private int number;  
        private int goals;  
        private int contractValue;  
        private string position;

        public Player(string name, string national, int age, int number, int gaols, int contractValue, string position) : base(name, national, age)
        {
            this.number = number;
            this.goals = gaols;
            this.contractValue = contractValue;
            this.position = position;
        }

        public override void Edit()
        {
            // TODO: Implement me!

        }

        public override string GetDataAsString()
        {
            // TODO: Remove the above line and implement me!
            string a = $" شماره بازیکن : {this.number} | نام بازیکن  : {base.name} | شماره ملی بازیکن : {base.nationalCode} | " +
                $"سن بازیکن : {base.age} |  تعداد گل ها : {this.goals} | مبلغ قرارداد : {this.contractValue} | موقعیت : {this.position} ";
            return a;
        }

        public override void Print()
        {
            // TODO : Implement me!
            //    string a = $"{this.number},{base.name},{base.nationalCode}" +
            //        $",{base.age},{this.goals},{this.contractValue},{this.position}";
        }
        public override string GetStringToSaveFile()
        {
            string a = $"{base.name},{base.nationalCode},{base.age},{this.contractValue},{this.number}" +
                $",{this.goals},{this.position}";
            return a;
        }

        public int GetContractValue => contractValue;
        public string GetPosition => position;

        public int GetGoals => goals;
        //public string GetNationalCode => base.nationalCode;
    }
}
