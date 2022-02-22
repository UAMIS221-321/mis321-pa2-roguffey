using System;
using mis321_pa2_roguffey.Interfaces;

namespace mis321_pa2_roguffey
{
    public class CannonFire : IAttack
    {
        public void Attack(Character myCharacter, Character myOpponent)
        {
            Console.WriteLine(myCharacter.Name + " has hit you with cannon fire!");
            double attackPower;
            
            if(myOpponent.PlayingCharacter=="j")
            {
                Console.WriteLine("Attack boost against Jack Sparrow!");
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