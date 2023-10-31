
using ChallengeApp;

var employee = new Employee("Jan", "Mazoch");
employee.AddGrade(5);
employee.AddGrade(2);
employee.AddGrade(4);
employee.AddGrade(6);


var statistics1 = employee.GetStatisticsWithForEach();


Console.WriteLine("Dla do foreach");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");