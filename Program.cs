using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 
  		Rover[] rovers = { lunokhod, apollo, sojourner };
      IDirectable[] probes = { lunokhod, apollo, sojourner, sputnik };

      DirectAll(rovers);
      Console.WriteLine($"Tracking a {lunokhod.GetType()}");
      Console.WriteLine($"Tracking a {apollo.GetType()}");
      Console.WriteLine($"Tracking a {sojourner.GetType()}");
      Console.WriteLine($"Tracking a {sputnik.GetType()}");
    }

    public static void DirectAll(IDirectable[] probes)
    {
      foreach(IDirectable r in probes) {
        Console.WriteLine(r.GetInfo());
        Console.WriteLine(r.Explore());
        Console.WriteLine(r.Collect());
      }
    }
  }
  
}
