int SumOfMN (int M, int N)
{
if (M == N) {
return M;
} else if(M < N) {
return M + SumOfMN(M+1, N);
} else {
return N + SumOfMN(M, N+1);
}
}
Console.WriteLine("Введите первое число: ");
int Fnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int Snumber = int.Parse(Console.ReadLine());
Console.WriteLine(SumOfMN(Fnumber, Snumber));
