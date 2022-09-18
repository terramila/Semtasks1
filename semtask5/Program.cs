Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
 if ((Math.Abs(num) < 1000) & (Math.Abs(num)> 99)) //Math.Abs.поключает отрицательные числа 
{
    Console.WriteLine( num % 10);
}
else {
    Console.WriteLine("Число не соответсвует условиям задачи");
}