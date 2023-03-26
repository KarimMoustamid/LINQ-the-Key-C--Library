var words = new [] {"a", "b", "c", "d", "e" , "eqeqeq" , "aaa"};
var wordsLingerThan2Letters = words.Where(word => word.Length > 2);

// The where method is an extension method on IEnumerable<T> . 

Console.WriteLine(string.Join(", ", wordsLingerThan2Letters));


// Test 

string multiLineString = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.
lorem ipsum dolor sit amet, consectetur adipiscing elit.
lorem ipsum dolor sit amet, consectetur adipiscing elit.
lorem ipsum dolor sit amet, consectetur adipiscing elit.
lorem ipsum dolor sit amet, consectetur adipiscing elit.
lorem ipsum dolor sit amet, consectetur adipiscing elit.
";


// Extension method
// static int GetCountOfLines(this string input)
// {
//     return input.Split("\n").Length;
// }

// var contOfLines = multiLineString.GetCountOfLines();