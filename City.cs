using System.Collections.Generic;

namespace Planner {

  public class City {
    // property on city would be the collection of buildings 
    public string CityName { get; set; }
    public string CityMayor { get; set; }
    public int CityYear { get; set; }

    public List<Building> AllBuildings { get; set; } = new List<Building> ();

    // A collection of all of the buildings in the city.

    // A method to add a building to the city.
    public void AddBuilding (Building building) {
      AllBuildings.Add (building);
    }
  }
}