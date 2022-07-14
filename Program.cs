// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigitFind(int num)
{
    int s = (num % 100) /10;
    return s;

}

int number = new Random().Next(100,1000);  //использовать рамдомное число
int digit = SecondDigitFind(number);

Console.WriteLine($"Вторая цифра числа {number} - {digit}");
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThreeDigit(int num)
{   
    while(num > 999)
         num = num / 10;
    return num;
           
}

int number = new Random().Next(1,1000000);  //использовать рамдомное число
int digit = ThreeDigit(number) % 10;

 if(number < 100)
    Console.WriteLine("Число не имеет сотый разряд");


Console.WriteLine($"Третья цифра числа {number} - {digit}"); 
*/


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Weekend(int num)
{
    if(num <= 5) return 1;
    return 2;
}

Console.Write("Введите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine()); 


int digit = Weekend(number);

if(digit == 1)
    Console.WriteLine($"{number} - Будний день");
if(digit == 2) 
    Console.WriteLine($"{number} - Выходной!");  