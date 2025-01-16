using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250116
{
    // 抽象クラス
    abstract class GameCharacter
    {
        // 共通のプロパティ
        public string Name { get; set; }    // キャラクター名
        public int Health { get; set; }     // 体力

        // コンストラクタ
        public GameCharacter(string  name, int health)
        {
            Name = name;
            Health = health;
        }

        // 抽象メソッド
        public abstract void Attack();
        public abstract void SpecialAbility();
    }

    // 戦士クラス
    class Warrior : GameCharacter
    {
        // コンストラクタ
        public Warrior(string name, int health) : base(name, health) { }
        public override void Attack()
        {
            Console.WriteLine($"{Name}は剣で攻撃！");
        }
        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name}は防御力を上げた！");
        }
    }

    class Mage : GameCharacter
    {
        public Mage(string name, int health) : base(name, health) { }
        public override void Attack()
        {
            Console.WriteLine($"{Name}は魔法で攻撃！");
        }
        public override void SpecialAbility()
        {
            Console.WriteLine($"{Name}は強力な火球を発射した！");
        }
    }
    internal class _20250116_Prac2_岡田
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("戦士の名前を入力してください。");
            var warriorName = Console.ReadLine();
            Console.WriteLine("魔法使いの名前を入力してください。");
            var mageName = Console.ReadLine();
            var warriorHP = rnd.Next(50, 300);
            var mageHP = rnd.Next(20, 100);

            List<GameCharacter> chara = new List<GameCharacter>
            {
                new Warrior(warriorName, warriorHP),
                new Mage(mageName, warriorHP)
            };

            // 各キャラクターの行動を順番に表示
            foreach(var character in chara)
            {
                Console.WriteLine($"--- {character.Name}'s Turn ---");
                character.Attack();
                character.SpecialAbility();
                Console.WriteLine($"HP : {character.Health}\n");
            }

        }
    }
}
