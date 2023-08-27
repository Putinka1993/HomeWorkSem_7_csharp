Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Введите размерность M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размерность N: ");
int n = int.Parse(Console.ReadLine());

double[,] matrix = new double[m, n];

void GetRandomMatrix(double[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().NextDouble() * (99.9+99.9) - 99.9;
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    } 
}

GetRandomMatrix(matrix);