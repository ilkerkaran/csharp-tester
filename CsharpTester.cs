namespace CsharpTester
{
  internal class Program
    {
        static void Main(string[] args)
        {
            // test RetSameNum with variable inputs
            Test<int>(5, () => RetSameNum(5));
            Test<int>(7, () => RetSameNum(7));
            Test<int>(8, () => RetSameNum(5));
            Console.WriteLine("----------------------------");
            // test FindBiggestOfList with variable inputs
            Test<int>(4, () => FindBiggestOfList(5,new List<int> { 2,2,3,4}));
            Test<int>(7, () => FindBiggestOfList(5, new List<int> { 2, 2, 3, 4 }));

            // Important, Test geeneric type should match the target functions return type
        }

        //example function
        public static int RetSameNum(int i)
        {
            return i;
        }

        // example function
        public static int FindBiggestOfList(int trashold, List<int> list) {

            return 7;
        }



        // Test invoker function
        public static (bool, object) Compare<T>(object expected, Func<T> funcToRun)
        {
            // Do stuff before running function as normal
            var res = funcToRun();
            return (expected.ToString() == res.ToString(),res);
        }

        // Test Function
        public static void Test<T>(object expected, Func<T> funcToRun)
        {
            var (isValid, result) = Compare<T>(expected, funcToRun);
            var resText = (isValid ? "OK" : "NOT OK");
             Console.WriteLine($"{resText}, Expected: {expected}, Actual: {result}");
        }
    }
}