var numbers = new List<int> {1 , 2, 3, 4, 5, 6, 7, 8, 9};

var numbersWith10 = numbers.Append(10);


// Console.WriteLine("Numbers: " + string.Join(", ", numbers)); 
// Console.WriteLine("Numbers: " + string.Join(", ", numbersWith10)); 


var oddNumbers = numbers.Where(n => n % 2 == 1).OrderBy(n => n);
// var orderOddNumbers = oddNumbers.OrderBy(n => n);
Console.WriteLine("IsOrderOddNumbers: " + string.Join(", ", oddNumbers)); 
