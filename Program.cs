

 /*int [] CreateRandomArray(int size, int minValue, int MaxValue) /// Массив
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);

    }
    return array;
}
*/

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();

}

/*


/////////////////    ЗАДАЧА 1    ////////////////////


// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int [] CreateTreeDigitArray(int size, int minValue, int MaxValue) /// Массив
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);

    }
    return array;
}

Console.Write("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input min threedigit number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input  max threedigit number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] NewArray = CreateTreeDigitArray(size, min, max);
ShowArray(NewArray);
Console.WriteLine();
Console.WriteLine();

int Even(int[] array) 
    
    {
    int j = 0;    
    for(int i =0; i < array.Length; i++)
    {
         if(array[i]%2 == 0)
         Console.WriteLine(array[i]);
            
    }
    return j;
    }

int result = Even(NewArray);

*/



/////////////////    ЗАДАЧА 2    ////////////////////
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*

int [] CreateRandomArray(int size, int min, int max) 
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);

    }
    return array;
}



int SumNegativeDigit(int[] array) 
    
    {
    int sum = 0;    
    for(int i =0; i < array.Length; i++)
    {
         if(i %2 == 0) 
            sum = sum + array[i+1];
         
        
    }
    return sum;
    }

Console.Write("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input min number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input  max number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] MyArray = CreateRandomArray(size, min, max);
ShowArray(MyArray);
Console.WriteLine();
Console.WriteLine();

int result = SumNegativeDigit(MyArray);
Console.WriteLine("Сумма элементов, стоящих на нечетных позииях = " + result);

*/




/////////////////    ЗАДАЧА 3    ////////////////////
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int [] CreateRandomArray(int size, int min, int max) 

{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);

    }
    return array;
}

int Difference(int[] array)
{
    int Big = array[0];
    int Small = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]>Big) Big = array[i];
        
    }
    for(int i = 0; i < array.Length; i++)
    {   
        if(array[i]< Small)  Small = array[i];
    }

    int dif = 0;
    dif = Big - Small;

    return dif;

}       


Console.Write("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input min number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input  max number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] MyArray = CreateRandomArray(size, min, max);
ShowArray(MyArray);
Console.WriteLine();
Console.WriteLine();

int result = Difference(MyArray);
Console.WriteLine("Разница между максимальным и минимальным элементов массива = " + result);




