using System;


namespace MyProj {
  internal class Program {
    static void Main(string[] args) {
      // & oop.cs
      // * An instance(object) of Person class:

      var person1 = new Person1("John", "Doe", new DateOnly(1900,1,1));
      var person2 = new Person1("John", "Doe", new DateOnly(1900, 1, 1));
      person1.PrintName();
      // person1._firstName; // ! This wont work

      // ------------------------------------------------------------------------------------------------------------
      var people = new List<Person1> {person1, person2};
      List<Person1> people2 = new List<Person1> {person1, person2};



      // $ generic-classes.cs:
      var phone = new Product<PhoneProduct> ("phoneName", new PhoneProduct("phoneBrand", true));
      var shoe = new Product<ShoeProduct> ("shoeName", new ShoeProduct(30, "blue"));

      phone.DisplayInfo();
      shoe.DisplayInfo();

      // & exec 1
      var car2 = new Car2("a", "b");
      car2.DisplayInfo();

      var car1 = new Car1("c", "d");
      Console.WriteLine(car1.GetMake());
      Console.WriteLine(car1.GetModel());

      // & exec 4 
      var titanic = new Ship(15, 10);
      bool isTitanicWorthIt = titanic.isWorthIt();
      Console.WriteLine(isTitanicWorthIt);
    }
  }
}

// public partial class Program{
//   public static void Main() {
//   }
// }