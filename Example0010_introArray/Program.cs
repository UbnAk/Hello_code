// // Нахождение наибольшего числа из 9, с помощью функции/метода.
// int Max(int arg1, int arg2, int arg3)// функция нахождения
// // максиммального числа из 3
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2; // тело функции
//     if(arg3 > result) result = arg3;
//     return result;
// }

// int[] array = {11,42,13,24,85,46,37,78,99}; // Массив - список
// int result = Max
//             (Max(array[0], array[1], array[2]),
//              Max(array[3], array[4], array [5]), // черещ функцию макс 
//              Max(array[6], array[7], array[8])  
//  );
// Console.WriteLine(result); //выводим результат


int Max(int a, int b, int c)
{
    int result = a;
    if(b > a) result = b;
    if(c > a) result = c;
    return result;
}

int [] array = {1,23,53,78,90,984,321,4485,211};
int max = Max
            (Max(array[0], array[1], array[2]),
            Max(array[3], array[4], array[5]),
            Max(array[6], array[7], array[8]));
 Console.WriteLine(max);