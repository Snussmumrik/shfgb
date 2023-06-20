Console.Clear();

Console.WriteLine("Ввведите трехзначное число: ");
string userInput = Console.ReadLine() ?? "" ;
int num = int.Parse(userInput);

int a = num % 100;

int result = a / 10;

Console. WriteLine($" Вторая цифра в {num} --> {result} ");