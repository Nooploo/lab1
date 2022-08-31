using System;



namespace ConvertNums1

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Оберіть систему числення \n1. Двійова \n2. Восьмерична");

            string s = Console.ReadLine();

            int i;

            while (!int.TryParse(s, out i))

            {

                Console.WriteLine("1 або 2");

                s = Console.ReadLine();

            }



            Console.WriteLine("Введіть число");

            int num = int.Parse(Console.ReadLine());



            switch (i)

            {

                case 1:

                    Console.WriteLine(Double(num));

                    break;

                case 2:

                    Console.WriteLine(Eight(num));

                    break;

            }

        }



        static string Double(int x)

        {

            string s = string.Empty;



            for (; x > 0; x /= 2)

                s = (x % 2) + s;



            return s;

        }



        static string Eight(int x)

        {

            string s = string.Empty;



            for (; x > 0; x /= 8)

                s = (x % 8) + s;



            return s;

        }

    }

}