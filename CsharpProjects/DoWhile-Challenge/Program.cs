int heroHP = 10;
int monsterHP = 10;

Random attack = new Random();


do
{
    int heroAttack = attack.Next(1, 11);
    monsterHP -= heroAttack;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHP} health.");

    if (monsterHP <= 0) continue;

    int monsterAttack = attack.Next(1, 11);
    heroHP -= monsterAttack;
    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHP} health.");

} while (heroHP > 0 && monsterHP > 0);


Console.WriteLine(heroHP > monsterHP ? "Hero wins!" : "Monster wins!");




