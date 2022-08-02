﻿// Instructions:

bool keepGoing = true;

do
{
    // =================================================================================
    //
    // this is the thing you want to do over and over as long as they want to keep going
    //
    Console.Write("Please enter a number: ");
    string entry = Console.ReadLine();
    double num = double.Parse(entry);
    Console.WriteLine($"That number squared is {num * num}");
    //
    // =================================================================================


    // ask the user if they want to go again

    bool valid = false;
    do
    {
        Console.Write("Would you like to go again? (y/n): ");
        entry = Console.ReadLine().ToLower();
        if (entry == "n" || entry == "no")
        {
            valid = true;
            keepGoing = false;
        }
        else if ( entry == "y" || entry == "yes")
        {
            valid = true;
        }
    } while(valid == false);
}while(keepGoing == true);


