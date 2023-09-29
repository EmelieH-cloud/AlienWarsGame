namespace AlienWars2023
{
    internal class Weapon
    {
        public int Precision { get; set; }
        public int Speed { get; set; }

        public Weapon(int p, int s)
        {
            Precision = p;
            Speed = s;
        }
    }
}
