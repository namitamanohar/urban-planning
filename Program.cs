using System;

namespace Planner {
    class Program {
        static void Main (string[] args) {

            Building FiveOneTwoEigth = new Building ("512 8th Avenue") {

                Width = 500,
                Height = 350,
                Stories = 25,
                Depth = 5

            };
            FiveOneTwoEigth.Construct ();
            FiveOneTwoEigth.Purchase ("Mo Silvera");

            // Console.WriteLine ($"Designed By {}")

            Building HelloFromKellow = new Building ("1108 Kellow Street") {

                Width = 900,
                Height = 600,
                Stories = 1,
                Depth = 90

            };
            HelloFromKellow.Construct ();
            HelloFromKellow.Purchase ("Chad Lautt");
            // instance and then call the method

            City Nashville = new City () {

                CityName = "Nashville",
                CityMayor = "Cooper",
                CityYear = 1976

            };

            Nashville.AddBuilding (HelloFromKellow);

            Nashville.AddBuilding (FiveOneTwoEigth);

            foreach (Building building in Nashville.AllBuildings) {
                building.Description ();

            }

        }
    }
}