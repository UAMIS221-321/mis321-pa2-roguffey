using System;

namespace mis321_pa2_roguffey
{
    class Program
    {
        static void Main(string[] args)
        {
            Character myCharacter = new Character(); 
            Character myOpponent = new Character();

            int choice = 0;
            int oppChoice = 0;

            string name;
            
            while (choice != 5)
            {
                Console.WriteLine("Choose your fighter: \n1. Jack Sparrow\n2. Will Turner\n3. Davy Jones\n4. Exit");
                choice = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                
                if(choice == 1)
                {
                    myCharacter = new JackSparrow(){Name = name};
                }
                else if(choice == 2)
                {
                    myCharacter = new WillTurner(){Name = name};
                }
                else if (choice == 3)
                {
                    myCharacter = new DavyJones(){Name = name};
                }
                else
                {
                    System.Environment.Exit(1);
                }
                
                myCharacter.Stats();
                Console.WriteLine("Press '5' to continue");
                choice = int.Parse(Console.ReadLine());
            }
            while (oppChoice != 5)
            {
                Console.WriteLine("Choose your fighter: \n1. Jack Sparrow\n2. Will Turner\n3. Davy Jones\n4. Exit");
                oppChoice = int.Parse(Console.ReadLine());

                Console.WriteLine("What is the opponents name?");
                name = Console.ReadLine();
                
                if(oppChoice == 1)
                {
                    myOpponent = new JackSparrow(){Name = name, PlayingCharacter = "j"};
                }
                else if(oppChoice == 2)
                {
                    myOpponent = new WillTurner(){Name = name, PlayingCharacter = "w"};
                }
                else if (oppChoice == 3)
                {
                    myOpponent = new DavyJones(){Name = name, PlayingCharacter = "d"};
                }
                else
                {
                    System.Environment.Exit(1);
                }
                
                myOpponent.Stats();
                Console.WriteLine("Press '5' to continue");
                oppChoice = int.Parse(Console.ReadLine());
            }

            var r = new Random();
            int n = r.Next(0,2);

            while (myCharacter.Health > 0 && myOpponent.Health > 0)
            {
                
                if(n == 0)
                {
                    myCharacter.attackBehavior.Attack(myCharacter, myOpponent);
                    myOpponent.Stats();
                    myOpponent.attackBehavior.Attack(myOpponent, myCharacter);
                    myCharacter.Stats();
                } 
                else
                {
                    myOpponent.attackBehavior.Attack(myOpponent, myCharacter);
                    myCharacter.Stats();
                    myCharacter.attackBehavior.Attack(myCharacter, myOpponent);
                    myOpponent.Stats();
                }
                
            }
            if(myCharacter.Health > 0)
            {
                Console.WriteLine($"{myCharacter.Name} won!");
            }
            else
            {
                Console.WriteLine($"{myOpponent.Name} won!");
            }
        }
    }
}
