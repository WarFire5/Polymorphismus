using Polymorphismus.Classes;

namespace Polymorphismus.Tests.Classes
{
    public class OrangutanAnimalTests
    {
        /// <summary>
        /// �������� ����� ������ ����� ����
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("������", 3, true)]
        [TestCase("�����", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            Aviary aviary = new Aviary("������ ��� ��������", "� �������", 400, 0, 0, "����", "������", false);
            OrangutanAnimal orangutan = new OrangutanAnimal("�����", 9, 15, 25);
            aviary.AddFeedInOtherFeeder(3);
            bool actual = orangutan.EatingPortionOfFeed(food, portionOfFeed, aviary);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �����������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("������", false)]
        [TestCase("�����", false)]
        [TestCase("������ � �����", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            OrangutanAnimal orangutan = new OrangutanAnimal("�����", 9, 15, 25);
            orangutan.CheckPredator(food);
            bool actual = orangutan.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("������", true)]
        [TestCase("�����", false)]
        [TestCase("������ � �����", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            Aviary aviary = new Aviary("������ ��� ��������", "� �������", 400, 0, 0, "����", "������", false);
            OrangutanAnimal orangutan = new OrangutanAnimal("�����", 9, 15, 25);
            aviary.AddFeedInOtherFeeder(9);
            orangutan.EatingPortionOfFeed(food, 3, aviary);
            orangutan.EatingPortionOfFeed(food, 3, aviary);
            orangutan.EatingPortionOfFeed(food, 3, aviary);
            bool actual = orangutan.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
