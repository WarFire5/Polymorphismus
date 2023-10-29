using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class ElephantAnimalTests
    {
        /// <summary>
        /// Проверка факта одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Сено", 5, true)]
        [TestCase("Торт", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("Вольер без хищников", "в Саванне", 400, 0, 0, "Сено", "Фрукты", false);
            ElephantAnimal elephant = new ElephantAnimal("Матильда", 15, 20, 100);
            aviary.AddFeedInFeeder(5);
            bool actual = elephant.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка хищничества
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Сено", false)]
        [TestCase("Торт", false)]
        [TestCase("Сено и Торт", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            ElephantAnimal elephant = new ElephantAnimal("Матильда", 15, 20, 100);
            elephant.CheckPredator(food);
            bool actual = elephant.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Сено", true)]
        [TestCase("Торт", false)]
        [TestCase("Сено и Торт", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Aviary aviary = new Aviary("Вольер без хищников", "в Саванне", 400, 0, 0, "Сено", "Фрукты", false);
            ElephantAnimal elephant = new ElephantAnimal("Матильда", 15, 20, 100);
            aviary.AddFeedInFeeder(15);
            elephant.EatingPortionOfFeed(food, 5, aviary);
            elephant.EatingPortionOfFeed(food, 5, aviary);
            elephant.EatingPortionOfFeed(food, 5, aviary);
            bool actual = elephant.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
