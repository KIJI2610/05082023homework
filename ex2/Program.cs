int[,] arr = new int[3, 4];
for (int i = 0; i < arr.GetLength(0); i++){
    for (int j = 0; j < arr.GetLength(1); j++){
        arr[i, j] = new Random().Next(10, 100);
         System.Console.Write("["+arr[i,j]+"]"+" ");
    }
   System.Console.WriteLine();
}
int[] sum = new int[3];
for (int i = 0; i < arr.GetLength(0); i++){
    int sumStr = 0;
    for (int j = 0; j < arr.GetLength(1); j++){
        sumStr += arr[i,j];     
    }
    sum[i] = sumStr;
   System.Console.WriteLine();
}
for(int i = 0; i < sum.Length; i++){
    System.Console.WriteLine("Сумма первой строчки: "+"["+sum[i]+"]"+" ");
}
System.Console.WriteLine();
System.Console.WriteLine("Самая большая сумма строки равна: "+sum.Max());

