string[] FilterStrings(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newArray = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }

    return newArray;
}

void PrintArray (string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        System.Console.Write(newArray[i] + " ");
    }
    System.Console.WriteLine();
}

Console.WriteLine("Введите элементы массива, разделяя их запятой:");
string[] inputArray = Console.ReadLine().Split(',');
string[] newArray = FilterStrings(inputArray);
PrintArray(newArray);




