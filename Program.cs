using System;
using System.Collections.Generic;

namespace IGIProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var Maverick = new Pilot("Maverick", "Captain", 123456789);
            var Face = new TankDriver("Face", "Sergeant", 987654321);

            var ATeam = new List<Solider>();
            ATeam.Add(Maverick);
            ATeam.Add(Face); 

            Console.WriteLine(value: $"Pilot: {Maverick.Name}. Rank: {Maverick.Rank}. Serial#: {Maverick.SerialNum}.");
            Console.WriteLine($"TankDriver: {Face.Name}. Rank: {Face.Rank}. Serial#: {Face.SerialNum}.");
        }
    }
}
