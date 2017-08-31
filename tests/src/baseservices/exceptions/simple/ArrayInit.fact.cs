using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _simple_ArrayInit_ArrayInit_
    {
        [OuterLoop]
        [Fact]
        public void _simple_ArrayInit_ArrayInit_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\simple\\ArrayInit\\ArrayInit.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
