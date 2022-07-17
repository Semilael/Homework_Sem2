// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Write three-digit number: ");
int number = int.Parse(Console.ReadLine());

int num2 = (number / 10) % 10;
Console.WriteLine($"Now I show you 2nd digit: {num2}");