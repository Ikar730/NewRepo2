//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать цикл







//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
//void ShowNumbers(int m, int n)
//{
//    if (m >= n)
//    {
//        Console.WriteLine(m);
//        return;
//    }
//    Console.Write(m + " ");
//    ShowNumbers(m + 1, n);
//}
//ShowNumbers(2, 10);





//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//Console.WriteLine(Ack1(3, 2));


int Ack1(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if (m == 0) return Ack1(n - 1, 1);

        return Ack1(n - 1, Ack1(n, m - 1));
    }
}
//Ackermann

//функция ack(n, m)
//   если n = 0
//     вернуть m + 1
//   иначе, если m = 0
//     вернуть ack (n - 1, 1)
//   еще
//     вернуть ack(n - 1, ack (n, m - 1))


//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать цикл

int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };

Console.WriteLine("Origin");
foreach (var i in array)
    Console.Write($"{i}\t");

var reversed = Reverse(array);

Console.WriteLine("Reversed");
foreach (var i in reversed)
    Console.Write($"{i}\t");

int[] Reverse(int[] array, int i = 0)
{
    if (i < array.Length / 2)
    {
        int temp = array[i]; 
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
        Reverse(array, ++i);
    }
    return array;
}
