// Задача 23

int n = new Random().Next(1, 10);
Console.WriteLine("Число N = " + n);
Console.WriteLine("Таблица кубов чисел от 1 до " + n + ":");
for(int i = 1; i < n + 1; i++)
    {
        double res = Math.Pow(i, 3);
        Console.Write(res + "  ");
    }
Console.WriteLine("");
