namespace FindMaximumNumberProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum number");
            //IntigerTestCase1
            //int IntigerTestCase1 = MaximumNumberCheck.MaximumIntigerNumber(23, 4, 5);
            //Console.WriteLine("Maximum no is " + IntigerTestCase1);
            ////IntigerTestCase2
            //int IntigerTestCase2 = MaximumNumberCheck.MaximumIntigerNumber(23, 45, 5);
            //Console.WriteLine("Maximum no is " + IntigerTestCase2);
            ////IntigerTestCase3
            //int IntigerTestCase3 = MaximumNumberCheck.MaximumIntigerNumber(23, 45, 54);
            //Console.WriteLine("Maximum no is " + IntigerTestCase3);
            //FloatTestCase1
            //double FloatTestCase1 = MaximumNumberCheck.MaximumFloatNumber(45.6, 4.3, 5.7);
            //Console.WriteLine("Maximum no is " + FloatTestCase1);
            ////FloatTestCase2
            //double FloatTestCase2 = MaximumNumberCheck.MaximumFloatNumber(23.8, 42.8, 16.4);
            //Console.WriteLine("Maximum no is " + FloatTestCase2);
            ////FloatTestCase3
            //double FloatTestCase3 = MaximumNumberCheck.MaximumFloatNumber(32.7, 43.6, 76.8);
            //Console.WriteLine("Maximum no is " + FloatTestCase3);
            //StringTestCase1
            //string StringTestCase1 = MaximumNumberCheck.MaximumString("25", "15", "10");
            //Console.WriteLine("Maximum Number is " + StringTestCase1);
            ////StringTestCase2
            //string StringTestCase2 = MaximumNumberCheck.MaximumString("25", "45", "30");
            //Console.WriteLine("Maximum Number is " + StringTestCase2);
            ////StringTestCase3
            //string StringTestCase3 = MaximumNumberCheck.MaximumString("25", "75", "90");
            //Console.WriteLine("Maximum Number is " + StringTestCase3);

            GenericMaximum<int> maximum = new GenericMaximum<int>(45, 67, 57);
            Console.WriteLine("The maximum No is "+maximum.MaxValue());
            GenericMaximum<double> doublemaximum = new GenericMaximum<double>(45.5, 76.9, 25.7);
            Console.WriteLine("The maximum No is " + doublemaximum.MaxValue());
            GenericMaximum<string> stringmaximum = new GenericMaximum<string>("Apple","Peach","Banana");
            Console.WriteLine("The maximum No is " + stringmaximum.MaxValue());



            //int[] intarray = { 41, 23, 63, 45,76 };
            //GenericMaximum<int> generic = new GenericMaximum<int>(intarray);
            //generic.PrintMaxValue();

            //double[] doublearray = { 23.7, 36.8, 83.3, 15.5, 96.9 };
            //GenericMaximum<double> genericDouble = new GenericMaximum<double>(doublearray);
            //genericDouble.PrintMaxValue();

            //string[] stringarray = { "237", "368", "833", "155", "969" };
            //GenericMaximum<string> genericString = new GenericMaximum<string>(stringarray);
            //genericString.PrintMaxValue();
        }
    }
}
