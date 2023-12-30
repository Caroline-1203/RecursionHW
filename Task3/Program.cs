// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
PrintArrayInReverse(array, array.Length - 1);

void PrintArrayInReverse(int [] arr, int index)
    {
        if (index >= 0)
        {
            
            Console.Write(arr[index] + " ");
            
            PrintArrayInReverse(arr, index -1);
            
        }
    }

