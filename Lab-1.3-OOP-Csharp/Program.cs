using System;

namespace TrapezeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо 3 трапеції
            Trapeze TR1 = new Trapeze(x1: 1, y1: 2, x2: 3, y2: 4, x3: 5, y3: 6, x4: 7, y4: 8);
            Trapeze TR2 = new Trapeze(x1: 8, y1: 7, x2: 6, y2: 5, x3: 4, y3: 3, x4: 2, y4: 1);
            Trapeze TR3 = new Trapeze(x1: 1, y1: 2, x2: 3, y2: 4, x3: 8, y3: 7, x4: 6, y4: 5);

            Trapeze tSub = TR3 - 3;
            Console.WriteLine("After subtracting 3 units from TR3:" + tSub);

            Trapeze tMul = TR3 * TR2;
            Console.WriteLine("Product of TR3 * TR2:" + tMul);

            Trapeze tImp = TR1 += tMul;
            Console.WriteLine("Implementation in T1:" + tImp);
        }
    }
}
