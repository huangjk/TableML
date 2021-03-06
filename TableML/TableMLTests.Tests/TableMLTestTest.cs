using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using TableMLTests;

namespace TableMLTests.Tests
{
    /// <summary>此类包含 TableMLTest 的参数化单元测试</summary>
    [PexClass(typeof(TableMLTest))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class TableMLTestTest
    {
        /// <summary>测试 TestMultString() 的存根</summary>
        [PexMethod]
        public void TestMultStringTest([PexAssumeUnderTest]TableMLTest target)
        {
            target.TestMultString();
            // TODO: 将断言添加到 方法 TableMLTestTest.TestMultStringTest(TableMLTest)
        }
    }
}
