// Задача 21

int[] a = {7, -5, 0};
int[] b = {1, -1, 9};
double c = 0;

for(int i = 0; i < 3; i++)
{
    c = c + Math.Pow((b[i] - a[i]), 2);
}
double d = Math.Sqrt(c);

Console.WriteLine(d);

// Можно сделать без цикла, но получается как-то громоздко и плохо читаемо...