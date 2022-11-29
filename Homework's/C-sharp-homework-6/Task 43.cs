Console.WriteLine("Введите:\n\r'b1' \n\r'k1' \n\r'b2' \n\r'k2'");
// значения заводим в массив с клавиатуры
// AB CD
double x = 0;
double y = 0;
double[] numbers = { 0, 0, 0, 0 };
  for (int i = 0; i < numbers.Length; i++)
 {
    numbers[i] = Convert.ToInt16(Console.ReadLine());
}
if(((numbers[1] == numbers[3]) && (numbers[0] == numbers[2]))){
    System.Console.WriteLine("Прямые совпадают");
}
else if (numbers[1]==numbers[3]){
    System.Console.WriteLine("Прямые паралельны");
}
else{
    x = (numbers[2]-numbers[0])/(numbers[1]-numbers[3]);

y = (numbers[1]*(numbers[2]-numbers[0]))/(numbers[1]-numbers[3])+numbers[0];
}


Console.WriteLine(x);
Console.WriteLine(y);
