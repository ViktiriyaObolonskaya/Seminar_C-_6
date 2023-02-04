// Задача 41:Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.


// Console.WriteLine("Введите числа через запятую: ");
// int[] N = GetArrayString(Console.ReadLine()!);
// Console.WriteLine($"Колличество чисел больше 0 -> {GetCountPositive(N)}");

// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему)

int[] array = GetArrey(10, 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
SelectionSort(array);
Console.WriteLine($"[{String.Join(",", array)}]");





//----------------Методы------------------

int[] GetArrayString(string stringArray)
{
    string[] numS = stringArray.Split(",", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

int GetCountPositive(int[] array)
{
    int count = 0;
    foreach (var el in array)
    {
        if(el > 0) count++;
    }
    return count;
}


int[] GetArrey(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min])
            {
                min = j;
            }
        }
        int temporary = array[i];
        array[i] = array[min];
        array[min] = temporary;
    }
}

// как записали на семинаре

// void SortArray(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[i] < array[j])
//             {
//                int temp = array[i];
//             array[i] = array[j];
//             array[j] = temp;  
//             }
       
//         }
//     }
// }