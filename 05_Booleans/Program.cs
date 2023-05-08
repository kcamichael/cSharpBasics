bool isCool = false;
isCool = true;

//-- Boolean Logical Operators
// Negation Operator
bool isTrue = !false;
bool isFalse = !true;

// AND Operator
bool trueAndExample = true && true;
bool falseAndExample = true && false;

// OR Operator
bool trueOrExample = true || false;
bool falseOrExample = false || false;

// XOR Operator
bool trueExclusiveOr = true ^ false;
bool falseExclusiveOr = true ^ true;

Console.WriteLine($"NOT False = {isTrue}");
Console.WriteLine($"False AND True = {falseAndExample}");
Console.WriteLine($"True OR True = {trueOrExample}");
Console.WriteLine($"True XOR True = {falseExclusiveOr}");