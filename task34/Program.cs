// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] A= new int [5];
// int[] ar1=new int[array.Length];
for(int i=0; i<A.Length; i++){
A[i] = new Random().Next(10,1000);
}
for   (int i = 0; i < A.Length; i++)
     {
        Console.WriteLine(A[i]);
    }
int B = 0;
for(int i=0; i<A.Length; i++)
if(A[i]%2==0)
 {
   B=B+1;
}
Console.Write($"{B}");

