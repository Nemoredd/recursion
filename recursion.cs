//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
Console.WriteLine("Введите 2 числа:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

void OutputOfNaturalNumbers(int first, int last){
    if (last > first){
        OutputOfNaturalNumbers(first,last-1);
    }
    Console.Write(last);
}

if (m < n){
    OutputOfNaturalNumbers(m,n);
}
else{
    OutputOfNaturalNumbers(n,m);
}

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите 2 числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int Akkerman (int first, int last)
{
    if (first == 0)
    {
        return last+1;
    }
    else
    {
        if (last == 0)
        {
            return Akkerman (first - 1, 1);
        }
        else
        {
            return Akkerman (first - 1, Akkerman (first, last - 1));
        }
    }
}
Console.Write($"Функция Аккермана равно {Akkerman(a, b)}");

//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
int[] mass = {1,2,5,0,10,34};
int i=0;
void Output (int[] array, int j)
{
    if (j < array.Length)
    {
        Output(array, j+1);
        Console.Write(array[j] + " ");
    }
}
Output(mass, i);