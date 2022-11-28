System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); ;
int sum = 0;
for (; ; )
{
    if (number == 0)
        break;
    else
    {
        sum += number % 10;
        number /= 10;
    }

}
System.Console.WriteLine(sum);
