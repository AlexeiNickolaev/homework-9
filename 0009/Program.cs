// Показать натуральные числа от M до N, N и M заданы
string NaturalsNumbers(int M, int N)
{
    if(M<=N)return NaturalsNumbers(M, N-1)+$"{N} ";
    else return" ";
}
// Найти сумму элементов от M до N, N и M заданы
int SumElements(int M, int N)
{
    if(M==N)return 0;
    else return N+SumElements(M, N-1);
}

Console.WriteLine("Показать натуральные числа от M до N");
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
NaturalsNumbers(M, N);
Console.WriteLine(NaturalsNumbers(M, N));

int sum = SumElements( M, N);
Console.WriteLine($"Сумма элементов от {M} до {N} равна {sum}");
Console.ReadKey();
Console.Clear();
