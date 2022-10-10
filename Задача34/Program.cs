// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте длину массива");
int size = int.Parse(Console.ReadLine());

int[] array = FillArray(size, 100, 999);



int Num = 0;
foreach(int element in array){
    Num += element % 2 ==0 ? 1 : 0;
    Console.Write(element + " ");
   }
Console.WriteLine("");

 Console.WriteLine ("Количество четных чисел в массиве:" + Num);

int[] FillArray(int size, int min, int max){
    int[] filledArray = new int[size];
    for(int i = 0; i < filledArray.Length; i++){
       filledArray[i] = new Random().Next(min, max+1); 
    }
    return filledArray;
}