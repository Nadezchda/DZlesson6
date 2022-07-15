
// перевернуть массив записать конец в начало

//  int[] RandomArray (int size)
// {
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//    array[i] = new Random().Next(100,1000);
//    }
//    return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }

// void  SwapArray(int [] array)
// {
//     int buf = 0;
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         buf = array [i] ;
//         array[i] = array[array.Length-i-1]; 
//         array[array.Length-i-1] = buf;    
//     }
//      ShowArray(array);

// }
// Console.WriteLine("Введите размер массива: " );
//  int size =  Convert.ToInt32(Console.ReadLine());
//  int [] arr =  RandomArray (size);
// ShowArray(arr);
// Console.WriteLine();
// SwapArray(arr);

// решена!!!

// ПРАКТИЧЕСКОЕ ЗАДАНИЕ 6
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

//    Console.WriteLine("Введите длину массива: " );
//    int M = Convert.ToInt32(Console.ReadLine());
//    int[] array = new int[M];   

// void ShowArray(int[]M)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//     Console.Write($"Bведите {i+1} числo для массива :");
//      array[i] = Convert.ToInt32(Console.ReadLine());
//     }}
// int myArray(int[]array)
// {
//   int sum = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if(array[i] > 0 ) sum += 1; 
//   }
//   return sum;
// }

// ShowArray(array);
// Console.WriteLine($"Введено чисел больше 0: { myArray(array)} ");

//     решена!!! 

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients(){
 for (int i = 0; i < coeff.GetLength(0); i++)
  {
 Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
 for (int j = 0; j < coeff.GetLength(1); j++)
    {
 if(j==0) Console.Write($"Введите коэффициент k: ");
 else Console.Write($"Введите коэффициент b: ");
 coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)
{
 crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
 crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
 return crossPoint;
}

void OutputResponse(double[,] coeff)
{
 if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
 Console.Write($"\n Прямые совпадают");
  }
 else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
 Console.Write($"\n Прямые параллельны");
  }
 else 
  {
 Decision(coeff);
 Console.Write($"\n Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}
InputCoefficients();
OutputResponse(coeff);




// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8