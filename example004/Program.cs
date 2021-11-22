int ura = 0;
int numberA = new Random().Next(1,100);
int numberB = new Random().Next(1,100);
int result = numberA + numberB;
if (result > 100)
{ura = 1 ;}
else {ura = 0;}
Console.WriteLine(ura);