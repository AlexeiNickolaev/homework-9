// Показать натуральные числа от M до N, N и M заданы
string NaturalsNumbers(int M, int N)
{
    if (M <= N) return NaturalsNumbers(M, N - 1) + $"{N} ";
    else return " ";
}
// Найти сумму элементов от M до N, N и M заданы
int SumElements(int M, int N)
{
    if (M == N) return N;
    else return N + SumElements(M, N - 1);
}
// Написать программу возведения числа А в целую стень B
int DegreeNumber(int A, int B)
{
    if (B == 0) return 1;
    else return (A * (DegreeNumber(A, B - 1)));
}
// Написать программу вычисления функции Аккермана
int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberN == 0 && numberM != 0) return AckermannFunction(numberM - 1, 1);
    else return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
}
// Написать программу показывающие первые N чисел, для которых каждое следующее равно 
// сумме двух предыдущих Первые два элемента последовательности задаются пользователем.
string Numbers(int numA, int numB, int numN)
{
    if (numN >= 0) return $"{numA} " + Numbers(numB, numA + numB, numN - 1);
    return string.Empty;
}
Console.WriteLine("Показать натуральные числа от M до N");
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
NaturalsNumbers(M, N);
Console.WriteLine(NaturalsNumbers(M, N));

int sum = SumElements(M, N);
Console.WriteLine($"Сумма элементов от {M} до {N} равна {sum}");
Console.ReadKey();
Console.Clear();

Console.WriteLine("Написать программу возведения числа А в целую стень B");
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine() ?? "0");
int pwr = DegreeNumber(A, B);
Console.WriteLine($"Число {A} в степени {B} равно {pwr}");
Console.ReadKey();
Console.Clear();


Console.WriteLine("Написать программу вычисления функции Аккермана");
Console.Write("Введите неотрицательное число M: ");
int numberM = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите неотрицательное число N: ");
int numberN = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(AckermannFunction(numberM, numberN));
Console.ReadKey();
Console.Clear();

Console.WriteLine("Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих");
Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int numN = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(Numbers(numA, numB, numN));