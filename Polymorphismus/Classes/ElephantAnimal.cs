namespace Polymorphismus.Classes
{
    public class ElephantAnimal : AbstractAnimal
    {
        public ElephantAnimal(string name, int volumeFeedPerDay, int age, int square)
        {
            Type = "Слон";
            Type2 = "Слонами";
            Biome = "в Саванне";
            Feed = "Сено";
            Feed2 = "Торт";
            TypeAnimal = "Травоядное животное";
            Do = "Использует хобот как пятую конечность";
            Sound = "Аууууф!!!";
            IsPredator = false;
            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
            Square = square;
        }
        public override bool EatingPortionOfFeed(string food, int portionOfFeed, Aviary aviary)
        {
            if (food == "Сено" & portionOfFeed == 5 && aviary.Feeder >= 5)
            {
                bool checkFeed = aviary.AnimalAtePortionOfFeed(5);
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
            if (food == "Сено" || food == "Торт" || food == "Сено и Торт")
            {
                Console.WriteLine($"{Name} - {TypeAnimal}.");
                IsPredator = false;
                return IsPredator;
            }
            else
            {
                IsPredator = true;
                return IsPredator;
            }
        }
        public override bool SatietyCheck()
        {
            if (Ate == 15)
            {
                Satiety = true;
                Console.WriteLine($"{Name} сыта.");
            }
            else
            {
                Satiety = false;
                Console.WriteLine($"{Name} не наелась.");
            }
            return Satiety;
        }
    }
}
