Console.WriteLine("Welcomer to Grand Circus' Room Detail Generator!");
Console.Write("Enter Length: ");
double length = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter Width: ");
double width = Convert.ToDouble(Console.ReadLine());
double area = length * width;
double perimeter = length + length + width + width;
Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter:{perimeter}");
if (area <= 250)
{
    Console.WriteLine("Calculated: This is a small-sized room");
}
else if (area > 250 && area < 650 ) // can remove the area < 250 portion since if it less than or equal to 250 from the first line of code it wont go to the following rule set.
{
    Console.WriteLine("Calculated: this is a medium-sized room");
}
else //if (area >= 650 )
{
    Console.WriteLine("Calculated: this is a large-sized room");
}
Console.WriteLine("BONUS TIME!");
Console.Write("Please Enter the Height: ");
double height = Convert.ToDouble(Console.ReadLine());
double volume = length * width * height;
double surfaceArea = (2 * length * height) + (2 * width * height) + (2 * length * width);
Console.WriteLine($"The Volume of this room is {volume}");
Console.WriteLine($"The Surface Area of the room is {surfaceArea}");
Console.WriteLine("Thank you for using the Room Detail Generator!");


