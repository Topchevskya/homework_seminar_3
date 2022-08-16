//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 	
int temp = number;
int invertNamber = 0;

    while (temp > 0)
    {
        int remainder = temp % 10;
        invertNamber = invertNamber * 10 + remainder;
        temp = temp / 10;
    }
    
    if (invertNamber == number) Console.WriteLine("Да");
    else Console.WriteLine("Нет");