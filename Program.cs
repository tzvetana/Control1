/*Написать программу, которая из имеющегося массива строк формирует формирует массив из строк, 
длина которых меньше либо равно 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. */

//задать массив строк
//выбрать из массива все строки, длина которых меньше либо равно 3 символа
//записать выбранные строки в новый массив
//вывести первоначальный массив
//вывести массив с выбранными строками


//задать массив строк
string[] arrayInput = new string[11] {"12", "-2", "computer", "Moscow", "Tumen"," ;-P", "password", "hi", "r2d", "98gy","star"};
/*второй массив другой длины для проверки
 далее так же для проверки добавлены строки с этим массивом. после проверки не стала их убирать*/
//string[] mainArray = new string[10] {"Hello!", "2", "world", ":-)", "234","1567", "-21", "Russia", "Denmark", "Kazan"};

//выбрать из массива все строки, длина которых меньше либо равно 3 символа
string[] GetValidArray(string[] array)
{
    int length = array.Length;

    int count = 0;

    for (int index = 0; index < length; index++)
    {
        if (array[index].Length <=3)
        {
            count++;
        }
    }
    string[] resultArray = new string[count];//создание нового массива

    int index2 = 0;
    for (int index = 0; index < length; index++)
    {
        if (array[index].Length <=3)
        {
            resultArray[index2] = array[index]; //записать выбранные строки в новый массив
            index2++;
        }
    }
    return resultArray;
}

//вывод массива
void PrintArray(string[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($" {array[index]}" + ",");
    }
    Console.WriteLine();
}


//вывести первоначальный массив
Console.WriteLine("Array to search for");
PrintArray(arrayInput);
//PrintArray(mainArray);

Console.WriteLine();

//вывести массив с выбранными строками
Console.WriteLine("Strings whose length is less than or equal to 3 characters");

PrintArray(GetValidArray(arrayInput));
//PrintArray(GetValidArray(mainArray));