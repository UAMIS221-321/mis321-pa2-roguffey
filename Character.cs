using System;
using mis321_pa2_roguffey.Interfaces;

namespace mis321_pa2_roguffey
{
    public class Character
    {
        public string PlayingCharacter{get; set;}

        public string Name {get;set;}
        
        public double Health{get;set;}

        public double AttackPower{get;set;}
        
        public IAttack attackBehavior;

        public double DefensePower{get;set;}
        
        public IDefend defenseBehavior;
        
        public int MaxPower{get;set;}
        
        // public string Type {get;set;}

        public void SetAttackBehavior (IAttack value)
        {
            attackBehavior = value;
        }
        public Character()
        {
            var ran = new Random();
            MaxPower = ran.Next(1,100);
            Health = 100;
            AttackPower = ran.Next(1, MaxPower);
            DefensePower = ran.Next(1, MaxPower);
            defenseBehavior = new Defense();

        }
        public void SetDefenseBehavior (IDefend value)
        {
            defenseBehavior = value;
        }
        public void Defend (double power)
        {
            power = defenseBehavior.Defend(power);
            Health -= power;
            Console.WriteLine($"{power} damage done to {this.Name}!");
        }
        public void Stats()
        {
            Console.WriteLine($"\nName: {Name}\nHealth: {Health}\nAttack Power: {AttackPower}\nDefense Power: {DefensePower}\n");
        }
    }
}