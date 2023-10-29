using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class ElephantAnimalTests
    {
        /// <summary>
        /// �������� ����� ������ ����� ����
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("����", 5, true)]
        [TestCase("����", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("������ ��� ��������", "� �������", 400, 0, 0, "����", "������", false);
            ElephantAnimal elephant = new ElephantAnimal("��������", 15, 20, 100);
            aviary.AddFeedInFeeder(5);
            bool actual = elephant.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �����������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("����", false)]
        [TestCase("����", false)]
        [TestCase("���� � ����", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            ElephantAnimal elephant = new ElephantAnimal("��������", 15, 20, 100);
            elephant.CheckPredator(food);
            bool actual = elephant.IsPredator;
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
            Aviary aviary = new Aviary("������ ��� ��������", "� �������", 400, 0, 0, "����", "������", false);
            ElephantAnimal elephant = new ElephantAnimal("��������", 15, 20, 100);
            aviary.AddFeedInFeeder(15);
            elephant.EatingPortionOfFeed(food, 5, aviary);
            elephant.EatingPortionOfFeed(food, 5, aviary);
            elephant.EatingPortionOfFeed(food, 5, aviary);
            bool actual = elephant.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
