



// string[] Array(string message)
// {
//     System.Console.Write(message);
//     string numb = Console.ReadLine();
//     int number = Convert.ToInt32(value);
//     number = int.Parse(numb);
//     return result;
// }
// int item = ReadInt("Введите несколько слов или чисел");
// int count = 0;
// while(item>0)
// {
//     digit/=10;
//     count = count + 1;
// }

// System.Console.WriteLine(count);

string[] array1 = new string[5] { "123", "23", "hello", "world", "res" };
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);