//-- Gold
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
// Links to an external site.
string year = "2021";
int yearNumber = int.Parse(year);
Console.WriteLine(yearNumber);

int anotherNumber = Convert.ToInt32(year);
Console.WriteLine(anotherNumber);