using System;
using System.Collections.Generic;

int []CoinsForChagnge = {1, 2, 5, 10, 50, 100, 200};
int ArrayLength = CoinsForChagnge.Length;

Console.WriteLine("Please enter the Sum of your purchaes");
int.TryParse(Console.ReadLine(), out int PurchaseTotal);
Console.WriteLine("Please enter the amount of money given to the cashier");
int.TryParse(Console.ReadLine(), out int MoneyRecieved);

int ToGiveOut = MoneyRecieved - PurchaseTotal;

List<int> OptimalCoins = new List<int>();

for (int i = ArrayLength - 1; i >= 0; i--)
{
    while(ToGiveOut >= CoinsForChagnge[i])
    {
        ToGiveOut -= CoinsForChagnge[i];
        OptimalCoins.Add(CoinsForChagnge[i]);
    }
}

string JoinedOptimalList = string.Join(", ", OptimalCoins);
Console.WriteLine($"Here's your change: {JoinedOptimalList}");