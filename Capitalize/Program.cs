// See https://aka.ms/new-console-template for more information

string Capitalize(string s, List<int> idxs)
{
    return new string(s
        .Select((c, charIndex) => idxs.Any(idx => idx == charIndex) ? char.ToUpper(c) : c)
        .ToArray());
}


Console.WriteLine(Capitalize("abcdef", new List<int> {1, 2, 5}));