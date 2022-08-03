bool goAgain = true;
bool correctNum = false;
do
{
    Console.WriteLine("please enter in an integer: ");
    int userInput = int.Parse(Console.ReadLine());
     do
    {
        if (userInput >= 1)
        {
            correctNum = true;

        }
        else
        {
            correctNum = false;
            Console.Write("try again, Please enter a new integer:");
            userInput = int.Parse(Console.ReadLine());
        }
    } while (correctNum == false);
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("Number  |  squared  |  cubed");
    Console.WriteLine("======     =======     =====");
    for (int i = 1; i <= userInput; i++)

    {
        int squared = i * i;
        int cubed = i * i * i;
        Console.WriteLine(String.Format("{0,-6}  |  {1,-6}  | {2,6}", i, squared, cubed));

    }
    bool valid = false;
    do
    {
        Console.Write("Would you like to go again? (y/n): ");
        string entry = Console.ReadLine().ToLower();
        if (entry == "n" || entry == "no")
        {
            valid = true;
            goAgain = false;
        }
        else if (entry == "y" || entry == "yes")
        {
            valid = true;
        }
    } while (valid == false);
} while (goAgain == true);


