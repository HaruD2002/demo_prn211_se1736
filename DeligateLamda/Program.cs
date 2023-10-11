using System.Threading.Channels;

namespace DeligateLamda
{
    internal class Program
    {

        //init deligate
        delegate void myDelegate(int a, int b);

        delegate int myDelegate2(int a);

        static void Main(string[] args)
        {
            //before deligate
            Console.WriteLine("not use deligate");
            plus(4, 6);
            compare(4, 6);
            UCLN(4, 6);
            //after deligate
            //part 1
            Console.WriteLine("use deligate");
            myDelegate my1 = new myDelegate(plus);
            my1 += compare;
            my1 += UCLN;

            my1(4, 6);

            my1 -= UCLN;
            my1(20, 16);

            Console.WriteLine(my1);


            //part 2
            myDelegate my2 = delegate(int a, int b) { 
                plus(a, b);
                compare(a, b);
            };
            Console.WriteLine("my2");

            myDelegate2 myy2 = delegate (int a)
            {
                return a * a;
            };

            // convert my2 to ...
            myDelegate my3 = (int a, int b) => Console.WriteLine(a*b);


            //transform
            myDelegate my4 = (a,b) => Console.WriteLine(a+b);


            // last transform

            myDelegate my5 = (a, b) => Console.WriteLine(1 + 2);

        }
        public static void plus(int a, int b) {
            Console.WriteLine("a+b =" + (a+b));
        }

        public static void compare(int a, int b)
        {

            if (a > b) { Console.WriteLine("a > b"); }
            else if(a < b) { Console.WriteLine("a < b"); }
            else { Console.WriteLine("a = b"); }
        }

        public static void UCLN(int k, int l) {
            while (k!= l) {
                if (k > l) k = k - l;
                else l = l - k;
            }
            Console.WriteLine("UCLN: " + k);
        }
    }
}