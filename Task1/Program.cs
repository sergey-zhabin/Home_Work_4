void Zadacha25()
{
    Console.WriteLine("Введите число, которое надо возводить в степень ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число, которое будет являться степенью ");
    int numberB = Convert.ToInt32(Console.ReadLine());  
      Console.WriteLine($"{numberA} в степени {numberB} равно {Finddegree(numberA, numberB)}");
}
int Finddegree(int numberA, int numberB)
{
    int numberC = numberA;
    int i = 1;
    while(i < numberB)
    {
        
        numberA=numberC*numberA;
        i++;
        
    }
    return numberA;
}

Zadacha25();