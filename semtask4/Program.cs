Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());
for  (int i = number*(-1); i <= number ; i++)
{
    Console.Write(i + $" ");
}
// Console.WriteLine("введите число: ");
// int num  = int.Parse(Console.ReadLine());
// int count = -num;
// while (count <= num )
// {
//   Console/Write($"{count} ");
//    count ++;
// } 