Console.WriteLine("Введите длину массива");
bool check = false;
int number = 0;
int res = 0;
int count = 0;

int ReadNumber()
{
    while (check == false)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            check = true;
        }
        else
        {
            Console.WriteLine("Не удалось распознать число, поробуйте ещё раз");
        }
    }
    check = false;
    return number;
}


int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;

}

int CountEvenNumbers(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(ReadNumber());

Console.WriteLine(String.Join("; ", array));

count = CountEvenNumbers(array);

Console.WriteLine($"Количество четных часел = {count}");