namespace PatternBasedProblems.Two_Pointers;

public class TrappingRainWater
{
    //“Two-pointer” + “Boundary tracking”
    public int Trap()
    {
        int[] wallHeight = new int[12] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

        int leftIndex = 0, rightIndex = wallHeight.Length - 1;

        int trappedWater = 0;
        int leftMax = 0, rightMax = 0;
        while (leftIndex < rightIndex)
        {
            if (wallHeight[leftIndex] <= wallHeight[rightIndex])
            {
                if (wallHeight[leftIndex] > leftMax)
                {
                    leftMax = wallHeight[leftIndex];
                }
                else
                {
                    trappedWater += leftMax - wallHeight[leftIndex];
                }
                leftIndex++;
            }
            else
            {
                if (wallHeight[rightIndex] > rightMax)
                {
                    rightMax = wallHeight[rightIndex];
                }
                else
                {
                    trappedWater += rightMax - wallHeight[rightIndex];
                }
                rightIndex--;
            }
        }

        return trappedWater;
    }
}
