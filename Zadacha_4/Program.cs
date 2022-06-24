/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Insert first number");
string first = Console.ReadLine();
int firstNumber = int.Parse(first);

Console.WriteLine("Insert second number");
string second = Console.ReadLine();
int secondNumber = int.Parse(second);

Console.WriteLine("Insert third number");
string third = Console.ReadLine();
int thirdNumber = int.Parse(third);

int maximum = firstNumber;

if (secondNumber > maximum)
{
    maximum = secondNumber;

}

if (thirdNumber > maximum)
{
    maximum = thirdNumber;

}
Console.WriteLine($"{maximum} is maximum number");