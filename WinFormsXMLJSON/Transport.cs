using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsXMLJSON
{
    internal class Transport
    {
    public string Name { get; set; }
    public Route route { get; set; }
    public string Capacity { get; set; }
    public string Speed { get; set; }
    public string Cost { get; set; }

        public static IEnumerable<Transport> GetTransports()
        {
            return new List<Transport>
            {
                new Transport{ Name ="Bus",route = new Route {Start = "Kazan", End = "Ufa"},Capacity = "65",Speed =  "100",Cost = "100" },
                new Transport{ Name ="Trolleybus",route = new Route {Start = "Kremlin", End = "Gorki"},Capacity = "55",Speed =  "70",Cost = "90" },
                new Transport{Name = "Tram",route = new Route {Start = "Sukonnaya Sloboda", End = "Tukai Square"},Capacity = "40",Speed = "55",Cost = "60" }
            };
        }
    }

    internal class Route
    {
        public string Start { get; set; }
        public string End { get; set; }
    }
    internal class Conductor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int WorkAge { get; set; }
    }

}

