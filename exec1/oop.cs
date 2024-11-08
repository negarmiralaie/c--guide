  using System;
  
  // ~ approach1 --> using object initializer:
  // * Note naming conventions for classes, methods, fields....
  // * Using private access modifier for fields and public for methods <= encapsulation
  // * Declaration of Person class:
  public class Person1(string firstName, string lastName, DateOnly birthDate){
    private readonly string _firstName = firstName;
    private readonly string _lastName = lastName;
    private readonly DateOnly _birthDate = birthDate;
    private string _fullName => $"{_firstName} {_lastName}";

    public void PrintName()
    {
      Console.WriteLine(_fullName);
    } 
  }

  // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
  // ~ approach2 --> using old-fashioned constructors:
  // * Note 2 getters and setters
  public class Person2{
    public Person2(string firstName, string lastName, DateOnly birthDate) {
      _firstName = firstName;
      _lastName = lastName;
      _birthDate = birthDate;
    }
    private string? _firstName { get; set; }
    private string? _lastName { get; set; }
    private DateOnly _birthDate {get; set; }
  }

  // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
  // ~ approach3 --> using primary constructors (feature added since C# 12) --> Much shorter in code lines:
  // * Params of constructor are moved to be params of class declaration
  // * Inside declaration of fields, we set those params to be as default values <-- if only you want to set a setter...
  public class Person3(string firstName, string lastName, DateOnly birthDate ) {

    // // * You are still able to create more constructors based on that primary constructor
    // public Person3() : this("James", "Bay")
    // {
    //   // Some code here.... 
    // }

    // * You can remove 2 below lines if you do not want to have access to these 2 fields from outside of the class and only keep the fullName
    private string _firstName { get; set; } = firstName;
    // * Below is an readonly field since it does not have the setter (readonly fields can only be assigned a value once they are created(or in constructor))
    private string _lastName { get; } = lastName;
    private DateOnly _birthDate { get; set; } = birthDate;
    private string _fullName => $"{firstName} {lastName}";
  }

  // ^ Polymorphism -> Person has a DisplayInfo method, Student inherits that method from Person but reimplements that in a different way --> use override keyword before writing type of response when overriding the method in the child class and virtual in superclass
  public class Person(string name) {
    protected string _name { get; } = name;

    public virtual void DisplayInfo () 
    {
      Console.WriteLine($"{_name} is a person!");
    }
  }

  public class Student : Person {
    public Student (string name) : base(name) { }
    public override void DisplayInfo() 
    {
      Console.WriteLine($"{_name} is a student!");
    }
  }

  // ------------------------------------------------------------------------------------------------------------