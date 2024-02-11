int[] Random_mas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 100);
    }
    return col;    
}

void Print_mas (int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}

void Recurs_mas (int[] col, int i)
{
    if(i == 0)
    {
        Console.Write($"{col[i]}\t");
        return;
    }
    Console.Write($"{col[i]}\t");
    Recurs_mas(col, i-1);
    }

Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
int i = n - 1;
int[] mas = new int[n];
Print_mas(Random_mas(mas));
Recurs_mas(mas, i);