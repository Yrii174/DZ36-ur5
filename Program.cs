// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] CreateArray(int size, int min, int max)  
{ 
System.Console.WriteLine("Задайте длину массива");
size = int.Parse(Console.ReadLine());
int[] array = new int[size];  
for (int i = 0; i < size; i++)   
    { 
    array[i] = new Random().Next(min, max);
    i = i++;   
    }
    return array; 
} 
string GetArray(int[] array)  
{      
string sum = string.Empty;      
for (int i = 0; i < array.Length; i++)      
    {
      sum = sum + $"{array[i]}, ";      
    }                   
    return sum;  
} 
int ArrayChetny(int [] array)  
{
int chetny = 0;          
foreach (int element in array)     
{         
    if (element % 2 != 0) chetny ++;    
}     
return chetny; 
} 
int[] array = CreateArray(8,int.MinValue, int.MaxValue);
System.Console.WriteLine(GetArray(array));
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна: {ArrayChetny(array)}");