// for loop 

for ( int index = 0; index < 10; index ++)
{
    Console.WriteLine(index);
}
Console.WriteLine();
for (int index = 0; index < 10; index +=2)
{
    Console.WriteLine(index);
}
Console.WriteLine();
for (int index = 21; index >= 0; index = index - 3)
{
    Console.WriteLine(index);
}
Console.WriteLine("all done! on too while loops");
Console.WriteLine();

// while loops

int w = 1;
while ( w < 5) 
{
    Console.WriteLine("inside while loop");
    Console.WriteLine(w);
    w++;
}

// Example of a break statement inside a while (true) 

int w2 = 10;
while ( w2 >= 0)
{
    if ( w2 == 4)
    {
        Console.WriteLine("oops, found corrupted data");
        break; // this exits the loop immediately (Break does not exit out of if statements.)

    }
    Console.WriteLine(w2);
    w2--;
}
Console.WriteLine("finished with while loops. on to do-while loops");
Console.WriteLine();

//With While loops, the condition is test before each iteration.
//With do-while loops, the condition is test after each iteration.


int w3 = 0;
do
{
    Console.WriteLine(w3);
    w3++;
}
while ( w3 < 10);

Console.WriteLine("All done with do-while loops Now a nested for loop!");


for (int x = 1; x <= 5; x++)
{
    Console.WriteLine($"Starting outer loop. x is {x}");
    for (int y = 1; y <= 3; y++)
    {
        Console.WriteLine($"x:{x}  y:{y}");
    }
    Console.WriteLine();
}

Console.WriteLine("How about a clock");

for (int hour = 0; hour < 24; hour++)
{
    Console.WriteLine($"The Hour is {hour}");
    for(int minute = 0; minute < 60; minute++)
    {
        Console.WriteLine($"  {hour}:{minute}");
    }
}

