// See https://aka.ms/new-console-template for more information

static int Score(int[] dice)
{
    var scores = new Dictionary<int, int>
    {
        {1, 1000}, 
        {6, 600}, 
        {5, 500}, 
        {4, 400}, 
        {3, 300}, 
        {2, 200}
    };
    var dices = new Dictionary<int, int>();
    var total = 0;
    foreach (var number in dice)
    {
        if(!dices.ContainsKey(number))
            dices.Add(number, dice.Count(x => x == number));
    }
    foreach (var (key, value) in dices)
    {
        if (value >= 3)
            total += scores[key] * (value / 3);
        if (key == 1)
            total += 100 * (value % 3);
        if (key == 5)
            total += 50 * (value % 3);
    }

    return total;
}

Console.WriteLine(Score(new int[]{2, 4, 4, 5, 4}));