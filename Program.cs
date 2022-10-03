// Все массивы от 5-ти элементов
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] array = FillArray();
// foreach (int i in array){
//     Console.Write($"[{String.Join("", i)}]");
// }
// Console.Write($"-> {even(array)} чётных элементов");
// int [] FillArray(){
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// int even(int[] arr){
//     int count = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if(arr[i]%2 == 0) count++;
//     }
//     return count;
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = FillArray();
foreach (int i in array){
    Console.Write($"[{String.Join("", i)}]");
}
Console.Write($"-> {even(array)} Сумма нечтных");
int [] FillArray(){
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int even(int[] arr){
    int sum = 0;
    for(int i = 0; i < arr.Length; i++){
        if(i%2 != 0){
            sum += arr[i];
        }
    }
    return sum;
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
