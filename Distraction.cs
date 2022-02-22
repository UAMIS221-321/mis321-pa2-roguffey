using System;
using mis321_pa2_roguffey.Interfaces;

namespace mis321_pa2_roguffey
{
    public class Distraction : IAttack
    {
        public void Attack(Character myCharacter, Character myOpponent)
        {
            Console.WriteLine(myCharacter.Name + " is dancing... oh wait!");
            double attackPower;
            
            if(myOpponent.PlayingCharacter=="w")
            {
                Console.WriteLine("Attack boost against Will Turner!");
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