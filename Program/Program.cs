using System;

string[] GetArray()
{
    Console.WriteLine("Input number of length array");
    int a = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[a];
    Console.WriteLine("And now fill array: ");
    for (int i = 0; i < a; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] SortArray(string[] array)
{
    string[] sortArray = new string[array.Length];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <=3)
        {
            sortArray[j] = array[i];
            Console.Write(sortArray[j] + ",");
            j++;
        }
    }
    return sortArray;
}

string[] array1 = GetArray();
string[] array2 = SortArray(array1);