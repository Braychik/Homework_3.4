/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

Console.Clear();
Console.Write("Введите любое число: ");
int N = int.Parse(Console.ReadLine());
int [] array = GetBinArray(N);
Console.Write($"[{String.Join(", ", array)}]");

int [] GetBinArray(int array){
    int[] result = new int[array];
    for (int i = 0; i < N; i++){
        result[i] = new Random().Next(N+1);
    }
    return result;
}
