using System.Collections.Generic;


namespace UglyCode.Variables
{
    public class Purpose
    {
        //qual proósito desse código?

        private List<int[]> theList;
        public List<int[]> getThen()
        {
            List<int[]> list1 = new List<int[]>();

            foreach (int[] x in theList)
            {
                if (x[0] == 4)
                    list1.Add(x);
            }

            return list1;
        }
    }
}
