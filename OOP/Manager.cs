using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // use to implement and extends a class
    public class Manager : IManager
    {
        public Manager(List<teacher> data)
        {
            Data = data;
        }

        public List<teacher> Data { get; }

        public int CountSlot10timer()
        {
            int count = 0;
            foreach (teacher teacher in Data)
            {
                if (teacher is ParttimeTeacher && ((ParttimeTeacher)teacher).Slot == 10) {
                    count++;
                }
            }
            return count;
        }

        public void InputList(int size)
        {
            for (int? i = 0; i < size; i++)
            {
                Console.WriteLine("Enter code");
                string? code = Console.ReadLine();
                Console.WriteLine("Enter Name");
                string? name = Console.ReadLine();
                Console.WriteLine("part or full time? (0 = full, 1 = part)");
                int? timer = Int32.Parse(Console.ReadLine());
                if (timer == 0)
                {
                    Console.WriteLine("Enter heso:");
                    double heso = Double.Parse(Console.ReadLine());
                    teacher full_timer = new FulltimeTeacher(code, name, heso);
                    Data.Add(full_timer);
                }
                else if (timer == 1) {
                    Console.WriteLine("Enter slot");
                    int slot = Int32.Parse(Console.ReadLine());
                    teacher part_timer = new ParttimeTeacher(code, name, slot);
                    Data.Add(part_timer);
                }

            }
        }

        public void OutputList()
        {
            foreach (var item in Data) {
                Console.WriteLine(item);
            }
        }
    }
}
