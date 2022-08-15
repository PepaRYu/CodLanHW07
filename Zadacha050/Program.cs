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


Console.WriteLine("Введите номер строки элемента: ");
int numbRow = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите номер столбца элемента: ");
int numbCol = Convert.ToInt32(Console.ReadLine());



void GetValue2DMatrix(int [, ] matrix , int rowNum , int colNum){
    if (matrix.GetLength(0)>=  rowNum && rowNum >= 0 && colNum >=0 && matrix.GetLength(1)>=colNum )
    {
        Console.Write($"Элемент {rowNum}{colNum} равен: " + matrix[rowNum, colNum ] + '\t');
    } else{
        Console.WriteLine($"{rowNum}{colNum} -> Такого элемента нет");
    }

}

int [, ] array2D = GetArray(rows, columns, 0, 15);
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
PringArray(array2D);
GetValue2DMatrix(array2D, numbRow, numbCol);
