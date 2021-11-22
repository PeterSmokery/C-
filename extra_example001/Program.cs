int count = 0 ;
double distance = 10000;
double firstFriendSpeed=1;
double secondFriendSpeed=2;
double DogSpeed = 10;
int friend=2;
double time=0;
while(distance >10)
{
    if(friend==1)
    {
    time=distance/(firstFriendSpeed+DogSpeed);
    friend=2;
    }
    else
    {
    time=distance/(secondFriendSpeed+DogSpeed);
    friend=1;
    }
distance=distance-(firstFriendSpeed+secondFriendSpeed)*time;
count=count+1;
}
Console.WriteLine(count);