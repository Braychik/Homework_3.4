/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int GetSum(int num1, int num2){
    int sum = 1;
    for(int i = 1; i <= num2; i++){
    sum = sum * num1;
    }
    return sum;
}
Console.Clear();
Console.Write("Введите число А: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {num1} в степени {num2} равна {GetSum(num1, num2)}");