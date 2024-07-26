//Tendai Nyevedazanai
using System;
using System.Linq;
public class Horse
{//get and setter methods
    public string Name { get; set; }
    public int Age { get; set; }
    public int height { get; set; }
    public double[] Times { get; set; }

    public Horse()
    {
        Times= new double[3];
    }

    public Horse(string name, int age, int height, double[] times)
    {
        Name = name;
        Age = age;
        this.height = height;
        Times = times;
    }
    public double AverageTime()
    {

    return Times.Average(); 
    }
    public string HorseDetails()
    {
        return $"Name: {Name}\tAge: {Age}\tHeight: {height}\tAverage run: {AverageTime()}";
    }
}