namespace Polymorphismus.Classes
{
    public class FishAnimal : AbstractAnimal
    {
        public FishAnimal(string name, int volumeFeedPerDay, int age, int square)
        {
            Type = "Рыба";
            Type2 = "Рыбами";
            Biome = "в Океане";
            Feed = "Планктон";
            Feed2 = "Сахар";
            TypeAnimal = "Хищник";
            Do = "Плавает лучше всех";
            Sound = "Тишина";
            IsPredator = true;
            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
            Square = square;
        }
        public override bool EatingPortionOfFeed(string food, int portionOfFeed, Aviary aviary)
        {
            if (food == "Планктон" & portionOfFeed == 1 && aviary.Feeder >= 1)
            {
                bool checkFeed = aviary.AnimalAtePortionOfFeed(1);
                if (checkFeed = true)
                {
                    Console.WriteLine($"{Name} покушал {Feed}.");
                    Ate += portionOfFeed;
                    SatietyCheck();
                    return true;
                }
            }
            else
            {
                Console.WriteLine($"{Name} не стал есть.");
            }
            return false;
        }
        public bool CheckPredator(string food)
        {
            if (food == "Планктон")
            {
                Console.WriteLine($"{Name} - {TypeAnimal}.");
                IsPredator = true;
                return IsPredator;
            }
            else
            {
                IsPredator = false;
                return IsPredator;
            }
        }
        public override bool SatietyCheck()
        {
            if (Ate == 3)
            {
                Satiety = true;
                Console.WriteLine($"{Name} сыт.");
            }
            else
            {
                Satiety = false;
                Console.WriteLine($"{Name} не наелся.");
            }
            return Satiety;
        }
    }
}
