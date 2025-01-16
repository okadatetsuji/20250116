using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250116
{
    abstract class Animal
    {
        // 抽象メソッド（派生クラスで必ず実装する必要あり）
        public abstract void Speak();

        // 具体的なメソッド
        public void Eat()
        {
            Console.WriteLine("食べる・・・(´～｀)ﾓｸﾞﾓｸﾞ");
        }
    }

    // 派生クラス
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("ワンワン！");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("ニャーニャー");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 抽象クラスを基準に多様な派生クラスを扱う
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myDog.Speak();
            myDog.Eat();

            myCat.Speak();
            myCat.Eat();
        }
    }
}
