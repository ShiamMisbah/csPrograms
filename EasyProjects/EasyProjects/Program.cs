namespace EasyProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3,5,7,2,5 };
            int target = 9;

            TwoSum(ints, target);
        }
        static void TwoSum(int[] nums, int target)
        {
            int[] li = new int[2];
            for (int con = 0; con < nums.Length; con++)
            {
                for (int i = con + 1; i < nums.Length; i++)
                {
                    if (nums[con] + nums[i] == target)
                    {
                        li[0] = con;
                        li[1] = i;
                        break;
                    }
                }
            }
            Console.WriteLine("[{0},{1}]",li[0],li[1]);
        }
    }
}
