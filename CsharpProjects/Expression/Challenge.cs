Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

Random coin1 = new Random();
Console.WriteLine((coin1.Next(0, 2) == 0) ? "heads" : "tails");