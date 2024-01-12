// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Разница между максимальным и минимальным элементами массива

//     // Нахождение минимума массива
//     public static double FindMin(double[] numbers)
//     {
//         //Напишите свое решение здесь
//       double min = numbers[0];
//       for(int i = 1 ; i < numbers.Length ; i++)
//       {
//         if(numbers[i]< min)
//         {
//           min = numbers[i];
//         }
//       }
//       return min;
//     }

//     // Нахождение максимума массива
//     public static double FindMax(double[] numbers)
//     {
//         //Напишите свое решение здесь
//       double max = numbers[0];
//       for(int i = 0 ; i < numbers.Length ; i++)
//       {
//         if(numbers[i]>max)
//         {
//           max = numbers[i];
//         }
//       }
//       return max;

//     }



//     public static void PrintResult(double[] array)
//     {
//         //Напишите свое решение здесь
//       Console.WriteLine(FindMax(array) - FindMin(array));
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         double[] array;


//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(double.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         } else {
//            // Если аргументов на входе нет
//             array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }
//task4*

internal class Program
{
    private static void Main(string[] args)
    {
        // Дано натуральное число в диапазоне от 0-я до 100000 , создайте массив состоящий из цыфр щтого числа
        // старший разряд числа должен распологаться на индексе 0 , младший на последнем.
        // Размер массива должен быть равен количеству цифр. 425  -- 4 , 2, 5.
        int naturalNum = new Random().Next(0, 100001);
        int countOfNum = 0;
        int N = naturalNum;
        while (N > 0)
        {
            N = N / 10;
            countOfNum += 1;
        }
        System.Console.WriteLine(naturalNum);
        /// <summary>
        /// returns the array of numbers of the natural number is given.
        /// </summary>
        /// <param name="naturalNum"></param>
        /// <param name="countOfNum"></param>
        /// <returns></returns>
         static int [] numbersToArray (int naturalNum ,  int countOfNum )
         {
            int [] array = new int [countOfNum];
for(int i = array.Length -1 ; i>= 0  ; i-- )
{
    array[i] = naturalNum  % 10 ; 
    naturalNum = naturalNum/10;

}
return array;
         }
         for(int i=0 ; i<countOfNum ; i++)
         {
            System.Console.Write(numbersToArray(naturalNum , countOfNum)[i] + "\t");
         }


    }
}