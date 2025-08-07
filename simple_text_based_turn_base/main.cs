using System;
namespace main
{
    public class BaseEntity
    {
        // Common variable like name, hp, etc.
        public string name;
        public int baseDmg;
        public int hp;
        public int maxHp;

        // Randomize base dmg from 80% - 120%
        private Random rand = new Random();
        int actDmg;
        public int GetRandomizedDmg()
        {
            double multiplier = rand.NextDouble() * (1.2 - 0.8) + 0.8;
            return (int)(baseDmg * multiplier);
        }

        // Attack function
        public void Attack(BaseEntity target)
        {
            actDmg = GetRandomizedDmg();
            target.hp -= actDmg;
            Console.WriteLine(name + " HP : " + hp);
            Console.WriteLine(name + " attacks and deals " + actDmg + " damage!");
            Console.WriteLine();
        }

        //Whos the winner function
        public void CheckWinner(BaseEntity a, BaseEntity b)
        {
            if (a.hp > 0)
            {
                Console.WriteLine(a.name + " WIN!!");
            }
            else if (b.hp > 0)
            {
                Console.WriteLine(b.name + " WIN!!");
            }
            else
            {
                Console.WriteLine("TIE!!");
            }
        }
    }

    //Each entity with its stats
    public class Player : BaseEntity
    {
        public Player()
        {
            name = "Player";
            hp = 100;
            maxHp = 100;
            baseDmg = 20;
        }
    }

    public class Troll : BaseEntity
    {
        public Troll()
        {
            name = "Troll";
            hp = 100;
            maxHp = 100;
            baseDmg = 23;
        }
    }
    
    //turnbase system
    public class Gameplay : BaseEntity
    {
        private bool isPlayerTurn = true;
        public void startTurn()
        {
            Player player = new Player();
            Troll troll = new Troll();

            while (player.hp > 0 && troll.hp > 0)
            {
                if (isPlayerTurn)
                {
                    player.Attack(troll);
                    isPlayerTurn = false;
                }
                else
                {
                    troll.Attack(player);
                    isPlayerTurn = true;
                }
            }
            BaseEntity win = new BaseEntity();
            win.CheckWinner(player, troll);
        }
    }

    //run em boi
    class Program
    {
        static void Main()
        {
            Gameplay game = new Gameplay();
            game.startTurn();
        }
    }
}