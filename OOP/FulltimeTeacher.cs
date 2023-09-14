using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // implement
    public class FulltimeTeacher : teacher
    {
        public double Heso { get; set; }

        public FulltimeTeacher()
        {
            
        }

        public FulltimeTeacher(string code, string name, double heso) : base(code, name)
        {
            Heso = heso;
        }

        public override double GetSalary()
        {
            return Heso * 2000000;
        }
    }
}
