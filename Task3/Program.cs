// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.



// void PrintArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//         {
//             Console.Write($"{array[i]} ");
//         }
//         Console.WriteLine();
//     }

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//         {

//             array[i] = new Random().Next(1, 10);
//         }
//         PrintArray(array);
//     }

// int[] array = new int[10];

// FillArray(array);
// Console.WriteLine();
// PrintArray(array);

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
PrintArrayInReverse(array, array.Length - 1);

void PrintArrayInReverse(int [] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayInReverse(arr, index -1);
        }
    }

