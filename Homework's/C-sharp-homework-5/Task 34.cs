// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] => 2



Console.WriteLine("Введите размер массива:  ");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = new int[x];
int result = 0;
int count = array.Length;
int position = 0;
for (int i = 0; i < x; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0) result++;
}
while (position < count){
    Console.Write($" {array[position]} ");
    position++;
}

System.Console.WriteLine($"Ваш результат => {result}");


