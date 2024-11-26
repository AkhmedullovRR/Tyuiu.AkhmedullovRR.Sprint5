using Tyuiu.AkhmedullovRR.Sprint5.Task0.V27.Lib;
namespace Tyuiu.AkhmedullovRR.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Äàøà\source\repos\Tyuiu.KulkoDA.Sprint5\Tyuiu.KulkoDA.Sprint5.Task0.V27\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);

        }
    }
}