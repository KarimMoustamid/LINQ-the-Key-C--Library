
var words = new List<string> { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

var shortWords = words.Where(w => w.Length <= 4).ToList();

Console.WriteLine("First iteration The short words are:");
foreach (var word in shortWords)
{
    Console.WriteLine(word);
}

words.Add("rice");

Console.WriteLine("Second iteration The short words are:");
foreach(var word in shortWords)
{
    Console.WriteLine(word);
}


// var people = new List<Person>
// {
//     new () {Name = "John", country = "USA"},
//     new () {Name = "Jane", country = "USA"},
//     new () {Name = "Joe", country = "UK"}
// };

// var allAmericans = people.Where(p => p.country == "USA");
// var notAllAmericans = allAmericans.Take(100);
//
// public class Person
// {
//     public string Name { get; set; }
//     public string country { get; set; }
// }
//

var animals = new List<string> { "dog", "cat", "bird", "fish", "dog", "cat", "dog" };

var animalsWithD = animals.Where(a =>
{
    Console.WriteLine("Checking animal: " + a);
    return a.StartsWith("d");
});

foreach (var animal in animalsWithD)
{
    Console.WriteLine(animal);
}



















