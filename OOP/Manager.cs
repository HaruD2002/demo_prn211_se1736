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

        public List<teacher> getAllPartTimerWithMoreSlotThan10()
        {
            List<teacher> allMoreThan10 = new List<teacher>();

            foreach (teacher teacher in Data)
            {
                if (teacher is ParttimeTeacher && ((ParttimeTeacher)teacher).Slot > 10) {
                    allMoreThan10.Add(teacher);
                }
            }
            return allMoreThan10;
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

        public void ListWithHighestSal()
        {
            foreach(var teach in  Data)
            {

            }
        }

        public void OutputList()
        {
            foreach (var item in Data) {
                Console.WriteLine(item);
            }
        }

        public void sortTeacherbySal()
        {
            var data = Data.OrderByDescending(teach => teach.GetSalary());
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public List<teacher> teacherStartwithAT()
        {
            List<teacher> allStartwithT = new List<teacher> ();
            foreach (var teacher in Data) {
                if (teacher.Name.ToLower().StartsWith("t")) {
                    allStartwithT.Add(teacher);
                }
            }
            return allStartwithT;
        }

        internal void loadfile(String filename)
        {
            Data.Clear();
            teacher T;
            List<teacher> teacherfromfile = new List<teacher>();
            try {
                using(StreamReader sr = new StreamReader(filename))
                {
                    String line = sr.ReadLine(); //read file
                    while(line != null)
                    {

                        Console.WriteLine(line);
                        line = sr.ReadLine();
                        String[] s = line.Split("\t");
                        string code = s[0];
                        string name = s[1];

                        if (s[3].Equals("0")) { 
                            double heso = Convert.ToDouble(s[2])/ 2000000;
                            T = new FulltimeTeacher(code, name, heso);
                            Data.Add(T);
                        }
                        else if (s[3].Equals ("1"))
                        {
                            int slot = Convert.ToInt32(s[2])/ 50000;
                            T = new ParttimeTeacher(code, name, slot);
                            Data.Add(T);

                        }
                    }
                }

                // cac truong hop normal sai o data.txt
                // 1. thua giong trong --> bo qua
                // 2. dong nao ma co phan code da co thi bo qua 
                // 3. giong nao bi sai format thi bo qua
            }
            catch (Exception) {
                Console.WriteLine("load file error");
            }
            throw new NotImplementedException();
        }

        internal void savefile(String filename)
        {

            try {

                // 1s step
                //StreamWriter sw = new StreamWriter(filename);
                //foreach (var teacher in Data)
                //{
                //    sw.WriteLine(teacher.Name + " " + teacher.GetSalary());
                //}
                //sw.Flush();
                //sw.Close();


                // 2nd step
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (var teacher in Data) {
                        if (teacher is FulltimeTeacher)
                        {
                            sw.WriteLine(teacher + "\t0");
                        }
                        else if (teacher is ParttimeTeacher) {
                            sw.WriteLine(teacher + "\t1");
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("load file error");
            }
        }
    }
}
