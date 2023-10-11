namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Button btnAsa = new Button("ASA");
            Button btnMiru = new Button("Miru");
            Button btnBan = new Button("Ban");

            while (true) {

                Console.WriteLine("1. button asa");
                Console.WriteLine("2. button miru");
                Console.WriteLine("3. button ban");
                Console.WriteLine("0. exit");
                Console.WriteLine("Chick button:");
                int option = Int32.Parse(Console.ReadLine());


                // add event lsitener
                btnAsa.onClick += BtnAsa_onClick;
                btnMiru.onClick += BtnMiru_onClick;
                btnBan.onClick += BtnBan_onClick;

                switch (option)
                {   
                    case 0:
                        return;

                    case 1:

                        // call the click event
                        btnAsa.click();
                        break;

                    case 2:
                        btnMiru.click();
                        break;

                    case 3:
                        btnBan.click();
                        break;
                     
                    default:
                        break;
                }
            }
        }


        // event handler
        private static void BtnBan_onClick(string name)
        {
            Console.WriteLine(name + "hi");
        }

        private static void BtnMiru_onClick(string name)
        {
            Console.WriteLine(name + "chaos");
        }

        private static void BtnAsa_onClick(string name)
        {
            Console.WriteLine(name + "hello");
        }
    }
}