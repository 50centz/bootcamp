﻿void SortSelection(int[] collection)
{
    int size = collection.Length;

    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
           if(collection[j] < collection[pos]) pos = j; 
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
}

int[] array = {7, 10, 464, 840, 1, 5, 9};
Console.WriteLine($"[{String.Join(',' , array)}]");
SortSelection(array);
Console.WriteLine($"[{String.Join(',' , array)}]");

