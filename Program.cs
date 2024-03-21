

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

int inputnumber(string text, int condition)
{
    bool isNumber = false;
    Console.WriteLine($"{text}");
    int finalNumber=0;
    while (isNumber == false)
        {
        string input = Console.ReadLine();
        isNumber = int.TryParse(input, out finalNumber);
        if (finalNumber <= 0 | finalNumber > condition) isNumber = false;
        if (isNumber==false)
        Console.WriteLine($"Неверный формат, введите допустимое значение");
        }
return finalNumber;
}

string[] getArray(int option)
{
    string[] sample = {"Hello", "2", "world", ":-)"};
    if (option == 2) return sample;
    else
    {
    int ammount = inputnumber("Введите количество элементов в массиве:",  int.MaxValue);
    string[] arr = new string[ammount];
    for (int i=0; i < ammount; i++)
    {
        Console.WriteLine($"Введите элемент массива №{i+1}:");
        arr[i] = Console.ReadLine();
    }
    return arr;
    }
}

string[] changedArray(string[] array)
{
    int newSize = 0;
    int symbols = 3;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= symbols) newSize +=1;
    string[] newArray = new string[newSize];
    for (int j = 0, k = 0; j < array.Length; j++)
        if (array[j].Length <= symbols)
        {
            newArray[k] = array[j]; 
            k +=1;
        } 
    return newArray;
}

void printarray(string[] arr, string text)
{
    Console.WriteLine($"{text}");
    Console.WriteLine($"\"{String.Join("\" \"", arr)}\"");
}

int upperLimit = 2;
int choice = inputnumber("Для ввода массива с клавиатуры нажмите 1, для использования готового массива нажмите 2", upperLimit);
string[] array = getArray(choice);
printarray(array, "Изначальный массив:");
string[] newArray = changedArray(array);
printarray(newArray, "Новый массив:");
