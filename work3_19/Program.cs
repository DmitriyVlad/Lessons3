// Задача 19

Console.Write("Ваше число:");
string num = Console.ReadLine();
int n = 5;
int itog = 1;
for (int i = 0; i < n / 2; i++)

    if(num[i] != num[n-i-1])
       itog = 0;
    
if(itog == 0)
Console.WriteLine("Число " + num + " - обычное");
else
Console.WriteLine("Число " + num + " - палиндром");