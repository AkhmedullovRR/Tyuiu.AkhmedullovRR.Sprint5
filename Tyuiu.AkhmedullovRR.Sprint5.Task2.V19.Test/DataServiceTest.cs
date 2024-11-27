using Tyuiu.AkhmedullovRR.Sprint5.Task2.V19.Lib;

namespace Tyuiu.AkhmedullovRR.Sprint5.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Àëåêñåé Øìåë¸â\source\repos\Tyuiu.AkhmedullovRR.Sprint5\Tyuiu.AkhmedullovRR.Sprint5.Task2.V15\bin\Debug\net8.0\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}