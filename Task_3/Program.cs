Console.WriteLine("Введите длину массива");
bool check = false;
int number = 0;
double differencesMaxMin = 0;

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

double[] GetArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().NextDouble() * 100;
        result[i] = Math.Round(result[i], 0);
    }
    return result;

}

double[] array = GetArray(ReadNumber());

Console.WriteLine(String.Join("; ", array));

double Differences(double[] array)
{
    double diff = 0;
    int size = array.Length;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < size; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    diff = max - min;
    return diff;
}
differencesMaxMin = Differences(array);

Console.WriteLine($"Разницу между максимальным и минимальным элементов массива = {differencesMaxMin}");