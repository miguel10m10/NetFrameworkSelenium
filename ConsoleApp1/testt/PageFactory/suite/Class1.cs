public class AllTests
    {
        [Suite]
        public static TestSuite Suite
        {
            get
            {
                TestSuite suite = new TestSuite("All Tests");
                suite.Add(new OneTestCase());
                suite.Add(new Assemblies.AssemblyTests());
                suite.Add(new AssertionTest());
                return suite;
            }
        
    }
}