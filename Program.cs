
Console.WriteLine("Введите количество элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
string[] array = new string[numberOfElements];

FillArray(array);

void FillArray(string[] collection)
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
	    Console.Write("Введите элемент массива: ");
        string element = Convert.ToString(Console.ReadLine());
        collection[index] = element;
        index++;
	}
}