using Tyuiu.DolgovIV.Sprint6.TaskReview.V25.Lib;

namespace Tyuiu.DolgovIV.Sprint6.TaskReview.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int N = 5;
            int M = 5;
            int X = 3;
            int[,] array = new int[N, M];

            int n1 = 0;
            int n2 = 10;

            int k = 0;
            int l = 1;
            int R = 3;

            int res = ds.result(ds.GetMatrix(array, n1, n2, X), R, k, l);
            int wait = 3;
            Assert.AreEqual(res, wait);
        }
    }
}
