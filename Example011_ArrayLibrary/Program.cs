void FillArray(int[] collection)//Метод. FillArray - наименование метода. collection - аргумент.
{
    int length = collection.Length; //Позволяет получить длину нашего массива.
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);//Обратиться к аргументу collection на позицию index и положить туда новое ЦЕЛОЕ случайное число из диапазона 1-10
        //index = index + 1
        index++;
    }
}

void PrintArray(int[] col) //МЕТОД, который будет печатать массив. col - аргумент.
{
    int count = col.Length; //Обозначает кол-во элементов.
    int positon = 0;
    while (positon < count)
    {
        Console.WriteLine(col[positon]); //Вывод на экран значение текущего элемента.
        positon++;
    }
}

int IndexOf(int[] collection, int find) //Описываем метод, отличный от void - он будет возвращать позицию (index).
//Наименование МЕТОДА IndexOf. В качестве аргумента будет приходить массив collection и какой-то элемент find.
{
    int count = collection.Length;
    int index = 0;
    int positon = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            positon = index;
            break;
        }
        index++;
    }
    return positon;
}

int[] array = new int[10]; //Создай новый массив, в котором будет 10 элеиентов (по умолчанию наполнен 0, 0, 0... нулями)

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);