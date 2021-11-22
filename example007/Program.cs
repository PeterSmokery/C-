//Console.Clear();
//Console.SetCursorPosition(15,3)
//Console.WriteLine("+");
Console.Clear();
int xa = 20, ya = 1;
int xb = 41, yb = 27;
int xc = 2, yc = 27;
Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");
int x = xa, y=xb;
int count=0;
while (count <10000)
{
    int p1 = new Random().Next(0,3);
if (p1 == 0)
{
     x = (x + xa) / 2;
     y = (y + ya) / 2;
}
if (p1 == 1)
{
     x = (x + xb) / 2;
     y = (y + yb) / 2;
}
if (p1 == 2)
{
     x = (x + xc) / 2;
     y = (y + yc) / 2;
}
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;
}