
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_15.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Threading.Tasks;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ValueTaskAsyncReturnTest()
        {
<<<<<<< HEAD
            string expected = "http://www.IntelliTect.com..............*";
=======
            string expected = "http://www.IntelliTect.com.*";
>>>>>>> Create Async example #WIP

            IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main(Array.Empty<string>());
            });
        }
    }
}