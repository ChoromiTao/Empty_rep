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
