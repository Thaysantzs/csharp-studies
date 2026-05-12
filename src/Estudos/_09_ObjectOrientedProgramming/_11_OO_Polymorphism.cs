/*
# Polymorphism is a concept that allows objects of different classes
  to be treated as if they were objects of the same class.
# It is achieved through inheritance, where a subclass can inherit 
  properties and methods from its superclass and override them.
# Polymorphism allows you to write code that can work with objects
  of different classes in a uniform way, making your code more
  simple, flexible and reusable.

# Class Content
  # Recreate the example of Hospital Classes (Copy from _08_OO_Inheritance3.cs)
  # Use the method PrintBadge as vitual/override
  # Store objects in a Array of Person
  # Loop and call the method PrintBadge
  # Show how to check and cast to a specific object type using the operator: is
*/


using System;

namespace OurCompany.LearnCoding.OOP.Polymorphism;

public class PolymorphismApp
{
    public static void Main(string[] args)
    {
        Person[] personDB = new Person[10];

        personDB[0] = new Patient
        {
          FirstName = "Julio",
          LastName = "Alexandro",
          Phone = "(61) 99999-1234",
          Email = "julioalexandro@gmail.com", 
          PatientID = "2456-8",
          Symptoms = "Headache, fever" 
        };

        personDB[1] = new Nurse
        {
            FirstName = "Maria",
            LastName = "Conseição",
            Phone = "(61) 99999-8765",
            Email = "mariaconseiçao@gmail.com",
            EmployeesID = "F002",
            BankAccount = "Bank X, Account 001",
            StartDate = "01/05/2022",
            NurseID = "N002",
            Shift = "Afternoon",
        };

        personDB[2] = new Doctor
        {
            FirstName = "Luis",
            LastName = "Otávio",
            Phone = "(61) 99999-8765",
            Email = "luisotavio@gmail.com",
            EmployeesID = "F015",
            BankAccount = "Bank Y, Account 003",
            StartDate = "23/11/2020",
            DoctorID = "D073",
            Specialization = "Cardiac Surgeon"
        };

        personDB[3] = new Doctor
        {
            FirstName = "Zenilton",
            LastName = "Fonseca",
            Email = "zene@noemail.com",
            Phone = "999(555)2222",
            EmployeesID = "E003",
            BankAccount = "Bank X, Account 007",
            StartDate = "01/05/1995",
            DoctorID = "D0002",
            Specialization = "Images"
        };

        // Printing all badges
        for(int i = 0; i < 4; i++)
        {
            personDB[i].PrintBadge();
        }

        // Printing only Employee Badges
        for (int i = 0; i < 4; i++)
        {
            if(personDB[i] is Employees)
            {
                personDB[i].PrintBadge();
            }
        }

        // Printing Doctor Name and Specialization
        for (int i = 0; i < 4; i++)
        {
            if(personDB[i] is Doctor)
            {
                Doctor doctor = (Doctor)personDB[i];
                Console.WriteLine($"{doctor.FullName} - {doctor.Specialization}");
            }
        }
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

    public virtual void PrintBadge()
    {
        Console.WriteLine($"FullName: {FullName}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Email: {Email}");
    }
}

public class Patient : Person
{
    public string?  PatientID { get; set; }
    public string? Symptoms { get; set; }

    public override void PrintBadge()
    {
        Console.WriteLine($"/----------------Patient----------------/");
        base.PrintBadge();
        Console.WriteLine($"PatientID: {PatientID}");
        Console.WriteLine($"Symptoms: {Symptoms}");
    }
}

public class Employees : Person
{
    public string? EmployeesID { get; set; }
    public string? BankAccount { get; set; }
    public string? StartDate { get; set; }

    public override void PrintBadge()
    {
        base.PrintBadge();
        Console.WriteLine($"EmployeesId: {EmployeesID}");
        Console.WriteLine($"BankAccountInfo: {BankAccount}");
        Console.WriteLine($"StartDat: {StartDate}");
    }
}

public class Nurse : Employees
{
    public string? NurseID { get; set; }
    public string? Shift { get; set; }

    public override void PrintBadge()
    {
        Console.WriteLine($"/----------------Nurse----------------/");
        base.PrintBadge();
        Console.WriteLine($"NurseId: {NurseID}");
        Console.WriteLine($"Shift: {Shift}");
    }
}

public class Doctor : Employees
{
    public string? DoctorID { get; set; }
    public string? Specialization { get; set; }

    public override void PrintBadge()
    {
        Console.WriteLine($"/----------------Doctor----------------/");
        base.PrintBadge();
        Console.WriteLine($"DoctorID: {DoctorID}");
        Console.WriteLine($"Specialization: {Specialization}");
    }
}