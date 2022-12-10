// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int [] array = new int [6];
GetArray(array);
void GetArray(int [] massiv)
{
	for (int i = 0; i <massiv.Length; i++)
	{
	    massiv[i] = new Random().Next(100,1000);
	}
}

Console.Write(String.Join(", ", array));
Console.WriteLine();

int count=0;
for (int i = 0; i <array.Length; i++)
{
    if (array[i]%2==0)
    {
        count++;
    }
}

Console.WriteLine("в данном массиве имеется "+count+" четных чисел");

