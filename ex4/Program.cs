int[,,] arr = new int[2,2,2];
for(int i = 0; i < arr.GetLength(0); i++){
    for(int j = 0; j < arr.GetLength(1); j++){
          for(int k = 0; k < arr.GetLength(1); k++){
              arr[i,j,k] = new Random().Next(10,100);  
              System.Console.Write("["+arr[i,j,k]+"]"+" ");
}
System.Console.WriteLine();
}
System.Console.WriteLine();
}