int[] array = GetArray(12, -9, 9);
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;

}
int sumPositive = 0; // Сумма положительных чисел
int sumNegative = 0; // Сумма отрицательных чисел
int size = array.Length;
for (int i = 0; i < size; i++)
{
    if (array[i] > 0)
    {
        //sumPositive = sumPositive + array[i];
        sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i]; // sumNegative = sumNegative + array[i]
    }
}
Console.WriteLine($"Сумма положительных чисел: {sumPositive}, отрицательных чисел: {sumNegative} ");