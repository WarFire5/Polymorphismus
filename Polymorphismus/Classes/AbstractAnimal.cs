namespace Polymorphismus.Classes
{
    public abstract class AbstractAnimal
    {
        public string Type { get; protected set; }
        public string Type2 { get; protected set; }
        public string Biome { get; protected set; }
        public int Square { get; set; }
        public string Feed { get; protected set; }
        public string Feed2 { get; protected set; }
        public bool IsPredator { get; protected set; }
        public string TypeAnimal { get; protected set; }
        public string Do { get; protected set; }
        public string Sound { get; protected set; }
        public string Name { get; set; }
        public int VolumeFeedPerDay { get; set; }
        public int Age { get; set; }
        public int Ate { get; protected set; }
        public bool Satiety { get; protected set; }

        public abstract bool EatingPortionOfFeed(string food, int portionOfFeed, Aviary aviary);

        public void Is()
        {
            Console.WriteLine($"{Name} это {Type}. {Type} - это {TypeAnimal}. Животному {Age} лет.");
        }
        public void LivesIn()
        {
            Console.WriteLine($"{Name} обитает {Biome} на площади {Square} кв.м.");
        }
        public void DoIt()
        {
            Console.WriteLine($"{Name} {Do}.");
        }
        public void MakeASound()
        {
            Console.WriteLine($"{Name} издал(а) звук '{Sound}'.");
        }
        public void Playing()
        {
            Console.WriteLine($"{Name} поиграл(а).");
        }
        public void PlayingWithRelatives()
        {
            Console.WriteLine($"{Name} поиграл(а) с другими {Type2}.");
        }
        public abstract bool SatietyCheck();
    }
}
