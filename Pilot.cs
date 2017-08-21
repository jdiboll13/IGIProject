using System;

namespace IGIProject
{
    public class Pilot : Solider, IPilot
    {
        public Pilot(string name, string rank, int serialNum)
        {
            this.Name = name;
            this.Rank = rank;
            this.SerialNum = serialNum;
        }

        public string Aircraft { get; set; }

        public void NumBombs() => Console.WriteLine("I'm carrying 20 GBU-38s bombs.");

        public void NumBullets() => Console.WriteLine("I'm carrying 10,000 rounds of bullets.");

        public void NumMissiles() => Console.WriteLine("I'm carrying 8 AIM-9X missiles.");

        public override void Speak() => Console.WriteLine("Too close for missiles. Switching to guns.");
    }
}