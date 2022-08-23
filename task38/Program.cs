/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.WriteLine("Введите массив через запятую ");
double[] array = Array.ConvertAll<string,double>
(Console.ReadLine().Split(','), i => { return System.Convert.ToInt32 (i);});
double maxValue = array[0];
double minValue = array[0];
int i = 0;
int count = array.Length;
while (i < count)
{
    if (array[i] >= maxValue)
    {
        maxValue = array[i];

    }
    else if (array[i] <= minValue)
    {
        minValue = array[i];
    }
i++;
}
double res = maxValue - minValue;
Console.WriteLine(res);