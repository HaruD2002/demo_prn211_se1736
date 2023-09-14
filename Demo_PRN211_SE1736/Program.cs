using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace Language;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, Language!");
        while (true)
        {
            Console.WriteLine("1.Basic.");
            Console.WriteLine("2.String.");
            Console.WriteLine("3.List.");
            Console.WriteLine("0.Exit.");
            Console.WriteLine("Choose an option: ");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0: return;
                case 1:
                    {
                        basic();
                        break;
                    }
                case 2:
                    {
                        demoString();
                        break;
                    }
                case 3:
                    {
                        demoList();
                        break;
                    }
            }
        }
    }

    private static void demoList()
    {
        List<String> studentList = new List<string>()
        {
        "Duy Nhat Dinh",
        "Trang Quynh Phan Le",
        "Haru Dinh",
        "Amelia Harrison"
        };

        // tao menu de thuc hien chuc nang 
        //1 show list
        //2 add name if match --> warning
        //3 how many student middle name contain more than 1 word
        //4 show student with their name start with T
        //5 tinh tong ki tu nhung nguoi co surname end with 'o'
        //6 hien thi theo for mat
        // Ten + chu cai dau tien cua surname + cac chu cai dau tien cua ten dem  vd Duy Nhat Dinh DuyDN


        while (true) {
            Console.WriteLine("List Practice");
            Console.WriteLine("1. Show current list");
            Console.WriteLine("2. Add student");
            Console.WriteLine("3. Number of Student with 2 or more middle name");
            Console.WriteLine("4. Student name start with a letter T");
            Console.WriteLine("5. Student with surname end with a letter O");
            Console.WriteLine("6. display student by format");
            Console.WriteLine("0. exit");
            Console.WriteLine("What do you want? ");
            var option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("The current list of student are");
                    studentList.ForEach(student => Console.WriteLine(student));
                    break;

                case 2:
                    Console.WriteLine("add a student");
                    string ?studentName = Console.ReadLine().Trim();
                    studentName = string.Join(" ", studentName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                    foreach (string student in studentList) {
                        if (studentName.ToLower().Equals(student.ToLower())) { 
                        Console.WriteLine("the student name " + studentName + "already exist");
                        }
                    }
                    studentList.Add(studentName);
                    break;

                case 3:
                    int output = 0;
                    foreach (string student in studentList) {
                        int count = student.Split().Length;
                        if (count > 3) {
                            output++;
                        }
                    }
                    Console.WriteLine("total student with more than 2 middle name is: " + output.ToString());
                    break;

                case 4:
                    // name first surname after
                    List<String> FilterStudent = new List<String>();
                    // Console.WriteLine("Enter a letter: ");
                    foreach(string student in studentList)
                    {
                        if (student.StartsWith("T") || student.StartsWith("t")) {
                            FilterStudent.Add(student);
                        }
                    }
                    Console.WriteLine("The student name start with the letter T are: ");
                    FilterStudent.ForEach(student => Console.WriteLine(student));
                    break;

                case 5:
                    // name first surname after
                    List<String> FilterStudentSurname = new List<String>();
                    // Console.WriteLine("Enter a letter: ");
                    foreach (string student in studentList)
                    {
                        if (student.EndsWith("o"))
                        {
                            FilterStudentSurname.Add(student);
                        }
                    }
                    Console.WriteLine("The student surname end with the letter o are: ");
                    FilterStudentSurname.ForEach(student => Console.WriteLine(student));
                    break;

                case 6:
                    foreach (string student in studentList) {
                        break;
                    }
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("invalid option");
                    break;

            }
        
        }
        throw new NotImplementedException();
    }

    private static void demoString()
    {
        List<string> list = new List<string>();
        Console.WriteLine("Enter fullname");
        string? fullName = Console.ReadLine()
            .Trim();
        fullName = string.Join(" ", fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        foreach (string part in fullName.Split(" "))
        {
            string? namepart = string.Concat(char.ToUpper(part[0]).ToString(), part.AsSpan(1));
            list.Add(namepart);
        }
        string? result = String.Join(' ', list);
        Console.WriteLine(result);

        //2 cat dau cach thua o chuoi
        //3 hien thi ho ten va ten dem thoe ung chuan
        // hien thi



        
    }

    private static void basic()
    {
        //1.Nhap 2 so nguyen tu ban phim

        Console.WriteLine("Nhap so nguyen a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so nguyen b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        //2.So sanh 2 so

        if (a > b)
        {
            Console.WriteLine($"{a} lon hon {b}");
        }
        else if (a < b)
        {
            Console.WriteLine($"{a} nho hon {b}");
        }
        else
        {
            Console.WriteLine($"{a} bang {b}");
        }


        //3.Co bao nhieu so nguyen to tu a den b

        // Kiem tra so nguyen to
        static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            if (n <= 3)
            {
                return true;
            }
            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //Dem so nguyen to tu a den b

        // Hàm đếm số nguyên tố từ a đến b
        static int CountPrimes(int a, int b)
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }
            return count;
        }


        int primeCount = CountPrimes(a, b);
        Console.WriteLine($" So so nguyen to tu {a} den {b} la {primeCount}");


        //4.Tong cac so chinh phuong tu a den b
        //5.Hien thi a so chinh phuong lon hon b
    }

    /// <summary>
    /// Chứa các xử lý language
    /// </summary>
    public void welcomeToCSharp()
    {
        Console.WriteLine("hello langugage");
    }
}