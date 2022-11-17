/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным*/

Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1 || day == 2 || day ==3 || day == 4 || day == 5)
{
    Console.WriteLine("Рабочий день");
}
if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
if (day < 1 || day > 7)
{
    Console.WriteLine("Такого дня нет");
}