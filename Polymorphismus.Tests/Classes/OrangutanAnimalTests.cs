using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class OrangutanAnimalTests
    {
        /// <summary>
        /// Проверка факта одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Фрукты", 3, true)]
        [TestCase("Чипсы", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("Вольер без хищников", "в Саванне", 400, 0, 0, "Сено", "Фрукты", false);
            OrangutanAnimal orangutan = new OrangutanAnimal("Губач", 9, 15, 25);
            aviary.AddFeedInOtherFeeder(3);
            bool actual = orangutan.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка хищничества
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Фрукты", false)]
        [TestCase("Чипсы", false)]
        [TestCase("Фрукты и Чипсы", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            OrangutanAnimal orangutan = new OrangutanAnimal("Губач", 9, 15, 25);
            orangutan.CheckPredator(food);
            bool actual = orangutan.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Фрукты", true)]
        [TestCase("Чипсы", false)]
        [TestCase("Фрукты и Трава", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Aviary aviary = new Aviary("Вольер без хищников", "в Саванне", 400, 0, 0, "Сено", "Фрукты", false);
            OrangutanAnimal orangutan = new OrangutanAnimal("Губач", 9, 15, 25);
            aviary.AddFeedInOtherFeeder(9);
            orangutan.EatingPortionOfFeed(food, 3, aviary);
            orangutan.EatingPortionOfFeed(food, 3, aviary);
            orangutan.EatingPortionOfFeed(food, 3, aviary);
            bool actual = orangutan.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
