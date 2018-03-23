using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaggageSortingSimulator.Model;

namespace BaggageSortingSimulator.System
{
    class DAL
    {
        public Dictionary<int, string> Destinations = new Dictionary<int, string>();

        private void CreateOfferedDestinations()
        {
            Destinations.Add(0, "Alanya");
            Destinations.Add(1, "Bangkok");
            Destinations.Add(2, "Barcelona");
            Destinations.Add(3, "Beijing");
            Destinations.Add(4, "Florida");
            Destinations.Add(5, "Hawaii");
            Destinations.Add(6, "NewYork");
            Destinations.Add(7, "Paris");
            Destinations.Add(8, "Turkey");
        }
        public string GetDestination(int identifier )
        {
            CreateOfferedDestinations();
            if (Destinations.ContainsKey(identifier))
            {
                return Destinations.Values.ElementAt(identifier);
            }
            else
            {
                return "No destination found";
            }            
        }
        public void Departure(Luggage lug)
        {

        }
        public void TestDAl()
        {
            Debug.WriteLine(GetDestination(8));
        }
        
    }
}
