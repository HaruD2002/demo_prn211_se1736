using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.model
{
    internal class Student
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Mark { get; set; }

        public Student()
        {
            
        }

        public Student(int code, string name, string subject, int mark)
        {
            Code = code;
            Name = name;
            Subject = subject;
            Mark = mark;
        }
         
        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + Subject + "\t" + Mark;
        }
    }
}
