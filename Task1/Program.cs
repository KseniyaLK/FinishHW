//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 симовлам.

// 1.ввод кол-ва элементов массива с клавиатуры
// 2.заполнение массива вводом с клавиатуры
// 3. главный метод
// 4. печать

// 1.ввод кол-ва элементов массива с клавиатуры
Console.Write("Ввод количество элементов массива:\t");
int elemCount = int.Parse(Console.ReadLine());
string[] input1Array = new string[elemCount];

// 2.заполнение массива вводом с клавиатуры
void Fill(string[] inputArray, int count)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write($"\nВведите элемент массива под индексом {i}:\t");
        inputArray[i] = Console.ReadLine();
    }

    Console.WriteLine("\nВывод начального массива: ");
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write(inputArray[i] + " ");
    }

    Console.ReadLine();
}


// 3. главный метод
string[] MainExample(string[] input2Array)
{
    int len = 0;
    int count = input2Array.Length;
    for (int k = 0; k < count; k++)
    {
        if (input2Array[k].Length <= 3) len++;
    }
    string[] outputArray = new string[len];

    int i = 0;
    int index = 0;
    while (i < count)
    {
        if (input2Array[i].Length <= 3)
        {
            outputArray[index++] = input2Array[i];
        }
        i++;
    }

    return outputArray;
}

//4.метод печати
void PrintArray(string[] array)
{
    if (array.Length == 0) Console.WriteLine("Массив не имеет значений");
    Console.WriteLine("\nВывод конечного массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Fill(input1Array, elemCount); //вызов метода заполнения массива 
string[] outputArray = MainExample(input1Array); //вызов главного метода
PrintArray(outputArray); // вызов метода печати
