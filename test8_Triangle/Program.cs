﻿// Ставим точки в середине отрезка
Console.Clear();
int xa = 45, ya = 1, 
    xb = 1, yb = 30, 
    xc = 90, yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xa, y = ya, count=0;
while(count<100)
{
    int newdot = Random().Next(0, 3);
    if (newdot == 0)
        {
            x=(x + xa) / 2;
            y=(y + ya) / 2;
        }   
    if (newdot == 1)
        {
            x=(x + xb) / 2;
            y=(y + yb) / 2;
        }  
    if (newdot == 2)
        {
            x=(x + xc) / 2;
            y=(y + yc) / 2;
        } 
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");                     
    count = count + 1;   
}
