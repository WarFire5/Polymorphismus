namespace Polymorphismus.Classes
{
    public class Aviary
    {
        public string Name { get; set; }
        public string Biome { get; set; }
        public int Square { get; protected set; }
        public int Feeder { get; protected set; }
        public int FeederOther { get; protected set; }
        public string Feed { get; protected set; }
        public string FeedOther { get; protected set; }
        public bool IsPredator { get; protected set; }
        public List<AbstractAnimal> Animals { get; set; }

        public Aviary(string name, string biome, int square, int feeder, int feederOther, string feed, string feedOther, bool isPredator)
        {
            Name = name;
            Biome = biome;
            Square = square;
            Feeder = feeder;
            FeederOther = feederOther;
            Feed = feed;
            FeedOther = feedOther;
            IsPredator = isPredator;
            Animals = new List<AbstractAnimal>();
        }

        public bool AddAnimal(AbstractAnimal animal)
        {
            int was = Animals.Count;
            Animals.Add(animal);
            if (Biome != animal.Biome)
            {
                return false;
            }
            else
            {
                if (IsPredator == false && IsPredator == animal.IsPredator)
                {
                    if (was < Animals.Count && Square >= animal.Square)
                    {
                        Square -= animal.Square;
                        Console.WriteLine();
                        Console.WriteLine($"Животное {animal.Type} {animal.Name} добавлено в {Name}.");
                        Console.WriteLine($"В {Name} {Animals.Count} животных.");
                        Console.WriteLine($"В {Name} осталось {Square} кв.м.");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (Animals.Count == 0 && IsPredator == animal.IsPredator)
                {
                    if (was < Animals.Count && Square >= animal.Square)
                    {
                        Square -= animal.Square;
                        Console.WriteLine();
                        Console.WriteLine($"Животное {animal.Type} {animal.Name} добавлено в {Name}.");
                        Console.WriteLine($"В {Name} {Animals.Count} животных.");
                        Console.WriteLine($"В {Name} осталось {Square} кв.м.");
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (Animals.Count > 0 && IsPredator == animal.IsPredator)
                {
                    if (animal.Type == Animals[0].Type)
                    {
                        if (was < Animals.Count && Square >= animal.Square)
                        {
                            Square -= animal.Square;
                            Console.WriteLine();
                            Console.WriteLine($"Животное {animal.Type} {animal.Name} добавлено в {Name}.");
                            Console.WriteLine($"В {Name} {Animals.Count} животных.");
                            Console.WriteLine($"В {Name} осталось {Square} кв.м.");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
        }

        public bool RemoveAnimal(string name)
        {
            int was = Animals.Count;
            if (Animals.Count == 0)
            {
                return false;
            }
            else
            {
                foreach (var animal in Animals)
                {
                    if (animal.Name == name)
                    {
                        Animals.Remove(animal);
                        if (was > Animals.Count)
                        {
                            Square += animal.Square;
                            Console.WriteLine();
                            Console.WriteLine($"Животное {animal.Name} удалено из {Name}");
                            Console.WriteLine($"В {Name} осталось {Animals.Count} животных");
                            Console.WriteLine($"В {Name} осталось {Square} кв.м.");
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public bool AddFeedInFeeder(int feed)
        {
            int was = Feeder;
            Feeder += feed;
            if (was < Feeder)
            {
                Console.WriteLine();
                Console.WriteLine($"Корм {Feed} в количестве {Feeder} добавлен в {Name}.");
                Console.WriteLine($"В кормушке {Feeder} {Feed}.");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddFeedInOtherFeeder(int feedOther)
        {
            int was = FeederOther;
            FeederOther += feedOther;
            if (was < FeederOther)
            {
                Console.WriteLine();
                Console.WriteLine($"Корм {FeedOther} в количестве {FeederOther} добавлен в {Name}.");
                Console.WriteLine($"В кормушке {FeederOther} {FeedOther}.");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FeedAllAnimals()
        {
            foreach (var animal in Animals)
            {
                if (animal.Type == "Слон")
                {
                    Console.WriteLine();
                    animal.EatingPortionOfFeed("Сено", 5, this);
                }
                if (animal.Type == "Пингвин")
                {
                    Console.WriteLine();
                    animal.EatingPortionOfFeed("Рыба", 1, this);
                }
                if (animal.Type == "Тигр")
                {
                    Console.WriteLine();
                    animal.EatingPortionOfFeed("Мясо", 5, this);
                }
                if (animal.Type == "Лягушка")
                {
                    Console.WriteLine();
                    animal.EatingPortionOfFeed("Насекомые", 2, this);
                }
                if (animal.Type == "Рыба")
                {
                    Console.WriteLine();
                    animal.EatingPortionOfFeed("Планктон", 1, this);
                }
                if (animal.Type == "Обезьяна")
                {
                    Console.WriteLine();
                    animal.EatingPortionOfFeed("Фрукты", 3, this);
                }
            }
        }

        public void SatietyCheckOfAllAnimals()
        {
            Console.WriteLine();
            foreach (var animal in Animals)
            {
                animal.SatietyCheck();
            }
        }

        public bool AnimalAtePortionOfFeed(int value)
        {
            if (Feeder == 0 || Feeder - value < 0)
            {
                return false;
            }
            else
            {
                Feeder -= value;
                return true;
            }
        }

        public bool AnimalAtePortionOfFeedOther(int value)
        {
            if (FeederOther == 0 || FeederOther - value < 0)
            {
                return false;
            }
            else
            {
                FeederOther -= value;
                return true;
            }
        }

        public void ShowRemainderFeeder()
        {
            Console.WriteLine();
            Console.WriteLine($"В кормушке осталось {Feeder} {Feed}.");
        }

        public void ShowRemainderFeederOther()
        {
            Console.WriteLine($"В кормушке для обезьян осталось {FeederOther} {FeedOther}.");
        }

        public void MakeASoundAllAnimals()
        {
            Console.WriteLine();
            foreach (var animal in Animals)
            {
                animal.MakeASound();
            }
        }

        //public void ShowListAnimals()
        //{
        //    foreach (var animal in Animals)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine($"{animal.Name}, {animal.Type}");
        //        animal.SatietyCheck();
        //    }
        //}
    }
}
