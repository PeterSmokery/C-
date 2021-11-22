int ura = 0;
int numberA = new Random().Next(1,100);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,100);
Console.WriteLine(numberB);
int result = numberA + numberB;
if (result > 100)
{ura = 1 ;}
else {ura = 0;}
Console.WriteLine(ura);