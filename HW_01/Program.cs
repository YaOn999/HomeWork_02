// {
//     Console.Write("введите трехзначное число: ");
//     number = int.Parse(Console.ReadLine());
//     if (number < 100 || number > 999)
//     {
//         Console.WriteLine("нужно ввести трехзначное число!");
//         continue;
//     }
//     break;
// }

Console.Clear();

Console.Write("введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int result = number / 10 % 10;
Console.WriteLine("второе число числа " + number + " является " + result);