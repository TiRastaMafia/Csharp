// Ввод координат двух точек по осям X Y Z
/*double distance;
Console.Write("Введите значение x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
Console.ReadKey();*/






internal class Program
{
    private static void Main(string[] args)
    {
// Приглашение к вводу координат
        Console.WriteLine("Введите через пробел значения x1, y1, z1, x2, y2, z2, нажмите enter"); 
// Создание массива и инициализирование элементов с клавиатуры 
        double[] array = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();
// Проверка на правильность заполнения количества координат при ошибке рестарт
            if (array.Length != 6){
            System.Console.WriteLine("Вы ввели неправильные координаты");
                return;
            }
// Расчет расстояния между 2-мя точками в пространстве по формуле https://calculatorium.ru/math/distance-between-two-points-in-3d
        Console.WriteLine(Math.Sqrt(Math.Pow(array[3] - array[0], 2) + Math.Pow(array[4] - array[1], 2) + Math.Pow(array[5] - array[2], 2)));
    }
}
