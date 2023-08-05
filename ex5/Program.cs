string[,] arr = new string[4,4];
arr[0,0] = "01";
arr[0,1] = "02";
arr[0,2] = "03";
arr[0,3] = "04";

arr[1,0] = "12";
arr[1,1] = "13";
arr[1,2] = "14";
arr[1,3] = "05";

arr[2,0] = "11";
arr[2,1] = "16";
arr[2,2] = "15";
arr[2,3] = "06";

arr[3,0] = "10";
arr[3,1] = "09";
arr[3,2] = "08";
arr[3,3] = "07";

for(int i = 0; i < arr.GetLength(0); i++){
    for(int j = 0; j < arr.GetLength(1); j++){
        System.Console.Write(arr[i,j]+" ");
}
System.Console.WriteLine();
}