using System; 

namespace UniversityX.ProjectA.DomainB;

public class RelationshiApp
{
    public static void Main(string[] args)
    {
        Building mainbuilding = new Building("Main BDL", "Street A, San Diego, California, 92346");
        Console.WriteLine(mainbuilding);

        Department ComputerScience = new Department("Computer Science", mainbuilding);
        Department Medicine = new Department("Medicine", mainbuilding);
        Department History = new Department("History", mainbuilding);
        Department Biology = new Department("Biology", mainbuilding);

        mainbuilding.PrintDepartment();
    }
}

public class Building
{
    public string? Name { get; set; }
    public string? Address { get; set; }

    List<Department> Departments;

    public Building(string name, string adress)
    {
        Name = name;
        Address = adress;
        Departments = new List<Department>();
    }

    public void addDepartament(Department department)
    {
        Departments.Add(department);
    }

    public override string ToString()
    {
        return $"Building: {Name}; {Address}";
    }

    public void PrintDepartment()
    {
        foreach(Department department in Departments)
        {
            Console.WriteLine(department);
        }
    }
}

public class Department
{
    public string? Name { get; set; }
    public Building Building { get; set; }

    public Department(string name, Building building)
    {
        Name = name;
        Building = building;
        building.addDepartament(this);
    }

    public override string ToString()
    {
        return $"Department: {Name}; {Building}";
    }
}