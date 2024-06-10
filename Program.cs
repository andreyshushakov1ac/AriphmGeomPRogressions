using System.Runtime.ExceptionServices;

namespace pr4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какую прогрессию хотели бы рассчитать?\na - арифметическая\nг - геометрическая\nВыбор: ");
            string ch = Console.ReadLine();

            if (ch == "а")
            {
                Console.WriteLine("Введите первый элемент арифметической прогрессии:");
                int a0 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите разность прогрессии");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество элементов");
                int k = int.Parse(Console.ReadLine());

                ArithmeticProgression ap1 = new ArithmeticProgression(a0, d);
                Console.WriteLine("{0} элемент ар.прогрессии = {1}", k, ap1.GetElement(k));
            }
            else if (ch == "г")
            {
                Console.WriteLine("Введите первый элемент геометрической прогрессии:");
                int b0 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите знаменатель прогрессии");
                int q = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество элементов");
                int k = int.Parse(Console.ReadLine());

                GeometricProgression ap1 = new GeometricProgression(b0, q);
                Console.WriteLine("{0} элемент ар.прогрессии = {1}", k, ap1.GetElement(k));
            }
            else {Console.WriteLine("/nОшибка ввода!"); Environment.Exit(0);}
        }  
    }
}