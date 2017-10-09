using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private string _message;

  public void SetMakeModel(string newMakeModel)
  {
    _makeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }
  public void SetPrice(int newPrice)
  {
    if (newPrice >= 0) {
      _price = newPrice;
    }
    else {
      Console.WriteLine("no");
    }
  }
  public int GetPrice()
  {
    return _price;
  }
  public void SetMiles(int newMiles)
  {
    _miles = newMiles;
  }
  public int GetMiles()
  {
    return _miles;
  }
  public void SetMessage(string newMessage)
  {
    _message = newMessage;
  }
  public string GetMessage()
  {
    return _message;
  }

  public Car(string carMakeModel, int carPrice, int carMiles, string message)
  {
    SetMakeModel(carMakeModel);
    SetPrice(carPrice);
    SetMiles(carMiles);
    SetMessage(message);
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911", 114991, 7864, "\"It is silver!\"");
    Car ford = new Car("2011 Ford F450", 55995, 14241, "\"It is gross!\"");
    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "\"It is yellow!\"");
    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "\"It is red!\"");
    Car ferrari = new Car("Ferrari XT 9000", 5000000, 0, "\"It is expensive!\"");
    Car subaru = new Car("Subaru Outback", 10, 4000000, "\"It is the best!\"");

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);
    Console.WriteLine("Enter maximum mileage: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> Cars = new List<Car>{ porsche, ford, lexus, mercedes, ferrari, subaru };

    List<Car> CarsMatchingSearch = new List<Car>();


    foreach(Car automobile in Cars)
    {
      if (automobile.GetPrice() <= maxPrice && automobile.GetMiles() <= maxMiles)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    if (CarsMatchingSearch.Count == 0)
    {
      Console.WriteLine("Your stadards are too damn high!");
    }
    else {
      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMessage());
      }
    }
  }
}
