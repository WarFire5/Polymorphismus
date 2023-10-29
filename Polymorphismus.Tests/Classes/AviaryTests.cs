using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class AviaryTests
    {
        /// <summary>
        /// Проверка заселения животного
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase(true)]
        public void AddAnimalTests(bool expected)
        {
            Aviary aviary = new Aviary("Вольер без хищников", "в Саванне", 400, 0, 0, "Сено", "Фрукты", false);
            ElephantAnimal elephant = new ElephantAnimal("Матильда", 15, 20, 100);
            bool actual = aviary.AddAnimal(elephant);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка незаселения хищника к травоядным
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase(false)]
        public void AddAnimalNegativeTests(bool expected)
        {
            Aviary aviary = new Aviary("Вольер без хищников", "в Саванне", 400, 0, 0, "Сено", "Фрукты", false);
            ElephantAnimal elephant = new ElephantAnimal("Матильда", 15, 20, 100);
            TigerAnimal tiger = new TigerAnimal("Симба", 15, 10, 50);
            aviary.AddAnimal(elephant);
            bool actual = aviary.AddAnimal(tiger);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка отселения животного, найденного по имени
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase(true)]
        public void RemoveAnimalTests(bool expected)
        {
            Aviary aviary = new Aviary("Вольер без хищников", "в Саванне", 400, 0, 0, "Сено", "Фрукты", false);
            ElephantAnimal elephant = new ElephantAnimal("Матильда", 15, 20, 100);
            aviary.AddAnimal(elephant);
            bool actual = aviary.RemoveAnimal("Матильда");
            Assert.AreEqual(expected, actual);
        } 
        
        /// <summary>
        /// Проверка неотселения животного с не тем именем
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase(false)]
        public void RemoveAnimalNegativeTests(bool expected)
        {
            Aviary aviary = new Aviary("Вольер без хищников", "в Саванне", 400, 0, 0, "Сено", "Фрукты", false);
            ElephantAnimal elephant = new ElephantAnimal("Матильда", 15, 20, 100);
            aviary.AddAnimal(elephant);
            bool actual = aviary.RemoveAnimal("Матильда2");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка неотселения животного из пустого вольера
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase(false)]
        public void RemoveAnimalFromEmptyAviaryNegativeTests(bool expected)
        {
            Aviary aviary = new Aviary("Вольер без хищников", "в Саванне", 400, 0, 0, "Сено", "Фрукты", false);
            bool actual = aviary.RemoveAnimal("Матильда");
            Assert.AreEqual(expected, actual);
        }


    }
}
