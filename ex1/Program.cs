int[,] arr = new int[3, 3];
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++){
    for (int j = 0; j < arr.GetLength(1); j++){
        arr[i, j] = rnd.Next(100);
         System.Console.Write("["+arr[i,j]+"]"+" ");
    }
   System.Console.WriteLine();
}
System.Console.WriteLine();
for (int i = 0; i < arr.GetLength(0); i++){
    int[] row = new int[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        row[j] = arr[i, j];
    }
    Array.Sort(row, (a, b) => b.CompareTo(a));
    for (int j = 0; j < arr.GetLength(1); j++){
        arr[i, j] = row[j];
    }
}
for (int i = 0; i < arr.GetLength(0); i++){
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write("["+ arr[i, j] + "]"+" ");
    }
    Console.WriteLine();
}