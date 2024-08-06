namespace functions
{
    public class calculator
    {
        public int ADD(params int[] nums)
        {
            int sum = 0;
            foreach (int number in nums)
            {
                sum += number;
            }
            return sum;
        }
    }
}
