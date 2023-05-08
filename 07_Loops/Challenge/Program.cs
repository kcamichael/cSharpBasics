//Write a for loop to print the numbers 500 through 525.

//-- Bronze
for (int i = 500; i <= 525; i++)
{
    Console.WriteLine(i);
}

//Create a for loop to print the numbers from 0-100 by 5's.
//-- Silver
for (int i = 0; i <= 100; i += 5)
{
    Console.WriteLine(i);
}

// or alternative Silver
for (int i = 0; i <= 100; i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}

