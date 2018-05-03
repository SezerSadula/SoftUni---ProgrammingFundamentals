using System;

namespace _15.Substring
{
    class Program
    {
	    public static void Main()
	    {
		    string text = Console.ReadLine();
		    int trailingChars = int.Parse(Console.ReadLine());

		    const char specialCharacter = 'p';
		    bool hasMatch = false;

		    for (int i = 0; i < text.Length; i++)
		    {
			    if (text[i] == specialCharacter)
			    {
				    hasMatch = true;

				    int substringLength = trailingChars + 1;

				    if (substringLength + i >= text.Length)
				    {
					    substringLength = text.Length - i;
				    }

				    string substring = text.Substring(i, substringLength);

				    Console.WriteLine(substring);

				    i += trailingChars;
			    }
		    }

		    if (!hasMatch)
		    {
			    Console.WriteLine("no");
		    }
	    }
    }
}
