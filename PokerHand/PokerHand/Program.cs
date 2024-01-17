using System;
using System.Linq;

public class Program
{
	public static string PokerHandRanking(string[] hand)
	{
		var order = "AKQJ198765432";
		var cardCounts = hand
				.GroupBy(c => c.Substring(0, c.Length - 1))
				.Select(g => new { card = g.Key, count = g.Count() })
				.OrderByDescending(g => g.count)
				.ToArray();
		var cardSeq = hand
				.Select(c => order.IndexOf(c[0]))
				.OrderBy(i => i)
				.ToArray();
		var isFlush = hand.All(c => c.Last() == hand[0].Last());
		var isStraight = Enumerable.Range(0, 4).All(i => cardSeq[i] == cardSeq[i + 1] - 1);
		if (isFlush)
		{
			if (isStraight)
			{
				return cardSeq[0] == 0 ? "Royal Flush" : "Straight Flush";
			}
			return "Flush";
		}
		if (isStraight) return "Straight";
		if (cardCounts[0].count == 4) return "Four of a Kind";
		if (cardCounts[0].count == 3) return cardCounts[1].count == 2 ? "Full House" : "Three of a Kind";
		if (cardCounts[0].count == 2) return cardCounts[1].count == 2 ? "Two Pair" : "Pair";
		return "High Card";
	}
	public static void Main()
    {
		string[] hand = { "10s", "10c", "8d", "10d", "10h" };
		Console.WriteLine(PokerHandRanking(hand));

	}
}