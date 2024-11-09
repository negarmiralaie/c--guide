using System;

public class Animal(string name) {
  protected string _name { get; } = name;

  public virtual void MakeSound() {
    Console.WriteLine($"Sound of an animal called {_name}");
  }
}

public class Dog : Animal {
  public Dog(string name) : base (name) { }
  public override void MakeSound() {
    Console.WriteLine($"Sound of an animal who is a dog! {_name}");
  }
}

public class Cat : Animal {
  public Cat(string name) : base (name) { }
  public override void MakeSound() {
    Console.WriteLine($"Sound of an animal who is a cat! {_name}");
  }
}
