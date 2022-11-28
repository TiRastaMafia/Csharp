/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

// проверки на введения цифр а не строки
int number = 0;
while (true){
    Console.Write("Введите пятизначное число: ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
}
int oldValue = number;
// проверка на то что число 5 значное
if (oldValue < 9999 || oldValue > 99999){
    Console.Write("Указанно не пятизначное число! ");   
    Console.ReadKey();
    return;      
}
// проверка на полиндромность     
int newValue = 0;
while (number > 0){
    int dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;
}
// вывод результата
if (newValue == oldValue)
    Console.WriteLine($"Число {oldValue} является палиндромом");
else
    Console.WriteLine($"Число {oldValue} не является палиндромом");