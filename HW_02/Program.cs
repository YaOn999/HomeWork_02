// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 1000)
{
    while (number > 1000) 
    {
    number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine("третья цифра введенного числа " + result);
}
else
{
    Console.Write("третьей цифры нет");
}

