using System;

namespace TrapezeApp
{
    public class Trapeze
    {
        //Властивості для координат вершин
        private double x1, y1;
        private double x2, y2;
        private double x3, y3;
        private double x4, y4;

        // Конструктор за замовчуванням
        public Trapeze() => x1 = y1 = x2 = y2 = x3 = y3 = x4 = y4 = 0.0;

        // Конструктор з параметрами
        public Trapeze(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        // Конструктор копії
        public Trapeze(Trapeze other)
        {
            this.x1 = other.x1;
            this.y1 = other.y1;
            this.x2 = other.x2;
            this.y2 = other.y2;
            this.x3 = other.x3;
            this.y3 = other.y3;
            this.x4 = other.x4;
            this.y4 = other.y4;
        }

        // Делегування конструктора
        public Trapeze(double x1, double y1) : this(x1, y1, 0, 0, 0, 0, 0, 0)
        {
        }

        // Деструктор
        ~Trapeze()
        {
        }

        // Метод для встановлення координат
        public void SetCoordinates(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }

        // Перевантаження: Метод приймає масив з 8 елементів
        public void SetCoordinates(double[] coords)
        {
            if (coords.Length != 8)
                throw new ArgumentException("Масив повинен містити рівно 8 елементів.");
            x1 = coords[0];
            y1 = coords[1];
            x2 = coords[2];
            y2 = coords[3];
            x3 = coords[4];
            y3 = coords[5];
            x4 = coords[6];
            y4 = coords[7];
        }

         //Гетери (властивості) для читання координат
         public double X1 => x1;
         public double Y1 => y1;
         public double X2 => x2;
         public double Y2 => y2;
         public double X3 => x3;
         public double Y3 => y3;
         public double X4 => x4;
         public double Y4 => y4;


        // Метод обчислення периметра
        public double GetPerimeter()
        {
            double sideA = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double sideB = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double sideC = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            double sideD = Math.Sqrt((x1 - x4) * (x1 - x4) + (y1 - y4) * (y1 - y4));

            return sideA + sideB + sideC + sideD;
        }

        // Метод обчислення площі 
        public double GetArea()
        {
            double sideA = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double sideB = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double sideC = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            double sideD = Math.Sqrt((x1 - x4) * (x1 - x4) + (y1 - y4) * (y1 - y4));

            double p = (sideA + sideB + sideC + sideD) / 2.0; 
            return Math.Abs((sideA * sideC) / (sideA - sideC) * Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)));
        }

        // Перевантаження оператора вирахування
        public static Trapeze operator -(Trapeze t, double subtraction)
        {
            return new Trapeze(
                t.X1 - subtraction, t.Y1 - subtraction,
                t.X2 - subtraction, t.Y2 - subtraction,
                t.X3 - subtraction, t.Y3 - subtraction,
                t.X4 - subtraction, t.Y4 - subtraction);
        }

        // Перевантаження оператора поміщення
        public static Trapeze operator +(Trapeze i, Trapeze other)
        {
            return new Trapeze(
                i.X1 + other.X1, i.Y1 + other.Y1,
                i.X2 + other.X2, i.Y2 + other.Y2,
                i.X3 + other.X3, i.Y3 + other.Y3,
                i.X4 + other.X4, i.Y4 + other.Y4
            );
        }

        // Перевантаження оператора множення
        public static Trapeze operator *(Trapeze a, Trapeze b)
        {
            return new Trapeze(
                a.X1 * b.X1, a.Y1 * b.Y1,
                a.X2 * b.X2, a.Y2 * b.Y2,
                a.X3 * b.X3, a.Y3 * b.Y3,
                a.X4 * b.X4, a.Y4 * b.Y4);
        }

        // Перевизначення ToString для зручного виведення координат
        public override string ToString()
        {
            return $"A({X1}, {Y1}), B({X2}, {Y2}), C({X3}, {Y3}), D({X4}, {Y4})";
        }
    }
}