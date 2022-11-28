// // Задайте массив заполненный случайными положительными трёхзначными числами. 
// // d.
// // [345, 897, 568, 234] -> 2



Console.WriteLine("Введите длинну массива: ");
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

System.Console.WriteLine($" четных чисел => {result}");


