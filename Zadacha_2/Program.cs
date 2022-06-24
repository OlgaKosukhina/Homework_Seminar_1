/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Insert first number");
string first = Console.ReadLine();
int firstNumber = int.Parse(first);

Console.WriteLine("Insert second number");
string second = Console.ReadLine();
int secondNumber = int.Parse(second);

if (firstNumber > secondNumber)
{
    Console.WriteLine($"{firstNumber} is maximum number, {secondNumber} is minimum number");
}
else
{
    Console.WriteLine($"{secondNumber} is maximum number, {firstNumber} is minimum number");
}
