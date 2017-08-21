using System;

namespace IGIProject
{
    public class TankDriver : Solider, ITankDriver, IInfantry
    {
        public TankDriver(string name, string rank, int serialNum)
        {
            this.Name = name;
            this.Rank = rank;
            this.SerialNum = serialNum;
        }
        public string Tank { get; set; }
        public string RuckSack { get; set; }
        public string FlakVest { get; set; }
        public string Weapon { get; set; }

        public void Ammo()
        {
            Console.WriteLine("I have 10 clips of 20 rounds each.");
        }

        public void ArmorClass()
        {
            Console.WriteLine("The armor class is 20.");
        }

        public void ArmorWearing()
        {
            Console.WriteLine("I have full-size plates in my Flak vest.");
        }

        public void CrewSize()
        {
            Console.WriteLine("The crew size is 4 members.");
        }

        public void FireOrdinance()
        {
            Console.WriteLine("FIRE!!!");
        }

        public override void Speak()
        {
            Console.WriteLine("Oorah!");
        }

        public void WeightCarried()
        {
            Console.WriteLine("My gear weighs 120lbs.");
        }
    }
}