/*更更更更更更更更更更更更更更更更更�       楳籥�� 64:           更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更*/
//  楳籥蜥� 芻瑾纃�� M � N. 沃闊�蓿� 關釿鞐跛�, 褌鴈鞐� 碼矼粤� 碌� 轢鴦鞐譛逶� �蔡諤 � 關鉤繙齟裙 銜 M 粮 N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("代粫鱚 � 袱褌� �蔗顋 轢�瑩�: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("代粫鱚 � 袱褌� �蔗顋 轢�瑩�: ");
int b = Convert.ToInt16(Console.ReadLine());
static string NumbersRec(int a, int b)
    {
     if (a <= b) return NumbersRec(a, b-1) + $"{b}, ";
     else return string.Empty;
    }
Console.WriteLine(NumbersRec(a,b));