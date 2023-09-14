using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class teacher
    {
		// props first character must be uppercase
        public string Code { get; set; }


		// full prop
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        // ctor for create fast constor
        public teacher()
        {
            
        }

        public teacher(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + GetSalary();
        }


        // c# class or function first character must be double case
        public abstract double GetSalary();
    }
}
