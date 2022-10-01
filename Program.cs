// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2 //1, -7, 567, 89, 223-> 3
int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] ArrayImput(int number)
{
    int[] myArr = new int [number];
    int i = 0;
    while (i < number)
    {
        System.Console.Write("введите число ");
        myArr[i] = int.Parse(Console.ReadLine());
        i++;        
    }
    return myArr;
}
int PositivNumber(int[] myArr)
{
    int count = 0;
    for (int i = 0; i < myArr.Length; i++)
    {
        if (myArr[i] > 0)
        {
        count++;
        }
    }
    return count;
}
void ImputAndCountNumber(int number)
{
   if (number > 0)
   {
    int[] myArr = ArrayImput(number);
    ArrayPrint(myArr);
    System.Console.WriteLine($"колличество положительных чисел равно {PositivNumber(myArr)} ");
   }
       else
       {
        System.Console.WriteLine("колличество не может быть отрицательным, либо равным 0 ");
       }       
}
void ArrayPrint(int[] myArr)
{
    for (int j = 0; j < myArr.Length; j++)
    {
        System.Console.Write($"{myArr[j]} ");
    }
}
int number = Prompt("определите колличество цифр в воде ");
ImputAndCountNumber(number);

