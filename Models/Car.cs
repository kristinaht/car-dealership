using System;

namespace Dealership.Models
{

  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _message;

    public Car(string makeModel, int price, int miles, string message)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _message = message;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public string GetMessage()
    {
      return _message;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public bool WorthBuyingPrice(int maxPrice, int maxMiles)
    {
      return (_price <maxPrice && _miles<maxMiles);
    }
  }
}