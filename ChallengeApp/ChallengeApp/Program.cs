using ChallengeApp;

Employee employee1 = new Employee ("Marek", "Kaszub", 45);
Employee employee2 = new Employee ("Jan", "Waza", 32);
Employee employee3 = new Employee ("Adam", "Chwała", 19);


employee1.AddScore(9);
employee1.AddScore(8);
employee1.AddScore(9);
employee1.AddScore(6);
employee1.AddScore(6);

employee2.AddScore(4);
employee2.AddScore(3);
employee2.AddScore(2);
employee2.AddScore(1);
employee2.AddScore(2);

employee3.AddScore(7);
employee3.AddScore(9);
employee3.AddScore(5);
employee3.AddScore(6);
employee3.AddScore(7);

List<Employee> employess = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employess)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Najwięcej punktów zdobył" + " " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + "lat" + " " + employeeWithMaxResult.Age);
Console.WriteLine("Ma ich" + " " + maxResult);