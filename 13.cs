// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(1,10000000);
Console.WriteLine(number);
string str = number.ToString();
if (str.Length < 3)
{
Console.WriteLine("третьей цифры нет");
}
else
{
   int a = (int)Char.GetNumericValue(str[2]);
   Console.WriteLine($"{a}"); 
}
