/*Написать программу, которая из имеющего массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма, при решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.*/

string[] initialArray = new string[5] {"Inga", "GB", "summer", "^_^", "686",};
string[] secondArray = new string[initialArray.Length];
void SecondArray(string[] initialArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < initialArray.Length; i++)
    {
    if(initialArray[i].Length <= 3)
        {
        secondArray[count] = initialArray[i];
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
SecondArray(initialArray, secondArray);
PrintArray(secondArray);