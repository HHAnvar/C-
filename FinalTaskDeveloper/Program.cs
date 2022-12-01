// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.

string[] array = {"hello", "word", "hi", "234", "3097"};
int resultLength = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultLength ++;
    }
}

string[] resoult = new string[resultLength];
int n = 0;

while (n < resultLength)
{
    for (int j = 0; j < array.Length ; j++)
    {
        if (array[j].Length <= 3)
        {
            resoult[n] = array[j];
            n++;
        }
    }
}

Console.WriteLine(string.Join(", ", resoult));