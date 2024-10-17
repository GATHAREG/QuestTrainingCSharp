class Employee
{
    public string Name { get; set; }
    public static string CompanyName { get; set; }

    static Employee()
    {
        CompanyName = "Microsoft";
    }

    public Employee(string name) => Name = name;

    public override string ToString() => Name + " " + CompanyName;
}

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Company Name: " + Employee.CompanyName);
        var e1 = new Employee("Joe");
        Console.WriteLine(e1);
    }
}
