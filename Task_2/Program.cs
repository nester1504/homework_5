Console.WriteLine("Введите длину массива");
bool check = false;
int number = 0;
int sum = 0;

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
        result[i] = new Random().Next(-100, 101);
    }
    return result;

}

int SumPosition(int[] array)
{
    int size = array.Length;
    int sum = 0;
    for (int i = 1; i < size; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] array = GetArray(ReadNumber());

Console.WriteLine(String.Join("; ", array));

sum = SumPosition(array);

Console.WriteLine($"Сумма чисел в нечётных позициях = {sum}");