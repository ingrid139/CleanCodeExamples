namespace PrettyCode.Variables
{
    public static class  MyExtensions
    {
        private static int STATUS_VALUE = 0;
        private static int FLAGGED = 4;
        public static bool isFlagged(this int[] cell)
        {
            return cell[STATUS_VALUE] == FLAGGED;
        }
    }
}
