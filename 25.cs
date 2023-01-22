int numberA = new Random().Next(1, 10);
Console.WriteLine($"Число А = {numberA}");
int numberB = new Random().Next(1, 10);
Console.WriteLine($"Число B = {numberB}");

int number = 1;
for (int i = 1; i <= numberB; ++i)
{
    number = number * numberA;
}
 Console.WriteLine($"{number}");
