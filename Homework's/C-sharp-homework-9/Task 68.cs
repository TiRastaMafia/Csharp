/*№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№       Задача 68:           №№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№№*/
//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9 
// m = 3, n = 2 -> A(m,n) = 29

static int A(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));

}
Console.WriteLine("Ведите n: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ведите m: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(A(n, m));
