

using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        void DataType()
        {



            //Типы данных в С#
            string variable_string = "Это строка";
            int variable_int = 12;
            double variable_double = 24.5;
            bool variable_bool = true;
            char variable_char = 'a';
            char variable_char2 = 'b';

            //Консольный вывод

            Console.WriteLine("Тип данных = строчка " + variable_string);
            Console.WriteLine("Тип данных = целочисленный " + variable_int);
            Console.WriteLine("Тип данных = дробный " + variable_double);
            Console.WriteLine("Тип данных = логический " + variable_bool);
            Console.WriteLine("Тип данных = символьный " + variable_char);

            //сложение двух переменных в консоли

            Console.WriteLine(variable_int + variable_double);

            //консольный ввод и ковнертация для него

            Console.WriteLine("Введите переменную типа int: ");
            int xInt;
            xInt = int.Parse(Console.ReadLine());
            Console.WriteLine(xInt + " -ваше значение.");

            Console.WriteLine("Введите строчку;");
            string xString;
            xString = Console.ReadLine();
            Console.WriteLine(xString + " - ваше значение.");

            Console.WriteLine("Введите переменную типа double: ");
            double xDouble;
            xDouble = double.Parse(Console.ReadLine());
            Console.WriteLine(xDouble + " - ваше значение.");

            Console.WriteLine("Введети переменную типа char:");
            char xChar;
            xChar = char.Parse(Console.ReadLine());
            Console.WriteLine(xChar + " - ваше значение");

            Console.WriteLine("Введети переменную типа bool:");
            bool xBool;
            xBool = bool.Parse(Console.ReadLine());
            Console.WriteLine(xBool + " - ваше значение");

            // бла бла бла бла раз два три 4 5 это очень важный комментарий для нашв рабарь

        }
        void Cycle()
        {
            int i = 0;
            //ЦИКОЛ С ПРЕДУСЛОВИЕМ
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;

            }


            for (i = 0; i <= 52; i++)
            {
                Console.WriteLine(i);
            }


            int mnojitel = 5;
            for (i = 0; i < 11; i++)
            {
                Console.WriteLine(mnojitel + " * " + i + " = " + i * mnojitel);
            }


            int[] numbers;
            int[] numbers_1 = new int[10];
            int[] numbers_2 = new int[5] { 1, 5, 23, 4, 10 };
            int[] numbers_3 = { 1, 24, 5, 8 };

            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine(matrix);

            foreach (int a in numbers_2)
            {
                Console.WriteLine(a);
            }

            for (int b = 0; b < numbers_2.Length; b++)
            {
                Console.WriteLine(b);
                Console.WriteLine(numbers_2[b]);

                Console.WriteLine("В ячейке под номером" + b + "храниста значение" + numbers_2[b]);
            }

        }
        int getSquare(int x, int y)
        {
            int z = x + y;
            return x * y;

        }
         double getKVADRAT(double x)
        {
            var result = x * x;
            return result;

        }

        Console.WriteLine(getKVADRAT(100456));

        var max = Int32.MaxValue;

        var min = Int32.MinValue;

        Console.WriteLine(max + " " + min);

        int getFactorial(int number)
        {
            int result = 1;

            for(int i = 1; i <=number; i++)
            {
                result *= i;
            }
                return result;
        }

        Console.WriteLine(getFactorial(4));
       




    }
}