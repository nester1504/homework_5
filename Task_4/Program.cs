Console.WriteLine("Введите длину массива");
bool check = false;
int number = 0;

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
        result[i] = new Random().Next(100);
    }
    return result;

}

int[] array = GetArray(ReadNumber());

Console.WriteLine(String.Join("; ", array));

void Sum(int[] array)
{
    int res = 0;
    int size = array.Length;

    if (size % 2 == 0)
    {
        for (int i = 0; i < size / 2; i++)
        {
            res = array[i] * array[size - 1];
            Console.Write($"{res}; ");
        }

    }
    else
    {
        for (int i = 0; i < size / 2; i++)
        {
            res = array[i] * array[size - 1];
            Console.Write($"{res}; ");
        }
        res = array[size / 2 ];
        Console.Write($"{res}; ");
    }

}
Sum(array);