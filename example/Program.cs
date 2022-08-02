int[] array = new int[12];

SetArray(array);
PrintArray(array);
Zadacha31(array);

array = SetArrayFunc(array.Length);
PrintArray(array);
Zadacha31(array);


void SetArray(int[] currentArray)
{
    Random rand = new Random();
    for (int i=0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(-9, 10);
    }
}

int[] SetArrayFunc(int size)
{
    int[] newArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(-9, 10);
    }
    return newArray;
}

void PrintArray(int[] currentArray)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива на печать:");
    for (int i=0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }
    Console.WriteLine();
}

void Zadacha31(int[] currentArray)
{
    Console.WriteLine();
    Console.WriteLine("Начинатся подсчет сумм...");
    int sumPos = 0;
    int sumNeg = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] > 0) sumPos += currentArray[i];
        else sumNeg += currentArray[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма положительных элементов равна {sumPos}, сумма отрицательных элементов равна {sumNeg}");
}
