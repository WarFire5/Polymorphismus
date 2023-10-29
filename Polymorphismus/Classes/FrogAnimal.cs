namespace Polymorphismus.Classes
{
    public class FrogAnimal : AbstractAnimal
    {
        public FrogAnimal(string name, int volumeFeedPerDay, int age, int square)
        {
            Type = "Лягушка";
            Type2 = "Лягушками";
            Biome = "в Болоте";
            Feed = "Насекомые";
            Feed2 = "Сыр";
            TypeAnimal = "Хищник";
            Do = "Хорошо прыгает и стреляет липким языком";
            Sound = "Квааа!";
            IsPredator = true;
            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
            Square = square;
        }
        public override bool EatingPortionOfFeed(string food, int portionOfFeed, Aviary aviary)
        {
            if (food == "Насекомые" & portionOfFeed == 2 && aviary.Feeder >= 2)
            {
                bool checkFeed = aviary.AnimalAtePortionOfFeed(2);
                if (checkFeed = true)
                {
                    Console.WriteLine($"{Name} покушала {Feed}.");
                    Ate += portionOfFeed;
                    SatietyCheck();
                    return true;
                }
            }
            else
            {
                Console.WriteLine($"{Name} не стала есть.");
            }
            return false;
        }
        public bool CheckPredator(string food)
        {
            if (food == "Насекомые")
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
            if (Ate == 6)
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
