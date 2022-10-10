// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте длину массива");
int size = int.Parse(Console.ReadLine());

int[] array = FillArray(size, 0, 99);



int Sum = 0;
for(int i = 0; i < array.Length; i++){
      Sum += i % 2 == 0 ? 0 : array[i]; 
    Console.Write(array[i] + " ");
    }
Console.WriteLine("");

 Console.WriteLine ("Сумма элементов на нечетных позициях:" + Sum);

int[] FillArray(int size, int min, int max){
    int[] filledArray = new int[size];
    for(int i = 0; i < filledArray.Length; i++){
       filledArray[i] = new Random().Next(min, max); 
    }
    return filledArray;
}
