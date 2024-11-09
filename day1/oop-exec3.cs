using System;

public class Shape{

  public virtual double GetArea() {
    return 0;
  }
}

public class Rectangle(double width, double length) : Shape {
  private double _width { get; } = width ;
  private double _length { get; } = length;
  public override double GetArea() {
    return _width * _length;
  }
}

public class Circle(double radius) : Shape{
  private double _radius { get; } = radius;
  private const double Pi = 3.14;
  public override double GetArea() {
    return Pi * _radius * _radius;
  }
}