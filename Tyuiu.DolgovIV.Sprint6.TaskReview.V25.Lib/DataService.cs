namespace Tyuiu.DolgovIV.Sprint6.TaskReview.V25.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(int[,] array, int n1, int n2, int x)
        {
            int rows = array.GetUpperBound(0) + 1;
            int cols = array.Length / rows;

            Random rn = new Random();


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i % 2 != 0)
                    {
                        array[i, j] = x;
                    }
                    else
                    {
                        array[i, j] = rn.Next(n1, n2);
                    }
                }
            }

            return array;
        }

        public int result(int[,] array, int R, int k, int l)
        {
            int res = 0;
            for (int j = k; j <= l; j++)
            {
                if (array[R-1, j] % 2 != 0)
                {
                    res += array[R-1, j];
                }
            }

            return res;
        }
    }
}
