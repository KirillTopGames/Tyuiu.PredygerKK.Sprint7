namespace Tyuiu.PredygerKK.Sprint7.Project.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string path = Path.GetTempPath();
            FileInfo fileInfo = new FileInfo(path);
            bool fileexists = fileInfo.Exists;
            bool expect = false;
            Assert.AreEqual(expect, fileexists);
        }
    }
}