int AckermannFunction (int m, int n)
{
if (m == 0) {
return n+1;
} else if(m > 0 && n ==0) {
return AckermannFunction(m-1, 1);
} else if(m > 0 && n > 0){
return AckermannFunction(m-1, AckermannFunction(m,n-1));
} else {
return AckermannFunction(m, n);
}
}
 
Console.WriteLine("Введите первое число: ");
int Fnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int Snumber = int.Parse(Console.ReadLine());
Console.WriteLine(AckermannFunction(Fnumber, Snumber));
