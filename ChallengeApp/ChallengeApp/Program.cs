using ChallengeApp;

Console.WriteLine("Welcome to XYZ Program to collect grades of your Employees and Supervisors and finally get statistics");
Console.WriteLine("======================================================");
Console.WriteLine();

var employee = new EmployeeInMemory("A1", "A2");
employee.GradeAdded += EmployeeGradeAdded;

var supervisor = new SupervisorInMemory("B1", "B2");
supervisor.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("New grade added");
}

while (true)
{
    Console.WriteLine("Type another grade of your Employee (A-E or 0-100)");
    Console.WriteLine("or press 'z' to go to grading your Supervisor and get statistics");
    var input = Console.ReadLine();
    if (input == "z")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

while (true)
{
    Console.WriteLine("Type another grade of your Supervisor (1-6 including +/-)");
    Console.WriteLine("or press 'q' to get statistics");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statisticsEmployee = employee.GetStatistics();
var statisticsSupervisor = supervisor.GetStatistics();

Console.WriteLine("======================================================");
Console.WriteLine("Employee Summary: ");
Console.WriteLine($"--> Average: {statisticsEmployee.Average}");
Console.WriteLine($"--> Average grade as letter: {statisticsEmployee.AverageLetter}");
Console.WriteLine($"--> Min: {statisticsEmployee.Min}");
Console.WriteLine($"--> Max: {statisticsEmployee.Max}");

Console.WriteLine();

Console.WriteLine("Supervisor Summary: ");
Console.WriteLine($"--> Average: {statisticsSupervisor.Average}");
Console.WriteLine($"--> Average grade as letter: {statisticsSupervisor.AverageLetter}");
Console.WriteLine($"--> Min: {statisticsSupervisor.Min}");
Console.WriteLine($"--> Max: {statisticsSupervisor.Max}");