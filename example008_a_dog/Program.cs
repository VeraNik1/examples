double distance = 10000;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int friend = 2;
int count = 0;
double time = 0;

while(distance > 1)
{
    if(friend == 1)
    {
        time = distance / (first_friend_speed + dog_speed);
        friend = 2;
        count += 1;
    }
    else
    {   time = distance / (second_friend_speed + dog_speed);
        friend = 1;
        count += 1;
    }

    distance -= (first_friend_speed + second_friend_speed) * time;

}

Console.WriteLine(count);
