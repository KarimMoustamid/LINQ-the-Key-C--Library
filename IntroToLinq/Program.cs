Console.WriteLine("Hello, World!");

var wordsNoUpperCase = new List<string> {"hello", "world", "this", "is", "a", "list", "of", "words"};
Console.WriteLine(IsAnyWordUpperCase(wordsNoUpperCase));

var wordsWithUpperCase = new List<string>
    {"hello", "world", "this", "is", "a", "list", "of", "words", "with", "UPPERCASE"};
Console.WriteLine(IsAnyWordUpperCase(wordsWithUpperCase));

static bool IsAnyWordUpperCase(IEnumerable<string> words)
{
    foreach (var word in words)
    {
        var areAllUpper = true;
        foreach (var letter in word)
        {
            if (char.IsLower(letter))
            {
                areAllUpper = false;
            }
        }

        if (areAllUpper)
        {
            return true;
        }
    }

    return false;
}

static bool IsAnyWordUpperCase_Linq(IEnumerable<string> words)
{
    return words.Any(word => word.All(letter => char.IsUpper(letter)));
}