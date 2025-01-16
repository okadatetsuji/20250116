using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250116
{
    // 抽象クラス
    abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    // 派生クラス
    class Rectangle : Shape
    {
        private double width;
        private double height;
        // コンストラクタ
        public Rectangle(double w, double h)
        {
            this.width = w; 
            this.height = h;
        }
        public override double CalculateArea()
        {
            // 面積の計算
            return width * height;
        }
        public override double CalculatePerimeter()
        {
            // 周囲長の計算
            return 2 * (width + height);
        }
    }

    class Circle : Shape
    {
        private double radius;
        // コンストラクタ
        public Circle(double r)
        {
            this.radius = r;
        }
        public override double CalculateArea()
        {
            // 面積の計算
            return 3.14 * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            // 周囲長の計算
            return 2 * 3.14 * radius;
        }
    }
    internal class _20250116_Prac1_岡田
    {
        static void Main(string[] args)
        {
            double width;
            double height;
            double radius;

            Console.WriteLine("幅を入力してください。");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("高さを入力してください。");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("半径を入力してください。");
            radius = double.Parse(Console.ReadLine());

            Shape rec = new Rectangle(width, height);
            Console.WriteLine($"面積：{rec.CalculateArea()}");
            Console.WriteLine($"周囲長：{rec.CalculatePerimeter()}");

            Shape cir = new Circle(radius);
            Console.WriteLine($"面積：{cir.CalculateArea()}");
            Console.WriteLine($"周囲長：{cir.CalculatePerimeter()}");
        }
    }
}
