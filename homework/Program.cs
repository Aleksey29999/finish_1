// Напишите программу, которая из действующено массива строк формирует массив  из строк , длина которых меньше либо равна 3символа
//  которая покажет количество чётных чисел в массиве.


// string[] text_array = new string[5];
//  string[] text_array = { "hello", "2", "world", ")" };
string[] text_array = {"1234", "1567"," -2", "computer science"};
//  string[] text_array = {"Russia", "Denmark", "Kazan"};
Console.WriteLine(string.Join(",", text_array));
string[] array = new string[text_array.Length];

for (int i = 0; i < text_array.Length; i++)
{
    if (text_array[i].Length <= 3)
        array[i] = text_array[i];

}
Console.Write("массив = ");
Console.WriteLine(string.Join(",", array));







