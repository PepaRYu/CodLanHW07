Console.WriteLine("Введите колиечство строк: ");
int rows = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

/// m -- количество строк, n -- количество столбцов
/// minRandom, maxRandom
int [,] GetArray(int m , int n, int minRandom, int maxRandom){

    int [,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //столбцы
        {   
            matrix[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }   
    }
    return matrix;
}

void PringArray(int [,] matrix){

        for (int i = 0; i < matrix.GetLength(0); i++) // строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //столбцы
        {   
           Console.Write(matrix[i, j] + "\t");// "\t" -- Tab между элементами
        }   
        Console.WriteLine();
    }
    
}

double [] GetMeanValue(int [,] matrix){
    double [] meanValStr = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double meanOfStr = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            meanOfStr += matrix[i, j];
        }
        meanValStr[i] = meanOfStr/(matrix.GetLength(1));
    }
    return meanValStr;
}

int [ , ] array = GetArray(rows, columns, 0, 15);
PringArray(array);
double [] meanVal = GetMeanValue(array);
Console.WriteLine( $"Выводим массив на экран $ {String.Join("; ", meanVal)}");