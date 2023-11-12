
using ChallengeApp;


Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Jan","Mazoch", 'M');
employee.AddGrade(56);
employee.AddGrade(35);
employee.AddGrade(42);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: { statistics.Average}");
Console.WriteLine($"Min:  { statistics.Min}");
Console.WriteLine($"Max:  { statistics.Max}");
Console.WriteLine($"AvarageLetter: {statistics.AverageLetter}");

//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
//    var input = Console.ReadLine();
//    if(input == "q")
//    {
//        break;
//    }

//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch(Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }
//}

//var statistics = employee.GetStatistics();
//Console.WriteLine($"Average: { statistics.Average}");
//Console.WriteLine($"Min:  { statistics.Min}");
//Console.WriteLine($"Max:  { statistics.Max}");
//Console.WriteLine($"AvarageLetter: {statistics.AverageLetter}");



