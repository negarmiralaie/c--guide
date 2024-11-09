// Using System;

// ~ approach1
public class Car1{
  private string? _make { get; }
  private string? _model { get; }

  public string? GetMake() => _make;
  public string? GetModel() => _model; 

  public Car1(string make, string model) {
    _make = make;
    _model = model;
  }
}

// ~ approach2
public class Car2(string make, string model) {
  private string? _make { get; } = make;
  private string? _model { get; } = model;

  public void DisplayInfo() {
    Console.WriteLine($"Make: {_make} and Model: {_model}");
  }
}

