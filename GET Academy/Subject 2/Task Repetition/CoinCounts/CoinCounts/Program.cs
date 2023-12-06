using CoinCounts;

var coinCounts = new Counter[]
{
    new Counter(1, 7),
    new Counter(5, 3),
    new Counter(10, 2),
    new Counter(10, 11),
};

int totalSum = 0;

for (var i = 0; i < coinCounts.Length; i++)
{
    totalSum += coinCounts[i].CalculateValue();
}

Console.WriteLine("Total sum: " + totalSum);