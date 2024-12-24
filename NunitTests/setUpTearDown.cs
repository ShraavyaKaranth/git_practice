namespace TestingEG.NunitTests
{
    internal class setUpTearDown
    {
        [SetUp, Order(2)]
        public void launchBrowser() 
        {
            Console.WriteLine("Browser Launched");
        }
        [SetUp, Order(1)]
        public void dbConnection()
        {
            Console.WriteLine("DB connection opened");
        }
        [TearDown, Order(2)]
        public void closeBrowser()
        {
            Console.WriteLine("Browser Closed");
        }
        [TearDown, Order(3)]
        public void closeDB()
        {
            Console.WriteLine("DB Closed");
        }
        [TearDown, Order(1)]
        public void closenetwork()
        {
            Console.WriteLine("network Closed");
        }
        [Test, Order(1)]
        public void test1()
        {
            Console.WriteLine("test1");
        }
        [Test, Order(3)]
        public void test3()
        {
            Console.WriteLine("test3");
        }
        [Test, Order(2)]
        public void test2()
        {
            Console.WriteLine("test2");
        }
    }
}
