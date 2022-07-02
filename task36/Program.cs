// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] A= new int [5];
for(int i=0; i<A.Length; i++){
A[i] = new Random().Next(-1000,1000);
}
for   (int i = 0; i < A.Length; i++)
     {
        Console.WriteLine(A[i]);
    }
int B = 0;
for(int i=0; i<A.Length; i++)
if(A[i]%2 != 0)
 {
   B=B+A[i];
}
Console.Write($"{B}");