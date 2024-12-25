using System.IO;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine();
            string[] file = File.ReadAllLines(path);

            int columns = file[0].Split(";").Length;
            int rows = file.Length;

            int[,] matrix = new int[columns, rows];

            for (int i = 0; i < file.Length; i++)
            {
                string[] digits = file[i].Split(";");
                for (int j = 0; j < digits.Length; j++)
                {
                    int digit = Convert.ToInt32(digits[j]);
                    if (j == 7 && digit != 5)
                    {
                        matrix[i, j] = -1;
                    }
                    else
                    {
                        matrix[i, j] = digit;
                    }
                }
            }
    }
}
