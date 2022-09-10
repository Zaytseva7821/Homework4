// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// рандомный массив

int[] array = new int [8];
System.Console.WriteLine("Ваш массив:");
for(int i=0; i< array.Length; i++)
{
    array[i] = new Random().Next(-100,100);
    System.Console.Write(array[i]+" ");
}

// пользовательский

// int[] array = new int [8];
// for(int i=0; i< array.Length; i++)
// {
//     System.Console.WriteLine($"Введите {i+1} число");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// System.Console.WriteLine("Ваш массив:");
// for(int i=0; i< array.Length; i++)
// {
//     System.Console.Write(array[i]+" ");
// }
