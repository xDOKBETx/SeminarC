/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
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


int[] FindIndexOfMinArray(int[,] arr)  // Функция для поиска позиции минимального значения элемента в массиве
{
    int[] IndexOfMinArr = new int[2];
    int RowMin = 0; // Переменная, которая будет хранить номер строки минимального элемента.
    int ColMin = 0; // Переменная, которая будет хранить номер столбца минимального элемента.
    int minArr = arr[0, 0]; // Переменная для хранения массива, который получится из позиции минимального элемента в строке и столбце
    for (int i = 0; i < arr.GetLength(0); i++)  // Проход по строкам.
    {
        for (int j = 0; j < arr.GetLength(1); j++) // Проход по столбцам
        {
            if (arr[i, j] < minArr) // Если позиция элемента по [i,j] < меньше minArr, то ...
            {
                minArr = arr[i, j]; // записываем новое значение в minArr.
                RowMin = i;  // Присваиваем полученную позицию(i) строки переменной RowMin
                ColMin = j; // Присваиваем полученную позицию(j) столбца переменной ColMin
            }
        }
        IndexOfMinArr[0] = RowMin;  // Передаём значение RowMin в массив
        IndexOfMinArr[1] = ColMin;  // Передаём значение ColMin в массив  
    }
    return IndexOfMinArr;  // Возврат массива в работу функции.
}

int[,] CorrectArrayToMinimum(int[,] arr) // Функция для корректировки массива с учетом удаления строки и столбца на позиции минимального элемента
{
    int[,] CorrectArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1]; // Новый массив уменьшенный на одну строку и столбец
    int correctI = 0; // Переменная для корректировки строк
    int correctJ = 0; // Переменная для корректировки столбцов
    for (int i = 0; i < CorrectArr.GetLength(0); i++) // Проход по строкам
    {
        if (i >= FindIndexOfMinArray(arr)[0]) correctI = i + 1; // Если индекс элемента в строке больше или равен значению
        // из результата работы функции FindIndexOfMinArray, то сдвигаем позцию элемента на + 1  
        else correctI = i; // Иначе оставляем его на месте.
        for (int j = 0; j < CorrectArr.GetLength(1); j++) // Проход по столбцам
        {
            if (j >= FindIndexOfMinArray(arr)[1]) correctJ = j + 1; //  Если индекс элемента в столбце больше или равен значению
                                                                    // из результата работы функции FindIndexOfMinArray, то сдвигаем позцию элемента на + 1  
            else correctJ = j;  // Иначе оставляем его на месте
            CorrectArr[i, j] = arr[correctI, correctJ]; // Записываем откорректированные координаты элемента в массив
        }
    }
    return CorrectArr; // Возврат массива в работу функции
}

Console.Write("Число строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Начало диапазона значений: ");
int beginNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Окончание диапазона: ");
int endNum = Convert.ToInt32(Console.ReadLine());

int[,] myArray = GetArray(row, col, beginNum, endNum); //  Новый массив, которому присваиваем значения функции создания массива
PrintArray(myArray); // Вызов функции печати массива.
Console.WriteLine();
Console.WriteLine($"Наименьший элемент массива расположен на пересечении {String.Join(", ", FindIndexOfMinArray(myArray))}");
myArray = CorrectArrayToMinimum(myArray); // Присваиваем значения функции корректировки массива новому массиву  
Console.WriteLine();
PrintArray(myArray); // Вызов функции печати массива.