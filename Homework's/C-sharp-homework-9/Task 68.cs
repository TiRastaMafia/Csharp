/*更更更更更更更更更更更更更更更更更�       楳籥�� 68:           更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更*/
//  沃闊�蓿� 關釿鞐跛� 碼�蔡諷辷� �鼾襁蓙 占裙韭琿� � 闔跪��� 鞳褥韵蓙. 釣逶 籵� 辣銜韆�瑩繼�逶� �蔡諤 m � n.
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
Console.WriteLine("代粫鱚 n: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("代粫鱚 m: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(A(n, m));
