Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
 if ((num < 1000) & ( num > 99))
{
    Console.WriteLine( num % 10);
}
else {
    Console.WriteLine("Число не соответсвует условиям задачи");
}