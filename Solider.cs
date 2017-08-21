using System;

namespace IGIProject
{
    public abstract class Solider
    {
        public int SerialNum { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }

        public void Eat()
        {
            Console.WriteLine("Yum yum yum.");
        }
        public void Sleep()
        {
            Console.WriteLine("Counting sheep.");
        }
        public void March()
        {
            Console.WriteLine("Hup, Two, Three, Four.");
        }
        public abstract void Speak();
        
    }
}