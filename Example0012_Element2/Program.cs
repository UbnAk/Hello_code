void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10]; // определили новый массив, и определили
// что по умолчанию в нем будет 10 элементов
// дословно new int[10], создай новый массив в котором будет 10 элементов
// по умолчанию он будет заполнен 0, и вот чтобы его заполнить случайными
// другими числами мы можем воспользоваться методом, который сами опишем.
// выше смотри методы два void
FillArray(array);// заполнил наш массив числами
 
PrintArray(array);// распечатал его
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
