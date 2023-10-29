namespace Polymorphismus.Classes
{
    public class OrangutanAnimal : AbstractAnimal
    {
        public OrangutanAnimal(string name, int volumeFeedPerDay, int age, int square)
        {
            Type = "Обезьяна";
            Type2 = "Обезьянами";
            Biome = "в Саванне";
            Feed = "Фрукты";
            Feed2 = "Чипсы";
            TypeAnimal = "Травоядное животное";
            Do = "Ловко лазает по деревьям";
            Sound = "У-у-ууу-уаа";
            IsPredator = false;
            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
            Square = square;
        }
        public override bool EatingPortionOfFeed(string food, int portionOfFeed, Aviary aviary)
        {
            if (food == "Фрукты" & portionOfFeed == 3 && aviary.FeederOther >= 3)
            {
                bool checkFeed = aviary.AnimalAtePortionOfFeedOther(3);
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
            if (food == "Фрукты" || food == "Чипсы" || food == "Фрукты и Чипсы")
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
            if (Ate == 9)
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
