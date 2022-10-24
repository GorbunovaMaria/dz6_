/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return myArray;
}

void ShowArray (int[]array)    //покажи массив
{
    Console.Write("Получившийся массив -> " );
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i]+ " ");
    }      
}

int ConvertTo2 (int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(a, min, max);
ShowArray (myArray);
int result = ConvertTo2 (myArray);
Console.WriteLine($"-> {result}");*/

/*Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
/*
void ConvertTo2 (double b1, double k1, double b2, double k2)
{ 
double xIntersection = 0;
double yIntersection = 0;
xIntersection =(b2-b1)/(k1-k2);
yIntersection =k1*xIntersection+b1;

Console.WriteLine ($"Точкa пересечения двух прямых ({xIntersection}) ; ({yIntersection}) ");
}
Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());
ConvertTo2 (b1, k1, b2, k2);*/

