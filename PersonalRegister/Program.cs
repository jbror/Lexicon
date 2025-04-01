
var registry = new List<Employee>();


while (true)
{
    Console.WriteLine("Choose an option: ");
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. Print registry");
    Console.WriteLine("3. Exit");
    var choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("Enter employee name: ");
        var name = Console.ReadLine();

        Console.WriteLine("Enter employee salary: ");
        var salary = int.Parse(Console.ReadLine());

        var employee = new Employee { Name = name, Salary = salary };
        registry.Add(employee);
    }
    else if (choice == "2")
    {
        Console.WriteLine("Employee Registry:");
        foreach (var employee in registry)
        {
            Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
        }
    }
    else if (choice == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }
}