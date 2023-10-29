using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class PenguinAnimalTests
    {
        /// <summary>
        /// Проверка факта одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Рыба", 1, true)]
        [TestCase("Хлеб", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("Пингвиний вольер", "на Льдине", 100, 0, 0, "Рыба", "Фрукты", true);
            PenguinAnimal penguin = new PenguinAnimal("Петя", 3, 5, 10);
            aviary.AddFeedInFeeder(1);
            bool actual = penguin.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка хищничества
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Рыба", true)]
        [TestCase("Хлеб", false)]
        [TestCase("Хлеб и Рыба", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            PenguinAnimal penguin = new PenguinAnimal("Петя", 3, 5, 10);
            penguin.CheckPredator(food);
            bool actual = penguin.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Рыба", true)]
        [TestCase("Хлеб", false)]
        [TestCase("Хлеб и Рыба", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Aviary aviary = new Aviary("Пингвиний вольер", "на Льдине", 100, 0, 0, "Рыба", "Фрукты", true);
            PenguinAnimal penguin = new PenguinAnimal("Петя", 3, 5, 10);
            aviary.AddFeedInFeeder(3); 
            penguin.EatingPortionOfFeed(food, 1, aviary);
            penguin.EatingPortionOfFeed(food, 1, aviary);
            penguin.EatingPortionOfFeed(food, 1, aviary);
            bool actual = penguin.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
