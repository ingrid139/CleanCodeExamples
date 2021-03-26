
namespace UglyCode.Variables
{
    public class Searchable
    {
        private int[] t = new int[34];
        public int Sum()
        {
            int s = 0;
            for (int i = 0; i < 34; i++)
            {
                s += (t[i] * 4) / 5;
            }
            return s;
        }
    }
}
