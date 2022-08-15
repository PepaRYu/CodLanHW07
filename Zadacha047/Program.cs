// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

double [,] Get2DArray(int m, int n){
    double [,] matrix = new double [m, n] ;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Random random = new Random();
            matrix[i, j] = random.NextDouble();
            // matrix[i, j] = new Random().NextDouble(minRandom, maxRandom);
        }        
    }
    return matrix;
}

void Print2DArray(double [, ] matrix){
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i,j] + '\t' + '\t');
        }        
        Console.WriteLine();
    }

}
double [,] TwoDarray = Get2DArray(rows, colums);
Print2DArray(TwoDarray);
