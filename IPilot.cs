namespace IGIProject
{
    interface IPilot
    {
        string Aircraft { get; set; }
        void FireMissiles();
        void ShootGuns();
        void DropBombs();

    }
}