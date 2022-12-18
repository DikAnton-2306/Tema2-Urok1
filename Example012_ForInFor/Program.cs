// ===== Вывод на экран таблицы умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// ===== Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить чёрточками, маленькие буквы "к" заменить большими "К",
// а большие "С" заменит маленькими "с".

// string text = "Жили у бабуси два весёлых гуся, "
//             + "один серый, другой белый, два вёсёлых гуся";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for(int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result+$"{newValue}";
//         else result = result + $"{text[i]}";
//     }    
//     return result;
// }
// string newText = Replace(text, ' ', ' ');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'и', 'ю');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'у', 'ю');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'е', 'ю');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'ё', 'ю');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'я', 'ю');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'ы', 'ю');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'о', 'ю');
// Console.WriteLine(newText);

// ===== Сортировка (упорядочивание) массива
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array) //Этот метод выводит массив на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) //Этот метод упорядочивает/сортирует массив
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);