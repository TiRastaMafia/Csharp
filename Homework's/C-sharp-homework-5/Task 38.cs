// // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// // [3 7 22 2 78] -> 76

Console.WriteLine("Введите длинну массива: ");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = new int[x];
int min = int.MaxValue;
int max = int.MinValue;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 1000);
// Вывести массив целиком
    Console.Write("{0} ", array[i]);
// если индекс 
    if (min > array[i])
    {
        min = array[i];
    }
    if (max < array[i])
    {
        max = array[i];
    }
}

Console.WriteLine($"      результат между {max} и {min}      равен => {max - min}");
