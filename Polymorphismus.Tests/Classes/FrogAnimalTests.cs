using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class FrogAnimalTests
    {
        /// <summary>
        /// �������� ����� ������ ����� ����
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("���������", 2, true)]
        [TestCase("���", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("��������� ������", "� ������", 25, 0, 0, "���������", "������", true);
            FrogAnimal frog = new FrogAnimal("�����", 6, 3, 5);
            aviary.AddFeedInFeeder(2);
            bool actual = frog.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �����������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("���������", true)]
        [TestCase("���", false)]
        [TestCase("��������� � ���", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            FrogAnimal frog = new FrogAnimal("�����", 6, 3, 5);
            frog.CheckPredator(food);
            bool actual = frog.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("���������", true)]
        [TestCase("���", false)]
        [TestCase("��������� � ���", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Aviary aviary = new Aviary("��������� ������", "� ������", 25, 0, 0, "���������", "������", true);
            FrogAnimal frog = new FrogAnimal("�����", 6, 3, 5);
            aviary.AddFeedInFeeder(6);
            frog.EatingPortionOfFeed(food, 2, aviary);
            frog.EatingPortionOfFeed(food, 2, aviary);
            frog.EatingPortionOfFeed(food, 2, aviary);
            bool actual = frog.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
