class CharacterPermutations
{
	private static void Permute(string expression, int leftLetter, int rightLetter)
	{
		if (leftLetter == rightLetter)
			Console.WriteLine(expression);
		else
		{
			for (int i = leftLetter; i <= rightLetter; i++)
			{
				expression = Swap(expression, leftLetter, i);
				Permute(expression, leftLetter + 1, rightLetter);
			}
		}
	}

	public static string Swap(string expression, int i, int j)
	{
		char temp;
		char[] charArray = expression.ToCharArray();
		temp = charArray[i];
		charArray[i] = charArray[j];
		charArray[j] = temp;
		string swapped = new string(charArray);
		return swapped;
	}

	public static void Main()
	{
		string expression = "ABCh";
		int lastLetter = expression.Length;
		Permute(expression, 0, lastLetter - 1);
	}
}


