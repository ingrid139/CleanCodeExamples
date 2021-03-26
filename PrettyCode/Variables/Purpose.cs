using System.Collections.Generic;

namespace PrettyCode.Variables
{
    public class Purpose
    {
        private List<int[]> gameBoard;
        private int STATUS_VALUE = 0;
        private int FLAGGED = 4;

        public List<int[]> getFlaggedCells()
        {
            List<int[]> flaggedCells = new List<int[]>();

            foreach (int[] cell in gameBoard)
            {
                if (cell[STATUS_VALUE] == FLAGGED)
                    flaggedCells.Add(cell);
            }

            return flaggedCells;
        }

        public List<int[]> getFlaggedCellsRefactor()
        {
            List<int[]> flaggedCells = new List<int[]>();

            foreach (int[] cell in gameBoard)
            {
                if (cell.isFlagged())
                    flaggedCells.Add(cell);
            }

            return flaggedCells;
        }
    }
}
