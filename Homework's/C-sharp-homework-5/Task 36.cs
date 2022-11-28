//  Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длинну массива: ");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = new int[x];

for (int i = 0; i < array.Length; i++)
//Цикл заполнения массива.
{
    //Присвоение случайного числа от 0 до 1000 [i]-тому элементу массива.
    array[i] = new Random().Next(0, 1000);

    Console.Write(array[i] + " ");//Вывод на экран.
}
Console.WriteLine("\nРезультат:");
//Цикл вывода массива.
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 2) array[i] += array[i] ;
                
    Console.Write(array[i] + " ");
}
