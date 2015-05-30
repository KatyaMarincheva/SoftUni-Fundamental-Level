/* Problem 20 – Oh, My Girl!
A painter acquainted a girl programmer. When he invited her to a date, she agreed. But the girl 
wanted the boy to take her from home. She handed him a sheet of paper on which her address was written. When he looked, 
 * he saw a lot of random characters without meaning and without order. After the main text there was a short string - key. 
 * The address was parted in pieces of two to six symbols. All parts of text are surrounded by key in the beginning and key in the end.
Example
a-.885O,a745#"F5Sofa7#"FFF5a1#"D5ia, a000#"FFF5a88887#"F532 a123457#"F5a7   #"FGDGSDG5G.S.a#"5 ma-5.55gghja-.885y8hgja#"F5Rakoa#"F5a5#"F5vsa9#"F5ghhjkuu867885a7#"FYIYUHUI5ki a7#"FUIO5 a9997#"F5Stra#"5gia-5.558dft.8.8.a60-6.05hu-h-0yuua-.885rla-5.55yuti-..uioa-.885!a-5.55
The key:  a7#"F5
The actual address: Sofia, 32 Rakovski Str
The key is not something permanent. It is a string, which meets the following criteria:
•	The first, last and all other characters other than numbers and letters have a hard value as the given key
•	The symbols between them are of the same type as the type of symbol in the original key:
Where there is a digit: in its place can sit a sequence of DIGITS with indefinite length or no length.
Where there is a letter: in its place can sit a sequence of LETTERS with indefinite length or no length.
•	The letters are case-sensitive.
•	Remember to escape all special characters when you want to match them with literal meaning.
Input
The input will be read from the console. The key will be received on the first line. The text will be received on the next lines, ending with the keyword "END". 
Output
The resulting paragraph should be printed as output.
Constraints
•	The text will be a string with a length of [20 ... 1000]
•	The key will be a string with a length of [2 ... 10].
Examples
Input	Output
a7#"F5
a-.885O,a745#"F5Sofa7#"FFF5a
1#"D5ia, a000#"FFF5a88887#"F532 a123457#"F5a7   #"FGDGSDG
5G.S.a#"5 ma-5.55gghja-.885y8
hgja#"F5Rakoa#"F5a5#"F5vsa9#"F5ghhjkuu867885a7#"FYIYUHUI5ki  a7#"FUIO5 a9997#"F5Stra#"5gia-5.558dft.8.8.a60-6.05hu-h-0yuua-.885rla-5.55yuti-..uioa-.885!a-5.55
END	
 * 
 Output
 Sofia, 32 Rakovski Str
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class OhMyGirl
{
    static void Main()
    {
        char[] specialSymbols = {'*', '+', '?', '[', ']', '{', '}', ',', '.', '^', '$', '<', '>', '\\', '/'};
        // input key
        string key = Console.ReadLine();

        // input text
        var text = GetText();

        // extract key pattern
        var pattern = ExtractKeyPattern(key, specialSymbols);
        //Console.WriteLine(pattern);

        // extract address
        var address = ExtractAddress(pattern, text);

        // print
        Console.WriteLine(address);
    }

    private static StringBuilder ExtractAddress(string pattern, string text)
    {
        Regex addressPiece = new Regex(pattern);
        MatchCollection matches = addressPiece.Matches(text);

        StringBuilder address = new StringBuilder();

        foreach (Match match in matches)
        {
            address.Append(match.Groups[1].Value);
        }
        return address;
    }

    private static string ExtractKeyPattern(string key, char[] specialSymbols)
    {
        StringBuilder keyPattern = new StringBuilder();
        if (char.IsControl(key[0]) || specialSymbols.Contains(key[0]))
        {
            keyPattern.Append(String.Format("\\" + key[0]));
        }
        else
        {
            keyPattern.Append(key[0]);
        }

        for (int i = 1; i < key.Length - 1; i++)
        {
            char symbol = key[i];
            if (char.IsUpper(symbol))
            {
                keyPattern.Append("[A-Z]*");
            }
            else if (char.IsLower(symbol))
            {
                keyPattern.Append("[a-z]*");
            }
            else if (char.IsDigit(symbol))
            {
                keyPattern.Append("\\d*");
            }
            else if (!char.IsControl(symbol))
            {
                keyPattern.Append(String.Format("\\" + symbol));
            }
            else
            {
                keyPattern.Append(symbol);
            }
        }
        if (char.IsControl(key[key.Length - 1]) || specialSymbols.Contains(key[key.Length - 1]))
        {
            keyPattern.Append(String.Format("\\" + key[key.Length - 1]));
        }
        else
        {
            keyPattern.Append(key[key.Length - 1]);
        }

        string keyPatternStr = keyPattern.ToString();
        string pattern = String.Format(keyPatternStr + "(.{{2,6}})" + keyPatternStr);
        return pattern;
    }

    private static string GetText()
    {
        StringBuilder text = new StringBuilder();
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "END")
            {
                break;
            }

            text.Append(line);
        }
        return text.ToString();
    }
}

