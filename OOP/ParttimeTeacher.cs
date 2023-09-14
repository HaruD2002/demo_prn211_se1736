using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class ParttimeTeacher : teacher
    {
        public int Slot { get; set; }
        public ParttimeTeacher()
        {
            
        }

        public ParttimeTeacher(string code, string name, int slot) : base(code, name)
        {
            Slot = slot;
        }

        public override double GetSalary()
        {
            return Slot + 50000;
        }
    }
}
