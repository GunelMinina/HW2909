// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте длину массива");
int size = int.Parse(Console.ReadLine());

double[] array = FillArray(size);
double maxNum = array[0];
double minNum = array[0];

foreach(double element in array){
    if(element > maxNum){
        maxNum = element;
    }

    if(element<minNum){
        minNum = element;
    }
    Console.Write(element + " ");
}
Console.WriteLine();

Console.WriteLine($"разница между максимальным и минимальным элементом = {maxNum-minNum}");


double[] FillArray(int size){
    double[] filledArray = new double[size];
    for(int i = 0; i < filledArray.Length; i++){
       filledArray[i] = new Random().NextDouble(); 
    }
    return filledArray;
}