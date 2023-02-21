// задача про двух друзей и собаку
int friend1speed = 1, friend2speed = 2, dogspeed = 5, count = 0, toWhom = 2;
double time = 0, dist = 10000, meet = 10;
while (dist < meet)
{
    if (toWhom = 1)
        {
        time = dist/(friend1speed + dogspeed);
        toWhom = 2;
        }
    else        
        {
        time = dist/(friend2speed + dogspeed);
        toWhom = 1;    
        }
        dist = dist - (friend1speed + friend2speed)*time;
        count++;
}    
Console.WriteLine(count);
