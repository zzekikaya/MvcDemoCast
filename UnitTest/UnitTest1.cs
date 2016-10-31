using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RepositoryContracts;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var context = new Mock<IMessageRepository>();
            string returnValue = "dbden okudu";
            context.Setup(x => x.SendMessage(It.IsAny<string>())).Returns(() => returnValue).Callback(() => returnValue = "World");

        }
        //private static Mock<T> MockExecuteScalar(object returnValue)
        //{
        //    Mock<DbProviderFactory> mockedDBFactory = new Mock<DbProviderFactory>();
        //    Mock<T> mockedDB = new Mock<T>("MockedDB", mockedDBFactory.Object);
        //    mockedDB.Setup(x => x.ExecuteScalar(It.IsAny<T>())).Returns(returnValue);
        //    return mockedDB;
        //}
    }

    public class HesaplaTest
    {

    }
}
