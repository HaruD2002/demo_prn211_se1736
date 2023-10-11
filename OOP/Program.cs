 using Language;
using System.Diagnostics.SymbolStore;

namespace OOP
{
    internal class Program
    {
        public static void Main(string[] args)
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
            // absolute path
            //String filename = "E:\\school\\PRN C#\\211\\demo_prn211_se1736\\OOP\\data.txt";
            // relative path
            String filename = "..\\..\\..\\data.txt;";
            while (true)
            {
                Console.WriteLine("1. Input list teacher");
                Console.WriteLine("2. Show list teacher");
                Console.WriteLine("3. Count part time teacher with slot = 10");
                Console.WriteLine("4. Return list teacher with more than 10 slots");
                Console.WriteLine("5. Return a list sort by salary");
                Console.WriteLine("6. List Teahcher name start with T");
                Console.WriteLine("7.  Save to file");
                Console.WriteLine("0. Exit");
                int option = inputint("Choose an option: ");
                switch (option)
                {
                    case 0:
                        return;

                    case 1:
                        int size = inputint("Enter size: ");
                        m.InputList(size);
                        break;

                    case 2:
                        m.OutputList();
                        break;

                    case 3:
                        int i = m.CountSlot10timer();
                        Console.WriteLine(i);
                        break;

                    case 4:
                        m.getAllPartTimerWithMoreSlotThan10().ForEach(Console.WriteLine);
                        break;

                    case 5:
                        m.sortTeacherbySal();
                        break;

                    case 6:
                        m.teacherStartwithAT().ForEach(Console.WriteLine);
                        break;

                    case 7:
                        m.savefile(filename);
                        break;
                    case 8:
                        m.loadfile(filename);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
        }

        public static int inputint(String prompt)
        {
            int option;
            while (true)
            {
                Console.WriteLine(prompt);
                try
                {
                    option = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return option;
        }
    }
}
