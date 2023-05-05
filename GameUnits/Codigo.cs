using System;

namespace GameUnits
{
    public abstract class Unit
    {
        
            public abstract float Cost { get; }
            public int movement;
            public virtual int Health { get; set;}
            
            public Unit (int movement , int health ) 
            {
                this.movement = movement ;
                Health = health ;
            }

        public void Move()
        {
            Console.WriteLine($"Andou {movement} casas");
        }

        public void ToString()
        {
            return base.GetType().name + ": HP=" + HP + " Cost=" + Cost;
        }
    }

    public class MilitaryUnit : Unit    
    {
        public int AttackPower { get; }
        public int XP { get ; private set; }
        public void Attack ( Unit u ){}

        public override float Cost => AttackPower + XP;

        public MilitaryUnit(int health, int movement, int attackPower) : base(movement, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public override int Health => XP + base.Health;

        public void Attack()
        {
            XP++;
            Health--;
        }

        public void ToString()
        {
            return base.GetType().name + ": HP=" + HP + " Cost=" + Cost + " AP=" + AttackPower + " XP=" + XP;
        }
    }

    public class SettlerUnit : Unit
    {
        public override float Cost => 5;
        public SettlerUnit(int health, int movement) : base(1, 2)
        {
        }
    }
}
