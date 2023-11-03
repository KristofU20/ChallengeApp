
using ChallengeApp;


Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Jan","Mazoch");

try
{
    Employee emp = null;
    var name = emp.Surname;
}
catch(Exception exception)
{
    Console.WriteLine(exception.Message);
}
finally
{
    Console.WriteLine("Finally here");
}


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: { statistics.Average}");
Console.WriteLine($"Min:  { statistics.Min}");
Console.WriteLine($"Max:  { statistics.Max}");
Console.WriteLine($"AvarageLetter: {statistics.AverageLetter}");



