namespace PatternBasedProblems.Two_Pointers;

public class TrappingRainWater
{
    //“Two-pointer” + “Boundary tracking”
    public static int Trap()
    {
        int[] wallHeight = new int[12] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        //int[] wallHeight = new int[8] { 0, 1, 0, 2, 0, 1, 0, 0 };

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
                    var waterTrappedLeft = leftMax - wallHeight[leftIndex];
                    trappedWater += waterTrappedLeft;
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
                    var waterTrappedRight = rightMax - wallHeight[rightIndex];
                    trappedWater += waterTrappedRight;
                }
                rightIndex--;
            }
        }

        return trappedWater;
    }
}
