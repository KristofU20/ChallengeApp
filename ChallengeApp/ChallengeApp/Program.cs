﻿
using ChallengeApp;

var employee = new Employee("Jan", "Mazoch");
employee.AddGrade(2);
employee.AddGrade(4);
employee.AddGrade(6);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

