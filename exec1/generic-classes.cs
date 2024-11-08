using System;

// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~`
// & Generic classes: We pass T as a param --> later on while instantiating the class we pass a value for T such as int or string...

public interface IProductSubClass {
  string GetInfo();
}

public interface IProduct<T> where T : IProductSubClass {
  void DisplayInfo();
}

public class Product<T>(string name, T t) : IProduct<T> where T : IProductSubClass {
  private string _name { get; } = name;
  private T _t { get; } = t;

  public void DisplayInfo() {
    Console.WriteLine(_t.GetInfo());
  }
}

public class ShoeProduct(int size, string color) : IProductSubClass {
  private int _size { get; } = size;
  private string _color { get; } = color;

  public string GetInfo() {
    return $"Size of this shoe is equal to: {_size} and color is: {_color}";
  } 
}

public class PhoneProduct(string brand, bool isOriginal) : IProductSubClass {
  private string _brand { get; } = brand;
  private bool _isOriginal { get; } = isOriginal;

  public string GetInfo() {
    return $"Brand of this phone is: {_brand}";
  }
}
