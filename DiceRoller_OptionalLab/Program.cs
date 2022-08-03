Console.WriteLine("Please enter the number sides we wish our die to have?: ");
int userInt = int.Parse(Console.ReadLine());


bool correctNumber = true;
if (userInt < 1)
{
    correctNumber = false;
}
while (!correctNumber)
{
    Console.WriteLine("Please enter a different number. Please make it Whole and a positive integer: ");
    userInt = int.Parse(Console.ReadLine());
    if (userInt >= 1)
    {
        correctNumber = true;
    }

}
if (userInt != 6)
{
    d_Not_Six_Outcomes(userInt);
}
else
{

    d_Six_Outcomes(userInt);
}
Console.WriteLine("Thanks for Playing!");


static void d_Six_Outcomes(int userInt)
{
    bool rollAgain = true;
    while (rollAgain)
    {

        bool continueRolling = true;
        int counter = 1;
        Console.WriteLine($"Roll {counter}: ");
        counter++;
        int die = RandomNumber(1, userInt);
        int die2 = RandomNumber(1, userInt);
        int rollTotal = die + die2;
        Console.WriteLine($"You rolled a {die} and a {die2} ({rollTotal} total)");

        if (rollTotal <= 2)
        {
            Console.WriteLine("Snake eyes");
        }
        else if (rollTotal <= 3)
        {
            Console.WriteLine("Ace Duce");
        }
        else if (rollTotal == 12)
        {
            Console.WriteLine("Box Cars");
        }
        else if (rollTotal == 7 || rollTotal == 11)
        {
            Console.WriteLine("You Win!");
        }
        else if (rollTotal == 2 || rollTotal == 3 || rollTotal == 12)
        {
            Console.WriteLine("Craps");
        }
        else if (rollTotal == 9)
        {
            Console.WriteLine("Congrats on getting a nine!");
        }
        else if (rollTotal == 8 || rollTotal == 10)
        {
            Console.WriteLine("Sorry, try again this number is bad luck...");
        }
        else
        {
            Console.WriteLine(" ");
        }
        do
        {

            Console.WriteLine("would you like to roll again? y/n");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain[0] == 'n')
            {
                continueRolling = true;
                rollAgain = false;
            }
            else if (playAgain[0] == 'y')
            {
                continueRolling = true;
            }
        } while (!continueRolling);
    }
}
static int RandomNumber (int x, int userInt)
{
    x = 1;
    Random random = new Random();
    int outcome = random.Next(1, userInt);
    return outcome;
}

static void d_Not_Six_Outcomes(int userInt)
    {
        bool rollAgain = true;
        while (rollAgain)
        {

            bool continueRolling = true;
            int counter = 1;
            Console.WriteLine($"Roll {counter}: ");
            counter++;
            int die = RandomNumber(1, userInt);
            int die2 = RandomNumber(1, userInt);
            int rollTotal = die + die2;
            Console.WriteLine($"You rolled a {die} and a {die2} ({rollTotal} total)");

            if (rollTotal > 12)
            {
                Console.WriteLine($"Wow a {rollTotal}.That is a big Number! What kind of dice are you using?");
            }
            else if (rollTotal < 12)
            {
                Console.WriteLine($"Wow... even with two {userInt} sided dice... Still only got a {rollTotal}");
            }
            else
            {
                Console.WriteLine(" ");
            }
            Console.WriteLine("");
            do
            {

                Console.WriteLine("would you like to roll again? y/n");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain[0] == 'n')
                {
                    continueRolling = true;
                    rollAgain = false;
                }
                else if (playAgain[0] == 'y')
                {
                    continueRolling = true;
                }
            } while (!continueRolling);
        }
    }


//============ My Orginal code, until i added Methods. keeping it here to look back on it if need/want to ==================
//Console.WriteLine("Please enter the number sides we wish our die to have?: ");
//int userInt = int.Parse(Console.ReadLine());


//bool correctNumber = true;
////Console.WriteLine(die);
//if (userInt < 1)
//{
//    correctNumber = false;
//}
//while (!correctNumber)
//{
//    Console.WriteLine("Please enter a different number. Please make it Whole and a positive integer: ");
//    userInt = int.Parse(Console.ReadLine());
//    if (userInt >= 1)
//    {
//        correctNumber = true;
//    }

//}

//bool rollAgain = true;
//bool continueRolling = true;
//int counter = 1;
//if (userInt != 6)
//{
//    while (rollAgain)
//    {
//        Console.WriteLine($"Roll {counter}: ");
//        counter++;
//        int die = RandomNumber(1, userInt);
//        int die2 = RandomNumber(1, userInt);
//        int rollTotal = die + die2;
//        Console.WriteLine($"You rolled a {die} and a {die2} ({rollTotal} total)");

//        if (rollTotal > 12)
//        {
//            Console.WriteLine($"Wow a {rollTotal}.That is a big Number! What kind of dice are you using?");
//        }
//        else if (rollTotal < 12)
//        {
//            Console.WriteLine($"Wow... even with two dice with that many sides you only got a {rollTotal}");
//        }
//        else
//        {
//            Console.WriteLine(" ");
//        }
//        Console.WriteLine("");
//        do
//        {

//            Console.WriteLine("would you like to roll again? y/n");
//            string playAgain = Console.ReadLine().ToLower();
//            if (playAgain[0] == 'n')
//            {
//                continueRolling = true;
//                rollAgain = false;
//            }
//            else if (playAgain[0] == 'y')
//            {
//                continueRolling = true;
//            }
//        } while (!continueRolling);
//    }
//}
//else 
//{

//    while (rollAgain)
//    {
//        Console.WriteLine($"Roll {counter}: ");
//        counter++;
//        int die = RandomNumber(1, userInt);
//        int die2 = RandomNumber(1, userInt);
//        int rollTotal = die + die2;
//        Console.WriteLine($"You rolled a {die} and a {die2} ({rollTotal} total)");

//        if (rollTotal <= 2)
//        {
//            Console.WriteLine("Snake eyes");
//        }
//        else if (rollTotal <= 3)
//        {
//            Console.WriteLine("Ace Duce");
//        }
//        else if (rollTotal == 12)
//        {
//            Console.WriteLine("Box Cars");
//        }
//        else if (rollTotal == 7 || rollTotal == 11)
//        {
//            Console.WriteLine("You Win!");
//        }
//        else if (rollTotal == 2 || rollTotal == 3 || rollTotal == 12)
//        {
//            Console.WriteLine("Craps");
//        }
//        else if (rollTotal == 9)
//        {
//            Console.WriteLine("Congrats on getting a nine!");
//        }
//        else if (rollTotal == 8 || rollTotal == 10)
//        {
//            Console.WriteLine("Sorry, try again this number is bad luck...");
//        }
//        else
//        {
//            Console.WriteLine(" ");
//        }
//        Console.WriteLine("");
//do
//{

//    Console.WriteLine("would you like to roll again? y/n");
//    string playAgain = Console.ReadLine().ToLower();
//    if (playAgain[0] == 'n')
//    {
//        continueRolling = true;
//        rollAgain = false;
//    }
//    else if (playAgain[0] == 'y')
//    {
//        continueRolling = true;
//    }
//} while (!continueRolling);

//    }
//}
//Console.WriteLine("Thanks for Playing!");
//=========================================================================