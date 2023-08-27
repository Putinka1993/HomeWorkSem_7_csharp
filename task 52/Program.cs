int[,] matrix = new int[4, 4];


void GetMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(1, 99);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetArithmeticMean(int[,] matrix){              
    double count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            count += matrix[j, i];
        }
        Console.WriteLine(count / matrix.GetLength(1));
        count = 0;
    }
}

GetMatrix(matrix);
GetArithmeticMean(matrix);