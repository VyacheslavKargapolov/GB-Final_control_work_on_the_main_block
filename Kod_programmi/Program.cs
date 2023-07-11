using System;
using static System.Console;

string[] GetArrayFromString(string elements)

{
string[] rezult = elements.Split(" ", StringSplitOptions.RemoveEmptyEntries);
return rezult;
}


string[] GetNewArray(string[] arr, int b)
{ string [] rez = new string[b] ;
 int j = 0;
 for (int i = 0; i< arr.Length; i++)
 {
     if (arr[i].Length <=3)  
     {
        rez[j] = arr[i];
         
         j++;
     }
    
 }
 
 return rez;
}


int CountElement(string[] arr)
{
int count = 0;
for(int i=0; i < arr.Length; i++)
    if (arr[i].Length <=3) count++;
return count;
}

Clear();
Write("Введите строки через пробел: ");

string element = ReadLine();

string[] array = GetArrayFromString(element);

int size = CountElement(array);

string[] array2 = GetNewArray(array, size);

WriteLine();
Write($"[{String.Join(", ", array)}] ---> ");
WriteLine($"[{String.Join(", ", array2)}]");
WriteLine();