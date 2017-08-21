namespace IGIProject
{
    interface IInfantry
    {
        string Weapon { get; set; }
        void Ammo();
        void WeightCarried();
        void ArmorWearing();
    }
}