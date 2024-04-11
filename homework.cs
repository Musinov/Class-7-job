// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void natural(int m, int n)
// {
// if (m > n) return;
// Console.Write($"{m} ");
// natural(m+1,n);

// }
// natural(m,n);




// //Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.Write("Введите неотрицательное число m: "); 
        int m = Convert.ToInt32(Console.ReadLine()); 
 
        Console.Write("Введите неотрицательное число n: "); 
        int n = Convert.ToInt32(Console.ReadLine()); 
  
        int res = Ack(n, m); 
        Console.WriteLine($"Значение = {res}"); 
     
    static int Ack(int n, int m) 
    { 
        if (n == 0) 
            return m + 1; 
        else if (m == 0) 
            return Ack(n - 1, 1); 
        else 
            return Ack(n - 1, Ack(n, m - 1)); 
    } 




    //Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


int[] arr = new[] { 1, 2, 3, 4, 5, 6, 7 };
var str = string.Join(" ", arr);
Console.WriteLine(str);
    
 Print(arr, arr.Length - 1);

 void Print(int[] arr, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(arr[index] + " "); 
            Print(arr, index - 1); 
        } 
    } 