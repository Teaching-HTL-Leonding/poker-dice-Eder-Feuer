Console.Clear();
int dice1 = 0;
int dice2 = 0;
int dice3 = 0;
int dice4 = 0;
int dice5 = 0;
bool fixed1 = false;
bool fixed2 = false;
bool fixed3 = false;
bool fixed4 = false;
bool fixed5 = false;
bool fixdiceloop = true;

void RollDice()
{
    if (fixed1 == false)
    {
        dice1 = Random.Shared.Next(1, 7);
    }
    if (fixed2 == false)
    {
        dice2 = Random.Shared.Next(1, 7);
    }
    if (fixed3 == false)
    {
        dice3 = Random.Shared.Next(1, 7);
    }
    if (fixed4 == false)
    {
        dice4 = Random.Shared.Next(1, 7);
    }
    if (fixed5 == false)
    {
        dice5 = Random.Shared.Next(1, 7);
    }
}

void PrintDice()
{
    Console.WriteLine($"{dice1} {dice2} {dice3} {dice4} {dice5}");
}

void FixDice()
{
    while (fixdiceloop)
    {
        Console.WriteLine("Which dice do you want to fix/unfix? (1-5, or '6' to roll the dice)");
        int dice = int.Parse(Console.ReadLine()!);
        if (dice == 6)
        {
            fixdiceloop = false;
        }
        switch (dice)
        {
            case 1:
                if (fixed1) { fixed1 = false; Console.WriteLine("Dice 1 has been unfixed"); } else { fixed1 = true; Console.WriteLine("Dice 1 has been fixed"); }
                break;
            case 2:
                if (fixed2) { fixed2 = false; Console.WriteLine("Dice 2 has been unfixed"); } else { fixed2 = true; Console.WriteLine("Dice 2 has been fixed"); }
                break;
            case 3:
                if (fixed3) { fixed3 = false; Console.WriteLine("Dice 3 has been unfixed"); } else { fixed3 = true; Console.WriteLine("Dice 3 has been fixed"); }
                break;
            case 4:
                if (fixed4) { fixed4 = false; Console.WriteLine("Dice 4 has been unfixed"); } else { fixed4 = true; Console.WriteLine("Dice 4 has been fixed"); }
                break;
            case 5:
                if (fixed5) { fixed5 = false; Console.WriteLine("Dice 5 has been unfixed"); } else { fixed5 = true; Console.WriteLine("Dice 5 has been fixed"); }
                break;

        }
    }
}
void sorting()
{
    if (){}
}

RollDice();
PrintDice();
FixDice();
fixdiceloop = true;
RollDice();
PrintDice();
FixDice();
RollDice();
PrintDice();