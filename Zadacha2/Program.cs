/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 && number > -100)
{
    Console.WriteLine("Третьей цифры нет");
}
if (number >= 100)
{
    int digitIndex = 2;
    int third = number.ToString()[digitIndex] - '0';
    Console.WriteLine("Третья цифра: " + third);
}
if (number <= -100)
{
    int digitIndex = 3;
    int third = number.ToString()[digitIndex] - '0';
    Console.WriteLine("Третья цифра: " + third);
}