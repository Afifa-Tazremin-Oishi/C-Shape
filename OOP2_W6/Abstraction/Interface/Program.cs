﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    
interface Shape
{
  
  //public abstract int GetArea(); Invalid
 int GetArea();
int GetPerimeter();
}

class Rectangle: Shape
{
int length;
int breadth;

public Rectangle(int l, int b)
{
  length = l;
  breadth = b;
}

public int GetArea()
{
  return length*breadth;
}

public int GetPerimeter()
{
  return 2*(length+breadth);
}
}

class Square: Shape
{
int side;

public Square(int s)
{
  side = s;
}

public int GetArea()
{
  return side*side;
}

public int GetPerimeter()
{
  return 4*side;
}
}

class Program
{
static void Main(string[] args)
{
  Rectangle r = new Rectangle(7, 4);
  Square s = new Square(4);

  Console.WriteLine("Rectangle :");
  Console.WriteLine("Area : {0} Perimeter : {1}",r.GetArea(),r.GetPerimeter());

  Console.WriteLine("Square :");
  Console.WriteLine("Area : {0} Perimeter : {1}", s.GetArea(), s.GetPerimeter());
}
}
////////////////// Another Exmaple ///////////////////////
    /*
    interface Vehicle { 
      
    // all are the abstract methods. 
    void changeGear(int a); 
    void speedUp(int a); 
    void applyBrakes(int a); 
} 
  
// class implements interface 
class Bicycle : Vehicle{ 
      
    int speed; 
    int gear; 
      
    // to change gear 
    public void changeGear(int newGear) 
    { 
          
        gear = newGear; 
    } 
      
    // to increase speed 
    public void speedUp(int increment) 
    { 
          
        speed = speed + increment; 
    } 
      
    // to decrease speed 
    public void applyBrakes(int decrement) 
    { 
          
        speed = speed - decrement; 
    } 
      
    public void printStates()  
    { 
        Console.WriteLine("speed: " + speed +  
                          " gear: " + gear); 
    } 
} 
      ////////////////// Another Exmaple ///////////////////////
// class implements interface 
class Bike : Vehicle { 
      
    int speed; 
    int gear; 
      
    // to change gear 
    public void changeGear(int newGear) 
    { 
          
        gear = newGear; 
    } 
      
    // to increase speed 
    public void speedUp(int increment) 
    { 
          
        speed = speed + increment; 
    } 
      
    // to decrease speed 
    public void applyBrakes(int decrement){ 
          
        speed = speed - decrement; 
    } 
      
    public void printStates()  
    { 
        Console.WriteLine("speed: " + speed +  
                          " gear: " + gear); 
    } 
      
} 
  
class Program
{ 
      
    // Main Method 
    public static void Main(String []args)  
    { 
      
        // creating an instance of Bicycle  
        // doing some operations  
        Bicycle bicycle = new Bicycle(); 
        bicycle.changeGear(2); 
        bicycle.speedUp(3); 
        bicycle.applyBrakes(1); 
          
        Console.WriteLine("Bicycle present state :"); 
        bicycle.printStates(); 
          
        // creating instance of bike. 
        Bike bike = new Bike(); 
        bike.changeGear(1); 
        bike.speedUp(4); 
        bike.applyBrakes(3); 
          
        Console.WriteLine("Bike present state :"); 
        bike.printStates(); 
    } 
} 
    */
}
