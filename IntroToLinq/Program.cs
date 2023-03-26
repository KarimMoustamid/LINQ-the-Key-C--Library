



var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};

var isAnyLargerThan100 = IsAnyLargerThan100(numbers , number => number > 100);
var isAnyEven = IsAnyEven(numbers , number => number % 2 == 0);


Console.WriteLine($"Is any > 100 ? : {isAnyLargerThan100}");
Console.WriteLine($"Is any Even ? : {isAnyEven}");


static bool IsAnyLargerThan100(IEnumerable<int> numbers , Func<int , bool> predicate)
{
    foreach (var number in numbers)
    {
        return predicate(number);
    }

    return false;
}

static bool IsAnyEven<T>(IEnumerable<T> numbers , Func<T, bool> predicate)
{
    foreach (var number in numbers)
    {
        return predicate(number);
    }

    return false;
}

// static bool IsLargerThan100(int number)
// {
//     return number > 100;
// }

// static bool IsEven(int number)
// {
//     return number % 2 == 0;
// }


