
Console.WriteLine("Введите количество элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
string[] array = new string[numberOfElements];

FillArray(array);
string[] result = TrimmedArray(array);

for (int i = 0; i < result.Length; i++)
{
    Console.Write($"{result[i]}  ");
}

// Метод заполняет массив введенными с клавиатуры элементами
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

// Метод возвращает элементы массива, которые не длиннее трех символов
string[] TrimmedArray(string[] col)
{
    int count = col.Length;
    int position = 0;
    int resultArrayLength = 0;

    // Цикл для подсчета длины результирующего массива
    while (position < count)
    {
        int len = col[position].Length;
        if (len <= 3)
        {
            resultArrayLength++;
        }
        position++;
    }

    position = 0;
    string[] resultArray = new string[resultArrayLength];
    int resArrayPosition = 0;
    
    // Цикл для переноса значений в результирующий массив
    while (position < count)
    {
        int len = col[position].Length;
        if (len <= 3)
        {
            resultArray[resArrayPosition] = col[position];
            resArrayPosition++;
        }
        position++;
    }
    return resultArray;
}
