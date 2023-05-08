string instructorName = "Amanda";
string[] instructors = new string[] { "Michael", "Joshua", instructorName };

//foreach(declaredIterator in enumerableCollection)
//    body

foreach (string name in instructors)
{
    Console.WriteLine(name);
}

int[] numbers = new int[] { 1, 5, 10, -4, 12, 0 };

foreach (int number in numbers)
{
    if (number > 0)
    {
        Console.WriteLine($"{number} is a positive number.");
    }
    else if (number < 0)
    {
        Console.WriteLine($"{number} is a negative number.");
    }
    else
    {
        Console.WriteLine($"{number} is a neutral number.");
    }
}