using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class FrogAnimalTests
    {
        /// <summary>
        /// Проверка факта одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Насекомые", 2, true)]
        [TestCase("Сыр", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("Лягушачий вольер", "в Болоте", 25, 0, 0, "Насекомые", "Фрукты", true);
            FrogAnimal frog = new FrogAnimal("Кваша", 6, 3, 5);
            aviary.AddFeedInFeeder(2);
            bool actual = frog.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка хищничества
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Насекомые", true)]
        [TestCase("Сыр", false)]
        [TestCase("Насекомые и Сыр", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            FrogAnimal frog = new FrogAnimal("Кваша", 6, 3, 5);
            frog.CheckPredator(food);
            bool actual = frog.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Насекомые", true)]
        [TestCase("Сыр", false)]
        [TestCase("Насекомые и Сыр", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Aviary aviary = new Aviary("Лягушачий вольер", "в Болоте", 25, 0, 0, "Насекомые", "Фрукты", true);
            FrogAnimal frog = new FrogAnimal("Кваша", 6, 3, 5);
            aviary.AddFeedInFeeder(6);
            frog.EatingPortionOfFeed(food, 2, aviary);
            frog.EatingPortionOfFeed(food, 2, aviary);
            frog.EatingPortionOfFeed(food, 2, aviary);
            bool actual = frog.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
