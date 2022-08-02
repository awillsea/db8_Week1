string name = "Fred";
Console.WriteLine(  name  );
string upperName = name.ToUpper(); // Strings are "immutable" 
Console.WriteLine(upperName);
Console.WriteLine(name);

Console.WriteLine(name[0]);
Console.WriteLine(name[1]);
Console.WriteLine(name.ToLower());


// floating point types

double pi = 3.1415926;
Console.WriteLine(pi);
double pi2 = pi * 2;
Console.WriteLine(pi2);
Console.WriteLine(  Math.Sqrt(pi)  );

double q = Math.Sqrt(25);
Console.WriteLine(q);

// when working with money we dont use float or double.
// use decimal when involved with money, use the Letter m after the int


decimal amount = 99.95m;
Console.WriteLine(amount);
amount = amount * 5;
Console.WriteLine(amount);

bool passed = true;
Console.WriteLine(passed);
passed = false;
Console.WriteLine(passed);
passed = !passed; // passed was false; the "not" operator flips it to true;
Console.WriteLine(passed);

