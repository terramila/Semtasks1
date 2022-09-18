Console.WriteLine("Введите число: ");
int num = Math.Abs(int.Parse(Console.ReadLine()));
 if ((num < 1000) & (num> 99)) //Math.Abs.поключает отрицательные числа 
{
    Console.WriteLine( num % 10);
}
else {
    Console.WriteLine("Число не соответсвует условиям задачи");
}