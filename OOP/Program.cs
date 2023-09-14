 using Language;
using System.Diagnostics.SymbolStore;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, OOP!");

            ////Goi sang xu ly ben Language

            //Language.Program.Main(args);

            //Language.Program lang = new();
            //lang.welcomeToCSharp();

            // create list teacher

            List<teacher> data = new List<teacher>() {
                new FulltimeTeacher("T01", "Joey", 2),
                new ParttimeTeacher("T02", "John", 10),
                new ParttimeTeacher("T03", "Nick", 11),
                new FulltimeTeacher("T04", "Joanna", 1.5),
                new ParttimeTeacher("T05", "Amelia", 10)
            };
            Manager m = new Manager(data);
            while (true) {
                Console.WriteLine("1. Input list teacher");
                Console.WriteLine("2. Show list teacher");
                Console.WriteLine("3. Count part time teacher with slot = 10");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Choose an option: ");
                int option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        return;

                    case 1:
                        Console.WriteLine("Enter size");
                        int size = Convert.ToInt32(Console.ReadLine());
                        m.InputList(size);
                        break;

                    case 2:
                        m.OutputList();
                        break;

                    case 3:
                        int i = m.CountSlot10timer();
                        Console.WriteLine(i);
                        break;
                }
            }
        }
    }
}