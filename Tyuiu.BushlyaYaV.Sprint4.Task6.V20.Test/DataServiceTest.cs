
using Tyuiu.BushlyaYaV.Sprint4.Task6.V20.Lib;

namespace Tyuiu.BushlyaYaV.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = { "����������", "������", "�����", "��������", "���������", "�������", "����������" };
            string[] wait = { "������", "�����", "��������", "���������", "�������" };
            string[] res = ds.Calculate(mas);
            CollectionAssert.AreEqual(wait, res);

        }
    }
}