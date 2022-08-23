/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях(по индексу считаем).

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
 int [] GetArray(int minValue, int maxValue)
 {
    int[] res = new int[size];
    for (int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
 }
 int[] array = GetArray(100,999);
int sumOdd=0;
int i = 0;
while (i<size)
{
     if (i % 2 != 0)  
    { 
    sumOdd += array[i]; 
    }
    i++;   
}
Console.WriteLine($"Сумма чисел стоящих на нечетных позициях: {sumOdd}"); 