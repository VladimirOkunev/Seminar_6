//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-7, 567, 89, 223-> 3

int [] GetArray(int size)
{
	int [] array = new int[size];
	Console.WriteLine($"Enter {size} numbers of the array: ");
	
	for(int i=0; i<size; i++)
	{
		array[i] = int.Parse(Console.ReadLine() ?? "0");
			}
	return array;
}

void PrintArray(int [] array)
{
    Console.Write("The created array: ");
	foreach(int el in array)
	{
		Console.Write($"{el} ");
	}
    Console.WriteLine();
}

int ZeroCounter(int [] array)
{
	int count = 0;
	foreach(int el in array)
	{
		if(el == 0) count++; 
	}
	return count;
}



Console.Clear();
Console.Write("Enter size of an array: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int [] newArray = GetArray(length);
PrintArray(newArray);
int counter = ZeroCounter(newArray);
Console.Write($"Numbers of zeros in the array: {counter}");
