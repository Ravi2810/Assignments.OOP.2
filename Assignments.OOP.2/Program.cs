using System;
using System.Collections.Generic;

namespace A1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//CardPicker mydeck = new CardPicker();
			//foreach (Card c in mydeck.Cards)
			//{
			//	Console.WriteLine(c);
			//}
			//Console.WriteLine("How Many Times Do You Want To Shuffle?");
			Console.WriteLine("Enter the number of cards to pick: ");
			string line = Console.ReadLine();
			if (int.TryParse(line, out int numCards))
			{
				foreach (var card in CardPicker.PickSomeCards(numCards))
				{
					Console.WriteLine(card);
				}
			}
			else
			{
				Console.WriteLine("Please enter a valid number.");
			}



		}

	}

	public static class SubsequenceFinder
	{
		/// <summary>
		/// Determines whether a list of integers is a subsequence of another list of integers
		/// </summary>
		/// <param name="seq">The main sequence of integers.</param>
		/// <param name="subseq">The potential subsequence.</param>
		/// <returns>True if subseq is a subsequence of seq and false otherise.</returns>
		public static bool IsValidSubsequeuce(List<int> seq, List<int> subseq)
		{
			if (seq.Count == 0)
			{
				return true;
			}
			int i = 0;
			int j = 0;
			while (i < seq.Count && j < subseq.Count)
			{
				if (seq.Contains(i) == subseq.Contains(j))
				{
					i++;
				}
				if (seq.Count == i)
				{
					return true;
				}
				j++;
			}
			return false;
		}
	}

	public class CardPicker
	{
		static Random random = new Random(1);
		/// <summary>
		/// Picks a random (with replacement) number of cards.
		/// </summary>
		/// <param name="numCards">The number of cards to choose at random.</param>
		/// <returns>An array of strings where each string represents a card.</returns>

		internal static IEnumerable<object> PickSomeCards(int numCards)
		{
			// Use RandomValue() & RandomSuit() to help you here
			Card[] cards = new Card[52];
			string[] numbers = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K" };

			int i = 0;
			foreach (string s in numbers)
			{
				cards[i] = new Card(Suits.Clubs, s);
				i++;

			}
			foreach (string s in numbers)
			{
				cards[i] = new Card(Suits.Spades, s);
				i++;

			}
			foreach (string s in numbers)
			{
				cards[i] = new Card(Suits.Hearts, s);
				i++;

			}
			foreach (string s in numbers)
			{
				cards[i] = new Card(Suits.Diamonds, s);
				i++;

			}

			return cards;
		}

	}
}


//      public Card[] Cards
//{
//	get
//	{
//		return cards;


//	}
//}




/// <summary>
/// Chooses a random value for a card (Ace, 2, 3, ... , Queen, King)
/// </summary>
/// <returns>A string that represents the value of a card</returns>

public enum Suits
{
	Hearts,
	Diamonds,
	Spades,
	Clubs
}


/// <summary>
/// Chooses a random suit for a card (Clubs, Diamonds, Hearts, Spades)
/// </summary>
/// <returns>A string that represents the suit of a card.</returns>

public class Card
{
	protected Suits suit;
	protected string cardvalue;
	public Card()
	{
	}
	public Card(Suits suit2, string cardvalue2)
	{
		suit = suit2;
		cardvalue = cardvalue2;
	}
	public override string ToString()
	{
		return string.Format("{0} of {1}", cardvalue, suit);
	}
}

