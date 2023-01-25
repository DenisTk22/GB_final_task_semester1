/*
Задача для финального контроля.
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. 
*/
// Задаю массив таким образом для быстроты контроля:
string [] array = new string [] {"u8", "-5", "Ostov", ";)[", "y", "190"};

// Метод для подсчета количества элементов, размер которых меньше или равен трем символам в заданном массиве:
int countEl (string [] massive)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <=3)
                    {
                        sum = sum + 1;
                    }
            }
        return sum;
    }
int count = countEl (array);

// Метод для заполнения искомого массива:
string [] Newmas (string [] massive)
{
    string [] array1 = new string [count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (massive[i].Length <=3)
                {
                    array1[j] = massive[i];
                    j++;
                }
        }
    return array1;
}

string [] Nmass = Newmas(array);

Console.WriteLine($"Искомый массив: [{string.Join(", ", Nmass)}]");