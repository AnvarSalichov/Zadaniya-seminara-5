// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = new double [5];

GetRandom(array);

void GetRandom(double [] massiv)
{
	for (int i = 0; i <massiv.Length; i++)
	{
	massiv[i] = new Random().Next(0,100);
    }
}
Console.WriteLine(String.Join(", ", array));

double minnum = array[0];
double maxnum = array[0];
for (int i = 0; i <array.Length; i++)
{
    if (array[i]>maxnum)
    {
    maxnum=array[i];
    }
    else if (array[i]<minnum)
    {
    minnum=array[i];
    }
   }   

Console.WriteLine("Наибольшее число = "+maxnum);
Console.WriteLine("Наименьшее число = "+minnum);
Console.WriteLine("Разница = "+(maxnum-minnum));

