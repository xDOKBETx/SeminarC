/* Задача 57: Составить частотный словарь элементов двумерного массива.
 Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
 Например: { 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза 
1 встречается 1 раз 
2 встречается 1 раз 
8 встречается 1 раз 
9 встречается 3 раза
 */


int[,] GetArray(int row, int col, int beginNum, int endNum)  // Функция для создания двумерного массива
{
    int[,] arr = new int[row, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr) // Метод с вложенной функцией печати массива.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[] ChangeTypeArray(int[,] arr)  // Функция для преобразования двумерного массива в одномерный.
{
    int[] newArr = new int[arr.Length];
    int index = 0;  // Переменная с первоначальным значением 0.
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArr[index] = arr[i, j];  // Присваиваем значение элемента на позиции i,j значению переменной index. 
            index++;  // Увеличиваем значение переменной на +1
        }
    }
    return newArr; // Возврат массива в работу функции.
}

void BubbleSort(int[] arr)  // Метод с вложенной функцией сортировки массива пузырьковым методом
{
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i; j++)
        {
            if (arr[j] < arr[j + 1]) // Если элемент на позиции j < меньше элемента на позиции j + 1, то ...
            {
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]); // Производим рокировку(замену) j-элемента на элемент на позиции j + 1.
            }
        }
    }
}

void DictionaryOfArrayElements(int[] arr) // Метод с вложенной функцией подсчёта элементов массива
{
    int count = 1; // Переменная счётчик.
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1]) count++;  // Если текущии элемент равен следующему, то увеличиваем счётчик
        else  // Иначе ... 
        {
            Console.WriteLine($"Элемент {arr[i]} встречается {count} р."); // Вывод в консоль результата.
            count = 1; // "Обнуление" счётчика
        }

    }
    Console.WriteLine($"Элемент {arr[arr.Length - 1]} встречается {count} р.");  // Вывод в консоль результата для последнего элемента
}

Console.Write("Число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] myArray = GetArray(row, col, 1, 10); // Новый массив, которому присваиваем значения функции создания массива
PrintArray(myArray);  // Вызов функции печати массива.
int[] newArr = ChangeTypeArray(myArray); // Новый массив, которому присваиваем значения функции преобразования двумерного массива в одномерный. 
BubbleSort(newArr);  // Вызов функции сортировки пузырьком
Console.WriteLine(String.Join(", ", newArr)); // Вывод в консоль результата работы "пузырька"
DictionaryOfArrayElements(newArr);  // Вызов функции подсчёта элементов