using System;

namespace TrapezeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо 3 трапеції
            Trapeze TR1 = new Trapeze(1, 2, 3, 4, 5, 6, 7, 8);
            Trapeze TR2 = new Trapeze(8, 7, 6, 5, 4, 3, 2, 1);
            Trapeze TR3 = new Trapeze(1, 2, 3, 4, 8, 7, 6, 5);

            Trapeze tSub = TR3 - 3;
            Console.WriteLine("After subtracting 3 units from TR3:" + tSub);

            Trapeze tMul = TR3 * TR2;
            Console.WriteLine("Product of TR3 * TR2:" + tMul);

            Trapeze tImp = TR1 += tMul;
            Console.WriteLine("Implementation in T1:" + tImp);
        }
    }
}