using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class TigerAnimalTests
    {
        /// <summary>
        /// Проверка факта одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Мясо", 5, true)]
        [TestCase("Трава", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("Тигриный вольер", "в Джунглях", 300, 0, 0, "Мясо", "Фрукты", true);
            TigerAnimal tiger = new TigerAnimal("Симба", 15, 10, 50);
            aviary.AddFeedInFeeder(5);
            bool actual = tiger.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка хищничества
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Мясо", true)]
        [TestCase("Трава", false)]
        [TestCase("Мясо и Трава", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            TigerAnimal tiger = new TigerAnimal("Симба", 15, 10, 50);
            tiger.CheckPredator(food);
            bool actual = tiger.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Мясо", true)]
        [TestCase("Трава", false)]
        [TestCase("Мясо и Трава", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Aviary aviary = new Aviary("Тигриный вольер", "в Джунглях", 300, 0, 0, "Мясо", "Фрукты", true);
            TigerAnimal tiger = new TigerAnimal("Симба", 15, 10, 50);
            aviary.AddFeedInFeeder(15); 
            tiger.EatingPortionOfFeed(food, 5, aviary);
            tiger.EatingPortionOfFeed(food, 5, aviary);
            tiger.EatingPortionOfFeed(food, 5, aviary);
            bool actual = tiger.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
