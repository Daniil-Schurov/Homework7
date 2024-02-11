string Nums(int M, int N)
{
    if(M == N) return Convert.ToString(M);
    return M + " " + Nums(M + 1, N);
}

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(Nums(M, N));