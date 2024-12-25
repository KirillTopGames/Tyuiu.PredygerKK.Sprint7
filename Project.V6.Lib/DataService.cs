using System.Reflection.Metadata.Ecma335;

namespace Tyuiu.PredygerKK.Sprint7.Project.V6.Lib
{
    public class DataService
    {
        public bool GetPath(string path)
        {
            path = Path.Combine("C:", "Desktop", "С# - Data.csv");
            return true;
        }
    }
}
