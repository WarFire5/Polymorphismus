using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class FishAnimalTests
    {
        /// <summary>
        /// �������� ����� ������ ����� ����
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("��������", 1, true)]
        [TestCase("�����", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("��������", "� ������", 100, 0, 0, "��������", "������", true);
            FishAnimal fish = new FishAnimal("����", 3, 1, 1);
            aviary.AddFeedInFeeder(1);
            bool actual = fish.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �����������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("��������", true)]
        [TestCase("�����", false)]
        [TestCase("����� � ��������", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            FishAnimal fish = new FishAnimal("����", 3, 1, 1);
            fish.CheckPredator(food);
            bool actual = fish.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("��������", true)]
        [TestCase("�����", false)]
        [TestCase("����� � ��������", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Aviary aviary = new Aviary("��������", "� ������", 100, 0, 0, "��������", "������", true);
            FishAnimal fish = new FishAnimal("����", 3, 1, 1);
            aviary.AddFeedInFeeder(3);
            fish.EatingPortionOfFeed(food, 1, aviary);
            fish.EatingPortionOfFeed(food, 1, aviary);
            fish.EatingPortionOfFeed(food, 1, aviary);
            bool actual = fish.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
