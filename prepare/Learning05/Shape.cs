

using System.Dynamic;
using System.Net.NetworkInformation;

public class Shape 
{
    private string _color;

    public Shape(String color)
 {
    _color = color;
 }
 public string Color
 {
    get => _color;
    set=> _color = value; 
    }

 public virtual double GetArea()
 {
    throw new NotImplementedException();
 }

}

