/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа*/

int randomNumder = new Random().Next(100, 1000);
int firstDigit = randomNumder / 10;
int secondDigit = firstDigit % 10;

Console.WriteLine(randomNumder + "->" + secondDigit);