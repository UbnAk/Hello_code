// Имеется одномерный массив array из n элементов, требуется найти элемент 
// равный Find
// 1. Установить счетчик index в позицию 0.
// 2. Если array[index] = find, алгоритм завершил работу успешно.
// 3. Увеличить index на 1.
// 4. Если index < n, то перейти к шагу 2. в противном случае алгорртим завершит работу успешно.

int[] array = {23, 45, 90, 82, 76, 87, 34, 73, 82}; //задали массив

int n = array.Length; // n элементы, Length-длина массива array
int find = 82; // find просто решили взять число 82
int index = 0; // изначально index = 0;

while (index<n) // делаем цикл. Пока индекс меньше длины массива
{
    if(array[index]== find) // Если array[0] == 82, то выводим ниже, если нет то индекс +1
    {
        Console.WriteLine(index);
        break;   // если в массиве будет два однаковых числа, найдя первый он прерветься.
    }
    index++;
}

// int[] Massiv = {234,124,765,22,14,665,124,66423,123,13};
// int n = Massiv.Length;
// int index = 0;
// int find = 123;

// while(index < n)
// {
//     if(Massiv[index] == find)
//     {
//         System.Console.WriteLine(index);
//         break;
//     }
//     index++;
// }