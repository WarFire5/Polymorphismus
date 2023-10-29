using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class FishAnimalTests
    {
        /// <summary>
        /// Проверка факта одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Планктон", 1, true)]
        [TestCase("Сахар", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("Аквариум", "в Океане", 100, 0, 0, "Планктон", "Фрукты", true);
            FishAnimal fish = new FishAnimal("Нимо", 3, 1, 1);
            aviary.AddFeedInFeeder(1);
            bool actual = fish.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка хищничества
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Планктон", true)]
        [TestCase("Сахар", false)]
        [TestCase("Сахар и Планктон", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            FishAnimal fish = new FishAnimal("Нимо", 3, 1, 1);
            fish.CheckPredator(food);
            bool actual = fish.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Планктон", true)]
        [TestCase("Сахар", false)]
        [TestCase("Сахар и Планктон", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Aviary aviary = new Aviary("Аквариум", "в Океане", 100, 0, 0, "Планктон", "Фрукты", true);
            FishAnimal fish = new FishAnimal("Нимо", 3, 1, 1);
            aviary.AddFeedInFeeder(3);
            fish.EatingPortionOfFeed(food, 1, aviary);
            fish.EatingPortionOfFeed(food, 1, aviary);
            fish.EatingPortionOfFeed(food, 1, aviary);
            bool actual = fish.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
