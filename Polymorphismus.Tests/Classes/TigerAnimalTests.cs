using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class TigerAnimalTests
    {
        /// <summary>
        /// �������� ����� ������ ����� ����
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("����", 5, true)]
        [TestCase("�����", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("�������� ������", "� ��������", 300, 0, 0, "����", "������", true);
            TigerAnimal tiger = new TigerAnimal("�����", 15, 10, 50);
            aviary.AddFeedInFeeder(5);
            bool actual = tiger.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �����������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("����", true)]
        [TestCase("�����", false)]
        [TestCase("���� � �����", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            TigerAnimal tiger = new TigerAnimal("�����", 15, 10, 50);
            tiger.CheckPredator(food);
            bool actual = tiger.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("����", true)]
        [TestCase("�����", false)]
        [TestCase("���� � �����", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Aviary aviary = new Aviary("�������� ������", "� ��������", 300, 0, 0, "����", "������", true);
            TigerAnimal tiger = new TigerAnimal("�����", 15, 10, 50);
            aviary.AddFeedInFeeder(15); 
            tiger.EatingPortionOfFeed(food, 5, aviary);
            tiger.EatingPortionOfFeed(food, 5, aviary);
            tiger.EatingPortionOfFeed(food, 5, aviary);
            bool actual = tiger.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
