
/*Random rand = new Random();
int number = rand.Next();
Console.WriteLine(number);*/

void Zadacha29()
{
    int size = 8;
    int [] array = new int[size];
    array = FillArray(size);

    PrintArray(array);
    ArraySort(array);
}

int [] FillArray(int size)
{
    int [] fillArray = new int[size];
    Random random = new Random();
    for(int i = 0; i < fillArray.Length; i++)
    {
        fillArray[i] = random.Next(-10,11);
    }
    return fillArray;
}

void PrintArray(int [] array)
{
    Console.WriteLine("Вывод массива ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ArraySort(int [] array)
{

    for(int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for(int j = i +1; j < array.Length; j++)
        {
           
            if(Math.Abs(array[j]) < Math.Abs(array[minPosition]))
            {
                minPosition=j;
            }
        }    
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
        }
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
}

Zadacha29(); 