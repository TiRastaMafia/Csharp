/*更更更更更更更更更更更更更更更更更�       楳籥�� 66:           更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更更*/
// 楳籥蜥� 芻瑾纃�� M � N. 沃闊�蓿� 關釿鞐跛�, 褌鴈鞐� 轢蜆交 體跛� 轢鴦鞐譛逶� �諷跂迺鈞 � 關鉤繙齟裙 銜 M 粮 N.

Console.WriteLine("代粫鱚 � 袱褌� �蔗顋 轢�瑩�: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("代粫鱚 � 袱褌� �蔗顋 轢�瑩�: ");
int b = Convert.ToInt16(Console.ReadLine());

int SummNumbers(int a, int b)
{  
 if (a == b) return - b*2 - a;
 else return SummNumbers(a, b-1) + a + b ;
}
Console.WriteLine(SummNumbers(a,b));
