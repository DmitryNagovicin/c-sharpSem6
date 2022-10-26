// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  Разделить ввод данных, от расчета данных 
//  (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArray (int length)
{
    int[] massiv = new int[length];
    for (int i = 0; i < length; i++)
    {
        massiv[i] = Prompt("Введите число: ");
    }
    return massiv;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int FindPolozitelnie(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] massiv = CreateArray(5);
PrintArray(massiv);
System.Console.WriteLine($"Среди введенных чисел {FindPolozitelnie(massiv)} больше <0>");
