using System;

namespace GameUnits
{
    public class Unit
    {
        
            abstract float Cost { get; }
            private int movement;
            virtual int Health { get; }
            
            public Unit (int movement , int health ) 
            {
            this.movement = movement ;
            Health = health ;
            }

        public void Move()
        {
            Console.WriteLine($"Andou {movement} casas");
        }
    }

    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get ; private set; }
        public void Attack ( Unit u );

        override float Cost()
        {
            return AttackPower + XP;
        }

        override int Health()
        {
            return XP + Health;
        }

        public void Attack()
        {
            XP++;
            Health--;
        }
    }

    public class SettlerUnit : Unit
    {
        override float Cost()
        {
            return 5;
        }
        public Set(int health, int movement)
        {
            health = 2;
            movement = 1;
        }
    }
class Program
    {
        static void Main(string[] args)
        {
            Move;
            Console.WriteLine($"Health: {Health}\nCost: {Cost}");
        }
    }
}
