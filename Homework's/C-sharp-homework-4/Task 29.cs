Console.WriteLine("Введите массив из введенных через запятую цифр\n ");
string str = Console.ReadLine();
char[] arr;
arr = str.ToCharArray();
Console.WriteLine("[{0}]", str);
// Для проверки на массив раскомментируйте две строки ниже этого сообщения
// foreach (char c in arr)
// Console.WriteLine(c);