//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3  


Console.Write("Введите количества элементов массива: ");

int element = int.Parse(Console.ReadLine());


int[] MyArray = new int[element];


for (int i = 0; i < MyArray.Length; i++)
{
    Console.Write("Введите элемент массива: ");
    MyArray[i] = int.Parse(Console.ReadLine());
}

int count = 0;
GetNumberZero(element);
PrintCount();


int[] GetNumberZero(int numbers)
{
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] > 0)
        {
            count++;
        }

    }
    return (MyArray);
}



void PrintCount()
{
    Console.WriteLine("Чисел больше 0, равно: " + count);
}





