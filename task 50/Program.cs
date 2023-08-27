// create random matrix 
int mR = new Random().Next(1, 9);
int nR = new Random().Next(1, 9);
int[,] matrix = new int[mR, nR];

// accept the given parameters
Console.WriteLine("Введите заданные параметры позиции M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите заданные параметры позиции N: ");
int n = int.Parse(Console.ReadLine());

// method fill elements in matrix random nums
void GetMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(-99, 99);
            if(m == i && n == j){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(matrix[i, j] + " ");
            }
            else {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}
GetMatrix(matrix);
if((m <= mR && m >= 1) || n <= nR && n >= 1){
    Console.ForegroundColor = ConsoleColor.Green;    
    Console.WriteLine($"В заданной таблице имеется искомая позиция {matrix[m, n]}");
}
else{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"В заданной таблице НЕ имеется искомая позиция");
}