Console.Clear();

int NumberA = new Random().Next(100, 999);

int A = NumberA % 10;

if (NumberA / 100 > 0)
{
Console. WriteLine($" Третья цифра в {NumberA} --> {A} ");
}

else
{
Console. WriteLine($" {NumberA} --> двухзначное число ");
}