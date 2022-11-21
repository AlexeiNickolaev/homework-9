// Показать натуральные числа от M до N, N и M заданы
string NaturalsNumbers(int M, int N)
{
    if(M<=N)return NaturalsNumbers(M, N-1)+$"{N} ";
    else return" ";
}

Console.WriteLine("Показать натуральные числа от M до N");
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
NaturalsNumbers(M, N);
Console.WriteLine(NaturalsNumbers(M, N));
