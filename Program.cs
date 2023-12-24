/*Here are the rules for the battle game that you need to implement in your code project:

    . You must use either the do-while statement or the while statement as an outer game loop.
    . The hero and the monster will start with 10 health points.
    . All attacks will be a value between 1 and 10.
    . The hero will attack first.
    . Print the amount of health the monster lost and their remaining health.
    . If the monster's health is greater than 0, it can attack the hero.
    . Print the amount of health the hero lost and their remaining health.
    . Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
    . Print the winner. */


Random randomNumber = new Random();
int heroHealth = 10;
int monsterHealth = 10;
string turn = "";

while( heroHealth > 0 && monsterHealth > 0 )
{
    int attack = randomNumber.Next(0,10);
    if( turn == "monster" )
    {
        heroHealth -= attack;
        if(heroHealth>0)
        {
            turn = "hero";
        }
        Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
    }else
    {
        monsterHealth -= attack;
        if(monsterHealth>0)
        {
            turn = "monster";
        }
        Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");
    }
};

Console.WriteLine($"{turn} wins!");
