Console.WriteLine("Введите диагональ массива: ");
int N = Convert.ToInt16(Console.ReadLine());
int final_element = N - 1;
int num = 1;

// int delta = 0; // Поменять рамку заполнения где 1 самая полная
int[,] numbers = new int[N, N];

void CreateSumm_array_array2(int[,] numbers)
{
    for (int delta = 0; delta < N - 2; delta++)
    {
        for (int i = 0 + delta; i < N - delta; i++)
        {
            numbers[0 + delta, i] = num;
            num++;
        }
        num--; // уменьшение num для исключения наложения при переключении стороны
        for (int i = 0 + delta; i < N - delta; i++)
        {
            numbers[i, final_element - delta] = num;
            num++;
        }
        num--;
        for (int i = N - 1 - delta; i >= 0 + delta; i--)
        {
            numbers[final_element - delta, i] = num;
            num++;
        }
        num--;
        for (int i = N - 1 - delta; i >= 1 + delta; i--)
        {
            numbers[i, 0 + delta] = num;
            num++;
        }
        num--;
        num++;
    }
}

void WriteArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,3}", numbers[i, j]));
        }
        Console.WriteLine();
    }
}

CreateSumm_array_array2(numbers);
WriteArray(numbers);