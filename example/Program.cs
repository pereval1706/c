int[] array = new int[12];

SetArray(array);

array = SetArrayFunc(array.Length);

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
    for (int i=0; i < newArray.Length; i++);
    {
        newArray[] = rand.Next(-9, 10);
    }
    return newArray;
}
