//int number1 = Convert.ToInt32(Console.ReadLine());
//int number2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(number1+number2);

int secretNumber = new Random().Next(1,11);
int popytki = 3;
bool flagWin = false;
while(popytki >0)
{
    Console.WriteLine("введите число от 1 до 10");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    popytki --;
    if(userNumber > secretNumber)
    {
        Console.WriteLine("секретное число меньше");
    }
    else if(userNumber < secretNumber)
    {
        Console.WriteLine("секретное число больше");
    }
    else
    {
        Console.WriteLine("Вы выйграли!");
        flagWin = true;
        break;
    }
} 
if(!flagWin)
{
    Console.WriteLine("Вы проиграли. Число было" + secretNumber); 
}