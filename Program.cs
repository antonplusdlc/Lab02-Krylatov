Console.WriteLine("Границы целочисленных типов");
Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
Console.WriteLine($"int {int.MinValue} .. {int.MaxValue}");
Console.WriteLine($"long {long.MinValue} .. {long.MaxValue}");

Console.WriteLine();

Console.WriteLine("Границы дробных типов");
Console.WriteLine($"float {float.MinValue} .. {float.MaxValue}");
Console.WriteLine($"double {double.MinValue} .. {double.MaxValue}");
Console.WriteLine($"decimal {decimal.MinValue} .. {decimal.MaxValue}");

Console.WriteLine();

Console.WriteLine("Переполнение byte");

byte maxByte = 255;
byte overflowed = (byte)(maxByte + 1);
Console.WriteLine($"255 + 1 for byte = {overflowed}");

Console.WriteLine();

Console.WriteLine("char");

char firstLetter = 'A';
char separator = '-';
int charAsNumber = firstLetter; // unicode prekolchiki

Console.WriteLine($"Symbol: {firstLetter}, separator: {separator}");
Console.WriteLine($"Symbol code '{firstLetter}' into unicode: {charAsNumber}");
Console.WriteLine($"tabulation:\tпосле таба");
Console.WriteLine($"перенос:\nпосле переноса");

Console.WriteLine();
Console.WriteLine("decimal vs double");

double priceDouble = 0.1 + 0.2;
decimal priceDecimal = 0.1m + 0.2m;

Console.WriteLine($"double: 0.1 + 0.2 = {priceDouble}");
Console.WriteLine($"decimal: 0.1 + 0.2 = {priceDecimal}");

Console.WriteLine();
Console.WriteLine("var");

var studentAge = 20; // int
var gpa = 4.75; // double
var fullName = "Smirnova A.C"; // string

Console.WriteLine($"{fullName}, {studentAge}, {gpa}");

Console.WriteLine();
Console.WriteLine("Enter text");

Console.Write("enter your name: ");
string name = Console.ReadLine();

Console.Write("enter your group: ");
string groupName = Console.ReadLine();

Console.WriteLine($"Hello, {name} from group {groupName}!");

Console.WriteLine();
Console.WriteLine("convert and parse");

Console.Write("Enter your year roshdenia: ");
string yearInput = Console.ReadLine();

int yearConvert = Convert.ToInt32(yearInput);
int yearParse = int.Parse(yearInput);

Console.WriteLine($"Convert.ToInt32: {yearConvert}");
Console.WriteLine($"int.Parse: {yearParse}");
Console.WriteLine($"2030: {2030 - yearConvert} years old");

Console.WriteLine();
Console.WriteLine("TryParse");

Console.Write("дай кол-во книг сколько мечтал прочитать за семестр: ");
string booksCnt = Console.ReadLine();

bool wasSuccess = int.TryParse(booksCnt, out int booksCount);

Console.WriteLine($"Success: {wasSuccess}");
Console.WriteLine($"booksCount: {booksCount}");