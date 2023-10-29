using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class PenguinAnimalTests
    {
        /// <summary>
        /// �������� ����� ������ ����� ����
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("����", 1, true)]
        [TestCase("����", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("��������� ������", "�� ������", 100, 0, 0, "����", "������", true);
            PenguinAnimal penguin = new PenguinAnimal("����", 3, 5, 10);
            aviary.AddFeedInFeeder(1);
            bool actual = penguin.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �����������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("����", true)]
        [TestCase("����", false)]
        [TestCase("���� � ����", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            PenguinAnimal penguin = new PenguinAnimal("����", 3, 5, 10);
            penguin.CheckPredator(food);
            bool actual = penguin.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("����", true)]
        [TestCase("����", false)]
        [TestCase("���� � ����", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Aviary aviary = new Aviary("��������� ������", "�� ������", 100, 0, 0, "����", "������", true);
            PenguinAnimal penguin = new PenguinAnimal("����", 3, 5, 10);
            aviary.AddFeedInFeeder(3); 
            penguin.EatingPortionOfFeed(food, 1, aviary);
            penguin.EatingPortionOfFeed(food, 1, aviary);
            penguin.EatingPortionOfFeed(food, 1, aviary);
            bool actual = penguin.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
