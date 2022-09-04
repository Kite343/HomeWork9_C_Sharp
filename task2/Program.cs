/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNumsMN (int m, int n)
{
    if(m == n) return n;
    else return m + SumNumsMN(++m, n);
}

int GetNumber()
{
    Console.WriteLine("Введите число");
    string text = Console.ReadLine();

    string[] sentence ={"введите именно число", 
                        "Число! это дожно быть число!!! \nпопробуй еще раз", 
                        "Это не закончится до тех пор, пока не будет введено число.", 
                        "ты не знаешь что такое число? 1, 2, 5, 10... \nПопробуй еще раз. Я верю -ты сможешь!", 
                        "Это не число! Не ошибись! Ни чего кроме числа! одного числа!"};

    if(!int.TryParse(text, out int number))
    {
        Console.WriteLine(sentence[new Random().Next(0, 5)]);
        return GetNumber();
    }

    return number;
}

Console.WriteLine("Поочередно введите первое и конечное значение, \nв промежутке между которым необходимо найти сумму всех чисел");
Console.WriteLine(SumNumsMN(GetNumber(), GetNumber()));