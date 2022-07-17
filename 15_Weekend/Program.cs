// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Insert number of day of the week to check if it is a weekend: ");
int weekDayNum = int.Parse(Console.ReadLine());

if((weekDayNum == 6) ^(weekDayNum == 7))
{
    Console.WriteLine("It is a weekend, yahoo!");
}
else if(1 > weekDayNum || weekDayNum > 7)
{
    Console.WriteLine("It's not the day of the week.");
}
else
{
    Console.WriteLine("Oh, no! It's a weekday. You've gotta work!");
}
