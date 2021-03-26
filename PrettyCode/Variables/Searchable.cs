using System;
using System.Collections.Generic;
using System.Text;

namespace PrettyCode.Variables
{
    public class Searchable
    {
        private int[] taskEstimate = new int[34];
        public const int NUMBER_OF_TASKS = 34;
        private const int realDaysPerIdealDay = 4;
        public const int WORK_DAYS_PER_WEEK = 5;

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < NUMBER_OF_TASKS; i++)
            {
                int realTaskDays = taskEstimate[i] * realDaysPerIdealDay;
                int realTaskWeeks = realTaskDays / WORK_DAYS_PER_WEEK;
                sum += realTaskWeeks;
            }
            return sum;
        }
    }
}
