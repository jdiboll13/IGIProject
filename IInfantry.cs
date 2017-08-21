namespace IGIProject
{
    interface IInfantry
    {
        string Weapon { get; set; }
        void Ammo();
        string RuckSack { get; set; }
        void WeightCarried();
        string FlakVest { get; set; }
        void ArmorWearing();
    }
}