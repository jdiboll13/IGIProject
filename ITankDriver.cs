namespace IGIProject
{
    interface ITankDriver
    {
        string Tank { get; set; }
        void FireOrdinance();
        void CrewSize();
        void ArmorClass();

    }
}