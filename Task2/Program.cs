void Zadacha27()
{ 
    Console.WriteLine("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($" сумма цифр в числе {number}  = {FindSumm(number)}");
}

int FindSumm(int number)
{
    
    int sumnum= 0;
    while(number >0)
    {
        sumnum =sumnum + number%10;
        number=number/10;  
    }    
    return sumnum;
}    
Zadacha27();
