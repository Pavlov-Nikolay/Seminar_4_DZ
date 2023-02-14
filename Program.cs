
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число - основание степени");

int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("Введите число - показатель степени");

int.TryParse(Console.ReadLine(), out int b);

Logarifm();

void Logarifm()
{
    int c = a;

    for (int i = 1; i < b; i++)
    {
    c = c * a;
    }

    Console.WriteLine($"Число A в натуральной степени B равно {c}");
}

///////////////////////////////////////////////////////////////////

// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");

int.TryParse(Console.ReadLine(), out int number);

int[] digitArray = DigitToArray(number); // Задание метода DigitToArray : int - возвращаемый тип данных, DigitToArray - название метода, (3) - лист параметров.

int[] DigitToArray(int length) // Тело метода с параметром length.
{
    length = 0;

    int oldNumber = number;

    while (number > 0)
    {
        number = number / 10;
        length++;
    }

    digitArray = new int [length]; // Создание массива digitArray длиной length элементов.

    for (int i = length - 1; i >= 0; i--) // Перевод числа number в массив digitArray.
    {
        digitArray[i] = oldNumber % 10;
        oldNumber = (oldNumber - digitArray[i]) / 10;
    }     

    int sum = 0;

    for (int i = length - 1; i >= 0; i--) // Подсчет суммы цифр в числе.
    {
        sum = sum + digitArray[i];
    }

    Console.WriteLine($"Сумма цифр в числе равна {sum}");

    return digitArray;
}


///////////////////////////////////////////////////////////////////

// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

ArrayOfDigits();

void ArrayOfDigits()
{
    Random random = new Random();
    int min = -10;
    int max = 10;
    int index = 0;
    int [] array = new int[8];
    while (index < 8)
    {
        array[index] = random.Next(min, max);
        index++;
    }

    index = 0;

    while (index < 8)
    {
        Console.Write($" " + array[index]);
        index++;
    }
}

///////////////////////////////////////////////////////////////////