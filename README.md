## GB-Final_control_work_on_the_main_block


*Задача:*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*


*Условия выполнения задачи:*
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)



### *Решение задачи:*

- Описание решения

- Блок схема выполнения решения

- Методы и их описание

- Результаты выполнения программы.



### КОД

using System;
using static System.Console;


/*-----------метод1------созданние массива---------------*/
string[] GetArrayFromString(string elements)
{
    string[] rezult = elements.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return rezult;
}


/*-----------метод2------созданние нового массива---------------*/

string[] GetNewArray(string[] arr, int b)
{
     string [] rez = new string[b] ;
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

/*-----------метод3------определение длинны нового массива нового массива---------------*/

int CountElement(string[] arr)
{
    int count = 0;
    for(int i=0; i < arr.Length; i++)
        if (arr[i].Length <=3) count++;
    return count;
}


/*-----------Основная программа---------------*/

Clear();
Write("Введите числа через пробел: ");
string element = Console.ReadLine();
string[] array = GetArrayFromString(element);
int size = CountElement(array);
string[] array2 = GetNewArray(array);
WriteLine();
WriteLine($"[{String.Join(", ", array)}]");


Write($"[{String.Join(", ", array)}]  --->  ");
WriteLine($"[{String.Join(", ", array2)}]");
WriteLine();
