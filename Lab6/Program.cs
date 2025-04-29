using System;
using Microsoft.VisualBasic;


class Car
{
  public string model;
  public string color;
  public int year;

//Method to The car is staring
  public void start()
  {
     Console.WriteLine("The car is starting.");
  }
//Method Drive
public void drive(int miles)

{
Console.WriteLine("The car drove "+ miles+" miles");
}

//Method Get Desciption
public string GetDescription()
{
    return $"{year} {color} {model}";
    }

//Method Repaint

public void Repaint(string newColor)
{
  color=newColor;
  Console.WriteLine($"The car has been repainted to {color}.");
}

// Example method to display car details. You can use this as an example for the other methods.
  public void Display()
  {
    Console.WriteLine("Car Details:");
    Console.WriteLine("Model: " + model);
    Console.WriteLine("Color: " + color);
    Console.WriteLine("Year: " + year);
  }
}

class Program
{
  static void Main()
  {
// Creating a Car object and assigning values to its properties
    Car myCar = new Car();
    myCar.model = "Civic";
    myCar.color = "Black";
    myCar.year = 2020;

  // Calling the Display method
     myCar.Display(); 
     myCar.start();
     myCar.drive(50);
    
     string description=myCar.GetDescription();
    Console.WriteLine($"Car Description: {description}");  
     myCar.Repaint("red");


  }
}