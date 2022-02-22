using System;
using mis321_pa2_roguffey.Interfaces;

namespace mis321_pa2_roguffey
{
    public class Sword : IAttack
    {
        public void Attack(Character myCharacter, Character myOpponent)
        {
            Console.WriteLine(myCharacter.Name + " cut you with their Sword!");
            double attackPower;
            
            if(myOpponent.PlayingCharacter=="d")
            {
                Console.WriteLine("Attack boost against Davy Jones!");
                attackPower = myCharacter.AttackPower * 1.2;

            }
            else
            {
                attackPower = myCharacter.AttackPower;
            }

    
            myOpponent.Defend(attackPower);
        }
    }
}