/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
*/

int Akkerman (int m, int n)
{
    if(m == 0) return n + 1;
    else if((m > 0) && (n == 0)) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int GetNumberPositiv()
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
        return GetNumberPositiv();
    }

    else if(number < 0) 
    {
        Console.WriteLine("Число не должно быть отрицательным");
        return GetNumberPositiv();
    }

    return number;
}

Console.WriteLine("Введите поочередно неотрицательные значения m и n для функции Аккермана");
Console.WriteLine(Akkerman(GetNumberPositiv(), GetNumberPositiv()));