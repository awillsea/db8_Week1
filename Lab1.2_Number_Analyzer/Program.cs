bool stop = false;
bool valid = false;
Console.Write("Hello, Please enter your name: ");
string name = Console.ReadLine();
bool validTwo = false;
// the first do..while loop encapsulate everything inside. it will process the first do loop inside then the second then back to the top if promoted. 
do
{
    Console.Write("Please enter an integer between 1 and 100: ");
    double number = double.Parse(Console.ReadLine());
    do
    {
        if (number >= 1 && number <= 100)
        {
            validTwo = true;

        }
        else
        {
            validTwo = false;
            Console.Write("try again, Please enter new number:");
            number = double.Parse(Console.ReadLine());
        }
    } while (validTwo == false); // the code will read this loop first and then will move on only after it passes the requirement

     if (number % 2 != 0 && number < 60)
        {
            Console.WriteLine($"{name} Entered: {number} which is an Odd number and less than 60");

        }
        else if (number % 2 == 0 && number >= 2 && number <= 24)
        {
            Console.WriteLine($"{name} Entered: {number} which is an Even number and less than 25");

        }
        else if (number % 2 == 0 && number >= 26 && number <= 60)
        {
            Console.WriteLine($"{name} Entered: {number} which is an Even number and between 26 and 60 ");

        }
        else if (number % 2 == 0 && number > 60)
        {
            Console.WriteLine($"{name} Entered: {number} which is an Even number and greater than 60");
        }
        else if (number % 2 != 0 && number > 60)
        {
            Console.WriteLine($"{name} Entered: {number} which is an Odd number and greater than 60 ");

        }
        else
        {
            Console.WriteLine($"{name}, you did something wrong...");
        }
    do // then after it will read this loop. and we can only move on from this until the criteria is met.
        {
            Console.WriteLine("would you like to go again? y/n: ");
            string entry = Console.ReadLine().ToLower();
            if (entry == "n" || entry == "no")
            {
                stop = true;
                valid = true;
            }
            else if (entry == "y" || entry == "yes")
            {
                stop = false;
                valid = true;
            }
     } while (valid == false);
 } while (stop == false);//the loop will keep going around and around until this is true.
