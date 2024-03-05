void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        System.Console.Write($"{e} ");
    }
}

int[] array = { 22, 24, 30, 40, 50 };
ZeroEvenElements(array);
PrintArray(array);

// Мы создали функцию, которая обнулит чётные элементы массива. И затем вывели значения на экран.
  
