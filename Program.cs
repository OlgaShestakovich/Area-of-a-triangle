using System;

/*- Запросить у пользователя длины трёх сторон треугольника.Длины могут быть представлены дробными значениями.
  - После получения длин сторон - использовать формулу Герона для вычисления площади треугольника.
  - После вычисления площади - вывести результат на консоль
  S= корень (p (p−a) (p−b) (p−c) )
где  p=0.5(a+b+c)
*/

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон треугольника");
            Console.Write("1 сторона- ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("2 сторона- ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("3 сторона- ");
            double c = double.Parse(Console.ReadLine());

            double p = 0.5 * (a + b + c);
            Double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Площадь треугольника=  " + S);


        }
    }
}
