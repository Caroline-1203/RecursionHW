// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.


int M = 3;
int N = 9;

PrintListNumber(M,N);

void PrintListNumber(int start, int end)
{
    if(start <= end)
    {
        Console.WriteLine(start);
        PrintListNumber(start + 1, end);
    }
}
                    
