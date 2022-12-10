// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int [] array = new int [4];
int negativSum = 0;

GetArray(array);

void GetArray(int [] massiv)
{
	for (int i = 0; i <massiv.Length; i++)
	{
	    massiv[i] = new Random().Next(-99,100);
        if (i%2 != 0)
        negativSum = negativSum + massiv[i];
	}
}

Console.WriteLine(String.Join(", ", array));
Console.WriteLine("Сумма нечетных элементов массива = "+ negativSum);


