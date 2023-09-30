// Задача 25: Напишите цикл, который принимает
// на вход два числа (A и B) и возводит
// число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Print (string mg)
{
    Console.Write(mg);
    string readInput=Console.ReadLine();
    int result=int.Parse(readInput);
    return result;
}
int Power (int osnov, int step)
{
    int power=1;
    for (int i=0;i<step;i++)
    {
        power*=osnov;
    }
    return power;
}
bool Validstep (int step)
{
    if (step<0)
    {
        Console.WriteLine("Показатель не должен быть равен нулю");
        return false;
    }
    return true;
}
int osnov=Print("Введите основание:");
int step=Print("Введите показатель:");

if (Validstep(step))
{
    Console.WriteLine($"Число {osnov} в степени {step} равно {Power(osnov,step )}");
}