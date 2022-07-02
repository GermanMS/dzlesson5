// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] A= new double[23];
double z = 0;
for(int i=0; i<A.Length; i++){
A[i] = new Random().Next(0,1000);
}
double min = A[0];
double max =A[0];
for   (int i = 0; i < A.Length; i++)
     {
        Console.Write(A[i]+ " ");
         if(A[i]< min)
        {
           min = A[i];
        }
        if(A[i]>max)
        {
          max= A[i];
        }
    }Console.WriteLine($"\n{min} минимальное значение, {max} максимальное значение");
z = max-min;
Console.WriteLine($"{z} разница между максимальным и минимальным элементов массива");
 
