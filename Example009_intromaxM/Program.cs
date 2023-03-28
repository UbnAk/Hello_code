// Нахождение наибольшего числа из 9, с помощью функции/метода.
int Max(int arg1, int arg2, int arg3) // функция для поиска максимума из трех
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; // Возвращает результат
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 122;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

//int max1 = Max(a1, b1, c1); через функцию первую тройку выявляем максимальное число
//int max2 = Max(a2, b2, c2); 2 максимальное число
//int max3 = Max(a3, b3, c3);  3 максимальное число
//int max = Max(max1, max2, max3); и среди 3 выявленных макс чисел выявляем макс

int max = Max(Max(a1,b1,c1), // строчки выше заменили другой записью
              Max(a2,b2,c2), 
              Max(a3,b3,c3));


Console.WriteLine(max);
