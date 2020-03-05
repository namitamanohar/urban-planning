using System;

namespace Planner {

  public class Building {

    private string _designer = "Namita Manohar";
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;
    public int Stories { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Depth { get; set; }

    public double Volume {
      get {
        return Width * Depth * (3 * Stories);
      }
    }
    // constructor 
    public Building (string address) {
      _address = address;
    }
    // public methods 
    public void Construct () {
      _dateConstructed = DateTime.Now;
    }
    public void Purchase (string owner) {
      _owner = owner;
    }

    public void Description () {
      Console.WriteLine (_address);
      Console.WriteLine ($"Designed by {_designer}");
      Console.WriteLine ($"Constructed by {_dateConstructed}");
      Console.WriteLine ($"Owner by {_owner}");
      Console.WriteLine ($"{Volume} cubic meters of space");

    }
  }
}