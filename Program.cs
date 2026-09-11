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