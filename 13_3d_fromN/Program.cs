// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Write a number with several digits in it: ");
int aNumber = int.Parse(Console.ReadLine());
string strNumber = Convert.ToString(aNumber);

if (strNumber.Length > 2)
{
    Console.WriteLine("3d digit is: " + strNumber[2]);
}
else
{
    Console.WriteLine("Not a 3-digit number");
}