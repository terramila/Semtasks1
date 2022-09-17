Console.WriteLine("Введите число1 : ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.WriteLine("Введите число2 : ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
if (number2 * number2 == number1) 
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}