string Prom(int num1, int num2)
{
    if (num1 == num2)
    {
        return num1.ToString();
    }
    return num1 + " " + Prom(num1+1, num2);
    
}



Console.WriteLine("Введите первое число : ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine(Prom(M, N));
