using System;
using System.Security.Cryptography.X509Certificates;

namespace OurCompany.LearnCoding.OOP.Inheritance3;

public class HospitalApp
{
    public static void Main(string[] args)
    {
        Person person1 = new Person
        {
            FirstName = "Thiago",
            LastName = "Santiago Rodrigues",
            Phone = "(61) 98426-4522",
            Email = "thiago.santiago@outlook.com",
        };
        //person1.PrintPerson();
       

        Patient patient1 = new Patient
        {
            FirstName = "Thiago",
            LastName = "Santiago Rodrigues",
            Phone = "(61) 98426-4522",
            Email = "thiago.santiago@outlook.com",
            PatientID = "24681236",
            Symptoms = "Alergic"
        };
        //patient1.PrintPatient();

        Employees employees1 = new Employees
        {
            FirstName = "Luiza",
            LastName = "Amaral Silva",
            Phone = "(61) 98426-4522",
            Email = "Luiza.Amaral@outlook.com",
            EmployeesID = "emp1",
            BankAccountInfo = "Bank x1 Acc 1234",
            StartDate = "20/01/2023",
        };
        //employees1.PrintEmployees();

        Nurse nurse1 = new Nurse
        {
            FirstName = "Luiza",
            LastName = "Amaral Silva",
            Phone = "(61) 98426-4522",
            Email = "Luiza.Amaral@outlook.com",
            EmployeesID = "emp109",
            BankAccountInfo = "Bank x1 Acc 1234",
            StartDate = "20/01/2023",
            NurseID = "N01",
            Shift = "Morning",
        };
        //nurse1.PrintNurse();

        Doctor doctor1 = new Doctor
        {
            FirstName = "Arthur",
            LastName = "Santos Braga",
            Phone = "(61) 98426-4522",
            Email = "Arthur.Santos@outlook.com",
            EmployeesID = "emp44",
            BankAccountInfo = "Bank x1 Acc 1234",
            StartDate = "04/08/2022",
            DoctorID = "D01",
            Specialization = "Cardiologist",
        };
        doctor1.PrintDoctor();
    }
}

public class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
    public string? Phone { get; set; }
    public string? Email { get; set; }

    public void PrintPerson()
    {
        Console.WriteLine($"/----------------Person----------------/");
        Console.WriteLine($"FullName: {FullName}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Email: {Email}");
    }
}

public class Patient : Person
{
    public string?  PatientID { get; set; }
    public string? Symptoms { get; set; }

    public void PrintPatient()
    {
        base.PrintPerson();
        Console.WriteLine($"/----------------Patient----------------/");
        Console.WriteLine($"PatientID: {PatientID}");
        Console.WriteLine($"Symptoms: {Symptoms}");
    }
}

public class Employees : Person
{
    public string? EmployeesID { get; set; }
    public string? BankAccountInfo { get; set; }
    public string? StartDate { get; set; }

    public void PrintEmployees()
    {
        base.PrintPerson();
        Console.WriteLine($"/----------------Employees----------------/");
        Console.WriteLine($"EmployeesId: {EmployeesID}");
        Console.WriteLine($"BankAccountInfo: {BankAccountInfo}");
        Console.WriteLine($"StartDat: {StartDate}");
    }
}

public class Nurse : Employees
{
    public string? NurseID { get; set; }
    public string? Shift { get; set; }

    public void PrintNurse()
    {
        base.PrintEmployees();
        Console.WriteLine($"/----------------Nurse----------------/");
        Console.WriteLine($"NurseId: {NurseID}");
        Console.WriteLine($"Shift: {Shift}");
    }
}

public class Doctor : Employees
{
    public string? DoctorID { get; set; }
    public string? Specialization { get; set; }

    public void PrintDoctor()
    {
        base.PrintEmployees();
        Console.WriteLine($"/----------------Doctor----------------/");
        Console.WriteLine($"DoctorID: {DoctorID}");
        Console.WriteLine($"Specialization: {Specialization}");
    }
}