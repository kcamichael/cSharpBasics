bool isRaining = true;
bool isGoingOutside = true;

//if (true/false value)
//{
//  Body of code, execute this code if above value is true
//}

if (isRaining)
{
    Console.WriteLine("It's raining out!");
}

// Is raining AND is going outside
if (isRaining && isGoingOutside)
{
    Console.WriteLine("Better bring an umbrella!");
}

// Not raining OR not going outside
if (!isRaining || !isGoingOutside)
{
    Console.WriteLine("I do not need an umbrella.");
}

// Exclusively not raining OR going outside
if (isRaining ^ isGoingOutside)
{
    Console.WriteLine("I will only go outside if it is not raining.");
}
