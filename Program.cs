namespace FindMaximumNumberProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum");
            //IntigerTestCase1
            int IntigerTestCase1 = MaximumNumberCheck.MaximumIntigerNumber(23, 4, 5);
            Console.WriteLine("Maximum no is " + IntigerTestCase1);
            //IntigerTestCase2
            int IntigerTestCase2 = MaximumNumberCheck.MaximumIntigerNumber(23, 45, 5);
            Console.WriteLine("Maximum no is " + IntigerTestCase2);
            //IntigerTestCase3
            int IntigerTestCase3 = MaximumNumberCheck.MaximumIntigerNumber(23, 45, 54);
            Console.WriteLine("Maximum no is " + IntigerTestCase3);
        }
    }
}
