
static int FindMin(int[] array)
{
    int min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    return min;
}

static int FindMax(int[] array)
{
    int max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    } 

    return max;
}

int[] array = { 4, 6, 1, 9, 2 };

int min = FindMin(array);
int max = FindMax(array);

Console.WriteLine("Минимальный элемент: " + min);
Console.WriteLine("Максимальный элемент: " + max);