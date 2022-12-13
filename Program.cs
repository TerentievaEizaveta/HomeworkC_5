// Домашняя работа 

//Задаем массив
Console.Clear();
int [] CreateRundomArray(int size, int minValue, int maxValue)
{
    int [] array=new int [size];
    for (int i=0;i<size; i++)
    {
        array[i]=new Random().Next(minValue,maxValue+1);
    }
    return array;
}
// Выводим массив
void ShowArray(int [] array)
{
    for (int i=0;i<array.Length; i++)
    {
        Console.Write(array[i]+" "); 
    }
}


/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

/*
int NumberOfEvenElements (int [] array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
    {
    if (array[i] %2==0) count++;
    }
    return count;
}

Console.Write("Input number of elements: ");
int size=Convert.ToInt32(Console.ReadLine());
int minValue=100;
int maxValue=999;
int [] myArray=CreateRundomArray(size, minValue, maxValue);
ShowArray(myArray);
int NumberOfEvenNumbers=NumberOfEvenElements(myArray);
Console.Write("Number of even elements " + NumberOfEvenNumbers);
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

/*
int SumEluments(int [] array)
{
    int sum=0;
    for(int i=0; i <array.Length; i=i+2)
    {
        sum +=array[i];
    }
    return sum;
}
Console.Write("Input number of elements: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int maxValue=Convert.ToInt32(Console.ReadLine());

int [] myArray=CreateRundomArray(size, minValue, maxValue);
ShowArray(myArray);
Console.WriteLine(" ");

int SumElument = SumEluments(myArray);
Console.WriteLine("Sum of the elements standing in odd positions " + SumElument);
*/
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.

*/
/*
double [] CreateRundomDoubleArray(int size, int minValue, int maxValue)
{
    double [] array=new double [size];
    for (int i=0;i<size; i++)
    {
        array[i]=Math.Round(new Random().Next(minValue,maxValue+1) +new  Random().NextDouble(),2) ;

    }
    return array;
}

void ShowDoubleArray(double [] array)
{
    Console.Write("[");
    for (int i=0;i<array.Length; i++)
    {
        if (i==array.Length-1) Console.Write(array[i]+"");
        else Console.Write(array[i]+", "); 
    }
    Console.WriteLine("]");
}

double DiffBetweenMaxOfMin(double [] array)
{
    double Max=array[0];
    double Min=array[0];
    for(int i=0; i<array.Length;i++)
    {
        if (array[i]>Max) Max=array[i];
        if (array[i]<Min) Min=array[i];
    }
    double DifferenceBetweenMaxOfMin=Math.Round(Max-Min,2);
    return DifferenceBetweenMaxOfMin;

}

Console.Write("Input number of elements: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int maxValue=Convert.ToInt32(Console.ReadLine());

double [] myArray=CreateRundomDoubleArray(size, minValue, maxValue);
ShowDoubleArray(myArray);

double Diff=DiffBetweenMaxOfMin(myArray);
Console.WriteLine("Difference between Max-element of Min-element " + Diff);
*/