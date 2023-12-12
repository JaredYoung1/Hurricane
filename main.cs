using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter hurricane wind speed");
    var windspeed = double.Parse(Console.ReadLine());
    if (windspeed < 74)
      {
        Console.WriteLine("Not a Hurricane");
      }
    if (windspeed >= 74 && windspeed < 96)
    {
      Console.WriteLine("Category One Hurricane");
    }
    if (windspeed >= 96 && windspeed < 111)
    {
      Console.WriteLine("Category Two Hurricane");
    }
    if (windspeed >= 111 && windspeed < 130)
    {
      Console.WriteLine("Category Three Hurricane");
    }
    if (windspeed >= 130 && windspeed < 157)
    {
      Console.WriteLine("Category Four Hurricane");
    }
    if (windspeed >= 157)
    {
      Console.WriteLine("Category Five Hurricane");
    }
    
  }
}