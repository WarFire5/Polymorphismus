namespace Polymorphismus.Classes
{
    public class PenguinAnimal : AbstractAnimal
    {
        public PenguinAnimal(string name, int volumeFeedPerDay, int age, int square)
        {
            Type = "Пингвин";
            Type2 = "Пингвинами";
            Biome = "на Льдине";
            Feed = "Рыба";
            Feed2 = "Хлеб";
            TypeAnimal = "Хищник";
            Do = "Птица, но не умеет летать; зато хоршо плавает";
            Sound = "Хрю!";
            IsPredator = true;
            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
            Square = square;
        }
        public override bool EatingPortionOfFeed(string food, int portionOfFeed, Aviary aviary)
        {
            if (food == "Рыба" & portionOfFeed == 1 && aviary.Feeder >= 1)
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
            if (food == "Рыба")
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